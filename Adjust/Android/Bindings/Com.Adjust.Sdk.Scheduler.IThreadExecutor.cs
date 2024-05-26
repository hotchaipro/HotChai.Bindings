using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk.Scheduler {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='ThreadExecutor']"
	[Register ("com/adjust/sdk/scheduler/ThreadExecutor", "", "Com.Adjust.Sdk.Scheduler.IThreadExecutorInvoker")]
	public partial interface IThreadExecutor : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='ThreadExecutor']/method[@name='submit' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("submit", "(Ljava/lang/Runnable;)V", "GetSubmit_Ljava_lang_Runnable_Handler:Com.Adjust.Sdk.Scheduler.IThreadExecutorInvoker, MatchBlocks.Android")]
		void Submit (global::Java.Lang.IRunnable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/interface[@name='ThreadExecutor']/method[@name='teardown' and count(parameter)=0]"
		[Register ("teardown", "()V", "GetTeardownHandler:Com.Adjust.Sdk.Scheduler.IThreadExecutorInvoker, MatchBlocks.Android")]
		void Teardown ();

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/scheduler/ThreadExecutor", DoNotGenerateAcw=true)]
	internal partial class IThreadExecutorInvoker : global::Java.Lang.Object, IThreadExecutor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/scheduler/ThreadExecutor", typeof (IThreadExecutorInvoker));

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

		public static IThreadExecutor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThreadExecutor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.scheduler.ThreadExecutor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThreadExecutorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IThreadExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.IThreadExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
