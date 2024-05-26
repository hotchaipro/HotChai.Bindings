using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk.Network {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='IActivityPackageSender']"
	[Register ("com/adjust/sdk/network/IActivityPackageSender", "", "Com.Adjust.Sdk.Network.IActivityPackageSenderInvoker")]
	public partial interface IActivityPackageSender : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='IActivityPackageSender']/method[@name='sendActivityPackage' and count(parameter)=3 and parameter[1][@type='com.adjust.sdk.ActivityPackage'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='com.adjust.sdk.network.IActivityPackageSender.ResponseDataCallbackSubscriber']]"
		[Register ("sendActivityPackage", "(Lcom/adjust/sdk/ActivityPackage;Ljava/util/Map;Lcom/adjust/sdk/network/IActivityPackageSender$ResponseDataCallbackSubscriber;)V", "GetSendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_Handler:Com.Adjust.Sdk.Network.IActivityPackageSenderInvoker, MatchBlocks.Android")]
		void SendActivityPackage (global::Com.Adjust.Sdk.ActivityPackage p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Com.Adjust.Sdk.Network.IActivityPackageSender.IResponseDataCallbackSubscriber p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='IActivityPackageSender']/method[@name='sendActivityPackageSync' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.ActivityPackage'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("sendActivityPackageSync", "(Lcom/adjust/sdk/ActivityPackage;Ljava/util/Map;)Lcom/adjust/sdk/ResponseData;", "GetSendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Handler:Com.Adjust.Sdk.Network.IActivityPackageSenderInvoker, MatchBlocks.Android")]
		global::Com.Adjust.Sdk.ResponseData SendActivityPackageSync (global::Com.Adjust.Sdk.ActivityPackage p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='IActivityPackageSender.ResponseDataCallbackSubscriber']"
		[Register ("com/adjust/sdk/network/IActivityPackageSender$ResponseDataCallbackSubscriber", "", "Com.Adjust.Sdk.Network.IActivityPackageSender/IResponseDataCallbackSubscriberInvoker")]
		public partial interface IResponseDataCallbackSubscriber : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='IActivityPackageSender.ResponseDataCallbackSubscriber']/method[@name='onResponseDataCallback' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.ResponseData']]"
			[Register ("onResponseDataCallback", "(Lcom/adjust/sdk/ResponseData;)V", "GetOnResponseDataCallback_Lcom_adjust_sdk_ResponseData_Handler:Com.Adjust.Sdk.Network.IActivityPackageSender/IResponseDataCallbackSubscriberInvoker, MatchBlocks.Android")]
			void OnResponseDataCallback (global::Com.Adjust.Sdk.ResponseData p0);

		}

		[global::Android.Runtime.Register ("com/adjust/sdk/network/IActivityPackageSender$ResponseDataCallbackSubscriber", DoNotGenerateAcw=true)]
		internal partial class IResponseDataCallbackSubscriberInvoker : global::Java.Lang.Object, IResponseDataCallbackSubscriber {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/network/IActivityPackageSender$ResponseDataCallbackSubscriber", typeof (IResponseDataCallbackSubscriberInvoker));

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

			public static IResponseDataCallbackSubscriber GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResponseDataCallbackSubscriber> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.network.IActivityPackageSender.ResponseDataCallbackSubscriber'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResponseDataCallbackSubscriberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Network.IActivityPackageSender.IResponseDataCallbackSubscriber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResponseDataCallback (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_;
			public unsafe void OnResponseDataCallback (global::Com.Adjust.Sdk.ResponseData p0)
			{
				if (id_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_ == IntPtr.Zero)
					id_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_ = JNIEnv.GetMethodID (class_ref, "onResponseDataCallback", "(Lcom/adjust/sdk/ResponseData;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponseDataCallback_Lcom_adjust_sdk_ResponseData_, __args);
			}

		}

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/network/IActivityPackageSender", DoNotGenerateAcw=true)]
	internal partial class IActivityPackageSenderInvoker : global::Java.Lang.Object, IActivityPackageSender {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/network/IActivityPackageSender", typeof (IActivityPackageSenderInvoker));

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

		public static IActivityPackageSender GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IActivityPackageSender> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.network.IActivityPackageSender'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IActivityPackageSenderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_;
#pragma warning disable 0169
		static Delegate GetSendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_Handler ()
		{
			if (cb_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_ == null)
				cb_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_SendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_));
			return cb_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_;
		}

		static void n_SendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Network.IActivityPackageSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Adjust.Sdk.Network.IActivityPackageSender.IResponseDataCallbackSubscriber)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Network.IActivityPackageSender.IResponseDataCallbackSubscriber> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendActivityPackage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_;
		public unsafe void SendActivityPackage (global::Com.Adjust.Sdk.ActivityPackage p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Com.Adjust.Sdk.Network.IActivityPackageSender.IResponseDataCallbackSubscriber p2)
		{
			if (id_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_ == IntPtr.Zero)
				id_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_ = JNIEnv.GetMethodID (class_ref, "sendActivityPackage", "(Lcom/adjust/sdk/ActivityPackage;Ljava/util/Map;Lcom/adjust/sdk/network/IActivityPackageSender$ResponseDataCallbackSubscriber;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendActivityPackage_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Lcom_adjust_sdk_network_IActivityPackageSender_ResponseDataCallbackSubscriber_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_Handler ()
		{
			if (cb_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_ == null)
				cb_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_SendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_));
			return cb_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_;
		}

		static IntPtr n_SendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.Network.IActivityPackageSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendActivityPackageSync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_;
		public unsafe global::Com.Adjust.Sdk.ResponseData SendActivityPackageSync (global::Com.Adjust.Sdk.ActivityPackage p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_ == IntPtr.Zero)
				id_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendActivityPackageSync", "(Lcom/adjust/sdk/ActivityPackage;Ljava/util/Map;)Lcom/adjust/sdk/ResponseData;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ResponseData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendActivityPackageSync_Lcom_adjust_sdk_ActivityPackage_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
