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
	[Protocol (Name = "ISDemandOnlyBannerDelegate", WrapperType = typeof (ISDemandOnlyBannerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BannerDidLoad", Selector = "bannerDidLoad:instanceId:", ParameterType = new Type [] { typeof (IronSourceSdk.ISDemandOnlyBannerView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BannerDidFailToLoadWithError", Selector = "bannerDidFailToLoadWithError:instanceId:", ParameterType = new Type [] { typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BannerDidShow", Selector = "bannerDidShow:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidClickBanner", Selector = "didClickBanner:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BannerWillLeaveApplication", Selector = "bannerWillLeaveApplication:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface IISDemandOnlyBannerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("bannerDidLoad:instanceId:")]
		[Preserve (Conditional = true)]
		void BannerDidLoad (ISDemandOnlyBannerView bannerView, string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("bannerDidFailToLoadWithError:instanceId:")]
		[Preserve (Conditional = true)]
		void BannerDidFailToLoadWithError (NSError error, string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("bannerDidShow:")]
		[Preserve (Conditional = true)]
		void BannerDidShow (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("didClickBanner:")]
		[Preserve (Conditional = true)]
		void DidClickBanner (string instanceId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("bannerWillLeaveApplication:")]
		[Preserve (Conditional = true)]
		void BannerWillLeaveApplication (string instanceId);
	}
	internal unsafe sealed class ISDemandOnlyBannerDelegateWrapper : BaseWrapper, IISDemandOnlyBannerDelegate {
		[Preserve (Conditional = true)]
		public ISDemandOnlyBannerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("bannerDidLoad:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BannerDidLoad (ISDemandOnlyBannerView bannerView, string instanceId)
		{
			var bannerView__handle__ = bannerView!.GetNonNullHandle (nameof (bannerView));
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("bannerDidLoad:instanceId:"), bannerView__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("bannerDidFailToLoadWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BannerDidFailToLoadWithError (NSError error, string instanceId)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("bannerDidFailToLoadWithError:instanceId:"), error__handle__, nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("bannerDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BannerDidShow (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("bannerDidShow:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("didClickBanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidClickBanner (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didClickBanner:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
		[Export ("bannerWillLeaveApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BannerWillLeaveApplication (string instanceId)
		{
			if (instanceId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (instanceId));
			var nsinstanceId = CFString.CreateNative (instanceId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("bannerWillLeaveApplication:"), nsinstanceId);
			CFString.ReleaseNative (nsinstanceId);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISDemandOnlyBannerDelegate", false)]
	[Model]
	public unsafe abstract partial class ISDemandOnlyBannerDelegate : NSObject, IISDemandOnlyBannerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISDemandOnlyBannerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISDemandOnlyBannerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISDemandOnlyBannerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("bannerDidFailToLoadWithError:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BannerDidFailToLoadWithError (NSError error, string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerDidLoad:instanceId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BannerDidLoad (ISDemandOnlyBannerView bannerView, string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BannerDidShow (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerWillLeaveApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BannerWillLeaveApplication (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didClickBanner:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidClickBanner (string instanceId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISDemandOnlyBannerDelegate */
}
