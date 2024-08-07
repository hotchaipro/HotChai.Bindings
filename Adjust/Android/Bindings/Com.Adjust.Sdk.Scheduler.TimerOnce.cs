//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk.Scheduler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adjust.sdk.scheduler']/class[@name='TimerOnce']"
	[global::Android.Runtime.Register ("com/adjust/sdk/scheduler/TimerOnce", DoNotGenerateAcw=true)]
	public partial class TimerOnce : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/scheduler/TimerOnce", typeof (TimerOnce));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected TimerOnce (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adjust.sdk.scheduler']/class[@name='TimerOnce']/constructor[@name='TimerOnce' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Runnable;Ljava/lang/String;)V", "")]
		public unsafe TimerOnce (global::Java.Lang.IRunnable p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Runnable;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getFireIn;
#pragma warning disable 0169
		static Delegate GetGetFireInHandler ()
		{
			if (cb_getFireIn == null)
				cb_getFireIn = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetFireIn));
			return cb_getFireIn;
		}

		static long n_GetFireIn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.TimerOnce> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FireIn;
		}
#pragma warning restore 0169

		public virtual unsafe long FireIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/class[@name='TimerOnce']/method[@name='getFireIn' and count(parameter)=0]"
			[Register ("getFireIn", "()J", "GetGetFireInHandler")]
			get {
				const string __id = "getFireIn.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Cancel));
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.TimerOnce> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/class[@name='TimerOnce']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startIn_J;
#pragma warning disable 0169
		static Delegate GetStartIn_JHandler ()
		{
			if (cb_startIn_J == null)
				cb_startIn_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPJ_V (n_StartIn_J));
			return cb_startIn_J;
		}

		static void n_StartIn_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.TimerOnce> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartIn (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/class[@name='TimerOnce']/method[@name='startIn' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("startIn", "(J)V", "GetStartIn_JHandler")]
		public virtual unsafe void StartIn (long p0)
		{
			const string __id = "startIn.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Scheduler.TimerOnce> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Teardown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.scheduler']/class[@name='TimerOnce']/method[@name='teardown' and count(parameter)=0]"
		[Register ("teardown", "()V", "GetTeardownHandler")]
		public virtual unsafe void Teardown ()
		{
			const string __id = "teardown.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
