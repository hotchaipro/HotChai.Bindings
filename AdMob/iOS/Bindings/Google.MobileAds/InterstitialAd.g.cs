//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using System.Threading.Tasks;
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
    [Register("GADInterstitialAd", true)]
	public unsafe partial class InterstitialAd : FullScreenPresentingAd {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADInterstitialAd");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected InterstitialAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal InterstitialAd (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("canPresentFromRootViewController:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPresent (global::UIKit.UIViewController rootViewController, out NSError? error)
		{
			var rootViewController__handle__ = rootViewController!.GetNonNullHandle (nameof (rootViewController));
            IntPtr errorValue = IntPtr.Zero;
			bool ret;
			if (IsDirectBinding) {
				ret = global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr (this.Handle, Selector.GetHandle ("canPresentFromRootViewController:error:"), rootViewController__handle__, ref errorValue);
			} else {
				ret = global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr (this.SuperHandle, Selector.GetHandle ("canPresentFromRootViewController:error:"), rootViewController__handle__, ref errorValue);
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("loadWithAdUnitID:request:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Load (string adUnitId, Request? request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDInterstitialAdLoadCompletionHandler))]InterstitialAdLoadCompletionHandler completionHandler)
		{
			if (adUnitId is null)
				ThrowHelper.ThrowArgumentNullException (nameof (adUnitId));
			var request__handle__ = request.GetHandle ();
			if (completionHandler is null)
				ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsadUnitId = CFString.CreateNative (adUnitId);
			using var block_completionHandler = Trampolines.SDInterstitialAdLoadCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("loadWithAdUnitID:request:completionHandler:"), nsadUnitId, request__handle__, (NativeHandle) block_ptr_completionHandler);
			CFString.ReleaseNative (nsadUnitId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<InterstitialAd> LoadAsync (string adUnitId, Request? request)
		{
			var tcs = new TaskCompletionSource<InterstitialAd> ();
			Load(adUnitId, request, (interstitialAd_, error_) => {
				if (error_ != null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (interstitialAd_!);
			});
			return tcs.Task;
		}
		[Export ("presentFromRootViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Present (global::UIKit.UIViewController? rootViewController)
		{
			var rootViewController__handle__ = rootViewController.GetHandle ();
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("presentFromRootViewController:"), rootViewController__handle__);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("presentFromRootViewController:"), rootViewController__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AdUnitId {
			[Export ("adUnitID")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adUnitID")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adUnitID")))!;
				}
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
	} /* class InterstitialAd */
}
