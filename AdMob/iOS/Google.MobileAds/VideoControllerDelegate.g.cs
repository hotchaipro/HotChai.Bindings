//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Protocol (Name = "GADVideoControllerDelegate", WrapperType = typeof (VideoControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPlayVideo", Selector = "videoControllerDidPlayVideo:", ParameterType = new Type [] { typeof (Google.MobileAds.VideoController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPauseVideo", Selector = "videoControllerDidPauseVideo:", ParameterType = new Type [] { typeof (Google.MobileAds.VideoController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndVideoPlayback", Selector = "videoControllerDidEndVideoPlayback:", ParameterType = new Type [] { typeof (Google.MobileAds.VideoController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidMuteVideo", Selector = "videoControllerDidMuteVideo:", ParameterType = new Type [] { typeof (Google.MobileAds.VideoController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnmuteVideo", Selector = "videoControllerDidUnmuteVideo:", ParameterType = new Type [] { typeof (Google.MobileAds.VideoController) }, ParameterByRef = new bool [] { false })]
	public partial interface IVideoControllerDelegate : INativeObject, IDisposable
	{
	}
	public static partial class VideoControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPlayVideo (this IVideoControllerDelegate This, VideoController videoController)
		{
			var videoController__handle__ = videoController!.GetNonNullHandle (nameof (videoController));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("videoControllerDidPlayVideo:"), videoController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPauseVideo (this IVideoControllerDelegate This, VideoController videoController)
		{
			var videoController__handle__ = videoController!.GetNonNullHandle (nameof (videoController));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("videoControllerDidPauseVideo:"), videoController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndVideoPlayback (this IVideoControllerDelegate This, VideoController videoController)
		{
			var videoController__handle__ = videoController!.GetNonNullHandle (nameof (videoController));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("videoControllerDidEndVideoPlayback:"), videoController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidMuteVideo (this IVideoControllerDelegate This, VideoController videoController)
		{
			var videoController__handle__ = videoController!.GetNonNullHandle (nameof (videoController));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("videoControllerDidMuteVideo:"), videoController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUnmuteVideo (this IVideoControllerDelegate This, VideoController videoController)
		{
			var videoController__handle__ = videoController!.GetNonNullHandle (nameof (videoController));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("videoControllerDidUnmuteVideo:"), videoController__handle__);
		}
	}
	internal sealed class VideoControllerDelegateWrapper : BaseWrapper, IVideoControllerDelegate {
		[Preserve (Conditional = true)]
		public VideoControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_VideoControllerDelegate", false)]
	[Model]
	public unsafe partial class VideoControllerDelegate : NSObject, IVideoControllerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public VideoControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected VideoControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal VideoControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("videoControllerDidEndVideoPlayback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndVideoPlayback (VideoController videoController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("videoControllerDidMuteVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidMuteVideo (VideoController videoController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("videoControllerDidPauseVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPauseVideo (VideoController videoController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("videoControllerDidPlayVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPlayVideo (VideoController videoController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("videoControllerDidUnmuteVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnmuteVideo (VideoController videoController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class VideoControllerDelegate */
}
