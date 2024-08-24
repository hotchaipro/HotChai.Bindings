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
	[Protocol (Name = "LevelPlayRewardedVideoBaseDelegate", WrapperType = typeof (LevelPlayRewardedVideoBaseDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveRewardForPlacement", Selector = "didReceiveRewardForPlacement:withAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISPlacementInfo), typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailToShowWithError", Selector = "didFailToShowWithError:andAdInfo:", ParameterType = new Type [] { typeof (NSError), typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidOpenWithAdInfo", Selector = "didOpenWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidClick", Selector = "didClick:withAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISPlacementInfo), typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCloseWithAdInfo", Selector = "didCloseWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdInfo) }, ParameterByRef = new bool [] { false })]
	public partial interface ILevelPlayRewardedVideoBaseDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didReceiveRewardForPlacement:withAdInfo:")]
		[Preserve (Conditional = true)]
		void DidReceiveRewardForPlacement (ISPlacementInfo placementInfo, ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didFailToShowWithError:andAdInfo:")]
		[Preserve (Conditional = true)]
		void DidFailToShowWithError (NSError error, ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didOpenWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidOpenWithAdInfo (ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didClick:withAdInfo:")]
		[Preserve (Conditional = true)]
		void DidClick (ISPlacementInfo placementInfo, ISAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didCloseWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidCloseWithAdInfo (ISAdInfo adInfo);
	}
	internal unsafe sealed class LevelPlayRewardedVideoBaseDelegateWrapper : BaseWrapper, ILevelPlayRewardedVideoBaseDelegate {
		[Preserve (Conditional = true)]
		public LevelPlayRewardedVideoBaseDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
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
	[Register("ApiDefinitions__IronSourceSdk_LevelPlayRewardedVideoBaseDelegate", false)]
	[Model]
	public unsafe abstract partial class LevelPlayRewardedVideoBaseDelegate : NSObject, ILevelPlayRewardedVideoBaseDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected LevelPlayRewardedVideoBaseDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LevelPlayRewardedVideoBaseDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LevelPlayRewardedVideoBaseDelegate (NativeHandle handle) : base (handle)
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
	} /* class LevelPlayRewardedVideoBaseDelegate */
}
