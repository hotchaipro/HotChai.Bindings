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
    [Protocol (Name = "GADUnifiedNativeAdLoaderDelegate", WrapperType = typeof (UnifiedNativeAdLoaderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveUnifiedNativeAd", Selector = "adLoader:didReceiveUnifiedNativeAd:", ParameterType = new Type [] { typeof (Google.MobileAds.AdLoader), typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUnifiedNativeAdLoaderDelegate : INativeObject, IDisposable, 
		Google.MobileAds.IAdLoaderDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adLoader:didReceiveUnifiedNativeAd:")]
		[Preserve (Conditional = true)]
		void DidReceiveUnifiedNativeAd (AdLoader adLoader, NativeAd nativeAd);
	}
	internal sealed class UnifiedNativeAdLoaderDelegateWrapper : BaseWrapper, IUnifiedNativeAdLoaderDelegate {
		[Preserve (Conditional = true)]
		public UnifiedNativeAdLoaderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adLoader:didReceiveUnifiedNativeAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveUnifiedNativeAd (AdLoader adLoader, NativeAd nativeAd)
		{
			var adLoader__handle__ = adLoader!.GetNonNullHandle (nameof (adLoader));
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("adLoader:didReceiveUnifiedNativeAd:"), adLoader__handle__, nativeAd__handle__);
		}
		[Export ("adLoader:didFailToReceiveAdWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToReceiveAd (AdLoader adLoader, NSError error)
		{
			var adLoader__handle__ = adLoader!.GetNonNullHandle (nameof (adLoader));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("adLoader:didFailToReceiveAdWithError:"), adLoader__handle__, error__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_UnifiedNativeAdLoaderDelegate", false)]
	[Model]
	public unsafe abstract partial class UnifiedNativeAdLoaderDelegate : NSObject, IUnifiedNativeAdLoaderDelegate, IAdLoaderDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UnifiedNativeAdLoaderDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UnifiedNativeAdLoaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UnifiedNativeAdLoaderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adLoader:didFailToReceiveAdWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToReceiveAd (AdLoader adLoader, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adLoaderDidFinishLoading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishLoading (AdLoader adLoader)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adLoader:didReceiveUnifiedNativeAd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidReceiveUnifiedNativeAd (AdLoader adLoader, NativeAd nativeAd);
	} /* class UnifiedNativeAdLoaderDelegate */
}
