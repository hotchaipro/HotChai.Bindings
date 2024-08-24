//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using CoreFoundation;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Google.UserMessagingPlatform
{
	[Register("UMPDebugSettings", true)]
	public unsafe partial class UMPDebugSettings : NSObject, INSCopying
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UMPDebugSettings");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UMPDebugSettings () : base (NSObjectFlag.Empty)
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
		protected UMPDebugSettings (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UMPDebugSettings (NativeHandle handle) : base (handle)
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
		public virtual UMPDebugGeography Geography {
			[Export ("geography", ArgumentSemantic.Assign)]
			get {
				UMPDebugGeography ret;
				if (IsDirectBinding) {
					ret = (Google.UserMessagingPlatform.UMPDebugGeography) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("geography"));
				} else {
					ret = (Google.UserMessagingPlatform.UMPDebugGeography) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("geography"));
				}
				return ret!;
			}
			[Export ("setGeography:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGeography:"), (IntPtr) (long) value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGeography:"), (IntPtr) (long) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? TestDeviceIdentifiers {
			[Export ("testDeviceIdentifiers", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return CFArray.StringArrayFromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("testDeviceIdentifiers")))!;
				} else {
					return CFArray.StringArrayFromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("testDeviceIdentifiers")))!;
				}
			}
			[Export ("setTestDeviceIdentifiers:", ArgumentSemantic.Assign)]
			set {
				var nsa_value = value is null ? null : NSArray.FromStrings (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTestDeviceIdentifiers:"), nsa_value.GetHandle ());
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setTestDeviceIdentifiers:"), nsa_value.GetHandle ());
				}
				if (nsa_value is not null)
					nsa_value.Dispose ();
			}
		}
	} /* class UMPDebugSettings */
}
