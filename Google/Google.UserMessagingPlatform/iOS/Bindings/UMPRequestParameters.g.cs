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
using NativeHandle = System.IntPtr;
#endif
namespace Google.UserMessagingPlatform
{
	[Register("UMPRequestParameters", true)]
	public unsafe partial class UMPRequestParameters : NSObject, INSCopying
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UMPRequestParameters");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UMPRequestParameters () : base (NSObjectFlag.Empty)
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
		protected UMPRequestParameters (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UMPRequestParameters (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("copyWithZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone!.GetNonNullHandle (nameof (zone));
			if (IsDirectBinding) {
				return Runtime.GetNSObject (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone!.Handle))!;
			} else {
				return Runtime.GetNSObject (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone!.Handle))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UMPDebugSettings? DebugSettings {
			[Export ("debugSettings", ArgumentSemantic.Copy)]
			get {
				UMPDebugSettings? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UMPDebugSettings> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("debugSettings")))!;
				} else {
					ret =  Runtime.GetNSObject<UMPDebugSettings> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("debugSettings")))!;
				}
				return ret!;
			}
			[Export ("setDebugSettings:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDebugSettings:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDebugSettings:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TagForUnderAgeOfConsent {
			[Export ("tagForUnderAgeOfConsent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("tagForUnderAgeOfConsent"));
				} else {
					ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tagForUnderAgeOfConsent"));
				}
				return ret != 0;
			}
			[Export ("setTagForUnderAgeOfConsent:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTagForUnderAgeOfConsent:"), value ? (byte) 1 : (byte) 0);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTagForUnderAgeOfConsent:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
	} /* class UMPRequestParameters */
}
