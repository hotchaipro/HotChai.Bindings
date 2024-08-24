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
    [Register("GADSearchBannerView", true)]
	public unsafe partial class SearchBannerView : BannerView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADSearchBannerView");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SearchBannerView () : base (NSObjectFlag.Empty)
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
		public SearchBannerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SearchBannerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SearchBannerView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SearchBannerView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		[Export ("initWithAdSize:origin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SearchBannerView (AdSize size, CGPoint origin)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_AdSize_CGPoint (this.Handle, Selector.GetHandle ("initWithAdSize:origin:"), size, origin), "initWithAdSize:origin:");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_AdSize_CGPoint (this.SuperHandle, Selector.GetHandle ("initWithAdSize:origin:"), size, origin), "initWithAdSize:origin:");
			}
		}
		[Export ("initWithAdSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SearchBannerView (AdSize size)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_AdSize (this.Handle, Selector.GetHandle ("initWithAdSize:"), size), "initWithAdSize:");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_AdSize (this.SuperHandle, Selector.GetHandle ("initWithAdSize:"), size), "initWithAdSize:");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdSizeDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual IAdSizeDelegate? AdSizeDelegate {
			[Export ("adSizeDelegate", ArgumentSemantic.Weak)]
			get {
				IAdSizeDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAdSizeDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adSizeDelegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<IAdSizeDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adSizeDelegate")), false)!;
				}
				MarkDirty ();
				__mt_AdSizeDelegate_var = ret;
				return ret!;
			}
			[Export ("setAdSizeDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdSizeDelegate:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdSizeDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdSizeDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_AdSizeDelegate_var = null;
			}
		}
		public partial class SearchBannerViewAppearance : global::Google.MobileAds.BannerView.BannerViewAppearance {
			protected internal SearchBannerViewAppearance (NativeHandle handle) : base (handle) {}
		}
		public static new SearchBannerViewAppearance Appearance {
			get { return new SearchBannerViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, global::ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new SearchBannerViewAppearance GetAppearance<T> () where T: SearchBannerView {
			return new SearchBannerViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), global::ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new SearchBannerViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new SearchBannerViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new SearchBannerViewAppearance GetAppearance (UITraitCollection traits) {
			return new SearchBannerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new SearchBannerViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new SearchBannerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new SearchBannerViewAppearance GetAppearance<T> (UITraitCollection traits) where T: SearchBannerView {
			return new SearchBannerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new SearchBannerViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: SearchBannerView{
			return new SearchBannerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class SearchBannerView */
}
