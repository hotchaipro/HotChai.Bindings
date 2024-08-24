//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Protocol (Name = "GADCustomEventInterstitial", WrapperType = typeof (CustomEventInterstitialWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetDelegate", Selector = "delegate", ReturnType = typeof (Google.MobileAds.ICustomEventInterstitialDelegate))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDelegate", Selector = "setDelegate:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventInterstitialDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestInterstitialAd", Selector = "requestInterstitialAdWithParameter:label:request:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (Google.MobileAds.CustomEventRequest) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentFromRootViewController", Selector = "presentFromRootViewController:", ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface ICustomEventInterstitial : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("delegate")]
		[Preserve (Conditional = true)]
		ICustomEventInterstitialDelegate? GetDelegate ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setDelegate:")]
		[Preserve (Conditional = true)]
		void SetDelegate (ICustomEventInterstitialDelegate? aDelegate);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("requestInterstitialAdWithParameter:label:request:")]
		[Preserve (Conditional = true)]
		void RequestInterstitialAd (string? serverParameter, string? serverLabel, CustomEventRequest request);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("presentFromRootViewController:")]
		[Preserve (Conditional = true)]
		void PresentFromRootViewController (global::UIKit.UIViewController? rootViewController);
	}
	internal sealed class CustomEventInterstitialWrapper : BaseWrapper, ICustomEventInterstitial {
		[Preserve (Conditional = true)]
		public CustomEventInterstitialWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("delegate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICustomEventInterstitialDelegate? GetDelegate ()
		{
			return  Runtime.GetINativeObject<ICustomEventInterstitialDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
		}
		[Export ("setDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDelegate (ICustomEventInterstitialDelegate? aDelegate)
		{
			var aDelegate__handle__ = aDelegate.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), aDelegate__handle__);
		}
		[Export ("requestInterstitialAdWithParameter:label:request:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RequestInterstitialAd (string? serverParameter, string? serverLabel, CustomEventRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var nsserverParameter = CFString.CreateNative (serverParameter);
			var nsserverLabel = CFString.CreateNative (serverLabel);
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestInterstitialAdWithParameter:label:request:"), nsserverParameter, nsserverLabel, request__handle__);
			CFString.ReleaseNative (nsserverParameter);
			CFString.ReleaseNative (nsserverLabel);
		}
		[Export ("presentFromRootViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PresentFromRootViewController (global::UIKit.UIViewController? rootViewController)
		{
			var rootViewController__handle__ = rootViewController.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("presentFromRootViewController:"), rootViewController__handle__);
		}
	}
}
