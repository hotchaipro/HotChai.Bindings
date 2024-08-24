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
	[Register("LPMAdSize", true)]
	public unsafe partial class LPMAdSize : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("LPMAdSize");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPMAdSize (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPMAdSize (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("bannerSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LPMAdSize BannerSize ()
		{
			return  Runtime.GetNSObject<LPMAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("bannerSize")))!;
		}
		[Export ("copyWithZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual NSObject Copy (NSZone zone)
		{
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			if (IsDirectBinding) {
				return Runtime.GetNSObject (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle))!;
			} else {
				return Runtime.GetNSObject (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone.Handle))!;
			}
		}
		[Export ("createAdaptiveAdSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LPMAdSize? CreateAdaptiveAdSize ()
		{
			return  Runtime.GetNSObject<LPMAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("createAdaptiveAdSize")))!;
		}
		[Export ("createAdaptiveAdSizeWithWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LPMAdSize? CreateAdaptiveAdSizeWithWidth (nfloat width)
		{
			return  Runtime.GetNSObject<LPMAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_nfloat (class_ptr, Selector.GetHandle ("createAdaptiveAdSizeWithWidth:"), width))!;
		}
		[Export ("customSizeWithWidth:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LPMAdSize CustomSizeWithWidth (nint width, nint height)
		{
			return  Runtime.GetNSObject<LPMAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("customSizeWithWidth:height:"), width, height))!;
		}
		[Export ("largeSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LPMAdSize LargeSize ()
		{
			return  Runtime.GetNSObject<LPMAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("largeSize")))!;
		}
		[Export ("leaderBoardSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LPMAdSize LeaderBoardSize ()
		{
			return  Runtime.GetNSObject<LPMAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("leaderBoardSize")))!;
		}
		[Export ("mediumRectangleSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LPMAdSize MediumRectangleSize ()
		{
			return  Runtime.GetNSObject<LPMAdSize> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("mediumRectangleSize")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Height {
			[Export ("height")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("height"));
				} else {
					return ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("height"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAdaptive {
			[Export ("isAdaptive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAdaptive"));
				} else {
					ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAdaptive"));
				}
				return ret != 0;
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
		public virtual LPMAdSizeType Type {
			[Export ("type")]
			get {
				LPMAdSizeType ret;
				if (IsDirectBinding) {
					ret = (IronSourceSdk.LPMAdSizeType) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				} else {
					ret = (IronSourceSdk.LPMAdSizeType) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Width {
			[Export ("width")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("width"));
				} else {
					return ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("width"));
				}
			}
		}
	} /* class LPMAdSize */
}
