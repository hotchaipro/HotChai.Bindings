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
    [Protocol (Name = "GADBannerViewDelegate", WrapperType = typeof (BannerViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveAd", Selector = "bannerViewDidReceiveAd:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToReceiveAd", Selector = "bannerView:didFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordImpression", Selector = "bannerViewDidRecordImpression:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordClick", Selector = "bannerViewDidRecordClick:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentScreen", Selector = "bannerViewWillPresentScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissScreen", Selector = "bannerViewWillDismissScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissScreen", Selector = "bannerViewDidDismissScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	public partial interface IBannerViewDelegate : INativeObject, IDisposable
	{
	}
	public static partial class BannerViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveAd (this IBannerViewDelegate This, BannerView view)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("bannerViewDidReceiveAd:"), view__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToReceiveAd (this IBannerViewDelegate This, BannerView view, NSError error)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bannerView:didFailToReceiveAdWithError:"), view__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordImpression (this IBannerViewDelegate This, BannerView view)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("bannerViewDidRecordImpression:"), view__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordClick (this IBannerViewDelegate This, BannerView view)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("bannerViewDidRecordClick:"), view__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentScreen (this IBannerViewDelegate This, BannerView adView)
		{
			var adView__handle__ = adView!.GetNonNullHandle (nameof (adView));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("bannerViewWillPresentScreen:"), adView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissScreen (this IBannerViewDelegate This, BannerView adView)
		{
			var adView__handle__ = adView!.GetNonNullHandle (nameof (adView));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("bannerViewWillDismissScreen:"), adView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissScreen (this IBannerViewDelegate This, BannerView adView)
		{
			var adView__handle__ = adView!.GetNonNullHandle (nameof (adView));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("bannerViewDidDismissScreen:"), adView__handle__);
		}
	}
	internal sealed class BannerViewDelegateWrapper : BaseWrapper, IBannerViewDelegate {
		[Preserve (Conditional = true)]
		public BannerViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_BannerViewDelegate", false)]
	[Model]
	public unsafe partial class BannerViewDelegate : NSObject, IBannerViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BannerViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BannerViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BannerViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("bannerViewDidDismissScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissScreen (BannerView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerView:didFailToReceiveAdWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToReceiveAd (BannerView view, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerViewDidReceiveAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveAd (BannerView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerViewDidRecordClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordClick (BannerView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerViewDidRecordImpression:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordImpression (BannerView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerViewWillDismissScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissScreen (BannerView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerViewWillPresentScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentScreen (BannerView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class BannerViewDelegate */
}
