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
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Protocol (Name = "GADCustomEventInterstitialDelegate", WrapperType = typeof (CustomEventInterstitialDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveAd", Selector = "customEventInterstitialDidReceiveAd:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitial) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailAd", Selector = "customEventInterstitial:didFailAd:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitial), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClickAd", Selector = "customEventInterstitialWasClicked:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitial) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresent", Selector = "customEventInterstitialWillPresent:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitial) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismiss", Selector = "customEventInterstitialWillDismiss:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitial) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "customEventInterstitialDidDismiss:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitial) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillLeaveApplication", Selector = "customEventInterstitialWillLeaveApplication:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitial) }, ParameterByRef = new bool [] { false })]
	public partial interface ICustomEventInterstitialDelegate : INativeObject, IDisposable
	{
	}
	public static partial class CustomEventInterstitialDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveAd (this ICustomEventInterstitialDelegate This, ICustomEventInterstitial customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialDidReceiveAd:"), customEvent__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailAd (this ICustomEventInterstitialDelegate This, ICustomEventInterstitial customEvent, NSError? error)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			var error__handle__ = error.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitial:didFailAd:"), customEvent__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClickAd (this ICustomEventInterstitialDelegate This, ICustomEventInterstitial customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialWasClicked:"), customEvent__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresent (this ICustomEventInterstitialDelegate This, ICustomEventInterstitial customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialWillPresent:"), customEvent__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismiss (this ICustomEventInterstitialDelegate This, ICustomEventInterstitial customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialWillDismiss:"), customEvent__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this ICustomEventInterstitialDelegate This, ICustomEventInterstitial customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialDidDismiss:"), customEvent__handle__);
		}
		[Obsolete ("Deprecated. No replacement.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillLeaveApplication (this ICustomEventInterstitialDelegate This, ICustomEventInterstitial customEvent)
		{
			var customEvent__handle__ = customEvent!.GetNonNullHandle (nameof (customEvent));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialWillLeaveApplication:"), customEvent__handle__);
		}
	}
	internal sealed class CustomEventInterstitialDelegateWrapper : BaseWrapper, ICustomEventInterstitialDelegate {
		[Preserve (Conditional = true)]
		public CustomEventInterstitialDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_CustomEventInterstitialDelegate", false)]
	[Model]
	public unsafe partial class CustomEventInterstitialDelegate : NSObject, ICustomEventInterstitialDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CustomEventInterstitialDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CustomEventInterstitialDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CustomEventInterstitialDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("customEventInterstitialWasClicked:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickAd (ICustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customEventInterstitialDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (ICustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customEventInterstitial:didFailAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailAd (ICustomEventInterstitial customEvent, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customEventInterstitialDidReceiveAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveAd (ICustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customEventInterstitialWillDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (ICustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customEventInterstitialWillLeaveApplication:")]
		[Obsolete ("Deprecated. No replacement.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillLeaveApplication (ICustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customEventInterstitialWillPresent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (ICustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CustomEventInterstitialDelegate */
}
