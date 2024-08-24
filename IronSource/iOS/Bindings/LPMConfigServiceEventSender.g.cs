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
	[Protocol (Name = "LPMConfigServiceEventSender", WrapperType = typeof (LPMConfigServiceEventSenderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendAdUnitCappingParseFailedEventWithAdUnitId", Selector = "sendAdUnitCappingParseFailedEventWithAdUnitId:error:", ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendPlacementCappingParseFailedEventWithPlacementName", Selector = "sendPlacementCappingParseFailedEventWithPlacementName:adFormat:error:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISAdUnit), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendConfigParseFailedEventWithError", Selector = "sendConfigParseFailedEventWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public partial interface ILPMConfigServiceEventSender : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sendAdUnitCappingParseFailedEventWithAdUnitId:error:")]
		[Preserve (Conditional = true)]
		void SendAdUnitCappingParseFailedEventWithAdUnitId (string adUnitId, NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sendPlacementCappingParseFailedEventWithPlacementName:adFormat:error:")]
		[Preserve (Conditional = true)]
		void SendPlacementCappingParseFailedEventWithPlacementName (string placementName, ISAdUnit adFormat, NSError error);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sendConfigParseFailedEventWithError:")]
		[Preserve (Conditional = true)]
		void SendConfigParseFailedEventWithError (NSError error);
	}
	internal unsafe sealed class LPMConfigServiceEventSenderWrapper : BaseWrapper, ILPMConfigServiceEventSender {
		[Preserve (Conditional = true)]
		public LPMConfigServiceEventSenderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("sendAdUnitCappingParseFailedEventWithAdUnitId:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SendAdUnitCappingParseFailedEventWithAdUnitId (string adUnitId, NSError error)
		{
			if (adUnitId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnitId));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsadUnitId = CFString.CreateNative (adUnitId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendAdUnitCappingParseFailedEventWithAdUnitId:error:"), nsadUnitId, error__handle__);
			CFString.ReleaseNative (nsadUnitId);
		}
		[Export ("sendPlacementCappingParseFailedEventWithPlacementName:adFormat:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SendPlacementCappingParseFailedEventWithPlacementName (string placementName, ISAdUnit adFormat, NSError error)
		{
			if (placementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementName));
			var adFormat__handle__ = adFormat!.GetNonNullHandle (nameof (adFormat));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsplacementName = CFString.CreateNative (placementName);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendPlacementCappingParseFailedEventWithPlacementName:adFormat:error:"), nsplacementName, adFormat__handle__, error__handle__);
			CFString.ReleaseNative (nsplacementName);
		}
		[Export ("sendConfigParseFailedEventWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SendConfigParseFailedEventWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("sendConfigParseFailedEventWithError:"), error__handle__);
		}
	}
}
