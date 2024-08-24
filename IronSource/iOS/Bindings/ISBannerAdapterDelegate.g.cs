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
	[Protocol (Name = "ISBannerAdapterDelegate", WrapperType = typeof (ISBannerAdapterDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerInitSuccess", Selector = "adapterBannerInitSuccess")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerInitFailedWithError", Selector = "adapterBannerInitFailedWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerDidLoad", Selector = "adapterBannerDidLoad:", ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerDidFailToLoadWithError", Selector = "adapterBannerDidFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerDidClick", Selector = "adapterBannerDidClick")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerWillPresentScreen", Selector = "adapterBannerWillPresentScreen")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerDidDismissScreen", Selector = "adapterBannerDidDismissScreen")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerWillLeaveApplication", Selector = "adapterBannerWillLeaveApplication")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerDidShow", Selector = "adapterBannerDidShow")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterBannerDidFailToShowWithError", Selector = "adapterBannerDidFailToShowWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public partial interface IISBannerAdapterDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerInitSuccess")]
		[Preserve (Conditional = true)]
		void AdapterBannerInitSuccess ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerInitFailedWithError:")]
		[Preserve (Conditional = true)]
		void AdapterBannerInitFailedWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerDidLoad:")]
		[Preserve (Conditional = true)]
		void AdapterBannerDidLoad (global::UIKit.UIView bannerView);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerDidFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void AdapterBannerDidFailToLoadWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerDidClick")]
		[Preserve (Conditional = true)]
		void AdapterBannerDidClick ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerWillPresentScreen")]
		[Preserve (Conditional = true)]
		void AdapterBannerWillPresentScreen ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerDidDismissScreen")]
		[Preserve (Conditional = true)]
		void AdapterBannerDidDismissScreen ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerWillLeaveApplication")]
		[Preserve (Conditional = true)]
		void AdapterBannerWillLeaveApplication ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerDidShow")]
		[Preserve (Conditional = true)]
		void AdapterBannerDidShow ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterBannerDidFailToShowWithError:")]
		[Preserve (Conditional = true)]
		void AdapterBannerDidFailToShowWithError (NSError error);
	}
	internal unsafe sealed class ISBannerAdapterDelegateWrapper : BaseWrapper, IISBannerAdapterDelegate {
		[Preserve (Conditional = true)]
		public ISBannerAdapterDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adapterBannerInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerInitSuccess ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterBannerInitSuccess"));
		}
		[Export ("adapterBannerInitFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerInitFailedWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterBannerInitFailedWithError:"), error__handle__);
		}
		[Export ("adapterBannerDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerDidLoad (global::UIKit.UIView bannerView)
		{
			var bannerView__handle__ = bannerView!.GetNonNullHandle (nameof (bannerView));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterBannerDidLoad:"), bannerView__handle__);
		}
		[Export ("adapterBannerDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerDidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterBannerDidFailToLoadWithError:"), error__handle__);
		}
		[Export ("adapterBannerDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerDidClick ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterBannerDidClick"));
		}
		[Export ("adapterBannerWillPresentScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerWillPresentScreen ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterBannerWillPresentScreen"));
		}
		[Export ("adapterBannerDidDismissScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerDidDismissScreen ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterBannerDidDismissScreen"));
		}
		[Export ("adapterBannerWillLeaveApplication")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerWillLeaveApplication ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterBannerWillLeaveApplication"));
		}
		[Export ("adapterBannerDidShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerDidShow ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterBannerDidShow"));
		}
		[Export ("adapterBannerDidFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterBannerDidFailToShowWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterBannerDidFailToShowWithError:"), error__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISBannerAdapterDelegate", false)]
	[Model]
	public unsafe abstract partial class ISBannerAdapterDelegate : NSObject, IISBannerAdapterDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISBannerAdapterDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISBannerAdapterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBannerAdapterDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adapterBannerDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerDidClick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerDidDismissScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerDidDismissScreen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerDidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerDidFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerDidFailToShowWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerDidLoad:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerDidLoad (global::UIKit.UIView bannerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerDidShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerDidShow ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerInitFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerInitFailedWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerInitSuccess ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerWillLeaveApplication")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerWillLeaveApplication ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterBannerWillPresentScreen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterBannerWillPresentScreen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISBannerAdapterDelegate */
}
