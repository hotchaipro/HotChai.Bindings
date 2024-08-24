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
    [Register("GADCustomEventExtras", true)]
	public unsafe partial class CustomEventExtras : NSObject, IAdNetworkExtras {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADCustomEventExtras");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CustomEventExtras () : base (NSObjectFlag.Empty)
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
		protected CustomEventExtras (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CustomEventExtras (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("extrasForLabel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? ExtrasForLabel (string label)
		{
			if (label is null)
				ThrowHelper.ThrowArgumentNullException (nameof (label));
			var nslabel = CFString.CreateNative (label);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("extrasForLabel:"), nslabel))!;
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("extrasForLabel:"), nslabel))!;
			}
			CFString.ReleaseNative (nslabel);
			return ret!;
		}
		[Export ("removeAllExtras")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllExtras ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllExtras"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllExtras"));
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("setExtras:forLabel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetExtras (NSDictionary? extras, string label)
		{
			var extras__handle__ = extras.GetHandle ();
			if (label is null)
				ThrowHelper.ThrowArgumentNullException (nameof (label));
			var nslabel = CFString.CreateNative (label);
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setExtras:forLabel:"), extras__handle__, nslabel);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setExtras:forLabel:"), extras__handle__, nslabel);
			}
			CFString.ReleaseNative (nslabel);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary AllExtras {
			[Export ("allExtras")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allExtras")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allExtras")))!;
				}
				return ret!;
			}
		}
	} /* class CustomEventExtras */
}
