using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']"
	[Register ("com/adjust/sdk/ILogger", "", "Com.Adjust.Sdk.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='Assert' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("Assert", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetAssert_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void Assert (string p0, params global::Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("debug", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetDebug_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void Debug (string p0, params global::Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("error", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetError_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void Error (string p0, params global::Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("info", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetInfo_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void Info (string p0, params global::Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='lockLogLevel' and count(parameter)=0]"
		[Register ("lockLogLevel", "()V", "GetLockLogLevelHandler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void LockLogLevel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='setLogLevel' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.LogLevel'] and parameter[2][@type='boolean']]"
		[Register ("setLogLevel", "(Lcom/adjust/sdk/LogLevel;Z)V", "GetSetLogLevel_Lcom_adjust_sdk_LogLevel_ZHandler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void SetLogLevel (global::Com.Adjust.Sdk.LogLevel p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='setLogLevelString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setLogLevelString", "(Ljava/lang/String;Z)V", "GetSetLogLevelString_Ljava_lang_String_ZHandler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void SetLogLevelString (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='verbose' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("verbose", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetVerbose_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void Verbose (string p0, params global::Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("warn", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetWarn_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void Warn (string p0, params global::Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ILogger']/method[@name='warnInProduction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("warnInProduction", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetWarnInProduction_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Adjust.Sdk.ILoggerInvoker, MatchBlocks.Android")]
		void WarnInProduction (string p0, params global::Java.Lang.Object[] p1);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/ILogger", DoNotGenerateAcw=true)]
	internal partial class ILoggerInvoker : global::Java.Lang.Object, ILogger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/ILogger", typeof (ILoggerInvoker));

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

		public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.ILogger'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_Assert_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAssert_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_Assert_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_Assert_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Assert_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_Assert_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Assert_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Assert (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_Assert_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Assert (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_Assert_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_Assert_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "Assert", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Assert_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_debug_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_debug_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_debug_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Debug_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_debug_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Debug_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Debug (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_debug_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Debug (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_debug_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_error_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Error_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Error (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_error_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Error (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_error_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_error_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Info_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Info (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_info_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_info_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_lockLogLevel;
#pragma warning disable 0169
		static Delegate GetLockLogLevelHandler ()
		{
			if (cb_lockLogLevel == null)
				cb_lockLogLevel = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LockLogLevel));
			return cb_lockLogLevel;
		}

		static void n_LockLogLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LockLogLevel ();
		}
#pragma warning restore 0169

		IntPtr id_lockLogLevel;
		public unsafe void LockLogLevel ()
		{
			if (id_lockLogLevel == IntPtr.Zero)
				id_lockLogLevel = JNIEnv.GetMethodID (class_ref, "lockLogLevel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_lockLogLevel);
		}

		static Delegate cb_setLogLevel_Lcom_adjust_sdk_LogLevel_Z;
#pragma warning disable 0169
		static Delegate GetSetLogLevel_Lcom_adjust_sdk_LogLevel_ZHandler ()
		{
			if (cb_setLogLevel_Lcom_adjust_sdk_LogLevel_Z == null)
				cb_setLogLevel_Lcom_adjust_sdk_LogLevel_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_V (n_SetLogLevel_Lcom_adjust_sdk_LogLevel_Z));
			return cb_setLogLevel_Lcom_adjust_sdk_LogLevel_Z;
		}

		static void n_SetLogLevel_Lcom_adjust_sdk_LogLevel_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.LogLevel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogLevel (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setLogLevel_Lcom_adjust_sdk_LogLevel_Z;
		public unsafe void SetLogLevel (global::Com.Adjust.Sdk.LogLevel p0, bool p1)
		{
			if (id_setLogLevel_Lcom_adjust_sdk_LogLevel_Z == IntPtr.Zero)
				id_setLogLevel_Lcom_adjust_sdk_LogLevel_Z = JNIEnv.GetMethodID (class_ref, "setLogLevel", "(Lcom/adjust/sdk/LogLevel;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogLevel_Lcom_adjust_sdk_LogLevel_Z, __args);
		}

		static Delegate cb_setLogLevelString_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetLogLevelString_Ljava_lang_String_ZHandler ()
		{
			if (cb_setLogLevelString_Ljava_lang_String_Z == null)
				cb_setLogLevelString_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_V (n_SetLogLevelString_Ljava_lang_String_Z));
			return cb_setLogLevelString_Ljava_lang_String_Z;
		}

		static void n_SetLogLevelString_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogLevelString (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setLogLevelString_Ljava_lang_String_Z;
		public unsafe void SetLogLevelString (string p0, bool p1)
		{
			if (id_setLogLevelString_Ljava_lang_String_Z == IntPtr.Zero)
				id_setLogLevelString_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setLogLevelString", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogLevelString_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetVerbose_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Verbose_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_verbose_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Verbose_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Verbose (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_verbose_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Verbose (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_verbose_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_verbose_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "verbose", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verbose_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_warn_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warn_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warn_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_Warn_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_warn_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warn_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warn (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_warn_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Warn (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_warn_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarnInProduction_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_WarnInProduction_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_WarnInProduction_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.WarnInProduction (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void WarnInProduction (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warnInProduction", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warnInProduction_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
