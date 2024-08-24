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
	[Register("ISBaseRewardedVideoAdapter", true)]
	public unsafe partial class ISBaseRewardedVideoAdapter : ISBaseAdUnitAdapter, IISAdUnitAdapterProtocol, IISNetworkInitCallbackProtocol, IISReleaseMemoryAdapterProtocol, IISRewardedVideoAdapterProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBaseRewardedVideoAdapter");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBaseRewardedVideoAdapter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISBaseRewardedVideoAdapter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBaseRewardedVideoAdapter (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectRewardedVideoBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("getRewardedVideoBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetRewardedVideoBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getRewardedVideoBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("getRewardedVideoBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			}
		}
		[Export ("hasRewardedVideoWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasRewardedVideoWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			byte ret;
			if (IsDirectBinding) {
				ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasRewardedVideoWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("hasRewardedVideoWithAdapterConfig:"), adapterConfig__handle__);
			}
			return ret != 0;
		}
		[Export ("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitAndLoadRewardedVideoWithUserId (string userId, ISAdapterConfig adapterConfig, NSDictionary adData, ISRewardedVideoAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:"), nsuserId, adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:"), nsuserId, adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitRewardedVideoForCallbacksWithUserId (string userId, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitRewardedVideoForDemandOnlyWithUserId (string userId, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, string serverData, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:"), adapterConfig__handle__, nsserverData, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:"), adapterConfig__handle__, nsserverData, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoForDemandOnlyWithAdapterConfig (ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:"), adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:"), adapterConfig__handle__, @delegate__handle__);
			}
		}
		[Export ("loadRewardedVideoWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadRewardedVideoWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISRewardedVideoAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadRewardedVideoWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadRewardedVideoWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("onNetworkInitCallbackFailed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void OnNetworkInitCallbackFailed (string errorMessage)
		{
			if (errorMessage is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (errorMessage));
			var nserrorMessage = CFString.CreateNative (errorMessage);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("onNetworkInitCallbackFailed:"), nserrorMessage);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("onNetworkInitCallbackFailed:"), nserrorMessage);
			}
			CFString.ReleaseNative (nserrorMessage);
		}
		[Export ("onNetworkInitCallbackSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void OnNetworkInitCallbackSuccess ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onNetworkInitCallbackSuccess"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("onNetworkInitCallbackSuccess"));
			}
		}
		[Export ("releaseMemoryWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReleaseMemoryWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("releaseMemoryWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("releaseMemoryWithAdapterConfig:"), adapterConfig__handle__);
			}
		}
		[Export ("showRewardedVideoWithViewController:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowRewardedVideoWithViewController (global::UIKit.UIViewController viewController, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showRewardedVideoWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("showRewardedVideoWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			}
		}
	} /* class ISBaseRewardedVideoAdapter */
}
