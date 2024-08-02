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
using UIKit;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Protocol (Name = "GADCustomEventNativeAd", WrapperType = typeof (CustomEventNativeAdWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Request", Selector = "requestNativeAdWithParameter:request:adTypes:options:rootViewController:", ParameterType = new Type [] { typeof (string), typeof (Google.MobileAds.CustomEventRequest), typeof (NSString[]), typeof (NSNumber[]), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandlesUserClicks", Selector = "handlesUserClicks", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandlesUserImpressions", Selector = "handlesUserImpressions", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetDelegate", Selector = "delegate", ReturnType = typeof (Google.MobileAds.ICustomEventNativeAdDelegate))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDelegate", Selector = "setDelegate:", ParameterType = new Type [] { typeof (Google.MobileAds.ICustomEventNativeAdDelegate) }, ParameterByRef = new bool [] { false })]
	public partial interface ICustomEventNativeAd : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("requestNativeAdWithParameter:request:adTypes:options:rootViewController:")]
		[Preserve (Conditional = true)]
		void Request (string serverParameter, CustomEventRequest request, NSString[] adTypes, NSNumber[] options, global::UIKit.UIViewController rootViewController);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("handlesUserClicks")]
		[Preserve (Conditional = true)]
		bool HandlesUserClicks ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("handlesUserImpressions")]
		[Preserve (Conditional = true)]
		bool HandlesUserImpressions ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("delegate")]
		[Preserve (Conditional = true)]
		ICustomEventNativeAdDelegate? GetDelegate ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setDelegate:")]
		[Preserve (Conditional = true)]
		void SetDelegate (ICustomEventNativeAdDelegate? aDelegate);
	}
	internal sealed class CustomEventNativeAdWrapper : BaseWrapper, ICustomEventNativeAd {
		[Preserve (Conditional = true)]
		public CustomEventNativeAdWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("requestNativeAdWithParameter:request:adTypes:options:rootViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Request (string serverParameter, CustomEventRequest request, NSString[] adTypes, NSNumber[] options, global::UIKit.UIViewController rootViewController)
		{
			if (serverParameter is null)
				ThrowHelper.ThrowArgumentNullException (nameof (serverParameter));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (adTypes is null)
				ThrowHelper.ThrowArgumentNullException (nameof (adTypes));
			if (options is null)
				ThrowHelper.ThrowArgumentNullException (nameof (options));
			var rootViewController__handle__ = rootViewController!.GetNonNullHandle (nameof (rootViewController));
			var nsserverParameter = CFString.CreateNative (serverParameter);
			var nsa_adTypes = NSArray.FromNSObjects (adTypes);
			var nsa_options = NSArray.FromNSObjects (options);
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestNativeAdWithParameter:request:adTypes:options:rootViewController:"), nsserverParameter, request__handle__, nsa_adTypes.Handle, nsa_options.Handle, rootViewController__handle__);
			CFString.ReleaseNative (nsserverParameter);
			nsa_adTypes.Dispose ();
			nsa_options.Dispose ();
		}
		[Export ("handlesUserClicks")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool HandlesUserClicks ()
		{
			return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("handlesUserClicks"));
		}
		[Export ("handlesUserImpressions")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool HandlesUserImpressions ()
		{
			return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("handlesUserImpressions"));
		}
		[Export ("delegate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICustomEventNativeAdDelegate? GetDelegate ()
		{
			return  Runtime.GetINativeObject<ICustomEventNativeAdDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
		}
		[Export ("setDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDelegate (ICustomEventNativeAdDelegate? aDelegate)
		{
			var aDelegate__handle__ = aDelegate.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), aDelegate__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_CustomEventNativeAd", false)]
	[Model]
	public unsafe abstract partial class CustomEventNativeAd : NSObject, ICustomEventNativeAd {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CustomEventNativeAd () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CustomEventNativeAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CustomEventNativeAd (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("delegate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract ICustomEventNativeAdDelegate? GetDelegate ();
		[Export ("handlesUserClicks")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract bool HandlesUserClicks ();
		[Export ("handlesUserImpressions")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract bool HandlesUserImpressions ();
		[Export ("requestNativeAdWithParameter:request:adTypes:options:rootViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void Request (string serverParameter, CustomEventRequest request, NSString[] adTypes, NSNumber[] options, global::UIKit.UIViewController rootViewController);
		[Export ("setDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void SetDelegate (ICustomEventNativeAdDelegate? aDelegate);
	} /* class CustomEventNativeAd */
}
