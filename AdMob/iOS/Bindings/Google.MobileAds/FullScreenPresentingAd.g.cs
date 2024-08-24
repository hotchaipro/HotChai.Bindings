//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Protocol (Name = "GADFullScreenPresentingAd", WrapperType = typeof (FullScreenPresentingAdWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Delegate", Selector = "fullScreenContentDelegate", PropertyType = typeof (Google.MobileAds.IFullScreenContentDelegate), GetterSelector = "fullScreenContentDelegate", SetterSelector = "setFullScreenContentDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	public partial interface IFullScreenPresentingAd : INativeObject, IDisposable
	{
	}
	public static partial class FullScreenPresentingAd_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IFullScreenContentDelegate GetDelegate (this IFullScreenPresentingAd This)
		{
			return  Runtime.GetINativeObject<IFullScreenContentDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("fullScreenContentDelegate")), false)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDelegate (this IFullScreenPresentingAd This, IFullScreenContentDelegate value)
		{
			var value__handle__ = value.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setFullScreenContentDelegate:"), value__handle__);
		}
	}
	internal sealed class FullScreenPresentingAdWrapper : BaseWrapper, IFullScreenPresentingAd {
		[Preserve (Conditional = true)]
		public FullScreenPresentingAdWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("GADFullScreenPresentingAd", true)]
	public unsafe partial class FullScreenPresentingAd : NSObject, IFullScreenPresentingAd {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADFullScreenPresentingAd");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FullScreenPresentingAd () : base (NSObjectFlag.Empty)
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
		protected FullScreenPresentingAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FullScreenPresentingAd (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IFullScreenContentDelegate? Delegate {
			[Export ("fullScreenContentDelegate", ArgumentSemantic.Weak)]
			get {
				IFullScreenContentDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IFullScreenContentDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fullScreenContentDelegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<IFullScreenContentDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fullScreenContentDelegate")), false)!;
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setFullScreenContentDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFullScreenContentDelegate:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFullScreenContentDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		_FullScreenContentDelegate EnsureFullScreenContentDelegate ()
		{
			var del = Delegate;
			if (del is null || (!(del is _FullScreenContentDelegate))){
				del = new _FullScreenContentDelegate ();
				Delegate = del;
			}
			return (_FullScreenContentDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _FullScreenContentDelegate : Google.MobileAds.FullScreenContentDelegate { 
			public _FullScreenContentDelegate () { IsDirectBinding = false; }
			internal EventHandler? didDismissFullScreenContent;
			[Preserve (Conditional = true)]
			public override void DidDismissFullScreenContent (Google.MobileAds.FullScreenPresentingAd ad)
			{
				var handler = didDismissFullScreenContent;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			internal EventHandler<FullScreenPresentingAdWithErrorEventArgs>? didFailToPresentFullScreenContent;
			[Preserve (Conditional = true)]
			public override void DidFailToPresentFullScreenContent (Google.MobileAds.FullScreenPresentingAd ad, NSError error)
			{
				var handler = didFailToPresentFullScreenContent;
				if (handler != null){
					var args = new FullScreenPresentingAdWithErrorEventArgs (error);
					handler (ad, args);
				}
			}
			internal EventHandler? didPresentFullScreenContent;
			[Preserve (Conditional = true)]
			public override void DidPresentFullScreenContent (Google.MobileAds.FullScreenPresentingAd ad)
			{
				var handler = didPresentFullScreenContent;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			internal EventHandler? didRecordClick;
			[Preserve (Conditional = true)]
			public override void DidRecordClick (Google.MobileAds.FullScreenPresentingAd ad)
			{
				var handler = didRecordClick;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			internal EventHandler? didRecordImpression;
			[Preserve (Conditional = true)]
			public override void DidRecordImpression (Google.MobileAds.FullScreenPresentingAd ad)
			{
				var handler = didRecordImpression;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			internal EventHandler? willDismissFullScreenContent;
			[Preserve (Conditional = true)]
			public override void WillDismissFullScreenContent (Google.MobileAds.FullScreenPresentingAd ad)
			{
				var handler = willDismissFullScreenContent;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		public event EventHandler DismissedContent {
			add { EnsureFullScreenContentDelegate ()!.didDismissFullScreenContent += value; }
			remove { EnsureFullScreenContentDelegate ()!.didDismissFullScreenContent -= value; }
		}
		public event EventHandler<FullScreenPresentingAdWithErrorEventArgs> FailedToPresentContent {
			add { EnsureFullScreenContentDelegate ()!.didFailToPresentFullScreenContent += value; }
			remove { EnsureFullScreenContentDelegate ()!.didFailToPresentFullScreenContent -= value; }
		}
		public event EventHandler PresentedContent {
			add { EnsureFullScreenContentDelegate ()!.didPresentFullScreenContent += value; }
			remove { EnsureFullScreenContentDelegate ()!.didPresentFullScreenContent -= value; }
		}
		public event EventHandler RecordedClick {
			add { EnsureFullScreenContentDelegate ()!.didRecordClick += value; }
			remove { EnsureFullScreenContentDelegate ()!.didRecordClick -= value; }
		}
		public event EventHandler RecordedImpression {
			add { EnsureFullScreenContentDelegate ()!.didRecordImpression += value; }
			remove { EnsureFullScreenContentDelegate ()!.didRecordImpression -= value; }
		}
		public event EventHandler DismissingContent {
			add { EnsureFullScreenContentDelegate ()!.willDismissFullScreenContent += value; }
			remove { EnsureFullScreenContentDelegate ()!.willDismissFullScreenContent -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class FullScreenPresentingAd */
	//
	// EventArgs classes
	//
	public partial class FullScreenPresentingAdWithErrorEventArgs : EventArgs {
		public FullScreenPresentingAdWithErrorEventArgs (NSError error)
		{
			this.Error = error;
		}
		public NSError Error { get; set; }
	}
}
