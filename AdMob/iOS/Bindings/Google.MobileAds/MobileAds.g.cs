//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
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
    [Register("GADMobileAds", true)]
	public unsafe partial class MobileAds : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADMobileAds");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileAds (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileAds (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("disableMediationInitialization")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableMediationInitialization ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disableMediationInitialization"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableMediationInitialization"));
			}
		}
		[Export ("disableSDKCrashReporting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableSdkCrashReporting ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disableSDKCrashReporting"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableSDKCrashReporting"));
			}
		}
		[Export ("isSDKVersionAtLeastMajor:minor:patch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSdkVersionAtLeast (nint major, nint minor, nint patch)
		{
			if (IsDirectBinding) {
				return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("isSDKVersionAtLeastMajor:minor:patch:"), (NativeHandle) major, (NativeHandle) minor, (NativeHandle) patch);
			} else {
				return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("isSDKVersionAtLeastMajor:minor:patch:"), (NativeHandle) major, (NativeHandle) minor, (NativeHandle) patch);
			}
		}
		[Export ("presentAdInspectorFromViewController:viewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentAdInspectorFromViewController (global::UIKit.UIViewController viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAdInspectorCompletionHandler))]AdInspectorCompletionHandler completionHandler)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (completionHandler is null)
				ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAdInspectorCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentAdInspectorFromViewController:completionHandler:"), viewController__handle__, (NativeHandle) block_ptr_completionHandler);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentAdInspectorFromViewController:completionHandler:"), viewController__handle__, (NativeHandle) block_ptr_completionHandler);
			}
		}
		[Export ("startWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Start ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDInitializationCompletionHandler))]InitializationCompletionHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDInitializationCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startWithCompletionHandler:"), (NativeHandle) block_ptr_completionHandler);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startWithCompletionHandler:"), (NativeHandle) block_ptr_completionHandler);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<InitializationStatus> StartAsync ()
		{
			var tcs = new TaskCompletionSource<InitializationStatus> ();
			Start((status_) => {
				tcs.SetResult (status_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ApplicationMuted {
			[Export ("applicationMuted")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("applicationMuted"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationMuted"));
				}
			}
			[Export ("setApplicationMuted:")]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setApplicationMuted:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setApplicationMuted:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ApplicationVolume {
			[Export ("applicationVolume")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("applicationVolume"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationVolume"));
				}
			}
			[Export ("setApplicationVolume:")]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setApplicationVolume:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setApplicationVolume:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AudioVideoManager AudioVideoManager {
			[Export ("audioVideoManager", ArgumentSemantic.Retain)]
			get {
				AudioVideoManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AudioVideoManager> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("audioVideoManager")))!;
				} else {
					ret =  Runtime.GetNSObject<AudioVideoManager> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("audioVideoManager")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual InitializationStatus InitializationStatus {
			[Export ("initializationStatus")]
			get {
				InitializationStatus? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<InitializationStatus> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("initializationStatus")))!;
				} else {
					ret =  Runtime.GetNSObject<InitializationStatus> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("initializationStatus")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual RequestConfiguration RequestConfiguration {
			[Export ("requestConfiguration", ArgumentSemantic.Retain)]
			get {
				RequestConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RequestConfiguration> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("requestConfiguration")))!;
				} else {
					ret =  Runtime.GetNSObject<RequestConfiguration> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestConfiguration")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SdkVersion {
			[Export ("sdkVersion")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sdkVersion")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sdkVersion")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileAds SharedInstance {
			[Export ("sharedInstance")]
			get {
				MobileAds? ret;
				ret =  Runtime.GetNSObject<MobileAds> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")))!;
				return ret!;
			}
		}
	} /* class MobileAds */
}
