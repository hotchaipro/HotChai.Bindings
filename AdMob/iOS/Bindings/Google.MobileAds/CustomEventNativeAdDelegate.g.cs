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
    [Protocol (Name = "GADCustomEventNativeAdDelegate", WrapperType = typeof (CustomEventNativeAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailToLoad", Selector = "customEventNativeAd:didFailToLoadWithError:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventNativeAd), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveMediatedUnifiedNativeAd", Selector = "customEventNativeAd:didReceiveMediatedUnifiedNativeAd:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventNativeAd), typeof (Google.MobileAds.Mediation.IMediatedUnifiedNativeAd) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICustomEventNativeAdDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventNativeAd:didFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void DidFailToLoad (ICustomEventNativeAd customEventNativeAd, NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("customEventNativeAd:didReceiveMediatedUnifiedNativeAd:")]
		[Preserve (Conditional = true)]
		void DidReceiveMediatedUnifiedNativeAd (ICustomEventNativeAd customEventNativeAd, global::Google.MobileAds.Mediation.IMediatedUnifiedNativeAd mediatedUnifiedNativeAd);
	}
	internal sealed class CustomEventNativeAdDelegateWrapper : BaseWrapper, ICustomEventNativeAdDelegate {
		[Preserve (Conditional = true)]
		public CustomEventNativeAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("customEventNativeAd:didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToLoad (ICustomEventNativeAd customEventNativeAd, NSError error)
		{
			var customEventNativeAd__handle__ = customEventNativeAd!.GetNonNullHandle (nameof (customEventNativeAd));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("customEventNativeAd:didFailToLoadWithError:"), customEventNativeAd__handle__, error__handle__);
		}
		[Export ("customEventNativeAd:didReceiveMediatedUnifiedNativeAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveMediatedUnifiedNativeAd (ICustomEventNativeAd customEventNativeAd, global::Google.MobileAds.Mediation.IMediatedUnifiedNativeAd mediatedUnifiedNativeAd)
		{
			var customEventNativeAd__handle__ = customEventNativeAd!.GetNonNullHandle (nameof (customEventNativeAd));
			var mediatedUnifiedNativeAd__handle__ = mediatedUnifiedNativeAd!.GetNonNullHandle (nameof (mediatedUnifiedNativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("customEventNativeAd:didReceiveMediatedUnifiedNativeAd:"), customEventNativeAd__handle__, mediatedUnifiedNativeAd__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_CustomEventNativeAdDelegate", false)]
	[Model]
	public unsafe abstract partial class CustomEventNativeAdDelegate : NSObject, ICustomEventNativeAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CustomEventNativeAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CustomEventNativeAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CustomEventNativeAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("customEventNativeAd:didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidFailToLoad (ICustomEventNativeAd customEventNativeAd, NSError error);
		[Export ("customEventNativeAd:didReceiveMediatedUnifiedNativeAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidReceiveMediatedUnifiedNativeAd (ICustomEventNativeAd customEventNativeAd, global::Google.MobileAds.Mediation.IMediatedUnifiedNativeAd mediatedUnifiedNativeAd);
	} /* class CustomEventNativeAdDelegate */
}
