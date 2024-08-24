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
	[Protocol (Name = "ISABannerAdViewDelegate", WrapperType = typeof (ISABannerAdViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BannerAdViewDidShow", Selector = "bannerAdViewDidShow:", ParameterType = new Type [] { typeof (IronSourceSdk.ISABannerAdView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BannerAdViewDidClick", Selector = "bannerAdViewDidClick:", ParameterType = new Type [] { typeof (IronSourceSdk.ISABannerAdView) }, ParameterByRef = new bool [] { false })]
	public partial interface IISABannerAdViewDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("bannerAdViewDidShow:")]
		[Preserve (Conditional = true)]
		void BannerAdViewDidShow (ISABannerAdView bannerAdView);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("bannerAdViewDidClick:")]
		[Preserve (Conditional = true)]
		void BannerAdViewDidClick (ISABannerAdView bannerAdView);
	}
	internal unsafe sealed class ISABannerAdViewDelegateWrapper : BaseWrapper, IISABannerAdViewDelegate {
		[Preserve (Conditional = true)]
		public ISABannerAdViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("bannerAdViewDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BannerAdViewDidShow (ISABannerAdView bannerAdView)
		{
			var bannerAdView__handle__ = bannerAdView!.GetNonNullHandle (nameof (bannerAdView));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("bannerAdViewDidShow:"), bannerAdView__handle__);
		}
		[Export ("bannerAdViewDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BannerAdViewDidClick (ISABannerAdView bannerAdView)
		{
			var bannerAdView__handle__ = bannerAdView!.GetNonNullHandle (nameof (bannerAdView));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("bannerAdViewDidClick:"), bannerAdView__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISABannerAdViewDelegate", false)]
	[Model]
	public unsafe abstract partial class ISABannerAdViewDelegate : NSObject, IISABannerAdViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISABannerAdViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISABannerAdViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISABannerAdViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("bannerAdViewDidClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BannerAdViewDidClick (ISABannerAdView bannerAdView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("bannerAdViewDidShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BannerAdViewDidShow (ISABannerAdView bannerAdView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISABannerAdViewDelegate */
}
