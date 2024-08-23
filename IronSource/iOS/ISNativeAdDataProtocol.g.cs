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
	[Protocol (Name = "ISNativeAdDataProtocol", WrapperType = typeof (ISNativeAdDataProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", SetterSelector = "setTitle:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Advertiser", Selector = "advertiser", PropertyType = typeof (string), GetterSelector = "advertiser", SetterSelector = "setAdvertiser:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Body", Selector = "body", PropertyType = typeof (string), GetterSelector = "body", SetterSelector = "setBody:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CallToAction", Selector = "callToAction", PropertyType = typeof (string), GetterSelector = "callToAction", SetterSelector = "setCallToAction:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Icon", Selector = "icon", PropertyType = typeof (IronSourceSdk.ISNativeAdDataImage), GetterSelector = "icon", SetterSelector = "setIcon:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IISNativeAdDataProtocol : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		string? Title {
			[Export ("title", ArgumentSemantic.Retain)]
			get;
			[Export ("setTitle:", ArgumentSemantic.Retain)]
			set;
		}
		[Preserve (Conditional = true)]
		string? Advertiser {
			[Export ("advertiser", ArgumentSemantic.Retain)]
			get;
			[Export ("setAdvertiser:", ArgumentSemantic.Retain)]
			set;
		}
		[Preserve (Conditional = true)]
		string? Body {
			[Export ("body", ArgumentSemantic.Retain)]
			get;
			[Export ("setBody:", ArgumentSemantic.Retain)]
			set;
		}
		[Preserve (Conditional = true)]
		string? CallToAction {
			[Export ("callToAction", ArgumentSemantic.Retain)]
			get;
			[Export ("setCallToAction:", ArgumentSemantic.Retain)]
			set;
		}
		[Preserve (Conditional = true)]
		ISNativeAdDataImage? Icon {
			[Export ("icon", ArgumentSemantic.Retain)]
			get;
			[Export ("setIcon:", ArgumentSemantic.Retain)]
			set;
		}
	}
	internal unsafe sealed class ISNativeAdDataProtocolWrapper : BaseWrapper, IISNativeAdDataProtocol {
		[Preserve (Conditional = true)]
		public ISNativeAdDataProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Title {
			[Export ("title", ArgumentSemantic.Retain)]
			get {
				return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")))!;
			}
			[Export ("setTitle:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Advertiser {
			[Export ("advertiser", ArgumentSemantic.Retain)]
			get {
				return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("advertiser")))!;
			}
			[Export ("setAdvertiser:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdvertiser:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Body {
			[Export ("body", ArgumentSemantic.Retain)]
			get {
				return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("body")))!;
			}
			[Export ("setBody:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBody:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? CallToAction {
			[Export ("callToAction", ArgumentSemantic.Retain)]
			get {
				return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("callToAction")))!;
			}
			[Export ("setCallToAction:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCallToAction:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISNativeAdDataImage? Icon {
			[Export ("icon", ArgumentSemantic.Retain)]
			get {
				return  Runtime.GetNSObject<ISNativeAdDataImage> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("icon")))!;
			}
			[Export ("setIcon:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIcon:"), value__handle__);
			}
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISNativeAdDataProtocol", true)]
	public unsafe partial class ISNativeAdDataProtocol : NSObject, IISNativeAdDataProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISNativeAdDataProtocol");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISNativeAdDataProtocol () : base (NSObjectFlag.Empty)
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
		protected ISNativeAdDataProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISNativeAdDataProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Advertiser {
			[Export ("advertiser", ArgumentSemantic.Retain)]
			get {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
			[Export ("setAdvertiser:", ArgumentSemantic.Retain)]
			set {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Body {
			[Export ("body", ArgumentSemantic.Retain)]
			get {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
			[Export ("setBody:", ArgumentSemantic.Retain)]
			set {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CallToAction {
			[Export ("callToAction", ArgumentSemantic.Retain)]
			get {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
			[Export ("setCallToAction:", ArgumentSemantic.Retain)]
			set {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISNativeAdDataImage? Icon {
			[Export ("icon", ArgumentSemantic.Retain)]
			get {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
			[Export ("setIcon:", ArgumentSemantic.Retain)]
			set {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title", ArgumentSemantic.Retain)]
			get {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
			[Export ("setTitle:", ArgumentSemantic.Retain)]
			set {
			throw new You_Should_Not_Call_base_In_This_Method ();
			}
		}
	} /* class ISNativeAdDataProtocol */
}
