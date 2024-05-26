using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnSessionTrackingFailedListener']"
	[Register ("com/adjust/sdk/OnSessionTrackingFailedListener", "", "Com.Adjust.Sdk.IOnSessionTrackingFailedListenerInvoker")]
	public partial interface IOnSessionTrackingFailedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnSessionTrackingFailedListener']/method[@name='onFinishedSessionTrackingFailed' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustSessionFailure']]"
		[Register ("onFinishedSessionTrackingFailed", "(Lcom/adjust/sdk/AdjustSessionFailure;)V", "GetOnFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_Handler:Com.Adjust.Sdk.IOnSessionTrackingFailedListenerInvoker, MatchBlocks.Android")]
		void OnFinishedSessionTrackingFailed (global::Com.Adjust.Sdk.AdjustSessionFailure p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnSessionTrackingFailedListener", DoNotGenerateAcw=true)]
	internal partial class IOnSessionTrackingFailedListenerInvoker : global::Java.Lang.Object, IOnSessionTrackingFailedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnSessionTrackingFailedListener", typeof (IOnSessionTrackingFailedListenerInvoker));

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

		public static IOnSessionTrackingFailedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSessionTrackingFailedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnSessionTrackingFailedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSessionTrackingFailedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_;
#pragma warning disable 0169
		static Delegate GetOnFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_Handler ()
		{
			if (cb_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_ == null)
				cb_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_));
			return cb_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_;
		}

		static void n_OnFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnSessionTrackingFailedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustSessionFailure> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFinishedSessionTrackingFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_;
		public unsafe void OnFinishedSessionTrackingFailed (global::Com.Adjust.Sdk.AdjustSessionFailure p0)
		{
			if (id_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_ == IntPtr.Zero)
				id_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_ = JNIEnv.GetMethodID (class_ref, "onFinishedSessionTrackingFailed", "(Lcom/adjust/sdk/AdjustSessionFailure;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinishedSessionTrackingFailed_Lcom_adjust_sdk_AdjustSessionFailure_, __args);
		}

	}

	// event args for com.adjust.sdk.OnSessionTrackingFailedListener.onFinishedSessionTrackingFailed
	public partial class SessionTrackingFailedEventArgs : global::System.EventArgs {
		public SessionTrackingFailedEventArgs (global::Com.Adjust.Sdk.AdjustSessionFailure p0)
		{
			this.p0 = p0;
		}

		global::Com.Adjust.Sdk.AdjustSessionFailure p0;

		public global::Com.Adjust.Sdk.AdjustSessionFailure P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnSessionTrackingFailedListenerImplementor")]
	internal sealed partial class IOnSessionTrackingFailedListenerImplementor : global::Java.Lang.Object, IOnSessionTrackingFailedListener {

		object sender;

		public unsafe IOnSessionTrackingFailedListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<SessionTrackingFailedEventArgs> Handler;
		#pragma warning restore 0649

		public void OnFinishedSessionTrackingFailed (global::Com.Adjust.Sdk.AdjustSessionFailure p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SessionTrackingFailedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnSessionTrackingFailedListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
