//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Trampolines = Google.MobileAds.ObjCRuntime.Trampolines;
using Libraries = Google.MobileAds.ObjCRuntime.Libraries;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADNativeAd", true)]
	public unsafe partial class NativeAd : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADNativeAd");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NativeAd () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NativeAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NativeAd (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("cancelUnconfirmedClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelUnconfirmedClick ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelUnconfirmedClick"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelUnconfirmedClick"));
			}
		}
		[Export ("enableCustomClickGestures")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnableCustomClickGestures ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("enableCustomClickGestures"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableCustomClickGestures"));
			}
		}
		[Export ("muteThisAdWithReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MuteThisAd (MuteThisAdReason reason)
		{
			var reason__handle__ = reason!.GetNonNullHandle (nameof (reason));
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("muteThisAdWithReason:"), reason__handle__);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("muteThisAdWithReason:"), reason__handle__);
			}
		}
		[Export ("recordCustomClickGesture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordCustomClickGesture ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("recordCustomClickGesture"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recordCustomClickGesture"));
			}
		}
		[Export ("registerAdView:clickableAssetViews:nonclickableAssetViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterAdView (global::UIKit.UIView adView, NSDictionary<NSString, global::UIKit.UIView> nsClickableAssetViews, NSDictionary<NSString, global::UIKit.UIView> nsNonclickableAssetViews)
		{
			var adView__handle__ = adView!.GetNonNullHandle (nameof (adView));
			var nsClickableAssetViews__handle__ = nsClickableAssetViews!.GetNonNullHandle (nameof (nsClickableAssetViews));
			var nsNonclickableAssetViews__handle__ = nsNonclickableAssetViews!.GetNonNullHandle (nameof (nsNonclickableAssetViews));
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("registerAdView:clickableAssetViews:nonclickableAssetViews:"), adView__handle__, nsClickableAssetViews__handle__, nsNonclickableAssetViews__handle__);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("registerAdView:clickableAssetViews:nonclickableAssetViews:"), adView__handle__, nsClickableAssetViews__handle__, nsNonclickableAssetViews__handle__);
			}
		}
		[Export ("registerClickConfirmingView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterClickConfirmingView (global::UIKit.UIView? view)
		{
			var view__handle__ = view.GetHandle ();
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerClickConfirmingView:"), view__handle__);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerClickConfirmingView:"), view__handle__);
			}
		}
		[Export ("unregisterAdView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterAdView ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unregisterAdView"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unregisterAdView"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Advertiser {
			[Export ("advertiser")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("advertiser")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("advertiser")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Body {
			[Export ("body")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("body")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("body")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CallToAction {
			[Export ("callToAction")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("callToAction")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("callToAction")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INativeAdDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				INativeAdDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<INativeAdDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<INativeAdDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false)!;
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? ExtraAssets {
			[Export ("extraAssets", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("extraAssets")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("extraAssets")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NativeAdImage? Icon {
			[Export ("icon", ArgumentSemantic.Retain)]
			get {
				NativeAdImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NativeAdImage> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("icon")))!;
				} else {
					ret =  Runtime.GetNSObject<NativeAdImage> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("icon")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NativeAdImage[]? Images {
			[Export ("images", ArgumentSemantic.Retain)]
			get {
				NativeAdImage[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NativeAdImage>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("images")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NativeAdImage>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("images")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCustomMuteThisAdAvailable {
			[Export ("isCustomMuteThisAdAvailable")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCustomMuteThisAdAvailable"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isCustomMuteThisAdAvailable"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MediaContent MediaContent {
			[Export ("mediaContent")]
			get {
				MediaContent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MediaContent> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mediaContent")))!;
				} else {
					ret =  Runtime.GetNSObject<MediaContent> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mediaContent")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MuteThisAdReason[]? MuteThisAdReasons {
			[Export ("muteThisAdReasons")]
			get {
				MuteThisAdReason[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MuteThisAdReason>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("muteThisAdReasons")))!;
				} else {
					ret = CFArray.ArrayFromHandle<MuteThisAdReason>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("muteThisAdReasons")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual PaidEventHandler? PaidEventHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDPaidEventHandler))]
			[Export ("paidEventHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paidEventHandler"));
				} else {
					ret = global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paidEventHandler"));
				}
				return global::Google.MobileAds.ObjCRuntime.Trampolines.NIDPaidEventHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPaidEventHandler))]
			[Export ("setPaidEventHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDPaidEventHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPaidEventHandler:"), (NativeHandle) block_ptr_value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPaidEventHandler:"), (NativeHandle) block_ptr_value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Price {
			[Export ("price")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("price")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("price")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ResponseInfo ResponseInfo {
			[Export ("responseInfo")]
			get {
				ResponseInfo? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ResponseInfo> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseInfo")))!;
				} else {
					ret =  Runtime.GetNSObject<ResponseInfo> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseInfo")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_RootViewController_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController? RootViewController {
			[Export ("rootViewController", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewController")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewController")))!;
				}
				MarkDirty ();
				__mt_RootViewController_var = ret;
				return ret!;
			}
			[Export ("setRootViewController:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewController:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewController:"), value__handle__);
				}
				MarkDirty ();
				__mt_RootViewController_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber? StarRating {
			[Export ("starRating", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("starRating")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("starRating")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Store {
			[Export ("store")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("store")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("store")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_UnconfirmedClickDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INativeAdUnconfirmedClickDelegate? UnconfirmedClickDelegate {
			[Export ("unconfirmedClickDelegate", ArgumentSemantic.Weak)]
			get {
				INativeAdUnconfirmedClickDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<INativeAdUnconfirmedClickDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unconfirmedClickDelegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<INativeAdUnconfirmedClickDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unconfirmedClickDelegate")), false)!;
				}
				MarkDirty ();
				__mt_UnconfirmedClickDelegate_var = ret;
				return ret!;
			}
			[Export ("setUnconfirmedClickDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUnconfirmedClickDelegate:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUnconfirmedClickDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_UnconfirmedClickDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		_NativeAdDelegate EnsureNativeAdDelegate ()
		{
			var del = Delegate;
			if (del is null || (!(del is _NativeAdDelegate))){
				del = new _NativeAdDelegate ();
				Delegate = del;
			}
			return (_NativeAdDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _NativeAdDelegate : Google.MobileAds.NativeAdDelegate { 
			public _NativeAdDelegate () { IsDirectBinding = false; }
			internal EventHandler? didDismissScreen;
			[Preserve (Conditional = true)]
			public override void DidDismissScreen (Google.MobileAds.NativeAd nativeAd)
			{
				var handler = didDismissScreen;
				if (handler != null){
					handler (nativeAd, EventArgs.Empty);
				}
			}
			internal EventHandler? didRecordClick;
			[Preserve (Conditional = true)]
			public override void DidRecordClick (Google.MobileAds.NativeAd nativeAd)
			{
				var handler = didRecordClick;
				if (handler != null){
					handler (nativeAd, EventArgs.Empty);
				}
			}
			internal EventHandler? didRecordImpression;
			[Preserve (Conditional = true)]
			public override void DidRecordImpression (Google.MobileAds.NativeAd nativeAd)
			{
				var handler = didRecordImpression;
				if (handler != null){
					handler (nativeAd, EventArgs.Empty);
				}
			}
			internal EventHandler? willDismissScreen;
			[Preserve (Conditional = true)]
			public override void WillDismissScreen (Google.MobileAds.NativeAd nativeAd)
			{
				var handler = willDismissScreen;
				if (handler != null){
					handler (nativeAd, EventArgs.Empty);
				}
			}
			internal EventHandler? willLeaveApplication;
			[Preserve (Conditional = true)]
			public override void WillLeaveApplication (Google.MobileAds.NativeAd nativeAd)
			{
				var handler = willLeaveApplication;
				if (handler != null){
					handler (nativeAd, EventArgs.Empty);
				}
			}
			internal EventHandler? willPresentScreen;
			[Preserve (Conditional = true)]
			public override void WillPresentScreen (Google.MobileAds.NativeAd nativeAd)
			{
				var handler = willPresentScreen;
				if (handler != null){
					handler (nativeAd, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		_NativeAdUnconfirmedClickDelegate EnsureNativeAdUnconfirmedClickDelegate ()
		{
			var del = UnconfirmedClickDelegate;
			if (del is null || (!(del is _NativeAdUnconfirmedClickDelegate))){
				del = new _NativeAdUnconfirmedClickDelegate ();
				UnconfirmedClickDelegate = del;
			}
			return (_NativeAdUnconfirmedClickDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _NativeAdUnconfirmedClickDelegate : Google.MobileAds.NativeAdUnconfirmedClickDelegate { 
			public _NativeAdUnconfirmedClickDelegate () { IsDirectBinding = false; }
			internal EventHandler? didCancelUnconfirmedClick;
			[Preserve (Conditional = true)]
			public override void DidCancelUnconfirmedClick (Google.MobileAds.NativeAd nativeAd)
			{
				var handler = didCancelUnconfirmedClick;
				if (handler != null){
					handler (nativeAd, EventArgs.Empty);
				}
			}
			internal EventHandler<NativeAdUnconfirmedClickReceivedEventArgs>? didReceiveUnconfirmedClick;
			[Preserve (Conditional = true)]
			public override void DidReceiveUnconfirmedClick (Google.MobileAds.NativeAd nativeAd, string assetId)
			{
				var handler = didReceiveUnconfirmedClick;
				if (handler != null){
					var args = new NativeAdUnconfirmedClickReceivedEventArgs (assetId);
					handler (nativeAd, args);
				}
			}
		}
		#pragma warning restore 672
		public event EventHandler ScreenDismissed {
			add { EnsureNativeAdDelegate ()!.didDismissScreen += value; }
			remove { EnsureNativeAdDelegate ()!.didDismissScreen -= value; }
		}
		public event EventHandler ClickRecorded {
			add { EnsureNativeAdDelegate ()!.didRecordClick += value; }
			remove { EnsureNativeAdDelegate ()!.didRecordClick -= value; }
		}
		public event EventHandler ImpressionRecorded {
			add { EnsureNativeAdDelegate ()!.didRecordImpression += value; }
			remove { EnsureNativeAdDelegate ()!.didRecordImpression -= value; }
		}
		public event EventHandler WillDismissScreen {
			add { EnsureNativeAdDelegate ()!.willDismissScreen += value; }
			remove { EnsureNativeAdDelegate ()!.willDismissScreen -= value; }
		}
		public event EventHandler WillLeaveApplication {
			add { EnsureNativeAdDelegate ()!.willLeaveApplication += value; }
			remove { EnsureNativeAdDelegate ()!.willLeaveApplication -= value; }
		}
		public event EventHandler WillPresentScreen {
			add { EnsureNativeAdDelegate ()!.willPresentScreen += value; }
			remove { EnsureNativeAdDelegate ()!.willPresentScreen -= value; }
		}
		public event EventHandler UnconfirmedClickCancelled {
			add { EnsureNativeAdUnconfirmedClickDelegate ()!.didCancelUnconfirmedClick += value; }
			remove { EnsureNativeAdUnconfirmedClickDelegate ()!.didCancelUnconfirmedClick -= value; }
		}
		public event EventHandler<NativeAdUnconfirmedClickReceivedEventArgs> UnconfirmedClickReceived {
			add { EnsureNativeAdUnconfirmedClickDelegate ()!.didReceiveUnconfirmedClick += value; }
			remove { EnsureNativeAdUnconfirmedClickDelegate ()!.didReceiveUnconfirmedClick -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_Delegate_var = null;
				__mt_RootViewController_var = null;
				__mt_UnconfirmedClickDelegate_var = null;
			}
		}
	} /* class NativeAd */
	//
	// EventArgs classes
	//
	public partial class NativeAdUnconfirmedClickReceivedEventArgs : EventArgs {
		public NativeAdUnconfirmedClickReceivedEventArgs (string assetId)
		{
			this.AssetId = assetId;
		}
		public string AssetId { get; set; }
	}
}
