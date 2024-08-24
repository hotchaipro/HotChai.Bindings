//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using Google.UserMessagingPlatform.ObjCRuntime;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Google.UserMessagingPlatform
{
	[Register("UMPConsentForm", true)]
	public unsafe partial class UMPConsentForm : NSObject
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UMPConsentForm");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UMPConsentForm (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UMPConsentForm (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("loadAndPresentIfRequiredFromViewController:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadAndPresentIfRequiredFromViewController (global::UIKit.UIViewController viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUMPConsentFormPresentCompletionHandler))]UMPConsentFormPresentCompletionHandler? completionHandler)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			using var block_completionHandler = Trampolines.SDUMPConsentFormPresentCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadAndPresentIfRequiredFromViewController:completionHandler:"), viewController__handle__, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("loadWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadWithCompletionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUMPConsentFormLoadCompletionHandler))]UMPConsentFormLoadCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDUMPConsentFormLoadCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("loadWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("presentFromViewController:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentFromViewController (global::UIKit.UIViewController viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUMPConsentFormPresentCompletionHandler))]UMPConsentFormPresentCompletionHandler? completionHandler)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			using var block_completionHandler = Trampolines.SDUMPConsentFormPresentCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("presentFromViewController:completionHandler:"), viewController__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("presentFromViewController:completionHandler:"), viewController__handle__, (IntPtr) block_ptr_completionHandler);
			}
		}
		[Export ("presentPrivacyOptionsFormFromViewController:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PresentPrivacyOptionsFormFromViewController (global::UIKit.UIViewController viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUMPConsentFormPresentCompletionHandler))]UMPConsentFormPresentCompletionHandler? completionHandler)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			using var block_completionHandler = Trampolines.SDUMPConsentFormPresentCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("presentPrivacyOptionsFormFromViewController:completionHandler:"), viewController__handle__, (IntPtr) block_ptr_completionHandler);
		}
	} /* class UMPConsentForm */
}
