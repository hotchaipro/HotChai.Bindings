using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']"
	[Register ("com/adjust/sdk/IAttributionHandler", "", "Com.Adjust.Sdk.IAttributionHandlerInvoker")]
	public partial interface IAttributionHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']/method[@name='checkSdkClickResponse' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.SdkClickResponseData']]"
		[Register ("checkSdkClickResponse", "(Lcom/adjust/sdk/SdkClickResponseData;)V", "GetCheckSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_Handler:Com.Adjust.Sdk.IAttributionHandlerInvoker, MatchBlocks.Android")]
		void CheckSdkClickResponse (global::Com.Adjust.Sdk.SdkClickResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']/method[@name='checkSessionResponse' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.SessionResponseData']]"
		[Register ("checkSessionResponse", "(Lcom/adjust/sdk/SessionResponseData;)V", "GetCheckSessionResponse_Lcom_adjust_sdk_SessionResponseData_Handler:Com.Adjust.Sdk.IAttributionHandlerInvoker, MatchBlocks.Android")]
		void CheckSessionResponse (global::Com.Adjust.Sdk.SessionResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']/method[@name='getAttribution' and count(parameter)=0]"
		[Register ("getAttribution", "()V", "GetGetAttributionHandler:Com.Adjust.Sdk.IAttributionHandlerInvoker, MatchBlocks.Android")]
		void GetAttribution ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.adjust.sdk.IActivityHandler'] and parameter[2][@type='boolean'] and parameter[3][@type='com.adjust.sdk.network.IActivityPackageSender']]"
		[Register ("init", "(Lcom/adjust/sdk/IActivityHandler;ZLcom/adjust/sdk/network/IActivityPackageSender;)V", "GetInit_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_Handler:Com.Adjust.Sdk.IAttributionHandlerInvoker, MatchBlocks.Android")]
		void Init (global::Com.Adjust.Sdk.IActivityHandler p0, bool p1, global::Com.Adjust.Sdk.Network.IActivityPackageSender p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']/method[@name='pauseSending' and count(parameter)=0]"
		[Register ("pauseSending", "()V", "GetPauseSendingHandler:Com.Adjust.Sdk.IAttributionHandlerInvoker, MatchBlocks.Android")]
		void PauseSending ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']/method[@name='resumeSending' and count(parameter)=0]"
		[Register ("resumeSending", "()V", "GetResumeSendingHandler:Com.Adjust.Sdk.IAttributionHandlerInvoker, MatchBlocks.Android")]
		void ResumeSending ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IAttributionHandler']/method[@name='teardown' and count(parameter)=0]"
		[Register ("teardown", "()V", "GetTeardownHandler:Com.Adjust.Sdk.IAttributionHandlerInvoker, MatchBlocks.Android")]
		void Teardown ();

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/IAttributionHandler", DoNotGenerateAcw=true)]
	internal partial class IAttributionHandlerInvoker : global::Java.Lang.Object, IAttributionHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/IAttributionHandler", typeof (IAttributionHandlerInvoker));

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

		public static IAttributionHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAttributionHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.IAttributionHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAttributionHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_;
#pragma warning disable 0169
		static Delegate GetCheckSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_Handler ()
		{
			if (cb_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_ == null)
				cb_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_CheckSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_));
			return cb_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_;
		}

		static void n_CheckSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IAttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.SdkClickResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckSdkClickResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_;
		public unsafe void CheckSdkClickResponse (global::Com.Adjust.Sdk.SdkClickResponseData p0)
		{
			if (id_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_ == IntPtr.Zero)
				id_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_ = JNIEnv.GetMethodID (class_ref, "checkSdkClickResponse", "(Lcom/adjust/sdk/SdkClickResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_, __args);
		}

		static Delegate cb_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_;
#pragma warning disable 0169
		static Delegate GetCheckSessionResponse_Lcom_adjust_sdk_SessionResponseData_Handler ()
		{
			if (cb_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_ == null)
				cb_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_CheckSessionResponse_Lcom_adjust_sdk_SessionResponseData_));
			return cb_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_;
		}

		static void n_CheckSessionResponse_Lcom_adjust_sdk_SessionResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IAttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.SessionResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckSessionResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_;
		public unsafe void CheckSessionResponse (global::Com.Adjust.Sdk.SessionResponseData p0)
		{
			if (id_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_ == IntPtr.Zero)
				id_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_ = JNIEnv.GetMethodID (class_ref, "checkSessionResponse", "(Lcom/adjust/sdk/SessionResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkSessionResponse_Lcom_adjust_sdk_SessionResponseData_, __args);
		}

		static Delegate cb_getAttribution;
#pragma warning disable 0169
		static Delegate GetGetAttributionHandler ()
		{
			if (cb_getAttribution == null)
				cb_getAttribution = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_GetAttribution));
			return cb_getAttribution;
		}

		static void n_GetAttribution (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IAttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetAttribution ();
		}
#pragma warning restore 0169

		IntPtr id_getAttribution;
		public unsafe void GetAttribution ()
		{
			if (id_getAttribution == IntPtr.Zero)
				id_getAttribution = JNIEnv.GetMethodID (class_ref, "getAttribution", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAttribution);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IAttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IAttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IAttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IAttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
