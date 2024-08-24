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
	[Protocol (Name = "ISInterstitialAdapterDelegate", WrapperType = typeof (ISInterstitialAdapterDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialInitSuccess", Selector = "adapterInterstitialInitSuccess")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialInitFailedWithError", Selector = "adapterInterstitialInitFailedWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidLoad", Selector = "adapterInterstitialDidLoad")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidFailToLoadWithError", Selector = "adapterInterstitialDidFailToLoadWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidOpen", Selector = "adapterInterstitialDidOpen")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidClose", Selector = "adapterInterstitialDidClose")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidShow", Selector = "adapterInterstitialDidShow")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidFailToShowWithError", Selector = "adapterInterstitialDidFailToShowWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidClick", Selector = "adapterInterstitialDidClick")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdapterInterstitialDidBecomeVisible", Selector = "adapterInterstitialDidBecomeVisible")]
	public partial interface IISInterstitialAdapterDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialInitSuccess")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialInitSuccess ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialInitFailedWithError:")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialInitFailedWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidLoad")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidLoad ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidFailToLoadWithError:")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidFailToLoadWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidOpen")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidOpen ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidClose")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidClose ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidShow")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidShow ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidFailToShowWithError:")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidFailToShowWithError (NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidClick")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidClick ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adapterInterstitialDidBecomeVisible")]
		[Preserve (Conditional = true)]
		void AdapterInterstitialDidBecomeVisible ();
	}
	internal unsafe sealed class ISInterstitialAdapterDelegateWrapper : BaseWrapper, IISInterstitialAdapterDelegate {
		[Preserve (Conditional = true)]
		public ISInterstitialAdapterDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adapterInterstitialInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialInitSuccess ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterInterstitialInitSuccess"));
		}
		[Export ("adapterInterstitialInitFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialInitFailedWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterInterstitialInitFailedWithError:"), error__handle__);
		}
		[Export ("adapterInterstitialDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidLoad ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterInterstitialDidLoad"));
		}
		[Export ("adapterInterstitialDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidFailToLoadWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterInterstitialDidFailToLoadWithError:"), error__handle__);
		}
		[Export ("adapterInterstitialDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidOpen ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterInterstitialDidOpen"));
		}
		[Export ("adapterInterstitialDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidClose ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterInterstitialDidClose"));
		}
		[Export ("adapterInterstitialDidShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidShow ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterInterstitialDidShow"));
		}
		[Export ("adapterInterstitialDidFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidFailToShowWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("adapterInterstitialDidFailToShowWithError:"), error__handle__);
		}
		[Export ("adapterInterstitialDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidClick ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterInterstitialDidClick"));
		}
		[Export ("adapterInterstitialDidBecomeVisible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdapterInterstitialDidBecomeVisible ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("adapterInterstitialDidBecomeVisible"));
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISInterstitialAdapterDelegate", false)]
	[Model]
	public unsafe abstract partial class ISInterstitialAdapterDelegate : NSObject, IISInterstitialAdapterDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISInterstitialAdapterDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISInterstitialAdapterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISInterstitialAdapterDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adapterInterstitialDidBecomeVisible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidBecomeVisible ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialDidClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidClick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialDidClose")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidClose ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialDidFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidFailToLoadWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialDidFailToShowWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidFailToShowWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialDidLoad")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidLoad ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialDidOpen")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidOpen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialDidShow")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialDidShow ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialInitFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialInitFailedWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adapterInterstitialInitSuccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdapterInterstitialInitSuccess ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISInterstitialAdapterDelegate */
}
