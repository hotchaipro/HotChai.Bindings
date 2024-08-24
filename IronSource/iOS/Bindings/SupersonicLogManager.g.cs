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
	[Register("SupersonicLogManager", true)]
	public unsafe partial class SupersonicLogManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SupersonicLogManager");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SupersonicLogManager () : base (NSObjectFlag.Empty)
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
		protected SupersonicLogManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SupersonicLogManager (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("log:withLevel:withTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Log (string str, ISNLogLevel level, ISNLogTag tag)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("log:withLevel:withTag:"), nsstr, (UIntPtr) (ulong) level, (UIntPtr) (ulong) tag);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (this.SuperHandle, Selector.GetHandle ("log:withLevel:withTag:"), nsstr, (UIntPtr) (ulong) level, (UIntPtr) (ulong) tag);
			}
			CFString.ReleaseNative (nsstr);
		}
		[Export ("logWithNetworkPrefix:withLevel:withTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LogWithNetworkPrefix (string logMessage, ISNLogLevel logLevel, ISNLogTag logTag)
		{
			if (logMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (logMessage));
			var nslogMessage = CFString.CreateNative (logMessage);
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("logWithNetworkPrefix:withLevel:withTag:"), nslogMessage, (UIntPtr) (ulong) logLevel, (UIntPtr) (ulong) logTag);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (this.SuperHandle, Selector.GetHandle ("logWithNetworkPrefix:withLevel:withTag:"), nslogMessage, (UIntPtr) (ulong) logLevel, (UIntPtr) (ulong) logTag);
			}
			CFString.ReleaseNative (nslogMessage);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RequiredDebugMode {
			[Export ("requiredDebugMode")]
			get {
				if (IsDirectBinding) {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("requiredDebugMode"));
				} else {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requiredDebugMode"));
				}
			}
			[Export ("setRequiredDebugMode:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRequiredDebugMode:"), value);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRequiredDebugMode:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SupersonicLogManager SharedManager {
			[Export ("sharedManager")]
			get {
				SupersonicLogManager? ret;
				ret =  Runtime.GetNSObject<SupersonicLogManager> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedManager")))!;
				return ret!;
			}
		}
	} /* class SupersonicLogManager */
}
