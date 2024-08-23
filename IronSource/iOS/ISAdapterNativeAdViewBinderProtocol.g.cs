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
	[Protocol (Name = "ISAdapterNativeAdViewBinderProtocol", WrapperType = typeof (ISAdapterNativeAdViewBinderProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetNativeAdView", Selector = "setNativeAdView:", ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NetworkNativeAdView", Selector = "networkNativeAdView", PropertyType = typeof (UIView), GetterSelector = "networkNativeAdView", SetterSelector = "setNetworkNativeAdView:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IISAdapterNativeAdViewBinderProtocol : INativeObject, IDisposable, 
		IronSourceSdk.IISNativeAdViewBinderProtocol
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setNativeAdView:")]
		[Preserve (Conditional = true)]
		void SetNativeAdView (global::UIKit.UIView? nativeAdView);
		[Preserve (Conditional = true)]
		global::UIKit.UIView? NetworkNativeAdView {
			[Export ("networkNativeAdView", ArgumentSemantic.Retain)]
			get;
			[Export ("setNetworkNativeAdView:", ArgumentSemantic.Retain)]
			set;
		}
	}
	internal unsafe sealed class ISAdapterNativeAdViewBinderProtocolWrapper : BaseWrapper, IISAdapterNativeAdViewBinderProtocol {
		[Preserve (Conditional = true)]
		public ISAdapterNativeAdViewBinderProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("setNativeAdView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetNativeAdView (global::UIKit.UIView? nativeAdView)
		{
			var nativeAdView__handle__ = nativeAdView.GetHandle ();
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNativeAdView:"), nativeAdView__handle__);
		}
		[Export ("setIconView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetIconView (global::UIKit.UIImageView iconView)
		{
			var iconView__handle__ = iconView!.GetNonNullHandle (nameof (iconView));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIconView:"), iconView__handle__);
		}
		[Export ("setTitleView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetTitleView (global::UIKit.UILabel titleView)
		{
			var titleView__handle__ = titleView!.GetNonNullHandle (nameof (titleView));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTitleView:"), titleView__handle__);
		}
		[Export ("setAdvertiserView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAdvertiserView (global::UIKit.UILabel advertiserView)
		{
			var advertiserView__handle__ = advertiserView!.GetNonNullHandle (nameof (advertiserView));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdvertiserView:"), advertiserView__handle__);
		}
		[Export ("setBodyView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBodyView (global::UIKit.UILabel bodyView)
		{
			var bodyView__handle__ = bodyView!.GetNonNullHandle (nameof (bodyView));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBodyView:"), bodyView__handle__);
		}
		[Export ("setMediaView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMediaView (LevelPlayMediaView mediaView)
		{
			var mediaView__handle__ = mediaView!.GetNonNullHandle (nameof (mediaView));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMediaView:"), mediaView__handle__);
		}
		[Export ("setCallToActionView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetCallToActionView (global::UIKit.UIButton callToActionView)
		{
			var callToActionView__handle__ = callToActionView!.GetNonNullHandle (nameof (callToActionView));
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCallToActionView:"), callToActionView__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIView? NetworkNativeAdView {
			[Export ("networkNativeAdView", ArgumentSemantic.Retain)]
			get {
				return  Runtime.GetNSObject<global::UIKit.UIView> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("networkNativeAdView")))!;
			}
			[Export ("setNetworkNativeAdView:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNetworkNativeAdView:"), value__handle__);
			}
		}
	}
}
