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
	[Register("ISLoggerManager", true)]
	public unsafe partial class ISLoggerManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISLoggerManager");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISLoggerManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISLoggerManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISLoggerManager (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addPublisherLogger:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddPublisherLogger (ISLogDelegate @delegate)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addPublisherLogger:"), @delegate__handle__);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("addPublisherLogger:"), @delegate__handle__);
			}
		}
		[Export ("automationLog:level:withTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AutomationLog (string message, ISLogLevel logLevel, LogTag logTag)
		{
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_int_UInt32 (this.Handle, Selector.GetHandle ("automationLog:level:withTag:"), nsmessage, (int)logLevel, (UInt32)logTag);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_int_UInt32 (this.SuperHandle, Selector.GetHandle ("automationLog:level:withTag:"), nsmessage, (int)logLevel, (UInt32)logTag);
			}
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("dynamicLog:message:level:withTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DynamicLog (global::System.SByte* calledFrom, string message, ISLogLevel logLevel, LogTag logTag)
		{
			if (calledFrom is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (calledFrom));
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_SByte__NativeHandle_int_UInt32 (this.Handle, Selector.GetHandle ("dynamicLog:message:level:withTag:"), calledFrom, nsmessage, (int)logLevel, (UInt32)logTag);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_SByte__NativeHandle_int_UInt32 (this.SuperHandle, Selector.GetHandle ("dynamicLog:message:level:withTag:"), calledFrom, nsmessage, (int)logLevel, (UInt32)logTag);
			}
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("log:level:tag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Log (string message, ISLogLevel logLevel, LogTag logTag)
		{
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_int_UInt32 (this.Handle, Selector.GetHandle ("log:level:tag:"), nsmessage, (int)logLevel, (UInt32)logTag);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_int_UInt32 (this.SuperHandle, Selector.GetHandle ("log:level:tag:"), nsmessage, (int)logLevel, (UInt32)logTag);
			}
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("logFromError:level:tag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LogFromError (NSError error, ISLogLevel logLevel, LogTag logTag)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_int_UInt32 (this.Handle, Selector.GetHandle ("logFromError:level:tag:"), error__handle__, (int)logLevel, (UInt32)logTag);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_int_UInt32 (this.SuperHandle, Selector.GetHandle ("logFromError:level:tag:"), error__handle__, (int)logLevel, (UInt32)logTag);
			}
		}
		[Export ("logFromException:level:tag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LogFromException (NSException exception, ISLogLevel logLevel, LogTag logTag)
		{
			var exception__handle__ = exception!.GetNonNullHandle (nameof (exception));
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_int_UInt32 (this.Handle, Selector.GetHandle ("logFromException:level:tag:"), exception__handle__, (int)logLevel, (UInt32)logTag);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_int_UInt32 (this.SuperHandle, Selector.GetHandle ("logFromException:level:tag:"), exception__handle__, (int)logLevel, (UInt32)logTag);
			}
		}
		[Export ("logFromException:message:level:tag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LogFromException (NSException exception, string message, ISLogLevel logLevel, LogTag logTag)
		{
			var exception__handle__ = exception!.GetNonNullHandle (nameof (exception));
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_int_UInt32 (this.Handle, Selector.GetHandle ("logFromException:message:level:tag:"), exception__handle__, nsmessage, (int)logLevel, (UInt32)logTag);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_int_UInt32 (this.SuperHandle, Selector.GetHandle ("logFromException:message:level:tag:"), exception__handle__, nsmessage, (int)logLevel, (UInt32)logTag);
			}
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("setLoggingLevels:publisher:console:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLoggingLevels (nint server, nint publisher, nint console)
		{
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLoggingLevels:publisher:console:"), server, publisher, console);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setLoggingLevels:publisher:console:"), server, publisher, console);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISLoggerManager SharedInstance {
			[Export ("sharedInstance")]
			get {
				ISLoggerManager? ret;
				ret =  Runtime.GetNSObject<ISLoggerManager> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")))!;
				return ret!;
			}
		}
	} /* class ISLoggerManager */
}
