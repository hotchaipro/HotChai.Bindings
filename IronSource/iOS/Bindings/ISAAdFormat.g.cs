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
	[Register("ISAAdFormat", true)]
	public unsafe partial class ISAAdFormat : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAAdFormat");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAAdFormat (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAAdFormat (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAdFormatType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISAAdFormat (ISAAdFormatType adFormatType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("initWithAdFormatType:"), (UIntPtr) (ulong) adFormatType), "initWithAdFormatType:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("initWithAdFormatType:"), (UIntPtr) (ulong) adFormatType), "initWithAdFormatType:");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAAdFormatType AdFormatType {
			[Export ("adFormatType")]
			get {
				ISAAdFormatType ret;
				if (IsDirectBinding) {
					ret = (IronSourceSdk.ISAAdFormatType) (ulong) ApiDefinitions.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adFormatType"));
				} else {
					ret = (IronSourceSdk.ISAAdFormatType) (ulong) ApiDefinitions.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adFormatType"));
				}
				return ret!;
			}
		}
	} /* class ISAAdFormat */
}
