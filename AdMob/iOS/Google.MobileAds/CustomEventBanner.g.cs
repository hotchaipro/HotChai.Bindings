//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Protocol (Name = "GADCustomEventBanner", WrapperType = typeof (CustomEventBannerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestBannerAd", Selector = "requestBannerAd:parameter:label:request:", ParameterType = new Type [] { typeof (Google.MobileAds.AdSize), typeof (string), typeof (string), typeof (Google.MobileAds.CustomEventRequest) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetDelegate", Selector = "delegate", ReturnType = typeof (Google.MobileAds.ICustomEventBannerDelegate))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDelegate", Selector = "setDelegate:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventBannerDelegate) }, ParameterByRef = new bool [] { false })]
	public partial interface ICustomEventBanner : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("requestBannerAd:parameter:label:request:")]
		[Preserve (Conditional = true)]
		void RequestBannerAd (AdSize adSize, string? serverParameter, string? serverLabel, CustomEventRequest request);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("delegate")]
		[Preserve (Conditional = true)]
		ICustomEventBannerDelegate? GetDelegate ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setDelegate:")]
		[Preserve (Conditional = true)]
		void SetDelegate (ICustomEventBannerDelegate? aDelegate);
	}
	internal sealed class CustomEventBannerWrapper : BaseWrapper, ICustomEventBanner {
		[Preserve (Conditional = true)]
		public CustomEventBannerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("requestBannerAd:parameter:label:request:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RequestBannerAd (AdSize adSize, string? serverParameter, string? serverLabel, CustomEventRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var nsserverParameter = CFString.CreateNative (serverParameter);
			var nsserverLabel = CFString.CreateNative (serverLabel);
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_AdSize_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestBannerAd:parameter:label:request:"), adSize, nsserverParameter, nsserverLabel, request__handle__);
			CFString.ReleaseNative (nsserverParameter);
			CFString.ReleaseNative (nsserverLabel);
		}
		[Export ("delegate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICustomEventBannerDelegate? GetDelegate ()
		{
			return  Runtime.GetINativeObject<ICustomEventBannerDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
		}
		[Export ("setDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDelegate (ICustomEventBannerDelegate? aDelegate)
		{
			var aDelegate__handle__ = aDelegate.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), aDelegate__handle__);
		}
	}
}
