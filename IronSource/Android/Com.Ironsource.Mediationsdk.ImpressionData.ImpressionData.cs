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

namespace Com.IronSource.MediationSdk.ImpressionData {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']"
	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/impressionData/ImpressionData", DoNotGenerateAcw=true)]
	public partial class ImpressionData : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_ABTEST']"
		[Register ("IMPRESSION_DATA_KEY_ABTEST")]
		public const string ImpressionDataKeyAbtest = (string) "ab";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_AD_NETWORK']"
		[Register ("IMPRESSION_DATA_KEY_AD_NETWORK")]
		public const string ImpressionDataKeyAdNetwork = (string) "adNetwork";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_AD_UNIT']"
		[Register ("IMPRESSION_DATA_KEY_AD_UNIT")]
		public const string ImpressionDataKeyAdUnit = (string) "adUnit";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_AUCTION_ID']"
		[Register ("IMPRESSION_DATA_KEY_AUCTION_ID")]
		public const string ImpressionDataKeyAuctionId = (string) "auctionId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_COUNTRY']"
		[Register ("IMPRESSION_DATA_KEY_COUNTRY")]
		public const string ImpressionDataKeyCountry = (string) "country";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_ENCRYPTED_CPM']"
		[Register ("IMPRESSION_DATA_KEY_ENCRYPTED_CPM")]
		public const string ImpressionDataKeyEncryptedCpm = (string) "encryptedCPM";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_INSTANCE_ID']"
		[Register ("IMPRESSION_DATA_KEY_INSTANCE_ID")]
		public const string ImpressionDataKeyInstanceId = (string) "instanceId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_INSTANCE_NAME']"
		[Register ("IMPRESSION_DATA_KEY_INSTANCE_NAME")]
		public const string ImpressionDataKeyInstanceName = (string) "instanceName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_LIFETIME_REVENUE']"
		[Register ("IMPRESSION_DATA_KEY_LIFETIME_REVENUE")]
		public const string ImpressionDataKeyLifetimeRevenue = (string) "lifetimeRevenue";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_PLACEMENT']"
		[Register ("IMPRESSION_DATA_KEY_PLACEMENT")]
		public const string ImpressionDataKeyPlacement = (string) "placement";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_PRECISION']"
		[Register ("IMPRESSION_DATA_KEY_PRECISION")]
		public const string ImpressionDataKeyPrecision = (string) "precision";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_REVENUE']"
		[Register ("IMPRESSION_DATA_KEY_REVENUE")]
		public const string ImpressionDataKeyRevenue = (string) "revenue";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/field[@name='IMPRESSION_DATA_KEY_SEGMENT_NAME']"
		[Register ("IMPRESSION_DATA_KEY_SEGMENT_NAME")]
		public const string ImpressionDataKeySegmentName = (string) "segmentName";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/impressionData/ImpressionData", typeof (ImpressionData));

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

		protected ImpressionData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/constructor[@name='ImpressionData' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.impressionData.ImpressionData']]"
		[Register (".ctor", "(Lcom/ironsource/mediationsdk/impressionData/ImpressionData;)V", "")]
		public unsafe ImpressionData (global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/ironsource/mediationsdk/impressionData/ImpressionData;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/constructor[@name='ImpressionData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ImpressionData (global::Org.Json.JSONObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/json/JSONObject;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getAb;
#pragma warning disable 0169
		static Delegate GetGetAbHandler ()
		{
			if (cb_getAb == null)
				cb_getAb = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAb));
			return cb_getAb;
		}

		static IntPtr n_GetAb (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ab);
		}
#pragma warning restore 0169

		public virtual unsafe string Ab {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getAb' and count(parameter)=0]"
			[Register ("getAb", "()Ljava/lang/String;", "GetGetAbHandler")]
			get {
				const string __id = "getAb.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdNetwork;
#pragma warning disable 0169
		static Delegate GetGetAdNetworkHandler ()
		{
			if (cb_getAdNetwork == null)
				cb_getAdNetwork = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdNetwork));
			return cb_getAdNetwork;
		}

		static IntPtr n_GetAdNetwork (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdNetwork);
		}
#pragma warning restore 0169

		public virtual unsafe string AdNetwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getAdNetwork' and count(parameter)=0]"
			[Register ("getAdNetwork", "()Ljava/lang/String;", "GetGetAdNetworkHandler")]
			get {
				const string __id = "getAdNetwork.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdUnit;
#pragma warning disable 0169
		static Delegate GetGetAdUnitHandler ()
		{
			if (cb_getAdUnit == null)
				cb_getAdUnit = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdUnit));
			return cb_getAdUnit;
		}

		static IntPtr n_GetAdUnit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdUnit);
		}
#pragma warning restore 0169

		public virtual unsafe string AdUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getAdUnit' and count(parameter)=0]"
			[Register ("getAdUnit", "()Ljava/lang/String;", "GetGetAdUnitHandler")]
			get {
				const string __id = "getAdUnit.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllData;
#pragma warning disable 0169
		static Delegate GetGetAllDataHandler ()
		{
			if (cb_getAllData == null)
				cb_getAllData = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAllData));
			return cb_getAllData;
		}

		static IntPtr n_GetAllData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AllData);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject AllData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getAllData' and count(parameter)=0]"
			[Register ("getAllData", "()Lorg/json/JSONObject;", "GetGetAllDataHandler")]
			get {
				const string __id = "getAllData.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuctionId;
#pragma warning disable 0169
		static Delegate GetGetAuctionIdHandler ()
		{
			if (cb_getAuctionId == null)
				cb_getAuctionId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAuctionId));
			return cb_getAuctionId;
		}

		static IntPtr n_GetAuctionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuctionId);
		}
#pragma warning restore 0169

		public virtual unsafe string AuctionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getAuctionId' and count(parameter)=0]"
			[Register ("getAuctionId", "()Ljava/lang/String;", "GetGetAuctionIdHandler")]
			get {
				const string __id = "getAuctionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCountry));
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				const string __id = "getCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEncryptedCPM;
#pragma warning disable 0169
		static Delegate GetGetEncryptedCPMHandler ()
		{
			if (cb_getEncryptedCPM == null)
				cb_getEncryptedCPM = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetEncryptedCPM));
			return cb_getEncryptedCPM;
		}

		static IntPtr n_GetEncryptedCPM (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptedCPM);
		}
#pragma warning restore 0169

		public virtual unsafe string EncryptedCPM {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getEncryptedCPM' and count(parameter)=0]"
			[Register ("getEncryptedCPM", "()Ljava/lang/String;", "GetGetEncryptedCPMHandler")]
			get {
				const string __id = "getEncryptedCPM.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInstanceId;
#pragma warning disable 0169
		static Delegate GetGetInstanceIdHandler ()
		{
			if (cb_getInstanceId == null)
				cb_getInstanceId = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetInstanceId));
			return cb_getInstanceId;
		}

		static IntPtr n_GetInstanceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InstanceId);
		}
#pragma warning restore 0169

		public virtual unsafe string InstanceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getInstanceId' and count(parameter)=0]"
			[Register ("getInstanceId", "()Ljava/lang/String;", "GetGetInstanceIdHandler")]
			get {
				const string __id = "getInstanceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInstanceName;
#pragma warning disable 0169
		static Delegate GetGetInstanceNameHandler ()
		{
			if (cb_getInstanceName == null)
				cb_getInstanceName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetInstanceName));
			return cb_getInstanceName;
		}

		static IntPtr n_GetInstanceName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InstanceName);
		}
#pragma warning restore 0169

		public virtual unsafe string InstanceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getInstanceName' and count(parameter)=0]"
			[Register ("getInstanceName", "()Ljava/lang/String;", "GetGetInstanceNameHandler")]
			get {
				const string __id = "getInstanceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLifetimeRevenue;
#pragma warning disable 0169
		static Delegate GetGetLifetimeRevenueHandler ()
		{
			if (cb_getLifetimeRevenue == null)
				cb_getLifetimeRevenue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLifetimeRevenue));
			return cb_getLifetimeRevenue;
		}

		static IntPtr n_GetLifetimeRevenue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LifetimeRevenue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Double LifetimeRevenue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getLifetimeRevenue' and count(parameter)=0]"
			[Register ("getLifetimeRevenue", "()Ljava/lang/Double;", "GetGetLifetimeRevenueHandler")]
			get {
				const string __id = "getLifetimeRevenue.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlacement;
#pragma warning disable 0169
		static Delegate GetGetPlacementHandler ()
		{
			if (cb_getPlacement == null)
				cb_getPlacement = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPlacement));
			return cb_getPlacement;
		}

		static IntPtr n_GetPlacement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Placement);
		}
#pragma warning restore 0169

		public virtual unsafe string Placement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getPlacement' and count(parameter)=0]"
			[Register ("getPlacement", "()Ljava/lang/String;", "GetGetPlacementHandler")]
			get {
				const string __id = "getPlacement.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrecision;
#pragma warning disable 0169
		static Delegate GetGetPrecisionHandler ()
		{
			if (cb_getPrecision == null)
				cb_getPrecision = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPrecision));
			return cb_getPrecision;
		}

		static IntPtr n_GetPrecision (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Precision);
		}
#pragma warning restore 0169

		public virtual unsafe string Precision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getPrecision' and count(parameter)=0]"
			[Register ("getPrecision", "()Ljava/lang/String;", "GetGetPrecisionHandler")]
			get {
				const string __id = "getPrecision.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRevenue;
#pragma warning disable 0169
		static Delegate GetGetRevenueHandler ()
		{
			if (cb_getRevenue == null)
				cb_getRevenue = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetRevenue));
			return cb_getRevenue;
		}

		static IntPtr n_GetRevenue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Revenue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Double Revenue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getRevenue' and count(parameter)=0]"
			[Register ("getRevenue", "()Ljava/lang/Double;", "GetGetRevenueHandler")]
			get {
				const string __id = "getRevenue.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSegmentName;
#pragma warning disable 0169
		static Delegate GetGetSegmentNameHandler ()
		{
			if (cb_getSegmentName == null)
				cb_getSegmentName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSegmentName));
			return cb_getSegmentName;
		}

		static IntPtr n_GetSegmentName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SegmentName);
		}
#pragma warning restore 0169

		public virtual unsafe string SegmentName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='getSegmentName' and count(parameter)=0]"
			[Register ("getSegmentName", "()Ljava/lang/String;", "GetGetSegmentNameHandler")]
			get {
				const string __id = "getSegmentName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_replaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_replaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_replaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_ReplaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_));
			return cb_replaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ReplaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceMacroForPlacementWithValue (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/class[@name='ImpressionData']/method[@name='replaceMacroForPlacementWithValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("replaceMacroForPlacementWithValue", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReplaceMacroForPlacementWithValue_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ReplaceMacroForPlacementWithValue (string p0, string p1)
		{
			const string __id = "replaceMacroForPlacementWithValue.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
