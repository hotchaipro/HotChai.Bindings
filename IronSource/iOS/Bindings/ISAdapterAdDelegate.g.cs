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
	[Protocol (Name = "ISAdapterAdDelegate", WrapperType = typeof (ISAdapterAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdDidLoad", Selector = "adDidLoad")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdDidFailToLoadWithErrorType", Selector = "adDidFailToLoadWithErrorType:errorCode:errorMessage:", ParameterType = new Type [] { typeof (IronSourceSdk.ISAdapterErrorType), typeof (IntPtr), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdDidOpen", Selector = "adDidOpen")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdDidFailToShowWithErrorCode", Selector = "adDidFailToShowWithErrorCode:errorMessage:", ParameterType = new Type [] { typeof (IntPtr), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdDidClick", Selector = "adDidClick")]
	public partial interface IISAdapterAdDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adDidLoad")]
		[Preserve (Conditional = true)]
		void AdDidLoad ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adDidFailToLoadWithErrorType:errorCode:errorMessage:")]
		[Preserve (Conditional = true)]
		void AdDidFailToLoadWithErrorType (ISAdapterErrorType errorType, nint errorCode, string? errorMessage);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adDidOpen")]
		[Preserve (Conditional = true)]
		void AdDidOpen ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adDidFailToShowWithErrorCode:errorMessage:")]
		[Preserve (Conditional = true)]
		void AdDidFailToShowWithErrorCode (nint errorCode, string? errorMessage);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adDidClick")]
		[Preserve (Conditional = true)]
		void AdDidClick ();
	}
	internal unsafe sealed class ISAdapterAdDelegateWrapper : BaseWrapper, IISAdapterAdDelegate {
		[Preserve (Conditional = true)]
		public ISAdapterAdDelegateWrapper (NativeHandle handle, bool owns)
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
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISAdapterAdDelegate", false)]
	[Model]
	public unsafe abstract partial class ISAdapterAdDelegate : NSObject, IISAdapterAdDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISAdapterAdDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAdapterAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAdapterAdDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdDidClick ()
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
	} /* class ISAdapterAdDelegate */
}
