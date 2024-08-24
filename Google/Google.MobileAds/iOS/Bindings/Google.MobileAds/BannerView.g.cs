//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using Trampolines = Google.MobileAds.ObjCRuntime.Trampolines;
using Libraries = Google.MobileAds.ObjCRuntime.Libraries;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADBannerView", true)]
	public unsafe partial class BannerView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADBannerView");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BannerView () : base (NSObjectFlag.Empty)
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
		public BannerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected BannerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BannerView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("initWithAdSize:origin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BannerView (AdSize size, CGPoint origin)
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
		public BannerView (AdSize size)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_AdSize (this.Handle, Selector.GetHandle ("initWithAdSize:"), size), "initWithAdSize:");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_AdSize (this.SuperHandle, Selector.GetHandle ("initWithAdSize:"), size), "initWithAdSize:");
			}
		}
		[Export ("loadRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRequest (Request? request)
		{
			var request__handle__ = request.GetHandle ();
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadRequest:"), request__handle__);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadRequest:"), request__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AdSize AdSize {
			[Export ("adSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				AdSize ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSend (this.Handle, Selector.GetHandle ("adSize"));
					} else if (IntPtr.Size == 8) {
						global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("adSize"));
					} else if (Runtime.Arch == Arch.DEVICE) {
						global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("adSize"));
					} else {
						global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("adSize"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adSize"));
					} else if (IntPtr.Size == 8) {
						global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("adSize"));
					} else if (Runtime.Arch == Arch.DEVICE) {
						global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("adSize"));
					} else {
						global::Google.MobileAds.ObjCRuntime.Messaging.AdSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("adSize"));
					}
				}
				return ret!;
			}
			[Export ("setAdSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_AdSize (this.Handle, Selector.GetHandle ("setAdSize:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_AdSize (this.SuperHandle, Selector.GetHandle ("setAdSize:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdSizeDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAdSizeDelegate? AdSizeDelegate {
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
		public virtual string? AdUnitId {
			[Export ("adUnitID", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adUnitID")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnitID")))!;
				}
			}
			[Export ("setAdUnitID:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdUnitID:"), nsvalue);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdUnitID:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoloadEnabled {
			[Export ("isAutoloadEnabled")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAutoloadEnabled"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAutoloadEnabled"));
				}
			}
			[Export ("setAutoloadEnabled:")]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoloadEnabled:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoloadEnabled:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IBannerViewDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IBannerViewDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IBannerViewDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<IBannerViewDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false)!;
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
		public virtual ResponseInfo? ResponseInfo {
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
		//
		// Events and properties from the delegate
		//
		_BannerViewDelegate EnsureBannerViewDelegate ()
		{
			var del = Delegate;
			if (del is null || (!(del is _BannerViewDelegate))){
				del = new _BannerViewDelegate ();
				Delegate = del;
			}
			return (_BannerViewDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _BannerViewDelegate : Google.MobileAds.BannerViewDelegate { 
			public _BannerViewDelegate () { IsDirectBinding = false; }
			internal EventHandler? didDismissScreen;
			[Preserve (Conditional = true)]
			public override void DidDismissScreen (Google.MobileAds.BannerView adView)
			{
				var handler = didDismissScreen;
				if (handler != null){
					handler (adView, EventArgs.Empty);
				}
			}
			internal EventHandler<BannerViewErrorEventArgs>? didFailToReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidFailToReceiveAd (Google.MobileAds.BannerView view, NSError error)
			{
				var handler = didFailToReceiveAd;
				if (handler != null){
					var args = new BannerViewErrorEventArgs (error);
					handler (view, args);
				}
			}
			internal EventHandler? didReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidReceiveAd (Google.MobileAds.BannerView view)
			{
				var handler = didReceiveAd;
				if (handler != null){
					handler (view, EventArgs.Empty);
				}
			}
			internal EventHandler? didRecordClick;
			[Preserve (Conditional = true)]
			public override void DidRecordClick (Google.MobileAds.BannerView view)
			{
				var handler = didRecordClick;
				if (handler != null){
					handler (view, EventArgs.Empty);
				}
			}
			internal EventHandler? didRecordImpression;
			[Preserve (Conditional = true)]
			public override void DidRecordImpression (Google.MobileAds.BannerView view)
			{
				var handler = didRecordImpression;
				if (handler != null){
					handler (view, EventArgs.Empty);
				}
			}
			internal EventHandler? willDismissScreen;
			[Preserve (Conditional = true)]
			public override void WillDismissScreen (Google.MobileAds.BannerView adView)
			{
				var handler = willDismissScreen;
				if (handler != null){
					handler (adView, EventArgs.Empty);
				}
			}
			internal EventHandler? willPresentScreen;
			[Preserve (Conditional = true)]
			public override void WillPresentScreen (Google.MobileAds.BannerView adView)
			{
				var handler = willPresentScreen;
				if (handler != null){
					handler (adView, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		_AdSizeDelegate EnsureAdSizeDelegate ()
		{
			var del = AdSizeDelegate;
			if (del is null || (!(del is _AdSizeDelegate))){
				del = new _AdSizeDelegate ();
				AdSizeDelegate = del;
			}
			return (_AdSizeDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _AdSizeDelegate : Google.MobileAds.AdSizeDelegate { 
			public _AdSizeDelegate () { IsDirectBinding = false; }
			internal EventHandler<AdSizeDelegateSizeEventArgs>? willChangeAdSizeTo;
			[Preserve (Conditional = true)]
			public override void WillChangeAdSizeTo (Google.MobileAds.BannerView view, Google.MobileAds.AdSize size)
			{
				var handler = willChangeAdSizeTo;
				if (handler != null){
					var args = new AdSizeDelegateSizeEventArgs (size);
					handler (view, args);
				}
			}
		}
		#pragma warning restore 672
		public event EventHandler<AdSizeDelegateSizeEventArgs> WillChangeAdSizeTo {
			add { EnsureAdSizeDelegate ()!.willChangeAdSizeTo += value; }
			remove { EnsureAdSizeDelegate ()!.willChangeAdSizeTo -= value; }
		}
		public event EventHandler ScreenDismissed {
			add { EnsureBannerViewDelegate ()!.didDismissScreen += value; }
			remove { EnsureBannerViewDelegate ()!.didDismissScreen -= value; }
		}
		public event EventHandler<BannerViewErrorEventArgs> ReceiveAdFailed {
			add { EnsureBannerViewDelegate ()!.didFailToReceiveAd += value; }
			remove { EnsureBannerViewDelegate ()!.didFailToReceiveAd -= value; }
		}
		public event EventHandler AdReceived {
			add { EnsureBannerViewDelegate ()!.didReceiveAd += value; }
			remove { EnsureBannerViewDelegate ()!.didReceiveAd -= value; }
		}
		public event EventHandler ClickRecorded {
			add { EnsureBannerViewDelegate ()!.didRecordClick += value; }
			remove { EnsureBannerViewDelegate ()!.didRecordClick -= value; }
		}
		public event EventHandler ImpressionRecorded {
			add { EnsureBannerViewDelegate ()!.didRecordImpression += value; }
			remove { EnsureBannerViewDelegate ()!.didRecordImpression -= value; }
		}
		public event EventHandler WillDismissScreen {
			add { EnsureBannerViewDelegate ()!.willDismissScreen += value; }
			remove { EnsureBannerViewDelegate ()!.willDismissScreen -= value; }
		}
		public event EventHandler WillPresentScreen {
			add { EnsureBannerViewDelegate ()!.willPresentScreen += value; }
			remove { EnsureBannerViewDelegate ()!.willPresentScreen -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_AdSizeDelegate_var = null;
				__mt_Delegate_var = null;
				__mt_RootViewController_var = null;
			}
		}
		public partial class BannerViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal BannerViewAppearance (NativeHandle handle) : base (handle) {}
		}
		public static new BannerViewAppearance Appearance {
			get { return new BannerViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, global::ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new BannerViewAppearance GetAppearance<T> () where T: BannerView {
			return new BannerViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), global::ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new BannerViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new BannerViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new BannerViewAppearance GetAppearance (UITraitCollection traits) {
			return new BannerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new BannerViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new BannerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new BannerViewAppearance GetAppearance<T> (UITraitCollection traits) where T: BannerView {
			return new BannerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new BannerViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: BannerView{
			return new BannerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class BannerView */
	//
	// EventArgs classes
	//
	public partial class AdSizeDelegateSizeEventArgs : EventArgs {
		public AdSizeDelegateSizeEventArgs (Google.MobileAds.AdSize size)
		{
			this.Size = size;
		}
		public Google.MobileAds.AdSize Size { get; set; }
	}
	public partial class BannerViewErrorEventArgs : EventArgs {
		public BannerViewErrorEventArgs (NSError error)
		{
			this.Error = error;
		}
		public NSError Error { get; set; }
	}
}
