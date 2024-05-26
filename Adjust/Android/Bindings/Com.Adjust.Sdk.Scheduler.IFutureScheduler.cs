using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk.Scheduler {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='FutureScheduler']"
	[Register ("com/adjust/sdk/scheduler/FutureScheduler", "", "Com.Adjust.Sdk.Scheduler.IFutureSchedulerInvoker")]
	public partial interface IFutureScheduler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='FutureScheduler']/method[@name='scheduleFuture' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("scheduleFuture", "(Ljava/lang/Runnable;J)Ljava/util/concurrent/ScheduledFuture;", "GetScheduleFuture_Ljava_lang_Runnable_JHandler:Com.Adjust.Sdk.Scheduler.IFutureSchedulerInvoker, MatchBlocks.Android")]
		global::Java.Util.Concurrent.IScheduledFuture ScheduleFuture (global::Java.Lang.IRunnable p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='FutureScheduler']/method[@name='scheduleFutureWithFixedDelay' and count(parameter)=3 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("scheduleFutureWithFixedDelay", "(Ljava/lang/Runnable;JJ)Ljava/util/concurrent/ScheduledFuture;", "GetScheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJHandler:Com.Adjust.Sdk.Scheduler.IFutureSchedulerInvoker, MatchBlocks.Android")]
		global::Java.Util.Concurrent.IScheduledFuture ScheduleFutureWithFixedDelay (global::Java.Lang.IRunnable p0, long p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='FutureScheduler']/method[@name='scheduleFutureWithReturn' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;V&gt;'] and parameter[2][@type='long']]"
		[Register ("scheduleFutureWithReturn", "(Ljava/util/concurrent/Callable;J)Ljava/util/concurrent/ScheduledFuture;", "GetScheduleFutureWithReturn_Ljava_util_concurrent_Callable_JHandler:Com.Adjust.Sdk.Scheduler.IFutureSchedulerInvoker, MatchBlocks.Android")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		global::Java.Util.Concurrent.IScheduledFuture ScheduleFutureWithReturn (global::Java.Util.Concurrent.ICallable p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='FutureScheduler']/method[@name='teardown' and count(parameter)=0]"
		[Register ("teardown", "()V", "GetTeardownHandler:Com.Adjust.Sdk.Scheduler.IFutureSchedulerInvoker, MatchBlocks.Android")]
		void Teardown ();

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/scheduler/FutureScheduler", DoNotGenerateAcw=true)]
	internal partial class IFutureSchedulerInvoker : global::Java.Lang.Object, IFutureScheduler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/scheduler/FutureScheduler", typeof (IFutureSchedulerInvoker));

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

		public static IFutureScheduler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFutureScheduler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.scheduler.FutureScheduler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFutureSchedulerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_scheduleFuture_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetScheduleFuture_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_scheduleFuture_Ljava_lang_Runnable_J == null)
				cb_scheduleFuture_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJ_L (n_ScheduleFuture_Ljava_lang_Runnable_J));
			return cb_scheduleFuture_Ljava_lang_Runnable_J;
		}

		static IntPtr n_ScheduleFuture_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IFutureScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleFuture (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_scheduleFuture_Ljava_lang_Runnable_J;
		public unsafe global::Java.Util.Concurrent.IScheduledFuture ScheduleFuture (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_scheduleFuture_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_scheduleFuture_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "scheduleFuture", "(Ljava/lang/Runnable;J)Ljava/util/concurrent/ScheduledFuture;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheduleFuture_Ljava_lang_Runnable_J, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ;
#pragma warning disable 0169
		static Delegate GetScheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJHandler ()
		{
			if (cb_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ == null)
				cb_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJJ_L (n_ScheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ));
			return cb_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ;
		}

		static IntPtr n_ScheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IFutureScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleFutureWithFixedDelay (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ;
		public unsafe global::Java.Util.Concurrent.IScheduledFuture ScheduleFutureWithFixedDelay (global::Java.Lang.IRunnable p0, long p1, long p2)
		{
			if (id_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ == IntPtr.Zero)
				id_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ = JNIEnv.GetMethodID (class_ref, "scheduleFutureWithFixedDelay", "(Ljava/lang/Runnable;JJ)Ljava/util/concurrent/ScheduledFuture;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheduleFutureWithFixedDelay_Ljava_lang_Runnable_JJ, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J;
#pragma warning disable 0169
		static Delegate GetScheduleFutureWithReturn_Ljava_util_concurrent_Callable_JHandler ()
		{
			if (cb_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J == null)
				cb_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJ_L (n_ScheduleFutureWithReturn_Ljava_util_concurrent_Callable_J));
			return cb_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J;
		}

		static IntPtr n_ScheduleFutureWithReturn_Ljava_util_concurrent_Callable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IFutureScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleFutureWithReturn (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J;
		public unsafe global::Java.Util.Concurrent.IScheduledFuture ScheduleFutureWithReturn (global::Java.Util.Concurrent.ICallable p0, long p1)
		{
			if (id_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J == IntPtr.Zero)
				id_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J = JNIEnv.GetMethodID (class_ref, "scheduleFutureWithReturn", "(Ljava/util/concurrent/Callable;J)Ljava/util/concurrent/ScheduledFuture;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_scheduleFutureWithReturn_Ljava_util_concurrent_Callable_J, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IFutureScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
