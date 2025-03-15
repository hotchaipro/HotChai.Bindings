# CocoaPods: https://cocoapods.org
pod update

# Sharpie: http://xmn.io/sharpie-docs
# sharpie xcode -sdks
sharpie bind -sdk iphoneos18.2 -f ./Pods/IronSourceSDK/IronSource/IronSource.xcframework/ios-arm64/IronSource.framework -namespace IronSourceSdk
