// swift-tools-version: 6.0

// Pins the LevelPlay (IronSource) SDK and its mediation adapters, each of which
// pins its network SDK. Not built: update.sh resolves it and copies the binary
// xcframeworks next to this file, where the binding project links them.

import PackageDescription

let package = Package(
  name: "IronSourceNativeDependencies",
  platforms: [.iOS(.v15)],
  dependencies: [
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-Swift-Package", exact: "9.7.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-AdMob-Adapter-Swift-Package", exact: "5.17.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-AppLovin-Adapter-Swift-Package", exact: "5.9.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-Facebook-Adapter-Swift-Package", exact: "5.6.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-Fyber-Adapter-Swift-Package", exact: "5.14.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-InMobi-Adapter-Swift-Package", exact: "5.10.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-Mintegral-Adapter-Swift-Package", exact: "5.22.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-Pangle-Adapter-Swift-Package", exact: "5.37.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-UnityAds-Adapter-Swift-Package", exact: "5.13.0"),
    .package(url: "https://github.com/ironsource-mobile/LevelPlay-Vungle-Adapter-Swift-Package", exact: "5.16.0"),
  ],
  targets: [
    .target(
      name: "Resolve",
      dependencies: [
        .product(name: "UnityMediationSDK", package: "LevelPlay-Swift-Package"),
        .product(name: "AdMobAdapter", package: "LevelPlay-AdMob-Adapter-Swift-Package"),
        .product(name: "AppLovinAdapter", package: "LevelPlay-AppLovin-Adapter-Swift-Package"),
        .product(name: "FacebookAdapter", package: "LevelPlay-Facebook-Adapter-Swift-Package"),
        .product(name: "FyberAdapter", package: "LevelPlay-Fyber-Adapter-Swift-Package"),
        .product(name: "InMobiAdapter", package: "LevelPlay-InMobi-Adapter-Swift-Package"),
        .product(name: "MintegralAdapter", package: "LevelPlay-Mintegral-Adapter-Swift-Package"),
        .product(name: "PangleAdapter", package: "LevelPlay-Pangle-Adapter-Swift-Package"),
        .product(name: "UnityAdsAdapter", package: "LevelPlay-UnityAds-Adapter-Swift-Package"),
        .product(name: "VungleAdapter", package: "LevelPlay-Vungle-Adapter-Swift-Package"),
      ]),
  ]
)
