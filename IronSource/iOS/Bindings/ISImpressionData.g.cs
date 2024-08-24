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
	[Register("ISImpressionData", true)]
	public unsafe partial class ISImpressionData : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISImpressionData");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISImpressionData () : base (NSObjectFlag.Empty)
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
		protected ISImpressionData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISImpressionData (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISImpressionData (NSDictionary dictionary)
			: base (NSObjectFlag.Empty)
		{
			var dictionary__handle__ = dictionary!.GetNonNullHandle (nameof (dictionary));
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithDictionary:"), dictionary__handle__), "initWithDictionary:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithDictionary:"), dictionary__handle__), "initWithDictionary:");
			}
		}
		[Export ("initWithImpressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISImpressionData (ISImpressionData impressionData)
			: base (NSObjectFlag.Empty)
		{
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithImpressionData:"), impressionData__handle__), "initWithImpressionData:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithImpressionData:"), impressionData__handle__), "initWithImpressionData:");
			}
		}
		[Export ("replacePlacementMacro:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplacePlacementMacro (string macro, string value)
		{
			if (macro is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (macro));
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsmacro = CFString.CreateNative (macro);
			var nsvalue = CFString.CreateNative (value);
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replacePlacementMacro:value:"), nsmacro, nsvalue);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("replacePlacementMacro:value:"), nsmacro, nsvalue);
			}
			CFString.ReleaseNative (nsmacro);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Ab {
			[Export ("ab")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("ab")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ab")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AdNetwork {
			[Export ("ad_network")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("ad_network")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ad_network")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AdUnit {
			[Export ("ad_unit")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("ad_unit")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ad_unit")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? AllData {
			[Export ("all_data", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("all_data")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("all_data")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AuctionId {
			[Export ("auction_id")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("auction_id")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("auction_id")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? ConversionValue {
			[Export ("conversion_value", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("conversion_value")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversion_value")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Country {
			[Export ("country")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("country")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("country")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? EncryptedCpm {
			[Export ("encrypted_cpm")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("encrypted_cpm")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("encrypted_cpm")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? InstanceId {
			[Export ("instance_id")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("instance_id")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("instance_id")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? InstanceName {
			[Export ("instance_name")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("instance_name")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("instance_name")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? LifetimeRevenue {
			[Export ("lifetime_revenue", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("lifetime_revenue")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lifetime_revenue")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Placement {
			[Export ("placement")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("placement")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("placement")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Precision {
			[Export ("precision")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("precision")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("precision")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Revenue {
			[Export ("revenue", ArgumentSemantic.Copy)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("revenue")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("revenue")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SegmentName {
			[Export ("segment_name")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("segment_name")))!;
				} else {
					return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("segment_name")))!;
				}
			}
		}
	} /* class ISImpressionData */
}
