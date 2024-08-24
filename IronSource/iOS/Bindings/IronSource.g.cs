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
using System.Runtime.Versioning;
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
using NativeHandle = System.IntPtr;
#endif
namespace IronSourceSdk {
	[Register("IronSource", true)]
	public unsafe partial class IronSource : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("IronSource");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IronSource () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected IronSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IronSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addImpressionDataDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionDataDelegate (ISImpressionDataDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionDataDelegate:"), @delegate__handle__);
		}
		[Export ("clearRewardedVideoServerParameters")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClearRewardedVideoServerParameters ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearRewardedVideoServerParameters"));
		}
		[Export ("destroyBanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DestroyBanner (ISBannerView banner)
		{
			var banner__handle__ = banner!.GetNonNullHandle (nameof (banner));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("destroyBanner:"), banner__handle__);
		}
		[Export ("destroyISDemandOnlyBannerWithInstanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DestroyISDemandOnlyBannerWithInstanceId (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("destroyISDemandOnlyBannerWithInstanceId:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("hasISDemandOnlyInterstitial:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasISDemandOnlyInterstitial (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("hasISDemandOnlyInterstitial:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
			return ret != 0;
		}
		[Export ("hasISDemandOnlyRewardedVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasISDemandOnlyRewardedVideo (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("hasISDemandOnlyRewardedVideo:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
			return ret != 0;
		}
		[Export ("initISDemandOnly:adUnits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitISDemandOnly (string appKey, string[] adUnits)
		{
			if (appKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appKey));
			if (adUnits is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnits));
			var nsappKey = CFString.CreateNative (appKey);
			var nsa_adUnits = NSArray.FromStrings (adUnits);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("initISDemandOnly:adUnits:"), nsappKey, nsa_adUnits.Handle);
			CFString.ReleaseNative (nsappKey);
			nsa_adUnits.Dispose ();
		}
		[Export ("initWithAppKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitWithAppKey (string appKey)
		{
			if (appKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appKey));
			var nsappKey = CFString.CreateNative (appKey);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("initWithAppKey:"), nsappKey);
			CFString.ReleaseNative (nsappKey);
		}
		[Export ("initWithAppKey:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitWithAppKey (string appKey, ISInitializationDelegate? @delegate)
		{
			if (appKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appKey));
			var @delegate__handle__ = @delegate.GetHandle ();
			var nsappKey = CFString.CreateNative (appKey);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("initWithAppKey:delegate:"), nsappKey, @delegate__handle__);
			CFString.ReleaseNative (nsappKey);
		}
		[Export ("initWithAppKey:adUnits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitWithAppKey (string appKey, string[] adUnits)
		{
			if (appKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appKey));
			if (adUnits is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnits));
			var nsappKey = CFString.CreateNative (appKey);
			var nsa_adUnits = NSArray.FromStrings (adUnits);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("initWithAppKey:adUnits:"), nsappKey, nsa_adUnits.Handle);
			CFString.ReleaseNative (nsappKey);
			nsa_adUnits.Dispose ();
		}
		[Export ("initWithAppKey:adUnits:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitWithAppKey (string appKey, string[] adUnits, ISInitializationDelegate? @delegate)
		{
			if (appKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appKey));
			if (adUnits is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnits));
			var @delegate__handle__ = @delegate.GetHandle ();
			var nsappKey = CFString.CreateNative (appKey);
			var nsa_adUnits = NSArray.FromStrings (adUnits);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("initWithAppKey:adUnits:delegate:"), nsappKey, nsa_adUnits.Handle, @delegate__handle__);
			CFString.ReleaseNative (nsappKey);
			nsa_adUnits.Dispose ();
		}
		[Export ("isBannerCappedForPlacement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsBannerCappedForPlacement (string placementName)
		{
			if (placementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementName));
			var nsplacementName = CFString.CreateNative (placementName);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isBannerCappedForPlacement:"), nsplacementName);
			CFString.ReleaseNative (nsplacementName);
			return ret != 0;
		}
		[Export ("isInterstitialCappedForPlacement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsInterstitialCappedForPlacement (string placementName)
		{
			if (placementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementName));
			var nsplacementName = CFString.CreateNative (placementName);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isInterstitialCappedForPlacement:"), nsplacementName);
			CFString.ReleaseNative (nsplacementName);
			return ret != 0;
		}
		[Export ("isRewardedVideoCappedForPlacement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsRewardedVideoCappedForPlacement (string placementName)
		{
			if (placementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementName));
			var nsplacementName = CFString.CreateNative (placementName);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isRewardedVideoCappedForPlacement:"), nsplacementName);
			CFString.ReleaseNative (nsplacementName);
			return ret != 0;
		}
		[Export ("launchTestSuite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LaunchTestSuite (global::UIKit.UIViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("launchTestSuite:"), viewController__handle__);
		}
		[Export ("loadBannerWithViewController:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadBannerWithViewController (global::UIKit.UIViewController viewController, ISBannerSize size)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadBannerWithViewController:size:"), viewController__handle__, size__handle__);
		}
		[Export ("loadBannerWithViewController:size:placement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadBannerWithViewController (global::UIKit.UIViewController viewController, ISBannerSize size, string? placementName)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsplacementName = CFString.CreateNative (placementName);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadBannerWithViewController:size:placement:"), viewController__handle__, size__handle__, nsplacementName);
			CFString.ReleaseNative (nsplacementName);
		}
		[Export ("loadConsentViewWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadConsentViewWithType (string consentViewType)
		{
			if (consentViewType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("loadConsentViewWithType:"), nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
		[Export ("loadISDemandOnlyBannerWithAdm:instanceId:viewController:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadISDemandOnlyBannerWithAdm (string adm, string instanceId, global::UIKit.UIViewController viewController, ISBannerSize size)
		{
			if (adm is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adm));
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsadm = CFString.CreateNative (adm);
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadISDemandOnlyBannerWithAdm:instanceId:viewController:size:"), nsadm, nsinstanceId, viewController__handle__, size__handle__);
			CFString.ReleaseNative (nsadm);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("loadISDemandOnlyBannerWithInstanceId:viewController:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadISDemandOnlyBannerWithInstanceId (string instanceId, global::UIKit.UIViewController viewController, ISBannerSize size)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadISDemandOnlyBannerWithInstanceId:viewController:size:"), nsinstanceId, viewController__handle__, size__handle__);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("loadISDemandOnlyInterstitial:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadISDemandOnlyInterstitial (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("loadISDemandOnlyInterstitial:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("loadISDemandOnlyInterstitialWithAdm:adm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadISDemandOnlyInterstitialWithAdm (string instanceId, string adm)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			if (adm is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adm));
			var nsinstanceId = CFString.CreateNative (instanceId);
			var nsadm = CFString.CreateNative (adm);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadISDemandOnlyInterstitialWithAdm:adm:"), nsinstanceId, nsadm);
			CFString.ReleaseNative (nsinstanceId);
			CFString.ReleaseNative (nsadm);
		}
		[Export ("loadISDemandOnlyRewardedVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadISDemandOnlyRewardedVideo (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("loadISDemandOnlyRewardedVideo:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("loadISDemandOnlyRewardedVideoWithAdm:adm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadISDemandOnlyRewardedVideoWithAdm (string instanceId, string adm)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			if (adm is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adm));
			var nsinstanceId = CFString.CreateNative (instanceId);
			var nsadm = CFString.CreateNative (adm);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadISDemandOnlyRewardedVideoWithAdm:adm:"), nsinstanceId, nsadm);
			CFString.ReleaseNative (nsinstanceId);
			CFString.ReleaseNative (nsadm);
		}
		[Export ("loadInterstitial")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadInterstitial ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("loadInterstitial"));
		}
		[Export ("loadRewardedVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadRewardedVideo ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("loadRewardedVideo"));
		}
		[Export ("removeImpressionDataDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveImpressionDataDelegate (ISImpressionDataDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeImpressionDataDelegate:"), @delegate__handle__);
		}
		[Export ("rewardedVideoPlacementInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISPlacementInfo RewardedVideoPlacementInfo (string placementName)
		{
			if (placementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementName));
			var nsplacementName = CFString.CreateNative (placementName);
			ISPlacementInfo? ret;
			ret =  Runtime.GetNSObject<ISPlacementInfo> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("rewardedVideoPlacementInfo:"), nsplacementName))!;
			CFString.ReleaseNative (nsplacementName);
			return ret!;
		}
		[Export ("setAdRevenueDataWithDataSource:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAdRevenueDataWithDataSource (string dataSource, NSData impressionData)
		{
			if (dataSource is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataSource));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsdataSource = CFString.CreateNative (dataSource);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setAdRevenueDataWithDataSource:impressionData:"), nsdataSource, impressionData__handle__);
			CFString.ReleaseNative (nsdataSource);
		}
		[Export ("setAdaptersDebug:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAdaptersDebug (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAdaptersDebug:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setConsent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetConsent (bool consent)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setConsent:"), consent ? (byte) 1 : (byte) 0);
		}
		[Export ("setConsentViewWithDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetConsentViewWithDelegate (ISConsentViewDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setConsentViewWithDelegate:"), @delegate__handle__);
		}
		[Export ("setDynamicUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetDynamicUserId (string dynamicUserId)
		{
			if (dynamicUserId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dynamicUserId));
			var nsdynamicUserId = CFString.CreateNative (dynamicUserId);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setDynamicUserId:"), nsdynamicUserId);
			CFString.ReleaseNative (nsdynamicUserId);
			return ret != 0;
		}
		[Export ("setISDemandOnlyBannerDelegate:forInstanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetISDemandOnlyBannerDelegate (ISDemandOnlyBannerDelegate @delegate, string instanceId)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setISDemandOnlyBannerDelegate:forInstanceId:"), @delegate__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("setISDemandOnlyInterstitialDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetISDemandOnlyInterstitialDelegate (ISDemandOnlyInterstitialDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setISDemandOnlyInterstitialDelegate:"), @delegate__handle__);
		}
		[Export ("setISDemandOnlyRewardedVideoDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetISDemandOnlyRewardedVideoDelegate (ISDemandOnlyRewardedVideoDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setISDemandOnlyRewardedVideoDelegate:"), @delegate__handle__);
		}
		[Export ("setLevelPlayBannerDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLevelPlayBannerDelegate (LevelPlayBannerDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setLevelPlayBannerDelegate:"), @delegate__handle__);
		}
		[Export ("setLevelPlayInterstitialDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLevelPlayInterstitialDelegate (LevelPlayInterstitialDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setLevelPlayInterstitialDelegate:"), @delegate__handle__);
		}
		[Export ("setLevelPlayRewardedVideoDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLevelPlayRewardedVideoDelegate (LevelPlayRewardedVideoDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setLevelPlayRewardedVideoDelegate:"), @delegate__handle__);
		}
		[Export ("setLevelPlayRewardedVideoManualDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLevelPlayRewardedVideoManualDelegate (LevelPlayRewardedVideoManualDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setLevelPlayRewardedVideoManualDelegate:"), @delegate__handle__);
		}
		[Export ("setLogDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLogDelegate (ISLogDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setLogDelegate:"), @delegate__handle__);
		}
		[Export ("setMediationType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMediationType (string mediationType)
		{
			if (mediationType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediationType));
			var nsmediationType = CFString.CreateNative (mediationType);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setMediationType:"), nsmediationType);
			CFString.ReleaseNative (nsmediationType);
		}
		[Export ("setMetaDataWithKey:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMetaDataWithKey (string key, string value)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setMetaDataWithKey:value:"), nskey, nsvalue);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
		}
		[Export ("setMetaDataWithKey:values:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMetaDataWithKey (string key, NSMutableArray values)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var nskey = CFString.CreateNative (key);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setMetaDataWithKey:values:"), nskey, values__handle__);
			CFString.ReleaseNative (nskey);
		}
		[Export ("setNetworkDataWithNetworkKey:andNetworkData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNetworkDataWithNetworkKey (string networkKey, NSDictionary networkData)
		{
			if (networkKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (networkKey));
			var networkData__handle__ = networkData!.GetNonNullHandle (nameof (networkData));
			var nsnetworkKey = CFString.CreateNative (networkKey);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setNetworkDataWithNetworkKey:andNetworkData:"), nsnetworkKey, networkData__handle__);
			CFString.ReleaseNative (nsnetworkKey);
		}
		[Export ("setRewardedVideoServerParameters:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetRewardedVideoServerParameters (NSDictionary parameters)
		{
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setRewardedVideoServerParameters:"), parameters__handle__);
		}
		[Export ("setSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSegment (ISSegment segment)
		{
			var segment__handle__ = segment!.GetNonNullHandle (nameof (segment));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setSegment:"), segment__handle__);
		}
		[Export ("setSegmentDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSegmentDelegate (ISSegmentDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setSegmentDelegate:"), @delegate__handle__);
		}
		[Export ("setUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserId (string userId)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setUserId:"), nsuserId);
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("setWaterfallConfiguration:forAdUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWaterfallConfiguration (ISWaterfallConfiguration waterfallConfiguration, ISAdUnit adUnit)
		{
			var waterfallConfiguration__handle__ = waterfallConfiguration!.GetNonNullHandle (nameof (waterfallConfiguration));
			var adUnit__handle__ = adUnit!.GetNonNullHandle (nameof (adUnit));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setWaterfallConfiguration:forAdUnit:"), waterfallConfiguration__handle__, adUnit__handle__);
		}
		[Export ("shouldTrackReachability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShouldTrackReachability (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("shouldTrackReachability:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("showConsentViewWithViewController:andType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowConsentViewWithViewController (global::UIKit.UIViewController viewController, string consentViewType)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (consentViewType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("showConsentViewWithViewController:andType:"), viewController__handle__, nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
		[Export ("showISDemandOnlyInterstitial:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowISDemandOnlyInterstitial (global::UIKit.UIViewController viewController, string instanceId)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("showISDemandOnlyInterstitial:instanceId:"), viewController__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("showISDemandOnlyRewardedVideo:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowISDemandOnlyRewardedVideo (global::UIKit.UIViewController viewController, string instanceId)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("showISDemandOnlyRewardedVideo:instanceId:"), viewController__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("showInterstitialWithViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowInterstitialWithViewController (global::UIKit.UIViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("showInterstitialWithViewController:"), viewController__handle__);
		}
		[Export ("showInterstitialWithViewController:placement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowInterstitialWithViewController (global::UIKit.UIViewController viewController, string? placementName)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var nsplacementName = CFString.CreateNative (placementName);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("showInterstitialWithViewController:placement:"), viewController__handle__, nsplacementName);
			CFString.ReleaseNative (nsplacementName);
		}
		[Export ("showRewardedVideoWithViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowRewardedVideoWithViewController (global::UIKit.UIViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("showRewardedVideoWithViewController:"), viewController__handle__);
		}
		[Export ("showRewardedVideoWithViewController:placement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowRewardedVideoWithViewController (global::UIKit.UIViewController viewController, string? placementName)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var nsplacementName = CFString.CreateNative (placementName);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("showRewardedVideoWithViewController:placement:"), viewController__handle__, nsplacementName);
			CFString.ReleaseNative (nsplacementName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string AdvertiserId {
			[Export ("advertiserId")]
			get {
				return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("advertiserId")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber ConversionValue {
			[Export ("getConversionValue")]
			get {
				NSNumber? ret;
				ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getConversionValue")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasInterstitial {
			[Export ("hasInterstitial")]
			get {
				byte ret;
				ret = ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("hasInterstitial"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasRewardedVideo {
			[Export ("hasRewardedVideo")]
			get {
				byte ret;
				ret = ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("hasRewardedVideo"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ISDemandOnlyBiddingData {
			[Export ("getISDemandOnlyBiddingData")]
			get {
				return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getISDemandOnlyBiddingData")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string SdkVersion {
			[Export ("sdkVersion")]
			get {
				return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sdkVersion")))!;
			}
		}
	} /* class IronSource */
}
