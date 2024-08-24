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
	[Register("ISBaseAdAdapter", true)]
	public unsafe partial class ISBaseAdAdapter : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBaseAdAdapter");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBaseAdAdapter () : base (NSObjectFlag.Empty)
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
		protected ISBaseAdAdapter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBaseAdAdapter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAdUnit:adapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISBaseAdAdapter (ISAdUnit adUnit, ISAdapterConfig adapterConfig)
			: base (NSObjectFlag.Empty)
		{
			var adUnit__handle__ = adUnit!.GetNonNullHandle (nameof (adUnit));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithAdUnit:adapterConfig:"), adUnit__handle__, adapterConfig__handle__), "initWithAdUnit:adapterConfig:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAdUnit:adapterConfig:"), adUnit__handle__, adapterConfig__handle__), "initWithAdUnit:adapterConfig:");
			}
		}
		[Export ("initWithAdUnit:adapterConfig:adUnitObjectId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISBaseAdAdapter (ISAdUnit adUnit, ISAdapterConfig adapterConfig, NSUuid? adUnitObjectId)
			: base (NSObjectFlag.Empty)
		{
			var adUnit__handle__ = adUnit!.GetNonNullHandle (nameof (adUnit));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adUnitObjectId__handle__ = adUnitObjectId.GetHandle ();
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithAdUnit:adapterConfig:adUnitObjectId:"), adUnit__handle__, adapterConfig__handle__, adUnitObjectId__handle__), "initWithAdUnit:adapterConfig:adUnitObjectId:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAdUnit:adapterConfig:adUnitObjectId:"), adUnit__handle__, adapterConfig__handle__, adUnitObjectId__handle__), "initWithAdUnit:adapterConfig:adUnitObjectId:");
			}
		}
		[Export ("releaseMemory")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReleaseMemory ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("releaseMemory"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("releaseMemory"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdUnit_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAdUnit AdUnit {
			[Export ("adUnit", ArgumentSemantic.Assign)]
			get {
				ISAdUnit? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ISAdUnit> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adUnit")))!;
				} else {
					ret =  Runtime.GetNSObject<ISAdUnit> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnit")))!;
				}
				MarkDirty ();
				__mt_AdUnit_var = ret;
				return ret!;
			}
			[Export ("setAdUnit:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdUnit:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdUnit:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdUnit_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUuid? AdUnitObjectId {
			[Export ("adUnitObjectId")]
			get {
				NSUuid? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUuid> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adUnitObjectId")))!;
				} else {
					ret =  Runtime.GetNSObject<NSUuid> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnitObjectId")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAdapterConfig AdapterConfig {
			[Export ("adapterConfig")]
			get {
				ISAdapterConfig? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ISAdapterConfig> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adapterConfig")))!;
				} else {
					ret =  Runtime.GetNSObject<ISAdapterConfig> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adapterConfig")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAdapterBaseProtocol? NetworkAdapter {
			[Export ("getNetworkAdapter")]
			get {
				ISAdapterBaseProtocol? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISAdapterBaseProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getNetworkAdapter")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<ISAdapterBaseProtocol> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getNetworkAdapter")), false)!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AdUnit_var = null;
			}
		}
	} /* class ISBaseAdAdapter */
}
