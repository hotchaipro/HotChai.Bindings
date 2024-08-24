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
    [Protocol (Name = "GADFullScreenContentDelegate", WrapperType = typeof (FullScreenContentDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordImpression", Selector = "adDidRecordImpression:", ParameterType = new Type [] { typeof (Google.MobileAds.FullScreenPresentingAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordClick", Selector = "adDidRecordClick:", ParameterType = new Type [] { typeof (Google.MobileAds.FullScreenPresentingAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToPresentFullScreenContent", Selector = "ad:didFailToPresentFullScreenContentWithError:", ParameterType = new Type [] { typeof (Google.MobileAds.FullScreenPresentingAd), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPresentFullScreenContent", Selector = "adDidPresentFullScreenContent:", ParameterType = new Type [] { typeof (Google.MobileAds.FullScreenPresentingAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissFullScreenContent", Selector = "adWillDismissFullScreenContent:", ParameterType = new Type [] { typeof (Google.MobileAds.FullScreenPresentingAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissFullScreenContent", Selector = "adDidDismissFullScreenContent:", ParameterType = new Type [] { typeof (Google.MobileAds.FullScreenPresentingAd) }, ParameterByRef = new bool [] { false })]
	public partial interface IFullScreenContentDelegate : INativeObject, IDisposable
	{
	}
	public static partial class FullScreenContentDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordImpression (this IFullScreenContentDelegate This, FullScreenPresentingAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adDidRecordImpression:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordClick (this IFullScreenContentDelegate This, FullScreenPresentingAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adDidRecordClick:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToPresentFullScreenContent (this IFullScreenContentDelegate This, FullScreenPresentingAd ad, NSError error)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("ad:didFailToPresentFullScreenContentWithError:"), ad__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPresentFullScreenContent (this IFullScreenContentDelegate This, FullScreenPresentingAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adDidPresentFullScreenContent:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissFullScreenContent (this IFullScreenContentDelegate This, FullScreenPresentingAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adWillDismissFullScreenContent:"), ad__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissFullScreenContent (this IFullScreenContentDelegate This, FullScreenPresentingAd ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adDidDismissFullScreenContent:"), ad__handle__);
		}
	}
	internal sealed class FullScreenContentDelegateWrapper : BaseWrapper, IFullScreenContentDelegate {
		[Preserve (Conditional = true)]
		public FullScreenContentDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_FullScreenContentDelegate", false)]
	[Model]
	public unsafe partial class FullScreenContentDelegate : NSObject, IFullScreenContentDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FullScreenContentDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected FullScreenContentDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FullScreenContentDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adDidDismissFullScreenContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissFullScreenContent (FullScreenPresentingAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("ad:didFailToPresentFullScreenContentWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPresentFullScreenContent (FullScreenPresentingAd ad, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidPresentFullScreenContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentFullScreenContent (FullScreenPresentingAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidRecordClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordClick (FullScreenPresentingAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidRecordImpression:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordImpression (FullScreenPresentingAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adWillDismissFullScreenContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissFullScreenContent (FullScreenPresentingAd ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class FullScreenContentDelegate */
}
