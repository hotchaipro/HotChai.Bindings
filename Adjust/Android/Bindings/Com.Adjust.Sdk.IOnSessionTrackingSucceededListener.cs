using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnSessionTrackingSucceededListener']"
	[Register ("com/adjust/sdk/OnSessionTrackingSucceededListener", "", "Com.Adjust.Sdk.IOnSessionTrackingSucceededListenerInvoker")]
	public partial interface IOnSessionTrackingSucceededListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnSessionTrackingSucceededListener']/method[@name='onFinishedSessionTrackingSucceeded' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustSessionSuccess']]"
		[Register ("onFinishedSessionTrackingSucceeded", "(Lcom/adjust/sdk/AdjustSessionSuccess;)V", "GetOnFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_Handler:Com.Adjust.Sdk.IOnSessionTrackingSucceededListenerInvoker, MatchBlocks.Android")]
		void OnFinishedSessionTrackingSucceeded (global::Com.Adjust.Sdk.AdjustSessionSuccess p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnSessionTrackingSucceededListener", DoNotGenerateAcw=true)]
	internal partial class IOnSessionTrackingSucceededListenerInvoker : global::Java.Lang.Object, IOnSessionTrackingSucceededListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnSessionTrackingSucceededListener", typeof (IOnSessionTrackingSucceededListenerInvoker));

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

		public static IOnSessionTrackingSucceededListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSessionTrackingSucceededListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnSessionTrackingSucceededListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSessionTrackingSucceededListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_;
#pragma warning disable 0169
		static Delegate GetOnFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_Handler ()
		{
			if (cb_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_ == null)
				cb_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_));
			return cb_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_;
		}

		static void n_OnFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnSessionTrackingSucceededListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustSessionSuccess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFinishedSessionTrackingSucceeded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_;
		public unsafe void OnFinishedSessionTrackingSucceeded (global::Com.Adjust.Sdk.AdjustSessionSuccess p0)
		{
			if (id_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_ == IntPtr.Zero)
				id_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_ = JNIEnv.GetMethodID (class_ref, "onFinishedSessionTrackingSucceeded", "(Lcom/adjust/sdk/AdjustSessionSuccess;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinishedSessionTrackingSucceeded_Lcom_adjust_sdk_AdjustSessionSuccess_, __args);
		}

	}

	// event args for com.adjust.sdk.OnSessionTrackingSucceededListener.onFinishedSessionTrackingSucceeded
	public partial class SessionTrackingSucceededEventArgs : global::System.EventArgs {
		public SessionTrackingSucceededEventArgs (global::Com.Adjust.Sdk.AdjustSessionSuccess p0)
		{
			this.p0 = p0;
		}

		global::Com.Adjust.Sdk.AdjustSessionSuccess p0;

		public global::Com.Adjust.Sdk.AdjustSessionSuccess P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnSessionTrackingSucceededListenerImplementor")]
	internal sealed partial class IOnSessionTrackingSucceededListenerImplementor : global::Java.Lang.Object, IOnSessionTrackingSucceededListener {

		object sender;

		public unsafe IOnSessionTrackingSucceededListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<SessionTrackingSucceededEventArgs> Handler;
		#pragma warning restore 0649

		public void OnFinishedSessionTrackingSucceeded (global::Com.Adjust.Sdk.AdjustSessionSuccess p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SessionTrackingSucceededEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnSessionTrackingSucceededListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
