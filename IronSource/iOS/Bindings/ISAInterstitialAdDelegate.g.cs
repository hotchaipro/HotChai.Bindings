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
	[Protocol (Name = "ISAInterstitialAdDelegate", WrapperType = typeof (ISAInterstitialAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialAdDidShow", Selector = "interstitialAdDidShow:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAInterstitialAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialAd", Selector = "interstitialAd:didFailToShowWithError:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAInterstitialAd), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialAdDidClick", Selector = "interstitialAdDidClick:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAInterstitialAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialAdDidDismiss", Selector = "interstitialAdDidDismiss:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAInterstitialAd) }, ParameterByRef = new bool [] { false })]
	public partial interface IISAInterstitialAdDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialAdDidShow:")]
		[Preserve (Conditional = true)]
		void InterstitialAdDidShow (ISAInterstitialAd interstitialAd);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialAd:didFailToShowWithError:")]
		[Preserve (Conditional = true)]
		void InterstitialAd (ISAInterstitialAd interstitialAd, NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialAdDidClick:")]
		[Preserve (Conditional = true)]
		void InterstitialAdDidClick (ISAInterstitialAd interstitialAd);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialAdDidDismiss:")]
		[Preserve (Conditional = true)]
		void InterstitialAdDidDismiss (ISAInterstitialAd interstitialAd);
	}
	internal unsafe sealed class ISAInterstitialAdDelegateWrapper : BaseWrapper, IISAInterstitialAdDelegate {
		[Preserve (Conditional = true)]
		public ISAInterstitialAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("interstitialAdDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialAdDidShow (ISAInterstitialAd interstitialAd)
		{
			var interstitialAd__handle__ = interstitialAd!.GetNonNullHandle (nameof (interstitialAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialAdDidShow:"), interstitialAd__handle__);
		}
		[Export ("interstitialAd:didFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialAd (ISAInterstitialAd interstitialAd, NSError error)
		{
			var interstitialAd__handle__ = interstitialAd!.GetNonNullHandle (nameof (interstitialAd));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("interstitialAd:didFailToShowWithError:"), interstitialAd__handle__, error__handle__);
		}
		[Export ("interstitialAdDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialAdDidClick (ISAInterstitialAd interstitialAd)
		{
			var interstitialAd__handle__ = interstitialAd!.GetNonNullHandle (nameof (interstitialAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialAdDidClick:"), interstitialAd__handle__);
		}
		[Export ("interstitialAdDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialAdDidDismiss (ISAInterstitialAd interstitialAd)
		{
			var interstitialAd__handle__ = interstitialAd!.GetNonNullHandle (nameof (interstitialAd));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialAdDidDismiss:"), interstitialAd__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISAInterstitialAdDelegate", false)]
	[Model]
	public unsafe abstract partial class ISAInterstitialAdDelegate : NSObject, IISAInterstitialAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISAInterstitialAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAInterstitialAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAInterstitialAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("interstitialAd:didFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialAd (ISAInterstitialAd interstitialAd, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialAdDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialAdDidClick (ISAInterstitialAd interstitialAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialAdDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialAdDidDismiss (ISAInterstitialAd interstitialAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialAdDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialAdDidShow (ISAInterstitialAd interstitialAd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISAInterstitialAdDelegate */
}
