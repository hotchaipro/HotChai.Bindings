using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnEventTrackingSucceededListener']"
	[Register ("com/adjust/sdk/OnEventTrackingSucceededListener", "", "Com.Adjust.Sdk.IOnEventTrackingSucceededListenerInvoker")]
	public partial interface IOnEventTrackingSucceededListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnEventTrackingSucceededListener']/method[@name='onFinishedEventTrackingSucceeded' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustEventSuccess']]"
		[Register ("onFinishedEventTrackingSucceeded", "(Lcom/adjust/sdk/AdjustEventSuccess;)V", "GetOnFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_Handler:Com.Adjust.Sdk.IOnEventTrackingSucceededListenerInvoker, MatchBlocks.Android")]
		void OnFinishedEventTrackingSucceeded (global::Com.Adjust.Sdk.AdjustEventSuccess p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnEventTrackingSucceededListener", DoNotGenerateAcw=true)]
	internal partial class IOnEventTrackingSucceededListenerInvoker : global::Java.Lang.Object, IOnEventTrackingSucceededListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnEventTrackingSucceededListener", typeof (IOnEventTrackingSucceededListenerInvoker));

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

		public static IOnEventTrackingSucceededListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnEventTrackingSucceededListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnEventTrackingSucceededListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnEventTrackingSucceededListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_;
#pragma warning disable 0169
		static Delegate GetOnFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_Handler ()
		{
			if (cb_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_ == null)
				cb_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_));
			return cb_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_;
		}

		static void n_OnFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnEventTrackingSucceededListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustEventSuccess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFinishedEventTrackingSucceeded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_;
		public unsafe void OnFinishedEventTrackingSucceeded (global::Com.Adjust.Sdk.AdjustEventSuccess p0)
		{
			if (id_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_ == IntPtr.Zero)
				id_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_ = JNIEnv.GetMethodID (class_ref, "onFinishedEventTrackingSucceeded", "(Lcom/adjust/sdk/AdjustEventSuccess;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinishedEventTrackingSucceeded_Lcom_adjust_sdk_AdjustEventSuccess_, __args);
		}

	}

	// event args for com.adjust.sdk.OnEventTrackingSucceededListener.onFinishedEventTrackingSucceeded
	public partial class EventTrackingSucceededEventArgs : global::System.EventArgs {
		public EventTrackingSucceededEventArgs (global::Com.Adjust.Sdk.AdjustEventSuccess p0)
		{
			this.p0 = p0;
		}

		global::Com.Adjust.Sdk.AdjustEventSuccess p0;

		public global::Com.Adjust.Sdk.AdjustEventSuccess P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnEventTrackingSucceededListenerImplementor")]
	internal sealed partial class IOnEventTrackingSucceededListenerImplementor : global::Java.Lang.Object, IOnEventTrackingSucceededListener {

		object sender;

		public unsafe IOnEventTrackingSucceededListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<EventTrackingSucceededEventArgs> Handler;
		#pragma warning restore 0649

		public void OnFinishedEventTrackingSucceeded (global::Com.Adjust.Sdk.AdjustEventSuccess p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventTrackingSucceededEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnEventTrackingSucceededListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
