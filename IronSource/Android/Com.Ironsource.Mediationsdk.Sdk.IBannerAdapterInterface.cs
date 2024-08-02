using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']"
	[Register ("com/ironsource/mediationsdk/sdk/BannerAdapterInterface", "", "Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker")]
	public partial interface IBannerAdapterInterface : global::Com.IronSource.MediationSdk.Sdk.IAdUnitAdapterInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='collectBannerBiddingData' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.bidding.BiddingDataCallback']]"
		[Register ("collectBannerBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V", "GetCollectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void CollectBannerBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='destroyBanner' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("destroyBanner", "(Lorg/json/JSONObject;)V", "GetDestroyBanner_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void DestroyBanner (global::Org.Json.JSONObject p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='getAdaptiveHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdaptiveHeight", "(I)I", "GetGetAdaptiveHeight_IHandler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		int GetAdaptiveHeight (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='getBannerBiddingData' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getBannerBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;", "GetGetBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetBannerBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='initBannerForBidding' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.BannerSmashListener']]"
		[Register ("initBannerForBidding", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V", "GetInitBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitBannerForBidding (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='initBanners' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.BannerSmashListener']]"
		[Register ("initBanners", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V", "GetInitBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitBanners (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='loadBanner' and count(parameter)=4 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.IronSourceBannerLayout'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.BannerSmashListener']]"
		[Register ("loadBanner", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/IronSourceBannerLayout;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V", "GetLoadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadBanner (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.IronSourceBannerLayout p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='loadBannerForBidding' and count(parameter)=5 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ironsource.mediationsdk.IronSourceBannerLayout'] and parameter[5][@type='com.ironsource.mediationsdk.sdk.BannerSmashListener']]"
		[Register ("loadBannerForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/IronSourceBannerLayout;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V", "GetLoadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadBannerForBidding (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, string p2, global::Com.IronSource.MediationSdk.IronSourceBannerLayout p3, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='loadBannerForDemandOnlyForBidding' and count(parameter)=4 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ironsource.mediationsdk.demandOnly.ISDemandOnlyBannerLayout'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.BannerSmashListener']]"
		[Register ("loadBannerForDemandOnlyForBidding", "(Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/demandOnly/ISDemandOnlyBannerLayout;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V", "GetLoadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadBannerForDemandOnlyForBidding (global::Org.Json.JSONObject p0, string p1, global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerLayout p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='onBannerViewBound' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("onBannerViewBound", "(Lorg/json/JSONObject;)V", "GetOnBannerViewBound_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void OnBannerViewBound (global::Org.Json.JSONObject p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerAdapterInterface']/method[@name='onBannerViewWillBind' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("onBannerViewWillBind", "(Lorg/json/JSONObject;)V", "GetOnBannerViewWillBind_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void OnBannerViewWillBind (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/BannerAdapterInterface", DoNotGenerateAcw=true)]
	internal partial class IBannerAdapterInterfaceInvoker : global::Java.Lang.Object, IBannerAdapterInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/BannerAdapterInterface", typeof (IBannerAdapterInterfaceInvoker));

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

		public static IBannerAdapterInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBannerAdapterInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.BannerAdapterInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBannerAdapterInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
#pragma warning disable 0169
		static Delegate GetCollectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler ()
		{
			if (cb_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == null)
				cb_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_CollectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_));
			return cb_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		}

		static void n_CollectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CollectBannerBiddingData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		public unsafe void CollectBannerBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback p2)
		{
			if (id_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == IntPtr.Zero)
				id_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNIEnv.GetMethodID (class_ref, "collectBannerBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collectBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_, __args);
		}

		static Delegate cb_destroyBanner_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetDestroyBanner_Lorg_json_JSONObject_Handler ()
		{
			if (cb_destroyBanner_Lorg_json_JSONObject_ == null)
				cb_destroyBanner_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_DestroyBanner_Lorg_json_JSONObject_));
			return cb_destroyBanner_Lorg_json_JSONObject_;
		}

		static void n_DestroyBanner_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DestroyBanner (p0);
		}
#pragma warning restore 0169

		IntPtr id_destroyBanner_Lorg_json_JSONObject_;
		public unsafe void DestroyBanner (global::Org.Json.JSONObject p0)
		{
			if (id_destroyBanner_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_destroyBanner_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "destroyBanner", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyBanner_Lorg_json_JSONObject_, __args);
		}

		static Delegate cb_getAdaptiveHeight_I;
#pragma warning disable 0169
		static Delegate GetGetAdaptiveHeight_IHandler ()
		{
			if (cb_getAdaptiveHeight_I == null)
				cb_getAdaptiveHeight_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_GetAdaptiveHeight_I));
			return cb_getAdaptiveHeight_I;
		}

		static int n_GetAdaptiveHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAdaptiveHeight (p0);
		}
#pragma warning restore 0169

		IntPtr id_getAdaptiveHeight_I;
		public unsafe int GetAdaptiveHeight (int p0)
		{
			if (id_getAdaptiveHeight_I == IntPtr.Zero)
				id_getAdaptiveHeight_I = JNIEnv.GetMethodID (class_ref, "getAdaptiveHeight", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdaptiveHeight_I, __args);
		}

		static Delegate cb_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == null)
				cb_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GetBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_));
			return cb_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetBannerBiddingData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetBannerBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1)
		{
			if (id_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getBannerBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBannerBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler ()
		{
			if (cb_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == null)
				cb_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_));
			return cb_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		}

		static void n_InitBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InitBannerForBidding (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		public unsafe void InitBannerForBidding (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3)
		{
			if (id_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == IntPtr.Zero)
				id_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNIEnv.GetMethodID (class_ref, "initBannerForBidding", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initBannerForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler ()
		{
			if (cb_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == null)
				cb_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_));
			return cb_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		}

		static void n_InitBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InitBanners (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		public unsafe void InitBanners (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3)
		{
			if (id_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == IntPtr.Zero)
				id_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNIEnv.GetMethodID (class_ref, "initBanners", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initBanners_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler ()
		{
			if (cb_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == null)
				cb_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_LoadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_));
			return cb_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		}

		static void n_LoadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IronSourceBannerLayout> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadBanner (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		public unsafe void LoadBanner (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.IronSourceBannerLayout p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3)
		{
			if (id_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == IntPtr.Zero)
				id_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadBanner", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/IronSourceBannerLayout;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadBanner_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_, __args);
		}

		static Delegate cb_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler ()
		{
			if (cb_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == null)
				cb_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_LoadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_));
			return cb_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		}

		static void n_LoadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IronSourceBannerLayout> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.LoadBannerForBidding (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		public unsafe void LoadBannerForBidding (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, string p2, global::Com.IronSource.MediationSdk.IronSourceBannerLayout p3, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p4)
		{
			if (id_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == IntPtr.Zero)
				id_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadBannerForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/IronSourceBannerLayout;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V");
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadBannerForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_IronSourceBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_Handler ()
		{
			if (cb_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == null)
				cb_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_LoadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_));
			return cb_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		}

		static void n_LoadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerLayout> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadBannerForDemandOnlyForBidding (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_;
		public unsafe void LoadBannerForDemandOnlyForBidding (global::Org.Json.JSONObject p0, string p1, global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerLayout p2, global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener p3)
		{
			if (id_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ == IntPtr.Zero)
				id_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadBannerForDemandOnlyForBidding", "(Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/demandOnly/ISDemandOnlyBannerLayout;Lcom/ironsource/mediationsdk/sdk/BannerSmashListener;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadBannerForDemandOnlyForBidding_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_demandOnly_ISDemandOnlyBannerLayout_Lcom_ironsource_mediationsdk_sdk_BannerSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onBannerViewBound_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetOnBannerViewBound_Lorg_json_JSONObject_Handler ()
		{
			if (cb_onBannerViewBound_Lorg_json_JSONObject_ == null)
				cb_onBannerViewBound_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerViewBound_Lorg_json_JSONObject_));
			return cb_onBannerViewBound_Lorg_json_JSONObject_;
		}

		static void n_OnBannerViewBound_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerViewBound (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerViewBound_Lorg_json_JSONObject_;
		public unsafe void OnBannerViewBound (global::Org.Json.JSONObject p0)
		{
			if (id_onBannerViewBound_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_onBannerViewBound_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onBannerViewBound", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerViewBound_Lorg_json_JSONObject_, __args);
		}

		static Delegate cb_onBannerViewWillBind_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetOnBannerViewWillBind_Lorg_json_JSONObject_Handler ()
		{
			if (cb_onBannerViewWillBind_Lorg_json_JSONObject_ == null)
				cb_onBannerViewWillBind_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerViewWillBind_Lorg_json_JSONObject_));
			return cb_onBannerViewWillBind_Lorg_json_JSONObject_;
		}

		static void n_OnBannerViewWillBind_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerViewWillBind (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerViewWillBind_Lorg_json_JSONObject_;
		public unsafe void OnBannerViewWillBind (global::Org.Json.JSONObject p0)
		{
			if (id_onBannerViewWillBind_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_onBannerViewWillBind_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onBannerViewWillBind", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerViewWillBind_Lorg_json_JSONObject_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
