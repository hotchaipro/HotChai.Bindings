using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk.Scheduler {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='ThreadScheduler']"
	[Register ("com/adjust/sdk/scheduler/ThreadScheduler", "", "Com.Adjust.Sdk.Scheduler.IThreadSchedulerInvoker")]
	public partial interface IThreadScheduler : global::Com.Adjust.Sdk.Scheduler.IThreadExecutor {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='ThreadScheduler']/method[@name='schedule' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("schedule", "(Ljava/lang/Runnable;J)V", "GetSchedule_Ljava_lang_Runnable_JHandler:Com.Adjust.Sdk.Scheduler.IThreadSchedulerInvoker, MatchBlocks.Android")]
		void Schedule (global::Java.Lang.IRunnable p0, long p1);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/scheduler/ThreadScheduler", DoNotGenerateAcw=true)]
	internal partial class IThreadSchedulerInvoker : global::Java.Lang.Object, IThreadScheduler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/scheduler/ThreadScheduler", typeof (IThreadSchedulerInvoker));

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

		public static IThreadScheduler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThreadScheduler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.scheduler.ThreadScheduler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThreadSchedulerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_schedule_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetSchedule_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_schedule_Ljava_lang_Runnable_J == null)
				cb_schedule_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJ_V (n_Schedule_Ljava_lang_Runnable_J));
			return cb_schedule_Ljava_lang_Runnable_J;
		}

		static void n_Schedule_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IThreadScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Schedule (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_schedule_Ljava_lang_Runnable_J;
		public unsafe void Schedule (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_schedule_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_schedule_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "schedule", "(Ljava/lang/Runnable;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Ljava_lang_Runnable_J, __args);
		}

		static Delegate cb_submit_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Handler ()
		{
			if (cb_submit_Ljava_lang_Runnable_ == null)
				cb_submit_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Submit_Ljava_lang_Runnable_));
			return cb_submit_Ljava_lang_Runnable_;
		}

		static void n_Submit_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IThreadScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Submit (p0);
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_lang_Runnable_;
		public unsafe void Submit (global::Java.Lang.IRunnable p0)
		{
			if (id_submit_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_submit_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "submit", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_submit_Ljava_lang_Runnable_, __args);
		}

		static Delegate cb_teardown;
#pragma warning disable 0169
		static Delegate GetTeardownHandler ()
		{
			if (cb_teardown == null)
				cb_teardown = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Teardown));
			return cb_teardown;
		}

		static void n_Teardown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IThreadScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Teardown ();
		}
#pragma warning restore 0169

		IntPtr id_teardown;
		public unsafe void Teardown ()
		{
			if (id_teardown == IntPtr.Zero)
				id_teardown = JNIEnv.GetMethodID (class_ref, "teardown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_teardown);
		}

	}
}
