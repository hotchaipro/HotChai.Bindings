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
	[Protocol (Name = "ISDemandOnlyRewardedVideoDelegate", WrapperType = typeof (ISDemandOnlyRewardedVideoDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedVideoDidLoad", Selector = "rewardedVideoDidLoad:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedVideoDidFailToLoadWithError", Selector = "rewardedVideoDidFailToLoadWithError:instanceId:", ParameterType = new Type [] { typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedVideoDidOpen", Selector = "rewardedVideoDidOpen:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedVideoDidFailToShowWithError", Selector = "rewardedVideoDidFailToShowWithError:instanceId:", ParameterType = new Type [] { typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedVideoDidClick", Selector = "rewardedVideoDidClick:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedVideoAdRewarded", Selector = "rewardedVideoAdRewarded:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedVideoDidClose", Selector = "rewardedVideoDidClose:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface IISDemandOnlyRewardedVideoDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedVideoDidLoad:")]
		[Preserve (Conditional = true)]
		void RewardedVideoDidLoad (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedVideoDidFailToLoadWithError:instanceId:")]
		[Preserve (Conditional = true)]
		void RewardedVideoDidFailToLoadWithError (NSError error, string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedVideoDidOpen:")]
		[Preserve (Conditional = true)]
		void RewardedVideoDidOpen (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedVideoDidFailToShowWithError:instanceId:")]
		[Preserve (Conditional = true)]
		void RewardedVideoDidFailToShowWithError (NSError error, string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedVideoDidClick:")]
		[Preserve (Conditional = true)]
		void RewardedVideoDidClick (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedVideoAdRewarded:")]
		[Preserve (Conditional = true)]
		void RewardedVideoAdRewarded (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedVideoDidClose:")]
		[Preserve (Conditional = true)]
		void RewardedVideoDidClose (string instanceId);
	}
	internal unsafe sealed class ISDemandOnlyRewardedVideoDelegateWrapper : BaseWrapper, IISDemandOnlyRewardedVideoDelegate {
		[Preserve (Conditional = true)]
		public ISDemandOnlyRewardedVideoDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("rewardedVideoDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedVideoDidLoad (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedVideoDidLoad:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("rewardedVideoDidFailToLoadWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedVideoDidFailToLoadWithError (NSError error, string instanceId)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("rewardedVideoDidFailToLoadWithError:instanceId:"), error__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("rewardedVideoDidOpen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedVideoDidOpen (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedVideoDidOpen:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("rewardedVideoDidFailToShowWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedVideoDidFailToShowWithError (NSError error, string instanceId)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("rewardedVideoDidFailToShowWithError:instanceId:"), error__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("rewardedVideoDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedVideoDidClick (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedVideoDidClick:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("rewardedVideoAdRewarded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedVideoAdRewarded (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedVideoAdRewarded:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("rewardedVideoDidClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedVideoDidClose (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedVideoDidClose:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISDemandOnlyRewardedVideoDelegate", false)]
	[Model]
	public unsafe abstract partial class ISDemandOnlyRewardedVideoDelegate : NSObject, IISDemandOnlyRewardedVideoDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISDemandOnlyRewardedVideoDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISDemandOnlyRewardedVideoDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISDemandOnlyRewardedVideoDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("rewardedVideoAdRewarded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedVideoAdRewarded (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedVideoDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedVideoDidClick (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedVideoDidClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedVideoDidClose (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedVideoDidFailToLoadWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedVideoDidFailToLoadWithError (NSError error, string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedVideoDidFailToShowWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedVideoDidFailToShowWithError (NSError error, string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedVideoDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedVideoDidLoad (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedVideoDidOpen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedVideoDidOpen (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISDemandOnlyRewardedVideoDelegate */
}
