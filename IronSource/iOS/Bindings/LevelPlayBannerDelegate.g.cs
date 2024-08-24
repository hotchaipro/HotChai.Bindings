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
	[Protocol (Name = "LevelPlayBannerDelegate", WrapperType = typeof (LevelPlayBannerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidLoad", Selector = "didLoad:withAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISBannerView), typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailToLoadWithError", Selector = "didFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidClickWithAdInfo", Selector = "didClickWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidLeaveApplicationWithAdInfo", Selector = "didLeaveApplicationWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidPresentScreenWithAdInfo", Selector = "didPresentScreenWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDismissScreenWithAdInfo", Selector = "didDismissScreenWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	public partial interface ILevelPlayBannerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didLoad:withAdInfo:")]
		[Preserve (Conditional = true)]
		void DidLoad (ISBannerView bannerView, ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void DidFailToLoadWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didClickWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidClickWithAdInfo (ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didLeaveApplicationWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidLeaveApplicationWithAdInfo (ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didPresentScreenWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidPresentScreenWithAdInfo (ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didDismissScreenWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidDismissScreenWithAdInfo (ISAdInfo adInfo);
	}
	internal unsafe sealed class LevelPlayBannerDelegateWrapper : BaseWrapper, ILevelPlayBannerDelegate {
		[Preserve (Conditional = true)]
		public LevelPlayBannerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("didLoad:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidLoad (ISBannerView bannerView, ISAdInfo adInfo)
		{
			var bannerView__handle__ = bannerView!.GetNonNullHandle (nameof (bannerView));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didLoad:withAdInfo:"), bannerView__handle__, adInfo__handle__);
		}
		[Export ("didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didFailToLoadWithError:"), error__handle__);
		}
		[Export ("didClickWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidClickWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didClickWithAdInfo:"), adInfo__handle__);
		}
		[Export ("didLeaveApplicationWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidLeaveApplicationWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didLeaveApplicationWithAdInfo:"), adInfo__handle__);
		}
		[Export ("didPresentScreenWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidPresentScreenWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didPresentScreenWithAdInfo:"), adInfo__handle__);
		}
		[Export ("didDismissScreenWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDismissScreenWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didDismissScreenWithAdInfo:"), adInfo__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_LevelPlayBannerDelegate", false)]
	[Model]
	public unsafe abstract partial class LevelPlayBannerDelegate : NSObject, ILevelPlayBannerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected LevelPlayBannerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LevelPlayBannerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LevelPlayBannerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didClickWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickWithAdInfo (ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didDismissScreenWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissScreenWithAdInfo (ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLeaveApplicationWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLeaveApplicationWithAdInfo (ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLoad:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoad (ISBannerView bannerView, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didPresentScreenWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresentScreenWithAdInfo (ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class LevelPlayBannerDelegate */
}
