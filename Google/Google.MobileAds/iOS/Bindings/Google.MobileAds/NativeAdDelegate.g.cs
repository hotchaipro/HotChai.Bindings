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
    [Protocol (Name = "GADNativeAdDelegate", WrapperType = typeof (NativeAdDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordImpression", Selector = "nativeAdDidRecordImpression:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordClick", Selector = "nativeAdDidRecordClick:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentScreen", Selector = "nativeAdWillPresentScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissScreen", Selector = "nativeAdWillDismissScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissScreen", Selector = "nativeAdDidDismissScreen:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillLeaveApplication", Selector = "nativeAdWillLeaveApplication:", ParameterType = new Type [] { typeof (Google.MobileAds.NativeAd) }, ParameterByRef = new bool [] { false })]
	public partial interface INativeAdDelegate : INativeObject, IDisposable
	{
	}
	public static partial class NativeAdDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordImpression (this INativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("nativeAdDidRecordImpression:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordClick (this INativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("nativeAdDidRecordClick:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentScreen (this INativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("nativeAdWillPresentScreen:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissScreen (this INativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("nativeAdWillDismissScreen:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissScreen (this INativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("nativeAdDidDismissScreen:"), nativeAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillLeaveApplication (this INativeAdDelegate This, NativeAd nativeAd)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("nativeAdWillLeaveApplication:"), nativeAd__handle__);
		}
	}
	internal sealed class NativeAdDelegateWrapper : BaseWrapper, INativeAdDelegate {
		[Preserve (Conditional = true)]
		public NativeAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_NativeAdDelegate", false)]
	[Model]
	public unsafe partial class NativeAdDelegate : NSObject, INativeAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NativeAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NativeAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NativeAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("nativeAdDidDismissScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissScreen (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("nativeAdDidRecordClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordClick (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("nativeAdDidRecordImpression:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordImpression (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("nativeAdWillDismissScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissScreen (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("nativeAdWillLeaveApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillLeaveApplication (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("nativeAdWillPresentScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentScreen (NativeAd nativeAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NativeAdDelegate */
}
