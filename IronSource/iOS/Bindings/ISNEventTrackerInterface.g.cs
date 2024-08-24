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
	[Protocol (Name = "ISNEventTrackerInterface", WrapperType = typeof (ISNEventTrackerInterfaceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Data", Selector = "logEvent:data:", ParameterType = new Type [] { typeof (IronSourceSdk.ISNEvent), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IISNEventTrackerInterface : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("logEvent:data:")]
		[Preserve (Conditional = true)]
		void Data (ISNEvent @event, NSDictionary data);
	}
	internal unsafe sealed class ISNEventTrackerInterfaceWrapper : BaseWrapper, IISNEventTrackerInterface {
		[Preserve (Conditional = true)]
		public ISNEventTrackerInterfaceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("logEvent:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Data (ISNEvent @event, NSDictionary data)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("logEvent:data:"), @event__handle__, data__handle__);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ISNEventTrackerInterface", true)]
	public unsafe partial class ISNEventTrackerInterface : NSObject, IISNEventTrackerInterface {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISNEventTrackerInterface");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISNEventTrackerInterface () : base (NSObjectFlag.Empty)
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
		protected ISNEventTrackerInterface (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISNEventTrackerInterface (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("logEvent:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Data (ISNEvent @event, NSDictionary data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISNEventTrackerInterface */
}
