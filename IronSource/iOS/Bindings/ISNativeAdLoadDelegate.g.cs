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
	[Protocol (Name = "ISNativeAdLoadDelegate", WrapperType = typeof (ISNativeAdLoadDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidLoad", Selector = "didLoad:withAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.LevelPlayNativeAd), typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailToLoad", Selector = "didFailToLoad:withError:", ParameterType = new Type [] { typeof (IronSourceSdk.LevelPlayNativeAd), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IISNativeAdLoadDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didLoad:withAdInfo:")]
		[Preserve (Conditional = true)]
		void DidLoad (LevelPlayNativeAd nativeAd, ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didFailToLoad:withError:")]
		[Preserve (Conditional = true)]
		void DidFailToLoad (LevelPlayNativeAd nativeAd, NSError error);
	}
	internal unsafe sealed class ISNativeAdLoadDelegateWrapper : BaseWrapper, IISNativeAdLoadDelegate {
		[Preserve (Conditional = true)]
		public ISNativeAdLoadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
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
	[Register("ApiDefinitions__IronSourceSdk_ISNativeAdLoadDelegate", false)]
	[Model]
	public unsafe abstract partial class ISNativeAdLoadDelegate : NSObject, IISNativeAdLoadDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISNativeAdLoadDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISNativeAdLoadDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISNativeAdLoadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
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
	} /* class ISNativeAdLoadDelegate */
}
