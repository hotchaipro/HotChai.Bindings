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
	[Register("ISSegment", true)]
	public unsafe partial class ISSegment : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISSegment");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISSegment () : base (NSObjectFlag.Empty)
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
		protected ISSegment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISSegment (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("setCustomValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCustomValue (string value, string key)
		{
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsvalue = CFString.CreateNative (value);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setCustomValue:forKey:"), nsvalue, nskey);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCustomValue:forKey:"), nsvalue, nskey);
			}
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int Age {
			[Export ("age")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("age"));
				} else {
					return ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("age"));
				}
			}
			[Export ("setAge:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setAge:"), value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setAge:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary CustomKeys {
			[Export ("customKeys", ArgumentSemantic.Retain)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customKeys")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customKeys")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Data {
			[Export ("getData")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getData")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getData")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISGender Gender {
			[Export ("gender", ArgumentSemantic.Assign)]
			get {
				ISGender ret;
				if (IsDirectBinding) {
					ret = (IronSourceSdk.ISGender) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gender"));
				} else {
					ret = (IronSourceSdk.ISGender) (long) ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gender"));
				}
				return ret!;
			}
			[Export ("setGender:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGender:"), (IntPtr) (long) value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGender:"), (IntPtr) (long) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double IapTotal {
			[Export ("iapTotal")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("iapTotal"));
				} else {
					return ApiDefinitions.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("iapTotal"));
				}
			}
			[Export ("setIapTotal:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setIapTotal:"), value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setIapTotal:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int Level {
			[Export ("level")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("level"));
				} else {
					return ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("level"));
				}
			}
			[Export ("setLevel:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLevel:"), value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLevel:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Paying {
			[Export ("paying")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("paying"));
				} else {
					ret = ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paying"));
				}
				return ret != 0;
			}
			[Export ("setPaying:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPaying:"), value ? (byte) 1 : (byte) 0);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPaying:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SegmentName {
			[Export ("segmentName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("segmentName")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("segmentName")))!;
				}
			}
			[Export ("setSegmentName:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSegmentName:"), nsvalue);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSegmentName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate UserCreationDate {
			[Export ("userCreationDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userCreationDate")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDate> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userCreationDate")))!;
				}
				return ret!;
			}
			[Export ("setUserCreationDate:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserCreationDate:"), value__handle__);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUserCreationDate:"), value__handle__);
				}
			}
		}
	} /* class ISSegment */
}
