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
	[Register("ISAdapterConfig", true)]
	public unsafe partial class ISAdapterConfig : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAdapterConfig");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISAdapterConfig () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAdapterConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAdapterConfig (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithProviderName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISAdapterConfig (string providerName)
			: base (NSObjectFlag.Empty)
		{
			if (providerName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (providerName));
			var nsproviderName = CFString.CreateNative (providerName);
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithProviderName:"), nsproviderName), "initWithProviderName:");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithProviderName:"), nsproviderName), "initWithProviderName:");
			}
			CFString.ReleaseNative (nsproviderName);
		}
		[Export ("customNetworkAdapterNameForAdUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CustomNetworkAdapterNameForAdUnit (ISAdUnit adUnit)
		{
			var adUnit__handle__ = adUnit!.GetNonNullHandle (nameof (adUnit));
			if (IsDirectBinding) {
				return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("customNetworkAdapterNameForAdUnit:"), adUnit__handle__))!;
			} else {
				return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("customNetworkAdapterNameForAdUnit:"), adUnit__handle__))!;
			}
		}
		[Export ("setAdUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdUnit (ISAdUnit adUnit)
		{
			var adUnit__handle__ = adUnit!.GetNonNullHandle (nameof (adUnit));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdUnit:"), adUnit__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdUnit:"), adUnit__handle__);
			}
		}
		[Export ("setAppSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAppSettings (NSDictionary appSettings)
		{
			var appSettings__handle__ = appSettings!.GetNonNullHandle (nameof (appSettings));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAppSettings:"), appSettings__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAppSettings:"), appSettings__handle__);
			}
		}
		[Export ("setInterstitialSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInterstitialSettings (NSDictionary interstitialSettings)
		{
			var interstitialSettings__handle__ = interstitialSettings!.GetNonNullHandle (nameof (interstitialSettings));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInterstitialSettings:"), interstitialSettings__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setInterstitialSettings:"), interstitialSettings__handle__);
			}
		}
		[Export ("setIsOneFlow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIsOneFlow (bool isOneFlow)
		{
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsOneFlow:"), isOneFlow ? (byte) 1 : (byte) 0);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsOneFlow:"), isOneFlow ? (byte) 1 : (byte) 0);
			}
		}
		[Export ("setLoadTimeOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLoadTimeOut (double loadTimeOut)
		{
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLoadTimeOut:"), loadTimeOut);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setLoadTimeOut:"), loadTimeOut);
			}
		}
		[Export ("setNativeAdSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNativeAdSettings (NSDictionary nativeAdSettings)
		{
			var nativeAdSettings__handle__ = nativeAdSettings!.GetNonNullHandle (nameof (nativeAdSettings));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNativeAdSettings:"), nativeAdSettings__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setNativeAdSettings:"), nativeAdSettings__handle__);
			}
		}
		[Export ("setProviderDefaultInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProviderDefaultInstance (string providerDefaultInstance)
		{
			if (providerDefaultInstance is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (providerDefaultInstance));
			var nsproviderDefaultInstance = CFString.CreateNative (providerDefaultInstance);
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setProviderDefaultInstance:"), nsproviderDefaultInstance);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setProviderDefaultInstance:"), nsproviderDefaultInstance);
			}
			CFString.ReleaseNative (nsproviderDefaultInstance);
		}
		[Export ("setReflectionName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetReflectionName (string reflectionName)
		{
			if (reflectionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reflectionName));
			var nsreflectionName = CFString.CreateNative (reflectionName);
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setReflectionName:"), nsreflectionName);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setReflectionName:"), nsreflectionName);
			}
			CFString.ReleaseNative (nsreflectionName);
		}
		[Export ("setRewardedVideoSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRewardedVideoSettings (NSDictionary rewardedVideoSettings)
		{
			var rewardedVideoSettings__handle__ = rewardedVideoSettings!.GetNonNullHandle (nameof (rewardedVideoSettings));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRewardedVideoSettings:"), rewardedVideoSettings__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setRewardedVideoSettings:"), rewardedVideoSettings__handle__);
			}
		}
		[Export ("setSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSettings (NSDictionary settings)
		{
			var settings__handle__ = settings!.GetNonNullHandle (nameof (settings));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSettings:"), settings__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSettings:"), settings__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AdSourceNameForEvent {
			[Export ("adSourceNameForEvent", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adSourceNameForEvent")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adSourceNameForEvent")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAdUnit AdUnit {
			[Export ("adUnit", ArgumentSemantic.Retain)]
			get {
				ISAdUnit? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ISAdUnit> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adUnit")))!;
				} else {
					ret =  Runtime.GetNSObject<ISAdUnit> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnit")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary AdUnitSettings {
			[Export ("adUnitSettings")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adUnitSettings")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnitSettings")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary AppSettings {
			[Export ("appSettings", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("appSettings")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appSettings")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary BannerSettings {
			[Export ("bannerSettings", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bannerSettings")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bannerSettings")))!;
				}
				return ret!;
			}
			[Export ("setBannerSettings:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBannerSettings:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setBannerSettings:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ConsentCMP {
			[Export ("getConsentCMP")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getConsentCMP"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getConsentCMP"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CustomNetwork {
			[Export ("customNetwork", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customNetwork")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customNetwork")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DemandSourceName {
			[Export ("demandSourceName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("demandSourceName")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("demandSourceName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasConsentCMP {
			[Export ("hasConsentCMP")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasConsentCMP"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasConsentCMP"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string InstanceId {
			[Export ("instanceId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("instanceId")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("instanceId")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string InstanceType {
			[Export ("instanceType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("instanceType")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("instanceType")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary InterstitialSettings {
			[Export ("interstitialSettings", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("interstitialSettings")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("interstitialSettings")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBidder {
			[Export ("isBidder")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBidder"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBidder"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCustomNetwork {
			[Export ("isCustomNetwork")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCustomNetwork"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isCustomNetwork"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsIronSource {
			[Export ("isIronSource")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isIronSource"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isIronSource"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMultiProviderInstance {
			[Export ("isMultiProviderInstance")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMultiProviderInstance"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMultiProviderInstance"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber IsOneFlow {
			[Export ("isOneFlow")]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("isOneFlow")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isOneFlow")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double LoadTimeOutSec {
			[Export ("loadTimeOutSec")]
			get {
				if (IsDirectBinding) {
					return global::IronSourceSdk.ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("loadTimeOutSec"));
				} else {
					return global::IronSourceSdk.ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadTimeOutSec"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MaxAdsPerDay {
			[Export ("maxAdsPerDay")]
			get {
				if (IsDirectBinding) {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxAdsPerDay"));
				} else {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxAdsPerDay"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber MaxAdsPerIteration {
			[Export ("maxAdsPerIteration", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("maxAdsPerIteration")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxAdsPerIteration")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber MaxAdsPerSession {
			[Export ("maxAdsPerSession", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("maxAdsPerSession")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxAdsPerSession")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary NativeAdSettings {
			[Export ("nativeAdSettings", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("nativeAdSettings")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nativeAdSettings")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ProviderDefaultInstance {
			[Export ("providerDefaultInstance", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("providerDefaultInstance")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("providerDefaultInstance")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ProviderName {
			[Export ("providerName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("providerName")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("providerName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ReflectionName {
			[Export ("reflectionName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reflectionName")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reflectionName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string RequestUrl {
			[Export ("requestUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("requestUrl")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestUrl")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary RewardedVideoSettings {
			[Export ("rewardedVideoSettings", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rewardedVideoSettings")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rewardedVideoSettings")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Settings {
			[Export ("settings", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("settings")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("settings")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEarlyInit {
			[Export ("shouldEarlyInit")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldEarlyInit"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldEarlyInit"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SubAdapterId {
			[Export ("subAdapterId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("subAdapterId")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subAdapterId")))!;
				}
			}
		}
	} /* class ISAdapterConfig */
}
