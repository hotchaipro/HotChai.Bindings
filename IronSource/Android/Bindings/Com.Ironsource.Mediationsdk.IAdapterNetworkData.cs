using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='AdapterNetworkData']"
	[Register ("com/ironsource/mediationsdk/AdapterNetworkData", "", "Com.IronSource.MediationSdk.IAdapterNetworkDataInvoker")]
	public partial interface IAdapterNetworkData : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='AdapterNetworkData']/method[@name='allData' and count(parameter)=0]"
		[Register ("allData", "()Lorg/json/JSONObject;", "GetAllDataHandler:Com.IronSource.MediationSdk.IAdapterNetworkDataInvoker, MatchSolitaire.Android")]
		global::Org.Json.JSONObject AllData ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='AdapterNetworkData']/method[@name='networkDataByAdUnit' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.IronSource.AD_UNIT']]"
		[Register ("networkDataByAdUnit", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;)Lorg/json/JSONObject;", "GetNetworkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Handler:Com.IronSource.MediationSdk.IAdapterNetworkDataInvoker, MatchSolitaire.Android")]
		global::Org.Json.JSONObject NetworkDataByAdUnit (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT adUnit);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/AdapterNetworkData", DoNotGenerateAcw=true)]
	internal partial class IAdapterNetworkDataInvoker : global::Java.Lang.Object, IAdapterNetworkData {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/AdapterNetworkData", typeof (IAdapterNetworkDataInvoker));

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

		public static IAdapterNetworkData GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterNetworkData> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.AdapterNetworkData'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterNetworkDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_allData;
#pragma warning disable 0169
		static Delegate GetAllDataHandler ()
		{
			if (cb_allData == null)
				cb_allData = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_AllData));
			return cb_allData;
		}

		static IntPtr n_AllData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IAdapterNetworkData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AllData ());
		}
#pragma warning restore 0169

		IntPtr id_allData;
		public unsafe global::Org.Json.JSONObject AllData ()
		{
			if (id_allData == IntPtr.Zero)
				id_allData = JNIEnv.GetMethodID (class_ref, "allData", "()Lorg/json/JSONObject;");
			return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allData), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_;
#pragma warning disable 0169
		static Delegate GetNetworkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Handler ()
		{
			if (cb_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ == null)
				cb_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_NetworkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_));
			return cb_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_;
		}

		static IntPtr n_NetworkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adUnit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IAdapterNetworkData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adUnit = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IronSource.AD_UNIT> (native_adUnit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NetworkDataByAdUnit (adUnit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_;
		public unsafe global::Org.Json.JSONObject NetworkDataByAdUnit (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT adUnit)
		{
			if (id_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ == IntPtr.Zero)
				id_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ = JNIEnv.GetMethodID (class_ref, "networkDataByAdUnit", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;)Lorg/json/JSONObject;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adUnit).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_networkDataByAdUnit_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
