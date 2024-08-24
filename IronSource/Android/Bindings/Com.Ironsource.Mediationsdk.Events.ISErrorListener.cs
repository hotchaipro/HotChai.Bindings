using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.events']/interface[@name='ISErrorListener']"
	[Register ("com/ironsource/mediationsdk/events/ISErrorListener", "", "Com.IronSource.MediationSdk.Events.ISErrorListenerInvoker")]
	public partial interface ISErrorListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.events']/interface[@name='ISErrorListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.IronSource.MediationSdk.Events.ISErrorListenerInvoker, MatchSolitaire.Android")]
		void OnError (global::Java.Lang.Throwable throwable);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/events/ISErrorListener", DoNotGenerateAcw=true)]
	internal partial class ISErrorListenerInvoker : global::Java.Lang.Object, ISErrorListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/events/ISErrorListener", typeof (ISErrorListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ISErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISErrorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.events.ISErrorListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnError_Ljava_lang_Throwable_));
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Events.ISErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.OnError (throwable);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable throwable)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
		}

	}

	// event args for com.ironsource.mediationsdk.events.ISErrorListener.onError
	public partial class SErrorEventArgs : global::System.EventArgs {
		public SErrorEventArgs (global::Java.Lang.Throwable throwable)
		{
			this.throwable = throwable;
		}

		global::Java.Lang.Throwable throwable;

		public global::Java.Lang.Throwable Throwable {
			get { return throwable; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/events/ISErrorListenerImplementor")]
	internal sealed partial class ISErrorListenerImplementor : global::Java.Lang.Object, ISErrorListener {

		object sender;

		public unsafe ISErrorListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<SErrorEventArgs> Handler;
		#pragma warning restore 0649

		public void OnError (global::Java.Lang.Throwable throwable)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SErrorEventArgs (throwable));
		}

		internal static bool __IsEmpty (ISErrorListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
