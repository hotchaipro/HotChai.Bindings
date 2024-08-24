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
	[Register("ISConfigurations", true)]
	public unsafe partial class ISConfigurations : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISConfigurations");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISConfigurations () : base (NSObjectFlag.Empty)
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
		protected ISConfigurations (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISConfigurations (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber AdapterTimeOutInSeconds {
			[Export ("adapterTimeOutInSeconds", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adapterTimeOutInSeconds")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adapterTimeOutInSeconds")))!;
				}
				return ret!;
			}
			[Export ("setAdapterTimeOutInSeconds:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdapterTimeOutInSeconds:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdapterTimeOutInSeconds:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AdaptersDebug {
			[Export ("adaptersDebug")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("adaptersDebug"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adaptersDebug"));
				}
				return ret != 0;
			}
			[Export ("setAdaptersDebug:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdaptersDebug:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAdaptersDebug:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AdvancedLoading {
			[Export ("advancedLoading")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("advancedLoading"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("advancedLoading"));
				}
				return ret != 0;
			}
			[Export ("setAdvancedLoading:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdvancedLoading:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAdvancedLoading:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AppKey {
			[Export ("appKey", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("appKey")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appKey")))!;
				}
			}
			[Export ("setAppKey:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAppKey:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAppKey:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary BatchGenericParams {
			[Export ("batchGenericParams", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("batchGenericParams")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("batchGenericParams")))!;
				}
				return ret!;
			}
			[Export ("setBatchGenericParams:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBatchGenericParams:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setBatchGenericParams:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CategorizeType {
			[Export ("categorizeType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("categorizeType")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("categorizeType")))!;
				}
			}
			[Export ("setCategorizeType:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCategorizeType:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCategorizeType:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISConfigurations Configurations {
			[Export ("getConfigurations")]
			get {
				ISConfigurations? ret;
				ret =  Runtime.GetNSObject<ISConfigurations> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getConfigurations")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Consent {
			[Export ("consent")]
			get {
				if (IsDirectBinding) {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("consent"));
				} else {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("consent"));
				}
			}
			[Export ("setConsent:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConsent:"), value);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConsent:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary CustomSegmentParams {
			[Export ("customSegmentParams", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customSegmentParams")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customSegmentParams")))!;
				}
				return ret!;
			}
			[Export ("setCustomSegmentParams:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomSegmentParams:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCustomSegmentParams:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DidSetConsent {
			[Export ("didSetConsent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("didSetConsent"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didSetConsent"));
				}
				return ret != 0;
			}
			[Export ("setDidSetConsent:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDidSetConsent:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDidSetConsent:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DynamicUserId {
			[Export ("dynamicUserId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dynamicUserId")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dynamicUserId")))!;
				}
			}
			[Export ("setDynamicUserId:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDynamicUserId:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDynamicUserId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary EventGenericParams {
			[Export ("eventGenericParams", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("eventGenericParams")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("eventGenericParams")))!;
				}
				return ret!;
			}
			[Export ("setEventGenericParams:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setEventGenericParams:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setEventGenericParams:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary EventPixelParams {
			[Export ("eventPixelParams", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("eventPixelParams")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("eventPixelParams")))!;
				}
				return ret!;
			}
			[Export ("setEventPixelParams:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setEventPixelParams:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setEventPixelParams:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber MaxNumOfAdaptersToLoadOnStart {
			[Export ("maxNumOfAdaptersToLoadOnStart", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("maxNumOfAdaptersToLoadOnStart")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxNumOfAdaptersToLoadOnStart")))!;
				}
				return ret!;
			}
			[Export ("setMaxNumOfAdaptersToLoadOnStart:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMaxNumOfAdaptersToLoadOnStart:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setMaxNumOfAdaptersToLoadOnStart:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber MaxVideosPerIteration {
			[Export ("maxVideosPerIteration", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("maxVideosPerIteration")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxVideosPerIteration")))!;
				}
				return ret!;
			}
			[Export ("setMaxVideosPerIteration:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMaxVideosPerIteration:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setMaxVideosPerIteration:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MediationType {
			[Export ("mediationType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mediationType")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediationType")))!;
				}
			}
			[Export ("setMediationType:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMediationType:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setMediationType:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Plugin {
			[Export ("plugin", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("plugin")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("plugin")))!;
				}
			}
			[Export ("setPlugin:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPlugin:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPlugin:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PluginFrameworkVersion {
			[Export ("pluginFrameworkVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pluginFrameworkVersion")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pluginFrameworkVersion")))!;
				}
			}
			[Export ("setPluginFrameworkVersion:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPluginFrameworkVersion:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPluginFrameworkVersion:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PluginVersion {
			[Export ("pluginVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pluginVersion")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pluginVersion")))!;
				}
			}
			[Export ("setPluginVersion:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPluginVersion:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPluginVersion:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary RewardedVideoCustomParameters {
			[Export ("rewardedVideoCustomParameters", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rewardedVideoCustomParameters")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rewardedVideoCustomParameters")))!;
				}
				return ret!;
			}
			[Export ("setRewardedVideoCustomParameters:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRewardedVideoCustomParameters:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setRewardedVideoCustomParameters:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary RvServerParams {
			[Export ("rvServerParams", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rvServerParams")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rvServerParams")))!;
				}
				return ret!;
			}
			[Export ("setRvServerParams:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRvServerParams:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setRvServerParams:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISSegment Segment {
			[Export ("segment", ArgumentSemantic.Retain)]
			get {
				ISSegment? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ISSegment> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("segment")))!;
				} else {
					ret =  Runtime.GetNSObject<ISSegment> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("segment")))!;
				}
				return ret!;
			}
			[Export ("setSegment:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSegment:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSegment:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SegmentId {
			[Export ("segmentId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("segmentId")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("segmentId")))!;
				}
			}
			[Export ("setSegmentId:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSegmentId:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSegmentId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber Serr {
			[Export ("serr", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("serr")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serr")))!;
				}
				return ret!;
			}
			[Export ("setSerr:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSerr:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSerr:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TrackReachability {
			[Export ("trackReachability")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("trackReachability"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("trackReachability"));
				}
				return ret != 0;
			}
			[Export ("setTrackReachability:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTrackReachability:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTrackReachability:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint UserAge {
			[Export ("userAge")]
			get {
				if (IsDirectBinding) {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userAge"));
				} else {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userAge"));
				}
			}
			[Export ("setUserAge:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserAge:"), value);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserAge:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISGender UserGender {
			[Export ("userGender", ArgumentSemantic.Assign)]
			get {
				ISGender ret;
				if (IsDirectBinding) {
					ret = (IronSourceSdk.ISGender) (long) global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userGender"));
				} else {
					ret = (IronSourceSdk.ISGender) (long) global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGender"));
				}
				return ret!;
			}
			[Export ("setUserGender:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserGender:"), (IntPtr) (long) value);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserGender:"), (IntPtr) (long) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UserId {
			[Export ("userId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userId")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userId")))!;
				}
			}
			[Export ("setUserId:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserId:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUserId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Version {
			[Export ("version", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("version")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("version")))!;
				}
			}
			[Export ("setVersion:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setVersion:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setVersion:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class ISConfigurations */
}
