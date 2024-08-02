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
    [Register("GADRewardedInterstitialAd", true)]
	public unsafe partial class RewardedInterstitialAd : FullScreenContentDelegate, IAdMetadataProvider {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADRewardedInterstitialAd");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RewardedInterstitialAd () : base (NSObjectFlag.Empty)
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
		protected RewardedInterstitialAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RewardedInterstitialAd (NativeHandle handle) : base (handle)
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
		public unsafe static void Load (string adUnitId, Request? request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDRewardedInterstitialAdLoadCompletionHandler))]RewardedInterstitialAdLoadCompletionHandler completionHandler)
		{
			if (adUnitId is null)
				ThrowHelper.ThrowArgumentNullException (nameof (adUnitId));
			var request__handle__ = request.GetHandle ();
			if (completionHandler is null)
				ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsadUnitId = CFString.CreateNative (adUnitId);
			using var block_completionHandler = Trampolines.SDRewardedInterstitialAdLoadCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("loadWithAdUnitID:request:completionHandler:"), nsadUnitId, request__handle__, (NativeHandle) block_ptr_completionHandler);
			CFString.ReleaseNative (nsadUnitId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<RewardedInterstitialAd> LoadAsync (string adUnitId, Request? request)
		{
			var tcs = new TaskCompletionSource<RewardedInterstitialAd> ();
			Load(adUnitId, request, (rewardedInterstitialAd_, error_) => {
				if (error_ != null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (rewardedInterstitialAd_!);
			});
			return tcs.Task;
		}
		[Export ("presentFromRootViewController:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Present (global::UIKit.UIViewController viewController, IRewardedAdDelegate @delegate)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentFromRootViewController:delegate:"), viewController__handle__, @delegate__handle__);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentFromRootViewController:delegate:"), viewController__handle__, @delegate__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> AdMetadata {
			[Export ("adMetadata")]
			get {
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adMetadata")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adMetadata")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AdMetadataDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAdMetadataDelegate? AdMetadataDelegate {
			[Export ("adMetadataDelegate", ArgumentSemantic.Weak)]
			get {
				IAdMetadataDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAdMetadataDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adMetadataDelegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<IAdMetadataDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adMetadataDelegate")), false)!;
				}
				MarkDirty ();
				__mt_AdMetadataDelegate_var = ret;
				return ret!;
			}
			[Export ("setAdMetadataDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdMetadataDelegate:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdMetadataDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_AdMetadataDelegate_var = value;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AdReward? Reward {
			[Export ("reward")]
			get {
				AdReward? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AdReward> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("reward")))!;
				} else {
					ret =  Runtime.GetNSObject<AdReward> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reward")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ServerSideVerificationOptions? ServerSideVerificationOptions {
			[Export ("serverSideVerificationOptions")]
			get {
				ServerSideVerificationOptions? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ServerSideVerificationOptions> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serverSideVerificationOptions")))!;
				} else {
					ret =  Runtime.GetNSObject<ServerSideVerificationOptions> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serverSideVerificationOptions")))!;
				}
				return ret!;
			}
			[Export ("setServerSideVerificationOptions:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setServerSideVerificationOptions:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setServerSideVerificationOptions:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_AdMetadataDelegate_var = null;
			}
		}
	} /* class RewardedInterstitialAd */
}
