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
	[Protocol (Name = "ISNativeAdAdapterDelegate", WrapperType = typeof (ISNativeAdAdapterDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterNativeAdInitSuccess", Selector = "adapterNativeAdInitSuccess")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterNativeAdInitFailedWithError", Selector = "adapterNativeAdInitFailedWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterNativeAdDidLoadWithAdData", Selector = "adapterNativeAdDidLoadWithAdData:adViewBinder:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterNativeAdData), typeof (IronSourceSdk.ISAdapterNativeAdViewBinder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterNativeAdDidFailToLoadWithError", Selector = "adapterNativeAdDidFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterNativeAdDidShow", Selector = "adapterNativeAdDidShow")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterNativeAdDidClick", Selector = "adapterNativeAdDidClick")]
	public partial interface IISNativeAdAdapterDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterNativeAdInitSuccess")]
		[Preserve (Conditional = true)]
		void AdapterNativeAdInitSuccess ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterNativeAdInitFailedWithError:")]
		[Preserve (Conditional = true)]
		void AdapterNativeAdInitFailedWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterNativeAdDidLoadWithAdData:adViewBinder:")]
		[Preserve (Conditional = true)]
		void AdapterNativeAdDidLoadWithAdData (ISAdapterNativeAdData adapterNativeAdData, ISAdapterNativeAdViewBinder nativeAdViewBinder);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterNativeAdDidFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void AdapterNativeAdDidFailToLoadWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterNativeAdDidShow")]
		[Preserve (Conditional = true)]
		void AdapterNativeAdDidShow ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterNativeAdDidClick")]
		[Preserve (Conditional = true)]
		void AdapterNativeAdDidClick ();
	}
	internal unsafe sealed class ISNativeAdAdapterDelegateWrapper : BaseWrapper, IISNativeAdAdapterDelegate {
		[Preserve (Conditional = true)]
		public ISNativeAdAdapterDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adapterNativeAdInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterNativeAdInitSuccess ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterNativeAdInitSuccess"));
		}
		[Export ("adapterNativeAdInitFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterNativeAdInitFailedWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterNativeAdInitFailedWithError:"), error__handle__);
		}
		[Export ("adapterNativeAdDidLoadWithAdData:adViewBinder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterNativeAdDidLoadWithAdData (ISAdapterNativeAdData adapterNativeAdData, ISAdapterNativeAdViewBinder nativeAdViewBinder)
		{
			var adapterNativeAdData__handle__ = adapterNativeAdData!.GetNonNullHandle (nameof (adapterNativeAdData));
			var nativeAdViewBinder__handle__ = nativeAdViewBinder!.GetNonNullHandle (nameof (nativeAdViewBinder));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("adapterNativeAdDidLoadWithAdData:adViewBinder:"), adapterNativeAdData__handle__, nativeAdViewBinder__handle__);
		}
		[Export ("adapterNativeAdDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterNativeAdDidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterNativeAdDidFailToLoadWithError:"), error__handle__);
		}
		[Export ("adapterNativeAdDidShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterNativeAdDidShow ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterNativeAdDidShow"));
		}
		[Export ("adapterNativeAdDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterNativeAdDidClick ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterNativeAdDidClick"));
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISNativeAdAdapterDelegate", false)]
	[Model]
	public unsafe abstract partial class ISNativeAdAdapterDelegate : NSObject, IISNativeAdAdapterDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISNativeAdAdapterDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISNativeAdAdapterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISNativeAdAdapterDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adapterNativeAdDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterNativeAdDidClick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterNativeAdDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterNativeAdDidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterNativeAdDidLoadWithAdData:adViewBinder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterNativeAdDidLoadWithAdData (ISAdapterNativeAdData adapterNativeAdData, ISAdapterNativeAdViewBinder nativeAdViewBinder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterNativeAdDidShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterNativeAdDidShow ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterNativeAdInitFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterNativeAdInitFailedWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterNativeAdInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterNativeAdInitSuccess ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISNativeAdAdapterDelegate */
}
