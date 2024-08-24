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
	[Protocol (Name = "LevelPlayRewardedVideoManualDelegate", WrapperType = typeof (LevelPlayRewardedVideoManualDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidLoadWithAdInfo", Selector = "didLoadWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailToLoadWithError", Selector = "didFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public partial interface ILevelPlayRewardedVideoManualDelegate : INativeObject, IDisposable, 
		IronSourceSdk.ILevelPlayRewardedVideoBaseDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didLoadWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidLoadWithAdInfo (ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void DidFailToLoadWithError (NSError error);
	}
	internal unsafe sealed class LevelPlayRewardedVideoManualDelegateWrapper : BaseWrapper, ILevelPlayRewardedVideoManualDelegate {
		[Preserve (Conditional = true)]
		public LevelPlayRewardedVideoManualDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("didLoadWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidLoadWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didLoadWithAdInfo:"), adInfo__handle__);
		}
		[Export ("didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didFailToLoadWithError:"), error__handle__);
		}
		[Export ("didReceiveRewardForPlacement:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveRewardForPlacement (ISPlacementInfo placementInfo, ISAdInfo adInfo)
		{
			var placementInfo__handle__ = placementInfo!.GetNonNullHandle (nameof (placementInfo));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didReceiveRewardForPlacement:withAdInfo:"), placementInfo__handle__, adInfo__handle__);
		}
		[Export ("didFailToShowWithError:andAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToShowWithError (NSError error, ISAdInfo adInfo)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didFailToShowWithError:andAdInfo:"), error__handle__, adInfo__handle__);
		}
		[Export ("didOpenWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidOpenWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didOpenWithAdInfo:"), adInfo__handle__);
		}
		[Export ("didClick:withAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidClick (ISPlacementInfo placementInfo, ISAdInfo adInfo)
		{
			var placementInfo__handle__ = placementInfo!.GetNonNullHandle (nameof (placementInfo));
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didClick:withAdInfo:"), placementInfo__handle__, adInfo__handle__);
		}
		[Export ("didCloseWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidCloseWithAdInfo (ISAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didCloseWithAdInfo:"), adInfo__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_LevelPlayRewardedVideoManualDelegate", false)]
	[Model]
	public unsafe abstract partial class LevelPlayRewardedVideoManualDelegate : NSObject, ILevelPlayRewardedVideoManualDelegate, ILevelPlayRewardedVideoBaseDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected LevelPlayRewardedVideoManualDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LevelPlayRewardedVideoManualDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LevelPlayRewardedVideoManualDelegate (NativeHandle handle) : base (handle)
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
		[Export ("didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToShowWithError:andAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToShowWithError (NSError error, ISAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLoadWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadWithAdInfo (ISAdInfo adInfo)
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
	} /* class LevelPlayRewardedVideoManualDelegate */
}
