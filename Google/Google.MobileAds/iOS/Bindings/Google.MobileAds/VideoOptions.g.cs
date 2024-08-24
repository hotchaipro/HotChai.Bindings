//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADVideoOptions", true)]
	public unsafe partial class VideoOptions : AdLoaderOptions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADVideoOptions");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public VideoOptions () : base (NSObjectFlag.Empty)
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
		protected VideoOptions (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal VideoOptions (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClickToExpandRequested {
			[Export ("clickToExpandRequested")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clickToExpandRequested"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clickToExpandRequested"));
				}
			}
			[Export ("setClickToExpandRequested:")]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClickToExpandRequested:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setClickToExpandRequested:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CustomControlsRequested {
			[Export ("customControlsRequested")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("customControlsRequested"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customControlsRequested"));
				}
			}
			[Export ("setCustomControlsRequested:")]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCustomControlsRequested:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCustomControlsRequested:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StartMuted {
			[Export ("startMuted")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("startMuted"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startMuted"));
				}
			}
			[Export ("setStartMuted:")]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setStartMuted:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setStartMuted:"), value);
				}
			}
		}
	} /* class VideoOptions */
}
