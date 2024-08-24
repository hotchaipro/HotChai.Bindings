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
    [Protocol (Name = "GADCustomEventBannerDelegate", WrapperType = typeof (CustomEventBannerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveAd", Selector = "customEventBanner:didReceiveAd:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBanner), typeof (UIView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailAd", Selector = "customEventBanner:didFailAd:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBanner), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidClickInAd", Selector = "customEventBannerWasClicked:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBanner) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ViewControllerForPresentingModalView", Selector = "viewControllerForPresentingModalView", ReturnType = typeof (UIViewController))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillPresentModal", Selector = "customEventBannerWillPresentModal:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBanner) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillDismissModal", Selector = "customEventBannerWillDismissModal:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBanner) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDismissModal", Selector = "customEventBannerDidDismissModal:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBanner) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillLeaveApplication", Selector = "customEventBannerWillLeaveApplication:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBanner) }, ParameterByRef = new bool [] { false })]
	public partial interface ICustomEventBannerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventBanner:didReceiveAd:")]
		[Preserve (Conditional = true)]
		void DidReceiveAd (ICustomEventBanner customEvent, global::UIKit.UIView view);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventBanner:didFailAd:")]
		[Preserve (Conditional = true)]
		void DidFailAd (ICustomEventBanner customEvent, NSError? error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventBannerWasClicked:")]
		[Preserve (Conditional = true)]
		void DidClickInAd (ICustomEventBanner customEvent);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("viewControllerForPresentingModalView")]
		[Preserve (Conditional = true)]
		global::UIKit.UIViewController ViewControllerForPresentingModalView ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventBannerWillPresentModal:")]
		[Preserve (Conditional = true)]
		void WillPresentModal (ICustomEventBanner customEvent);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventBannerWillDismissModal:")]
		[Preserve (Conditional = true)]
		void WillDismissModal (ICustomEventBanner customEvent);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventBannerDidDismissModal:")]
		[Preserve (Conditional = true)]
		void DidDismissModal (ICustomEventBanner customEvent);
		[Obsolete ("Deprecated. No replacement.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventBannerWillLeaveApplication:")]
		[Preserve (Conditional = true)]
		void WillLeaveApplication (ICustomEventBanner customEvent);
	}
	internal sealed class CustomEventBannerDelegateWrapper : BaseWrapper, ICustomEventBannerDelegate {
		[Preserve (Conditional = true)]
		public CustomEventBannerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("customEventBanner:didReceiveAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveAd (ICustomEventBanner customEvent, global::UIKit.UIView view)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("customEventBanner:didReceiveAd:"), customEvent__handle__, view__handle__);
		}
		[Export ("customEventBanner:didFailAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailAd (ICustomEventBanner customEvent, NSError? error)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			var error__handle__ = error.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("customEventBanner:didFailAd:"), customEvent__handle__, error__handle__);
		}
		[Export ("customEventBannerWasClicked:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidClickInAd (ICustomEventBanner customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("customEventBannerWasClicked:"), customEvent__handle__);
		}
		[Export ("viewControllerForPresentingModalView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIViewController ViewControllerForPresentingModalView ()
		{
			return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("viewControllerForPresentingModalView")))!;
		}
		[Export ("customEventBannerWillPresentModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillPresentModal (ICustomEventBanner customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("customEventBannerWillPresentModal:"), customEvent__handle__);
		}
		[Export ("customEventBannerWillDismissModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillDismissModal (ICustomEventBanner customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("customEventBannerWillDismissModal:"), customEvent__handle__);
		}
		[Export ("customEventBannerDidDismissModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDismissModal (ICustomEventBanner customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("customEventBannerDidDismissModal:"), customEvent__handle__);
		}
		[Export ("customEventBannerWillLeaveApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillLeaveApplication (ICustomEventBanner customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("customEventBannerWillLeaveApplication:"), customEvent__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_CustomEventBannerDelegate", false)]
	[Model]
	public unsafe abstract partial class CustomEventBannerDelegate : NSObject, ICustomEventBannerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CustomEventBannerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CustomEventBannerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CustomEventBannerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("customEventBannerWasClicked:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidClickInAd (ICustomEventBanner customEvent);
		[Export ("customEventBannerDidDismissModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidDismissModal (ICustomEventBanner customEvent);
		[Export ("customEventBanner:didFailAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidFailAd (ICustomEventBanner customEvent, NSError? error);
		[Export ("customEventBanner:didReceiveAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidReceiveAd (ICustomEventBanner customEvent, global::UIKit.UIView view);
		[Export ("viewControllerForPresentingModalView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::UIKit.UIViewController ViewControllerForPresentingModalView ();
		[Export ("customEventBannerWillDismissModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void WillDismissModal (ICustomEventBanner customEvent);
		[Export ("customEventBannerWillLeaveApplication:")]
		[Obsolete ("Deprecated. No replacement.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void WillLeaveApplication (ICustomEventBanner customEvent);
		[Export ("customEventBannerWillPresentModal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void WillPresentModal (ICustomEventBanner customEvent);
	} /* class CustomEventBannerDelegate */
}
