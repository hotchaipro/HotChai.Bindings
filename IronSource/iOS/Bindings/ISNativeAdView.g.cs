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
	[Register("ISNativeAdView", true)]
	public unsafe partial class ISNativeAdView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISNativeAdView");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISNativeAdView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ISNativeAdView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISNativeAdView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISNativeAdView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("registerNativeAdViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterNativeAdViews (LevelPlayNativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("registerNativeAdViews:"), nativeAd__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("registerNativeAdViews:"), nativeAd__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdAdvertiserView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UILabel? AdAdvertiserView {
			[Export ("adAdvertiserView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UILabel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adAdvertiserView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adAdvertiserView")))!;
				}
				MarkDirty ();
				__mt_AdAdvertiserView_var = ret;
				return ret!;
			}
			[Export ("setAdAdvertiserView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdAdvertiserView:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdAdvertiserView:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdAdvertiserView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdAppIcon_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImageView? AdAppIcon {
			[Export ("adAppIcon", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIImageView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adAppIcon")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adAppIcon")))!;
				}
				MarkDirty ();
				__mt_AdAppIcon_var = ret;
				return ret!;
			}
			[Export ("setAdAppIcon:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdAppIcon:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdAppIcon:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdAppIcon_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdBodyView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UILabel? AdBodyView {
			[Export ("adBodyView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UILabel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adBodyView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adBodyView")))!;
				}
				MarkDirty ();
				__mt_AdBodyView_var = ret;
				return ret!;
			}
			[Export ("setAdBodyView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdBodyView:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdBodyView:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdBodyView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdCallToActionView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIButton? AdCallToActionView {
			[Export ("adCallToActionView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIButton? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adCallToActionView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adCallToActionView")))!;
				}
				MarkDirty ();
				__mt_AdCallToActionView_var = ret;
				return ret!;
			}
			[Export ("setAdCallToActionView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdCallToActionView:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdCallToActionView:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdCallToActionView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdMediaView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LevelPlayMediaView? AdMediaView {
			[Export ("adMediaView", ArgumentSemantic.Weak)]
			get {
				LevelPlayMediaView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LevelPlayMediaView> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adMediaView")))!;
				} else {
					ret =  Runtime.GetNSObject<LevelPlayMediaView> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adMediaView")))!;
				}
				MarkDirty ();
				__mt_AdMediaView_var = ret;
				return ret!;
			}
			[Export ("setAdMediaView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdMediaView:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdMediaView:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdMediaView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdTitleView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UILabel? AdTitleView {
			[Export ("adTitleView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UILabel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("adTitleView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adTitleView")))!;
				}
				MarkDirty ();
				__mt_AdTitleView_var = ret;
				return ret!;
			}
			[Export ("setAdTitleView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdTitleView:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdTitleView:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdTitleView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AdAdvertiserView_var = null;
				__mt_AdAppIcon_var = null;
				__mt_AdBodyView_var = null;
				__mt_AdCallToActionView_var = null;
				__mt_AdMediaView_var = null;
				__mt_AdTitleView_var = null;
			}
		}
		public partial class ISNativeAdViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal ISNativeAdViewAppearance (IntPtr handle) : base (handle) {}
		}
		public static new ISNativeAdViewAppearance Appearance {
			get { return new ISNativeAdViewAppearance (ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, global::ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new ISNativeAdViewAppearance GetAppearance<T> () where T: ISNativeAdView {
			return new ISNativeAdViewAppearance (ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), global::ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new ISNativeAdViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new ISNativeAdViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new ISNativeAdViewAppearance GetAppearance (UITraitCollection traits) {
			return new ISNativeAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new ISNativeAdViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new ISNativeAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new ISNativeAdViewAppearance GetAppearance<T> (UITraitCollection traits) where T: ISNativeAdView {
			return new ISNativeAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new ISNativeAdViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: ISNativeAdView{
			return new ISNativeAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class ISNativeAdView */
}
