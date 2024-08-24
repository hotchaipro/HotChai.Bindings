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
    [Register("GADVideoController", true)]
	public unsafe partial class VideoController : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADVideoController");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public VideoController () : base (NSObjectFlag.Empty)
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
		protected VideoController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal VideoController (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[Export ("pause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pause"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pause"));
			}
		}
		[Export ("play")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Play ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("play"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("play"));
			}
		}
		[Export ("setMute:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMute (bool mute)
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMute:"), mute);
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMute:"), mute);
			}
		}
		[Export ("stop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
			} else {
				global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stop"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IVideoControllerDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				IVideoControllerDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IVideoControllerDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					ret =  Runtime.GetINativeObject<IVideoControllerDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false)!;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsClickToExpandEnabled {
			[Export ("clickToExpandEnabled")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clickToExpandEnabled"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clickToExpandEnabled"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCustomControlsEnabled {
			[Export ("customControlsEnabled")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("customControlsEnabled"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customControlsEnabled"));
				}
			}
		}
		//
		// Events and properties from the delegate
		//
		_VideoControllerDelegate EnsureVideoControllerDelegate ()
		{
			var del = Delegate;
			if (del is null || (!(del is _VideoControllerDelegate))){
				del = new _VideoControllerDelegate ();
				Delegate = del;
			}
			return (_VideoControllerDelegate) del;
		}
		#pragma warning disable 672
		[Register]
		sealed class _VideoControllerDelegate : Google.MobileAds.VideoControllerDelegate { 
			public _VideoControllerDelegate () { IsDirectBinding = false; }
			internal EventHandler? didEndVideoPlayback;
			[Preserve (Conditional = true)]
			public override void DidEndVideoPlayback (Google.MobileAds.VideoController videoController)
			{
				var handler = didEndVideoPlayback;
				if (handler != null){
					handler (videoController, EventArgs.Empty);
				}
			}
			internal EventHandler? didMuteVideo;
			[Preserve (Conditional = true)]
			public override void DidMuteVideo (Google.MobileAds.VideoController videoController)
			{
				var handler = didMuteVideo;
				if (handler != null){
					handler (videoController, EventArgs.Empty);
				}
			}
			internal EventHandler? didPauseVideo;
			[Preserve (Conditional = true)]
			public override void DidPauseVideo (Google.MobileAds.VideoController videoController)
			{
				var handler = didPauseVideo;
				if (handler != null){
					handler (videoController, EventArgs.Empty);
				}
			}
			internal EventHandler? didPlayVideo;
			[Preserve (Conditional = true)]
			public override void DidPlayVideo (Google.MobileAds.VideoController videoController)
			{
				var handler = didPlayVideo;
				if (handler != null){
					handler (videoController, EventArgs.Empty);
				}
			}
			internal EventHandler? didUnmuteVideo;
			[Preserve (Conditional = true)]
			public override void DidUnmuteVideo (Google.MobileAds.VideoController videoController)
			{
				var handler = didUnmuteVideo;
				if (handler != null){
					handler (videoController, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		public event EventHandler VideoPlaybackEnded {
			add { EnsureVideoControllerDelegate ()!.didEndVideoPlayback += value; }
			remove { EnsureVideoControllerDelegate ()!.didEndVideoPlayback -= value; }
		}
		public event EventHandler VideoMuted {
			add { EnsureVideoControllerDelegate ()!.didMuteVideo += value; }
			remove { EnsureVideoControllerDelegate ()!.didMuteVideo -= value; }
		}
		public event EventHandler VideoPaused {
			add { EnsureVideoControllerDelegate ()!.didPauseVideo += value; }
			remove { EnsureVideoControllerDelegate ()!.didPauseVideo -= value; }
		}
		public event EventHandler VideoPlayed {
			add { EnsureVideoControllerDelegate ()!.didPlayVideo += value; }
			remove { EnsureVideoControllerDelegate ()!.didPlayVideo -= value; }
		}
		public event EventHandler VideoUnuted {
			add { EnsureVideoControllerDelegate ()!.didUnmuteVideo += value; }
			remove { EnsureVideoControllerDelegate ()!.didUnmuteVideo -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class VideoController */
}
