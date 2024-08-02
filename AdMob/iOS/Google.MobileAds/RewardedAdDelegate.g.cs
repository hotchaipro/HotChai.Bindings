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
    [Protocol (Name = "GADRewardedAdDelegate", WrapperType = typeof (RewardedAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UserDidEarnReward", Selector = "rewardedAd:userDidEarnReward:", ParameterType = new Type [] { typeof (Google.MobileAds.RewardedAd), typeof (Google.MobileAds.AdReward) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToPresent", Selector = "rewardedAd:didFailToPresentWithError:", ParameterType = new Type [] { typeof (Google.MobileAds.RewardedAd), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPresent", Selector = "rewardedAdDidPresent:", ParameterType = new Type [] { typeof (Google.MobileAds.RewardedAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "rewardedAdDidDismiss:", ParameterType = new Type [] { typeof (Google.MobileAds.RewardedAd) }, ParameterByRef = new bool [] { false })]
	public partial interface IRewardedAdDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("rewardedAd:userDidEarnReward:")]
		[Preserve (Conditional = true)]
		void UserDidEarnReward (RewardedAd rewardedAd, AdReward reward);
	}
	public static partial class RewardedAdDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToPresent (this IRewardedAdDelegate This, RewardedAd rewardedAd, NSError error)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("rewardedAd:didFailToPresentWithError:"), rewardedAd__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPresent (this IRewardedAdDelegate This, RewardedAd rewardedAd)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rewardedAdDidPresent:"), rewardedAd__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this IRewardedAdDelegate This, RewardedAd rewardedAd)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rewardedAdDidDismiss:"), rewardedAd__handle__);
		}
	}
	internal sealed class RewardedAdDelegateWrapper : BaseWrapper, IRewardedAdDelegate {
		[Preserve (Conditional = true)]
		public RewardedAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("rewardedAd:userDidEarnReward:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UserDidEarnReward (RewardedAd rewardedAd, AdReward reward)
		{
			var rewardedAd__handle__ = rewardedAd!.GetNonNullHandle (nameof (rewardedAd));
			var reward__handle__ = reward!.GetNonNullHandle (nameof (reward));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("rewardedAd:userDidEarnReward:"), rewardedAd__handle__, reward__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_RewardedAdDelegate", false)]
	[Model]
	public unsafe abstract partial class RewardedAdDelegate : NSObject, IRewardedAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected RewardedAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected RewardedAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RewardedAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("rewardedAdDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (RewardedAd rewardedAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAd:didFailToPresentWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPresent (RewardedAd rewardedAd, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAdDidPresent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPresent (RewardedAd rewardedAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("rewardedAd:userDidEarnReward:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void UserDidEarnReward (RewardedAd rewardedAd, AdReward reward);
	} /* class RewardedAdDelegate */
}
