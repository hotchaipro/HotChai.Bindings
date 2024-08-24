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
	[Register("LPMBannerAdView", true)]
	public unsafe partial class LPMBannerAdView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("LPMBannerAdView");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public LPMBannerAdView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPMBannerAdView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPMBannerAdView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAdUnitId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LPMBannerAdView (string adUnitId)
			: base (NSObjectFlag.Empty)
		{
			if (adUnitId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnitId));
			var nsadUnitId = CFString.CreateNative (adUnitId);
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithAdUnitId:"), nsadUnitId), "initWithAdUnitId:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAdUnitId:"), nsadUnitId), "initWithAdUnitId:");
			}
			CFString.ReleaseNative (nsadUnitId);
		}
		[Export ("destroy")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Destroy ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("destroy"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("destroy"));
			}
		}
		[Export ("loadAdWithViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadAdWithViewController (global::UIKit.UIViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadAdWithViewController:"), viewController__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadAdWithViewController:"), viewController__handle__);
			}
		}
		[Export ("pauseAutoRefresh")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseAutoRefresh ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pauseAutoRefresh"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pauseAutoRefresh"));
			}
		}
		[Export ("resumeAutoRefresh")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumeAutoRefresh ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resumeAutoRefresh"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resumeAutoRefresh"));
			}
		}
		[Export ("setAdSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdSize (LPMAdSize adSize)
		{
			var adSize__handle__ = adSize!.GetNonNullHandle (nameof (adSize));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdSize:"), adSize__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdSize:"), adSize__handle__);
			}
		}
		[Export ("setDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDelegate (LPMBannerAdViewDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setPlacementName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPlacementName (string placementName)
		{
			if (placementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementName));
			var nsplacementName = CFString.CreateNative (placementName);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPlacementName:"), nsplacementName);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPlacementName:"), nsplacementName);
			}
			CFString.ReleaseNative (nsplacementName);
		}
		public partial class LPMBannerAdViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal LPMBannerAdViewAppearance (IntPtr handle) : base (handle) {}
		}
		public static new LPMBannerAdViewAppearance Appearance {
			get { return new LPMBannerAdViewAppearance (ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, global::ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new LPMBannerAdViewAppearance GetAppearance<T> () where T: LPMBannerAdView {
			return new LPMBannerAdViewAppearance (ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), global::ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new LPMBannerAdViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new LPMBannerAdViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new LPMBannerAdViewAppearance GetAppearance (UITraitCollection traits) {
			return new LPMBannerAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new LPMBannerAdViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new LPMBannerAdViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new LPMBannerAdViewAppearance GetAppearance<T> (UITraitCollection traits) where T: LPMBannerAdView {
			return new LPMBannerAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new LPMBannerAdViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: LPMBannerAdView{
			return new LPMBannerAdViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class LPMBannerAdView */
}
