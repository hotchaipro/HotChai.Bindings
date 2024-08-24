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
	[Register("UMPConsentInformation", true)]
	public unsafe partial class UMPConsentInformation : NSObject
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UMPConsentInformation");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UMPConsentInformation () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UMPConsentInformation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UMPConsentInformation (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("requestConsentInfoUpdateWithParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestConsentInfoUpdateWithParameters (UMPRequestParameters? parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUMPConsentInformationUpdateCompletionHandler))]UMPConsentInformationUpdateCompletionHandler handler)
		{
			var parameters__handle__ = parameters.GetHandle ();
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDUMPConsentInformationUpdateCompletionHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestConsentInfoUpdateWithParameters:completionHandler:"), parameters__handle__, (IntPtr) block_ptr_handler);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("requestConsentInfoUpdateWithParameters:completionHandler:"), parameters__handle__, (IntPtr) block_ptr_handler);
			}
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reset"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanRequestAds {
			[Export ("canRequestAds")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canRequestAds"));
				} else {
					ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canRequestAds"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UMPConsentStatus ConsentStatus {
			[Export ("consentStatus")]
			get {
				UMPConsentStatus ret;
				if (IsDirectBinding) {
					ret = (Google.UserMessagingPlatform.UMPConsentStatus) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("consentStatus"));
				} else {
					ret = (Google.UserMessagingPlatform.UMPConsentStatus) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("consentStatus"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UMPFormStatus FormStatus {
			[Export ("formStatus")]
			get {
				UMPFormStatus ret;
				if (IsDirectBinding) {
					ret = (Google.UserMessagingPlatform.UMPFormStatus) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formStatus"));
				} else {
					ret = (Google.UserMessagingPlatform.UMPFormStatus) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formStatus"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UMPPrivacyOptionsRequirementStatus PrivacyOptionsRequirementStatus {
			[Export ("privacyOptionsRequirementStatus")]
			get {
				UMPPrivacyOptionsRequirementStatus ret;
				if (IsDirectBinding) {
					ret = (Google.UserMessagingPlatform.UMPPrivacyOptionsRequirementStatus) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("privacyOptionsRequirementStatus"));
				} else {
					ret = (Google.UserMessagingPlatform.UMPPrivacyOptionsRequirementStatus) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("privacyOptionsRequirementStatus"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UMPConsentInformation SharedInstance {
			[Export ("sharedInstance")]
			get {
				UMPConsentInformation? ret;
				ret =  Runtime.GetNSObject<UMPConsentInformation> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")))!;
				return ret!;
			}
		}
	} /* class UMPConsentInformation */
}
