using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']"
	[Register ("com/adjust/sdk/ISdkClickHandler", "", "Com.Adjust.Sdk.ISdkClickHandlerInvoker")]
	public partial interface ISdkClickHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.adjust.sdk.IActivityHandler'] and parameter[2][@type='boolean'] and parameter[3][@type='com.adjust.sdk.network.IActivityPackageSender']]"
		[Register ("init", "(Lcom/adjust/sdk/IActivityHandler;ZLcom/adjust/sdk/network/IActivityPackageSender;)V", "GetInit_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_Handler:Com.Adjust.Sdk.ISdkClickHandlerInvoker, MatchBlocks.Android")]
		void Init (global::Com.Adjust.Sdk.IActivityHandler p0, bool p1, global::Com.Adjust.Sdk.Network.IActivityPackageSender p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']/method[@name='pauseSending' and count(parameter)=0]"
		[Register ("pauseSending", "()V", "GetPauseSendingHandler:Com.Adjust.Sdk.ISdkClickHandlerInvoker, MatchBlocks.Android")]
		void PauseSending ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']/method[@name='resumeSending' and count(parameter)=0]"
		[Register ("resumeSending", "()V", "GetResumeSendingHandler:Com.Adjust.Sdk.ISdkClickHandlerInvoker, MatchBlocks.Android")]
		void ResumeSending ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']/method[@name='sendPreinstallPayload' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendPreinstallPayload", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_Handler:Com.Adjust.Sdk.ISdkClickHandlerInvoker, MatchBlocks.Android")]
		void SendPreinstallPayload (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']/method[@name='sendReftagReferrers' and count(parameter)=0]"
		[Register ("sendReftagReferrers", "()V", "GetSendReftagReferrersHandler:Com.Adjust.Sdk.ISdkClickHandlerInvoker, MatchBlocks.Android")]
		void SendReftagReferrers ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']/method[@name='sendSdkClick' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.ActivityPackage']]"
		[Register ("sendSdkClick", "(Lcom/adjust/sdk/ActivityPackage;)V", "GetSendSdkClick_Lcom_adjust_sdk_ActivityPackage_Handler:Com.Adjust.Sdk.ISdkClickHandlerInvoker, MatchBlocks.Android")]
		void SendSdkClick (global::Com.Adjust.Sdk.ActivityPackage p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='ISdkClickHandler']/method[@name='teardown' and count(parameter)=0]"
		[Register ("teardown", "()V", "GetTeardownHandler:Com.Adjust.Sdk.ISdkClickHandlerInvoker, MatchBlocks.Android")]
		void Teardown ();

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/ISdkClickHandler", DoNotGenerateAcw=true)]
	internal partial class ISdkClickHandlerInvoker : global::Java.Lang.Object, ISdkClickHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/ISdkClickHandler", typeof (ISdkClickHandlerInvoker));

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

		public static ISdkClickHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISdkClickHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.ISdkClickHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISdkClickHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_Handler ()
		{
			if (cb_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_ == null)
				cb_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZL_V (n_Init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_));
			return cb_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_;
		}

		static void n_Init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ISdkClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Adjust.Sdk.IActivityHandler)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Adjust.Sdk.Network.IActivityPackageSender)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Network.IActivityPackageSender> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_;
		public unsafe void Init (global::Com.Adjust.Sdk.IActivityHandler p0, bool p1, global::Com.Adjust.Sdk.Network.IActivityPackageSender p2)
		{
			if (id_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_ == IntPtr.Zero)
				id_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/adjust/sdk/IActivityHandler;ZLcom/adjust/sdk/network/IActivityPackageSender;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_, __args);
		}

		static Delegate cb_pauseSending;
#pragma warning disable 0169
		static Delegate GetPauseSendingHandler ()
		{
			if (cb_pauseSending == null)
				cb_pauseSending = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PauseSending));
			return cb_pauseSending;
		}

		static void n_PauseSending (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ISdkClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseSending ();
		}
#pragma warning restore 0169

		IntPtr id_pauseSending;
		public unsafe void PauseSending ()
		{
			if (id_pauseSending == IntPtr.Zero)
				id_pauseSending = JNIEnv.GetMethodID (class_ref, "pauseSending", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseSending);
		}

		static Delegate cb_resumeSending;
#pragma warning disable 0169
		static Delegate GetResumeSendingHandler ()
		{
			if (cb_resumeSending == null)
				cb_resumeSending = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ResumeSending));
			return cb_resumeSending;
		}

		static void n_ResumeSending (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ISdkClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeSending ();
		}
#pragma warning restore 0169

		IntPtr id_resumeSending;
		public unsafe void ResumeSending ()
		{
			if (id_resumeSending == IntPtr.Zero)
				id_resumeSending = JNIEnv.GetMethodID (class_ref, "resumeSending", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeSending);
		}

		static Delegate cb_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_));
			return cb_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ISdkClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendPreinstallPayload (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SendPreinstallPayload (string p0, string p1)
		{
			if (id_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendPreinstallPayload", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPreinstallPayload_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sendReftagReferrers;
#pragma warning disable 0169
		static Delegate GetSendReftagReferrersHandler ()
		{
			if (cb_sendReftagReferrers == null)
				cb_sendReftagReferrers = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SendReftagReferrers));
			return cb_sendReftagReferrers;
		}

		static void n_SendReftagReferrers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ISdkClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendReftagReferrers ();
		}
#pragma warning restore 0169

		IntPtr id_sendReftagReferrers;
		public unsafe void SendReftagReferrers ()
		{
			if (id_sendReftagReferrers == IntPtr.Zero)
				id_sendReftagReferrers = JNIEnv.GetMethodID (class_ref, "sendReftagReferrers", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendReftagReferrers);
		}

		static Delegate cb_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_;
#pragma warning disable 0169
		static Delegate GetSendSdkClick_Lcom_adjust_sdk_ActivityPackage_Handler ()
		{
			if (cb_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_ == null)
				cb_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SendSdkClick_Lcom_adjust_sdk_ActivityPackage_));
			return cb_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_;
		}

		static void n_SendSdkClick_Lcom_adjust_sdk_ActivityPackage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ISdkClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendSdkClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_;
		public unsafe void SendSdkClick (global::Com.Adjust.Sdk.ActivityPackage p0)
		{
			if (id_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_ == IntPtr.Zero)
				id_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_ = JNIEnv.GetMethodID (class_ref, "sendSdkClick", "(Lcom/adjust/sdk/ActivityPackage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSdkClick_Lcom_adjust_sdk_ActivityPackage_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ISdkClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
