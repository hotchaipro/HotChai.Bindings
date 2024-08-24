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
	[Register("ISAdData", true)]
	public unsafe partial class ISAdData : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAdData");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISAdData () : base (NSObjectFlag.Empty)
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
		protected ISAdData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAdData (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithServerData:configuration:adUnitData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISAdData (string? serverData, NSDictionary configuration, NSDictionary? adUnitData)
			: base (NSObjectFlag.Empty)
		{
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var adUnitData__handle__ = adUnitData.GetHandle ();
			var nsserverData = CFString.CreateNative (serverData);
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithServerData:configuration:adUnitData:"), nsserverData, configuration__handle__, adUnitData__handle__), "initWithServerData:configuration:adUnitData:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithServerData:configuration:adUnitData:"), nsserverData, configuration__handle__, adUnitData__handle__), "initWithServerData:configuration:adUnitData:");
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("adDataWithAdapterConfiguration:adUnit:userId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISAdData AdDataWithAdapterConfiguration (ISAdapterConfig config, ISAdUnit adUnit, string userId)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			var adUnit__handle__ = adUnit!.GetNonNullHandle (nameof (adUnit));
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			ISAdData? ret;
			ret =  Runtime.GetNSObject<ISAdData> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("adDataWithAdapterConfiguration:adUnit:userId:"), config__handle__, adUnit__handle__, nsuserId))!;
			CFString.ReleaseNative (nsuserId);
			return ret!;
		}
		[Export ("adDataWithAdapterConfiguration:adUnit:userId:bannerSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISAdData AdDataWithAdapterConfiguration (ISAdapterConfig config, ISAdUnit adUnit, string? userId, ISBannerSize? bannerSize)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			var adUnit__handle__ = adUnit!.GetNonNullHandle (nameof (adUnit));
			var bannerSize__handle__ = bannerSize.GetHandle ();
			var nsuserId = CFString.CreateNative (userId);
			ISAdData? ret;
			ret =  Runtime.GetNSObject<ISAdData> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("adDataWithAdapterConfiguration:adUnit:userId:bannerSize:"), config__handle__, adUnit__handle__, nsuserId, bannerSize__handle__))!;
			CFString.ReleaseNative (nsuserId);
			return ret!;
		}
		[Export ("getBoolean:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetBoolean (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getBoolean:"), nskey);
			} else {
				ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getBoolean:"), nskey);
			}
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("getInt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetInt (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			nint ret;
			if (IsDirectBinding) {
				ret = ApiDefinitions.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getInt:"), nskey);
			} else {
				ret = ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getInt:"), nskey);
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("getNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? GetNumber (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSNumber? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getNumber:"), nskey))!;
			} else {
				ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getNumber:"), nskey))!;
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("getString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetString (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getString:"), nskey))!;
			} else {
				ret = CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getString:"), nskey))!;
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? AdUnitData {
			[Export ("adUnitData", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adUnitData")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnitData")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Configuration {
			[Export ("configuration", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configuration")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("configuration")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ServerData {
			[Export ("serverData", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("serverData")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serverData")))!;
				}
			}
		}
	} /* class ISAdData */
}
