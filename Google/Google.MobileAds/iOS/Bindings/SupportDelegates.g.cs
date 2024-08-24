//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds {
	#nullable enable
	public delegate void AdInspectorCompletionHandler (NSError? error);
	public delegate void AppOpenAdLoadCompletionHandler (Google.MobileAds.AppOpenAd? appOpenAd, NSError? error);
	public delegate void InitializationCompletionHandler (Google.MobileAds.InitializationStatus status);
	public delegate void InterstitialAdLoadCompletionHandler (Google.MobileAds.InterstitialAd? interstitialAd, NSError? error);
	public delegate void NativeAdCustomClickHandle (string assetId);
	public delegate void PaidEventHandler (Google.MobileAds.AdValue value);
	public delegate void RewardedAdLoadCompletionHandler (Google.MobileAds.RewardedAd? rewardedAd, NSError? error);
	public delegate void RewardedInterstitialAdLoadCompletionHandler (Google.MobileAds.RewardedInterstitialAd? rewardedInterstitialAd, NSError? error);
	public delegate void UserDidEarnRewardHandler ();
}
