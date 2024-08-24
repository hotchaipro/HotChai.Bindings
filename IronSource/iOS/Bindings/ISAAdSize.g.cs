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
	[Register("ISAAdSize", true)]
	public unsafe partial class ISAAdSize : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAAdSize");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAAdSize (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAAdSize (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISAAdSize Banner {
			[Export ("banner")]
			get {
				ISAAdSize? ret;
				ret =  Runtime.GetNSObject<ISAAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("banner")))!;
				return ret!;
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISAAdSize Large {
			[Export ("large")]
			get {
				ISAAdSize? ret;
				ret =  Runtime.GetNSObject<ISAAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("large")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISAAdSize Leaderboard {
			[Export ("leaderboard")]
			get {
				ISAAdSize? ret;
				ret =  Runtime.GetNSObject<ISAAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("leaderboard")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISAAdSize MediumRectangle {
			[Export ("mediumRectangle")]
			get {
				ISAAdSize? ret;
				ret =  Runtime.GetNSObject<ISAAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("mediumRectangle")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SizeDescription {
			[Export ("sizeDescription")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sizeDescription")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sizeDescription")))!;
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
		}
	} /* class ISAAdSize */
}
