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

namespace Com.IronSource.MediationSdk.Logger {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']"
	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/logger/IronSourceLoggerManager", DoNotGenerateAcw=true)]
	public partial class IronSourceLoggerManager : global::Com.IronSource.MediationSdk.Logger.IronSourceLogger, global::Com.IronSource.MediationSdk.Logger.ILogListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/logger/IronSourceLoggerManager", typeof (IronSourceLoggerManager));

		internal static new IntPtr class_ref {
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

		protected IronSourceLoggerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Lcom/ironsource/mediationsdk/logger/IronSourceLoggerManager;", "")]
			get {
				const string __id = "getLogger.()Lcom/ironsource/mediationsdk/logger/IronSourceLoggerManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_;
#pragma warning disable 0169
		static Delegate GetAddLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_Handler ()
		{
			if (cb_addLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_ == null)
				cb_addLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_AddLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_));
			return cb_addLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_;
		}

		static void n_AddLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLogger> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLogger (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']/method[@name='addLogger' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceLogger']]"
		[Register ("addLogger", "(Lcom/ironsource/mediationsdk/logger/IronSourceLogger;)V", "GetAddLogger_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_Handler")]
		public virtual unsafe void AddLogger (global::Com.IronSource.MediationSdk.Logger.IronSourceLogger p0)
		{
			const string __id = "addLogger.(Lcom/ironsource/mediationsdk/logger/IronSourceLogger;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLogger", "(I)Lcom/ironsource/mediationsdk/logger/IronSourceLoggerManager;", "")]
		public static unsafe global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager GetLogger (int p0)
		{
			const string __id = "getLogger.(I)Lcom/ironsource/mediationsdk/logger/IronSourceLoggerManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_log_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_IHandler ()
		{
			if (cb_log_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I == null)
				cb_log_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_Log_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I));
			return cb_log_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I;
		}

		static void n_Log_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']/method[@name='log' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceLogger.IronSourceTag'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("log", "(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;I)V", "GetLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_IHandler")]
		public override unsafe void Log (global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0, string p1, int p2)
		{
			const string __id = "log.(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;I)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_logException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLogException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_logException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_logException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_LogException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_));
			return cb_logException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_LogException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LogException (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']/method[@name='logException' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceLogger.IronSourceTag'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("logException", "(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLogException_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public override unsafe void LogException (global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0, string p1, global::Java.Lang.Throwable p2)
		{
			const string __id = "logException.(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_IHandler ()
		{
			if (cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I == null)
				cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_OnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I));
			return cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I;
		}

		static void n_OnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLog (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']/method[@name='onLog' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceLogger.IronSourceTag'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("onLog", "(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;I)V", "GetOnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_IHandler")]
		public virtual unsafe void OnLog (global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0, string p1, int p2)
		{
			const string __id = "onLog.(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;I)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setLoggerDebugLevel_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetLoggerDebugLevel_Ljava_lang_String_IHandler ()
		{
			if (cb_setLoggerDebugLevel_Ljava_lang_String_I == null)
				cb_setLoggerDebugLevel_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_SetLoggerDebugLevel_Ljava_lang_String_I));
			return cb_setLoggerDebugLevel_Ljava_lang_String_I;
		}

		static void n_SetLoggerDebugLevel_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLoggerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLoggerDebugLevel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/class[@name='IronSourceLoggerManager']/method[@name='setLoggerDebugLevel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setLoggerDebugLevel", "(Ljava/lang/String;I)V", "GetSetLoggerDebugLevel_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetLoggerDebugLevel (string p0, int p1)
		{
			const string __id = "setLoggerDebugLevel.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
