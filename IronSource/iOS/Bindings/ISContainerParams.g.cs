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
	[Register("ISContainerParams", true)]
	public unsafe partial class ISContainerParams : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISContainerParams");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISContainerParams () : base (NSObjectFlag.Empty)
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
		protected ISContainerParams (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISContainerParams (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithWidth:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISContainerParams (nfloat width, nfloat height)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (this.Handle, Selector.GetHandle ("initWithWidth:height:"), width, height), "initWithWidth:height:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_nfloat_nfloat (this.SuperHandle, Selector.GetHandle ("initWithWidth:height:"), width, height), "initWithWidth:height:");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Height {
			[Export ("height")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("height"));
				} else {
					return ApiDefinitions.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("height"));
				}
			}
			[Export ("setHeight:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setHeight:"), value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setHeight:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Width {
			[Export ("width")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("width"));
				} else {
					return ApiDefinitions.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("width"));
				}
			}
			[Export ("setWidth:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setWidth:"), value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setWidth:"), value);
				}
			}
		}
	} /* class ISContainerParams */
}
