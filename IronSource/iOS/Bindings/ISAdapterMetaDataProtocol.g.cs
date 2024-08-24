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
	[Protocol (Name = "ISAdapterMetaDataProtocol", WrapperType = typeof (ISAdapterMetaDataProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AndValues", Selector = "setMetaDataWithKey:andValues:", ParameterType = new Type [] { typeof (string), typeof (NSMutableArray) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IISAdapterMetaDataProtocol : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setMetaDataWithKey:andValues:")]
		[Preserve (Conditional = true)]
		void AndValues (string key, NSMutableArray values);
	}
	internal unsafe sealed class ISAdapterMetaDataProtocolWrapper : BaseWrapper, IISAdapterMetaDataProtocol {
		[Preserve (Conditional = true)]
		public ISAdapterMetaDataProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("setMetaDataWithKey:andValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AndValues (string key, NSMutableArray values)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var values__handle__ = values!.GetNonNullHandle (nameof (values));
			var nskey = CFString.CreateNative (key);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setMetaDataWithKey:andValues:"), nskey, values__handle__);
			CFString.ReleaseNative (nskey);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISAdapterMetaDataProtocol", true)]
	public unsafe partial class ISAdapterMetaDataProtocol : NSObject, IISAdapterMetaDataProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISAdapterMetaDataProtocol");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISAdapterMetaDataProtocol () : base (NSObjectFlag.Empty)
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
		protected ISAdapterMetaDataProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAdapterMetaDataProtocol (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("setMetaDataWithKey:andValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AndValues (string key, NSMutableArray values)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISAdapterMetaDataProtocol */
}
