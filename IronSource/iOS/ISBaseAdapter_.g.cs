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
	[Protocol (Name = "ISBaseAdapter_", WrapperType = typeof (ISBaseAdapter_Wrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsConfigValueValid", Selector = "isConfigValueValid:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ErrorForMissingCredentialFieldWithName", Selector = "errorForMissingCredentialFieldWithName:", ReturnType = typeof (NSError), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMetaDataWithKey", Selector = "setMetaDataWithKey:andValues:", ParameterType = new Type [] { typeof (string), typeof (NSMutableArray) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TopMostController", Selector = "topMostController", PropertyType = typeof (UIViewController), GetterSelector = "topMostController", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IISBaseAdapter_ : INativeObject, IDisposable
	{
	}
	public unsafe static partial class ISBaseAdapter__Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsConfigValueValid (this IISBaseAdapter_ This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isConfigValueValid:"), nsvalue);
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError ErrorForMissingCredentialFieldWithName (this IISBaseAdapter_ This, string fieldName)
		{
			if (fieldName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fieldName));
			var nsfieldName = CFString.CreateNative (fieldName);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("errorForMissingCredentialFieldWithName:"), nsfieldName))!;
			CFString.ReleaseNative (nsfieldName);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMetaDataWithKey (this IISBaseAdapter_ This, string key, NSMutableArray values)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var nskey = CFString.CreateNative (key);
			global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setMetaDataWithKey:andValues:"), nskey, values__handle__);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIViewController GetTopMostController (this IISBaseAdapter_ This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIViewController> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("topMostController")))!;
		}
	}
	internal unsafe sealed class ISBaseAdapter_Wrapper : BaseWrapper, IISBaseAdapter_ {
		[Preserve (Conditional = true)]
		public ISBaseAdapter_Wrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISBaseAdapter_", true)]
	public unsafe partial class ISBaseAdapter_ : ISBaseAdapter, IISBaseAdapter_ {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBaseAdapter_");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBaseAdapter_ () : base (NSObjectFlag.Empty)
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
		protected ISBaseAdapter_ (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBaseAdapter_ (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("errorForMissingCredentialFieldWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError ErrorForMissingCredentialFieldWithName (string fieldName)
		{
			if (fieldName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fieldName));
			var nsfieldName = CFString.CreateNative (fieldName);
			NSError? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSError> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("errorForMissingCredentialFieldWithName:"), nsfieldName))!;
			} else {
				ret =  Runtime.GetNSObject<NSError> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("errorForMissingCredentialFieldWithName:"), nsfieldName))!;
			}
			CFString.ReleaseNative (nsfieldName);
			return ret!;
		}
		[Export ("isConfigValueValid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsConfigValueValid (string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			if (IsDirectBinding) {
				ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isConfigValueValid:"), nsvalue);
			} else {
				ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("isConfigValueValid:"), nsvalue);
			}
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
		[Export ("setMetaDataWithKey:andValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMetaDataWithKey (string key, NSMutableArray values)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setMetaDataWithKey:andValues:"), nskey, values__handle__);
			} else {
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setMetaDataWithKey:andValues:"), nskey, values__handle__);
			}
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController TopMostController {
			[Export ("topMostController")]
			get {
				global::UIKit.UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("topMostController")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("topMostController")))!;
				}
				return ret!;
			}
		}
	} /* class ISBaseAdapter_ */
}
