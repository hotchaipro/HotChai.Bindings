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
	[Protocol (Name = "ISAdapterBannerProtocol", WrapperType = typeof (ISAdapterBannerProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadAdWithAdData", Selector = "loadAdWithAdData:viewController:size:delegate:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdData), typeof (UIViewController), typeof (IronSourceSdk.ISBannerSize), typeof (IronSourceSdk.ISBannerAdDelegate) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DestroyAdWithAdData", Selector = "destroyAdWithAdData:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsSupportAdaptiveBanner", Selector = "isSupportAdaptiveBanner", PropertyType = typeof (bool), GetterSelector = "isSupportAdaptiveBanner", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IISAdapterBannerProtocol : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("loadAdWithAdData:viewController:size:delegate:")]
		[Preserve (Conditional = true)]
		void LoadAdWithAdData (ISAdData adData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdDelegate @delegate);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("destroyAdWithAdData:")]
		[Preserve (Conditional = true)]
		void DestroyAdWithAdData (ISAdData adData);
		[Preserve (Conditional = true)]
		bool IsSupportAdaptiveBanner {
			[Export ("isSupportAdaptiveBanner")]
			get;
		}
	}
	internal unsafe sealed class ISAdapterBannerProtocolWrapper : BaseWrapper, IISAdapterBannerProtocol {
		[Preserve (Conditional = true)]
		public ISAdapterBannerProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("loadAdWithAdData:viewController:size:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void LoadAdWithAdData (ISAdData adData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdDelegate @delegate)
		{
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var size__handle__ = size!.GetNonNullHandle (nameof (size));
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadAdWithAdData:viewController:size:delegate:"), adData__handle__, viewController__handle__, size__handle__, @delegate__handle__);
		}
		[Export ("destroyAdWithAdData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DestroyAdWithAdData (ISAdData adData)
		{
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("destroyAdWithAdData:"), adData__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsSupportAdaptiveBanner {
			[Export ("isSupportAdaptiveBanner")]
			get {
				byte ret;
				ret = ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSupportAdaptiveBanner"));
				return ret != 0;
			}
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISAdapterBannerProtocol", false)]
	[Model]
	public unsafe abstract partial class ISAdapterBannerProtocol : NSObject, IISAdapterBannerProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISAdapterBannerProtocol () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAdapterBannerProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAdapterBannerProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("destroyAdWithAdData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DestroyAdWithAdData (ISAdData adData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("loadAdWithAdData:viewController:size:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadAdWithAdData (ISAdData adData, global::UIKit.UIViewController viewController, ISBannerSize size, ISBannerAdDelegate @delegate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSupportAdaptiveBanner {
			[Export ("isSupportAdaptiveBanner")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class ISAdapterBannerProtocol */
}
