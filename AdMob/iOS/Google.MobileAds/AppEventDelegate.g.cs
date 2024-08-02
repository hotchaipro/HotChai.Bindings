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
    [Protocol (Name = "GADAppEventDelegate", WrapperType = typeof (AppEventDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AdViewDidReceiveAppEvent", Selector = "adView:didReceiveAppEvent:withInfo:", ParameterType = new Type [] { typeof (Google.MobileAds.BannerView), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InterstitialDidReceiveAppEvent", Selector = "interstitial:didReceiveAppEvent:withInfo:", ParameterType = new Type [] { typeof (Google.MobileAds.InterstitialAd), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAppEventDelegate : INativeObject, IDisposable
	{
	}
	public static partial class AppEventDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AdViewDidReceiveAppEvent (this IAppEventDelegate This, BannerView banner, string name, string? info)
		{
			var banner__handle__ = banner!.GetNonNullHandle (nameof (banner));
			if (name is null)
				ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			var nsinfo = CFString.CreateNative (info);
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("adView:didReceiveAppEvent:withInfo:"), banner__handle__, nsname, nsinfo);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsinfo);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InterstitialDidReceiveAppEvent (this IAppEventDelegate This, InterstitialAd interstitial, string name, string? info)
		{
			var interstitial__handle__ = interstitial!.GetNonNullHandle (nameof (interstitial));
			if (name is null)
				ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			var nsinfo = CFString.CreateNative (info);
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("interstitial:didReceiveAppEvent:withInfo:"), interstitial__handle__, nsname, nsinfo);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsinfo);
		}
	}
	internal sealed class AppEventDelegateWrapper : BaseWrapper, IAppEventDelegate {
		[Preserve (Conditional = true)]
		public AppEventDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_AppEventDelegate", false)]
	[Model]
	public unsafe partial class AppEventDelegate : NSObject, IAppEventDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AppEventDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AppEventDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AppEventDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adView:didReceiveAppEvent:withInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdViewDidReceiveAppEvent (BannerView banner, string name, string? info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitial:didReceiveAppEvent:withInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialDidReceiveAppEvent (InterstitialAd interstitial, string name, string? info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AppEventDelegate */
}
