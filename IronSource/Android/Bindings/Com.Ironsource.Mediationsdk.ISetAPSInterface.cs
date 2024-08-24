using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='SetAPSInterface']"
	[Register ("com/ironsource/mediationsdk/SetAPSInterface", "", "Com.IronSource.MediationSdk.ISetAPSInterfaceInvoker")]
	public partial interface ISetAPSInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='SetAPSInterface']/method[@name='setAPSData' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.IronSource.AD_UNIT'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("setAPSData", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;Lorg/json/JSONObject;)V", "GetSetAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.ISetAPSInterfaceInvoker, MatchSolitaire.Android")]
		void SetAPSData (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT adUnit, global::Org.Json.JSONObject apsData);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/SetAPSInterface", DoNotGenerateAcw=true)]
	internal partial class ISetAPSInterfaceInvoker : global::Java.Lang.Object, ISetAPSInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/SetAPSInterface", typeof (ISetAPSInterfaceInvoker));

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

		public static ISetAPSInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISetAPSInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.SetAPSInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISetAPSInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ == null)
				cb_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SetAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_));
			return cb_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_;
		}

		static void n_SetAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adUnit, IntPtr native_apsData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ISetAPSInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adUnit = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IronSource.AD_UNIT> (native_adUnit, JniHandleOwnership.DoNotTransfer);
			var apsData = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_apsData, JniHandleOwnership.DoNotTransfer);
			__this.SetAPSData (adUnit, apsData);
		}
#pragma warning restore 0169

		IntPtr id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_;
		public unsafe void SetAPSData (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT adUnit, global::Org.Json.JSONObject apsData)
		{
			if (id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setAPSData", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((adUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adUnit).Handle);
			__args [1] = new JValue ((apsData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apsData).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_, __args);
		}

	}
}
