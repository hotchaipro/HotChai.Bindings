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
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds.ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.AdInspectorCompletionHandler))]
		unsafe internal delegate void DAdInspectorCompletionHandler (NativeHandle block, NativeHandle error);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAdInspectorCompletionHandler {
			unsafe static internal readonly DAdInspectorCompletionHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DAdInspectorCompletionHandler))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle error) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.AdInspectorCompletionHandler> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<NSError> (error)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.AdInspectorCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.AdInspectorCompletionHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDAdInspectorCompletionHandler */
		internal sealed class NIDAdInspectorCompletionHandler : TrampolineBlockBase {
			DAdInspectorCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAdInspectorCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DAdInspectorCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.AdInspectorCompletionHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.AdInspectorCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDAdInspectorCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError? error)
			{
				var error__handle__ = error?.GetHandle () ?? NativeHandle.Zero;
				invoker (BlockPointer, error__handle__);
			}
		} /* class NIDAdInspectorCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.AppOpenAdLoadCompletionHandler))]
		unsafe internal delegate void DAppOpenAdLoadCompletionHandler (NativeHandle block, NativeHandle appOpenAd, NativeHandle error);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAppOpenAdLoadCompletionHandler {
			unsafe static internal readonly DAppOpenAdLoadCompletionHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DAppOpenAdLoadCompletionHandler))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle appOpenAd, NativeHandle error) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.AppOpenAdLoadCompletionHandler> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<Google.MobileAds.AppOpenAd> (appOpenAd)!,  Runtime.GetNSObject<NSError> (error)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.AppOpenAdLoadCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.AppOpenAdLoadCompletionHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDAppOpenAdLoadCompletionHandler */
		internal sealed class NIDAppOpenAdLoadCompletionHandler : TrampolineBlockBase {
			DAppOpenAdLoadCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAppOpenAdLoadCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DAppOpenAdLoadCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.AppOpenAdLoadCompletionHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.AppOpenAdLoadCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDAppOpenAdLoadCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Google.MobileAds.AppOpenAd? appOpenAd, NSError? error)
			{
				var appOpenAd__handle__ = appOpenAd.GetHandle ();
				var error__handle__ = error.GetHandle ();
				invoker (BlockPointer, appOpenAd__handle__, error__handle__);
			}
		} /* class NIDAppOpenAdLoadCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.InitializationCompletionHandler))]
		unsafe internal delegate void DInitializationCompletionHandler (NativeHandle block, NativeHandle status);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDInitializationCompletionHandler {
			unsafe static internal readonly DInitializationCompletionHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DInitializationCompletionHandler))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle status) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.InitializationCompletionHandler> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<Google.MobileAds.InitializationStatus> (status)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.InitializationCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.InitializationCompletionHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDInitializationCompletionHandler */
		internal sealed class NIDInitializationCompletionHandler : TrampolineBlockBase {
			DInitializationCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDInitializationCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DInitializationCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.InitializationCompletionHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.InitializationCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDInitializationCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Google.MobileAds.InitializationStatus status)
			{
				var status__handle__ = status.GetHandle ();
				invoker (BlockPointer, status__handle__);
			}
		} /* class NIDInitializationCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.InterstitialAdLoadCompletionHandler))]
		unsafe internal delegate void DInterstitialAdLoadCompletionHandler (NativeHandle block, NativeHandle interstitialAd, NativeHandle error);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDInterstitialAdLoadCompletionHandler {
			unsafe static internal readonly DInterstitialAdLoadCompletionHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DInterstitialAdLoadCompletionHandler))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle interstitialAd, NativeHandle error) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.InterstitialAdLoadCompletionHandler> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<Google.MobileAds.InterstitialAd> (interstitialAd)!,  Runtime.GetNSObject<NSError> (error)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.InterstitialAdLoadCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.InterstitialAdLoadCompletionHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDInterstitialAdLoadCompletionHandler */
		internal sealed class NIDInterstitialAdLoadCompletionHandler : TrampolineBlockBase {
			DInterstitialAdLoadCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDInterstitialAdLoadCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DInterstitialAdLoadCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.InterstitialAdLoadCompletionHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.InterstitialAdLoadCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDInterstitialAdLoadCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Google.MobileAds.InterstitialAd? interstitialAd, NSError? error)
			{
				var interstitialAd__handle__ = interstitialAd.GetHandle ();
				var error__handle__ = error.GetHandle ();
				invoker (BlockPointer, interstitialAd__handle__, error__handle__);
			}
		} /* class NIDInterstitialAdLoadCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.NativeAdCustomClickHandle))]
		unsafe internal delegate void DNativeAdCustomClickHandle (NativeHandle block, NativeHandle assetId);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDNativeAdCustomClickHandle {
			unsafe static internal readonly DNativeAdCustomClickHandle Handler = Invoke;
			[MonoPInvokeCallback (typeof (DNativeAdCustomClickHandle))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle assetId) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.NativeAdCustomClickHandle> (block);
				if (del != null) {
					del (CFString.FromHandle (assetId)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.NativeAdCustomClickHandle? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.NativeAdCustomClickHandle callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDNativeAdCustomClickHandle */
		internal sealed class NIDNativeAdCustomClickHandle : TrampolineBlockBase {
			DNativeAdCustomClickHandle invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDNativeAdCustomClickHandle (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DNativeAdCustomClickHandle> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.NativeAdCustomClickHandle? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.NativeAdCustomClickHandle) GetExistingManagedDelegate (block);
				return del ?? new NIDNativeAdCustomClickHandle ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (string assetId)
			{
				if (assetId is null)
					ThrowHelper.ThrowArgumentNullException (nameof (assetId));
				var nsassetId = CFString.CreateNative (assetId);
				invoker (BlockPointer, nsassetId);
				CFString.ReleaseNative (nsassetId);
			}
		} /* class NIDNativeAdCustomClickHandle */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.PaidEventHandler))]
		unsafe internal delegate void DPaidEventHandler (NativeHandle block, NativeHandle value);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPaidEventHandler {
			unsafe static internal readonly DPaidEventHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DPaidEventHandler))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle value) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.PaidEventHandler> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<Google.MobileAds.AdValue> (value)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.PaidEventHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.PaidEventHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDPaidEventHandler */
		internal sealed class NIDPaidEventHandler : TrampolineBlockBase {
			DPaidEventHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDPaidEventHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DPaidEventHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.PaidEventHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.PaidEventHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDPaidEventHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Google.MobileAds.AdValue value)
			{
				var value__handle__ = value.GetHandle ();
				invoker (BlockPointer, value__handle__);
			}
		} /* class NIDPaidEventHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.RewardedAdLoadCompletionHandler))]
		unsafe internal delegate void DRewardedAdLoadCompletionHandler (NativeHandle block, NativeHandle rewardedAd, NativeHandle error);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRewardedAdLoadCompletionHandler {
			unsafe static internal readonly DRewardedAdLoadCompletionHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DRewardedAdLoadCompletionHandler))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle rewardedAd, NativeHandle error) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.RewardedAdLoadCompletionHandler> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<Google.MobileAds.RewardedAd> (rewardedAd)!,  Runtime.GetNSObject<NSError> (error)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.RewardedAdLoadCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.RewardedAdLoadCompletionHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDRewardedAdLoadCompletionHandler */
		internal sealed class NIDRewardedAdLoadCompletionHandler : TrampolineBlockBase {
			DRewardedAdLoadCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDRewardedAdLoadCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DRewardedAdLoadCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.RewardedAdLoadCompletionHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.RewardedAdLoadCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDRewardedAdLoadCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Google.MobileAds.RewardedAd? rewardedAd, NSError? error)
			{
				var rewardedAd__handle__ = rewardedAd.GetHandle ();
				var error__handle__ = error.GetHandle ();
				invoker (BlockPointer, rewardedAd__handle__, error__handle__);
			}
		} /* class NIDRewardedAdLoadCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.RewardedInterstitialAdLoadCompletionHandler))]
		unsafe internal delegate void DRewardedInterstitialAdLoadCompletionHandler (NativeHandle block, NativeHandle rewardedInterstitialAd, NativeHandle error);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRewardedInterstitialAdLoadCompletionHandler {
			unsafe static internal readonly DRewardedInterstitialAdLoadCompletionHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DRewardedInterstitialAdLoadCompletionHandler))]
			internal static unsafe void Invoke (NativeHandle block, NativeHandle rewardedInterstitialAd, NativeHandle error) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.RewardedInterstitialAdLoadCompletionHandler> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<Google.MobileAds.RewardedInterstitialAd> (rewardedInterstitialAd)!,  Runtime.GetNSObject<NSError> (error)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.RewardedInterstitialAdLoadCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.RewardedInterstitialAdLoadCompletionHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDRewardedInterstitialAdLoadCompletionHandler */
		internal sealed class NIDRewardedInterstitialAdLoadCompletionHandler : TrampolineBlockBase {
			DRewardedInterstitialAdLoadCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDRewardedInterstitialAdLoadCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DRewardedInterstitialAdLoadCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.RewardedInterstitialAdLoadCompletionHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.RewardedInterstitialAdLoadCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDRewardedInterstitialAdLoadCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Google.MobileAds.RewardedInterstitialAd? rewardedInterstitialAd, NSError? error)
			{
				var rewardedInterstitialAd__handle__ = rewardedInterstitialAd.GetHandle ();
				var error__handle__ = error.GetHandle ();
				invoker (BlockPointer, rewardedInterstitialAd__handle__, error__handle__);
			}
		} /* class NIDRewardedInterstitialAdLoadCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.MobileAds.UserDidEarnRewardHandler))]
		unsafe internal delegate void DUserDidEarnRewardHandler (NativeHandle block);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDUserDidEarnRewardHandler {
			unsafe static internal readonly DUserDidEarnRewardHandler Handler = Invoke;
			[MonoPInvokeCallback (typeof (DUserDidEarnRewardHandler))]
			internal static unsafe void Invoke (NativeHandle block) {
				var del = BlockLiteral.GetTarget<global::Google.MobileAds.UserDidEarnRewardHandler> (block);
				if (del != null) {
					del ();
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.MobileAds.UserDidEarnRewardHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.MobileAds.UserDidEarnRewardHandler callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDUserDidEarnRewardHandler */
		internal sealed class NIDUserDidEarnRewardHandler : TrampolineBlockBase {
			DUserDidEarnRewardHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDUserDidEarnRewardHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DUserDidEarnRewardHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.MobileAds.UserDidEarnRewardHandler? Create (NativeHandle block)
			{
				if (block == NativeHandle.Zero)
					return null;
				var del = (global::Google.MobileAds.UserDidEarnRewardHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDUserDidEarnRewardHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDUserDidEarnRewardHandler */
	}
}
