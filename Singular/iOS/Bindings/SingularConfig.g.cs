#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using CoreFoundation;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace SingularSDK
{
	[Register("SingularConfig", true)]
	public unsafe partial class SingularConfig : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SingularConfig");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SingularConfig () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SingularConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SingularConfig (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithApiKey:andSecret:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SingularConfig (string apikey, string secret)
			: base (NSObjectFlag.Empty)
		{
			if (apikey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apikey));
			if (secret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (secret));
			var nsapikey = CFString.CreateNative (apikey);
			var nssecret = CFString.CreateNative (secret);
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithApiKey:andSecret:"), nsapikey, nssecret), "initWithApiKey:andSecret:");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithApiKey:andSecret:"), nsapikey, nssecret), "initWithApiKey:andSecret:");
			}
			CFString.ReleaseNative (nsapikey);
			CFString.ReleaseNative (nssecret);
		}
		[Export ("setGlobalProperty:withValue:overrideExisting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetGlobalProperty (string key, string value, bool overrideExisiting)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("setGlobalProperty:withValue:overrideExisting:"), nskey, nsvalue, overrideExisiting ? (byte) 1 : (byte) 0);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool (this.SuperHandle, Selector.GetHandle ("setGlobalProperty:withValue:overrideExisting:"), nskey, nsvalue, overrideExisiting ? (byte) 1 : (byte) 0);
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Apikey {
			[Export ("apikey")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("apikey")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("apikey")))!;
				}
			}
			[Export ("setApikey:")]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setApikey:"), nsvalue);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setApikey:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AppGroupName {
			[Export ("appGroupName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("appGroupName")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appGroupName")))!;
				}
			}
			[Export ("setAppGroupName:")]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAppGroupName:"), nsvalue);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAppGroupName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClipboardAttribution {
			[Export ("clipboardAttribution")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clipboardAttribution"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clipboardAttribution"));
				}
				return ret != 0;
			}
			[Export ("setClipboardAttribution:")]
			set {
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClipboardAttribution:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setClipboardAttribution:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<nint> ConversionValueUpdatedCallback {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V2))]
			[Export ("conversionValueUpdatedCallback", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("conversionValueUpdatedCallback"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversionValueUpdatedCallback"));
				}
				return global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V2.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]
			[Export ("setConversionValueUpdatedCallback:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V2.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setConversionValueUpdatedCallback:"), (IntPtr) block_ptr_value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setConversionValueUpdatedCallback:"), (IntPtr) block_ptr_value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<NSNumber, NSNumber, bool> ConversionValuesUpdatedCallback {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity3V0))]
			[Export ("conversionValuesUpdatedCallback", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("conversionValuesUpdatedCallback"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversionValuesUpdatedCallback"));
				}
				return global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity3V0.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]
			[Export ("setConversionValuesUpdatedCallback:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity3V0.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setConversionValuesUpdatedCallback:"), (IntPtr) block_ptr_value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setConversionValuesUpdatedCallback:"), (IntPtr) block_ptr_value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CustomSdid {
			[Export ("customSdid")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customSdid")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customSdid")))!;
				}
			}
			[Export ("setCustomSdid:")]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomSdid:"), nsvalue);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCustomSdid:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<NSDictionary> DeviceAttributionCallback {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V3))]
			[Export ("deviceAttributionCallback", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("deviceAttributionCallback"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceAttributionCallback"));
				}
				return global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V3.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]
			[Export ("setDeviceAttributionCallback:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V3.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDeviceAttributionCallback:"), (IntPtr) block_ptr_value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDeviceAttributionCallback:"), (IntPtr) block_ptr_value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SdidAccessorHandler DidSetSdidHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDSdidAccessorHandler))]
			[Export ("didSetSdidHandler", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("didSetSdidHandler"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didSetSdidHandler"));
				}
				return global::SingularSDK.ObjCRuntime.Trampolines.NIDSdidAccessorHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSdidAccessorHandler))]
			[Export ("setDidSetSdidHandler:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = global::SingularSDK.ObjCRuntime.Trampolines.SDSdidAccessorHandler.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDidSetSdidHandler:"), (IntPtr) block_ptr_value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDidSetSdidHandler:"), (IntPtr) block_ptr_value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_EspDomains_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] EspDomains {
			[Export ("espDomains", ArgumentSemantic.Assign)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("espDomains")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NSObject>(global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("espDomains")))!;
				}
				MarkDirty ();
				__mt_EspDomains_var = ret;
				return ret!;
			}
			[Export ("setEspDomains:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setEspDomains:"), nsa_value.Handle);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setEspDomains:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				MarkDirty ();
				__mt_EspDomains_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary GlobalProperties {
			[Export ("globalProperties")]
			get {
				NSMutableDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("globalProperties")))!;
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("globalProperties")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_LaunchOptions_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary LaunchOptions {
			[Export ("launchOptions", ArgumentSemantic.Assign)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("launchOptions")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("launchOptions")))!;
				}
				MarkDirty ();
				__mt_LaunchOptions_var = ret;
				return ret!;
			}
			[Export ("setLaunchOptions:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLaunchOptions:"), value__handle__);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setLaunchOptions:"), value__handle__);
				}
				MarkDirty ();
				__mt_LaunchOptions_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ManualSkanConversionManagement {
			[Export ("manualSkanConversionManagement")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("manualSkanConversionManagement"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("manualSkanConversionManagement"));
				}
				return ret != 0;
			}
			[Export ("setManualSkanConversionManagement:")]
			set {
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setManualSkanConversionManagement:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setManualSkanConversionManagement:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_OpenUrl_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl OpenUrl {
			[Export ("openUrl", ArgumentSemantic.Assign)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("openUrl")))!;
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openUrl")))!;
				}
				MarkDirty ();
				__mt_OpenUrl_var = ret;
				return ret!;
			}
			[Export ("setOpenUrl:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOpenUrl:"), value__handle__);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setOpenUrl:"), value__handle__);
				}
				MarkDirty ();
				__mt_OpenUrl_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SdidAccessorHandler SdidReceivedHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDSdidAccessorHandler))]
			[Export ("sdidReceivedHandler", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sdidReceivedHandler"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sdidReceivedHandler"));
				}
				return global::SingularSDK.ObjCRuntime.Trampolines.NIDSdidAccessorHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSdidAccessorHandler))]
			[Export ("setSdidReceivedHandler:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = global::SingularSDK.ObjCRuntime.Trampolines.SDSdidAccessorHandler.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSdidReceivedHandler:"), (IntPtr) block_ptr_value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSdidReceivedHandler:"), (IntPtr) block_ptr_value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Secret {
			[Export ("secret")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("secret")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secret")))!;
				}
			}
			[Export ("setSecret:")]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSecret:"), nsvalue);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSecret:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ShortLinkResolveTimeOut {
			[Export ("shortLinkResolveTimeOut")]
			get {
				if (IsDirectBinding) {
					return global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shortLinkResolveTimeOut"));
				} else {
					return global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shortLinkResolveTimeOut"));
				}
			}
			[Export ("setShortLinkResolveTimeOut:")]
			set {
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShortLinkResolveTimeOut:"), value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShortLinkResolveTimeOut:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Action<SingularLinkParams> SingularLinksHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V1))]
			[Export ("singularLinksHandler", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("singularLinksHandler"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("singularLinksHandler"));
				}
				return global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]
			[Export ("setSingularLinksHandler:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSingularLinksHandler:"), (IntPtr) block_ptr_value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSingularLinksHandler:"), (IntPtr) block_ptr_value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SkAdNetworkEnabled {
			[Export ("skAdNetworkEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("skAdNetworkEnabled"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("skAdNetworkEnabled"));
				}
				return ret != 0;
			}
			[Export ("setSkAdNetworkEnabled:")]
			set {
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSkAdNetworkEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSkAdNetworkEnabled:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportAppExtension {
			[Export ("supportAppExtension")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportAppExtension"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("supportAppExtension"));
				}
				return ret != 0;
			}
			[Export ("setSupportAppExtension:")]
			set {
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSupportAppExtension:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSupportAppExtension:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ToJsonString {
			[Export ("toJsonString")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("toJsonString")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toJsonString")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_UserActivity_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserActivity UserActivity {
			[Export ("userActivity", ArgumentSemantic.Assign)]
			get {
				NSUserActivity? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUserActivity> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userActivity")))!;
				} else {
					ret =  Runtime.GetNSObject<NSUserActivity> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userActivity")))!;
				}
				MarkDirty ();
				__mt_UserActivity_var = ret;
				return ret!;
			}
			[Export ("setUserActivity:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserActivity:"), value__handle__);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUserActivity:"), value__handle__);
				}
				MarkDirty ();
				__mt_UserActivity_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint WaitForTrackingAuthorizationWithTimeoutInterval {
			[Export ("waitForTrackingAuthorizationWithTimeoutInterval")]
			get {
				if (IsDirectBinding) {
					return global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("waitForTrackingAuthorizationWithTimeoutInterval"));
				} else {
					return global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("waitForTrackingAuthorizationWithTimeoutInterval"));
				}
			}
			[Export ("setWaitForTrackingAuthorizationWithTimeoutInterval:")]
			set {
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWaitForTrackingAuthorizationWithTimeoutInterval:"), value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWaitForTrackingAuthorizationWithTimeoutInterval:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_EspDomains_var = null;
				__mt_LaunchOptions_var = null;
				__mt_OpenUrl_var = null;
				__mt_UserActivity_var = null;
			}
		}
	} /* class SingularConfig */
}
