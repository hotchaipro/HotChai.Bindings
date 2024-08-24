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
	[Protocol (Name = "ISAppStoreErrorDelegate", WrapperType = typeof (ISAppStoreErrorDelegateWrapper))]
	public partial interface IISAppStoreErrorDelegate : INativeObject, IDisposable, 
		IronSourceSdk.IISNAppStoreVCRootViewDelegate
	{
	}
	internal unsafe sealed class ISAppStoreErrorDelegateWrapper : BaseWrapper, IISAppStoreErrorDelegate {
		[Preserve (Conditional = true)]
		public ISAppStoreErrorDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("didReceiveOutOfAppStoreTouchWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveOutOfAppStoreTouchWithType (string type)
		{
			if (type is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didReceiveOutOfAppStoreTouchWithType:"), nstype);
			CFString.ReleaseNative (nstype);
		}
	}
}
namespace IronSourceSdk {
	[Protocol()]
	[Register("ApiDefinitions__IronSourceSdk_ISAppStoreErrorDelegate", false)]
	[Model]
	public unsafe partial class ISAppStoreErrorDelegate : NSObject, IISAppStoreErrorDelegate, IISNAppStoreVCRootViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISAppStoreErrorDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISAppStoreErrorDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISAppStoreErrorDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didReceiveOutOfAppStoreTouchWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveOutOfAppStoreTouchWithType (string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class ISAppStoreErrorDelegate */
}
