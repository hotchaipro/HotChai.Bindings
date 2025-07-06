@echo off

:: Clean and update Gradle native dependencies
del /q %~dp0NativeDependencies\*
call "%ProgramFiles%\Gradle\bin\gradle.bat" update

:: Map 'gradle dependencies' to Xamarin NuGet packages where possible

:: +--- com.google.android.gms:play-services-ads-identifier -> Xamarin.GooglePlayServices.Ads.Identifier (#)
:: +--- com.jakewharton.threetenabp:threetenabp
:: |    \--- org.threeten:threetenbp
:: +--- com.unity3d.ads-mediation:mediation-sdk
:: |    +--- com.unity3d.ads-mediation:adquality-sdk
:: |    \--- org.jetbrains.kotlin:kotlin-stdlib -> Xamarin.Kotlin.StdLib (#)
:: +--- com.unity3d.ads-mediation:adquality-sdk
:: +--- com.unity3d.ads-mediation:applovin-adapter
:: +--- com.applovin:applovin-sdk
:: |    +--- com.google.android.gms:play-services-ads-identifier -> Xamarin.GooglePlayServices.Ads.Identifier (*)
:: |    +--- com.google.android.gms:play-services-appset -> Xamarin.GooglePlayServices.AppSet (#)
:: |    \--- androidx.browser:browser -> Xamarin.AndroidX.Browser (#)
:: +--- com.unity3d.ads-mediation:fyber-adapter
:: +--- com.fyber:marketplace-sdk
:: |    \--- com.fyber.omsdk:om-sdk
:: +--- com.unity3d.ads-mediation:facebook-adapter
:: +--- com.facebook.android:audience-network-sdk
:: |    \--- com.google.android.gms:play-services-basement -> Xamarin.GooglePlayServices.Basement (*)
:: +--- com.unity3d.ads-mediation:admob-adapter
:: +--- com.google.android.gms:play-services-ads -> Xamarin.GooglePlayServices.Ads (#)
:: +--- com.unity3d.ads-mediation:inmobi-adapter
:: +--- com.inmobi.monetization:inmobi-ads-kotlin
:: |    +--- com.inmobi.omsdk:inmobi-omsdk
:: |    +--- com.google.android.gms:play-services-ads-identifier -> Xamarin.GooglePlayServices.Ads.Identifier (*)
:: |    +--- androidx.recyclerview:recyclerview -> Xamarin.AndroidX.RecyclerView (#)
:: |    +--- com.squareup.picasso:picasso -> Square.Picasso (#)
:: |    |    +--- com.squareup.okhttp3:okhttp -> Square.OkHttp3 (#)
:: |    |    +--- androidx.annotation:annotation
:: |    |    \--- androidx.exifinterface:exifinterface
:: |    +--- androidx.browser:browser -> Xamarin.AndroidX.Browser (*)
:: |    +--- androidx.core:core-ktx -> Xamarin.AndroidX.Activity.Ktx (*)
:: |    +--- com.google.android.gms:play-services-appset -> Xamarin.GooglePlayServices.AppSet (*)
:: |    +--- com.google.android.gms:play-services-tasks -> Xamarin.GooglePlayServices.Basement (*)
:: |    \--- org.jetbrains.kotlin:kotlin-stdlib -> Xamarin.Kotlin.StdLib (*)
:: +--- com.unity3d.ads-mediation:vungle-adapter
:: +--- com.vungle:vungle-ads
:: |    +--- androidx.annotation:annotation -> Xamarin.AndroidX.Annotation (*)
:: |    +--- androidx.core:core-ktx -> Xamarin.AndroidX.Core.Core.Ktx (*)
:: |    +--- com.squareup.okhttp3:okhttp -> Square.OkHttp3 (*)
:: |    +--- com.squareup.okio:okio-jvm -> Square.OkIO.JVM (*)
:: |    +--- org.jetbrains.kotlinx:kotlinx-serialization-core-jvm -> Xamarin.KotlinX.Serialization.Core.Jvm (#)
:: |    +--- org.jetbrains.kotlinx:kotlinx-serialization-json-jvm -> Xamarin.KotlinX.Serialization.Json.Jvm (#)
:: |    \--- com.google.protobuf:protobuf-javalite -> Xamarin.Protobuf.JavaLite (#)
:: +--- com.unity3d.ads-mediation:mintegral-adapter
:: +--- com.mbridge.msdk.oversea:mbridge_android_sdk
:: +--- com.unity3d.ads-mediation:pangle-adapter
:: +--- com.pangle.global:ads-sdk
:: |    +--- com.pangle.global:pag-apm
:: |    +--- com.pangle.global:gecko_pgl
:: |    \--- androidx.browser:browser -> Xamarin.AndroidX.Browser (*)
:: +--- com.unity3d.ads-mediation:unityads-adapter
:: \--- com.unity3d.ads:unity-ads
::      +--- androidx.activity:activity-ktx -> Xamarin.AndroidX.Activity.Ktx (#)
::      +--- androidx.core:core-ktx -> Xamarin.AndroidX.Core.Core.Ktx (*)
::      +--- androidx.lifecycle:lifecycle-process -> Xamarin.AndroidX.Lifecycle.Process (#)
::      +--- androidx.lifecycle:lifecycle-runtime-ktx -> Xamarin.AndroidX.Lifecycle.Runtime.Ktx (#)
::      +--- androidx.startup:startup-runtime -> Xamarin.AndroidX.Startup.StartupRuntime (*)
::      +--- androidx.webkit:webkit -> Xamarin.AndroidX.WebKit (*)
::      +--- androidx.datastore:datastore -> Xamarin.AndroidX.DataStore (#)
::      +--- org.jetbrains.kotlinx:kotlinx-coroutines-android -> Xamarin.KotlinX.Coroutines.Android (*)
::      +--- org.jetbrains.kotlin:kotlin-stdlib-jdk8 -> Xamarin.Kotlin.StdLib.Jdk8 (*)
::      +--- com.squareup.okhttp3:okhttp -> Square.OkHttp3 (*)
::      +--- com.google.protobuf:protobuf-kotlin-lite
::      +--- androidx.work:work-runtime-ktx -> Xamarin.AndroidX.Work.Work.Runtime.Ktx (*)
::      \--- com.google.android.gms:play-services-cronet -> Xamarin.GooglePlayServices.CroNet (#)
::
:: (#) Gradle dependency mapped to a NuGet package
:: (*) NuGet package dependency listed previously

:: Remove dependencies already included in NuGet packages

:: Xamarin.AndroidX.Activity.Ktx (androidx.activity:activity-ktx)
del %~dp0NativeDependencies\activity-*.aar
del %~dp0NativeDependencies\annotation-experimental-*.aar
del %~dp0NativeDependencies\annotation-jvm-*.jar
del %~dp0NativeDependencies\annotations-*.jar
del %~dp0NativeDependencies\collection-*.jar
del %~dp0NativeDependencies\concurrent-futures-*.jar
del %~dp0NativeDependencies\core-common-*.jar
del %~dp0NativeDependencies\core-ktx-*.aar
del %~dp0NativeDependencies\core-runtime-*.aar
del %~dp0NativeDependencies\core-*.aar
del %~dp0NativeDependencies\interpolator-*.aar
del %~dp0NativeDependencies\kotlin-stdlib-jdk7-*.jar
del %~dp0NativeDependencies\kotlin-stdlib-jdk8-*.jar
del %~dp0NativeDependencies\kotlin-stdlib-*.jar
del %~dp0NativeDependencies\kotlinx-coroutines-android-*.jar
del %~dp0NativeDependencies\kotlinx-coroutines-core-jvm-*.jar
del %~dp0NativeDependencies\lifecycle-common-*.jar
del %~dp0NativeDependencies\lifecycle-livedata-core-*.aar
del %~dp0NativeDependencies\lifecycle-livedata-*.aar
del %~dp0NativeDependencies\lifecycle-runtime-ktx-*.aar
del %~dp0NativeDependencies\lifecycle-runtime-*.aar
del %~dp0NativeDependencies\lifecycle-viewmodel-ktx-*.aar
del %~dp0NativeDependencies\lifecycle-viewmodel-savedstate-*.aar
del %~dp0NativeDependencies\lifecycle-viewmodel-*.aar
del %~dp0NativeDependencies\listenablefuture-*.jar
del %~dp0NativeDependencies\profileinstaller-*.aar
del %~dp0NativeDependencies\savedstate-ktx-*.aar
del %~dp0NativeDependencies\savedstate-*.aar
del %~dp0NativeDependencies\startup-runtime-*.aar
del %~dp0NativeDependencies\tracing-*.aar
del %~dp0NativeDependencies\versionedparcelable-*.aar

:: Xamarin.AndroidX.Browser (androidx.browser:browser)
del %~dp0NativeDependencies\browser-*.aar

:: Xamarin.AndroidX.DataStore (androidx.datastore:datastore)
del %~dp0NativeDependencies\datastore-core-*.jar
del %~dp0NativeDependencies\datastore-*.aar

:: Xamarin.AndroidX.Lifecycle.Process (androidx.lifecycle:lifecycle-process)
del %~dp0NativeDependencies\lifecycle-process-*.aar

:: Xamarin.AndroidX.RecyclerView (androidx.recyclerview:recyclerview)
del %~dp0NativeDependencies\customview-*.aar
del %~dp0NativeDependencies\recyclerview-*.aar

:: Xamarin.AndroidX.Work.Work.Runtime.Ktx (androidx.work:work-runtime-ktx)
del %~dp0NativeDependencies\lifecycle-service-*.aar
del %~dp0NativeDependencies\room-common-*.jar
del %~dp0NativeDependencies\room-runtime-*.aar
del %~dp0NativeDependencies\sqlite-framework-*.aar
del %~dp0NativeDependencies\sqlite-*.aar
del %~dp0NativeDependencies\work-runtime-ktx-*.aar
del %~dp0NativeDependencies\work-runtime-*.aar

:: Xamarin.GooglePlayServices.Ads.Identifier (com.google.android.gms:play-services-ads-identifier)
del %~dp0NativeDependencies\fragment-*.aar
del %~dp0NativeDependencies\loader-*.aar
del %~dp0NativeDependencies\play-services-ads-identifier-*.aar
del %~dp0NativeDependencies\play-services-base-*.aar
del %~dp0NativeDependencies\play-services-basement-*.aar
del %~dp0NativeDependencies\play-services-tasks-*.aar
del %~dp0NativeDependencies\viewpager-*.aar

:: Xamarin.GooglePlayServices.Ads (com.google.android.gms:play-services-ads)
del %~dp0NativeDependencies\ads-adservices-java-*.aar
del %~dp0NativeDependencies\ads-adservices-*.aar
del %~dp0NativeDependencies\checker-qual-*.jar
del %~dp0NativeDependencies\error_prone_annotations-*.jar
del %~dp0NativeDependencies\failureaccess-*.jar
del %~dp0NativeDependencies\guava-*-android.jar
del %~dp0NativeDependencies\j2objc-annotations-*.jar
del %~dp0NativeDependencies\jsr305-*.jar
del %~dp0NativeDependencies\play-services-ads-api-*.aar
del %~dp0NativeDependencies\play-services-ads-*.aar
del %~dp0NativeDependencies\play-services-appset-*.aar
del %~dp0NativeDependencies\play-services-measurement-base-*.aar
del %~dp0NativeDependencies\play-services-measurement-sdk-api-*.aar
del %~dp0NativeDependencies\user-messaging-platform-*.aar
del %~dp0NativeDependencies\webkit-*.aar

:: Xamarin.GooglePlayServices.CroNet (com.google.android.gms:play-services-cronet)
del %~dp0NativeDependencies\cronet-api-*.aar
del %~dp0NativeDependencies\play-services-cronet-*.aar

:: Xamarin.KotlinX.Serialization.Core.Jvm (org.jetbrains.kotlinx:kotlinx-serialization-core-jvm)
del %~dp0NativeDependencies\kotlinx-serialization-core-jvm-*.jar

:: Xamarin.KotlinX.Serialization.Json.Jvm (org.jetbrains.kotlinx:kotlinx-serialization-json-jvm)
del %~dp0NativeDependencies\kotlinx-serialization-json-jvm-*.jar

:: Square.OkIO.JVM (com.squareup.okio:okio-jvm)
del %~dp0NativeDependencies\okio-jvm-*.jar

:: Square.OkHttp3 (com.squareup.okhttp3:okhttp)
del %~dp0NativeDependencies\okhttp-*.jar
del %~dp0NativeDependencies\okio-*.jar

:: Square.Picasso (com.squareup.picasso:picasso)
del %~dp0NativeDependencies\exifinterface-*.aar
del %~dp0NativeDependencies\picasso-*.aar

:: Xamarin.Protobuf.JavaLite (com.google.protobuf:protobuf-javalite)
del %~dp0NativeDependencies\protobuf-javalite-*.jar

:: HotChai.Bindings.Protobuf.Kotlin.Lite (com.google.protobuf:protobuf-kotlin-lite)
del %~dp0NativeDependencies\protobuf-kotlin-lite-*.jar
