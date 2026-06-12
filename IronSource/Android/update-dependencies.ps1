<#
.SYNOPSIS
	Updates the ironSource native Android dependencies using Gradle and removes
	the files that are already provided by the NuGet package references in
	HotChai.Bindings.IronSource.Android.csproj.

.DESCRIPTION
	The mediation SDKs and network adapters are downloaded into NativeDependencies
	by the 'update' task in build.gradle. Many of the transitive dependencies that
	Gradle resolves (AndroidX, Google Play services, Kotlin, Square, protobuf, ...)
	are also provided by the Microsoft/Square binding NuGet packages referenced by
	the project. Shipping both copies causes duplicate types at bind/build time, so
	this script deletes every file that a referenced NuGet package already provides.

	Only the SDK and adapter artifacts that have no equivalent NuGet binding are
	kept. Any downloaded file that is neither mapped to a NuGet package nor part of
	the keep-set is reported as a warning so it can be evaluated.

.PARAMETER SkipGradleUpdate
	Re-runs the pruning step only, without cleaning and re-downloading via Gradle.

.PARAMETER DryRun
	Lists what would be deleted/kept without modifying any files.

.NOTES
	Keep the NuGet -> file mapping below in sync with the PackageReference items in
	HotChai.Bindings.IronSource.Android.csproj.
#>
[CmdletBinding()]
param(
	[switch]$SkipGradleUpdate,
	[switch]$DryRun
)

$ErrorActionPreference = 'Stop'

$scriptRoot = Split-Path -Parent $MyInvocation.MyCommand.Definition
$nativeDir = Join-Path $scriptRoot 'NativeDependencies'

# Files provided by a referenced NuGet package (grouped by the providing package).
# Each value is a list of file name patterns to delete from NativeDependencies.
$nugetProvided = [ordered]@{
	'Xamarin.AndroidX.Activity.Ktx' = @(
		'activity-ktx-*.aar', 'activity-*.aar',
		'annotation-experimental-*.aar', 'annotation-jvm-*.jar', 'annotations-*.jar',
		'collection-*.jar', 'concurrent-futures-*.jar',
		'core-common-*.jar', 'core-ktx-*.aar', 'core-runtime-*.aar', 'core-*.aar',
		'interpolator-*.aar',
		'kotlin-stdlib-jdk7-*.jar', 'kotlin-stdlib-jdk8-*.jar', 'kotlin-stdlib-*.jar',
		'kotlinx-coroutines-android-*.jar', 'kotlinx-coroutines-core-jvm-*.jar',
		'lifecycle-common-*.jar',
		'lifecycle-livedata-core-*.aar', 'lifecycle-livedata-*.aar',
		'lifecycle-runtime-ktx-*.aar', 'lifecycle-runtime-*.aar',
		'lifecycle-viewmodel-ktx-*.aar', 'lifecycle-viewmodel-savedstate-*.aar', 'lifecycle-viewmodel-*.aar',
		'listenablefuture-*.jar', 'profileinstaller-*.aar',
		'savedstate-ktx-*.aar', 'savedstate-*.aar',
		'startup-runtime-*.aar', 'tracing-*.aar', 'versionedparcelable-*.aar'
	)
	'Xamarin.AndroidX.Browser' = @(
		'browser-*.aar'
	)
	'Xamarin.AndroidX.DataStore' = @(
		'datastore-core-*.jar', 'datastore-*.aar'
	)
	'Xamarin.AndroidX.Lifecycle.Process' = @(
		'lifecycle-process-*.aar'
	)
	'Xamarin.AndroidX.RecyclerView' = @(
		'customview-*.aar', 'recyclerview-*.aar'
	)
	'Xamarin.AndroidX.Work.Work.Runtime.Ktx' = @(
		'lifecycle-service-*.aar',
		'room-common-*.jar', 'room-runtime-*.aar',
		'sqlite-framework-*.aar', 'sqlite-*.aar',
		'work-runtime-ktx-*.aar', 'work-runtime-*.aar'
	)
	'Xamarin.GooglePlayServices.Ads.Identifier' = @(
		'fragment-*.aar', 'loader-*.aar', 'viewpager-*.aar',
		'play-services-ads-identifier-*.aar',
		'play-services-base-*.aar', 'play-services-basement-*.aar', 'play-services-tasks-*.aar'
	)
	'Xamarin.GooglePlayServices.Ads' = @(
		'ads-adservices-java-*.aar', 'ads-adservices-*.aar',
		'checker-qual-*.jar', 'error_prone_annotations-*.jar', 'failureaccess-*.jar',
		'guava-*-android.jar', 'j2objc-annotations-*.jar', 'jsr305-*.jar',
		'play-services-ads-api-*.aar', 'play-services-ads-*.aar',
		'play-services-appset-*.aar',
		'play-services-measurement-base-*.aar', 'play-services-measurement-sdk-api-*.aar',
		'user-messaging-platform-*.aar', 'webkit-*.aar'
	)
	'Xamarin.GooglePlayServices.CroNet' = @(
		'cronet-api-*.aar', 'play-services-cronet-*.aar'
	)
	'Xamarin.KotlinX.Serialization.Core.Jvm' = @(
		'kotlinx-serialization-core-jvm-*.jar'
	)
	'Xamarin.KotlinX.Serialization.Json.Jvm' = @(
		'kotlinx-serialization-json-jvm-*.jar'
	)
	'Square.OkHttp3' = @(
		'okhttp-*.jar'
	)
	'Square.OkIO' = @(
		'okio-jvm-*.jar'
	)
	'Square.Picasso' = @(
		'exifinterface-*.aar', 'picasso-*.aar'
	)
	'Xamarin.Protobuf.JavaLite' = @(
		'protobuf-javalite-*.jar'
	)
	'HotChai.Bindings.Protobuf.Kotlin.Lite' = @(
		'protobuf-kotlin-lite-*.jar'
	)
}

# SDK / adapter artifacts that have no equivalent NuGet binding and must be kept.
$keepPrefixes = @(
	'mediation-sdk-', 'adquality-sdk-',
	'applovin-adapter-', 'applovin-sdk-',
	'fyber-adapter-', 'marketplace-sdk-', 'om-sdk-',
	'admob-adapter-',
	'inmobi-adapter-',
	'vungle-adapter-', 'vungle-ads-',
	'facebook-adapter-', 'audience-network-sdk-',
	'mintegral-adapter-', 'mbridge_android_sdk-',
	'pangle-adapter-', 'pag-sdk-', 'pag-apm-', 'pag-gecko-', 'tiktok-business-android-sdk-comp-',
	'unityads-adapter-', 'unity-ads-'
)

function Resolve-Gradle {
	if ($env:GRADLE_HOME -and (Test-Path (Join-Path $env:GRADLE_HOME 'bin\gradle.bat'))) {
		return (Join-Path $env:GRADLE_HOME 'bin\gradle.bat')
	}
	$programFilesGradle = Join-Path $env:ProgramFiles 'Gradle\bin\gradle.bat'
	if (Test-Path $programFilesGradle) {
		return $programFilesGradle
	}
	$onPath = Get-Command 'gradle' -ErrorAction SilentlyContinue
	if ($onPath) {
		return $onPath.Source
	}
	throw "Unable to locate Gradle. Set GRADLE_HOME, install to '$env:ProgramFiles\Gradle', or add 'gradle' to PATH."
}

function Test-IsKept {
	param([string]$Name)
	foreach ($prefix in $keepPrefixes) {
		if ($Name.StartsWith($prefix)) { return $true }
	}
	return $false
}

Write-Host "Native dependencies folder: $nativeDir"

if (-not $SkipGradleUpdate) {
	$gradle = Resolve-Gradle
	Write-Host "Using Gradle: $gradle"

	if (-not $DryRun) {
		if (Test-Path $nativeDir) {
			Write-Host 'Cleaning NativeDependencies...'
			Get-ChildItem -Path $nativeDir -File | Remove-Item -Force
		}
		else {
			New-Item -ItemType Directory -Path $nativeDir | Out-Null
		}

		Write-Host 'Running Gradle update...'
		& $gradle update --project-dir $scriptRoot --console=plain
		if ($LASTEXITCODE -ne 0) {
			throw "Gradle update failed with exit code $LASTEXITCODE."
		}
	}
	else {
		Write-Host '[DryRun] Skipping clean and Gradle update.'
	}
}
else {
	Write-Host 'Skipping Gradle update (re-pruning existing files only).'
}

if (-not (Test-Path $nativeDir)) {
	throw "NativeDependencies folder not found: $nativeDir"
}

Write-Host ''
Write-Host 'Removing files already provided by NuGet package references...'

$deletedCount = 0
foreach ($package in $nugetProvided.Keys) {
	$matched = New-Object System.Collections.Generic.List[string]
	foreach ($pattern in $nugetProvided[$package]) {
		foreach ($file in (Get-ChildItem -Path $nativeDir -Filter $pattern -File -ErrorAction SilentlyContinue)) {
			if (-not $matched.Contains($file.Name)) {
				$matched.Add($file.Name)
			}
		}
	}
	if ($matched.Count -gt 0) {
		Write-Host ("  {0}" -f $package)
		foreach ($name in ($matched | Sort-Object)) {
			Write-Host ("    - {0}" -f $name)
			if (-not $DryRun) {
				Remove-Item -Path (Join-Path $nativeDir $name) -Force
			}
			$deletedCount++
		}
	}
}

Write-Host ''
Write-Host 'Verifying remaining files...'

$kept = New-Object System.Collections.Generic.List[string]
$unmapped = New-Object System.Collections.Generic.List[string]
foreach ($file in (Get-ChildItem -Path $nativeDir -File | Sort-Object Name)) {
	if (Test-IsKept $file.Name) {
		$kept.Add($file.Name)
	}
	else {
		$unmapped.Add($file.Name)
	}
}

foreach ($name in $kept) {
	Write-Host ("  kept: {0}" -f $name)
}

if ($unmapped.Count -gt 0) {
	Write-Warning 'The following native dependencies are not mapped to a NuGet package and are not in the keep-set.'
	Write-Warning 'Evaluate whether a NuGet package already provides them (delete) or they are a new SDK (keep).'
	foreach ($name in $unmapped) {
		Write-Warning ("  unmapped: {0}" -f $name)
	}
}

Write-Host ''
Write-Host ("Done. Removed {0} NuGet-provided file(s); kept {1} SDK/adapter file(s)." -f $deletedCount, $kept.Count)
if ($DryRun) {
	Write-Host '(DryRun: no files were actually modified.)'
}
