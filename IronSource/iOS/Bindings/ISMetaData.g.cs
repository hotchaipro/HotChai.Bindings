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
	[Register("ISMetaData", true)]
	public unsafe partial class ISMetaData : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISMetaData");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISMetaData () : base (NSObjectFlag.Empty)
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
		protected ISMetaData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISMetaData (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithKey:andValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISMetaData (string key, NSMutableArray values)
			: base (NSObjectFlag.Empty)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var nskey = CFString.CreateNative (key);
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithKey:andValues:"), nskey, values__handle__), "initWithKey:andValues:");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithKey:andValues:"), nskey, values__handle__), "initWithKey:andValues:");
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("initWithKey:values:andValuesType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISMetaData (string key, NSMutableArray values, NSMutableArray valuesType)
			: base (NSObjectFlag.Empty)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var valuesType__handle__ = valuesType!.GetNonNullHandle (nameof (valuesType));
			var nskey = CFString.CreateNative (key);
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithKey:values:andValuesType:"), nskey, values__handle__, valuesType__handle__), "initWithKey:values:andValuesType:");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithKey:values:andValuesType:"), nskey, values__handle__, valuesType__handle__), "initWithKey:values:andValuesType:");
			}
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Key {
			[Export ("key")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("key")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("key")))!;
				}
			}
			[Export ("setKey:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setKey:"), nsvalue);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setKey:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Values_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray Values {
			[Export ("values", ArgumentSemantic.Assign)]
			get {
				NSMutableArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("values")))!;
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("values")))!;
				}
				MarkDirty ();
				__mt_Values_var = ret;
				return ret!;
			}
			[Export ("setValues:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setValues:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setValues:"), value__handle__);
				}
				MarkDirty ();
				__mt_Values_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ValuesType_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray ValuesType {
			[Export ("valuesType", ArgumentSemantic.Assign)]
			get {
				NSMutableArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("valuesType")))!;
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("valuesType")))!;
				}
				MarkDirty ();
				__mt_ValuesType_var = ret;
				return ret!;
			}
			[Export ("setValuesType:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setValuesType:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setValuesType:"), value__handle__);
				}
				MarkDirty ();
				__mt_ValuesType_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ValuesType_var = null;
				__mt_Values_var = null;
			}
		}
	} /* class ISMetaData */
}
