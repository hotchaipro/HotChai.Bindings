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
	[Protocol (Name = "ISAInterstitialAdLoaderDelegate", WrapperType = typeof (ISAInterstitialAdLoaderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialAdDidLoad", Selector = "interstitialAdDidLoad:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAInterstitialAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialAdDidFailToLoadWithError", Selector = "interstitialAdDidFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public partial interface IISAInterstitialAdLoaderDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialAdDidLoad:")]
		[Preserve (Conditional = true)]
		void InterstitialAdDidLoad (ISAInterstitialAd interstitialAd);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialAdDidFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void InterstitialAdDidFailToLoadWithError (NSError error);
	}
	internal unsafe sealed class ISAInterstitialAdLoaderDelegateWrapper : BaseWrapper, IISAInterstitialAdLoaderDelegate {
		[Preserve (Conditional = true)]
		public ISAInterstitialAdLoaderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("interstitialAdDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialAdDidLoad (ISAInterstitialAd interstitialAd)
		{
			var interstitialAd__handle__ = interstitialAd!.GetNonNullHandle (nameof (interstitialAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialAdDidLoad:"), interstitialAd__handle__);
		}
		[Export ("interstitialAdDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialAdDidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialAdDidFailToLoadWithError:"), error__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISAInterstitialAdLoaderDelegate", false)]
	[Model]
	public unsafe abstract partial class ISAInterstitialAdLoaderDelegate : NSObject, IISAInterstitialAdLoaderDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISAInterstitialAdLoaderDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAInterstitialAdLoaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAInterstitialAdLoaderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("interstitialAdDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialAdDidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialAdDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialAdDidLoad (ISAInterstitialAd interstitialAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISAInterstitialAdLoaderDelegate */
}
