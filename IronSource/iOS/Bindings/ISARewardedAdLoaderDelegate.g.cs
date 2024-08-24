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
	[Protocol (Name = "ISARewardedAdLoaderDelegate", WrapperType = typeof (ISARewardedAdLoaderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedAdDidLoad", Selector = "rewardedAdDidLoad:", ParameterType = new Type [] { typeof (IronSourceSdk.ISARewardedAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RewardedAdDidFailToLoadWithError", Selector = "rewardedAdDidFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public partial interface IISARewardedAdLoaderDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAdDidLoad:")]
		[Preserve (Conditional = true)]
		void RewardedAdDidLoad (ISARewardedAd rewardedAd);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAdDidFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void RewardedAdDidFailToLoadWithError (NSError error);
	}
	internal unsafe sealed class ISARewardedAdLoaderDelegateWrapper : BaseWrapper, IISARewardedAdLoaderDelegate {
		[Preserve (Conditional = true)]
		public ISARewardedAdLoaderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("rewardedAdDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedAdDidLoad (ISARewardedAd rewardedAd)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedAdDidLoad:"), rewardedAd__handle__);
		}
		[Export ("rewardedAdDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RewardedAdDidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rewardedAdDidFailToLoadWithError:"), error__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISARewardedAdLoaderDelegate", false)]
	[Model]
	public unsafe abstract partial class ISARewardedAdLoaderDelegate : NSObject, IISARewardedAdLoaderDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISARewardedAdLoaderDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISARewardedAdLoaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISARewardedAdLoaderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("rewardedAdDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedAdDidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAdDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RewardedAdDidLoad (ISARewardedAd rewardedAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISARewardedAdLoaderDelegate */
}
