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
	[Protocol (Name = "ISBannerAdDelegate", WrapperType = typeof (ISBannerAdDelegateWrapper))]
	public partial interface IISBannerAdDelegate : INativeObject, IDisposable, 
		IronSourceSdk.IISAdapterAdDelegate
		, IronSourceSdk.IISAdapterAdViewDelegate
	{
	}
	internal unsafe sealed class ISBannerAdDelegateWrapper : BaseWrapper, IISBannerAdDelegate {
		[Preserve (Conditional = true)]
		public ISBannerAdDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidLoad ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidLoad"));
		}
		[Export ("adDidFailToLoadWithErrorType:errorCode:errorMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidFailToLoadWithErrorType (ISAdapterErrorType errorType, nint errorCode, string? errorMessage)
		{
			var nserrorMessage = CFString.CreateNative (errorMessage);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("adDidFailToLoadWithErrorType:errorCode:errorMessage:"), (IntPtr) (long) errorType, errorCode, nserrorMessage);
			CFString.ReleaseNative (nserrorMessage);
		}
		[Export ("adDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidOpen ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidOpen"));
		}
		[Export ("adDidFailToShowWithErrorCode:errorMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidFailToShowWithErrorCode (nint errorCode, string? errorMessage)
		{
			var nserrorMessage = CFString.CreateNative (errorMessage);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("adDidFailToShowWithErrorCode:errorMessage:"), errorCode, nserrorMessage);
			CFString.ReleaseNative (nserrorMessage);
		}
		[Export ("adDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidClick ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidClick"));
		}
		[Export ("adDidLoadWithView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidLoadWithView (global::UIKit.UIView view)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adDidLoadWithView:"), view__handle__);
		}
		[Export ("adWillLeaveApplication")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdWillLeaveApplication ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adWillLeaveApplication"));
		}
		[Export ("adWillPresentScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdWillPresentScreen ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adWillPresentScreen"));
		}
		[Export ("adDidDismissScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidDismissScreen ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidDismissScreen"));
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISBannerAdDelegate", false)]
	[Model]
	public unsafe partial class ISBannerAdDelegate : NSObject, IISBannerAdDelegate, IISAdapterAdDelegate, IISAdapterAdViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBannerAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISBannerAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBannerAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidClick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidDismissScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidDismissScreen ()
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
		[Export ("adDidLoadWithView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidLoadWithView (global::UIKit.UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidOpen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adWillLeaveApplication")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdWillLeaveApplication ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adWillPresentScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdWillPresentScreen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISBannerAdDelegate */
}
