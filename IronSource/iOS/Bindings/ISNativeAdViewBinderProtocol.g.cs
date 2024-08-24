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
	[Protocol (Name = "ISNativeAdViewBinderProtocol", WrapperType = typeof (ISNativeAdViewBinderProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetIconView", Selector = "setIconView:", ParameterType = new Type [] { typeof (UIImageView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTitleView", Selector = "setTitleView:", ParameterType = new Type [] { typeof (UILabel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAdvertiserView", Selector = "setAdvertiserView:", ParameterType = new Type [] { typeof (UILabel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBodyView", Selector = "setBodyView:", ParameterType = new Type [] { typeof (UILabel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMediaView", Selector = "setMediaView:", ParameterType = new Type [] { typeof (IronSourceSdk.LevelPlayMediaView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCallToActionView", Selector = "setCallToActionView:", ParameterType = new Type [] { typeof (UIButton) }, ParameterByRef = new bool [] { false })]
	public partial interface IISNativeAdViewBinderProtocol : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setIconView:")]
		[Preserve (Conditional = true)]
		void SetIconView (global::UIKit.UIImageView iconView);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setTitleView:")]
		[Preserve (Conditional = true)]
		void SetTitleView (global::UIKit.UILabel titleView);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setAdvertiserView:")]
		[Preserve (Conditional = true)]
		void SetAdvertiserView (global::UIKit.UILabel advertiserView);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setBodyView:")]
		[Preserve (Conditional = true)]
		void SetBodyView (global::UIKit.UILabel bodyView);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setMediaView:")]
		[Preserve (Conditional = true)]
		void SetMediaView (LevelPlayMediaView mediaView);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setCallToActionView:")]
		[Preserve (Conditional = true)]
		void SetCallToActionView (global::UIKit.UIButton callToActionView);
	}
	internal unsafe sealed class ISNativeAdViewBinderProtocolWrapper : BaseWrapper, IISNativeAdViewBinderProtocol {
		[Preserve (Conditional = true)]
		public ISNativeAdViewBinderProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
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
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISNativeAdViewBinderProtocol", true)]
	public unsafe partial class ISNativeAdViewBinderProtocol : NSObject, IISNativeAdViewBinderProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISNativeAdViewBinderProtocol");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISNativeAdViewBinderProtocol () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISNativeAdViewBinderProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISNativeAdViewBinderProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("setAdvertiserView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdvertiserView (global::UIKit.UILabel advertiserView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setBodyView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBodyView (global::UIKit.UILabel bodyView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setCallToActionView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCallToActionView (global::UIKit.UIButton callToActionView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setIconView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetIconView (global::UIKit.UIImageView iconView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setMediaView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMediaView (LevelPlayMediaView mediaView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setTitleView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitleView (global::UIKit.UILabel titleView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISNativeAdViewBinderProtocol */
}
