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
	[Register("ISBaseAdapter", true)]
	public unsafe partial class ISBaseAdapter : NSObject, IISAdUnitAdapterProtocol, IISAdapterNetworkDataProtocol, IISBannerAdapterProtocol, IISInterstitialAdapterProtocol, IISNativeAdAdapterProtocol, IISNetworkInitCallbackProtocol, IISReleaseMemoryAdapterProtocol, IISRewardedVideoAdapterProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBaseAdapter");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBaseAdapter () : base (NSObjectFlag.Empty)
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
		protected ISBaseAdapter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBaseAdapter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initAdapter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISBaseAdapter (string name)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initAdapter:"), nsname), "initAdapter:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initAdapter:"), nsname), "initAdapter:");
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("collectBannerBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectBannerBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectBannerBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("collectBannerBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectInterstitialBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectNativeAdBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectRewardedVideoBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("destroyBannerWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DestroyBannerWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("destroyBannerWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("destroyBannerWithAdapterConfig:"), adapterConfig__handle__);
			}
		}
		[Export ("destroyNativeAdWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DestroyNativeAdWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("destroyNativeAdWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("destroyNativeAdWithAdapterConfig:"), adapterConfig__handle__);
			}
		}
		[Export ("earlyInitWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EarlyInitWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("earlyInitWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("earlyInitWithAdapterConfig:"), adapterConfig__handle__);
			}
		}
		[Export ("getAdaptiveHeightWithWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetAdaptiveHeightWithWidth (nfloat width)
		{
			if (IsDirectBinding) {
				return ApiDefinitions.Messaging.nfloat_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("getAdaptiveHeightWithWidth:"), width);
			} else {
				return ApiDefinitions.Messaging.nfloat_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("getAdaptiveHeightWithWidth:"), width);
			}
		}
		[Export ("getBannerBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetBannerBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getBannerBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("getBannerBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			}
		}
		[Export ("getInterstitialBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetInterstitialBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getInterstitialBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("getInterstitialBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			}
		}
		[Export ("getLWSSupportState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISLoadWhileShowSupportState GetLWSSupportState (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			ISLoadWhileShowSupportState ret;
			if (IsDirectBinding) {
				ret = (IronSourceSdk.ISLoadWhileShowSupportState) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getLWSSupportState:"), adapterConfig__handle__);
			} else {
				ret = (IronSourceSdk.ISLoadWhileShowSupportState) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getLWSSupportState:"), adapterConfig__handle__);
			}
			return ret!;
		}
		[Export ("getNativeAdBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetNativeAdBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getNativeAdBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("getNativeAdBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			}
		}
		[Export ("getRewardedVideoBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetRewardedVideoBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getRewardedVideoBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("getRewardedVideoBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			}
		}
		[Export ("hasInterstitialWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasInterstitialWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			byte ret;
			if (IsDirectBinding) {
				ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasInterstitialWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("hasInterstitialWithAdapterConfig:"), adapterConfig__handle__);
			}
			return ret != 0;
		}
		[Export ("hasRewardedVideoWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasRewardedVideoWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			byte ret;
			if (IsDirectBinding) {
				ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasRewardedVideoWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("hasRewardedVideoWithAdapterConfig:"), adapterConfig__handle__);
			}
			return ret != 0;
		}
		[Export ("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitAndLoadRewardedVideoWithUserId (string userId, ISAdapterConfig adapterConfig, NSDictionary adData, ISRewardedVideoAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:"), nsuserId, adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:"), nsuserId, adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initBannerForBiddingWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitBannerForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initBannerForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initBannerForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initBannerWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitBannerWithUserId (string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initBannerWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initBannerWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitInterstitialForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initInterstitialWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitInterstitialWithUserId (string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initInterstitialWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initInterstitialWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitNativeAdForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initNativeAdsWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitNativeAdsWithUserId (string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initNativeAdsWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initNativeAdsWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitRewardedVideoForCallbacksWithUserId (string userId, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitRewardedVideoForDemandOnlyWithUserId (string userId, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadBannerForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, size__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, size__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadBannerWithAdapterConfig:adData:viewController:size:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadBannerWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadBannerWithAdapterConfig:adData:viewController:size:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, size__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadBannerWithAdapterConfig:adData:viewController:size:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, size__handle__, @delegate__handle__);
			}
		}
		[Export ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadInterstitialForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, ISInterstitialAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadInterstitialWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadInterstitialWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISInterstitialAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadInterstitialWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadInterstitialWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadNativeAdForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, global::UIKit.UIViewController viewController, ISNativeAdAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadNativeAdWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, global::UIKit.UIViewController viewController, ISNativeAdAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, @delegate__handle__);
			}
		}
		[Export ("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, string serverData, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:"), adapterConfig__handle__, nsserverData, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:"), adapterConfig__handle__, nsserverData, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoForDemandOnlyWithAdapterConfig (ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:"), adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:"), adapterConfig__handle__, @delegate__handle__);
			}
		}
		[Export ("loadRewardedVideoWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("onNetworkInitCallbackFailed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnNetworkInitCallbackFailed (string errorMessage)
		{
			if (errorMessage is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (errorMessage));
			var nserrorMessage = CFString.CreateNative (errorMessage);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("onNetworkInitCallbackFailed:"), nserrorMessage);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("onNetworkInitCallbackFailed:"), nserrorMessage);
			}
			CFString.ReleaseNative (nserrorMessage);
		}
		[Export ("onNetworkInitCallbackSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnNetworkInitCallbackSuccess ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onNetworkInitCallbackSuccess"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("onNetworkInitCallbackSuccess"));
			}
		}
		[Export ("releaseMemoryWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReleaseMemoryWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("releaseMemoryWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("releaseMemoryWithAdapterConfig:"), adapterConfig__handle__);
			}
		}
		[Export ("setBannerAdapter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBannerAdapter (ISBannerAdapterProtocol bannerAdapter)
		{
			var bannerAdapter__handle__ = bannerAdapter!.GetNonNullHandle (nameof (bannerAdapter));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBannerAdapter:"), bannerAdapter__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setBannerAdapter:"), bannerAdapter__handle__);
			}
		}
		[Export ("setConsent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetConsent (bool consent)
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setConsent:"), consent ? (byte) 1 : (byte) 0);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setConsent:"), consent ? (byte) 1 : (byte) 0);
			}
		}
		[Export ("setInterstitialAdapter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInterstitialAdapter (ISInterstitialAdapterProtocol interstitialAdapter)
		{
			var interstitialAdapter__handle__ = interstitialAdapter!.GetNonNullHandle (nameof (interstitialAdapter));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInterstitialAdapter:"), interstitialAdapter__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setInterstitialAdapter:"), interstitialAdapter__handle__);
			}
		}
		[Export ("setNativeAdAdapter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNativeAdAdapter (ISNativeAdAdapterProtocol nativeAdAdapter)
		{
			var nativeAdAdapter__handle__ = nativeAdAdapter!.GetNonNullHandle (nameof (nativeAdAdapter));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNativeAdAdapter:"), nativeAdAdapter__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setNativeAdAdapter:"), nativeAdAdapter__handle__);
			}
		}
		[Export ("setNetworkData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNetworkData (ISAdapterNetworkData networkData)
		{
			var networkData__handle__ = networkData!.GetNonNullHandle (nameof (networkData));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNetworkData:"), networkData__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setNetworkData:"), networkData__handle__);
			}
		}
		[Export ("setRewardedVideoAdapter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRewardedVideoAdapter (ISRewardedVideoAdapterProtocol rewardedVideoAdapter)
		{
			var rewardedVideoAdapter__handle__ = rewardedVideoAdapter!.GetNonNullHandle (nameof (rewardedVideoAdapter));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRewardedVideoAdapter:"), rewardedVideoAdapter__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setRewardedVideoAdapter:"), rewardedVideoAdapter__handle__);
			}
		}
		[Export ("showInterstitialWithViewController:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowInterstitialWithViewController (global::UIKit.UIViewController viewController, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showInterstitialWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("showInterstitialWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			}
		}
		[Export ("showRewardedVideoWithViewController:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowRewardedVideoWithViewController (global::UIKit.UIViewController viewController, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showRewardedVideoWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("showRewardedVideoWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISConcurrentMutableDictionary AdUnitAdapters {
			[Export ("adUnitAdapters", ArgumentSemantic.Retain)]
			get {
				ISConcurrentMutableDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ISConcurrentMutableDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adUnitAdapters")))!;
				} else {
					ret =  Runtime.GetNSObject<ISConcurrentMutableDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnitAdapters")))!;
				}
				return ret!;
			}
			[Export ("setAdUnitAdapters:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdUnitAdapters:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdUnitAdapters:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AdapterName {
			[Export ("adapterName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adapterName")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adapterName")))!;
				}
			}
			[Export ("setAdapterName:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdapterName:"), nsvalue);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdapterName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISBannerAdapterProtocol BannerAdapter {
			[Export ("getBannerAdapter")]
			get {
				ISBannerAdapterProtocol? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISBannerAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getBannerAdapter")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<ISBannerAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBannerAdapter")), false)!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DynamicUserId {
			[Export ("dynamicUserId")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dynamicUserId")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dynamicUserId")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISInterstitialAdapterProtocol InterstitialAdapter {
			[Export ("getInterstitialAdapter")]
			get {
				ISInterstitialAdapterProtocol? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISInterstitialAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getInterstitialAdapter")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<ISInterstitialAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getInterstitialAdapter")), false)!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISNativeAdAdapterProtocol NativeAdAdapter {
			[Export ("getNativeAdAdapter")]
			get {
				ISNativeAdAdapterProtocol? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISNativeAdAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getNativeAdAdapter")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<ISNativeAdAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getNativeAdAdapter")), false)!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PluginType {
			[Export ("pluginType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pluginType")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pluginType")))!;
				}
			}
			[Export ("setPluginType:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPluginType:"), nsvalue);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPluginType:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ProviderNetworkKey {
			[Export ("providerNetworkKey", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("providerNetworkKey")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("providerNetworkKey")))!;
				}
			}
			[Export ("setProviderNetworkKey:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setProviderNetworkKey:"), nsvalue);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setProviderNetworkKey:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISRewardedVideoAdapterProtocol RewardedVideoAdapter {
			[Export ("getRewardedVideoAdapter")]
			get {
				ISRewardedVideoAdapterProtocol? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISRewardedVideoAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getRewardedVideoAdapter")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<ISRewardedVideoAdapterProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getRewardedVideoAdapter")), false)!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SdkVersion {
			[Export ("sdkVersion")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sdkVersion")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sdkVersion")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UserId {
			[Export ("userId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userId")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userId")))!;
				}
			}
			[Export ("setUserId:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserId:"), nsvalue);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUserId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Version {
			[Export ("version")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("version")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("version")))!;
				}
			}
		}
	} /* class ISBaseAdapter */
}
