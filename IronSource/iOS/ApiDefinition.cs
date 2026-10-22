using System;
using AuthenticationServices;
using AVFoundation;
using BackgroundAssets;
using CoreAnimation;
using CoreFoundation;
using CoreImage;
using CoreLocation;
using CoreMedia;
using Foundation;
using ImageIO;
using MapKit;
using Metal;
using ObjCRuntime;
using OpenGLES;
using CoreGraphics;
using UIKit;
using UserNotifications;
using WebKit;

namespace IronSourceSdk
{
    interface IISABannerAdViewDelegate { }
    interface IISABannerAdLoaderDelegate { }
    interface IISAInterstitialAdDelegate { }
    interface IISAInterstitialAdLoaderDelegate { }
    interface IISARewardedAdDelegate { }
    interface IISARewardedAdLoaderDelegate { }
    interface IISAdapterAdaptiveProtocol { }
    interface IISDemandOnlyBannerDelegate { }
    interface IISDemandOnlyInterstitialDelegate { }
    interface IISDemandOnlyRewardedVideoDelegate { }
    interface ILPMDispatcherProtocol { }
    interface ILPMImpressionDataDelegate { }
    interface IISAdapterAdDelegate { }
    interface IISAdapterAdViewDelegate { }
    interface IISBannerAdDelegate { }
    interface IISAdapterBannerProtocol { }
    interface IISNetworkInitializationDelegate { }
    interface IISAdapterBaseProtocol { }
    interface IISAdapterAdInteractionDelegate { }
    interface IISAdapterAdFullscreenProtocol { }
    interface IISInterstitialAdDelegate { }
    interface IISNativeAdDataProtocol { }
    interface IISNativeAdViewBinderProtocol { }
    interface IISAdapterNativeAdViewBinderProtocol { }
    interface IISNativeAdDelegate { }
    interface IISAdapterNativeAdProtocol { }
    interface IISAdapterConsentProtocol { }
    interface IISAdapterDebugProtocol { }
    interface IISAdapterMetaDataProtocol { }
    interface IISAdapterNetworkData { }
    interface IISAdapterNetworkDataProtocol { }
    interface IISAdapterAdRewardedDelegate { }
    interface IISRewardedVideoAdDelegate { }
    interface IISSetAPSDataProtocol { }
    interface IISAdapterTestModeProtocol { }
    interface IISBiddingDataDelegate { }
    interface IISBiddingDataProtocol { }
    interface IISNativeAdProtocol { }
    interface IISNativeAdInteractionDelegate { }
    interface IISNativeAdLoadDelegate { }
    interface ILevelPlayNativeAdDelegate { }
    interface ILPMBannerAdViewDelegate { }
    interface ILPMInterstitialAdDelegate { }
    interface ILPMRewardedAdDelegate { }
    interface IISNAppStoreVCRootViewDelegate { }
    interface IISAppStoreErrorDelegate { }
    interface IISNetworkInitCallbackProtocol { }
    interface IISAdUnitAdapterProtocol { }
    interface IISNativeAdAdapterDelegate { }
    interface IISNativeAdAdapterProtocol { }
    interface IISBannerAdapterDelegate { }
    interface IISBannerAdapterProtocol { }
    interface ILPMThreadSafeDictionaryProtocol { }
    interface IISInterstitialAdapterDelegate { }
    interface IISInterstitialAdapterProtocol { }
    interface IISRewardedVideoAdapterDelegate { }
    interface IISRewardedVideoAdapterProtocol { }
    interface IISNAdViewsManagerSwiftFacadeProtocol { }
    interface IISNControllerMessageListener { }
    interface IISNEventTrackerInterface { }

    /// <summary>
    /// Protocol handling banner ad show events for `ISABannerAd`. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISABannerAdViewDelegate
    {
        /// <summary>
        /// Called when a banner ad is shown.
        /// </summary>
        /// <param name="bannerAdView">The banner ad that is shown.</param>
        [Abstract]
        [Export("bannerAdViewDidShow:")]
        void DidShow(ISABannerAdView bannerAdView);

        /// <summary>
        /// Called when a banner ad is clicked.
        /// </summary>
        /// <param name="bannerAdView">The banner ad that is clicked.</param>
        [Abstract]
        [Export("bannerAdViewDidClick:")]
        void DidClick(ISABannerAdView bannerAdView);

    }

    /// <summary>
    /// Protocol handling loading callbacks for a requested banner ad. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISABannerAdLoaderDelegate
    {
        /// <summary>
        /// Called when a banner ad is successfully loaded.
        /// </summary>
        /// <param name="bannerAdView">The banner ad that is loaded.</param>
        [Abstract]
        [Export("bannerAdDidLoad:")]
        void BannerAdDidLoad(ISABannerAdView bannerAdView);

        /// <summary>
        /// Called when a banner ad fails to load.
        /// </summary>
        /// <param name="error">The error that occurred during loading.</param>
        [Abstract]
        [Export("bannerAdDidFailToLoadWithError:")]
        void BannerAdDidFailToLoadWithError(NSError error);

    }

    /// <summary>
    /// Protocol handling interstitial ad show events for `ISAInterstitialAd`. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISAInterstitialAdDelegate
    {
        /// <summary>
        /// Called when an interstitial ad is shown.
        /// </summary>
        /// <param name="interstitialAd">The interstitial ad that is shown.</param>
        [Abstract]
        [Export("interstitialAdDidShow:")]
        void DidShow(ISAInterstitialAd interstitialAd);

        /// <summary>
        /// Called when an interstitial ad fails to show.
        /// </summary>
        /// <param name="interstitialAd">The interstitial ad that fails to show.</param>
        /// <param name="error">The error that occurred.</param>
        [Abstract]
        [Export("interstitialAd:didFailToShowWithError:")]
        void DidFailToShowWithError(ISAInterstitialAd interstitialAd, NSError error);

        /// <summary>
        /// Called when an interstitial ad is clicked.
        /// </summary>
        /// <param name="interstitialAd">The interstitial ad that is clicked.</param>
        [Abstract]
        [Export("interstitialAdDidClick:")]
        void DidClick(ISAInterstitialAd interstitialAd);

        /// <summary>
        /// Called when an interstitial ad is dismissed.
        /// </summary>
        /// <param name="interstitialAd">The interstitial ad that is dismissed.</param>
        [Abstract]
        [Export("interstitialAdDidDismiss:")]
        void DidDismiss(ISAInterstitialAd interstitialAd);

    }

    /// <summary>
    /// Protocol handling loading callbacks for a requested interstitial ad. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISAInterstitialAdLoaderDelegate
    {
        /// <summary>
        /// Called when an interstitial ad is successfully loaded.
        /// </summary>
        /// <param name="interstitialAd">The interstitial ad that is loaded.</param>
        [Abstract]
        [Export("interstitialAdDidLoad:")]
        void InterstitialAdDidLoad(ISAInterstitialAd interstitialAd);

        /// <summary>
        /// Called when an interstitial ad fails to load.
        /// </summary>
        /// <param name="error">The error that occurred during loading.</param>
        [Abstract]
        [Export("interstitialAdDidFailToLoadWithError:")]
        void InterstitialAdDidFailToLoadWithError(NSError error);

    }

    /// <summary>
    /// Protocol handling rewarded ad show events for `ISARewardedAd`. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISARewardedAdDelegate
    {
        /// <summary>
        /// Called when a rewarded ad is shown.
        /// </summary>
        /// <param name="rewardedAd">The rewarded ad that is shown.</param>
        [Abstract]
        [Export("rewardedAdDidShow:")]
        void DidShow(ISARewardedAd rewardedAd);

        /// <summary>
        /// Called when a rewarded ad fails to show.
        /// </summary>
        /// <param name="rewardedAd">The rewarded ad that fails to show.</param>
        /// <param name="error">The error that occurred.</param>
        [Abstract]
        [Export("rewardedAd:didFailToShowWithError:")]
        void DidFailToShowWithError(ISARewardedAd rewardedAd, NSError error);

        /// <summary>
        /// Called when the user earns a reward.
        /// </summary>
        /// <param name="rewardedAd">The rewarded ad that the user earns a reward from.</param>
        [Abstract]
        [Export("rewardedAdDidUserEarnReward:")]
        void DidUserEarnReward(ISARewardedAd rewardedAd);

        /// <summary>
        /// Called when a rewarded ad is clicked.
        /// </summary>
        /// <param name="rewardedAd">The rewarded ad that is clicked.</param>
        [Abstract]
        [Export("rewardedAdDidClick:")]
        void DidClick(ISARewardedAd rewardedAd);

        /// <summary>
        /// Called when a rewarded ad is dismissed.
        /// </summary>
        /// <param name="rewardedAd">The rewarded ad that is dismissed.</param>
        [Abstract]
        [Export("rewardedAdDidDismiss:")]
        void DidDismiss(ISARewardedAd rewardedAd);

    }

    /// <summary>
    /// Protocol handling loading callbacks for a requested rewarded ad. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISARewardedAdLoaderDelegate
    {
        /// <summary>
        /// Called when a rewarded ad is successfully loaded.
        /// </summary>
        /// <param name="rewardedAd">The rewarded ad that is loaded.</param>
        [Abstract]
        [Export("rewardedAdDidLoad:")]
        void RewardedAdDidLoad(ISARewardedAd rewardedAd);

        /// <summary>
        /// Called when a rewarded ad fails to load.
        /// </summary>
        /// <param name="error">The error that occurred during loading.</param>
        [Abstract]
        [Export("rewardedAdDidFailToLoadWithError:")]
        void RewardedAdDidFailToLoadWithError(NSError error);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterAdaptiveProtocol
    {
        [Abstract]
        [Export("getAdaptiveHeightWithWidth:")]
        nfloat GetAdaptiveHeightWithWidth(nfloat width);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISDemandOnlyBannerDelegate
    {
        /// <summary>
        /// Called after a banner ad has been successfully loaded
        /// </summary>
        /// <param name="bannerView">The view that contains the ad.</param>
        /// <param name="instanceId">The demand only instance id to be used to display the banner.</param>
        [Abstract]
        [Export("bannerDidLoad:instanceId:")]
        void InstanceId(ISDemandOnlyBannerView bannerView, string instanceId);

        /// <summary>
        /// Called after a banner has attempted to load an ad but failed.
        /// </summary>
        /// <param name="error">The reason for the error</param>
        /// <param name="instanceId">The demand only instance id that fail to load.</param>
        [Abstract]
        [Export("bannerDidFailToLoadWithError:instanceId:")]
        void InstanceId(NSError error, string instanceId);

        /// <summary>
        /// Called when a banner was shown
        /// </summary>
        /// <param name="instanceId">The demand only instance id which did show.</param>
        [Abstract]
        [Export("bannerDidShow:")]
        void BannerDidShow(string instanceId);

        /// <summary>
        /// Called after a banner has been clicked.
        /// </summary>
        /// <param name="instanceId">The demand only instance id which clicked.</param>
        [Abstract]
        [Export("didClickBanner:")]
        void DidClickBanner(string instanceId);

        /// <summary>
        /// Called when a user would be taken out of the application context.
        /// </summary>
        /// <param name="instanceId">The demand only instance id that taken out of the application.</param>
        [Abstract]
        [Export("bannerWillLeaveApplication:")]
        void BannerWillLeaveApplication(string instanceId);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISDemandOnlyInterstitialDelegate
    {
        /// <summary>
        /// Called after an interstitial has been loaded
        /// </summary>
        [Abstract]
        [Export("interstitialDidLoad:")]
        void InterstitialDidLoad(string instanceId);

        /// <summary>
        /// Called after an interstitial has attempted to load but failed.
        /// </summary>
        /// <param name="error">The reason for the error</param>
        [Abstract]
        [Export("interstitialDidFailToLoadWithError:instanceId:")]
        void InstanceId(NSError error, string instanceId);

        /// <summary>
        /// Called after an interstitial has been opened.
        /// </summary>
        [Abstract]
        [Export("interstitialDidOpen:")]
        void InterstitialDidOpen(string instanceId);

        /// <summary>
        /// Called after an interstitial has been dismissed.
        /// </summary>
        [Abstract]
        [Export("interstitialDidClose:")]
        void InterstitialDidClose(string instanceId);

        /// <summary>
        /// Called after an interstitial has attempted to show but failed.
        /// </summary>
        /// <param name="error">The reason for the error</param>
        [Abstract]
        [Export("interstitialDidFailToShowWithError:instanceId:")]
        void InterstitialDidFailToShowWithErrorInstanceId(NSError error, string instanceId);

        /// <summary>
        /// Called after an interstitial has been clicked.
        /// </summary>
        [Abstract]
        [Export("didClickInterstitial:")]
        void DidClickInterstitial(string instanceId);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISDemandOnlyRewardedVideoDelegate
    {
        [Abstract]
        [Export("rewardedVideoDidLoad:")]
        void RewardedVideoDidLoad(string instanceId);

        [Abstract]
        [Export("rewardedVideoDidFailToLoadWithError:instanceId:")]
        void InstanceId(NSError error, string instanceId);

        [Abstract]
        [Export("rewardedVideoDidOpen:")]
        void RewardedVideoDidOpen(string instanceId);

        [Abstract]
        [Export("rewardedVideoDidFailToShowWithError:instanceId:")]
        void RewardedVideoDidFailToShowWithErrorInstanceId(NSError error, string instanceId);

        [Abstract]
        [Export("rewardedVideoDidClick:")]
        void RewardedVideoDidClick(string instanceId);

        [Abstract]
        [Export("rewardedVideoAdRewarded:")]
        void RewardedVideoAdRewarded(string instanceId);

        [Abstract]
        [Export("rewardedVideoDidClose:")]
        void RewardedVideoDidClose(string instanceId);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface LPMDispatcherProtocol
    {
        [Abstract]
        [Export("dispatch:")]
        void Dispatch(Action task);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface LPMImpressionDataDelegate
    {
        [Abstract]
        [Export("impressionDataDidSucceed:")]
        void DidSucceed(LPMImpressionData impressionData);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterAdDelegate
    {
        [Abstract]
        [Export("adDidLoad")]
        void AdDidLoad();

        [Abstract]
        [Export("adDidLoadWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidLoadWithExtraData(NSDictionary extraData);

        /// <param name="errorType">the load error type, including NO_FILL</param>
        /// <param name="errorCode">the error code if available, general ones in AdapterErrors</param>
        /// <param name="errorMessage">the error message if available</param>
        [Abstract]
        [Export("adDidFailToLoadWithErrorType:errorCode:errorMessage:")]
        void ErrorCodeErrorMessage(ISAdapterErrorType errorType, nint errorCode, [NullAllowed] string errorMessage);

        /// <param name="errorType">the load error type, including NO_FILL</param>
        /// <param name="errorCode">the error code if available, general ones in AdapterErrors</param>
        /// <param name="errorMessage">the error message if available</param>
        [Abstract]
        [Export("adDidFailToLoadWithErrorType:errorCode:errorMessage:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ErrorCodeErrorMessageExtraData(ISAdapterErrorType errorType, nint errorCode, [NullAllowed] string errorMessage, NSDictionary extraData);

        [Abstract]
        [Export("adDidOpen")]
        void AdDidOpen();

        [Abstract]
        [Export("adDidOpenWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidOpenWithExtraData(NSDictionary extraData);

        /// <param name="errorCode">the error code if available, general ones in AdapterErrors</param>
        /// <param name="errorMessage">the error message if available</param>
        [Abstract]
        [Export("adDidFailToShowWithErrorCode:errorMessage:")]
        void ErrorMessage(nint errorCode, [NullAllowed] string errorMessage);

        /// <param name="errorCode">the error code if available, general ones in AdapterErrors</param>
        /// <param name="errorMessage">the error message if available</param>
        [Abstract]
        [Export("adDidFailToShowWithErrorCode:errorMessage:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ErrorMessageExtraData(nint errorCode, [NullAllowed] string errorMessage, NSDictionary extraData);

        [Abstract]
        [Export("adDidClick")]
        void AdDidClick();

        [Abstract]
        [Export("adDidClickWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidClickWithExtraData(NSDictionary extraData);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterAdViewDelegate : ISAdapterAdDelegate
    {
        /// <param name="view">the view that was loaded</param>
        [Abstract]
        [Export("adDidLoadWithView:")]
        void AdDidLoadWithView(UIView view);

        /// <param name="view">the view that was loaded</param>
        /// <param name="extraData">custom data</param>
        [Abstract]
        [Export("adDidLoadWithView:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ExtraData(UIView view, NSDictionary extraData);

        /// <summary>
        /// This method should be invoked before the user is taken out of the application after a click
        /// </summary>
        [Abstract]
        [Export("adWillLeaveApplication")]
        void AdWillLeaveApplication();

        /// <summary>
        /// This method should be invoked before the user is taken out of the application after a click
        /// </summary>
        /// <param name="extraData">custom data</param>
        [Abstract]
        [Export("adWillLeaveApplicationWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdWillLeaveApplicationWithExtraData(NSDictionary extraData);

        /// <summary>
        /// This method should be invoked after the ad view presents fullscreen content
        /// </summary>
        [Abstract]
        [Export("adWillPresentScreen")]
        void AdWillPresentScreen();

        /// <summary>
        /// This method should be invoked after the ad view presents fullscreen content
        /// </summary>
        /// <param name="extraData">custom data</param>
        [Abstract]
        [Export("adWillPresentScreenWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdWillPresentScreenWithExtraData(NSDictionary extraData);

        /// <summary>
        /// This method should be invoked after the fullscreen content is dismissed
        /// </summary>
        [Abstract]
        [Export("adDidDismissScreen")]
        void AdDidDismissScreen();

        /// <summary>
        /// This method should be invoked after the fullscreen content is dismissed
        /// </summary>
        /// <param name="extraData">custom data</param>
        [Abstract]
        [Export("adDidDismissScreenWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidDismissScreenWithExtraData(NSDictionary extraData);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISBannerAdDelegate : ISAdapterAdViewDelegate
    {
    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterBannerProtocol
    {
        /// <summary>
        /// load the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="viewController">the application view controller</param>
        /// <param name="size">the banner size the ad will be presented on</param>
        /// <param name="delegate">the callback listener to return mandatory callbacks based on the network - load success, load failure, ad opened optional callbacks - clicked, left application, presented, dismissed</param>
        [Abstract]
        [Export("loadAdWithAdData:viewController:size:delegate:")]
        void LoadAdWithAdData(ISAdData adData, UIViewController viewController, ISBannerSize size, IISBannerAdDelegate @delegate);

        /// <summary>
        /// destroy the ad
        /// </summary>
        /// <param name="adData">- data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        [Abstract]
        [Export("destroyAdWithAdData:")]
        void DestroyAdWithAdData(ISAdData adData);

        [Abstract]
        [Export("isSupportAdaptiveBanner")]
        bool IsSupportAdaptiveBanner();

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISNetworkInitializationDelegate
    {
        [Abstract]
        [Export("onInitDidSucceed")]
        void OnInitDidSucceed();

        [Abstract]
        [Export("onInitDidSucceedWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void OnInitDidSucceedWithExtraData(NSDictionary extraData);

        /// <param name="errorCode">the error code if available, general ones in AdapterErrors</param>
        /// <param name="errorMessage">the error message if available</param>
        [Abstract]
        [Export("onInitDidFailWithErrorCode:errorMessage:")]
        void ErrorMessage(nint errorCode, [NullAllowed] string errorMessage);

        /// <param name="errorCode">the error code if available, general ones in AdapterErrors</param>
        /// <param name="errorMessage">the error message if available</param>
        /// <param name="extraData">custom data</param>
        [Abstract]
        [Export("onInitDidFailWithErrorCode:errorMessage:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ErrorMessageExtraData(nint errorCode, [NullAllowed] string errorMessage, NSDictionary extraData);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterBaseProtocol
    {
        /// <summary>
        /// initializes the network
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="delegate">the delegate to return whether the initialization was a success or failure</param>
        [Abstract]
        [Export("init:delegate:")]
        void Init(ISAdData adData, IISNetworkInitializationDelegate @delegate);

        /// <summary>
        /// returns the network SDK version
        /// </summary>
        [Abstract]
        [Export("networkSDKVersion")]
        string NetworkSDKVersion();

        /// <summary>
        /// returns the adapter version
        /// </summary>
        [Abstract]
        [Export("adapterVersion")]
        string AdapterVersion();

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterAdInteractionDelegate : ISAdapterAdDelegate
    {
        [Abstract]
        [Export("adDidClose")]
        void AdDidClose();

        [Abstract]
        [Export("adDidCloseWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidCloseWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adDidBecomeVisible")]
        void AdDidBecomeVisible();

        [Abstract]
        [Export("adDidBecomeVisibleWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidBecomeVisibleWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adDidStart")]
        void AdDidStart();

        [Abstract]
        [Export("adDidStartWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidStartWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adDidEnd")]
        void AdDidEnd();

        [Abstract]
        [Export("adDidEndWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdDidEndWithExtraData(NSDictionary extraData);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterAdFullscreenProtocol
    {
        /// <summary>
        /// load the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="delegate">the delegate to return mandatory callbacks based on the network - load success, load failure, ad opened, ad closed, show failed optional callbacks - show success, clicked</param>
        [Abstract]
        [Export("loadAdWithAdData:delegate:")]
        void LoadAdWithAdData(ISAdData adData, IISAdapterAdDelegate @delegate);

        /// <summary>
        /// show the ad
        /// </summary>
        /// <param name="viewController">current viewController for showing the ad</param>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="delegate">the callback listener</param>
        [Abstract]
        [Export("showAdWithViewController:adData:delegate:")]
        void ShowAdWithViewController(UIViewController viewController, ISAdData adData, IISAdapterAdInteractionDelegate @delegate);

        /// <summary>
        /// returning whether the ad is available or not
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        [Abstract]
        [Export("isAdAvailableWithAdData:")]
        bool IsAdAvailableWithAdData(ISAdData adData);

        /// <summary>
        /// destroy the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        [Abstract]
        [Export("destroyAdWithAdData:")]
        void DestroyAdWithAdData(ISAdData adData);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISInterstitialAdDelegate : ISAdapterAdInteractionDelegate
    {
    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdDataProtocol
    {
        [Abstract]
        [Export("title", ArgumentSemantic.Retain)]
        [NullAllowed]
        string Title {
            get;
            [Export("setTitle:")] set;
        }

        [Abstract]
        [Export("advertiser", ArgumentSemantic.Retain)]
        [NullAllowed]
        string Advertiser {
            get;
            [Export("setAdvertiser:")] set;
        }

        [Abstract]
        [Export("body", ArgumentSemantic.Retain)]
        [NullAllowed]
        string Body {
            get;
            [Export("setBody:")] set;
        }

        [Abstract]
        [Export("callToAction", ArgumentSemantic.Retain)]
        [NullAllowed]
        string CallToAction {
            get;
            [Export("setCallToAction:")] set;
        }

        [Abstract]
        [Export("icon", ArgumentSemantic.Retain)]
        [NullAllowed]
        ISNativeAdDataImage Icon {
            get;
            [Export("setIcon:")] set;
        }

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdViewBinderProtocol
    {
        [Abstract]
        [Export("setIconView:")]
        void SetIconView(UIImageView iconView);

        [Abstract]
        [Export("setTitleView:")]
        void SetTitleView(UILabel titleView);

        [Abstract]
        [Export("setAdvertiserView:")]
        void SetAdvertiserView(UILabel advertiserView);

        [Abstract]
        [Export("setBodyView:")]
        void SetBodyView(UILabel bodyView);

        [Abstract]
        [Export("setMediaView:")]
        void SetMediaView(LevelPlayMediaView mediaView);

        [Abstract]
        [Export("setCallToActionView:")]
        void SetCallToActionView(UIButton callToActionView);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterNativeAdViewBinderProtocol : ISNativeAdViewBinderProtocol
    {
        [Abstract]
        [Export("setNativeAdView:")]
        void SetNativeAdView([NullAllowed] UIView nativeAdView);

        [Abstract]
        [Export("networkNativeAdView", ArgumentSemantic.Retain)]
        [NullAllowed]
        UIView NetworkNativeAdView {
            get;
            [Export("setNetworkNativeAdView:")] set;
        }

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdDelegate : ISAdapterAdDelegate
    {
        /// <summary>
        /// mandatory callbacks
        /// </summary>
        /// <param name="adapterNativeAdData">the native ad data</param>
        /// <param name="nativeAdViewBinder">the native ad view binder</param>
        [Abstract]
        [Export("adDidLoadWithAdData:adViewBinder:")]
        void AdViewBinder(ISAdapterNativeAdData adapterNativeAdData, ISAdapterNativeAdViewBinder nativeAdViewBinder);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterNativeAdProtocol
    {
        /// <summary>
        /// load the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="viewController">the application view controller</param>
        /// <param name="delegate">the callback listener to return mandatory callbacks based on the network - load success, load failure, ad opened optional callbacks - clicked, left application, presented, dismissed</param>
        [Abstract]
        [Export("loadAdWithAdData:viewController:delegate:")]
        void LoadAdWithAdData(ISAdData adData, UIViewController viewController, IISNativeAdDelegate @delegate);

        /// <summary>
        /// destroy the ad
        /// </summary>
        /// <param name="adData">- data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        [Abstract]
        [Export("destroyAdWithAdData:")]
        void DestroyAdWithAdData(ISAdData adData);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterConsentProtocol
    {
        [Abstract]
        [Export("setConsent:")]
        void SetConsent(bool consent);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterDebugProtocol
    {
        [Abstract]
        [Export("setAdapterDebug:")]
        void SetAdapterDebug(bool adapterDebug);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterMetaDataProtocol
    {
        [Abstract]
        [Export("setMetaDataWithKey:andValues:")]
        void SetMetaDataWithKey(string key, NSMutableArray values);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterNetworkData
    {
        [Abstract]
        [Export("allData")]
        NSDictionary AllData();

        [Abstract]
        [Export("dataByKeyIgnoreCase:valueType:")]
        NSObject DataByKeyIgnoreCase(string desiredKey, Class valueType);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterNetworkDataProtocol
    {
        [Abstract]
        [Export("setNetworkData:")]
        void SetNetworkData(IISAdapterNetworkData networkData);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterAdRewardedDelegate : ISAdapterAdInteractionDelegate
    {
        [Abstract]
        [Export("adRewarded")]
        void AdRewarded();

        [Abstract]
        [Export("adRewardedWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdRewardedWithExtraData(NSDictionary extraData);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISRewardedVideoAdDelegate : ISAdapterAdRewardedDelegate
    {
    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISSetAPSDataProtocol
    {
        [Abstract]
        [Export("setAPSDataWithAdUnit:apsData:")]
        void SetAPSDataWithAdUnit(string adUnit, NSDictionary apsData);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdapterTestModeProtocol
    {
        [Abstract]
        [Export("setTestMode:")]
        void SetTestMode(bool enabled);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISBiddingDataDelegate
    {
        [Abstract]
        [Export("successWithBiddingData:")]
        void SuccessWithBiddingData(NSDictionary biddingData);

        [Abstract]
        [Export("failureWithError:")]
        void FailureWithError(string error);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISBiddingDataProtocol
    {
        /// <summary>
        /// Collects bidding data for the network. The method supports non-MADU flow. It is duplicated on `AdAdapterBridge` to support MADU flow.
        /// </summary>
        [Abstract]
        [Export("collectBiddingDataWithAdData:delegate:")]
        void CollectBiddingDataWithAdData(ISAdData adData, IISBiddingDataDelegate @delegate);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdProtocol
    {
        [Abstract]
        [Export("loadAd")]
        void LoadAd();

        [Abstract]
        [Export("destroyAd")]
        void DestroyAd();

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdInteractionDelegate
    {
        /// <summary>
        /// Called after a native ad impression has been recorded.
        /// </summary>
        /// <param name="nativeAd">Level Play native ad.</param>
        /// <param name="adInfo">The info of the ad.</param>
        [Abstract]
        [Export("didRecordImpression:withAdInfo:")]
        void DidRecordImpressionWithAdInfo(LevelPlayNativeAd nativeAd, ISAdInfo adInfo);

        /// <summary>
        /// Called after a native ad has been clicked.
        /// </summary>
        /// <param name="nativeAd">Level Play native ad.</param>
        /// <param name="adInfo">The info of the ad.</param>
        [Abstract]
        [Export("didClick:withAdInfo:")]
        void DidClickWithAdInfo(LevelPlayNativeAd nativeAd, ISAdInfo adInfo);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdLoadDelegate
    {
        /// <summary>
        /// Called after a native ad has been successfully loaded
        /// </summary>
        /// <param name="nativeAd">Level Play native ad.</param>
        /// <param name="adInfo">The info of the ad.</param>
        [Abstract]
        [Export("didLoad:withAdInfo:")]
        void WithAdInfo(LevelPlayNativeAd nativeAd, ISAdInfo adInfo);

        /// <summary>
        /// Called after a native has attempted to load an ad but failed.
        /// </summary>
        /// <param name="nativeAd">Level Play native ad.</param>
        /// <param name="error">The reason for the error</param>
        [Abstract]
        [Export("didFailToLoad:withError:")]
        void WithError(LevelPlayNativeAd nativeAd, NSError error);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface LevelPlayNativeAdDelegate : ISNativeAdLoadDelegate, ISNativeAdInteractionDelegate
    {
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface LPMBannerAdViewDelegate
    {
        [Abstract]
        [Export("didLoadAdWithAdInfo:")]
        void DidLoadAdWithAdInfo(LPMAdInfo adInfo);

        [Abstract]
        [Export("didFailToLoadAdWithAdUnitId:error:")]
        void Error(string adUnitId, NSError error);

        [Export("didClickAdWithAdInfo:")]
        void DidClickAdWithAdInfo(LPMAdInfo adInfo);

        [Export("didDisplayAdWithAdInfo:")]
        void DidDisplayAdWithAdInfo(LPMAdInfo adInfo);

        [Export("didFailToDisplayAdWithAdInfo:error:")]
        void Error(LPMAdInfo adInfo, NSError error);

        [Export("didLeaveAppWithAdInfo:")]
        void DidLeaveAppWithAdInfo(LPMAdInfo adInfo);

        [Export("didExpandAdWithAdInfo:")]
        void DidExpandAdWithAdInfo(LPMAdInfo adInfo);

        [Export("didCollapseAdWithAdInfo:")]
        void DidCollapseAdWithAdInfo(LPMAdInfo adInfo);

    }

    /// <summary>
    /// Protocol handling interstitial ad events for `LPMInterstitialAd`. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface LPMInterstitialAdDelegate
    {
        /// <summary>
        /// Triggered when an interstitial ad is successfully loaded.
        /// </summary>
        /// <param name="adInfo">Ad info of the loaded interstitial ad.</param>
        [Abstract]
        [Export("didLoadAdWithAdInfo:")]
        void DidLoadAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when an interstitial ad fails to load.
        /// </summary>
        /// <param name="adUnitId">The ad unit id of the interstitial ad that fails to load.</param>
        /// <param name="error">The error that occurred during loading.</param>
        [Abstract]
        [Export("didFailToLoadAdWithAdUnitId:error:")]
        void Error(string adUnitId, NSError error);

        /// <summary>
        /// Triggered when an interstitial ad is displayed.
        /// </summary>
        /// <param name="adInfo">Ad info of the displayed interstitial ad.</param>
        [Abstract]
        [Export("didDisplayAdWithAdInfo:")]
        void DidDisplayAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when an interstitial ad fails to show.
        /// </summary>
        /// <param name="adInfo">Ad info of the interstitial ad that failed to display.</param>
        /// <param name="error">The error that occurred.</param>
        [Export("didFailToDisplayAdWithAdInfo:error:")]
        void Error(LPMAdInfo adInfo, NSError error);

        /// <summary>
        /// Triggered when an interstitial ad is clicked.
        /// </summary>
        /// <param name="adInfo">Ad info of the clicked interstitial ad.</param>
        [Export("didClickAdWithAdInfo:")]
        void DidClickAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when an interstitial ad is closed.
        /// </summary>
        /// <param name="adInfo">Ad info of the closed interstitial ad.</param>
        [Export("didCloseAdWithAdInfo:")]
        void DidCloseAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when ad was reloaded and ad info updated.
        /// </summary>
        /// <param name="adInfo">The updated interstitial ad info after the reloading.</param>
        [Export("didChangeAdInfo:")]
        void DidChangeAdInfo(LPMAdInfo adInfo);

    }

    /// <summary>
    /// Protocol handling rewarded ad events for `LPMRewardedAd`. The callbacks will be invoked on the main thread.
    /// </summary>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface LPMRewardedAdDelegate
    {
        /// <summary>
        /// Triggered when a rewarded ad is successfully loaded.
        /// </summary>
        /// <param name="adInfo">Ad info of the loaded rewarded ad.</param>
        [Abstract]
        [Export("didLoadAdWithAdInfo:")]
        void DidLoadAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when a rewarded ad fails to load.
        /// </summary>
        /// <param name="adUnitId">The ad unit id of the rewarded ad that fails to load.</param>
        /// <param name="error">The error that occurred during loading.</param>
        [Abstract]
        [Export("didFailToLoadAdWithAdUnitId:error:")]
        void Error(string adUnitId, NSError error);

        /// <summary>
        /// Triggered when a rewarded ad is displayed.
        /// </summary>
        /// <param name="adInfo">Ad info of the displayed rewarded ad.</param>
        [Abstract]
        [Export("didDisplayAdWithAdInfo:")]
        void DidDisplayAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when the ad reward is granted.
        /// </summary>
        /// <param name="adInfo">Ad info of the displayed rewarded ad.</param>
        /// <param name="reward">Reward of the displayed ad.</param>
        [Abstract]
        [Export("didRewardAdWithAdInfo:reward:")]
        void Reward(LPMAdInfo adInfo, LPMReward reward);

        /// <summary>
        /// Triggered when a rewarded ad fails to show.
        /// </summary>
        /// <param name="adInfo">Ad info of the rewarded ad that failed to display.</param>
        /// <param name="error">The error that occurred.</param>
        [Export("didFailToDisplayAdWithAdInfo:error:")]
        void Error(LPMAdInfo adInfo, NSError error);

        /// <summary>
        /// Triggered when a rewarded ad is clicked.
        /// </summary>
        /// <param name="adInfo">Ad info of the clicked rewarded ad.</param>
        [Export("didClickAdWithAdInfo:")]
        void DidClickAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when a rewarded ad is closed.
        /// </summary>
        /// <param name="adInfo">Ad info of the closed rewarded ad.</param>
        [Export("didCloseAdWithAdInfo:")]
        void DidCloseAdWithAdInfo(LPMAdInfo adInfo);

        /// <summary>
        /// Triggered when ad was reloaded and ad info updated.
        /// </summary>
        /// <param name="adInfo">The updated rewarded ad info after the reloading.</param>
        [Export("didChangeAdInfo:")]
        void DidChangeAdInfo(LPMAdInfo adInfo);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISNAppStoreVCRootViewDelegate
    {
        [Abstract]
        [Export("didReceiveOutOfAppStoreTouchWithType:")]
        void DidReceiveOutOfAppStoreTouchWithType(string type);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISAppStoreErrorDelegate : ISNAppStoreVCRootViewDelegate
    {
    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISNetworkInitCallbackProtocol
    {
        [Export("onNetworkInitCallbackSuccess")]
        void OnNetworkInitCallbackSuccess();

        [Export("onNetworkInitCallbackFailed:")]
        void OnNetworkInitCallbackFailed(string errorMessage);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISAdUnitAdapterProtocol : ISNetworkInitCallbackProtocol
    {
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdAdapterDelegate
    {
        [Abstract]
        [Export("adapterNativeAdInitSuccess")]
        void AdapterNativeAdInitSuccess();

        [Abstract]
        [Export("adapterNativeAdInitFailedWithError:")]
        void AdapterNativeAdInitFailedWithError(NSError error);

        [Abstract]
        [Export("adapterNativeAdDidLoadWithAdData:adViewBinder:")]
        void AdViewBinder(ISAdapterNativeAdData adapterNativeAdData, ISAdapterNativeAdViewBinder nativeAdViewBinder);

        [Abstract]
        [Export("adapterNativeAdDidFailToLoadWithError:")]
        void AdapterNativeAdDidFailToLoadWithError(NSError error);

        [Abstract]
        [Export("adapterNativeAdDidShow")]
        void AdapterNativeAdDidShow();

        [Abstract]
        [Export("adapterNativeAdDidClick")]
        void AdapterNativeAdDidClick();

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdAdapterProtocol : ISAdUnitAdapterProtocol
    {
        [Export("initNativeAdsWithUserId:adapterConfig:delegate:")]
        void InitNativeAdsWithUserId(string userId, ISAdapterConfig adapterConfig, IISNativeAdAdapterDelegate @delegate);

        [Export("initNativeAdForBiddingWithUserId:adapterConfig:delegate:")]
        void InitNativeAdForBiddingWithUserId(string userId, ISAdapterConfig adapterConfig, IISNativeAdAdapterDelegate @delegate);

        [Export("loadNativeAdWithAdapterConfig:adData:viewController:delegate:")]
        void LoadNativeAdWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, UIViewController viewController, IISNativeAdAdapterDelegate @delegate);

        [Export("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:")]
        void LoadNativeAdForBiddingWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, UIViewController viewController, IISNativeAdAdapterDelegate @delegate);

        [Export("destroyNativeAdWithAdapterConfig:")]
        void DestroyNativeAdWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("getNativeAdBiddingDataWithAdapterConfig:adData:")]
        NSDictionary GetNativeAdBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData);

        [Export("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:")]
        void CollectNativeAdBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, IISBiddingDataDelegate @delegate);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISBannerAdapterDelegate
    {
        [Abstract]
        [Export("adapterBannerInitSuccess")]
        void AdapterBannerInitSuccess();

        [Abstract]
        [Export("adapterBannerInitSuccessWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerInitSuccessWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerInitFailedWithError:")]
        void AdapterBannerInitFailedWithError(NSError error);

        [Abstract]
        [Export("adapterBannerInitFailedWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerDidLoad:")]
        void AdapterBannerDidLoad(UIView bannerView);

        [Abstract]
        [Export("adapterBannerDidLoad:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ExtraData(UIView bannerView, NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerDidFailToLoadWithError:")]
        void AdapterBannerDidFailToLoadWithError(NSError error);

        [Abstract]
        [Export("adapterBannerDidFailToLoadWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerDidFailToLoadWithErrorExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerDidClick")]
        void AdapterBannerDidClick();

        [Abstract]
        [Export("adapterBannerDidClickWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerDidClickWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerWillPresentScreen")]
        void AdapterBannerWillPresentScreen();

        [Abstract]
        [Export("adapterBannerWillPresentScreenWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerWillPresentScreenWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerDidDismissScreen")]
        void AdapterBannerDidDismissScreen();

        [Abstract]
        [Export("adapterBannerDidDismissScreenWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerDidDismissScreenWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerWillLeaveApplication")]
        void AdapterBannerWillLeaveApplication();

        [Abstract]
        [Export("adapterBannerWillLeaveApplicationWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerWillLeaveApplicationWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerDidShow")]
        void AdapterBannerDidShow();

        [Abstract]
        [Export("adapterBannerDidShowWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerDidShowWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterBannerDidFailToShowWithError:")]
        void AdapterBannerDidFailToShowWithError(NSError error);

        [Abstract]
        [Export("adapterBannerDidFailToShowWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterBannerDidFailToShowWithErrorExtraData(NSError error, NSDictionary extraData);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISBannerAdapterProtocol : ISAdUnitAdapterProtocol
    {
        [Export("destroyBannerWithAdapterConfig:")]
        void DestroyBannerWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("getAdaptiveHeightWithWidth:")]
        nfloat GetAdaptiveHeightWithWidth(nfloat width);

        [Export("initBannerWithUserId:adapterConfig:delegate:")]
        void InitBannerWithUserId(string userId, ISAdapterConfig adapterConfig, IISBannerAdapterDelegate @delegate);

        [Export("loadBannerWithAdapterConfig:adData:viewController:size:delegate:")]
        void LoadBannerWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, UIViewController viewController, ISBannerSize size, IISBannerAdapterDelegate @delegate);

        [Export("getBannerBiddingDataWithAdapterConfig:adData:")]
        NSDictionary GetBannerBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData);

        [Export("collectBannerBiddingDataWithAdapterConfig:adData:delegate:")]
        void CollectBannerBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, IISBiddingDataDelegate @delegate);

        [Export("initBannerForBiddingWithUserId:adapterConfig:delegate:")]
        void InitBannerForBiddingWithUserId(string userId, ISAdapterConfig adapterConfig, IISBannerAdapterDelegate @delegate);

        [Export("loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:")]
        void LoadBannerForBiddingWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, UIViewController viewController, ISBannerSize size, IISBannerAdapterDelegate @delegate);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface LPMThreadSafeDictionaryProtocol
    {
        [Abstract]
        [Export("count")]
        nuint Count();

        [Abstract]
        [Export("objectForKey:")]
        NSObject ObjectForKey(string key);

        [Abstract]
        [Export("setObject:forKey:")]
        void SetObject(NSObject @object, string key);

        [Abstract]
        [Export("hasObjectForKey:")]
        bool HasObjectForKey(string key);

        [Abstract]
        [Export("removeObjectForKey:")]
        void RemoveObjectForKey(string key);

        [Abstract]
        [Export("removeAllObjects")]
        void RemoveAllObjects();

        [Abstract]
        [Export("allKeys")]
        // Return: Element type: string
        string[] AllKeys();

        [Abstract]
        [Export("allValues")]
        NSArray AllValues();

        [Abstract]
        [Export("allData")]
        // Return: Key type: string, Value type: NSObject
        NSDictionary AllData();

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISInterstitialAdapterDelegate
    {
        [Abstract]
        [Export("adapterInterstitialInitSuccess")]
        void AdapterInterstitialInitSuccess();

        [Abstract]
        [Export("adapterInterstitialInitSuccessWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialInitSuccessWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialInitFailedWithError:")]
        void AdapterInterstitialInitFailedWithError(NSError error);

        [Abstract]
        [Export("adapterInterstitialInitFailedWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidLoad")]
        void AdapterInterstitialDidLoad();

        [Abstract]
        [Export("adapterInterstitialDidLoadWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidLoadWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidFailToLoadWithError:")]
        void AdapterInterstitialDidFailToLoadWithError(NSError error);

        [Abstract]
        [Export("adapterInterstitialDidFailToLoadWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidFailToLoadWithErrorExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidOpen")]
        void AdapterInterstitialDidOpen();

        [Abstract]
        [Export("adapterInterstitialDidOpenWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidOpenWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidClose")]
        void AdapterInterstitialDidClose();

        [Abstract]
        [Export("adapterInterstitialDidCloseWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidCloseWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidShow")]
        void AdapterInterstitialDidShow();

        [Abstract]
        [Export("adapterInterstitialDidShowWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidShowWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidFailToShowWithError:")]
        void AdapterInterstitialDidFailToShowWithError(NSError error);

        [Abstract]
        [Export("adapterInterstitialDidFailToShowWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidFailToShowWithErrorExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidClick")]
        void AdapterInterstitialDidClick();

        [Abstract]
        [Export("adapterInterstitialDidClickWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidClickWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterInterstitialDidBecomeVisible")]
        void AdapterInterstitialDidBecomeVisible();

        [Abstract]
        [Export("adapterInterstitialDidBecomeVisibleWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterInterstitialDidBecomeVisibleWithExtraData(NSDictionary extraData);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISInterstitialAdapterProtocol : ISAdUnitAdapterProtocol
    {
        [Export("showInterstitialWithViewController:adapterConfig:delegate:")]
        void ShowInterstitialWithViewController(UIViewController viewController, ISAdapterConfig adapterConfig, IISInterstitialAdapterDelegate @delegate);

        [Export("hasInterstitialWithAdapterConfig:")]
        bool HasInterstitialWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("destroyInterstitialAdWithAdapterConfig:")]
        void DestroyInterstitialAdWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("initInterstitialWithUserId:adapterConfig:delegate:")]
        void InitInterstitialWithUserId(string userId, ISAdapterConfig adapterConfig, IISInterstitialAdapterDelegate @delegate);

        [Export("loadInterstitialWithAdapterConfig:adData:delegate:")]
        void LoadInterstitialWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, IISInterstitialAdapterDelegate @delegate);

        [Export("getInterstitialBiddingDataWithAdapterConfig:adData:")]
        NSDictionary GetInterstitialBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData);

        [Export("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:")]
        void CollectInterstitialBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, IISBiddingDataDelegate @delegate);

        [Export("initInterstitialForBiddingWithUserId:adapterConfig:delegate:")]
        void InitInterstitialForBiddingWithUserId(string userId, ISAdapterConfig adapterConfig, IISInterstitialAdapterDelegate @delegate);

        [Export("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:")]
        void LoadInterstitialForBiddingWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, IISInterstitialAdapterDelegate @delegate);

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    partial interface ISRewardedVideoAdapterDelegate
    {
        [Abstract]
        [Export("adapterRewardedVideoHasChangedAvailability:")]
        void AdapterRewardedVideoHasChangedAvailability(bool available);

        [Abstract]
        [Export("adapterRewardedVideoHasChangedAvailability:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ExtraData(bool available, NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidFailToLoadWithError:")]
        void AdapterRewardedVideoDidFailToLoadWithError(NSError error);

        [Abstract]
        [Export("adapterRewardedVideoDidFailToLoadWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void ExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidReceiveReward")]
        void AdapterRewardedVideoDidReceiveReward();

        [Abstract]
        [Export("adapterRewardedVideoDidReceiveRewardWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidReceiveRewardWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidFailToShowWithError:")]
        void AdapterRewardedVideoDidFailToShowWithError(NSError error);

        [Abstract]
        [Export("adapterRewardedVideoDidFailToShowWithError:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidFailToShowWithErrorExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidOpen")]
        void AdapterRewardedVideoDidOpen();

        [Abstract]
        [Export("adapterRewardedVideoDidOpenWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidOpenWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidClose")]
        void AdapterRewardedVideoDidClose();

        [Abstract]
        [Export("adapterRewardedVideoDidCloseWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidCloseWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidLoad")]
        void AdapterRewardedVideoDidLoad();

        [Abstract]
        [Export("adapterRewardedVideoDidLoadWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidLoadWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidClick")]
        void AdapterRewardedVideoDidClick();

        [Abstract]
        [Export("adapterRewardedVideoDidClickWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidClickWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidStart")]
        void AdapterRewardedVideoDidStart();

        [Abstract]
        [Export("adapterRewardedVideoDidStartWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidStartWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidEnd")]
        void AdapterRewardedVideoDidEnd();

        [Abstract]
        [Export("adapterRewardedVideoDidEndWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidEndWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoInitSuccess")]
        void AdapterRewardedVideoInitSuccess();

        [Abstract]
        [Export("adapterRewardedVideoInitSuccessWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoInitSuccessWithExtraData(NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoInitFailed:")]
        void AdapterRewardedVideoInitFailed(NSError error);

        [Abstract]
        [Export("adapterRewardedVideoInitFailed:extraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoInitFailedExtraData(NSError error, NSDictionary extraData);

        [Abstract]
        [Export("adapterRewardedVideoDidBecomeVisible")]
        void AdapterRewardedVideoDidBecomeVisible();

        [Abstract]
        [Export("adapterRewardedVideoDidBecomeVisibleWithExtraData:")]
        // Parameter 'extraData': Key type: string, Value type: NSObject
        void AdapterRewardedVideoDidBecomeVisibleWithExtraData(NSDictionary extraData);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISRewardedVideoAdapterProtocol : ISAdUnitAdapterProtocol
    {
        [Export("hasRewardedVideoWithAdapterConfig:")]
        bool HasRewardedVideoWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("showRewardedVideoWithViewController:adapterConfig:delegate:")]
        void ShowRewardedVideoWithViewController(UIViewController viewController, ISAdapterConfig adapterConfig, IISRewardedVideoAdapterDelegate @delegate);

        [Export("destroyRewardedVideoAdWithAdapterConfig:")]
        void DestroyRewardedVideoAdWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:")]
        void InitAndLoadRewardedVideoWithUserId(string userId, ISAdapterConfig adapterConfig, NSDictionary adData, IISRewardedVideoAdapterDelegate @delegate);

        [Export("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:")]
        void InitRewardedVideoForCallbacksWithUserId(string userId, ISAdapterConfig adapterConfig, IISRewardedVideoAdapterDelegate @delegate);

        [Export("loadRewardedVideoWithAdapterConfig:adData:delegate:")]
        void LoadRewardedVideoWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, IISRewardedVideoAdapterDelegate @delegate);

        [Export("getRewardedVideoBiddingDataWithAdapterConfig:adData:")]
        NSDictionary GetRewardedVideoBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData);

        [Export("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:")]
        void CollectRewardedVideoBiddingDataWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, IISBiddingDataDelegate @delegate);

        [Export("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:")]
        void LoadRewardedVideoForBiddingWithAdapterConfig(ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, IISRewardedVideoAdapterDelegate @delegate);

        [Export("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:")]
        void InitRewardedVideoForDemandOnlyWithUserId(string userId, ISAdapterConfig adapterConfig, IISRewardedVideoAdapterDelegate @delegate);

        [Export("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:")]
        void LoadRewardedVideoForDemandOnlyWithAdapterConfig(ISAdapterConfig adapterConfig, IISRewardedVideoAdapterDelegate @delegate);

        [Export("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:")]
        void LoadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig(ISAdapterConfig adapterConfig, string serverData, IISRewardedVideoAdapterDelegate @delegate);

    }

    [Protocol(Name = "ISNAdViewsManagerSwiftFacade")]
    [BaseType(typeof(NSObject))]
    partial interface ISNAdViewsManagerSwiftFacadeProtocol
    {
        [Abstract]
        [Export("getAdViewById:")]
        UIView GetAdViewById(string adViewId);

    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISNControllerMessageListener
    {
    }

    [Protocol]
    [BaseType(typeof(NSObject))]
    partial interface ISNEventTrackerInterface
    {
        [Abstract]
        [Export("logEvent:data:")]
        void LogEvent(ISNEvent @event, NSDictionary data);

    }

    /// <summary>
    /// Class containing information on the associated banner ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISABannerAdInfo
    {
        [Export("new")]
        [return: Release]
        ISABannerAdInfo New();

        /// <summary>
        /// The identifier of the network instance.
        /// </summary>
        [Export("instanceId", ArgumentSemantic.Retain)]
        string InstanceId { get; }

        /// <summary>
        /// The unique identifier of the ad.
        /// </summary>
        [Export("adId", ArgumentSemantic.Retain)]
        string AdId { get; }

    }

    [DisableDefaultCtor]
    [BaseType(typeof(UIView))]
    partial interface ISABannerAdView
    {
        [Export("new")]
        [return: Release]
        ISABannerAdView New();

        [Wrap("WeakDelegate")]
        [NullAllowed]
        ISABannerAdViewDelegate Delegate { get; set; }

        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate {
            get;
            [Export("setDelegate:")] set;
        }

        [Export("adInfo", ArgumentSemantic.Retain)]
        ISABannerAdInfo AdInfo { get; }

        [Export("viewController", ArgumentSemantic.Weak)]
        [NullAllowed]
        UIViewController ViewController {
            get;
            [Export("setViewController:")] set;
        }

    }

    /// <summary>
    /// Class representing an ad size.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAAdSize
    {
        [Export("new")]
        [return: Release]
        ISAAdSize New();

        /// <summary>
        /// Creates an `ISAAdSize` for a banner ad.
        /// </summary>
        [Static]
        [Export("banner")]
        ISAAdSize Banner();

        /// <summary>
        /// Creates an `ISAAdSize` for a large ad.
        /// </summary>
        [Static]
        [Export("large")]
        ISAAdSize Large();

        /// <summary>
        /// Creates an `ISAAdSize` for a medium rectangle ad.
        /// </summary>
        [Static]
        [Export("mediumRectangle")]
        ISAAdSize MediumRectangle();

        /// <summary>
        /// Creates an `ISAAdSize` for a leaderboard ad.
        /// </summary>
        [Static]
        [Export("leaderboard")]
        ISAAdSize Leaderboard();

        [Export("width")]
        nfloat Width { get; }

        [Export("height")]
        nfloat Height { get; }

        [Export("sizeDescription", ArgumentSemantic.Copy)]
        string SizeDescription { get; }

    }

    /// <summary>
    /// Class representing a loading request for a banner ad. Use `ISABannerAdRequestBuilder` in order to create an instance of this class.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISABannerAdRequest
    {
        [Export("new")]
        [return: Release]
        ISABannerAdRequest New();

        /// <summary>
        /// The identifier for the network instance.
        /// </summary>
        [Export("instanceId", ArgumentSemantic.Retain)]
        string InstanceId { get; }

        /// <summary>
        /// The ad markup.
        /// </summary>
        [Export("adm", ArgumentSemantic.Retain)]
        string Adm { get; }

        /// <summary>
        /// The ad size.
        /// </summary>
        [Export("size", ArgumentSemantic.Retain)]
        ISAAdSize Size { get; }

        /// <summary>
        /// The view controller to show the ad on, if available.
        /// </summary>
        [Export("viewController", ArgumentSemantic.Weak)]
        [NullAllowed]
        UIViewController ViewController { get; }

        /// <summary>
        /// Extra parameters for the ad request.
        /// </summary>
        [Export("extraParams", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSDictionary ExtraParams { get; }

    }

    /// <summary>
    /// Class responsible for loading banner ads.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISABannerAdLoader
    {
        [Export("new")]
        [return: Release]
        ISABannerAdLoader New();

        /// <summary>
        /// Loads a banner ad. The delegate will send a `bannerAdDidLoad:` or `bannerAdDidFailToLoadWithError:` callback.
        /// </summary>
        /// <param name="adRequest">The request configuration for the ad to be loaded.</param>
        /// <param name="delegate">The delegate to be notified of ad loading callbacks. The callbacks will be invoked on the main thread. The delegate is held weakly.</param>
        [Static]
        [Export("loadAdWithAdRequest:delegate:")]
        void LoadAdWithAdRequest(ISABannerAdRequest adRequest, IISABannerAdLoaderDelegate @delegate);

    }

    /// <summary>
    /// Builder class for `ISABannerAdRequest`.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISABannerAdRequestBuilder
    {
        [Export("new")]
        [return: Release]
        ISABannerAdRequestBuilder New();

        /// <summary>
        /// Initializes the builder.
        /// </summary>
        /// <param name="instanceId">The identifier for the network instance.</param>
        /// <param name="adm">The ad markup.</param>
        /// <param name="size">The ad size.</param>
        [Export("initWithInstanceId:adm:size:")]
        NativeHandle Constructor(string instanceId, string adm, ISAAdSize size);

        /// <summary>
        /// Sets extra parameters for the ad request. Optional. The Builder instance.
        /// </summary>
        /// <param name="extraParams">The extra parameters dictionary.</param>
        [Export("withExtraParams:")]
        ISABannerAdRequestBuilder WithExtraParams(NSDictionary extraParams);

        /// <summary>
        /// Sets the view controller that will show the ad, if available. The Builder instance.
        /// </summary>
        /// <param name="viewController">The view controller that will show the ad, if available.</param>
        [Export("withViewController:")]
        ISABannerAdRequestBuilder WithViewController(UIViewController viewController);

        /// <summary>
        /// Builds the `ISABannerAdRequest` instance. The ad request instance.
        /// </summary>
        [Export("build")]
        ISABannerAdRequest Build();

    }

    /// <summary>
    /// Class representing an ad format.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAAdFormat
    {
        [Export("new")]
        [return: Release]
        ISAAdFormat New();

        /// <summary>
        /// Initializes with the given ad format type.
        /// </summary>
        /// <param name="adFormatType">the ad format type to represent.</param>
        [Export("initWithAdFormatType:")]
        NativeHandle Constructor(ISAAdFormatType adFormatType);

        /// <summary>
        /// The ad format type.
        /// </summary>
        [Export("adFormatType")]
        ISAAdFormatType AdFormatType { get; }

    }

    /// <summary>
    /// Class representing an initialization request for IronSourceAds. Use `ISAInitRequestBuilder` to create an instance of this class.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAInitRequest
    {
        [Export("new")]
        [return: Release]
        ISAInitRequest New();

        /// <summary>
        /// The application key.
        /// </summary>
        [Export("appKey")]
        string AppKey { get; }

        /// <summary>
        /// Legacy ad formats for the initialization request.
        /// </summary>
        [Export("legacyAdFormats")]
        // Element type: ISAAdFormat
        ISAAdFormat[] LegacyAdFormats { get; }

        /// <summary>
        /// Log level to use in IronSourceAds. Default value is `ISALogLevelNone`.
        /// </summary>
        [Export("logLevel")]
        ISALogLevel LogLevel { get; }

    }

    /// <summary>
    /// Builder class for `ISAInitRequest`.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAInitRequestBuilder
    {
        [Export("new")]
        [return: Release]
        ISAInitRequestBuilder New();

        /// <summary>
        /// Initializes the builder.
        /// </summary>
        /// <param name="appKey">the application key.</param>
        [Export("initWithAppKey:")]
        NativeHandle Constructor(string appKey);

        /// <summary>
        /// Builds the `ISAInitRequest` instance. The init request instance.
        /// </summary>
        [Export("build")]
        ISAInitRequest Build();

        /// <summary>
        /// Sets the legacy ad formats for the initialization request. To enable non-bidding instances, pass the relevant legacy ad formats. For bidding instances, this is non-mandatory. The Builder instance.
        /// </summary>
        /// <param name="legacyAdFormats">The list of legacy ad formats.</param>
        [Export("withLegacyAdFormats:")]
        // Parameter 'legacyAdFormats': Element type: ISAAdFormat
        ISAInitRequestBuilder WithLegacyAdFormats(ISAAdFormat[] legacyAdFormats);

        /// <summary>
        /// Sets the log level for the initialization request. Default value is `ISALogLevelNone`. The Builder instance.
        /// </summary>
        /// <param name="logLevel">The log level.</param>
        [Export("withLogLevel:")]
        ISAInitRequestBuilder WithLogLevel(ISALogLevel logLevel);

    }

    /// <summary>
    /// Class responsible for handling the operations and callbacks of an interstitial ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAInterstitialAd
    {
        [Export("new")]
        [return: Release]
        ISAInterstitialAd New();

        /// <summary>
        /// Check if the ad is ready to show. Showing an ad that is not ready will result in a show failure. Whether the ad is ready to show.
        /// </summary>
        [Export("isReadyToShow")]
        bool IsReadyToShow();

        /// <summary>
        /// Show the ad. The delegate will send a `interstitialAdDidShow:` or `interstitialAd:didFailToShowWithError:` callback.
        /// </summary>
        /// <param name="viewController">The view controller where the ad will be shown.</param>
        [Export("showFromViewController:")]
        void ShowFromViewController(UIViewController viewController);

        /// <summary>
        /// The delegate for the ad callbacks. Set this delegate in order to receive callbacks from the ad. The callbacks will be invoked on the main thread.
        /// </summary>
        [Wrap("WeakDelegate")]
        [NullAllowed]
        ISAInterstitialAdDelegate Delegate { get; set; }

        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate {
            get;
            [Export("setDelegate:")] set;
        }

        /// <summary>
        /// Contains information associated with the ad.
        /// </summary>
        [Export("adInfo", ArgumentSemantic.Retain)]
        ISAInterstitialAdInfo AdInfo { get; }

    }

    /// <summary>
    /// Class containing information on the associated interstitial ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAInterstitialAdInfo
    {
        [Export("new")]
        [return: Release]
        ISAInterstitialAdInfo New();

        /// <summary>
        /// The identifier of the network instance.
        /// </summary>
        [Export("instanceId", ArgumentSemantic.Retain)]
        string InstanceId { get; }

        /// <summary>
        /// The unique identifier of the ad.
        /// </summary>
        [Export("adId", ArgumentSemantic.Retain)]
        string AdId { get; }

    }

    /// <summary>
    /// Class representing a loading request for an interstitial ad. Use `ISAInterstitialAdRequestBuilder` in order to create an instance of this class.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAInterstitialAdRequest
    {
        [Export("new")]
        [return: Release]
        ISAInterstitialAdRequest New();

        /// <summary>
        /// The identifier for the network instance.
        /// </summary>
        [Export("instanceId", ArgumentSemantic.Retain)]
        string InstanceId { get; }

        /// <summary>
        /// The ad markup.
        /// </summary>
        [Export("adm", ArgumentSemantic.Retain)]
        string Adm { get; }

        /// <summary>
        /// Extra parameters for the ad request.
        /// </summary>
        [Export("extraParams", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSDictionary ExtraParams { get; }

    }

    /// <summary>
    /// Class responsible for loading interstitial ads.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAInterstitialAdLoader
    {
        [Export("new")]
        [return: Release]
        ISAInterstitialAdLoader New();

        /// <summary>
        /// Loads an interstitial ad. The delegate will send a `interstitialAdDidLoad:` or `interstitialAdDidFailToLoadWithError:` callback.
        /// </summary>
        /// <param name="adRequest">The request configuration for the ad to be loaded.</param>
        /// <param name="delegate">The delegate to be notified of ad loading callbacks. The callbacks will be invoked on the main thread. The delegate is held weakly.</param>
        [Static]
        [Export("loadAdWithAdRequest:delegate:")]
        void LoadAdWithAdRequest(ISAInterstitialAdRequest adRequest, IISAInterstitialAdLoaderDelegate @delegate);

    }

    /// <summary>
    /// Builder class for `ISAInterstitialAdRequest`.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAInterstitialAdRequestBuilder
    {
        [Export("new")]
        [return: Release]
        ISAInterstitialAdRequestBuilder New();

        /// <summary>
        /// Initializes the builder.
        /// </summary>
        /// <param name="instanceId">The identifier for the network instance.</param>
        /// <param name="adm">The ad markup.</param>
        [Export("initWithInstanceId:adm:")]
        NativeHandle Constructor(string instanceId, string adm);

        /// <summary>
        /// Sets extra parameters for the ad request. Optional. The Builder instance.
        /// </summary>
        /// <param name="extraParams">The extra parameters dictionary.</param>
        [Export("withExtraParams:")]
        ISAInterstitialAdRequestBuilder WithExtraParams(NSDictionary extraParams);

        /// <summary>
        /// Builds the `ISAInterstitialAdRequest` instance. The ad request instance.
        /// </summary>
        [Export("build")]
        ISAInterstitialAdRequest Build();

    }

    /// <summary>
    /// Class responsible for handling the operations and callbacks of a rewarded ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISARewardedAd
    {
        [Export("new")]
        [return: Release]
        ISARewardedAd New();

        /// <summary>
        /// Check if the ad is ready to show. Showing an ad that is not ready will result in a show failure. Whether the ad is ready to show.
        /// </summary>
        [Export("isReadyToShow")]
        bool IsReadyToShow();

        /// <summary>
        /// Show the ad. The delegate will send a `rewardedAdDidShow:` or `rewardedAd:didFailToShowWithError:` callback.
        /// </summary>
        /// <param name="viewController">The view controller where the ad will be shown.</param>
        [Export("showFromViewController:")]
        void ShowFromViewController(UIViewController viewController);

        /// <summary>
        /// The delegate for the ad callbacks. Set this delegate in order to receive callbacks from the ad. The callbacks will be invoked on the main thread.
        /// </summary>
        [Wrap("WeakDelegate")]
        [NullAllowed]
        ISARewardedAdDelegate Delegate { get; set; }

        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate {
            get;
            [Export("setDelegate:")] set;
        }

        /// <summary>
        /// Contains information associated with the ad.
        /// </summary>
        [Export("adInfo", ArgumentSemantic.Retain)]
        ISARewardedAdInfo AdInfo { get; }

    }

    /// <summary>
    /// Class containing information on the associated rewarded ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISARewardedAdInfo
    {
        [Export("new")]
        [return: Release]
        ISARewardedAdInfo New();

        /// <summary>
        /// The identifier of the network instance.
        /// </summary>
        [Export("instanceId", ArgumentSemantic.Retain)]
        string InstanceId { get; }

        /// <summary>
        /// The unique identifier of the ad.
        /// </summary>
        [Export("adId", ArgumentSemantic.Retain)]
        string AdId { get; }

    }

    /// <summary>
    /// Class representing a loading request for a rewarded ad. Use `ISARewardedAdRequestBuilder` in order to create an instance of this class.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISARewardedAdRequest
    {
        [Export("new")]
        [return: Release]
        ISARewardedAdRequest New();

        /// <summary>
        /// The identifier for the network instance.
        /// </summary>
        [Export("instanceId", ArgumentSemantic.Retain)]
        string InstanceId { get; }

        /// <summary>
        /// The ad markup.
        /// </summary>
        [Export("adm", ArgumentSemantic.Retain)]
        string Adm { get; }

        /// <summary>
        /// Extra parameters for the ad request.
        /// </summary>
        [Export("extraParams", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSDictionary ExtraParams { get; }

    }

    /// <summary>
    /// Class responsible for loading rewarded ads.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISARewardedAdLoader
    {
        [Export("new")]
        [return: Release]
        ISARewardedAdLoader New();

        /// <summary>
        /// Loads a rewarded ad. The delegate will send a `rewardedAdDidLoad:` or `rewardedAdDidFailToLoadWithError:` callback.
        /// </summary>
        /// <param name="adRequest">The request configuration for the ad to be loaded.</param>
        /// <param name="delegate">The delegate to be notified of ad loading callbacks. The callbacks will be invoked on the main thread. The delegate is held weakly.</param>
        [Static]
        [Export("loadAdWithAdRequest:delegate:")]
        void LoadAdWithAdRequest(ISARewardedAdRequest adRequest, IISARewardedAdLoaderDelegate @delegate);

    }

    /// <summary>
    /// Builder class for `ISARewardedAdRequest`.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISARewardedAdRequestBuilder
    {
        [Export("new")]
        [return: Release]
        ISARewardedAdRequestBuilder New();

        /// <summary>
        /// Initializes the builder.
        /// </summary>
        /// <param name="instanceId">The identifier for the network instance.</param>
        /// <param name="adm">The ad markup.</param>
        [Export("initWithInstanceId:adm:")]
        NativeHandle Constructor(string instanceId, string adm);

        /// <summary>
        /// Sets extra parameters for the ad request. Optional. The Builder instance.
        /// </summary>
        /// <param name="extraParams">The extra parameters dictionary.</param>
        [Export("withExtraParams:")]
        ISARewardedAdRequestBuilder WithExtraParams(NSDictionary extraParams);

        /// <summary>
        /// Builds the `ISARewardedAdRequest` instance. The ad request instance.
        /// </summary>
        [Export("build")]
        ISARewardedAdRequest Build();

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISAdInfo
    {
        [Export("auction_id", ArgumentSemantic.Copy)]
        string Auction_id { get; }

        [Export("ad_network", ArgumentSemantic.Copy)]
        string Ad_network { get; }

        [Export("instance_name", ArgumentSemantic.Copy)]
        string Instance_name { get; }

        [Export("instance_id", ArgumentSemantic.Copy)]
        string Instance_id { get; }

        [Export("country", ArgumentSemantic.Copy)]
        string Country { get; }

        [Export("revenue", ArgumentSemantic.Copy)]
        NSNumber Revenue { get; }

        [Export("precision", ArgumentSemantic.Copy)]
        string Precision { get; }

        [Export("ab", ArgumentSemantic.Copy)]
        string Ab { get; }

        [Export("segment_name", ArgumentSemantic.Copy)]
        string Segment_name { get; }

        [Export("encrypted_cpm", ArgumentSemantic.Copy)]
        string Encrypted_cpm { get; }

        [Export("conversion_value", ArgumentSemantic.Copy)]
        NSNumber Conversion_value { get; }

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMAdSize : INSCopying
    {
        [Export("new")]
        [return: Release]
        LPMAdSize New();

        [Static]
        [Export("bannerSize")]
        LPMAdSize BannerSize();

        [Static]
        [Export("largeSize")]
        LPMAdSize LargeSize();

        [Static]
        [Export("mediumRectangleSize")]
        LPMAdSize MediumRectangleSize();

        [Static]
        [Export("leaderBoardSize")]
        LPMAdSize LeaderBoardSize();

        [Static]
        [Export("customSizeWithWidth:height:")]
        LPMAdSize CustomSizeWithWidth(nint width, nint height);

        /// <summary>
        /// Creates and returns an adaptive ad size for a given width. If the provided width is invalid (less than or equal to 0), the method uses the screen width based on the device orientation. An instance of LPMAdSize with the calculated height for the given width, or `nil` if the SDK is not initialized.
        /// </summary>
        /// <param name="width">The specified width for which the adaptive ad size is calculated.</param>
        [Static]
        [Export("createAdaptiveAdSizeWithWidth:")]
        [return: NullAllowed]
        LPMAdSize CreateAdaptiveAdSizeWithWidth(nfloat width);

        /// <summary>
        /// Creates and returns an adaptive ad size using the screen width based on the device orientation. An instance of LPMAdSize with the calculated height for the screen width, or `nil` if the SDK is not initialized.
        /// </summary>
        [Static]
        [Export("createAdaptiveAdSize")]
        [return: NullAllowed]
        LPMAdSize CreateAdaptiveAdSize();

        [Export("type")]
        LPMAdSizeType Type { get; }

        [Export("width")]
        nint Width { get; }

        [Export("height")]
        nint Height { get; }

        [Export("sizeDescription", ArgumentSemantic.Copy)]
        string SizeDescription { get; }

        [Export("isAdaptive")]
        bool IsAdaptive { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISBannerSize
    {
        [Export("initWithWidth:andHeight:")]
        NativeHandle Constructor(nint width, nint height);

        [Export("initWithDescription:width:height:")]
        NativeHandle Constructor(string description, nint width, nint height);

        [Export("isSmart")]
        bool IsSmart();

        [Export("toLPMAdSize")]
        LPMAdSize ToLPMAdSize();

        /// <summary>
        /// Calculates and returns the maximum height of an adaptive banner for a given width. If there are no adaptive banner supporting networks, the return value will be -1. The maximal height of an adaptive banner, or -1 if no supporting networks are found.
        /// </summary>
        /// <param name="width">The specified width for which the maximum height is calculated.</param>
        [Static]
        [Export("getMaximalAdaptiveHeightWithWidth:")]
        nfloat GetMaximalAdaptiveHeightWithWidth(nfloat width);

        [Export("sizeDescription")]
        string SizeDescription { get; }

        [Export("width")]
        nint Width { get; }

        [Export("height")]
        nint Height { get; }

        [Export("isAdaptive", ArgumentSemantic.Assign)]
        bool Adaptive {
            [Bind("isAdaptive")] get;
            [Export("setAdaptive:")] set;
        }

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMSegment
    {
        [Export("setCustomValue:forKey:")]
        void SetCustomValue(string value, string key);

        [Export("getData")]
        NSDictionary GetData();

        [Export("level", ArgumentSemantic.Assign)]
        int Level {
            get;
            [Export("setLevel:")] set;
        }

        [Export("iapTotal", ArgumentSemantic.Assign)]
        double IapTotal {
            get;
            [Export("setIapTotal:")] set;
        }

        [Export("paying", ArgumentSemantic.Assign)]
        bool Paying {
            get;
            [Export("setPaying:")] set;
        }

        [Export("userCreationDate", ArgumentSemantic.Retain)]
        NSDate UserCreationDate {
            get;
            [Export("setUserCreationDate:")] set;
        }

        [Export("segmentName", ArgumentSemantic.Retain)]
        string SegmentName {
            get;
            [Export("setSegmentName:")] set;
        }

        [Export("customKeys", ArgumentSemantic.Retain)]
        // Key type: string, Value type: string
        NSDictionary<NSString, NSString> CustomKeys { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISConfigurations
    {
        [Static]
        [Export("getConfigurations")]
        ISConfigurations GetConfigurations();

        [Export("userId", ArgumentSemantic.Retain)]
        string UserId {
            get;
            [Export("setUserId:")] set;
        }

        [Export("appKey", ArgumentSemantic.Retain)]
        string AppKey {
            get;
            [Export("setAppKey:")] set;
        }

        [Export("segmentId", ArgumentSemantic.Retain)]
        string SegmentId {
            get;
            [Export("setSegmentId:")] set;
        }

        [Export("customSegmentParams", ArgumentSemantic.Retain)]
        NSDictionary CustomSegmentParams {
            get;
            [Export("setCustomSegmentParams:")] set;
        }

        [Export("segment", ArgumentSemantic.Retain)]
        LPMSegment Segment {
            get;
            [Export("setSegment:")] set;
        }

        [Export("rewardedVideoCustomParameters", ArgumentSemantic.Retain)]
        NSDictionary RewardedVideoCustomParameters {
            get;
            [Export("setRewardedVideoCustomParameters:")] set;
        }

        [Export("version", ArgumentSemantic.Retain)]
        string Version {
            get;
            [Export("setVersion:")] set;
        }

        [Export("adapterTimeOutInSeconds", ArgumentSemantic.Retain)]
        NSNumber AdapterTimeOutInSeconds {
            get;
            [Export("setAdapterTimeOutInSeconds:")] set;
        }

        [Export("maxNumOfAdaptersToLoadOnStart", ArgumentSemantic.Retain)]
        NSNumber MaxNumOfAdaptersToLoadOnStart {
            get;
            [Export("setMaxNumOfAdaptersToLoadOnStart:")] set;
        }

        [Export("advancedLoading", ArgumentSemantic.Assign)]
        bool AdvancedLoading {
            get;
            [Export("setAdvancedLoading:")] set;
        }

        [Export("plugin", ArgumentSemantic.Retain)]
        string Plugin {
            get;
            [Export("setPlugin:")] set;
        }

        [Export("pluginVersion", ArgumentSemantic.Retain)]
        string PluginVersion {
            get;
            [Export("setPluginVersion:")] set;
        }

        [Export("pluginFrameworkVersion", ArgumentSemantic.Retain)]
        string PluginFrameworkVersion {
            get;
            [Export("setPluginFrameworkVersion:")] set;
        }

        [Export("maxVideosPerIteration", ArgumentSemantic.Retain)]
        NSNumber MaxVideosPerIteration {
            get;
            [Export("setMaxVideosPerIteration:")] set;
        }

        [Export("userAge", ArgumentSemantic.Assign)]
        nint UserAge {
            get;
            [Export("setUserAge:")] set;
        }

        [Export("trackReachability", ArgumentSemantic.Assign)]
        bool TrackReachability {
            get;
            [Export("setTrackReachability:")] set;
        }

        [Export("dynamicUserId", ArgumentSemantic.Retain)]
        string DynamicUserId {
            get;
            [Export("setDynamicUserId:")] set;
        }

        [Export("adaptersDebug", ArgumentSemantic.Assign)]
        bool AdaptersDebug {
            get;
            [Export("setAdaptersDebug:")] set;
        }

        [Export("mediationType", ArgumentSemantic.Retain)]
        string MediationType {
            get;
            [Export("setMediationType:")] set;
        }

        [Export("serr", ArgumentSemantic.Retain)]
        NSNumber Serr {
            get;
            [Export("setSerr:")] set;
        }

        [Export("abt", ArgumentSemantic.Retain)]
        string Abt {
            get;
            [Export("setAbt:")] set;
        }

        [Export("rvServerParams", ArgumentSemantic.Retain)]
        NSDictionary RvServerParams {
            get;
            [Export("setRvServerParams:")] set;
        }

        [Export("consent", ArgumentSemantic.Assign)]
        nint Consent {
            get;
            [Export("setConsent:")] set;
        }

        [Export("didSetConsent", ArgumentSemantic.Assign)]
        bool DidSetConsent {
            get;
            [Export("setDidSetConsent:")] set;
        }

        [Export("batchGenericParams", ArgumentSemantic.Retain)]
        NSDictionary BatchGenericParams {
            get;
            [Export("setBatchGenericParams:")] set;
        }

        [Export("eventGenericParams", ArgumentSemantic.Retain)]
        NSDictionary EventGenericParams {
            get;
            [Export("setEventGenericParams:")] set;
        }

        [Export("eventPixelParams", ArgumentSemantic.Retain)]
        NSDictionary EventPixelParams {
            get;
            [Export("setEventPixelParams:")] set;
        }

    }

    [BaseType(typeof(UIView))]
    partial interface ISDemandOnlyBannerView
    {
    }

    [BaseType(typeof(NSObject))]
    partial interface ISSupersonicAdsConfiguration
    {
        [Static]
        [Export("configurations")]
        ISSupersonicAdsConfiguration Configurations();

        [Export("language", ArgumentSemantic.Retain)]
        string Language {
            get;
            [Export("setLanguage:")] set;
        }

        [Export("minimumOfferCommission", ArgumentSemantic.Retain)]
        string MinimumOfferCommission {
            get;
            [Export("setMinimumOfferCommission:")] set;
        }

        [Export("controllerConfig", ArgumentSemantic.Retain)]
        NSDictionary ControllerConfig {
            get;
            [Export("setControllerConfig:")] set;
        }

        [Export("itemName", ArgumentSemantic.Retain)]
        string ItemName {
            get;
            [Export("setItemName:")] set;
        }

        [Export("controllerUrl", ArgumentSemantic.Retain)]
        string ControllerUrl {
            get;
            [Export("setControllerUrl:")] set;
        }

        [Export("itemCount", ArgumentSemantic.Retain)]
        NSNumber ItemCount {
            get;
            [Export("setItemCount:")] set;
        }

        [Export("maxVideoLength", ArgumentSemantic.Retain)]
        NSNumber MaxVideoLength {
            get;
            [Export("setMaxVideoLength:")] set;
        }

        [Export("privateKey", ArgumentSemantic.Retain)]
        string PrivateKey {
            get;
            [Export("setPrivateKey:")] set;
        }

        [Export("debugMode", ArgumentSemantic.Assign)]
        bool DebugMode {
            get;
            [Export("setDebugMode:")] set;
        }

        [Export("debugLevel", ArgumentSemantic.Assign)]
        nint DebugLevel {
            get;
            [Export("setDebugLevel:")] set;
        }

    }

    /// <summary>
    /// Object used to initialize IronSourceAds network.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface IronSourceAds
    {
        [Export("new")]
        [return: Release]
        IronSourceAds New();

        /// <summary>
        /// Initializes IronSourceAds SDK.
        /// </summary>
        /// <param name="request">The initialization request containing the necessary configurations for initialization.</param>
        /// <param name="completion">The completion for initialization. The completion will be invoked on the main thread.</param>
        [Static]
        [Export("initWithRequest:completion:")]
        void InitWithRequest(ISAInitRequest request, Action<bool, NSError> completion);

        /// <summary>
        /// Retrieve a string-based representation of the SDK version. The returned value will be in the form of "&lt;Major&gt;.&lt;Minor&gt;.&lt;Revision&gt;". NSString representing the current IronSource SDK version.
        /// </summary>
        [Static]
        [Export("sdkVersion")]
        string SdkVersion();

        /// <summary>
        /// Sets if IAds should allow debug logs. This value will be passed to the IAds Network. Default is NO.
        /// </summary>
        /// <param name="enable">YES to allow IAds Network debug logs, NO otherwise.</param>
        [Static]
        [Export("enableDebugMode:")]
        void EnableDebugMode(bool enable);

        /// <summary>
        /// Sets the meta data with a key and value. This value will be passed to the IronSourceAds network.
        /// </summary>
        /// <param name="key">The meta data key.</param>
        /// <param name="value">The meta data value</param>
        [Static]
        [Export("setMetaDataWithKey:value:")]
        void SetMetaDataWithKey(string key, string value);

        /// <summary>
        /// Sets the meta data with a key and values. This value will be passed to the IronSourceAds network.
        /// </summary>
        /// <param name="key">The meta data key.</param>
        /// <param name="values">The meta data values</param>
        [Static]
        [Export("setMetaDataWithKey:values:")]
        void SetMetaDataWithKey(string key, NSMutableArray values);

        /// <summary>
        /// Sets the consent value. Sets the consent, boolean value that indicates whether the user has granted consent for the SDK to collect and share data. Consent is used for GDPR compliance.
        /// </summary>
        /// <param name="consent">value.</param>
        [Static]
        [Export("setConsent:")]
        void SetConsent(bool consent);

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMImpressionData
    {
        [Export("initWithDictionary:")]
        NativeHandle Constructor(NSDictionary dictionary);

        [Export("initWithImpressionData:")]
        NativeHandle Constructor(LPMImpressionData impressionData);

        [Export("replacePlacementMacro:value:")]
        void ReplacePlacementMacro(string macro, string value);

        [Export("auctionId", ArgumentSemantic.Copy)]
        [NullAllowed]
        string AuctionId { get; }

        [Export("mediationAdUnitName", ArgumentSemantic.Copy)]
        [NullAllowed]
        string MediationAdUnitName { get; }

        [Export("mediationAdUnitId", ArgumentSemantic.Copy)]
        [NullAllowed]
        string MediationAdUnitId { get; }

        [Export("adFormat", ArgumentSemantic.Copy)]
        [NullAllowed]
        string AdFormat { get; }

        [Export("adNetwork", ArgumentSemantic.Copy)]
        [NullAllowed]
        string AdNetwork { get; }

        [Export("instanceName", ArgumentSemantic.Copy)]
        [NullAllowed]
        string InstanceName { get; }

        [Export("instanceId", ArgumentSemantic.Copy)]
        [NullAllowed]
        string InstanceId { get; }

        [Export("country", ArgumentSemantic.Copy)]
        [NullAllowed]
        string Country { get; }

        [Export("placement", ArgumentSemantic.Copy)]
        [NullAllowed]
        string Placement { get; }

        [Export("revenue", ArgumentSemantic.Copy)]
        [NullAllowed]
        NSNumber Revenue { get; }

        [Export("precision", ArgumentSemantic.Copy)]
        [NullAllowed]
        string Precision { get; }

        [Export("ab", ArgumentSemantic.Copy)]
        [NullAllowed]
        string Ab { get; }

        [Export("segmentName", ArgumentSemantic.Copy)]
        [NullAllowed]
        string SegmentName { get; }

        [Export("encryptedCpm", ArgumentSemantic.Copy)]
        [NullAllowed]
        string EncryptedCpm { get; }

        [Export("conversionValue", ArgumentSemantic.Copy)]
        [NullAllowed]
        NSNumber ConversionValue { get; }

        [Export("creativeId", ArgumentSemantic.Copy)]
        [NullAllowed]
        string CreativeId { get; }

        [Export("allData", ArgumentSemantic.Copy)]
        [NullAllowed]
        NSDictionary AllData { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISAdapterConfig
    {
        [Export("initWithProviderName:")]
        NativeHandle Constructor(string providerName);

        [Export("setSettings:")]
        void SetSettings(NSDictionary settings);

        [Export("setReflectionName:")]
        void SetReflectionName(string reflectionName);

        [Export("setLoadTimeOut:")]
        void SetLoadTimeOut(double loadTimeOut);

        [Export("setAdFormat:")]
        void SetAdFormat(string adFormat);

        [Export("isIronSource")]
        bool IsIronSource();

        [Export("setAppSettings:")]
        void SetAppSettings(NSDictionary appSettings);

        [Export("setInterstitialSettings:")]
        void SetInterstitialSettings(NSDictionary interstitialSettings);

        [Export("setRewardedVideoSettings:")]
        void SetRewardedVideoSettings(NSDictionary rewardedVideoSettings);

        [Export("setNativeAdSettings:")]
        void SetNativeAdSettings(NSDictionary nativeAdSettings);

        [Export("setProviderDefaultInstance:")]
        void SetProviderDefaultInstance(string providerDefaultInstance);

        [Export("setIsOneFlow:")]
        void SetIsOneFlow(bool isOneFlow);

        [Export("customNetworkAdapterNameForAdFormat:")]
        [return: NullAllowed]
        string CustomNetworkAdapterNameForAdFormat([NullAllowed] string adFormat);

        [Export("adUnitSettings")]
        NSDictionary AdUnitSettings();

        [Export("demandSourceName")]
        string DemandSourceName();

        [Export("isOneFlow")]
        NSNumber IsOneFlow();

        [Export("hasConsentCMP")]
        bool HasConsentCMP();

        [Export("getConsentCMP")]
        bool GetConsentCMP();

        [Export("settings", ArgumentSemantic.Retain)]
        NSDictionary Settings { get; }

        [Export("providerName", ArgumentSemantic.Retain)]
        string ProviderName { get; }

        [Export("reflectionName", ArgumentSemantic.Retain)]
        string ReflectionName { get; }

        [Export("name", ArgumentSemantic.Retain)]
        string Name { get; }

        [Export("requestUrl", ArgumentSemantic.Retain)]
        string RequestUrl { get; }

        [Export("subAdapterId", ArgumentSemantic.Retain)]
        string SubAdapterId { get; }

        [Export("instanceId", ArgumentSemantic.Retain)]
        string InstanceId { get; }

        [Export("maxAdsPerIteration", ArgumentSemantic.Retain)]
        NSNumber MaxAdsPerIteration { get; }

        [Export("maxAdsPerSession", ArgumentSemantic.Retain)]
        NSNumber MaxAdsPerSession { get; }

        [Export("instanceType", ArgumentSemantic.Retain)]
        string InstanceType { get; }

        [Export("maxAdsPerDay", ArgumentSemantic.Assign)]
        nint MaxAdsPerDay { get; }

        [Export("loadTimeOutSec", ArgumentSemantic.Assign)]
        double LoadTimeOutSec { get; }

        [Export("isMultiProviderInstance", ArgumentSemantic.Assign)]
        bool IsMultiProviderInstance { get; }

        [Export("adSourceNameForEvent", ArgumentSemantic.Retain)]
        string AdSourceNameForEvent { get; }

        [Export("isBidder", ArgumentSemantic.Assign)]
        bool IsBidder { get; }

        [Export("shouldEarlyInit", ArgumentSemantic.Assign)]
        bool ShouldEarlyInit { get; }

        [Export("adFormat", ArgumentSemantic.Retain)]
        string AdFormat { get; }

        [Export("appSettings", ArgumentSemantic.Retain)]
        NSDictionary AppSettings { get; }

        [Export("interstitialSettings", ArgumentSemantic.Retain)]
        NSDictionary InterstitialSettings { get; }

        [Export("rewardedVideoSettings", ArgumentSemantic.Retain)]
        NSDictionary RewardedVideoSettings { get; }

        [Export("bannerSettings", ArgumentSemantic.Retain)]
        NSDictionary BannerSettings {
            get;
            [Export("setBannerSettings:")] set;
        }

        [Export("nativeAdSettings", ArgumentSemantic.Retain)]
        NSDictionary NativeAdSettings { get; }

        [Export("providerDefaultInstance", ArgumentSemantic.Retain)]
        string ProviderDefaultInstance { get; }

        [Export("providerNetworkKey", ArgumentSemantic.Retain)]
        string ProviderNetworkKey { get; }

        [Export("customNetwork", ArgumentSemantic.Retain)]
        string CustomNetwork { get; }

        [Export("isCustomNetwork", ArgumentSemantic.Assign)]
        bool IsCustomNetwork { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISAdData
    {
        [Export("initWithServerData:configuration:adUnitData:")]
        NativeHandle Constructor([NullAllowed] string serverData, NSDictionary configuration, [NullAllowed] NSDictionary adUnitData);

        [Export("getString:")]
        [return: NullAllowed]
        string GetString(string key);

        [Export("getInt:")]
        nint GetInt(string key);

        [Export("getBoolean:")]
        bool GetBoolean(string key);

        [Export("getNumber:")]
        [return: NullAllowed]
        NSNumber GetNumber(string key);

        [Export("getAdUnitData")]
        [return: NullAllowed]
        NSDictionary GetAdUnitData();

        [Export("serverData", ArgumentSemantic.Retain)]
        [NullAllowed]
        string ServerData { get; }

        [Export("configuration", ArgumentSemantic.Retain)]
        NSDictionary Configuration { get; }

        [Export("adUnitData", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSDictionary AdUnitData { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMConfiguration
    {
        [Export("isAdQualityEnabled", ArgumentSemantic.Assign)]
        bool IsAdQualityEnabled {
            get;
            [Export("setIsAdQualityEnabled:")] set;
        }

        [Export("ab", ArgumentSemantic.Retain)]
        [NullAllowed]
        string Ab {
            get;
            [Export("setAb:")] set;
        }

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMInitRequest
    {
        [Export("new")]
        [return: Release]
        LPMInitRequest New();

        [Export("initWithAppKey:userId:")]
        NativeHandle Constructor(string appKey, [NullAllowed] string userId);

        [Export("appKey")]
        string AppKey { get; }

        [Export("legacyAdFormats")]
        // Element type: string
        string[] LegacyAdFormats { get; }

        [Export("userId")]
        [NullAllowed]
        string UserId { get; }

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LevelPlay
    {
        [Export("new")]
        [return: Release]
        LevelPlay New();

        /// <summary>
        /// Initializes the LevelPlay SDK with the provided request parameters.
        /// </summary>
        /// <param name="request">The  containing initialization parameters.</param>
        /// <param name="completion">A block called when the initialization process completes. It returns an `LPMConfiguration` object if successful, or an `NSError` describing the failure.</param>
        [Static]
        [Export("initWithRequest:completion:")]
        void InitWithRequest(LPMInitRequest request, Action<LPMConfiguration, NSError> completion);

        /// <summary>
        /// Retrieve a string-based representation of the SDK version. The returned value will be in the form of "&lt;Major&gt;.&lt;Minor&gt;.&lt;Revision&gt;". NSString representing the current IronSource SDK version.
        /// </summary>
        [Static]
        [Export("sdkVersion")]
        string SdkVersion();

        /// <summary>
        /// Adds the delegate for impression data callbacks. Publishers: use `setImpressionDataDelegate:` on each `LPMBannerAdView`, `LPMInterstitialAd`, or `LPMRewardedAd`.    Third-party SDKs: use `addImpressionLevelRevenueDelegate:forSubscriberId:`.
        /// </summary>
        /// <param name="delegate">The delegate for LevelPlay to send callbacks to.</param>
        [Static]
        [Export("addImpressionDataDelegate:")]
        void AddImpressionDataDelegate(ILPMImpressionDataDelegate @delegate);

        /// <summary>
        /// Removes the delegate from impression data callbacks. Publishers: use `setImpressionDataDelegate:nil` on each `LPMBannerAdView`, `LPMInterstitialAd`, or `LPMRewardedAd`.    Third-party SDKs: use `removeImpressionLevelRevenueDelegate:`.
        /// </summary>
        /// <param name="delegate">The delegate for LevelPlay to send callbacks to.</param>
        [Static]
        [Export("removeImpressionDataDelegate:")]
        void RemoveImpressionDataDelegate(ILPMImpressionDataDelegate @delegate);

        /// <summary>
        /// Adds impression level revenue data delegate callbacks for approved third-party SDKs.
        /// </summary>
        /// <param name="delegate">The delegate to receive impression data callbacks.</param>
        /// <param name="subscriberId">The identifier as provided by your Unity Partnership Manager.</param>
        [Static]
        [Export("addImpressionLevelRevenueDelegate:forSubscriberId:")]
        void AddImpressionLevelRevenueDelegate(ILPMImpressionDataDelegate @delegate, string subscriberId);

        /// <summary>
        /// Removes impression level revenue data delegate callbacks.
        /// </summary>
        /// <param name="delegate">The delegate to remove from impression data callbacks.</param>
        [Static]
        [Export("removeImpressionLevelRevenueDelegate:")]
        void RemoveImpressionLevelRevenueDelegate(ILPMImpressionDataDelegate @delegate);

        /// <summary>
        /// Sets the meta data with a key and value. This value will be passed to the supporting ad networks.
        /// </summary>
        /// <param name="key">The meta data key.</param>
        /// <param name="value">The meta data value</param>
        [Static]
        [Export("setMetaDataWithKey:value:")]
        void SetMetaDataWithKey(string key, string value);

        /// <summary>
        /// Sets the meta data with a key and values. This value will be passed to the supporting ad networks.
        /// </summary>
        /// <param name="key">The meta data key.</param>
        /// <param name="values">The meta data values.</param>
        [Static]
        [Export("setMetaDataWithKey:values:")]
        void SetMetaDataWithKey(string key, NSMutableArray values);

        /// <summary>
        /// Sets the network data according to the network key.
        /// </summary>
        /// <param name="networkKey">Network identifier.</param>
        /// <param name="networkData">a dictionary containing the information required by the network.</param>
        [Static]
        [Export("setNetworkDataWithNetworkKey:andNetworkData:")]
        void SetNetworkDataWithNetworkKey(string networkKey, NSDictionary networkData);

        /// <summary>
        /// Sets a dynamic identifier for the current user. `BOOL` that indicates if the dynamic identifier is valid.
        /// </summary>
        /// <param name="dynamicUserId">Dynamic user identifier.</param>
        [Static]
        [Export("setDynamicUserId:")]
        bool SetDynamicUserId(string dynamicUserId);

        /// <summary>
        /// Sets if LevelPlay SDK should allow ad networks debug logs.
        /// </summary>
        /// <param name="flag">to allow ad networks debug logs,.</param>
        [Static]
        [Export("setAdaptersDebug:")]
        void SetAdaptersDebug(bool flag);

        /// <summary>
        /// Sets a segment. This method is used to start a session with a spesific segment.
        /// </summary>
        /// <param name="segment">A segment object.</param>
        [Static]
        [Export("setSegment:")]
        void SetSegment(LPMSegment segment);

        /// <summary>
        /// Launches the Test Suite. Mediation SDK must be initialized before calling this method.
        /// </summary>
        /// <param name="viewController">The UIViewController to display the Test Suite within.</param>
        [Static]
        [Export("launchTestSuite:")]
        void LaunchTestSuite(UIViewController viewController);

        /// <summary>
        /// A tool to verify a successful integration of the IronSource SDK and any additional adapters. The Integration Helper tool portray the compatibility between the SDK and adapter versions, and makes sure all required dependencies and frameworks were added for the various mediated ad networks. Once you have finished your integration, call the 'validateIntegration' function and confirm that everything in your integration is marked as VERIFIED.
        /// </summary>
        [Static]
        [Export("validateIntegration")]
        void ValidateIntegration();

        /// <summary>
        /// Sets the consent value. Sets the consent, boolean value that indicates whether the user has granted consent for the SDK to collect and share data. Consent is used for GDPR compliance. This method is deprecated. Use `+[LPMPrivacySettings.setGDPRConsent:]` instead for GDPR consent management.
        /// </summary>
        /// <param name="consent">value.</param>
        [Static]
        [Export("setConsent:")]
        void SetConsent(bool consent);

    }

    [BaseType(typeof(NSObject))]
    partial interface ISBaseAdAdapter
    {
        /// <param name="adFormat">the ad format represented by the adapter</param>
        /// <param name="adapterConfig">the configuration relevant for the adapter instance</param>
        [Export("initWithAdFormat:adapterConfig:")]
        NativeHandle Constructor(string adFormat, ISAdapterConfig adapterConfig);

        /// <param name="adFormat">the ad format represented by the adapter</param>
        /// <param name="adapterConfig">the configuration relevant for the adapter instance</param>
        /// <param name="adUnitObjectId">the object id for the ad loaded</param>
        [Export("initWithAdFormat:adapterConfig:adUnitObjectId:")]
        NativeHandle Constructor(string adFormat, ISAdapterConfig adapterConfig, [NullAllowed] NSUuid adUnitObjectId);

        /// <summary>
        /// the network sdk version
        /// </summary>
        [Export("getNetworkAdapter")]
        [return: NullAllowed]
        IISAdapterBaseProtocol GetNetworkAdapter();

        /// <summary>
        /// destroy the ad
        /// </summary>
        /// <param name="adData">- data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        [Export("destroyAdWithAdData:")]
        void DestroyAdWithAdData(ISAdData adData);

        [Export("adFormat", ArgumentSemantic.Retain)]
        string AdFormat {
            get;
            [Export("setAdFormat:")] set;
        }

        [Export("adapterConfig")]
        ISAdapterConfig AdapterConfig { get; }

        [Export("adUnitObjectId")]
        [NullAllowed]
        NSUuid AdUnitObjectId { get; }

    }

    [BaseType(typeof(ISBaseAdAdapter))]
    partial interface ISBaseBanner : ISAdapterBannerProtocol
    {
        /// <param name="providerConfig">the configuration relevant for the adapter instance</param>
        [Export("init:")]
        [return: Release]
        ISBaseBanner Init(ISAdapterConfig providerConfig);

        /// <summary>
        /// load the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="viewController">the application view controller</param>
        /// <param name="size">the banner size the ad will be presented on</param>
        /// <param name="delegate">the callback listener to return mandatory callbacks based on the network - load success, load failure, ad opened optional callbacks - clicked, left application, presented, dismissed</param>
        [Export("loadAdWithAdData:viewController:size:delegate:")]
        void LoadAdWithAdData(ISAdData adData, UIViewController viewController, ISBannerSize size, IISBannerAdDelegate @delegate);

        /// <summary>
        /// destroy the ad
        /// </summary>
        /// <param name="adData">- data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        [Export("destroyAdWithAdData:")]
        void DestroyAdWithAdData(ISAdData adData);

    }

    [BaseType(typeof(ISBaseAdAdapter))]
    partial interface ISBaseAdInteractionAdapter : ISAdapterAdFullscreenProtocol
    {
    }

    [BaseType(typeof(ISBaseAdInteractionAdapter))]
    partial interface ISBaseInterstitial
    {
        /// <param name="providerConfig">the configuration relevant for the adapter instance</param>
        [Export("init:")]
        [return: Release]
        ISBaseInterstitial Init(ISAdapterConfig providerConfig);

        /// <summary>
        /// load the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="delegate">the delegate to return mandatory callbacks based on the network - load success, load failure</param>
        [Export("loadAdWithAdData:delegate:")]
        void LoadAdWithAdData(ISAdData adData, IISInterstitialAdDelegate @delegate);

        /// <summary>
        /// show the ad
        /// </summary>
        /// <param name="viewController">current viewController for showing the ad</param>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="delegate">the delegate to return mandatory callbacks based on the network - ad opened, ad closed, show failed optional callbacks - show success, ad clicked</param>
        [Export("showAdWithViewController:adData:delegate:")]
        void ShowAdWithViewController(UIViewController viewController, ISAdData adData, IISInterstitialAdDelegate @delegate);

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdDataImage
    {
        [Export("initWithImage:url:")]
        NativeHandle Constructor([NullAllowed] UIImage image, [NullAllowed] NSUrl url);

        [Export("new")]
        [return: Release]
        ISNativeAdDataImage New();

        [Export("image", ArgumentSemantic.Retain)]
        [NullAllowed]
        UIImage Image { get; }

        [Export("url", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSUrl Url { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISAdapterNativeAdData : ISNativeAdDataProtocol
    {
    }

    [BaseType(typeof(UIView))]
    partial interface LevelPlayMediaView
    {
    }

    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdViewHolder
    {
        [Export("iconView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UIImageView IconView {
            get;
            [Export("setIconView:")] set;
        }

        [Export("titleView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UILabel TitleView {
            get;
            [Export("setTitleView:")] set;
        }

        [Export("advertiserView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UILabel AdvertiserView {
            get;
            [Export("setAdvertiserView:")] set;
        }

        [Export("bodyView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UILabel BodyView {
            get;
            [Export("setBodyView:")] set;
        }

        [Export("mediaView", ArgumentSemantic.Weak)]
        [NullAllowed]
        LevelPlayMediaView MediaView {
            get;
            [Export("setMediaView:")] set;
        }

        [Export("callToActionView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UIButton CallToActionView {
            get;
            [Export("setCallToActionView:")] set;
        }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISAdapterNativeAdViewBinder : ISAdapterNativeAdViewBinderProtocol
    {
        [Export("adViewHolder", ArgumentSemantic.Retain)]
        [NullAllowed]
        ISNativeAdViewHolder AdViewHolder {
            get;
            [Export("setAdViewHolder:")] set;
        }

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISNativeAdProperties
    {
        [Export("initWithAdapterConfig:")]
        NativeHandle Constructor(ISAdapterConfig adapterConfig);

        [Export("initWithServerConfig:")]
        NativeHandle Constructor(NSDictionary serverConfig);

        [Export("new")]
        [return: Release]
        ISNativeAdProperties New();

        [Export("adOptionsPosition", ArgumentSemantic.Assign)]
        ISAdOptionsPosition AdOptionsPosition { get; }

    }

    [BaseType(typeof(ISBaseAdAdapter))]
    partial interface ISBaseNativeAd : ISAdapterNativeAdProtocol
    {
        /// <param name="providerConfig">the configuration relevant for the adapter instance</param>
        [Export("init:")]
        [return: Release]
        ISBaseNativeAd Init(ISAdapterConfig providerConfig);

        /// <summary>
        /// load the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="viewController">the application view controller</param>
        /// <param name="delegate">the callback listener to return mandatory callbacks based on the network - load success, load failure, ad opened optional callbacks - clicked, left application, presented, dismissed</param>
        [Export("loadAdWithAdData:viewController:delegate:")]
        void LoadAdWithAdData(ISAdData adData, UIViewController viewController, IISNativeAdDelegate @delegate);

        /// <summary>
        /// destroy the ad
        /// </summary>
        /// <param name="adData">- data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        [Export("destroyAdWithAdData:")]
        void DestroyAdWithAdData(ISAdData adData);

        /// <summary>
        /// Get the native ad properties from the ad data.
        /// </summary>
        /// <param name="adData">The ad data containing the native ad information.</param>
        [Export("getNativeAdPropertiesWithAdData:")]
        ISNativeAdProperties GetNativeAdPropertiesWithAdData(ISAdData adData);

    }

    [BaseType(typeof(NSObject))]
    partial interface ISBaseNetworkAdapter : ISAdapterBaseProtocol, ISAdapterDebugProtocol, ISAdapterConsentProtocol, ISAdapterNetworkDataProtocol
    {
    }

    [BaseType(typeof(ISBaseAdInteractionAdapter))]
    partial interface ISBaseRewardedVideo
    {
        /// <param name="providerConfig">the configuration relevant for the adapter instance</param>
        [Export("init:")]
        [return: Release]
        ISBaseRewardedVideo Init(ISAdapterConfig providerConfig);

        /// <summary>
        /// load the ad
        /// </summary>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="delegate">the delegate to return mandatory callbacks based on the network - load success, load failure</param>
        [Export("loadAdWithAdData:delegate:")]
        void LoadAdWithAdData(ISAdData adData, IISRewardedVideoAdDelegate @delegate);

        /// <summary>
        /// show the ad
        /// </summary>
        /// <param name="viewController">current viewController for showing the ad</param>
        /// <param name="adData">data containing the configuration passed from the server and other related parameters passed from the publisher like userId</param>
        /// <param name="delegate">the delegate to return mandatory callbacks based on the network - ad opened, ad closed, show failed optional callbacks - show success, ad clicked</param>
        [Export("showAdWithViewController:adData:delegate:")]
        void ShowAdWithViewController(UIViewController viewController, ISAdData adData, IISRewardedVideoAdDelegate @delegate);

    }

    [BaseType(typeof(NSObject))]
    partial interface ISDataKeys
    {
        [Static]
        [Export("USER_ID")]
        string USER_ID();

        [Static]
        [Export("AD_UNIT")]
        string AD_UNIT();

        [Static]
        [Export("AD_DATA_IS_MULTIPLE_AD_UNITS_FLOW")]
        string AD_DATA_IS_MULTIPLE_AD_UNITS_FLOW();

        [Static]
        [Export("AD_UNIT_ID")]
        string AD_UNIT_ID();

    }

    [BaseType(typeof(ISBaseNetworkAdapter))]
    partial interface LevelPlayBaseAdapter : ISAdapterAdaptiveProtocol, ISAdapterMetaDataProtocol, ISAdapterTestModeProtocol
    {
        [Static]
        [Export("networkAdapterVersion")]
        [return: NullAllowed]
        string NetworkAdapterVersion();

    }

    [BaseType(typeof(NSObject))]
    partial interface LevelPlayNativeAd : ISNativeAdDataProtocol
    {
        [Export("initWithBuilder:")]
        NativeHandle Constructor(LevelPlayNativeAdBuilder builder);

        [Export("loadAd")]
        void LoadAd();

        [Export("destroyAd")]
        void DestroyAd();

        [Export("setDelegate:")]
        void SetDelegate(ILevelPlayNativeAdDelegate @delegate);

        [Export("getObjectId")]
        string GetObjectId();

        [Export("nativeAdViewBinder", ArgumentSemantic.Retain)]
        [NullAllowed]
        ISAdapterNativeAdViewBinder NativeAdViewBinder {
            get;
            [Export("setNativeAdViewBinder:")] set;
        }

    }

    [BaseType(typeof(NSError))]
    partial interface ISError
    {
        [Static]
        [Export("createError:")]
        NSError CreateError(ISErrorCode errorCode);

        [Static]
        [Export("createError:withParams:")]
        NSError CreateError(ISErrorCode errorCode, NSArray @params);

        [Static]
        [Export("createError:withMessage:")]
        NSError CreateError(ISErrorCode errorCode, string message);

        [Static]
        [Export("createErrorWithDomain:code:message:")]
        NSError CreateErrorWithDomain(string domain, ISErrorCode code, string message);

        [Static]
        [Export("appendError:withPrefix:")]
        NSError AppendError(NSError error, string prefix);

        [Static]
        [Export("appendError:withSuffix:")]
        NSError AppendErrorWithSuffix(NSError error, string suffix);

        [Static]
        [Export("getCode:")]
        ISErrorCode GetCode(ISErrorCode errorCode);

        [Export("prefix", ArgumentSemantic.Retain)]
        string Prefix {
            get;
            [Export("setPrefix:")] set;
        }

        [Export("suffix", ArgumentSemantic.Retain)]
        string Suffix {
            get;
            [Export("setSuffix:")] set;
        }

    }

    [BaseType(typeof(NSObject))]
    partial interface LevelPlayNativeAdBuilder
    {
        [Export("withViewController:")]
        LevelPlayNativeAdBuilder WithViewController(UIViewController viewController);

        [Export("withPlacementName:")]
        LevelPlayNativeAdBuilder WithPlacementName(string placementName);

        [Export("withDelegate:")]
        LevelPlayNativeAdBuilder WithDelegate(ILevelPlayNativeAdDelegate @delegate);

        [Export("build")]
        LevelPlayNativeAd Build();

        [Export("placementName", ArgumentSemantic.Retain)]
        string PlacementName {
            get;
            [Export("setPlacementName:")] set;
        }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        LevelPlayNativeAdDelegate Delegate { get; set; }

        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate {
            get;
            [Export("setDelegate:")] set;
        }

        [Export("viewController", ArgumentSemantic.Weak)]
        UIViewController ViewController {
            get;
            [Export("setViewController:")] set;
        }

    }

    [BaseType(typeof(UIView))]
    partial interface ISNativeAdView
    {
        [Export("registerNativeAdViews:")]
        void RegisterNativeAdViews(LevelPlayNativeAd nativeAd);

        /// <summary>
        /// Weak reference to your ad view's icon asset view.
        /// </summary>
        [Export("adAppIcon", ArgumentSemantic.Weak)]
        [NullAllowed]
        UIImageView AdAppIcon {
            get;
            [Export("setAdAppIcon:")] set;
        }

        /// <summary>
        /// Weak reference to your ad view's headline asset view.
        /// </summary>
        [Export("adTitleView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UILabel AdTitleView {
            get;
            [Export("setAdTitleView:")] set;
        }

        /// <summary>
        /// Weak reference to your ad view's advertiser asset view.
        /// </summary>
        [Export("adAdvertiserView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UILabel AdAdvertiserView {
            get;
            [Export("setAdAdvertiserView:")] set;
        }

        /// <summary>
        /// Weak reference to your ad view's body asset view.
        /// </summary>
        [Export("adBodyView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UILabel AdBodyView {
            get;
            [Export("setAdBodyView:")] set;
        }

        /// <summary>
        /// Weak reference to your ad view's media asset view.
        /// </summary>
        [Export("adMediaView", ArgumentSemantic.Weak)]
        [NullAllowed]
        LevelPlayMediaView AdMediaView {
            get;
            [Export("setAdMediaView:")] set;
        }

        /// <summary>
        /// Weak reference to your ad view's call to action asset view.
        /// </summary>
        [Export("adCallToActionView", ArgumentSemantic.Weak)]
        [NullAllowed]
        UIButton AdCallToActionView {
            get;
            [Export("setAdCallToActionView:")] set;
        }

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMAdInfo
    {
        [Export("adId", ArgumentSemantic.Copy)]
        string AdId { get; }

        [Export("adUnitId", ArgumentSemantic.Copy)]
        string AdUnitId { get; }

        [Export("adUnitName", ArgumentSemantic.Copy)]
        string AdUnitName { get; }

        [Export("placementName", ArgumentSemantic.Copy)]
        [NullAllowed]
        string PlacementName { get; }

        [Export("adSize", ArgumentSemantic.Copy)]
        [NullAllowed]
        LPMAdSize AdSize { get; }

        [Export("adFormat", ArgumentSemantic.Copy)]
        string AdFormat { get; }

        [Export("auctionId", ArgumentSemantic.Copy)]
        string AuctionId { get; }

        [Export("country", ArgumentSemantic.Copy)]
        string Country { get; }

        [Export("ab", ArgumentSemantic.Copy)]
        string Ab { get; }

        [Export("segmentName", ArgumentSemantic.Copy)]
        string SegmentName { get; }

        [Export("adNetwork", ArgumentSemantic.Copy)]
        string AdNetwork { get; }

        [Export("instanceName", ArgumentSemantic.Copy)]
        string InstanceName { get; }

        [Export("instanceId", ArgumentSemantic.Copy)]
        string InstanceId { get; }

        [Export("revenue", ArgumentSemantic.Copy)]
        NSNumber Revenue { get; }

        [Export("precision", ArgumentSemantic.Copy)]
        string Precision { get; }

        [Export("encryptedCPM", ArgumentSemantic.Copy)]
        string EncryptedCPM { get; }

        [Export("conversionValue", ArgumentSemantic.Copy)]
        NSNumber ConversionValue { get; }

        [Export("creativeId", ArgumentSemantic.Copy)]
        string CreativeId { get; }

    }

    /// <summary>
    /// Class representing a banner ad configuration. Use `LPMBannerAdViewConfigBuilder` to create an instance of this class.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMBannerAdViewConfig
    {
        [Export("new")]
        [return: Release]
        LPMBannerAdViewConfig New();

        /// <summary>
        /// An ad size to be applied to the ad object.
        /// </summary>
        [Export("adSize", ArgumentSemantic.Retain)]
        [NullAllowed]
        LPMAdSize AdSize { get; }

        /// <summary>
        /// A bidding floor to be applied to the ad object.
        /// </summary>
        [Export("bidFloor", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSNumber BidFloor { get; }

        /// <summary>
        /// A placement name to be applied to the ad object.
        /// </summary>
        [Export("placementName", ArgumentSemantic.Retain)]
        [NullAllowed]
        string PlacementName { get; }

    }

    [DisableDefaultCtor]
    [BaseType(typeof(UIView))]
    partial interface LPMBannerAdView
    {
        [Export("new")]
        [return: Release]
        LPMBannerAdView New();

        [Export("initWithAdUnitId:")]
        NativeHandle Constructor(string adUnitId);

        [Export("initWithAdUnitId:config:")]
        NativeHandle Constructor(string adUnitId, LPMBannerAdViewConfig config);

        [Export("setDelegate:")]
        void SetDelegate(ILPMBannerAdViewDelegate @delegate);

        /// <summary>
        /// Sets a delegate for impression-level revenue data. The callback will be invoked on the main thread when an impression occurs for this specific ad instance.
        /// </summary>
        /// <param name="delegate">The delegate to set.</param>
        [Export("setImpressionDataDelegate:")]
        void SetImpressionDataDelegate([NullAllowed] ILPMImpressionDataDelegate @delegate);

        [Export("loadAdWithViewController:")]
        void LoadAdWithViewController(UIViewController viewController);

        [Export("destroy")]
        void Destroy();

        [Export("pauseAutoRefresh")]
        void PauseAutoRefresh();

        [Export("resumeAutoRefresh")]
        void ResumeAutoRefresh();

        /// <summary>
        /// A unique identifier associated with the ad object.
        /// </summary>
        [Export("adId", ArgumentSemantic.Retain)]
        string AdId { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMBannerAdViewConfigBuilder
    {
        /// <summary>
        /// Set an ad size to be applied to the ad object. The builder that had the setter called.
        /// </summary>
        /// <param name="adSize">an ad size.</param>
        [Export("setWithAdSize:")]
        LPMBannerAdViewConfigBuilder SetWithAdSize(LPMAdSize adSize);

        /// <summary>
        /// Set a bid floor to be applied to the ad object. The builder that had the setter called.
        /// </summary>
        /// <param name="bidFloor">bid floor value in USD.</param>
        [Export("setWithBidFloor:")]
        LPMBannerAdViewConfigBuilder SetWithBidFloor(NSNumber bidFloor);

        /// <summary>
        /// Set a placement name to be applied to the ad object. The builder that had the setter called.
        /// </summary>
        /// <param name="placementName">The placement name for the ad.</param>
        [Export("setWithPlacementName:")]
        LPMBannerAdViewConfigBuilder SetWithPlacementName(string placementName);

        /// <summary>
        /// a banner ad configuration from this builder
        /// </summary>
        [Export("build")]
        LPMBannerAdViewConfig Build();

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMInitRequestBuilder
    {
        [Export("new")]
        [return: Release]
        LPMInitRequestBuilder New();

        [Export("initWithAppKey:")]
        NativeHandle Constructor(string appKey);

        [Export("build")]
        LPMInitRequest Build();

        [Export("withUserId:")]
        LPMInitRequestBuilder WithUserId(string userId);

    }

    /// <summary>
    /// Class responsible for handling the APIs, callbacks and overall operations of an interstitial ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMInterstitialAd
    {
        [Export("new")]
        [return: Release]
        LPMInterstitialAd New();

        /// <summary>
        /// Initializes an interstitial ad.
        /// </summary>
        /// <param name="adUnitId">The ad unit identifier.</param>
        [Export("initWithAdUnitId:")]
        NativeHandle Constructor(string adUnitId);

        /// <summary>
        /// Initializes an interstitial ad with configuration.
        /// </summary>
        /// <param name="adUnitId">The ad unit identifier.</param>
        /// <param name="config">The ad configuration.</param>
        [Export("initWithAdUnitId:config:")]
        NativeHandle Constructor(string adUnitId, LPMInterstitialAdConfig config);

        /// <summary>
        /// Sets a delegate for the ad callbacks. The callbacks will be invoked on the main thread. The delegate is held weakly.
        /// </summary>
        /// <param name="delegate">The delegate to set.</param>
        [Export("setDelegate:")]
        void SetDelegate(ILPMInterstitialAdDelegate @delegate);

        /// <summary>
        /// Sets a delegate for impression-level revenue data. The callback will be invoked on the main thread when an impression occurs for this specific ad instance.
        /// </summary>
        /// <param name="delegate">The delegate to set.</param>
        [Export("setImpressionDataDelegate:")]
        void SetImpressionDataDelegate([NullAllowed] ILPMImpressionDataDelegate @delegate);

        /// <summary>
        /// Loads an interstitial ad. The delegate will send a `didLoadAdWithAdInfo:` or `didFailToLoadAdWithAdUnitId: error:` callback. The callbacks will be invoked on the main thread.
        /// </summary>
        [Export("loadAd")]
        void LoadAd();

        /// <summary>
        /// Shows the ad. The delegate will send a `interstitialAdDidShow:` or `interstitialAd:didFailToShowWithError:` callback.
        /// </summary>
        /// <param name="viewController">The view controller where the ad will be shown.</param>
        /// <param name="placementName">The placement name for the ad.</param>
        [Export("showAdWithViewController:placementName:")]
        void ShowAdWithViewController(UIViewController viewController, [NullAllowed] string placementName);

        /// <summary>
        /// Checks if the ad is ready. Showing an ad that is not ready will result in a show failure. When calling to the show api with placement, make sure to verify that placement isn't capped via `isPlacementCapped:`. Whether the ad is ready.
        /// </summary>
        [Export("isAdReady")]
        bool IsAdReady();

        /// <summary>
        /// Checks if the placement is capped. `YES` if the placement is capped, `NO` otherwise.
        /// </summary>
        /// <param name="placementName">The placement name to check.</param>
        [Static]
        [Export("isPlacementCapped:")]
        bool IsPlacementCapped(string placementName);

        /// <summary>
        /// A unique identifier associated with the ad object.
        /// </summary>
        [Export("adId", ArgumentSemantic.Retain)]
        string AdId { get; }

    }

    /// <summary>
    /// Class representing an interstitial ad configuration. Use `LPMInterstitialAdConfigBuilder` to create an instance of this class.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMInterstitialAdConfig
    {
        [Export("new")]
        [return: Release]
        LPMInterstitialAdConfig New();

        /// <summary>
        /// A NSNumber bidding floor to be applied to the ad object.
        /// </summary>
        [Export("bidFloor", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSNumber BidFloor { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMInterstitialAdConfigBuilder
    {
        /// <summary>
        /// Set a bid floor to be applied to the ad object. The builder that had the setter called.
        /// </summary>
        /// <param name="bidFloor">bid floor value in USD.</param>
        [Export("setWithBidFloor:")]
        LPMInterstitialAdConfigBuilder SetWithBidFloor(NSNumber bidFloor);

        /// <summary>
        /// an interstitial ad configuration from this builder
        /// </summary>
        [Export("build")]
        LPMInterstitialAdConfig Build();

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMPrivacySettings
    {
        /// <summary>
        /// Sets the consent per network, a dictionary of network keys to boolean values that indicates whether the user has granted consent for each network to collect and share data. Consent is used for GDPR compliance. This method is deprecated. Use `+[LPMPrivacySettings.setGDPRConsent:]` instead for GDPR consent management.
        /// </summary>
        /// <param name="networkConsents">A dictionary where keys are network identifiers (NSString) and values are NSNumber objects wrapping boolean values (YES if the user has granted consent, NO otherwise).</param>
        [Static]
        [Export("setGDPRConsents:")]
        // Parameter 'networkConsents': Key type: string, Value type: NSNumber
        void SetGDPRConsents(NSDictionary<NSString, NSNumber> networkConsents);

        /// <summary>
        /// Sets the GDPR consent, indicating whether the user has granted consent to collect and share their data. Consent is used for GDPR compliance.
        /// </summary>
        /// <param name="consent">A boolean indicating the user's GDPR consent status, true if the user has   granted consent, false otherwise.</param>
        [Static]
        [Export("setGDPRConsent:")]
        void SetGDPRConsent(bool consent);

        /// <summary>
        /// Sets the CCPA (California Consumer Privacy Act) flag. This flag indicates whether the user has opted out of the sale of their personal information.
        /// </summary>
        /// <param name="value">YES if the user has opted out of the sale of their personal information, NO otherwise.</param>
        [Static]
        [Export("setCCPA:")]
        void SetCCPA(bool value);

        /// <summary>
        /// Sets the COPPA (Children's Online Privacy Protection Act) flag. This flag indicates whether the user is a child and the app should comply with COPPA regulations. Must be called before SDK initialization. If the SDK is already initialized, this call is ignored and an error is logged.
        /// </summary>
        /// <param name="value">YES if the user is a child and COPPA compliance is required, NO otherwise.</param>
        [Static]
        [Export("setCOPPA:")]
        void SetCOPPA(bool value);

    }

    /// <summary>
    /// Class representing a reward for an ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMReward
    {
        [Export("new")]
        [return: Release]
        LPMReward New();

        [Export("initWithName:amount:")]
        NativeHandle Constructor(string name, nint amount);

        /// <summary>
        /// The amount of the reward.
        /// </summary>
        [Export("amount")]
        nint Amount { get; }

        /// <summary>
        /// The name of the reward.
        /// </summary>
        [Export("name", ArgumentSemantic.Retain)]
        string Name { get; }

    }

    /// <summary>
    /// Class responsible for handling the APIs, callbacks and overall operations of a rewarded ad.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMRewardedAd
    {
        [Export("new")]
        [return: Release]
        LPMRewardedAd New();

        /// <summary>
        /// Initializes a rewarded ad.
        /// </summary>
        /// <param name="adUnitId">The ad unit identifier.</param>
        [Export("initWithAdUnitId:")]
        NativeHandle Constructor(string adUnitId);

        /// <summary>
        /// Initializes a rewarded ad.
        /// </summary>
        /// <param name="adUnitId">The ad unit identifier.</param>
        /// <param name="config">The ad configuration.</param>
        [Export("initWithAdUnitId:config:")]
        NativeHandle Constructor(string adUnitId, LPMRewardedAdConfig config);

        /// <summary>
        /// Sets a delegate for the ad callbacks. The callbacks will be invoked on the main thread. The delegate is held weakly.
        /// </summary>
        /// <param name="delegate">The delegate to set.</param>
        [Export("setDelegate:")]
        void SetDelegate(ILPMRewardedAdDelegate @delegate);

        /// <summary>
        /// Sets a delegate for impression-level revenue data. The callback will be invoked on the main thread when an impression occurs for this specific ad instance.
        /// </summary>
        /// <param name="delegate">The delegate to set.</param>
        [Export("setImpressionDataDelegate:")]
        void SetImpressionDataDelegate([NullAllowed] ILPMImpressionDataDelegate @delegate);

        /// <summary>
        /// Loads a rewarded ad. The delegate will send a `didLoadAdWithAdInfo:` or `didFailToLoadAdWithAdUnitId: error:` callback. The callbacks will be invoked on the main thread.
        /// </summary>
        [Export("loadAd")]
        void LoadAd();

        /// <summary>
        /// Shows the ad. The delegate will send a `rewardedAdDidShow:` or `rewardedAd:didFailToShowWithError:` callback.
        /// </summary>
        /// <param name="viewController">The view controller where the ad will be shown.</param>
        /// <param name="placementName">The placement name for the ad.</param>
        [Export("showAdWithViewController:placementName:")]
        void ShowAdWithViewController(UIViewController viewController, [NullAllowed] string placementName);

        /// <summary>
        /// Checks if the ad is ready. Showing an ad that is not ready will result in a show failure. When calling to the show api with placement, make sure to verify that placement isn't capped via `isPlacementCapped:`. Whether the ad is ready.
        /// </summary>
        [Export("isAdReady")]
        bool IsAdReady();

        /// <summary>
        /// Retrieves the reward associated with the ad. Use this method to obtain the reward configured for the ad unit or placement. The placement-specific reward takes precedence over the ad unit reward when a valid placement name is provided. A `LPMReward` object. Returns an empty reward on failures (`name: ""` and `amount: 0`).
        /// </summary>
        /// <param name="placement">The placement name to retrieve the reward for, or `nil` to use the ad unit's reward.</param>
        [Export("getRewardWithPlacementName:")]
        LPMReward GetRewardWithPlacementName([NullAllowed] string placement);

        /// <summary>
        /// Checks if the placement is capped. `YES` if the placement is capped, `NO` otherwise.
        /// </summary>
        /// <param name="placementName">The placement name to check.</param>
        [Static]
        [Export("isPlacementCapped:")]
        bool IsPlacementCapped(string placementName);

        /// <summary>
        /// A unique identifier associated with the ad object.
        /// </summary>
        [Export("adId", ArgumentSemantic.Retain)]
        string AdId { get; }

    }

    /// <summary>
    /// Class representing a rewarded ad configuration. Use `LPMRewardedAdConfigBuilder` to create an instance of this class.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface LPMRewardedAdConfig
    {
        [Export("new")]
        [return: Release]
        LPMRewardedAdConfig New();

        /// <summary>
        /// A NSNumber bidding floor to be applied to the ad object.
        /// </summary>
        [Export("bidFloor", ArgumentSemantic.Retain)]
        [NullAllowed]
        NSNumber BidFloor { get; }

    }

    [BaseType(typeof(NSObject))]
    partial interface LPMRewardedAdConfigBuilder
    {
        /// <summary>
        /// Set a bid floor to be applied to the ad object. The builder that had the setter called.
        /// </summary>
        /// <param name="bidFloor">bid floor value in USD.</param>
        [Export("setWithBidFloor:")]
        LPMRewardedAdConfigBuilder SetWithBidFloor(NSNumber bidFloor);

        /// <summary>
        /// a rewarded ad configuration from this builder
        /// </summary>
        [Export("build")]
        LPMRewardedAdConfig Build();

    }

    [BaseType(typeof(NSObject))]
    partial interface ISBaseAdUnitAdapter : ISNetworkInitCallbackProtocol
    {
        [Export("getStringValueFromAdapterConfig:forKey:")]
        string GetStringValueFromAdapterConfig(ISAdapterConfig adapterConfig, string key);

        [Export("getMissingParamErrorStringWithKey:")]
        string GetMissingParamErrorStringWithKey(string key);

    }

    [BaseType(typeof(ISBaseAdUnitAdapter))]
    partial interface ISBaseNativeAdAdapter : ISNativeAdAdapterProtocol
    {
        [Export("getNativeAdPropertiesWithAdapterConfig:")]
        ISNativeAdProperties GetNativeAdPropertiesWithAdapterConfig(ISAdapterConfig adapterConfig);

    }

    [BaseType(typeof(NSObject))]
    partial interface ISConcurrentMutableDictionary : LPMThreadSafeDictionaryProtocol
    {
        [Static]
        [Export("dictionary")]
        ISConcurrentMutableDictionary Dictionary();

        [Static]
        [Export("lpmDictionary")]
        ILPMThreadSafeDictionaryProtocol LpmDictionary();

    }

    [BaseType(typeof(NSObject))]
    partial interface ISBaseAdapter : ISInterstitialAdapterProtocol, ISRewardedVideoAdapterProtocol, ISBannerAdapterProtocol, ISAdapterNetworkDataProtocol, ISNativeAdAdapterProtocol
    {
        [Export("initAdapter:")]
        [return: Release]
        ISBaseAdapter InitAdapter(string name);

        [Export("earlyInitWithAdapterConfig:")]
        void EarlyInitWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("sdkVersion")]
        string SdkVersion();

        [Export("version")]
        string Version();

        [Export("dynamicUserId")]
        string DynamicUserId();

        [Static]
        [Export("networkAdapterVersion")]
        [return: NullAllowed]
        string NetworkAdapterVersion();

        [Export("getLWSSupportState:")]
        ISLoadWhileShowSupportState GetLWSSupportState(ISAdapterConfig adapterConfig);

        [Export("setNetworkData:")]
        void SetNetworkData(IISAdapterNetworkData networkData);

        [Export("setRewardedVideoAdapter:")]
        void SetRewardedVideoAdapter(IISRewardedVideoAdapterProtocol rewardedVideoAdapter);

        [Export("setInterstitialAdapter:")]
        void SetInterstitialAdapter(IISInterstitialAdapterProtocol interstitialAdapter);

        [Export("setBannerAdapter:")]
        void SetBannerAdapter(IISBannerAdapterProtocol bannerAdapter);

        [Export("setNativeAdAdapter:")]
        void SetNativeAdAdapter(IISNativeAdAdapterProtocol nativeAdAdapter);

        [Export("setConsent:")]
        void SetConsent(bool consent);

        [Export("setTestMode:")]
        void SetTestMode(bool enabled);

        [Export("getRewardedVideoAdapter")]
        IISRewardedVideoAdapterProtocol GetRewardedVideoAdapter();

        [Export("getInterstitialAdapter")]
        IISInterstitialAdapterProtocol GetInterstitialAdapter();

        [Export("getBannerAdapter")]
        IISBannerAdapterProtocol GetBannerAdapter();

        [Export("getNativeAdAdapter")]
        IISNativeAdAdapterProtocol GetNativeAdAdapter();

        [Export("getAdaptiveHeightWithWidth:")]
        nfloat GetAdaptiveHeightWithWidth(nfloat width);

        [Export("destroyRewardedVideoAdWithAdapterConfig:")]
        void DestroyRewardedVideoAdWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("destroyInterstitialAdWithAdapterConfig:")]
        void DestroyInterstitialAdWithAdapterConfig(ISAdapterConfig adapterConfig);

        [Export("isConfigValueValid:")]
        bool IsConfigValueValid(string value);

        [Export("errorForMissingCredentialFieldWithName:")]
        NSError ErrorForMissingCredentialFieldWithName(string fieldName);

        [Export("topMostController")]
        UIViewController TopMostController();

        [Export("setMetaDataWithKey:andValues:")]
        void SetMetaDataWithKey(string key, NSMutableArray values);

        [Export("adapterName", ArgumentSemantic.Retain)]
        string AdapterName {
            get;
            [Export("setAdapterName:")] set;
        }

        [Export("providerNetworkKey", ArgumentSemantic.Retain)]
        string ProviderNetworkKey {
            get;
            [Export("setProviderNetworkKey:")] set;
        }

        [Export("pluginType", ArgumentSemantic.Retain)]
        string PluginType {
            get;
            [Export("setPluginType:")] set;
        }

        [Export("userId", ArgumentSemantic.Retain)]
        string UserId {
            get;
            [Export("setUserId:")] set;
        }

        [Export("adUnitAdapters", ArgumentSemantic.Retain)]
        ILPMThreadSafeDictionaryProtocol AdUnitAdapters {
            get;
            [Export("setAdUnitAdapters:")] set;
        }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISMetaData
    {
        [Export("initWithKey:andValues:")]
        NativeHandle Constructor(string key, NSMutableArray values);

        [Export("initWithKey:values:andValuesType:")]
        NativeHandle Constructor(string key, NSMutableArray values, NSMutableArray valuesType);

        [Export("key", ArgumentSemantic.Retain)]
        string Key {
            get;
            [Export("setKey:")] set;
        }

        [Export("values", ArgumentSemantic.Retain)]
        NSMutableArray Values {
            get;
            [Export("setValues:")] set;
        }

        [Export("valuesType", ArgumentSemantic.Retain)]
        NSMutableArray ValuesType {
            get;
            [Export("setValuesType:")] set;
        }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISMetaDataUtils
    {
        [Static]
        [Export("getValueTypeForKey:")]
        ISMetaDataValueTypes GetValueTypeForKey(string key);

        [Static]
        [Export("isKnownKey:")]
        bool IsKnownKey(string key);

        [Static]
        [Export("isMediationOnlyKey:")]
        bool IsMediationOnlyKey(string key);

        [Static]
        [Export("formatValue:forType:")]
        string FormatValue(string value, ISMetaDataValueTypes valueType);

        [Static]
        [Export("formatMetaDataKey:andValues:")]
        ISMetaData FormatMetaDataKey(string key, NSMutableArray values);

        [Static]
        [Export("isMetaDataKeyValid:error:")]
        bool IsMetaDataKeyValid(string key, IntPtr error);

        [Static]
        [Export("isMetaDataValuesValid:error:")]
        bool IsMetaDataValuesValid(NSMutableArray values, IntPtr error);

        [Static]
        [Export("isValidCCPAMetaDataWithKey:andValue:")]
        bool IsValidCCPAMetaDataWithKey(string key, string value);

        [Static]
        [Export("isValidMetaDataWithKey:flag:andValue:")]
        bool IsValidMetaDataWithKey(string key, string flag, string value);

        [Static]
        [Export("getMetaDataBooleanValue:")]
        bool GetMetaDataBooleanValue(string value);

    }

    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    partial interface ISConcurrentMutableSet
    {
        [Static]
        [Export("set")]
        ISConcurrentMutableSet Set();

        [Static]
        [Export("setWithSet:")]
        ISConcurrentMutableSet SetWithSet(NSObject set);

        [Export("initCommon")]
        [return: Release]
        ISConcurrentMutableSet InitCommon();

        [Export("initWithCapacity:")]
        NativeHandle Constructor(nuint numItems);

        [Export("initWithCoder:")]
        NativeHandle Constructor(NSCoder aDecoder);

        [Export("initWithSet:")]
        NativeHandle Constructor(NSMutableSet set);

        [Export("initWithArray:")]
        NativeHandle Constructor(NSArray array);

        [Export("count")]
        nuint Count();

        [Export("addObject:")]
        void AddObject(NSObject @object);

        [Export("removeObject:")]
        void RemoveObject(NSObject @object);

        [Export("addObjectsFromArray:")]
        void AddObjectsFromArray(NSArray array);

        [Export("intersectSet:")]
        void IntersectSet(NSSet otherSet);

        [Export("minusSet:")]
        void MinusSet(NSSet otherSet);

        [Export("removeAllObjects")]
        void RemoveAllObjects();

        [Export("unionSet:")]
        void UnionSet(NSSet otherSet);

        [Export("allObjects")]
        NSArray AllObjects();

        [Export("hasObject:")]
        bool HasObject(NSObject @object);

        [Export("objectEnumerator")]
        NSEnumerator ObjectEnumerator();

    }

    [BaseType(typeof(NSObject))]
    partial interface ISLoggerManager
    {
        [Static]
        [Export("sharedInstance")]
        ISLoggerManager SharedInstance();

        [Export("setLoggingLevels:publisher:console:")]
        void SetLoggingLevels(nint server, nint publisher, nint console);

        [Export("log:level:tag:")]
        void Log(string message, LogLevelValues logLevel, LogTagValue logTag);

        [Export("logFromError:level:tag:")]
        void LogFromError(NSError error, LogLevelValues logLevel, LogTagValue logTag);

        [Export("logFromException:level:tag:")]
        void LogFromException(NSException exception, LogLevelValues logLevel, LogTagValue logTag);

        [Export("logFromException:message:level:tag:")]
        void LogFromException(NSException exception, string message, LogLevelValues logLevel, LogTagValue logTag);

        [Export("dynamicLog:message:level:withTag:")]
        void DynamicLog(out byte calledFrom, string message, LogLevelValues logLevel, LogTagValue logTag);

        [Export("automationLog:level:withTag:")]
        void AutomationLog(string message, LogLevelValues logLevel, LogTagValue logTag);

    }

    [BaseType(typeof(NSObject))]
    partial interface ISLog
    {
    }

    [BaseType(typeof(ISBaseAdUnitAdapter))]
    partial interface ISBaseBannerAdapter : ISBannerAdapterProtocol
    {
    }

    [BaseType(typeof(ISBaseAdUnitAdapter))]
    partial interface ISBaseInterstitialAdapter : ISInterstitialAdapterProtocol
    {
    }

    [BaseType(typeof(ISBaseAdUnitAdapter))]
    partial interface ISBaseRewardedVideoAdapter : ISRewardedVideoAdapterProtocol
    {
    }

    [BaseType(typeof(ISBaseAdapter))]
    partial interface ISIronSourceAdapter
    {
        [Export("initSDK:")]
        void InitSDK(ISAdapterConfig adapterConfig);

        [Export("createInitExtraParams")]
        NSDictionary CreateInitExtraParams();

    }

    [BaseType(typeof(NSObject))]
    partial interface ISNAdViewsManagerSwiftFacade : ISNAdViewsManagerSwiftFacadeProtocol
    {
    }

    [BaseType(typeof(NSObject))]
    partial interface ISNControllerManagerSwiftFacade
    {
        [Export("setControllerMessageListenerWithAdId:listener:")]
        void SetControllerMessageListenerWithAdId(string adId, IISNControllerMessageListener listener);

        [Export("removeControllerMessageListenerWithAdId:")]
        void RemoveControllerMessageListenerWithAdId(string adId);

    }

    [BaseType(typeof(NSObject))]
    partial interface ISNEvent
    {
        [Export("initWithEventId:eventName:")]
        NativeHandle Constructor(NSNumber eventId, string eventName);

        [Export("eventName", ArgumentSemantic.Retain)]
        string EventName {
            get;
            [Export("setEventName:")] set;
        }

        [Export("eventId", ArgumentSemantic.Retain)]
        NSNumber EventId {
            get;
            [Export("setEventId:")] set;
        }

    }

    [BaseType(typeof(NSObject))]
    partial interface ISNEventTrackerWrapper : ISNEventTrackerInterface
    {
    }

    [BaseType(typeof(NSObject))]
    partial interface ISNSupersonicAdsPublisherSwiftFacade
    {
        [Export("setControllerConfig:")]
        void SetControllerConfig(string config);

    }

    [BaseType(typeof(NSObject))]
    partial interface IronSource
    {
        /// <summary>
        /// Retrieve a string-based representation of the SDK version. The returned value will be in the form of "&lt;Major&gt;.&lt;Minor&gt;.&lt;Revision&gt;". NSString representing the current IronSource SDK version.
        /// </summary>
        [Static]
        [Export("sdkVersion")]
        string SdkVersion();

        /// <summary>
        /// Sets a mediation type. This method is used only for IronSource's SDK, and will be passed as a custom param.
        /// </summary>
        /// <param name="mediationType">a mediation type name. Should be alphanumeric and between 1-64 chars in length.</param>
        [Static]
        [Export("setMediationType:")]
        void SetMediationType(string mediationType);

        /// <summary>
        /// used for demand only API, return the bidding data token.
        /// </summary>
        [Static]
        [Export("getISDemandOnlyBiddingData")]
        string GetISDemandOnlyBiddingData();

        /// <summary>
        /// Sets the delegate for demand only rewarded video callbacks.
        /// </summary>
        /// <param name="delegate">The 'ISDemandOnlyRewardedVideoDelegate' for IronSource to send callbacks to.</param>
        [Static]
        [Export("setISDemandOnlyRewardedVideoDelegate:")]
        void SetISDemandOnlyRewardedVideoDelegate(IISDemandOnlyRewardedVideoDelegate @delegate);

        /// <summary>
        /// Loads a demand only rewarded video for a non bidder instance. This method will load a demand only rewarded video ad for a non bidder instance.
        /// </summary>
        /// <param name="instanceId">The demand only instance id to be used to display the rewarded video.</param>
        [Static]
        [Export("loadISDemandOnlyRewardedVideo:")]
        void LoadISDemandOnlyRewardedVideo(string instanceId);

        /// <summary>
        /// Shows a demand only rewarded video using the default placement.
        /// </summary>
        /// <param name="viewController">The UIViewController to display the rewarded video within.</param>
        /// <param name="instanceId">The demand only instance id to be used to display the rewarded video.</param>
        [Static]
        [Export("showISDemandOnlyRewardedVideo:instanceId:")]
        void ShowISDemandOnlyRewardedVideo(UIViewController viewController, string instanceId);

        /// <summary>
        /// Determine if a locally cached demand only rewarded video exists for an instance id. A return value of YES here indicates that there is a cached rewarded video for the instance id. YES if rewarded video is ready to be played, NO otherwise.
        /// </summary>
        /// <param name="instanceId">The demand only instance id to be used to display the rewarded video.</param>
        [Static]
        [Export("hasISDemandOnlyRewardedVideo:")]
        bool HasISDemandOnlyRewardedVideo(string instanceId);

        /// <summary>
        /// Sets the delegate for demand only interstitial callbacks.
        /// </summary>
        /// <param name="delegate">The 'ISDemandOnlyInterstitialDelegate' for IronSource to send callbacks to.</param>
        [Static]
        [Export("setISDemandOnlyInterstitialDelegate:")]
        void SetISDemandOnlyInterstitialDelegate(IISDemandOnlyInterstitialDelegate @delegate);

        /// <summary>
        /// Loads a demand only interstitial. This method will load a demand only interstitial ad.
        /// </summary>
        /// <param name="instanceId">The demand only instance id to be used to display the interstitial.</param>
        [Static]
        [Export("loadISDemandOnlyInterstitial:")]
        void LoadISDemandOnlyInterstitial(string instanceId);

        /// <summary>
        /// Show a demand only interstitial using the default placement.
        /// </summary>
        /// <param name="viewController">The UIViewController to display the interstitial within.</param>
        /// <param name="instanceId">The demand only instance id to be used to display the interstitial.</param>
        [Static]
        [Export("showISDemandOnlyInterstitial:instanceId:")]
        void ShowISDemandOnlyInterstitial(UIViewController viewController, string instanceId);

        /// <summary>
        /// Determine if a locally cached interstitial exists for a demand only instance id. A return value of YES here indicates that there is a cached interstitial for the instance id. YES if there is a locally cached interstitial, NO otherwise.
        /// </summary>
        /// <param name="instanceId">The demand only instance id to be used to display the interstitial.</param>
        [Static]
        [Export("hasISDemandOnlyInterstitial:")]
        bool HasISDemandOnlyInterstitial(string instanceId);

        /// <summary>
        /// Sets the delegate for demand only Banner callbacks.
        /// </summary>
        /// <param name="delegate">The 'ISDemandOnlyBannerDelegate' for IronSource to send callbacks to.</param>
        /// <param name="instanceId">The instance id on which the delegate will notify.</param>
        [Static]
        [Export("setISDemandOnlyBannerDelegate:forInstanceId:")]
        void SetISDemandOnlyBannerDelegate(IISDemandOnlyBannerDelegate @delegate, string instanceId);

        /// <summary>
        /// Loads a demand only Banner for a non bidder instance. This method will load a demand only Banner ad for a non bidder instance.
        /// </summary>
        /// <param name="instanceId">The demand only instance id to be used to display the Banner.</param>
        /// <param name="viewController">The view controller on which the banner should be presented</param>
        /// <param name="size">The required banner ad size</param>
        [Static]
        [Export("loadISDemandOnlyBannerWithInstanceId:viewController:size:")]
        void LoadISDemandOnlyBannerWithInstanceId(string instanceId, UIViewController viewController, ISBannerSize size);

        /// <summary>
        /// Removes the banner from memory.
        /// </summary>
        /// <param name="instanceId">The demand only instance id of the Banner that should be destroyed.</param>
        [Static]
        [Export("destroyISDemandOnlyBannerWithInstanceId:")]
        void DestroyISDemandOnlyBannerWithInstanceId(string instanceId);

        /// <summary>
        /// Ad revenue data
        /// </summary>
        /// <param name="dataSource">the external source id from which the impression data is sent.</param>
        /// <param name="impressionData">the impression data</param>
        [Static]
        [Export("setAdRevenueDataWithDataSource:impressionData:")]
        void SetAdRevenueDataWithDataSource(string dataSource, NSData impressionData);

    }

    [Category]
    [BaseType(typeof(UIView))]
    partial interface UIView_ISNativeView
    {
        [Export("addSubviewAndAdjust:")]
        void AddSubviewAndAdjust(UIView view);

    }

}
