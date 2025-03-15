# CocoaPods: https://cocoapods.org
pod update

# Sharpie: http://xmn.io/sharpie-docs
# sharpie xcode -sdks
sharpie bind -sdk iphoneos18.2 -f ./Pods/GA-SDK-IOS/GameAnalytics.xcframework/ios-arm64/GameAnalytics.framework -namespace GameAnalyticsSdk
