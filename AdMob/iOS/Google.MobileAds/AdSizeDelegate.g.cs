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
    [Protocol (Name = "GADAdSizeDelegate", WrapperType = typeof (AdSizeDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillChangeAdSizeTo", Selector = "adView:willChangeAdSizeTo:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView), typeof (Google.MobileAds.AdSize) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAdSizeDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adView:willChangeAdSizeTo:")]
		[Preserve (Conditional = true)]
		void WillChangeAdSizeTo (BannerView view, AdSize size);
	}
	internal sealed class AdSizeDelegateWrapper : BaseWrapper, IAdSizeDelegate {
		[Preserve (Conditional = true)]
		public AdSizeDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adView:willChangeAdSizeTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillChangeAdSizeTo (BannerView view, AdSize size)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_AdSize (this.Handle, Selector.GetHandle ("adView:willChangeAdSizeTo:"), view__handle__, size);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_AdSizeDelegate", false)]
	[Model]
	public unsafe abstract partial class AdSizeDelegate : NSObject, IAdSizeDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AdSizeDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AdSizeDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdSizeDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adView:willChangeAdSizeTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void WillChangeAdSizeTo (BannerView view, AdSize size);
	} /* class AdSizeDelegate */
}
