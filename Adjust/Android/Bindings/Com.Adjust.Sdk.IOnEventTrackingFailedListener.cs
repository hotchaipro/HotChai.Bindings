using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnEventTrackingFailedListener']"
	[Register ("com/adjust/sdk/OnEventTrackingFailedListener", "", "Com.Adjust.Sdk.IOnEventTrackingFailedListenerInvoker")]
	public partial interface IOnEventTrackingFailedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnEventTrackingFailedListener']/method[@name='onFinishedEventTrackingFailed' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustEventFailure']]"
		[Register ("onFinishedEventTrackingFailed", "(Lcom/adjust/sdk/AdjustEventFailure;)V", "GetOnFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_Handler:Com.Adjust.Sdk.IOnEventTrackingFailedListenerInvoker, MatchBlocks.Android")]
		void OnFinishedEventTrackingFailed (global::Com.Adjust.Sdk.AdjustEventFailure p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnEventTrackingFailedListener", DoNotGenerateAcw=true)]
	internal partial class IOnEventTrackingFailedListenerInvoker : global::Java.Lang.Object, IOnEventTrackingFailedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnEventTrackingFailedListener", typeof (IOnEventTrackingFailedListenerInvoker));

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

		public static IOnEventTrackingFailedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnEventTrackingFailedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnEventTrackingFailedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnEventTrackingFailedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_;
#pragma warning disable 0169
		static Delegate GetOnFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_Handler ()
		{
			if (cb_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_ == null)
				cb_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_));
			return cb_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_;
		}

		static void n_OnFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnEventTrackingFailedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustEventFailure> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFinishedEventTrackingFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_;
		public unsafe void OnFinishedEventTrackingFailed (global::Com.Adjust.Sdk.AdjustEventFailure p0)
		{
			if (id_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_ == IntPtr.Zero)
				id_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_ = JNIEnv.GetMethodID (class_ref, "onFinishedEventTrackingFailed", "(Lcom/adjust/sdk/AdjustEventFailure;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinishedEventTrackingFailed_Lcom_adjust_sdk_AdjustEventFailure_, __args);
		}

	}

	// event args for com.adjust.sdk.OnEventTrackingFailedListener.onFinishedEventTrackingFailed
	public partial class EventTrackingFailedEventArgs : global::System.EventArgs {
		public EventTrackingFailedEventArgs (global::Com.Adjust.Sdk.AdjustEventFailure p0)
		{
			this.p0 = p0;
		}

		global::Com.Adjust.Sdk.AdjustEventFailure p0;

		public global::Com.Adjust.Sdk.AdjustEventFailure P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnEventTrackingFailedListenerImplementor")]
	internal sealed partial class IOnEventTrackingFailedListenerImplementor : global::Java.Lang.Object, IOnEventTrackingFailedListener {

		object sender;

		public unsafe IOnEventTrackingFailedListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<EventTrackingFailedEventArgs> Handler;
		#pragma warning restore 0649

		public void OnFinishedEventTrackingFailed (global::Com.Adjust.Sdk.AdjustEventFailure p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventTrackingFailedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnEventTrackingFailedListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
