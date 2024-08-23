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
namespace IronSourceSDK {
	[Protocol (Name = "ISNAdViewsManagerSwiftFacadeProtocol", WrapperType = typeof (ISNAdViewsManagerSwiftFacadeProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAdViewById", Selector = "getAdViewById:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface IISNAdViewsManagerSwiftFacadeProtocol : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("getAdViewById:")]
		[Preserve (Conditional = true)]
		global::UIKit.UIView GetAdViewById (string adViewId);
	}
	internal unsafe sealed class ISNAdViewsManagerSwiftFacadeProtocolWrapper : BaseWrapper, IISNAdViewsManagerSwiftFacadeProtocol {
		[Preserve (Conditional = true)]
		public ISNAdViewsManagerSwiftFacadeProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("getAdViewById:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIView GetAdViewById (string adViewId)
		{
			if (adViewId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adViewId));
			var nsadViewId = CFString.CreateNative (adViewId);
			global::UIKit.UIView? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getAdViewById:"), nsadViewId))!;
			CFString.ReleaseNative (nsadViewId);
			return ret!;
		}
	}
}
