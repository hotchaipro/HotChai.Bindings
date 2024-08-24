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
	[Protocol (Name = "ISInterstitialAdapterProtocol", WrapperType = typeof (ISInterstitialAdapterProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowInterstitialWithViewController", Selector = "showInterstitialWithViewController:adapterConfig:delegate:", ParameterType = new Type [] { typeof (UIViewController), typeof (IronSourceSdk.ISAdapterConfig), typeof (IronSourceSdk.ISInterstitialAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasInterstitialWithAdapterConfig", Selector = "hasInterstitialWithAdapterConfig:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitInterstitialWithUserId", Selector = "initInterstitialWithUserId:adapterConfig:delegate:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISAdapterConfig), typeof (IronSourceSdk.ISInterstitialAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadInterstitialWithAdapterConfig", Selector = "loadInterstitialWithAdapterConfig:adData:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (IronSourceSdk.ISInterstitialAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInterstitialBiddingDataWithAdapterConfig", Selector = "getInterstitialBiddingDataWithAdapterConfig:adData:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CollectInterstitialBiddingDataWithAdapterConfig", Selector = "collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (IronSourceSdk.ISBiddingDataDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitInterstitialForBiddingWithUserId", Selector = "initInterstitialForBiddingWithUserId:adapterConfig:delegate:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISAdapterConfig), typeof (IronSourceSdk.ISInterstitialAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadInterstitialForBiddingWithAdapterConfig", Selector = "loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (string), typeof (IronSourceSdk.ISInterstitialAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IISInterstitialAdapterProtocol : INativeObject, IDisposable, 
		IronSourceSdk.IISAdUnitAdapterProtocol
		, IronSourceSdk.IISNetworkInitCallbackProtocol
		, IronSourceSdk.IISReleaseMemoryAdapterProtocol
	{
	}
	public unsafe static partial class ISInterstitialAdapterProtocol_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowInterstitialWithViewController (this IISInterstitialAdapterProtocol This, global::UIKit.UIViewController viewController, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("showInterstitialWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasInterstitialWithAdapterConfig (this IISInterstitialAdapterProtocol This, ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("hasInterstitialWithAdapterConfig:"), adapterConfig__handle__);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitInterstitialWithUserId (this IISInterstitialAdapterProtocol This, string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("initInterstitialWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsuserId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadInterstitialWithAdapterConfig (this IISInterstitialAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, ISInterstitialAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadInterstitialWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetInterstitialBiddingDataWithAdapterConfig (this IISInterstitialAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("getInterstitialBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CollectInterstitialBiddingDataWithAdapterConfig (this IISInterstitialAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitInterstitialForBiddingWithUserId (this IISInterstitialAdapterProtocol This, string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsuserId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadInterstitialForBiddingWithAdapterConfig (this IISInterstitialAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, ISInterstitialAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			CFString.ReleaseNative (nsserverData);
		}
	}
	internal unsafe sealed class ISInterstitialAdapterProtocolWrapper : BaseWrapper, IISInterstitialAdapterProtocol {
		[Preserve (Conditional = true)]
		public ISInterstitialAdapterProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISInterstitialAdapterProtocol", true)]
	public unsafe partial class ISInterstitialAdapterProtocol : NSObject, IISInterstitialAdapterProtocol, IISAdUnitAdapterProtocol, IISNetworkInitCallbackProtocol, IISReleaseMemoryAdapterProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISInterstitialAdapterProtocol");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISInterstitialAdapterProtocol () : base (NSObjectFlag.Empty)
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
		protected ISInterstitialAdapterProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISInterstitialAdapterProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectInterstitialBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			}
		}
		[Export ("getInterstitialBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetInterstitialBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getInterstitialBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("getInterstitialBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
			}
		}
		[Export ("hasInterstitialWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasInterstitialWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			byte ret;
			if (IsDirectBinding) {
				ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasInterstitialWithAdapterConfig:"), adapterConfig__handle__);
			} else {
				ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("hasInterstitialWithAdapterConfig:"), adapterConfig__handle__);
			}
			return ret != 0;
		}
		[Export ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitInterstitialForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("initInterstitialWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitInterstitialWithUserId (string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initInterstitialWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initInterstitialWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			}
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadInterstitialForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, ISInterstitialAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, @delegate__handle__);
			}
			CFString.ReleaseNative (nsserverData);
		}
		[Export ("loadInterstitialWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadInterstitialWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISInterstitialAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadInterstitialWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadInterstitialWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
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
		[Export ("showInterstitialWithViewController:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowInterstitialWithViewController (global::UIKit.UIViewController viewController, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showInterstitialWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("showInterstitialWithViewController:adapterConfig:delegate:"), viewController__handle__, adapterConfig__handle__, @delegate__handle__);
			}
		}
	} /* class ISInterstitialAdapterProtocol */
}
