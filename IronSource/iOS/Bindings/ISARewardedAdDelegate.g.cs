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
	[Protocol (Name = "ISARewardedAdDelegate", WrapperType = typeof (ISARewardedAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedAdDidShow", Selector = "rewardedAdDidShow:", ParameterType = new Type [] { typeof (IronSourceSdk.ISARewardedAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedAd", Selector = "rewardedAd:didFailToShowWithError:", ParameterType = new Type [] { typeof (IronSourceSdk.ISARewardedAd), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedAdDidUserEarnReward", Selector = "rewardedAdDidUserEarnReward:", ParameterType = new Type [] { typeof (IronSourceSdk.ISARewardedAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedAdDidClick", Selector = "rewardedAdDidClick:", ParameterType = new Type [] { typeof (IronSourceSdk.ISARewardedAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedAdDidDismiss", Selector = "rewardedAdDidDismiss:", ParameterType = new Type [] { typeof (IronSourceSdk.ISARewardedAd) }, ParameterByRef = new bool [] { false })]
	public partial interface IISARewardedAdDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAdDidShow:")]
		[Preserve (Conditional = true)]
		void RewardedAdDidShow (ISARewardedAd rewardedAd);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAd:didFailToShowWithError:")]
		[Preserve (Conditional = true)]
		void RewardedAd (ISARewardedAd rewardedAd, NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAdDidUserEarnReward:")]
		[Preserve (Conditional = true)]
		void RewardedAdDidUserEarnReward (ISARewardedAd rewardedAd);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAdDidClick:")]
		[Preserve (Conditional = true)]
		void RewardedAdDidClick (ISARewardedAd rewardedAd);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAdDidDismiss:")]
		[Preserve (Conditional = true)]
		void RewardedAdDidDismiss (ISARewardedAd rewardedAd);
	}
	internal unsafe sealed class ISARewardedAdDelegateWrapper : BaseWrapper, IISARewardedAdDelegate {
		[Preserve (Conditional = true)]
		public ISARewardedAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("rewardedAdDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedAdDidShow (ISARewardedAd rewardedAd)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedAdDidShow:"), rewardedAd__handle__);
		}
		[Export ("rewardedAd:didFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedAd (ISARewardedAd rewardedAd, NSError error)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("rewardedAd:didFailToShowWithError:"), rewardedAd__handle__, error__handle__);
		}
		[Export ("rewardedAdDidUserEarnReward:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedAdDidUserEarnReward (ISARewardedAd rewardedAd)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedAdDidUserEarnReward:"), rewardedAd__handle__);
		}
		[Export ("rewardedAdDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedAdDidClick (ISARewardedAd rewardedAd)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedAdDidClick:"), rewardedAd__handle__);
		}
		[Export ("rewardedAdDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedAdDidDismiss (ISARewardedAd rewardedAd)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedAdDidDismiss:"), rewardedAd__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISARewardedAdDelegate", false)]
	[Model]
	public unsafe abstract partial class ISARewardedAdDelegate : NSObject, IISARewardedAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISARewardedAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISARewardedAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISARewardedAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("rewardedAd:didFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedAd (ISARewardedAd rewardedAd, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAdDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedAdDidClick (ISARewardedAd rewardedAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAdDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedAdDidDismiss (ISARewardedAd rewardedAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAdDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedAdDidShow (ISARewardedAd rewardedAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAdDidUserEarnReward:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedAdDidUserEarnReward (ISARewardedAd rewardedAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISARewardedAdDelegate */
}
