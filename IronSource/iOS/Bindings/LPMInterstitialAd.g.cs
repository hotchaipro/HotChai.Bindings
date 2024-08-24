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
	[Register("LPMInterstitialAd", true)]
	public unsafe partial class LPMInterstitialAd : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("LPMInterstitialAd");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPMInterstitialAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPMInterstitialAd (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAdUnitId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LPMInterstitialAd (string adUnitId)
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
		[Export ("isPlacementCapped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPlacementCapped (string placementName)
		{
			if (placementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementName));
			var nsplacementName = CFString.CreateNative (placementName);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isPlacementCapped:"), nsplacementName);
			CFString.ReleaseNative (nsplacementName);
			return ret != 0;
		}
		[Export ("loadAd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadAd ()
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadAd"));
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadAd"));
			}
		}
		[Export ("setDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDelegate (LPMInterstitialAdDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDelegate:"), @delegate__handle__);
			}
		}
		[Export ("showAdWithViewController:placementName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAdWithViewController (global::UIKit.UIViewController viewController, string? placementName)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var nsplacementName = CFString.CreateNative (placementName);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showAdWithViewController:placementName:"), viewController__handle__, nsplacementName);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("showAdWithViewController:placementName:"), viewController__handle__, nsplacementName);
			}
			CFString.ReleaseNative (nsplacementName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAdReady {
			[Export ("isAdReady")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAdReady"));
				} else {
					ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAdReady"));
				}
				return ret != 0;
			}
		}
	} /* class LPMInterstitialAd */
}
