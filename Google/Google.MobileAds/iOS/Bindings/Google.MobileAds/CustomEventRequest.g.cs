//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADCustomEventRequest", true)]
	public unsafe partial class CustomEventRequest : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADCustomEventRequest");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CustomEventRequest () : base (NSObjectFlag.Empty)
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
		protected CustomEventRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CustomEventRequest (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? AdditionalParameters {
			[Export ("additionalParameters", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("additionalParameters")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("additionalParameters")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsTesting {
			[Export ("isTesting")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTesting"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isTesting"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserHasLocation {
			[Export ("userHasLocation")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("userHasLocation"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userHasLocation"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? UserKeywords {
			[Export ("userKeywords", ArgumentSemantic.Copy)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userKeywords")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NSObject>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userKeywords")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat UserLatitude {
			[Export ("userLatitude", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("userLatitude"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLatitude"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat UserLocationAccuracyInMeters {
			[Export ("userLocationAccuracyInMeters", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("userLocationAccuracyInMeters"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLocationAccuracyInMeters"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? UserLocationDescription {
			[Export ("userLocationDescription", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userLocationDescription")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLocationDescription")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat UserLongitude {
			[Export ("userLongitude", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("userLongitude"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userLongitude"));
				}
			}
		}
	} /* class CustomEventRequest */
}
