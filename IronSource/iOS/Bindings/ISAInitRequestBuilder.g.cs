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
	[Register("ISAInitRequestBuilder", true)]
	public unsafe partial class ISAInitRequestBuilder : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAInitRequestBuilder");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAInitRequestBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAInitRequestBuilder (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAppKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISAInitRequestBuilder (string appKey)
			: base (NSObjectFlag.Empty)
		{
			if (appKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appKey));
			var nsappKey = CFString.CreateNative (appKey);
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithAppKey:"), nsappKey), "initWithAppKey:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAppKey:"), nsappKey), "initWithAppKey:");
			}
			CFString.ReleaseNative (nsappKey);
		}
		[Export ("build")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAInitRequest Build ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<ISAInitRequest> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("build")))!;
			} else {
				return  Runtime.GetNSObject<ISAInitRequest> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("build")))!;
			}
		}
		[Export ("withLegacyAdFormats:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAInitRequestBuilder WithLegacyAdFormats (ISAAdFormat[] legacyAdFormats)
		{
			if (legacyAdFormats is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (legacyAdFormats));
			var nsa_legacyAdFormats = NSArray.FromNSObjects (legacyAdFormats);
			ISAInitRequestBuilder? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<ISAInitRequestBuilder> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("withLegacyAdFormats:"), nsa_legacyAdFormats.Handle))!;
			} else {
				ret =  Runtime.GetNSObject<ISAInitRequestBuilder> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("withLegacyAdFormats:"), nsa_legacyAdFormats.Handle))!;
			}
			nsa_legacyAdFormats.Dispose ();
			return ret!;
		}
		[Export ("withLogLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISAInitRequestBuilder WithLogLevel (ISALogLevel logLevel)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<ISAInitRequestBuilder> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("withLogLevel:"), (IntPtr) (long) logLevel))!;
			} else {
				return  Runtime.GetNSObject<ISAInitRequestBuilder> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("withLogLevel:"), (IntPtr) (long) logLevel))!;
			}
		}
	} /* class ISAInitRequestBuilder */
}
