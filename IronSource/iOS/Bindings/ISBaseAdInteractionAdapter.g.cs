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
	[Register("ISBaseAdInteractionAdapter", true)]
	public unsafe partial class ISBaseAdInteractionAdapter : ISBaseAdAdapter, IISAdapterAdFullscreenProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBaseAdInteractionAdapter");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBaseAdInteractionAdapter () : base (NSObjectFlag.Empty)
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
		protected ISBaseAdInteractionAdapter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBaseAdInteractionAdapter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("isAdAvailableWithAdData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAdAvailableWithAdData (ISAdData adData)
		{
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			byte ret;
			if (IsDirectBinding) {
				ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isAdAvailableWithAdData:"), adData__handle__);
			} else {
				ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("isAdAvailableWithAdData:"), adData__handle__);
			}
			return ret != 0;
		}
		[Export ("loadAdWithAdData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadAdWithAdData (ISAdData adData, ISAdapterAdDelegate @delegate)
		{
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadAdWithAdData:delegate:"), adData__handle__, @delegate__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadAdWithAdData:delegate:"), adData__handle__, @delegate__handle__);
			}
		}
		[Export ("showAdWithViewController:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAdWithViewController (global::UIKit.UIViewController viewController, ISAdData adData, ISAdapterAdInteractionDelegate @delegate)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showAdWithViewController:adData:delegate:"), viewController__handle__, adData__handle__, @delegate__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("showAdWithViewController:adData:delegate:"), viewController__handle__, adData__handle__, @delegate__handle__);
			}
		}
	} /* class ISBaseAdInteractionAdapter */
}
