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
    [Protocol (Name = "GADAudioVideoManagerDelegate", WrapperType = typeof (AudioVideoManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPlayVideo", Selector = "audioVideoManagerWillPlayVideo:", ParameterType = new Type [] { typeof (Google.MobileAds.AudioVideoManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPauseAllVideo", Selector = "audioVideoManagerDidPauseAllVideo:", ParameterType = new Type [] { typeof (Google.MobileAds.AudioVideoManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPlayAudio", Selector = "audioVideoManagerWillPlayAudio:", ParameterType = new Type [] { typeof (Google.MobileAds.AudioVideoManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopPlayingAudio", Selector = "audioVideoManagerDidStopPlayingAudio:", ParameterType = new Type [] { typeof (Google.MobileAds.AudioVideoManager) }, ParameterByRef = new bool [] { false })]
	public partial interface IAudioVideoManagerDelegate : INativeObject, IDisposable
	{
	}
	public static partial class AudioVideoManagerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPlayVideo (this IAudioVideoManagerDelegate This, AudioVideoManager audioVideoManager)
		{
			var audioVideoManager__handle__ = audioVideoManager!.GetNonNullHandle (nameof (audioVideoManager));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("audioVideoManagerWillPlayVideo:"), audioVideoManager__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPauseAllVideo (this IAudioVideoManagerDelegate This, AudioVideoManager audioVideoManager)
		{
			var audioVideoManager__handle__ = audioVideoManager!.GetNonNullHandle (nameof (audioVideoManager));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("audioVideoManagerDidPauseAllVideo:"), audioVideoManager__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPlayAudio (this IAudioVideoManagerDelegate This, AudioVideoManager audioVideoManager)
		{
			var audioVideoManager__handle__ = audioVideoManager!.GetNonNullHandle (nameof (audioVideoManager));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("audioVideoManagerWillPlayAudio:"), audioVideoManager__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopPlayingAudio (this IAudioVideoManagerDelegate This, AudioVideoManager audioVideoManager)
		{
			var audioVideoManager__handle__ = audioVideoManager!.GetNonNullHandle (nameof (audioVideoManager));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("audioVideoManagerDidStopPlayingAudio:"), audioVideoManager__handle__);
		}
	}
	internal sealed class AudioVideoManagerDelegateWrapper : BaseWrapper, IAudioVideoManagerDelegate {
		[Preserve (Conditional = true)]
		public AudioVideoManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_AudioVideoManagerDelegate", false)]
	[Model]
	public unsafe partial class AudioVideoManagerDelegate : NSObject, IAudioVideoManagerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AudioVideoManagerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AudioVideoManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AudioVideoManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("audioVideoManagerDidPauseAllVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPauseAllVideo (AudioVideoManager audioVideoManager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("audioVideoManagerDidStopPlayingAudio:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopPlayingAudio (AudioVideoManager audioVideoManager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("audioVideoManagerWillPlayAudio:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPlayAudio (AudioVideoManager audioVideoManager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("audioVideoManagerWillPlayVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPlayVideo (AudioVideoManager audioVideoManager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AudioVideoManagerDelegate */
}
