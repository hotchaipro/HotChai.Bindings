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
	[Register("ISBaseBanner", true)]
	public unsafe partial class ISBaseBanner : ISBaseAdAdapter, IISAdapterBannerProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBaseBanner");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBaseBanner () : base (NSObjectFlag.Empty)
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
		protected ISBaseBanner (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBaseBanner (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("init:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISBaseBanner (ISAdapterConfig providerConfig)
			: base (NSObjectFlag.Empty)
		{
			var providerConfig__handle__ = providerConfig!.GetNonNullHandle (nameof (providerConfig));
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("init:"), providerConfig__handle__), "init:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("init:"), providerConfig__handle__), "init:");
			}
		}
		[Export ("destroyAdWithAdData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DestroyAdWithAdData (ISAdData adData)
		{
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("destroyAdWithAdData:"), adData__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("destroyAdWithAdData:"), adData__handle__);
			}
		}
		[Export ("loadAdWithAdData:viewController:size:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadAdWithAdData (ISAdData adData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdDelegate @delegate)
		{
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadAdWithAdData:viewController:size:delegate:"), adData__handle__, viewController__handle__, size__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadAdWithAdData:viewController:size:delegate:"), adData__handle__, viewController__handle__, size__handle__, @delegate__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSupportAdaptiveBanner {
			[Export ("isSupportAdaptiveBanner")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSupportAdaptiveBanner"));
				} else {
					ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSupportAdaptiveBanner"));
				}
				return ret != 0;
			}
		}
	} /* class ISBaseBanner */
}
