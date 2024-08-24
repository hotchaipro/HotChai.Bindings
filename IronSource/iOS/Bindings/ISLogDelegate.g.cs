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
	[Protocol (Name = "ISLogDelegate", WrapperType = typeof (ISLogDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Level", Selector = "sendLog:level:tag:", ParameterType = new Type [] { typeof (string), typeof (IronSourceSdk.ISLogLevel), typeof (IronSourceSdk.LogTag) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IISLogDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("sendLog:level:tag:")]
		[Preserve (Conditional = true)]
		void Level (string log, ISLogLevel level, LogTag tag);
	}
	internal unsafe sealed class ISLogDelegateWrapper : BaseWrapper, IISLogDelegate {
		[Preserve (Conditional = true)]
		public ISLogDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("sendLog:level:tag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Level (string log, ISLogLevel level, LogTag tag)
		{
			if (log is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (log));
			var nslog = CFString.CreateNative (log);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_int_UInt32 (this.Handle, Selector.GetHandle ("sendLog:level:tag:"), nslog, (int)level, (UInt32)tag);
			CFString.ReleaseNative (nslog);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISLogDelegate", false)]
	[Model]
	public unsafe abstract partial class ISLogDelegate : NSObject, IISLogDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected ISLogDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISLogDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISLogDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("sendLog:level:tag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Level (string log, ISLogLevel level, LogTag tag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISLogDelegate */
}
