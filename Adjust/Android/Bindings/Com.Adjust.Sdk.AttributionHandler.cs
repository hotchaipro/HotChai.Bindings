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

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']"
	[global::Android.Runtime.Register ("com/adjust/sdk/AttributionHandler", DoNotGenerateAcw=true)]
	public partial class AttributionHandler : global::Java.Lang.Object, global::Com.Adjust.Sdk.IAttributionHandler, global::Com.Adjust.Sdk.Network.IActivityPackageSender.IResponseDataCallbackSubscriber {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/AttributionHandler", typeof (AttributionHandler));

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

		protected AttributionHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/constructor[@name='AttributionHandler' and count(parameter)=3 and parameter[1][@type='com.adjust.sdk.IActivityHandler'] and parameter[2][@type='boolean'] and parameter[3][@type='com.adjust.sdk.network.IActivityPackageSender']]"
		[Register (".ctor", "(Lcom/adjust/sdk/IActivityHandler;ZLcom/adjust/sdk/network/IActivityPackageSender;)V", "")]
		public unsafe AttributionHandler (global::Com.Adjust.Sdk.IActivityHandler p0, bool p1, global::Com.Adjust.Sdk.Network.IActivityPackageSender p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/adjust/sdk/IActivityHandler;ZLcom/adjust/sdk/network/IActivityPackageSender;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_checkAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_;
#pragma warning disable 0169
		static Delegate GetCheckAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_Handler ()
		{
			if (cb_checkAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_ == null)
				cb_checkAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_CheckAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_));
			return cb_checkAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_;
		}

		static void n_CheckAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckAttributionResponse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='checkAttributionResponse' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AttributionResponseData']]"
		[Register ("checkAttributionResponse", "(Lcom/adjust/sdk/AttributionResponseData;)V", "GetCheckAttributionResponse_Lcom_adjust_sdk_AttributionResponseData_Handler")]
		public virtual unsafe void CheckAttributionResponse (global::Com.Adjust.Sdk.AttributionResponseData p0)
		{
			const string __id = "checkAttributionResponse.(Lcom/adjust/sdk/AttributionResponseData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.SdkClickResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckSdkClickResponse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='checkSdkClickResponse' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.SdkClickResponseData']]"
		[Register ("checkSdkClickResponse", "(Lcom/adjust/sdk/SdkClickResponseData;)V", "GetCheckSdkClickResponse_Lcom_adjust_sdk_SdkClickResponseData_Handler")]
		public virtual unsafe void CheckSdkClickResponse (global::Com.Adjust.Sdk.SdkClickResponseData p0)
		{
			const string __id = "checkSdkClickResponse.(Lcom/adjust/sdk/SdkClickResponseData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.SessionResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckSessionResponse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='checkSessionResponse' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.SessionResponseData']]"
		[Register ("checkSessionResponse", "(Lcom/adjust/sdk/SessionResponseData;)V", "GetCheckSessionResponse_Lcom_adjust_sdk_SessionResponseData_Handler")]
		public virtual unsafe void CheckSessionResponse (global::Com.Adjust.Sdk.SessionResponseData p0)
		{
			const string __id = "checkSessionResponse.(Lcom/adjust/sdk/SessionResponseData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetAttribution ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='getAttribution' and count(parameter)=0]"
		[Register ("getAttribution", "()V", "GetGetAttributionHandler")]
		public virtual unsafe void GetAttribution ()
		{
			const string __id = "getAttribution.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Adjust.Sdk.IActivityHandler)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Adjust.Sdk.Network.IActivityPackageSender)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Network.IActivityPackageSender> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.adjust.sdk.IActivityHandler'] and parameter[2][@type='boolean'] and parameter[3][@type='com.adjust.sdk.network.IActivityPackageSender']]"
		[Register ("init", "(Lcom/adjust/sdk/IActivityHandler;ZLcom/adjust/sdk/network/IActivityPackageSender;)V", "GetInit_Lcom_adjust_sdk_IActivityHandler_ZLcom_adjust_sdk_network_IActivityPackageSender_Handler")]
		public virtual unsafe void Init (global::Com.Adjust.Sdk.IActivityHandler p0, bool p1, global::Com.Adjust.Sdk.Network.IActivityPackageSender p2)
		{
			const string __id = "init.(Lcom/adjust/sdk/IActivityHandler;ZLcom/adjust/sdk/network/IActivityPackageSender;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_;
#pragma warning disable 0169
		static Delegate GetOnResponseDataCallback_Lcom_adjust_sdk_ResponseData_Handler ()
		{
			if (cb_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_ == null)
				cb_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnResponseDataCallback_Lcom_adjust_sdk_ResponseData_));
			return cb_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_;
		}

		static void n_OnResponseDataCallback_Lcom_adjust_sdk_ResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponseDataCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='onResponseDataCallback' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.ResponseData']]"
		[Register ("onResponseDataCallback", "(Lcom/adjust/sdk/ResponseData;)V", "GetOnResponseDataCallback_Lcom_adjust_sdk_ResponseData_Handler")]
		public virtual unsafe void OnResponseDataCallback (global::Com.Adjust.Sdk.ResponseData p0)
		{
			const string __id = "onResponseDataCallback.(Lcom/adjust/sdk/ResponseData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseSending ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='pauseSending' and count(parameter)=0]"
		[Register ("pauseSending", "()V", "GetPauseSendingHandler")]
		public virtual unsafe void PauseSending ()
		{
			const string __id = "pauseSending.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeSending ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='resumeSending' and count(parameter)=0]"
		[Register ("resumeSending", "()V", "GetResumeSendingHandler")]
		public virtual unsafe void ResumeSending ()
		{
			const string __id = "resumeSending.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Teardown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='AttributionHandler']/method[@name='teardown' and count(parameter)=0]"
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