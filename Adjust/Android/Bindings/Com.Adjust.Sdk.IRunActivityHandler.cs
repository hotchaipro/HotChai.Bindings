using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IRunActivityHandler']"
	[Register ("com/adjust/sdk/IRunActivityHandler", "", "Com.Adjust.Sdk.IRunActivityHandlerInvoker")]
	public partial interface IRunActivityHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IRunActivityHandler']/method[@name='run' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.ActivityHandler']]"
		[Register ("run", "(Lcom/adjust/sdk/ActivityHandler;)V", "GetRun_Lcom_adjust_sdk_ActivityHandler_Handler:Com.Adjust.Sdk.IRunActivityHandlerInvoker, MatchBlocks.Android")]
		void Run (global::Com.Adjust.Sdk.ActivityHandler p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/IRunActivityHandler", DoNotGenerateAcw=true)]
	internal partial class IRunActivityHandlerInvoker : global::Java.Lang.Object, IRunActivityHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/IRunActivityHandler", typeof (IRunActivityHandlerInvoker));

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

		public static IRunActivityHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRunActivityHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.IRunActivityHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRunActivityHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_run_Lcom_adjust_sdk_ActivityHandler_;
#pragma warning disable 0169
		static Delegate GetRun_Lcom_adjust_sdk_ActivityHandler_Handler ()
		{
			if (cb_run_Lcom_adjust_sdk_ActivityHandler_ == null)
				cb_run_Lcom_adjust_sdk_ActivityHandler_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Run_Lcom_adjust_sdk_ActivityHandler_));
			return cb_run_Lcom_adjust_sdk_ActivityHandler_;
		}

		static void n_Run_Lcom_adjust_sdk_ActivityHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IRunActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Run (p0);
		}
#pragma warning restore 0169

		IntPtr id_run_Lcom_adjust_sdk_ActivityHandler_;
		public unsafe void Run (global::Com.Adjust.Sdk.ActivityHandler p0)
		{
			if (id_run_Lcom_adjust_sdk_ActivityHandler_ == IntPtr.Zero)
				id_run_Lcom_adjust_sdk_ActivityHandler_ = JNIEnv.GetMethodID (class_ref, "run", "(Lcom/adjust/sdk/ActivityHandler;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run_Lcom_adjust_sdk_ActivityHandler_, __args);
		}

	}
}
