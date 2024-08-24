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
	public unsafe static partial class ISBaseAdapter_  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBaseAdapter");
		[Export ("errorForMissingCredentialFieldWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError ErrorForMissingCredentialFieldWithName (this ISBaseAdapter This, string fieldName)
		{
			if (fieldName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fieldName));
			var nsfieldName = CFString.CreateNative (fieldName);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("errorForMissingCredentialFieldWithName:"), nsfieldName))!;
			CFString.ReleaseNative (nsfieldName);
			return ret!;
		}
		[Export ("isConfigValueValid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsConfigValueValid (this ISBaseAdapter This, string value)
		{
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			ret = ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isConfigValueValid:"), nsvalue);
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
		[Export ("setMetaDataWithKey:andValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMetaDataWithKey (this ISBaseAdapter This, string key, NSMutableArray values)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var nskey = CFString.CreateNative (key);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setMetaDataWithKey:andValues:"), nskey, values__handle__);
			CFString.ReleaseNative (nskey);
		}
	} /* class ISBaseAdapter_ */
}
