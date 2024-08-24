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
	[Protocol (Name = "ISConsentViewDelegate", WrapperType = typeof (ISConsentViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConsentViewDidLoadSuccess", Selector = "consentViewDidLoadSuccess:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConsentViewDidFailToLoadWithError", Selector = "consentViewDidFailToLoadWithError:consentViewType:", ParameterType = new Type [] { typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConsentViewDidShowSuccess", Selector = "consentViewDidShowSuccess:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConsentViewDidFailToShowWithError", Selector = "consentViewDidFailToShowWithError:consentViewType:", ParameterType = new Type [] { typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConsentViewDidAccept", Selector = "consentViewDidAccept:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConsentViewDidDismiss", Selector = "consentViewDidDismiss:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface IISConsentViewDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("consentViewDidLoadSuccess:")]
		[Preserve (Conditional = true)]
		void ConsentViewDidLoadSuccess (string consentViewType);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("consentViewDidFailToLoadWithError:consentViewType:")]
		[Preserve (Conditional = true)]
		void ConsentViewDidFailToLoadWithError (NSError error, string consentViewType);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("consentViewDidShowSuccess:")]
		[Preserve (Conditional = true)]
		void ConsentViewDidShowSuccess (string consentViewType);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("consentViewDidFailToShowWithError:consentViewType:")]
		[Preserve (Conditional = true)]
		void ConsentViewDidFailToShowWithError (NSError error, string consentViewType);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("consentViewDidAccept:")]
		[Preserve (Conditional = true)]
		void ConsentViewDidAccept (string consentViewType);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("consentViewDidDismiss:")]
		[Preserve (Conditional = true)]
		void ConsentViewDidDismiss (string consentViewType);
	}
	internal unsafe sealed class ISConsentViewDelegateWrapper : BaseWrapper, IISConsentViewDelegate {
		[Preserve (Conditional = true)]
		public ISConsentViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("consentViewDidLoadSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConsentViewDidLoadSuccess (string consentViewType)
		{
			if (consentViewType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("consentViewDidLoadSuccess:"), nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
		[Export ("consentViewDidFailToLoadWithError:consentViewType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConsentViewDidFailToLoadWithError (NSError error, string consentViewType)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (consentViewType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("consentViewDidFailToLoadWithError:consentViewType:"), error__handle__, nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
		[Export ("consentViewDidShowSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConsentViewDidShowSuccess (string consentViewType)
		{
			if (consentViewType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("consentViewDidShowSuccess:"), nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
		[Export ("consentViewDidFailToShowWithError:consentViewType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConsentViewDidFailToShowWithError (NSError error, string consentViewType)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (consentViewType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("consentViewDidFailToShowWithError:consentViewType:"), error__handle__, nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
		[Export ("consentViewDidAccept:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConsentViewDidAccept (string consentViewType)
		{
			if (consentViewType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("consentViewDidAccept:"), nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
		[Export ("consentViewDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ConsentViewDidDismiss (string consentViewType)
		{
			if (consentViewType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (consentViewType));
			var nsconsentViewType = CFString.CreateNative (consentViewType);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("consentViewDidDismiss:"), nsconsentViewType);
			CFString.ReleaseNative (nsconsentViewType);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISConsentViewDelegate", false)]
	[Model]
	public unsafe abstract partial class ISConsentViewDelegate : NSObject, IISConsentViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISConsentViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISConsentViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISConsentViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("consentViewDidAccept:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConsentViewDidAccept (string consentViewType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("consentViewDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConsentViewDidDismiss (string consentViewType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("consentViewDidFailToLoadWithError:consentViewType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConsentViewDidFailToLoadWithError (NSError error, string consentViewType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("consentViewDidFailToShowWithError:consentViewType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConsentViewDidFailToShowWithError (NSError error, string consentViewType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("consentViewDidLoadSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConsentViewDidLoadSuccess (string consentViewType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("consentViewDidShowSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConsentViewDidShowSuccess (string consentViewType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISConsentViewDelegate */
}
