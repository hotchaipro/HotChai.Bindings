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
    [Protocol (Name = "GADSwipeableBannerViewDelegate", WrapperType = typeof (SwipeableBannerViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidActivateAd", Selector = "adViewDidActivateAd:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeactivateAd", Selector = "adViewDidDeactivateAd:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView) }, ParameterByRef = new bool [] { false })]
	public partial interface ISwipeableBannerViewDelegate : INativeObject, IDisposable
	{
	}
	public static partial class SwipeableBannerViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidActivateAd (this ISwipeableBannerViewDelegate This, BannerView banner)
		{
			var banner__handle__ = banner!.GetNonNullHandle (nameof (banner));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewDidActivateAd:"), banner__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDeactivateAd (this ISwipeableBannerViewDelegate This, BannerView banner)
		{
			var banner__handle__ = banner!.GetNonNullHandle (nameof (banner));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewDidDeactivateAd:"), banner__handle__);
		}
	}
	internal sealed class SwipeableBannerViewDelegateWrapper : BaseWrapper, ISwipeableBannerViewDelegate {
		[Preserve (Conditional = true)]
		public SwipeableBannerViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_SwipeableBannerViewDelegate", false)]
	[Model]
	public unsafe partial class SwipeableBannerViewDelegate : NSObject, ISwipeableBannerViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SwipeableBannerViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SwipeableBannerViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SwipeableBannerViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adViewDidActivateAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidActivateAd (BannerView banner)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adViewDidDeactivateAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDeactivateAd (BannerView banner)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SwipeableBannerViewDelegate */
}
