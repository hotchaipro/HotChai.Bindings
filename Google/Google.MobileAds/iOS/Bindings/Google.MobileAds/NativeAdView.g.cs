//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADNativeAdView", true)]
	public unsafe partial class NativeAdView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADNativeAdView");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NativeAdView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NativeAdView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NativeAdView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NativeAdView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NativeAdView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdChoicesView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AdChoicesView? AdChoicesView {
			[Export ("adChoicesView", ArgumentSemantic.Weak)]
			get {
				AdChoicesView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AdChoicesView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adChoicesView")))!;
				} else {
					ret =  Runtime.GetNSObject<AdChoicesView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adChoicesView")))!;
				}
				MarkDirty ();
				__mt_AdChoicesView_var = ret;
				return ret!;
			}
			[Export ("setAdChoicesView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdChoicesView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdChoicesView:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdChoicesView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdvertiserView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? AdvertiserView {
			[Export ("advertiserView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("advertiserView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("advertiserView")))!;
				}
				MarkDirty ();
				__mt_AdvertiserView_var = ret;
				return ret!;
			}
			[Export ("setAdvertiserView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdvertiserView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdvertiserView:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdvertiserView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_BodyView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? BodyView {
			[Export ("bodyView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bodyView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bodyView")))!;
				}
				MarkDirty ();
				__mt_BodyView_var = ret;
				return ret!;
			}
			[Export ("setBodyView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBodyView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBodyView:"), value__handle__);
				}
				MarkDirty ();
				__mt_BodyView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_CallToActionView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? CallToActionView {
			[Export ("callToActionView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("callToActionView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("callToActionView")))!;
				}
				MarkDirty ();
				__mt_CallToActionView_var = ret;
				return ret!;
			}
			[Export ("setCallToActionView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCallToActionView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCallToActionView:"), value__handle__);
				}
				MarkDirty ();
				__mt_CallToActionView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_HeadlineView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? HeadlineView {
			[Export ("headlineView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("headlineView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("headlineView")))!;
				}
				MarkDirty ();
				__mt_HeadlineView_var = ret;
				return ret!;
			}
			[Export ("setHeadlineView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeadlineView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeadlineView:"), value__handle__);
				}
				MarkDirty ();
				__mt_HeadlineView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_IconView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? IconView {
			[Export ("iconView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("iconView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("iconView")))!;
				}
				MarkDirty ();
				__mt_IconView_var = ret;
				return ret!;
			}
			[Export ("setIconView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIconView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setIconView:"), value__handle__);
				}
				MarkDirty ();
				__mt_IconView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ImageView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? ImageView {
			[Export ("imageView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("imageView")))!;
				}
				MarkDirty ();
				__mt_ImageView_var = ret;
				return ret!;
			}
			[Export ("setImageView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImageView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setImageView:"), value__handle__);
				}
				MarkDirty ();
				__mt_ImageView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_MediaView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MediaView? MediaView {
			[Export ("mediaView", ArgumentSemantic.Weak)]
			get {
				MediaView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MediaView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mediaView")))!;
				} else {
					ret =  Runtime.GetNSObject<MediaView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaView")))!;
				}
				MarkDirty ();
				__mt_MediaView_var = ret;
				return ret!;
			}
			[Export ("setMediaView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMediaView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMediaView:"), value__handle__);
				}
				MarkDirty ();
				__mt_MediaView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NativeAd? NativeAd {
			[Export ("nativeAd", ArgumentSemantic.Retain)]
			get {
				NativeAd? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NativeAd> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("nativeAd")))!;
				} else {
					ret =  Runtime.GetNSObject<NativeAd> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nativeAd")))!;
				}
				return ret!;
			}
			[Export ("setNativeAd:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNativeAd:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNativeAd:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PriceView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? PriceView {
			[Export ("priceView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("priceView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("priceView")))!;
				}
				MarkDirty ();
				__mt_PriceView_var = ret;
				return ret!;
			}
			[Export ("setPriceView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPriceView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPriceView:"), value__handle__);
				}
				MarkDirty ();
				__mt_PriceView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_StarRatingView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? StarRatingView {
			[Export ("starRatingView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("starRatingView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("starRatingView")))!;
				}
				MarkDirty ();
				__mt_StarRatingView_var = ret;
				return ret!;
			}
			[Export ("setStarRatingView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStarRatingView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStarRatingView:"), value__handle__);
				}
				MarkDirty ();
				__mt_StarRatingView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_StoreView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? StoreView {
			[Export ("storeView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("storeView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("storeView")))!;
				}
				MarkDirty ();
				__mt_StoreView_var = ret;
				return ret!;
			}
			[Export ("setStoreView:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStoreView:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStoreView:"), value__handle__);
				}
				MarkDirty ();
				__mt_StoreView_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_AdChoicesView_var = null;
				__mt_AdvertiserView_var = null;
				__mt_BodyView_var = null;
				__mt_CallToActionView_var = null;
				__mt_HeadlineView_var = null;
				__mt_IconView_var = null;
				__mt_ImageView_var = null;
				__mt_MediaView_var = null;
				__mt_PriceView_var = null;
				__mt_StarRatingView_var = null;
				__mt_StoreView_var = null;
			}
		}
		public partial class NativeAdViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal NativeAdViewAppearance (NativeHandle handle) : base (handle) {}
		}
		public static new NativeAdViewAppearance Appearance {
			get { return new NativeAdViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, global::ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new NativeAdViewAppearance GetAppearance<T> () where T: NativeAdView {
			return new NativeAdViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), global::ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new NativeAdViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new NativeAdViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new NativeAdViewAppearance GetAppearance (UITraitCollection traits) {
			return new NativeAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new NativeAdViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new NativeAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new NativeAdViewAppearance GetAppearance<T> (UITraitCollection traits) where T: NativeAdView {
			return new NativeAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new NativeAdViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: NativeAdView{
			return new NativeAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class NativeAdView */
}
