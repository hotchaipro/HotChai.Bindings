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
	[Register("ISWaterfallConfiguration", true)]
	public unsafe partial class ISWaterfallConfiguration : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISWaterfallConfiguration");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISWaterfallConfiguration () : base (NSObjectFlag.Empty)
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
		protected ISWaterfallConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISWaterfallConfiguration (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("clear")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISWaterfallConfiguration Clear ()
		{
			return  Runtime.GetNSObject<ISWaterfallConfiguration> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("clear")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISWaterfallConfigurationBuilder Builder {
			[Export ("builder")]
			get {
				ISWaterfallConfigurationBuilder? ret;
				ret =  Runtime.GetNSObject<ISWaterfallConfigurationBuilder> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("builder")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Ceiling {
			[Export ("ceiling", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("ceiling")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ceiling")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Floor {
			[Export ("floor", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("floor")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("floor")))!;
				}
				return ret!;
			}
		}
	} /* class ISWaterfallConfiguration */
}
