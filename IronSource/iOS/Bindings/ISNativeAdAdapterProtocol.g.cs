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
	[Protocol (Name = "ISNativeAdAdapterProtocol", WrapperType = typeof (ISNativeAdAdapterProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitNativeAdsWithUserId", Selector = "initNativeAdsWithUserId:adapterConfig:delegate:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISAdapterConfig), typeof (IronSourceSdk.ISNativeAdAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitNativeAdForBiddingWithUserId", Selector = "initNativeAdForBiddingWithUserId:adapterConfig:delegate:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISAdapterConfig), typeof (IronSourceSdk.ISNativeAdAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadNativeAdWithAdapterConfig", Selector = "loadNativeAdWithAdapterConfig:adData:viewController:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (UIViewController), typeof (IronSourceSdk.ISNativeAdAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadNativeAdForBiddingWithAdapterConfig", Selector = "loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (string), typeof (UIViewController), typeof (IronSourceSdk.ISNativeAdAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DestroyNativeAdWithAdapterConfig", Selector = "destroyNativeAdWithAdapterConfig:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNativeAdBiddingDataWithAdapterConfig", Selector = "getNativeAdBiddingDataWithAdapterConfig:adData:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CollectNativeAdBiddingDataWithAdapterConfig", Selector = "collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (IronSourceSdk.ISBiddingDataDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IISNativeAdAdapterProtocol : INativeObject, IDisposable, 
		IronSourceSdk.IISAdUnitAdapterProtocol
		, IronSourceSdk.IISNetworkInitCallbackProtocol
		, IronSourceSdk.IISReleaseMemoryAdapterProtocol
	{
	}
	public unsafe static partial class ISNativeAdAdapterProtocol_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitNativeAdsWithUserId (this IISNativeAdAdapterProtocol This, string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("initNativeAdsWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsuserId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitNativeAdForBiddingWithUserId (this IISNativeAdAdapterProtocol This, string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsuserId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadNativeAdWithAdapterConfig (this IISNativeAdAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, global::UIKit.UIViewController viewController, ISNativeAdAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadNativeAdForBiddingWithAdapterConfig (this IISNativeAdAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, global::UIKit.UIViewController viewController, ISNativeAdAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsserverData);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DestroyNativeAdWithAdapterConfig (this IISNativeAdAdapterProtocol This, ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("destroyNativeAdWithAdapterConfig:"), adapterConfig__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetNativeAdBiddingDataWithAdapterConfig (this IISNativeAdAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("getNativeAdBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CollectNativeAdBiddingDataWithAdapterConfig (this IISNativeAdAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
		}
	}
	internal unsafe sealed class ISNativeAdAdapterProtocolWrapper : BaseWrapper, IISNativeAdAdapterProtocol {
		[Preserve (Conditional = true)]
		public ISNativeAdAdapterProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISNativeAdAdapterProtocol", true)]
	public unsafe partial class ISNativeAdAdapterProtocol : NSObject, IISNativeAdAdapterProtocol, IISAdUnitAdapterProtocol, IISNetworkInitCallbackProtocol, IISReleaseMemoryAdapterProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISNativeAdAdapterProtocol");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISNativeAdAdapterProtocol () : base (NSObjectFlag.Empty)
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
		protected ISNativeAdAdapterProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISNativeAdAdapterProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectNativeAdBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("destroyNativeAdWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DestroyNativeAdWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("destroyNativeAdWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("destroyNativeAdWithAdapterConfig:"), adapterConfig__handle__);
			}
		}
		[Export ("getNativeAdBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetNativeAdBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getNativeAdBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("getNativeAdBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			}
		}
		[Export ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitNativeAdForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initNativeAdsWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitNativeAdsWithUserId (string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initNativeAdsWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initNativeAdsWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadNativeAdForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, global::UIKit.UIViewController viewController, ISNativeAdAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadNativeAdWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, global::UIKit.UIViewController viewController, ISNativeAdAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, @delegate__handle__);
			}
		}
		[Export ("onNetworkInitCallbackFailed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnNetworkInitCallbackFailed (string errorMessage)
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
		public virtual void OnNetworkInitCallbackSuccess ()
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
	} /* class ISNativeAdAdapterProtocol */
}
