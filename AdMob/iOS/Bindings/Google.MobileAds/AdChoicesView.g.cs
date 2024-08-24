//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using UIKit;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADAdChoicesView", true)]
	public unsafe partial class AdChoicesView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADAdChoicesView");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AdChoicesView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public AdChoicesView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AdChoicesView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdChoicesView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		public partial class AdChoicesViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal AdChoicesViewAppearance (NativeHandle handle) : base (handle) {}
		}
		public static new AdChoicesViewAppearance Appearance {
			get { return new AdChoicesViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, global::ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new AdChoicesViewAppearance GetAppearance<T> () where T: AdChoicesView {
			return new AdChoicesViewAppearance (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), global::ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new AdChoicesViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new AdChoicesViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new AdChoicesViewAppearance GetAppearance (UITraitCollection traits) {
			return new AdChoicesViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new AdChoicesViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new AdChoicesViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new AdChoicesViewAppearance GetAppearance<T> (UITraitCollection traits) where T: AdChoicesView {
			return new AdChoicesViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new AdChoicesViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: AdChoicesView{
			return new AdChoicesViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class AdChoicesView */
}
