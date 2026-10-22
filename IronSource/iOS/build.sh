#!/bin/bash
#
# Regenerates the binding definitions (ApiDefinition.cs, StructsAndEnums.cs,
# BgenDelegates.cs) from the LevelPlay SDK's headers, with the Objective-C
# generator of Swift Bindings (https://github.com/justinwojo/swift-dotnet-bindings).
#
# The generator ships in the SwiftBindings.Sdk package; this script fetches the
# pinned version from nuget.org into the package cache on first use.
#
# Run it after NativeDependencies/update.sh changes IronSource.xcframework, then
# review the diff: renamed or removed members break IronSourceAdProvider in
# HotChai.Platform.

set -euo pipefail
cd "$(dirname "$0")"

SWIFT_BINDINGS_VERSION=0.20.0

# Methods the generator names the same within one type, renamed by selector
# (https://github.com/justinwojo/swift-dotnet-bindings/issues/47)
RENAMES=(
    # LevelPlayNativeAdDelegate inherits didLoad:withAdInfo: as WithAdInfo too
    "didRecordImpression:withAdInfo:=DidRecordImpressionWithAdInfo"
)

packages="${NUGET_PACKAGES:-$HOME/.nuget/packages}"
sdk="$packages/swiftbindings.sdk/$SWIFT_BINDINGS_VERSION"
generator="$sdk/tools/net10.0/any/Swift.Bindings.dll"

if [ ! -f "$generator" ]; then
    echo "Fetching SwiftBindings.Sdk $SWIFT_BINDINGS_VERSION"
    mkdir -p "$sdk"
    nupkg="$sdk/swiftbindings.sdk.$SWIFT_BINDINGS_VERSION.nupkg"
    curl -fsSL -o "$nupkg" "https://api.nuget.org/v3-flatcontainer/swiftbindings.sdk/$SWIFT_BINDINGS_VERSION/swiftbindings.sdk.$SWIFT_BINDINGS_VERSION.nupkg"
    unzip -qo "$nupkg" -d "$sdk"
fi

output="$(mktemp -d)"
trap 'rm -rf "$output"' EXIT

dotnet "$generator" \
    --xcframework NativeDependencies/Frameworks/IronSource.xcframework \
    --objc \
    --sdk-mode \
    --namespace-pattern 'IronSourceSdk' \
    -o "$output"

# Class methods named init... that the generator binds as constructors, rebound
# as static methods with these names
# (https://github.com/justinwojo/swift-dotnet-bindings/issues/48)
STATIC_INITS=(
    # +[LevelPlay initWithRequest:completion:], +[IronSourceAds initWithRequest:completion:]
    "initWithRequest:completion:=InitWithRequest"
)

for rebind in "${STATIC_INITS[@]}"; do
    selector="${rebind%%=*}" name="${rebind#*=}" \
        perl -0pi -e 's/^(\s*)(\[Export\("\Q$ENV{selector}\E"\)\]\s*\n\s*)NativeHandle Constructor\(/$1\[Static\]\n$1$2void $ENV{name}(/mg or die "constructor $ENV{selector} not found\n"' \
        "$output/ApiDefinition.cs"
done

# Rename the method declared after each selector's [Export]
for rename in "${RENAMES[@]}"; do
    selector="${rename%%=*}" name="${rename#*=}" \
        perl -0pi -e 's/(\[Export\("\Q$ENV{selector}\E"\)\]\s*\n\s*[^\n(]*?\s)\w+(\()/$1$ENV{name}$2/g or die "selector $ENV{selector} not found\n"' \
        "$output/ApiDefinition.cs"
done

cp "$output/ApiDefinition.cs" "$output/StructsAndEnums.cs" "$output/BgenDelegates.cs" .
