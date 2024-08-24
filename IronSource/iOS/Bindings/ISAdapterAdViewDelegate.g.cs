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
	[Protocol (Name = "ISAdapterAdViewDelegate", WrapperType = typeof (ISAdapterAdViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdDidLoadWithView", Selector = "adDidLoadWithView:", ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdWillLeaveApplication", Selector = "adWillLeaveApplication")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdWillPresentScreen", Selector = "adWillPresentScreen")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdDidDismissScreen", Selector = "adDidDismissScreen")]
	public partial interface IISAdapterAdViewDelegate : INativeObject, IDisposable, 
		IronSourceSdk.IISAdapterAdDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adDidLoadWithView:")]
		[Preserve (Conditional = true)]
		void AdDidLoadWithView (global::UIKit.UIView view);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adWillLeaveApplication")]
		[Preserve (Conditional = true)]
		void AdWillLeaveApplication ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adWillPresentScreen")]
		[Preserve (Conditional = true)]
		void AdWillPresentScreen ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adDidDismissScreen")]
		[Preserve (Conditional = true)]
		void AdDidDismissScreen ();
	}
	internal unsafe sealed class ISAdapterAdViewDelegateWrapper : BaseWrapper, IISAdapterAdViewDelegate {
		[Preserve (Conditional = true)]
		public ISAdapterAdViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adDidLoadWithView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidLoadWithView (global::UIKit.UIView view)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adDidLoadWithView:"), view__handle__);
		}
		[Export ("adWillLeaveApplication")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdWillLeaveApplication ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adWillLeaveApplication"));
		}
		[Export ("adWillPresentScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdWillPresentScreen ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adWillPresentScreen"));
		}
		[Export ("adDidDismissScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdDidDismissScreen ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adDidDismissScreen"));
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
	}
}
