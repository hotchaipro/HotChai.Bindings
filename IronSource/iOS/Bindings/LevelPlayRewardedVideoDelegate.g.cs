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
	[Protocol (Name = "LevelPlayRewardedVideoDelegate", WrapperType = typeof (LevelPlayRewardedVideoDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HasAvailableAdWithAdInfo", Selector = "hasAvailableAdWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HasNoAvailableAd", Selector = "hasNoAvailableAd")]
	public partial interface ILevelPlayRewardedVideoDelegate : INativeObject, IDisposable, 
		IronSourceSdk.ILevelPlayRewardedVideoBaseDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("hasAvailableAdWithAdInfo:")]
		[Preserve (Conditional = true)]
		void HasAvailableAdWithAdInfo (ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("hasNoAvailableAd")]
		[Preserve (Conditional = true)]
		void HasNoAvailableAd ();
	}
	internal unsafe sealed class LevelPlayRewardedVideoDelegateWrapper : BaseWrapper, ILevelPlayRewardedVideoDelegate {
		[Preserve (Conditional = true)]
		public LevelPlayRewardedVideoDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("hasAvailableAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HasAvailableAdWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasAvailableAdWithAdInfo:"), adInfo__handle__);
		}
		[Export ("hasNoAvailableAd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HasNoAvailableAd ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hasNoAvailableAd"));
		}
		[Export ("didReceiveRewardForPlacement:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveRewardForPlacement (ISPlacementInfo placementInfo, ISAdInfo adInfo)
		{
			var placementInfo__handle__ = placementInfo!.GetNonNullHandle (nameof (placementInfo));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didReceiveRewardForPlacement:withAdInfo:"), placementInfo__handle__, adInfo__handle__);
		}
		[Export ("didFailToShowWithError:andAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToShowWithError (NSError error, ISAdInfo adInfo)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didFailToShowWithError:andAdInfo:"), error__handle__, adInfo__handle__);
		}
		[Export ("didOpenWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidOpenWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didOpenWithAdInfo:"), adInfo__handle__);
		}
		[Export ("didClick:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidClick (ISPlacementInfo placementInfo, ISAdInfo adInfo)
		{
			var placementInfo__handle__ = placementInfo!.GetNonNullHandle (nameof (placementInfo));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didClick:withAdInfo:"), placementInfo__handle__, adInfo__handle__);
		}
		[Export ("didCloseWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidCloseWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didCloseWithAdInfo:"), adInfo__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_LevelPlayRewardedVideoDelegate", false)]
	[Model]
	public unsafe abstract partial class LevelPlayRewardedVideoDelegate : NSObject, ILevelPlayRewardedVideoDelegate, ILevelPlayRewardedVideoBaseDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected LevelPlayRewardedVideoDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LevelPlayRewardedVideoDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LevelPlayRewardedVideoDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didClick:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClick (ISPlacementInfo placementInfo, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didCloseWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseWithAdInfo (ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToShowWithError:andAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToShowWithError (NSError error, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didOpenWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOpenWithAdInfo (ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didReceiveRewardForPlacement:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveRewardForPlacement (ISPlacementInfo placementInfo, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("hasAvailableAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HasAvailableAdWithAdInfo (ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("hasNoAvailableAd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HasNoAvailableAd ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class LevelPlayRewardedVideoDelegate */
}
