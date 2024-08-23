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
	[Protocol (Name = "ISDemandOnlyInterstitialDelegate", WrapperType = typeof (ISDemandOnlyInterstitialDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialDidLoad", Selector = "interstitialDidLoad:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialDidFailToLoadWithError", Selector = "interstitialDidFailToLoadWithError:instanceId:", ParameterType = new Type [] { typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialDidOpen", Selector = "interstitialDidOpen:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialDidClose", Selector = "interstitialDidClose:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InterstitialDidFailToShowWithError", Selector = "interstitialDidFailToShowWithError:instanceId:", ParameterType = new Type [] { typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidClickInterstitial", Selector = "didClickInterstitial:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface IISDemandOnlyInterstitialDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialDidLoad:")]
		[Preserve (Conditional = true)]
		void InterstitialDidLoad (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialDidFailToLoadWithError:instanceId:")]
		[Preserve (Conditional = true)]
		void InterstitialDidFailToLoadWithError (NSError error, string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialDidOpen:")]
		[Preserve (Conditional = true)]
		void InterstitialDidOpen (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialDidClose:")]
		[Preserve (Conditional = true)]
		void InterstitialDidClose (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("interstitialDidFailToShowWithError:instanceId:")]
		[Preserve (Conditional = true)]
		void InterstitialDidFailToShowWithError (NSError error, string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didClickInterstitial:")]
		[Preserve (Conditional = true)]
		void DidClickInterstitial (string instanceId);
	}
	internal unsafe sealed class ISDemandOnlyInterstitialDelegateWrapper : BaseWrapper, IISDemandOnlyInterstitialDelegate {
		[Preserve (Conditional = true)]
		public ISDemandOnlyInterstitialDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("interstitialDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialDidLoad (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialDidLoad:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("interstitialDidFailToLoadWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialDidFailToLoadWithError (NSError error, string instanceId)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("interstitialDidFailToLoadWithError:instanceId:"), error__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("interstitialDidOpen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialDidOpen (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialDidOpen:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("interstitialDidClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialDidClose (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("interstitialDidClose:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("interstitialDidFailToShowWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InterstitialDidFailToShowWithError (NSError error, string instanceId)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("interstitialDidFailToShowWithError:instanceId:"), error__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("didClickInterstitial:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidClickInterstitial (string instanceId)
		{
			if (instanceId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didClickInterstitial:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISDemandOnlyInterstitialDelegate", false)]
	[Model]
	public unsafe abstract partial class ISDemandOnlyInterstitialDelegate : NSObject, IISDemandOnlyInterstitialDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISDemandOnlyInterstitialDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISDemandOnlyInterstitialDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISDemandOnlyInterstitialDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didClickInterstitial:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickInterstitial (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialDidClose:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialDidClose (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialDidFailToLoadWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialDidFailToLoadWithError (NSError error, string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialDidFailToShowWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialDidFailToShowWithError (NSError error, string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialDidLoad (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("interstitialDidOpen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InterstitialDidOpen (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISDemandOnlyInterstitialDelegate */
}
