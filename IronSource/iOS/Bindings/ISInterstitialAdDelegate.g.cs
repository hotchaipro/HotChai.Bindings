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
	[Protocol (Name = "ISInterstitialAdDelegate", WrapperType = typeof (ISInterstitialAdDelegateWrapper))]
	public partial interface IISInterstitialAdDelegate : INativeObject, IDisposable, 
		IronSourceSdk.IISAdapterAdDelegate
		, IronSourceSdk.IISAdapterAdInteractionDelegate
	{
	}
	internal unsafe sealed class ISInterstitialAdDelegateWrapper : BaseWrapper, IISInterstitialAdDelegate {
		[Preserve (Conditional = true)]
		public ISInterstitialAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidLoad ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidLoad"));
		}
		[Export ("adDidFailToLoadWithErrorType:errorCode:errorMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidFailToLoadWithErrorType (ISAdapterErrorType errorType, nint errorCode, string? errorMessage)
		{
			var nserrorMessage = CFString.CreateNative (errorMessage);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("adDidFailToLoadWithErrorType:errorCode:errorMessage:"), (IntPtr) (long) errorType, errorCode, nserrorMessage);
			CFString.ReleaseNative (nserrorMessage);
		}
		[Export ("adDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidOpen ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidOpen"));
		}
		[Export ("adDidFailToShowWithErrorCode:errorMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidFailToShowWithErrorCode (nint errorCode, string? errorMessage)
		{
			var nserrorMessage = CFString.CreateNative (errorMessage);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("adDidFailToShowWithErrorCode:errorMessage:"), errorCode, nserrorMessage);
			CFString.ReleaseNative (nserrorMessage);
		}
		[Export ("adDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidClick ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidClick"));
		}
		[Export ("adDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidClose ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidClose"));
		}
		[Export ("adDidShowSucceed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidShowSucceed ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidShowSucceed"));
		}
		[Export ("adDidBecomeVisible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidBecomeVisible ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidBecomeVisible"));
		}
		[Export ("adDidStart")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidStart ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidStart"));
		}
		[Export ("adDidEnd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidEnd ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidEnd"));
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISInterstitialAdDelegate", false)]
	[Model]
	public unsafe partial class ISInterstitialAdDelegate : NSObject, IISInterstitialAdDelegate, IISAdapterAdDelegate, IISAdapterAdInteractionDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISInterstitialAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISInterstitialAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISInterstitialAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adDidBecomeVisible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidBecomeVisible ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidClick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidClose ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidEnd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidEnd ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidFailToLoadWithErrorType:errorCode:errorMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidFailToLoadWithErrorType (ISAdapterErrorType errorType, nint errorCode, string? errorMessage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidFailToShowWithErrorCode:errorMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidFailToShowWithErrorCode (nint errorCode, string? errorMessage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidLoad ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidOpen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidShowSucceed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidShowSucceed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidStart")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidStart ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISInterstitialAdDelegate */
}
