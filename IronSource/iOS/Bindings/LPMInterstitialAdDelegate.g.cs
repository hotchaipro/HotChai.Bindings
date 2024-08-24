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
	[Protocol (Name = "LPMInterstitialAdDelegate", WrapperType = typeof (LPMInterstitialAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidLoadAdWithAdInfo", Selector = "didLoadAdWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.LPMAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailToLoadAdWithAdUnitId", Selector = "didFailToLoadAdWithAdUnitId:error:", ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDisplayAdWithAdInfo", Selector = "didDisplayAdWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.LPMAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToDisplayAdWithAdInfo", Selector = "didFailToDisplayAdWithAdInfo:error:", ParameterType = new Type [] { typeof (IronSourceSdk.LPMAdInfo), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClickAdWithAdInfo", Selector = "didClickAdWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.LPMAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCloseAdWithAdInfo", Selector = "didCloseAdWithAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.LPMAdInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeAdInfo", Selector = "didChangeAdInfo:", ParameterType = new Type [] { typeof (IronSourceSdk.LPMAdInfo) }, ParameterByRef = new bool [] { false })]
	public partial interface ILPMInterstitialAdDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didLoadAdWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidLoadAdWithAdInfo (LPMAdInfo adInfo);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didFailToLoadAdWithAdUnitId:error:")]
		[Preserve (Conditional = true)]
		void DidFailToLoadAdWithAdUnitId (string adUnitId, NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didDisplayAdWithAdInfo:")]
		[Preserve (Conditional = true)]
		void DidDisplayAdWithAdInfo (LPMAdInfo adInfo);
	}
	public unsafe static partial class LPMInterstitialAdDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToDisplayAdWithAdInfo (this ILPMInterstitialAdDelegate This, LPMAdInfo adInfo, NSError error)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailToDisplayAdWithAdInfo:error:"), adInfo__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidClickAdWithAdInfo (this ILPMInterstitialAdDelegate This, LPMAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didClickAdWithAdInfo:"), adInfo__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCloseAdWithAdInfo (this ILPMInterstitialAdDelegate This, LPMAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didCloseAdWithAdInfo:"), adInfo__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeAdInfo (this ILPMInterstitialAdDelegate This, LPMAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didChangeAdInfo:"), adInfo__handle__);
		}
	}
	internal unsafe sealed class LPMInterstitialAdDelegateWrapper : BaseWrapper, ILPMInterstitialAdDelegate {
		[Preserve (Conditional = true)]
		public LPMInterstitialAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("didLoadAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidLoadAdWithAdInfo (LPMAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didLoadAdWithAdInfo:"), adInfo__handle__);
		}
		[Export ("didFailToLoadAdWithAdUnitId:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailToLoadAdWithAdUnitId (string adUnitId, NSError error)
		{
			if (adUnitId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnitId));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsadUnitId = CFString.CreateNative (adUnitId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didFailToLoadAdWithAdUnitId:error:"), nsadUnitId, error__handle__);
			CFString.ReleaseNative (nsadUnitId);
		}
		[Export ("didDisplayAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDisplayAdWithAdInfo (LPMAdInfo adInfo)
		{
			var adInfo__handle__ = adInfo!.GetNonNullHandle (nameof (adInfo));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didDisplayAdWithAdInfo:"), adInfo__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_LPMInterstitialAdDelegate", false)]
	[Model]
	public unsafe abstract partial class LPMInterstitialAdDelegate : NSObject, ILPMInterstitialAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected LPMInterstitialAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPMInterstitialAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPMInterstitialAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didChangeAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAdInfo (LPMAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didClickAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickAdWithAdInfo (LPMAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didCloseAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCloseAdWithAdInfo (LPMAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didDisplayAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisplayAdWithAdInfo (LPMAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToDisplayAdWithAdInfo:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToDisplayAdWithAdInfo (LPMAdInfo adInfo, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToLoadAdWithAdUnitId:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLoadAdWithAdUnitId (string adUnitId, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didLoadAdWithAdInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidLoadAdWithAdInfo (LPMAdInfo adInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class LPMInterstitialAdDelegate */
}
