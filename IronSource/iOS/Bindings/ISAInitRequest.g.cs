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
	[Register("ISAInitRequest", true)]
	public unsafe partial class ISAInitRequest : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAInitRequest");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAInitRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAInitRequest (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AppKey {
			[Export ("appKey")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("appKey")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appKey")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAAdFormat[] LegacyAdFormats {
			[Export ("legacyAdFormats")]
			get {
				ISAAdFormat[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ISAAdFormat>(ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("legacyAdFormats")))!;
				} else {
					ret = CFArray.ArrayFromHandle<ISAAdFormat>(ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("legacyAdFormats")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISALogLevel LogLevel {
			[Export ("logLevel")]
			get {
				ISALogLevel ret;
				if (IsDirectBinding) {
					ret = (IronSourceSdk.ISALogLevel) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("logLevel"));
				} else {
					ret = (IronSourceSdk.ISALogLevel) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logLevel"));
				}
				return ret!;
			}
		}
	} /* class ISAInitRequest */
}
