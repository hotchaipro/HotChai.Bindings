//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace IronSourceSdk {
	[Protocol (Name = "LevelPlayNativeAdDelegate", WrapperType = typeof (LevelPlayNativeAdDelegateWrapper))]
	public partial interface ILevelPlayNativeAdDelegate : INativeObject, IDisposable, 
		IronSourceSdk.IISNativeAdInteractionDelegate
		, IronSourceSdk.IISNativeAdLoadDelegate
	{
	}
	internal unsafe sealed class LevelPlayNativeAdDelegateWrapper : BaseWrapper, ILevelPlayNativeAdDelegate {
		[Preserve (Conditional = true)]
		public LevelPlayNativeAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("didRecordImpression:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidRecordImpression (LevelPlayNativeAd nativeAd, ISAdInfo adInfo)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didRecordImpression:withAdInfo:"), nativeAd__handle__, adInfo__handle__);
		}
		[Export ("didClick:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidClick (LevelPlayNativeAd nativeAd, ISAdInfo adInfo)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didClick:withAdInfo:"), nativeAd__handle__, adInfo__handle__);
		}
		[Export ("didLoad:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidLoad (LevelPlayNativeAd nativeAd, ISAdInfo adInfo)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didLoad:withAdInfo:"), nativeAd__handle__, adInfo__handle__);
		}
		[Export ("didFailToLoad:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToLoad (LevelPlayNativeAd nativeAd, NSError error)
		{
			var nativeAd__handle__ = nativeAd!.GetNonNullHandle (nameof (nativeAd));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didFailToLoad:withError:"), nativeAd__handle__, error__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_LevelPlayNativeAdDelegate", false)]
	[Model]
	public unsafe partial class LevelPlayNativeAdDelegate : NSObject, ILevelPlayNativeAdDelegate, IISNativeAdInteractionDelegate, IISNativeAdLoadDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LevelPlayNativeAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LevelPlayNativeAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LevelPlayNativeAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didClick:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClick (LevelPlayNativeAd nativeAd, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToLoad:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLoad (LevelPlayNativeAd nativeAd, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLoad:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoad (LevelPlayNativeAd nativeAd, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didRecordImpression:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordImpression (LevelPlayNativeAd nativeAd, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class LevelPlayNativeAdDelegate */
}
