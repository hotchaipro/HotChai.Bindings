using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='ReleaseMemoryAdapterInterface']"
	[Register ("com/ironsource/mediationsdk/sdk/ReleaseMemoryAdapterInterface", "", "Com.IronSource.MediationSdk.Sdk.IReleaseMemoryAdapterInterfaceInvoker")]
	public partial interface IReleaseMemoryAdapterInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='ReleaseMemoryAdapterInterface']/method[@name='releaseMemory' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.IronSource.AD_UNIT'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("releaseMemory", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;Lorg/json/JSONObject;)V", "GetReleaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IReleaseMemoryAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void ReleaseMemory (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT adUnit, global::Org.Json.JSONObject config);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/ReleaseMemoryAdapterInterface", DoNotGenerateAcw=true)]
	internal partial class IReleaseMemoryAdapterInterfaceInvoker : global::Java.Lang.Object, IReleaseMemoryAdapterInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/ReleaseMemoryAdapterInterface", typeof (IReleaseMemoryAdapterInterfaceInvoker));

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

		public static IReleaseMemoryAdapterInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReleaseMemoryAdapterInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.ReleaseMemoryAdapterInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReleaseMemoryAdapterInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetReleaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_Handler ()
		{
			if (cb_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ == null)
				cb_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_ReleaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_));
			return cb_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_;
		}

		static void n_ReleaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adUnit, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IReleaseMemoryAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adUnit = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IronSource.AD_UNIT> (native_adUnit, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseMemory (adUnit, config);
		}
#pragma warning restore 0169

		IntPtr id_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_;
		public unsafe void ReleaseMemory (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT adUnit, global::Org.Json.JSONObject config)
		{
			if (id_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "releaseMemory", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((adUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adUnit).Handle);
			__args [1] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseMemory_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_, __args);
		}

	}
}
