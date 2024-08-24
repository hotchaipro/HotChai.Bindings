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
	[Protocol (Name = "ISSetAPSDataProtocol", WrapperType = typeof (ISSetAPSDataProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ApsData", Selector = "setAPSDataWithAdUnit:apsData:", ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IISSetAPSDataProtocol : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setAPSDataWithAdUnit:apsData:")]
		[Preserve (Conditional = true)]
		void ApsData (string adUnit, NSDictionary apsData);
	}
	internal unsafe sealed class ISSetAPSDataProtocolWrapper : BaseWrapper, IISSetAPSDataProtocol {
		[Preserve (Conditional = true)]
		public ISSetAPSDataProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("setAPSDataWithAdUnit:apsData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ApsData (string adUnit, NSDictionary apsData)
		{
			if (adUnit is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnit));
			var apsData__handle__ = apsData!.GetNonNullHandle (nameof (apsData));
			var nsadUnit = CFString.CreateNative (adUnit);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setAPSDataWithAdUnit:apsData:"), nsadUnit, apsData__handle__);
			CFString.ReleaseNative (nsadUnit);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISSetAPSDataProtocol", true)]
	public unsafe partial class ISSetAPSDataProtocol : NSObject, IISSetAPSDataProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISSetAPSDataProtocol");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISSetAPSDataProtocol () : base (NSObjectFlag.Empty)
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
		protected ISSetAPSDataProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISSetAPSDataProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("setAPSDataWithAdUnit:apsData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApsData (string adUnit, NSDictionary apsData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISSetAPSDataProtocol */
}
