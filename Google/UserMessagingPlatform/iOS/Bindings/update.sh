﻿# CocoaPods: https://cocoapods.org
pod update

# Sharpie: http://xmn.io/sharpie-docs
# sharpie xcode -sdks
sharpie bind -sdk iphoneos17.4 -f ./Pods/GoogleUserMessagingPlatform/Frameworks/Release/UserMessagingPlatform.xcframework/ios-arm64/UserMessagingPlatform.framework -namespace Google.UserMessagingPlatform
