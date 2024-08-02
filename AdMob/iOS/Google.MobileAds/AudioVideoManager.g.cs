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
    [Register("GADAudioVideoManager", true)]
	public unsafe partial class AudioVideoManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADAudioVideoManager");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AudioVideoManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AudioVideoManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AudioVideoManager (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AudioSessionIsApplicationManaged {
			[Export ("audioSessionIsApplicationManaged")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("audioSessionIsApplicationManaged"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("audioSessionIsApplicationManaged"));
				}
			}
			[Export ("setAudioSessionIsApplicationManaged:")]
			set {
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAudioSessionIsApplicationManaged:"), value);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAudioSessionIsApplicationManaged:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAudioVideoManagerDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IAudioVideoManagerDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAudioVideoManagerDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<IAudioVideoManagerDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false)!;
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		_AudioVideoManagerDelegate EnsureAudioVideoManagerDelegate ()
		{
			var del = Delegate;
			if (del is null || (!(del is _AudioVideoManagerDelegate))){
				del = new _AudioVideoManagerDelegate ();
				Delegate = del;
			}
			return (_AudioVideoManagerDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _AudioVideoManagerDelegate : Google.MobileAds.AudioVideoManagerDelegate { 
			public _AudioVideoManagerDelegate () { IsDirectBinding = false; }
			internal EventHandler? didPauseAllVideo;
			[Preserve (Conditional = true)]
			public override void DidPauseAllVideo (Google.MobileAds.AudioVideoManager audioVideoManager)
			{
				var handler = didPauseAllVideo;
				if (handler != null){
					handler (audioVideoManager, EventArgs.Empty);
				}
			}
			internal EventHandler? didStopPlayingAudio;
			[Preserve (Conditional = true)]
			public override void DidStopPlayingAudio (Google.MobileAds.AudioVideoManager audioVideoManager)
			{
				var handler = didStopPlayingAudio;
				if (handler != null){
					handler (audioVideoManager, EventArgs.Empty);
				}
			}
			internal EventHandler? willPlayAudio;
			[Preserve (Conditional = true)]
			public override void WillPlayAudio (Google.MobileAds.AudioVideoManager audioVideoManager)
			{
				var handler = willPlayAudio;
				if (handler != null){
					handler (audioVideoManager, EventArgs.Empty);
				}
			}
			internal EventHandler? willPlayVideo;
			[Preserve (Conditional = true)]
			public override void WillPlayVideo (Google.MobileAds.AudioVideoManager audioVideoManager)
			{
				var handler = willPlayVideo;
				if (handler != null){
					handler (audioVideoManager, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		public event EventHandler AllVideoPaused {
			add { EnsureAudioVideoManagerDelegate ()!.didPauseAllVideo += value; }
			remove { EnsureAudioVideoManagerDelegate ()!.didPauseAllVideo -= value; }
		}
		public event EventHandler PlayingAudioStopped {
			add { EnsureAudioVideoManagerDelegate ()!.didStopPlayingAudio += value; }
			remove { EnsureAudioVideoManagerDelegate ()!.didStopPlayingAudio -= value; }
		}
		public event EventHandler WillPlayAudio {
			add { EnsureAudioVideoManagerDelegate ()!.willPlayAudio += value; }
			remove { EnsureAudioVideoManagerDelegate ()!.willPlayAudio -= value; }
		}
		public event EventHandler WillPlayVideo {
			add { EnsureAudioVideoManagerDelegate ()!.willPlayVideo += value; }
			remove { EnsureAudioVideoManagerDelegate ()!.willPlayVideo -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class AudioVideoManager */
}
