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
	[Register("LPMInitRequest", true)]
	public unsafe partial class LPMInitRequest : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("LPMInitRequest");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPMInitRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPMInitRequest (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAppKey:legacyAdFormats:userId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LPMInitRequest (string appKey, string[] legacyAdFormats, string? userId)
			: base (NSObjectFlag.Empty)
		{
			if (appKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appKey));
			if (legacyAdFormats is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (legacyAdFormats));
			var nsappKey = CFString.CreateNative (appKey);
			var nsa_legacyAdFormats = NSArray.FromStrings (legacyAdFormats);
			var nsuserId = CFString.CreateNative (userId);
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithAppKey:legacyAdFormats:userId:"), nsappKey, nsa_legacyAdFormats.Handle, nsuserId), "initWithAppKey:legacyAdFormats:userId:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAppKey:legacyAdFormats:userId:"), nsappKey, nsa_legacyAdFormats.Handle, nsuserId), "initWithAppKey:legacyAdFormats:userId:");
			}
			CFString.ReleaseNative (nsappKey);
			nsa_legacyAdFormats.Dispose ();
			CFString.ReleaseNative (nsuserId);
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
		public virtual string[] LegacyAdFormats {
			[Export ("legacyAdFormats")]
			get {
				if (IsDirectBinding) {
					return CFArray.StringArrayFromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("legacyAdFormats")))!;
				} else {
					return CFArray.StringArrayFromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("legacyAdFormats")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? UserId {
			[Export ("userId")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userId")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userId")))!;
				}
			}
		}
	} /* class LPMInitRequest */
}
