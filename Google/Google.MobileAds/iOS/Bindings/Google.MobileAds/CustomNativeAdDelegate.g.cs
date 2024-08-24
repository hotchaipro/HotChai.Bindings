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
    [Protocol (Name = "GADCustomNativeAdDelegate", WrapperType = typeof (CustomNativeAdDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordImpression", Selector = "customNativeAdDidRecordImpression:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordClick", Selector = "customNativeAdDidRecordClick:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentScreen", Selector = "customNativeAdWillPresentScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissScreen", Selector = "customNativeAdWillDismissScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissScreen", Selector = "customNativeAdDidDismissScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	public partial interface ICustomNativeAdDelegate : INativeObject, IDisposable
	{
	}
	public static partial class CustomNativeAdDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordImpression (this ICustomNativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customNativeAdDidRecordImpression:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordClick (this ICustomNativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customNativeAdDidRecordClick:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentScreen (this ICustomNativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customNativeAdWillPresentScreen:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissScreen (this ICustomNativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customNativeAdWillDismissScreen:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissScreen (this ICustomNativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customNativeAdDidDismissScreen:"), nativeAd__handle__);
		}
	}
	internal sealed class CustomNativeAdDelegateWrapper : BaseWrapper, ICustomNativeAdDelegate {
		[Preserve (Conditional = true)]
		public CustomNativeAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_CustomNativeAdDelegate", false)]
	[Model]
	public unsafe partial class CustomNativeAdDelegate : NSObject, ICustomNativeAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CustomNativeAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CustomNativeAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CustomNativeAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("customNativeAdDidDismissScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissScreen (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customNativeAdDidRecordClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordClick (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customNativeAdDidRecordImpression:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordImpression (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customNativeAdWillDismissScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissScreen (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("customNativeAdWillPresentScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentScreen (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CustomNativeAdDelegate */
}
