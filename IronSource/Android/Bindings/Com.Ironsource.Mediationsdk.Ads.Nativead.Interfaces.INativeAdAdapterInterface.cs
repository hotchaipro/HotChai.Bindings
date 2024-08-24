using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdAdapterInterface", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker")]
	public partial interface INativeAdAdapterInterface : global::Com.IronSource.MediationSdk.Sdk.IAdUnitAdapterInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']/method[@name='collectNativeAdBiddingData' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.bidding.BiddingDataCallback']]"
		[Register ("collectNativeAdBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V", "GetCollectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void CollectNativeAdBiddingData (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback biddingDataCallback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']/method[@name='destroyNativeAd' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("destroyNativeAd", "(Lorg/json/JSONObject;)V", "GetDestroyNativeAd_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void DestroyNativeAd (global::Org.Json.JSONObject config);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']/method[@name='getNativeAdBiddingData' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getNativeAdBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;", "GetGetNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker, MatchSolitaire.Android")]
		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetNativeAdBiddingData (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']/method[@name='initNativeAdForBidding' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener']]"
		[Register ("initNativeAdForBidding", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V", "GetInitNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitNativeAdForBidding (string appKey, string userId, global::Org.Json.JSONObject config, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']/method[@name='initNativeAds' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener']]"
		[Register ("initNativeAds", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V", "GetInitNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitNativeAds (string appKey, string userId, global::Org.Json.JSONObject config, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']/method[@name='loadNativeAd' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener']]"
		[Register ("loadNativeAd", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V", "GetLoadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadNativeAd (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdAdapterInterface']/method[@name='loadNativeAdForBidding' and count(parameter)=4 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener']]"
		[Register ("loadNativeAdForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V", "GetLoadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadNativeAdForBidding (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData, string serverData, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdAdapterInterface", DoNotGenerateAcw=true)]
	internal partial class INativeAdAdapterInterfaceInvoker : global::Java.Lang.Object, INativeAdAdapterInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdAdapterInterface", typeof (INativeAdAdapterInterfaceInvoker));

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

		public static INativeAdAdapterInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdAdapterInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdAdapterInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdAdapterInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
#pragma warning disable 0169
		static Delegate GetCollectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler ()
		{
			if (cb_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == null)
				cb_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_CollectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_));
			return cb_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		}

		static void n_CollectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config, IntPtr native_adData, IntPtr native_biddingDataCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_adData, JniHandleOwnership.DoNotTransfer);
			var biddingDataCallback = (global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback> (native_biddingDataCallback, JniHandleOwnership.DoNotTransfer);
			__this.CollectNativeAdBiddingData (config, adData, biddingDataCallback);
		}
#pragma warning restore 0169

		IntPtr id_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		public unsafe void CollectNativeAdBiddingData (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback biddingDataCallback)
		{
			if (id_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == IntPtr.Zero)
				id_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNIEnv.GetMethodID (class_ref, "collectNativeAdBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			__args [1] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			__args [2] = new JValue ((biddingDataCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) biddingDataCallback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collectNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_, __args);
		}

		static Delegate cb_destroyNativeAd_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetDestroyNativeAd_Lorg_json_JSONObject_Handler ()
		{
			if (cb_destroyNativeAd_Lorg_json_JSONObject_ == null)
				cb_destroyNativeAd_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_DestroyNativeAd_Lorg_json_JSONObject_));
			return cb_destroyNativeAd_Lorg_json_JSONObject_;
		}

		static void n_DestroyNativeAd_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.DestroyNativeAd (config);
		}
#pragma warning restore 0169

		IntPtr id_destroyNativeAd_Lorg_json_JSONObject_;
		public unsafe void DestroyNativeAd (global::Org.Json.JSONObject config)
		{
			if (id_destroyNativeAd_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_destroyNativeAd_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "destroyNativeAd", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyNativeAd_Lorg_json_JSONObject_, __args);
		}

		static Delegate cb_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == null)
				cb_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GetNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_));
			return cb_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config, IntPtr native_adData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_adData, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetNativeAdBiddingData (config, adData));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetNativeAdBiddingData (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData)
		{
			if (id_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getNativeAdBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			__args [1] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			var __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNativeAdBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler ()
		{
			if (cb_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == null)
				cb_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_));
			return cb_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		}

		static void n_InitNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appKey, IntPtr native_userId, IntPtr native_config, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var appKey = JNIEnv.GetString (native_appKey, JniHandleOwnership.DoNotTransfer);
			var userId = JNIEnv.GetString (native_userId, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.InitNativeAdForBidding (appKey, userId, config, listener);
		}
#pragma warning restore 0169

		IntPtr id_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		public unsafe void InitNativeAdForBidding (string appKey, string userId, global::Org.Json.JSONObject config, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener)
		{
			if (id_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == IntPtr.Zero)
				id_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNIEnv.GetMethodID (class_ref, "initNativeAdForBidding", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V");
			IntPtr native_appKey = JNIEnv.NewString ((string)appKey);
			IntPtr native_userId = JNIEnv.NewString ((string)userId);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_appKey);
			__args [1] = new JValue (native_userId);
			__args [2] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			__args [3] = new JValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initNativeAdForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_appKey);
			JNIEnv.DeleteLocalRef (native_userId);
		}

		static Delegate cb_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler ()
		{
			if (cb_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == null)
				cb_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_));
			return cb_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		}

		static void n_InitNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appKey, IntPtr native_userId, IntPtr native_config, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var appKey = JNIEnv.GetString (native_appKey, JniHandleOwnership.DoNotTransfer);
			var userId = JNIEnv.GetString (native_userId, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.InitNativeAds (appKey, userId, config, listener);
		}
#pragma warning restore 0169

		IntPtr id_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		public unsafe void InitNativeAds (string appKey, string userId, global::Org.Json.JSONObject config, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener)
		{
			if (id_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == IntPtr.Zero)
				id_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNIEnv.GetMethodID (class_ref, "initNativeAds", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V");
			IntPtr native_appKey = JNIEnv.NewString ((string)appKey);
			IntPtr native_userId = JNIEnv.NewString ((string)userId);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_appKey);
			__args [1] = new JValue (native_userId);
			__args [2] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			__args [3] = new JValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initNativeAds_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_appKey);
			JNIEnv.DeleteLocalRef (native_userId);
		}

		static Delegate cb_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler ()
		{
			if (cb_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == null)
				cb_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_LoadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_));
			return cb_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		}

		static void n_LoadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config, IntPtr native_adData, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_adData, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.LoadNativeAd (config, adData, listener);
		}
#pragma warning restore 0169

		IntPtr id_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		public unsafe void LoadNativeAd (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener)
		{
			if (id_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == IntPtr.Zero)
				id_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadNativeAd", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			__args [1] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			__args [2] = new JValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadNativeAd_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_, __args);
		}

		static Delegate cb_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_Handler ()
		{
			if (cb_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == null)
				cb_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_LoadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_));
			return cb_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		}

		static void n_LoadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config, IntPtr native_adData, IntPtr native_serverData, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_config, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_adData, JniHandleOwnership.DoNotTransfer);
			var serverData = JNIEnv.GetString (native_serverData, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.LoadNativeAdForBidding (config, adData, serverData, listener);
		}
#pragma warning restore 0169

		IntPtr id_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_;
		public unsafe void LoadNativeAdForBidding (global::Org.Json.JSONObject config, global::Org.Json.JSONObject adData, string serverData, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener listener)
		{
			if (id_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ == IntPtr.Zero)
				id_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadNativeAdForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener;)V");
			IntPtr native_serverData = JNIEnv.NewString ((string)serverData);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			__args [1] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			__args [2] = new JValue (native_serverData);
			__args [3] = new JValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadNativeAdForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_ads_nativead_interfaces_NativeAdSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_serverData);
		}

		static Delegate cb_onNetworkInitCallbackFailed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNetworkInitCallbackFailed_Ljava_lang_String_Handler ()
		{
			if (cb_onNetworkInitCallbackFailed_Ljava_lang_String_ == null)
				cb_onNetworkInitCallbackFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnNetworkInitCallbackFailed_Ljava_lang_String_));
			return cb_onNetworkInitCallbackFailed_Ljava_lang_String_;
		}

		static void n_OnNetworkInitCallbackFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInitCallbackFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNetworkInitCallbackFailed_Ljava_lang_String_;
		public unsafe void OnNetworkInitCallbackFailed (string p0)
		{
			if (id_onNetworkInitCallbackFailed_Ljava_lang_String_ == IntPtr.Zero)
				id_onNetworkInitCallbackFailed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNetworkInitCallbackFailed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkInitCallbackFailed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onNetworkInitCallbackSuccess;
#pragma warning disable 0169
		static Delegate GetOnNetworkInitCallbackSuccessHandler ()
		{
			if (cb_onNetworkInitCallbackSuccess == null)
				cb_onNetworkInitCallbackSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnNetworkInitCallbackSuccess));
			return cb_onNetworkInitCallbackSuccess;
		}

		static void n_OnNetworkInitCallbackSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInitCallbackSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onNetworkInitCallbackSuccess;
		public unsafe void OnNetworkInitCallbackSuccess ()
		{
			if (id_onNetworkInitCallbackSuccess == IntPtr.Zero)
				id_onNetworkInitCallbackSuccess = JNIEnv.GetMethodID (class_ref, "onNetworkInitCallbackSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkInitCallbackSuccess);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
