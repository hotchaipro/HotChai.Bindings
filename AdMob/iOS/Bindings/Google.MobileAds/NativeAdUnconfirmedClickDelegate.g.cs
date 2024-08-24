//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
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
    [Protocol (Name = "GADNativeAdUnconfirmedClickDelegate", WrapperType = typeof (NativeAdUnconfirmedClickDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveUnconfirmedClick", Selector = "nativeAd:didReceiveUnconfirmedClickOnAssetID:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCancelUnconfirmedClick", Selector = "nativeAdDidCancelUnconfirmedClick:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	public partial interface INativeAdUnconfirmedClickDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("nativeAd:didReceiveUnconfirmedClickOnAssetID:")]
		[Preserve (Conditional = true)]
		void DidReceiveUnconfirmedClick (NativeAd nativeAd, string assetId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("nativeAdDidCancelUnconfirmedClick:")]
		[Preserve (Conditional = true)]
		void DidCancelUnconfirmedClick (NativeAd nativeAd);
	}
	internal sealed class NativeAdUnconfirmedClickDelegateWrapper : BaseWrapper, INativeAdUnconfirmedClickDelegate {
		[Preserve (Conditional = true)]
		public NativeAdUnconfirmedClickDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("nativeAd:didReceiveUnconfirmedClickOnAssetID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveUnconfirmedClick (NativeAd nativeAd, string assetId)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			if (assetId is null)
				ThrowHelper.ThrowArgumentNullException (nameof (assetId));
			var nsassetId = CFString.CreateNative (assetId);
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("nativeAd:didReceiveUnconfirmedClickOnAssetID:"), nativeAd__handle__, nsassetId);
			CFString.ReleaseNative (nsassetId);
		}
		[Export ("nativeAdDidCancelUnconfirmedClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidCancelUnconfirmedClick (NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("nativeAdDidCancelUnconfirmedClick:"), nativeAd__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_NativeAdUnconfirmedClickDelegate", false)]
	[Model]
	public unsafe abstract partial class NativeAdUnconfirmedClickDelegate : NSObject, INativeAdUnconfirmedClickDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NativeAdUnconfirmedClickDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NativeAdUnconfirmedClickDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NativeAdUnconfirmedClickDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("nativeAdDidCancelUnconfirmedClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidCancelUnconfirmedClick (NativeAd nativeAd);
		[Export ("nativeAd:didReceiveUnconfirmedClickOnAssetID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidReceiveUnconfirmedClick (NativeAd nativeAd, string assetId);
	} /* class NativeAdUnconfirmedClickDelegate */
}
