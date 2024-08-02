using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']"
	[Register ("com/ironsource/mediationsdk/sdk/InterstitialAdapterInterface", "", "Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker")]
	public partial interface IInterstitialAdapterInterface : global::Com.IronSource.MediationSdk.Sdk.IAdUnitAdapterInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='collectInterstitialBiddingData' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.bidding.BiddingDataCallback']]"
		[Register ("collectInterstitialBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V", "GetCollectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void CollectInterstitialBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='getInterstitialBiddingData' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getInterstitialBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;", "GetGetInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetInterstitialBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='initInterstitial' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.InterstitialSmashListener']]"
		[Register ("initInterstitial", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V", "GetInitInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitInterstitial (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='initInterstitialForBidding' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.InterstitialSmashListener']]"
		[Register ("initInterstitialForBidding", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V", "GetInitInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitInterstitialForBidding (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='isInterstitialReady' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("isInterstitialReady", "(Lorg/json/JSONObject;)Z", "GetIsInterstitialReady_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		bool IsInterstitialReady (global::Org.Json.JSONObject p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='loadInterstitial' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.sdk.InterstitialSmashListener']]"
		[Register ("loadInterstitial", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V", "GetLoadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadInterstitial (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='loadInterstitialForBidding' and count(parameter)=4 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.InterstitialSmashListener']]"
		[Register ("loadInterstitialForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V", "GetLoadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadInterstitialForBidding (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, string p2, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialAdapterInterface']/method[@name='showInterstitial' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.ironsource.mediationsdk.sdk.InterstitialSmashListener']]"
		[Register ("showInterstitial", "(Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V", "GetShowInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void ShowInterstitial (global::Org.Json.JSONObject p0, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/InterstitialAdapterInterface", DoNotGenerateAcw=true)]
	internal partial class IInterstitialAdapterInterfaceInvoker : global::Java.Lang.Object, IInterstitialAdapterInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/InterstitialAdapterInterface", typeof (IInterstitialAdapterInterfaceInvoker));

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

		public static IInterstitialAdapterInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterstitialAdapterInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.InterstitialAdapterInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterstitialAdapterInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
#pragma warning disable 0169
		static Delegate GetCollectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler ()
		{
			if (cb_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == null)
				cb_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_CollectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_));
			return cb_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		}

		static void n_CollectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CollectInterstitialBiddingData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		public unsafe void CollectInterstitialBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback p2)
		{
			if (id_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == IntPtr.Zero)
				id_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNIEnv.GetMethodID (class_ref, "collectInterstitialBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collectInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_, __args);
		}

		static Delegate cb_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == null)
				cb_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GetInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_));
			return cb_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetInterstitialBiddingData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetInterstitialBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1)
		{
			if (id_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getInterstitialBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInterstitialBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler ()
		{
			if (cb_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == null)
				cb_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_));
			return cb_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		}

		static void n_InitInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InitInterstitial (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		public unsafe void InitInterstitial (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p3)
		{
			if (id_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == IntPtr.Zero)
				id_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNIEnv.GetMethodID (class_ref, "initInterstitial", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initInterstitial_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler ()
		{
			if (cb_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == null)
				cb_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_));
			return cb_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		}

		static void n_InitInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InitInterstitialForBidding (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		public unsafe void InitInterstitialForBidding (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p3)
		{
			if (id_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == IntPtr.Zero)
				id_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNIEnv.GetMethodID (class_ref, "initInterstitialForBidding", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initInterstitialForBidding_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_isInterstitialReady_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetIsInterstitialReady_Lorg_json_JSONObject_Handler ()
		{
			if (cb_isInterstitialReady_Lorg_json_JSONObject_ == null)
				cb_isInterstitialReady_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsInterstitialReady_Lorg_json_JSONObject_));
			return cb_isInterstitialReady_Lorg_json_JSONObject_;
		}

		static bool n_IsInterstitialReady_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInterstitialReady (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isInterstitialReady_Lorg_json_JSONObject_;
		public unsafe bool IsInterstitialReady (global::Org.Json.JSONObject p0)
		{
			if (id_isInterstitialReady_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_isInterstitialReady_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "isInterstitialReady", "(Lorg/json/JSONObject;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInterstitialReady_Lorg_json_JSONObject_, __args);
			return __ret;
		}

		static Delegate cb_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler ()
		{
			if (cb_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == null)
				cb_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_LoadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_));
			return cb_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		}

		static void n_LoadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadInterstitial (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		public unsafe void LoadInterstitial (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p2)
		{
			if (id_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == IntPtr.Zero)
				id_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadInterstitial", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadInterstitial_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_, __args);
		}

		static Delegate cb_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler ()
		{
			if (cb_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == null)
				cb_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_LoadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_));
			return cb_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		}

		static void n_LoadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadInterstitialForBidding (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		public unsafe void LoadInterstitialForBidding (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, string p2, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p3)
		{
			if (id_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == IntPtr.Zero)
				id_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadInterstitialForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V");
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadInterstitialForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
#pragma warning disable 0169
		static Delegate GetShowInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_Handler ()
		{
			if (cb_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == null)
				cb_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_ShowInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_));
			return cb_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		}

		static void n_ShowInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitial (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_;
		public unsafe void ShowInterstitial (global::Org.Json.JSONObject p0, global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener p1)
		{
			if (id_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ == IntPtr.Zero)
				id_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_ = JNIEnv.GetMethodID (class_ref, "showInterstitial", "(Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/InterstitialSmashListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showInterstitial_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_InterstitialSmashListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
