using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterAPSDataInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterAPSDataInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAPSDataInterfaceInvoker")]
	public partial interface IAdapterAPSDataInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterAPSDataInterface']/method[@name='setAPSData' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.IronSource.AD_UNIT'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("setAPSData", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;Lorg/json/JSONObject;)V", "GetSetAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAPSDataInterfaceInvoker, MatchSolitaire.Android")]
		void SetAPSData (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT p0, global::Org.Json.JSONObject p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterAPSDataInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterAPSDataInterfaceInvoker : global::Java.Lang.Object, IAdapterAPSDataInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterAPSDataInterface", typeof (IAdapterAPSDataInterfaceInvoker));

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

		public static IAdapterAPSDataInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterAPSDataInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterAPSDataInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterAPSDataInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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

		static void n_SetAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAPSDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IronSource.AD_UNIT> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAPSData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_;
		public unsafe void SetAPSData (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT p0, global::Org.Json.JSONObject p1)
		{
			if (id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setAPSData", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAPSData_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Lorg_json_JSONObject_, __args);
		}

	}
}
