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
	[Register("ISMetaDataUtils", true)]
	public unsafe partial class ISMetaDataUtils : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISMetaDataUtils");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISMetaDataUtils () : base (NSObjectFlag.Empty)
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
		protected ISMetaDataUtils (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISMetaDataUtils (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("formatMetaDataKey:andValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISMetaData FormatMetaDataKey (string key, NSMutableArray values)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var nskey = CFString.CreateNative (key);
			ISMetaData? ret;
			ret =  Runtime.GetNSObject<ISMetaData> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("formatMetaDataKey:andValues:"), nskey, values__handle__))!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("formatValue:forType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string FormatValue (string value, ISMetaDataValueTypes valueType)
		{
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			string? ret;
			ret = CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (class_ptr, Selector.GetHandle ("formatValue:forType:"), nsvalue, (UIntPtr) (ulong) valueType))!;
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
		[Export ("getMetaDataBooleanValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetMetaDataBooleanValue (string value)
		{
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getMetaDataBooleanValue:"), nsvalue);
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
		[Export ("getValueTypeForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ISMetaDataValueTypes GetValueTypeForKey (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			ISMetaDataValueTypes ret;
			ret = (IronSourceSdk.ISMetaDataValueTypes) (ulong) ApiDefinitions.Messaging.UIntPtr_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getValueTypeForKey:"), nskey);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("isKnownKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsKnownKey (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isKnownKey:"), nskey);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("isMediationOnlyKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMediationOnlyKey (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isMediationOnlyKey:"), nskey);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("isMetaDataKeyValid:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMetaDataKeyValid (string key, out string error)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			NativeHandle errorValue = IntPtr.Zero;
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("isMetaDataKeyValid:error:"), nskey, &errorValue);
			CFString.ReleaseNative (nskey);
			error = CFString.FromHandle (errorValue)!;
			return ret != 0;
		}
		[Export ("isMetaDataValuesValid:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMetaDataValuesValid (NSMutableArray values, out string error)
		{
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("isMetaDataValuesValid:error:"), values__handle__, &errorValue);
			error = CFString.FromHandle (errorValue)!;
			return ret != 0;
		}
		[Export ("isValidCCPAMetaDataWithKey:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidCCPAMetaDataWithKey (string key, string value)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("isValidCCPAMetaDataWithKey:andValue:"), nskey, nsvalue);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
		[Export ("isValidMetaDataWithKey:flag:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidMetaDataWithKey (string key, string flag, string value)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (flag is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (flag));
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsflag = CFString.CreateNative (flag);
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("isValidMetaDataWithKey:flag:andValue:"), nskey, nsflag, nsvalue);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsflag);
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
	} /* class ISMetaDataUtils */
}
