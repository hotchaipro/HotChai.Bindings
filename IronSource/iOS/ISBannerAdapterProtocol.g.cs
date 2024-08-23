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
	[Protocol (Name = "ISBannerAdapterProtocol", WrapperType = typeof (ISBannerAdapterProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DestroyBannerWithAdapterConfig", Selector = "destroyBannerWithAdapterConfig:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAdaptiveHeightWithWidth", Selector = "getAdaptiveHeightWithWidth:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (NFloat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitBannerWithUserId", Selector = "initBannerWithUserId:adapterConfig:delegate:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISAdapterConfig), typeof (IronSourceSdk.ISBannerAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadBannerWithAdapterConfig", Selector = "loadBannerWithAdapterConfig:adData:viewController:size:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (UIViewController), typeof (IronSourceSdk.ISBannerSize), typeof (IronSourceSdk.ISBannerAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetBannerBiddingDataWithAdapterConfig", Selector = "getBannerBiddingDataWithAdapterConfig:adData:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CollectBannerBiddingDataWithAdapterConfig", Selector = "collectBannerBiddingDataWithAdapterConfig:adData:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (IronSourceSdk.ISBiddingDataDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitBannerForBiddingWithUserId", Selector = "initBannerForBiddingWithUserId:adapterConfig:delegate:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISAdapterConfig), typeof (IronSourceSdk.ISBannerAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LoadBannerForBiddingWithAdapterConfig", Selector = "loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterConfig), typeof (NSDictionary), typeof (string), typeof (UIViewController), typeof (IronSourceSdk.ISBannerSize), typeof (IronSourceSdk.ISBannerAdapterDelegate) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	public partial interface IISBannerAdapterProtocol : INativeObject, IDisposable, 
		IronSourceSdk.IISAdUnitAdapterProtocol
		, IronSourceSdk.IISNetworkInitCallbackProtocol
		, IronSourceSdk.IISReleaseMemoryAdapterProtocol
	{
	}
	public unsafe static partial class ISBannerAdapterProtocol_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DestroyBannerWithAdapterConfig (this IISBannerAdapterProtocol This, ISAdapterConfig adapterConfig)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("destroyBannerWithAdapterConfig:"), adapterConfig__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetAdaptiveHeightWithWidth (this IISBannerAdapterProtocol This, nfloat width)
		{
			return global::IronSourceSdk.ApiDefinitions.Messaging.nfloat_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("getAdaptiveHeightWithWidth:"), width);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitBannerWithUserId (this IISBannerAdapterProtocol This, string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate)
		{
			if (userId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("initBannerWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsuserId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadBannerWithAdapterConfig (this IISBannerAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadBannerWithAdapterConfig:adData:viewController:size:delegate:"), adapterConfig__handle__, adData__handle__, viewController__handle__, size__handle__, @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetBannerBiddingDataWithAdapterConfig (this IISBannerAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			return  Runtime.GetNSObject<NSDictionary> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("getBannerBiddingDataWithAdapterConfig:adData:"), adapterConfig__handle__, adData__handle__))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CollectBannerBiddingDataWithAdapterConfig (this IISBannerAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collectBannerBiddingDataWithAdapterConfig:adData:delegate:"), adapterConfig__handle__, adData__handle__, @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitBannerForBiddingWithUserId (this IISBannerAdapterProtocol This, string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate)
		{
			if (userId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsuserId = CFString.CreateNative (userId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("initBannerForBiddingWithUserId:adapterConfig:delegate:"), nsuserId, adapterConfig__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsuserId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LoadBannerForBiddingWithAdapterConfig (this IISBannerAdapterProtocol This, ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate)
		{
			var adapterConfig__handle__ = adapterConfig!.GetNonNullHandle (nameof (adapterConfig));
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			if (serverData is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serverData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			var nsserverData = CFString.CreateNative (serverData);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:"), adapterConfig__handle__, adData__handle__, nsserverData, viewController__handle__, size__handle__, @delegate__handle__);
			CFString.ReleaseNative (nsserverData);
		}
	}
	internal unsafe sealed class ISBannerAdapterProtocolWrapper : BaseWrapper, IISBannerAdapterProtocol {
		[Preserve (Conditional = true)]
		public ISBannerAdapterProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISBannerAdapterProtocol", false)]
	[Model]
	public unsafe partial class ISBannerAdapterProtocol : NSObject, IISBannerAdapterProtocol, IISAdUnitAdapterProtocol, IISNetworkInitCallbackProtocol, IISReleaseMemoryAdapterProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBannerAdapterProtocol () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISBannerAdapterProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBannerAdapterProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("collectBannerBiddingDataWithAdapterConfig:adData:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CollectBannerBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("destroyBannerWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DestroyBannerWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("getAdaptiveHeightWithWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetAdaptiveHeightWithWidth (nfloat width)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("getBannerBiddingDataWithAdapterConfig:adData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetBannerBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("initBannerForBiddingWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitBannerForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("initBannerWithUserId:adapterConfig:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitBannerWithUserId (string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadBannerForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("loadBannerWithAdapterConfig:adData:viewController:size:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadBannerWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onNetworkInitCallbackFailed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnNetworkInitCallbackFailed (string errorMessage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onNetworkInitCallbackSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnNetworkInitCallbackSuccess ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("releaseMemoryWithAdapterConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReleaseMemoryWithAdapterConfig (ISAdapterConfig adapterConfig)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISBannerAdapterProtocol */
}
