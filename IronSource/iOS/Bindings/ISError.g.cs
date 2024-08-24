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
	[Register("ISError", true)]
	public unsafe partial class ISError : NSError {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISError");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISError () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ISError (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected ISError (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISError (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("appendError:withPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError AppendErrorWithPrefix (NSError error, string prefix)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (prefix is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prefix));
			var nsprefix = CFString.CreateNative (prefix);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("appendError:withPrefix:"), error__handle__, nsprefix))!;
			CFString.ReleaseNative (nsprefix);
			return ret!;
		}
		[Export ("appendError:withSuffix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError AppendErrorWithSuffix (NSError error, string suffix)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (suffix is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suffix));
			var nssuffix = CFString.CreateNative (suffix);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("appendError:withSuffix:"), error__handle__, nssuffix))!;
			CFString.ReleaseNative (nssuffix);
			return ret!;
		}
		[Export ("createError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError CreateError (ISErrorCode errorCode)
		{
			return  Runtime.GetNSObject<NSError> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, Selector.GetHandle ("createError:"), (UIntPtr) (ulong) errorCode))!;
		}
		[Export ("createError:withParams:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError CreateError (ISErrorCode errorCode, NSObject[] @params)
		{
			if (@params is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@params));
			var nsa_params = NSArray.FromNSObjects (@params);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (class_ptr, Selector.GetHandle ("createError:withParams:"), (UIntPtr) (ulong) errorCode, nsa_params.Handle))!;
			nsa_params.Dispose ();
			return ret!;
		}
		[Export ("createError:withMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError CreateError (ISErrorCode errorCode, string message)
		{
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (class_ptr, Selector.GetHandle ("createError:withMessage:"), (UIntPtr) (ulong) errorCode, nsmessage))!;
			CFString.ReleaseNative (nsmessage);
			return ret!;
		}
		[Export ("createErrorWithDomain:code:message:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError CreateErrorWithDomain (string domain, ISErrorCode code, string message)
		{
			if (domain is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domain));
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsdomain = CFString.CreateNative (domain);
			var nsmessage = CFString.CreateNative (message);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (class_ptr, Selector.GetHandle ("createErrorWithDomain:code:message:"), nsdomain, (UIntPtr) (ulong) code, nsmessage))!;
			CFString.ReleaseNative (nsdomain);
			CFString.ReleaseNative (nsmessage);
			return ret!;
		}
		[Export ("getCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISErrorCode GetCode (ISErrorCode errorCode)
		{
			ISErrorCode ret;
			ret = (IronSourceSdk.ISErrorCode) (ulong) ApiDefinitions.Messaging.UIntPtr_objc_msgSend_UIntPtr (class_ptr, Selector.GetHandle ("getCode:"), (UIntPtr) (ulong) errorCode);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Prefix {
			[Export ("prefix", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("prefix")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prefix")))!;
				}
			}
			[Export ("setPrefix:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrefix:"), nsvalue);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPrefix:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Suffix {
			[Export ("suffix", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("suffix")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("suffix")))!;
				}
			}
			[Export ("setSuffix:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSuffix:"), nsvalue);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSuffix:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class ISError */
}
