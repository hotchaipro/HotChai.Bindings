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
    [Protocol (Name = "GADAdLoaderDelegate", WrapperType = typeof (AdLoaderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailToReceiveAd", Selector = "adLoader:didFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (Google.MobileAds.AdLoader), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishLoading", Selector = "adLoaderDidFinishLoading:", ParameterType = new Type [] { typeof (Google.MobileAds.AdLoader) }, ParameterByRef = new bool [] { false })]
	public partial interface IAdLoaderDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adLoader:didFailToReceiveAdWithError:")]
		[Preserve (Conditional = true)]
		void DidFailToReceiveAd (AdLoader adLoader, NSError error);
	}
	public static partial class AdLoaderDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishLoading (this IAdLoaderDelegate This, AdLoader adLoader)
		{
			var adLoader__handle__ = adLoader!.GetNonNullHandle (nameof (adLoader));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adLoaderDidFinishLoading:"), adLoader__handle__);
		}
	}
	internal sealed class AdLoaderDelegateWrapper : BaseWrapper, IAdLoaderDelegate {
		[Preserve (Conditional = true)]
		public AdLoaderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
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
	[Register("ApiDefinition__Google_MobileAds_AdLoaderDelegate", false)]
	[Model]
	public unsafe abstract partial class AdLoaderDelegate : NSObject, IAdLoaderDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AdLoaderDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AdLoaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdLoaderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adLoader:didFailToReceiveAdWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidFailToReceiveAd (AdLoader adLoader, NSError error);
		[Export ("adLoaderDidFinishLoading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishLoading (AdLoader adLoader)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AdLoaderDelegate */
}
