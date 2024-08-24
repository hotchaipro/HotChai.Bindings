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
	[Protocol (Name = "ISRewardedVideoAdapterDelegate", WrapperType = typeof (ISRewardedVideoAdapterDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoHasChangedAvailability", Selector = "adapterRewardedVideoHasChangedAvailability:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidFailToLoadWithError", Selector = "adapterRewardedVideoDidFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidReceiveReward", Selector = "adapterRewardedVideoDidReceiveReward")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidFailToShowWithError", Selector = "adapterRewardedVideoDidFailToShowWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidOpen", Selector = "adapterRewardedVideoDidOpen")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidClose", Selector = "adapterRewardedVideoDidClose")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidLoad", Selector = "adapterRewardedVideoDidLoad")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidClick", Selector = "adapterRewardedVideoDidClick")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidStart", Selector = "adapterRewardedVideoDidStart")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidEnd", Selector = "adapterRewardedVideoDidEnd")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoInitSuccess", Selector = "adapterRewardedVideoInitSuccess")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoInitFailed", Selector = "adapterRewardedVideoInitFailed:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterRewardedVideoDidBecomeVisible", Selector = "adapterRewardedVideoDidBecomeVisible")]
	public partial interface IISRewardedVideoAdapterDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoHasChangedAvailability:")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoHasChangedAvailability (bool available);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidFailToLoadWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidReceiveReward")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidReceiveReward ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidFailToShowWithError:")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidFailToShowWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidOpen")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidOpen ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidClose")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidClose ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidLoad")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidLoad ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidClick")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidClick ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidStart")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidStart ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidEnd")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidEnd ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoInitSuccess")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoInitSuccess ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoInitFailed:")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoInitFailed (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterRewardedVideoDidBecomeVisible")]
		[Preserve (Conditional = true)]
		void AdapterRewardedVideoDidBecomeVisible ();
	}
	internal unsafe sealed class ISRewardedVideoAdapterDelegateWrapper : BaseWrapper, IISRewardedVideoAdapterDelegate {
		[Preserve (Conditional = true)]
		public ISRewardedVideoAdapterDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adapterRewardedVideoHasChangedAvailability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoHasChangedAvailability (bool available)
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("adapterRewardedVideoHasChangedAvailability:"), available ? (byte) 1 : (byte) 0);
		}
		[Export ("adapterRewardedVideoDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidFailToLoadWithError:"), error__handle__);
		}
		[Export ("adapterRewardedVideoDidReceiveReward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidReceiveReward ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidReceiveReward"));
		}
		[Export ("adapterRewardedVideoDidFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidFailToShowWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidFailToShowWithError:"), error__handle__);
		}
		[Export ("adapterRewardedVideoDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidOpen ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidOpen"));
		}
		[Export ("adapterRewardedVideoDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidClose ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidClose"));
		}
		[Export ("adapterRewardedVideoDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidLoad ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidLoad"));
		}
		[Export ("adapterRewardedVideoDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidClick ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidClick"));
		}
		[Export ("adapterRewardedVideoDidStart")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidStart ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidStart"));
		}
		[Export ("adapterRewardedVideoDidEnd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidEnd ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidEnd"));
		}
		[Export ("adapterRewardedVideoInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoInitSuccess ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoInitSuccess"));
		}
		[Export ("adapterRewardedVideoInitFailed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoInitFailed (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterRewardedVideoInitFailed:"), error__handle__);
		}
		[Export ("adapterRewardedVideoDidBecomeVisible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterRewardedVideoDidBecomeVisible ()
		{
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterRewardedVideoDidBecomeVisible"));
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSDK_ISRewardedVideoAdapterDelegate", false)]
	[Model]
	public unsafe abstract partial class ISRewardedVideoAdapterDelegate : NSObject, IISRewardedVideoAdapterDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISRewardedVideoAdapterDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISRewardedVideoAdapterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISRewardedVideoAdapterDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adapterRewardedVideoDidBecomeVisible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidBecomeVisible ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidClick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidClose ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidEnd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidEnd ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidFailToShowWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidLoad ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidOpen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidReceiveReward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidReceiveReward ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoDidStart")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoDidStart ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoHasChangedAvailability:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoHasChangedAvailability (bool available)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoInitFailed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoInitFailed (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterRewardedVideoInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterRewardedVideoInitSuccess ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISRewardedVideoAdapterDelegate */
}
