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
	[Register("ISAInterstitialAdRequestBuilder", true)]
	public unsafe partial class ISAInterstitialAdRequestBuilder : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAInterstitialAdRequestBuilder");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAInterstitialAdRequestBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAInterstitialAdRequestBuilder (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithInstanceId:adm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISAInterstitialAdRequestBuilder (string instanceId, string adm)
			: base (NSObjectFlag.Empty)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			if (adm is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adm));
			var nsinstanceId = CFString.CreateNative (instanceId);
			var nsadm = CFString.CreateNative (adm);
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithInstanceId:adm:"), nsinstanceId, nsadm), "initWithInstanceId:adm:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithInstanceId:adm:"), nsinstanceId, nsadm), "initWithInstanceId:adm:");
			}
			CFString.ReleaseNative (nsinstanceId);
			CFString.ReleaseNative (nsadm);
		}
		[Export ("build")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAInterstitialAdRequest Build ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<ISAInterstitialAdRequest> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("build")))!;
			} else {
				return  Runtime.GetNSObject<ISAInterstitialAdRequest> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("build")))!;
			}
		}
		[Export ("withExtraParams:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAInterstitialAdRequestBuilder WithExtraParams (NSDictionary extraParams)
		{
			var extraParams__handle__ = extraParams!.GetNonNullHandle (nameof (extraParams));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<ISAInterstitialAdRequestBuilder> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("withExtraParams:"), extraParams__handle__))!;
			} else {
				return  Runtime.GetNSObject<ISAInterstitialAdRequestBuilder> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("withExtraParams:"), extraParams__handle__))!;
			}
		}
	} /* class ISAInterstitialAdRequestBuilder */
}
