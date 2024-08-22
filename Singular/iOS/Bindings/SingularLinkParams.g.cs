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
namespace SingularSDK
{
	[Register("SingularLinkParams", true)]
	public unsafe partial class SingularLinkParams : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SingularLinkParams");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SingularLinkParams () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SingularLinkParams (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SingularLinkParams (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithDeeplink:passthrough:isDeferred:url:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SingularLinkParams (string deeplink, string passthrough, bool isDeferred, NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (deeplink is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (deeplink));
			if (passthrough is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (passthrough));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nsdeeplink = CFString.CreateNative (deeplink);
			var nspassthrough = CFString.CreateNative (passthrough);
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("initWithDeeplink:passthrough:isDeferred:url:"), nsdeeplink, nspassthrough, isDeferred ? (byte) 1 : (byte) 0, url__handle__), "initWithDeeplink:passthrough:isDeferred:url:");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithDeeplink:passthrough:isDeferred:url:"), nsdeeplink, nspassthrough, isDeferred ? (byte) 1 : (byte) 0, url__handle__), "initWithDeeplink:passthrough:isDeferred:url:");
			}
			CFString.ReleaseNative (nsdeeplink);
			CFString.ReleaseNative (nspassthrough);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DeepLink {
			[Export ("getDeepLink")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getDeepLink")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeepLink")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDeferred {
			[Export ("isDeferred")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDeferred"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDeferred"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Passthrough {
			[Export ("getPassthrough")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getPassthrough")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPassthrough")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary UrlParameters {
			[Export ("getUrlParameters")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getUrlParameters")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getUrlParameters")))!;
				}
				return ret!;
			}
		}
	} /* class SingularLinkParams */
}
