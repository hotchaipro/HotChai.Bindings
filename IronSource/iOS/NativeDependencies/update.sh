#!/bin/bash
#
# Resolves Package.swift (the LevelPlay SDK, its mediation adapters and their
# network SDKs, at the exact versions it pins) and copies what the binding
# project needs next to it:
#
#   Frameworks/   the binary xcframeworks, linked by NativeReference items
#   Resources/    the resource bundles the app must contain: those inside the
#                 static frameworks (the linker doesn't copy them) and those the
#                 packages ship as SwiftPM resources
#
# UserMessagingPlatform is skipped: the HotChai.Bindings.Google.UserMessagingPlatform
# package links it.
#
# The binding project runs it when Frameworks/ is missing or out of date. After
# changing a version in Package.swift, commit Package.swift and Package.resolved
# (Frameworks/ and Resources/ aren't committed: some binaries exceed GitHub's
# file size limit).

set -euo pipefail
cd "$(dirname "$0")"

swift package resolve

rm -rf Frameworks Resources
mkdir -p Frameworks Resources

copy_bundle() {
    local bundle="$1"
    # The same bundle (IronSourcePrivacyInfo, MTGResources) ships in several places
    if [ ! -e "Resources/$(basename "$bundle")" ]; then
        cp -R "$bundle" Resources/
    fi
}

find .build/artifacts -path .build/artifacts/extract -prune -o -name "*.xcframework" -type d -prune -print | sort |
    while read -r framework; do
        name="$(basename "$framework" .xcframework)"
        if [ "$name" = "UserMessagingPlatform" ]; then
            continue
        fi
        cp -R "$framework" Frameworks/

        # A dynamic framework carries its bundles into the app itself
        binary="$framework/ios-arm64/$name.framework/$name"
        if [ -f "$binary" ] && file -b "$binary" | grep -q "dynamically linked"; then
            continue
        fi
        find "$framework/ios-arm64" -name "*.bundle" -type d -prune | while read -r bundle; do copy_bundle "$bundle"; done
    done

find .build/checkouts/*/Sources -name "*.bundle" -type d -prune | while read -r bundle; do copy_bundle "$bundle"; done

ls Frameworks Resources
