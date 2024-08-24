using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']"
	[Register ("com/ironsource/mediationsdk/sdk/RewardedVideoAdapterInterface", "", "Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker")]
	public partial interface IRewardedVideoAdapterInterface : global::Com.IronSource.MediationSdk.Sdk.IAdUnitAdapterInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='collectRewardedVideoBiddingData' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.bidding.BiddingDataCallback']]"
		[Register ("collectRewardedVideoBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V", "GetCollectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void CollectRewardedVideoBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='getRewardedVideoBiddingData' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("getRewardedVideoBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;", "GetGetRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetRewardedVideoBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='initAndLoadRewardedVideo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='org.json.JSONObject'] and parameter[5][@type='com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener']]"
		[Register ("initAndLoadRewardedVideo", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V", "GetInitAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitAndLoadRewardedVideo (string p0, string p1, global::Org.Json.JSONObject p2, global::Org.Json.JSONObject p3, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='initRewardedVideoForDemandOnly' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener']]"
		[Register ("initRewardedVideoForDemandOnly", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V", "GetInitRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitRewardedVideoForDemandOnly (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='initRewardedVideoWithCallback' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener']]"
		[Register ("initRewardedVideoWithCallback", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V", "GetInitRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void InitRewardedVideoWithCallback (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='isRewardedVideoAvailable' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("isRewardedVideoAvailable", "(Lorg/json/JSONObject;)Z", "GetIsRewardedVideoAvailable_Lorg_json_JSONObject_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		bool IsRewardedVideoAvailable (global::Org.Json.JSONObject p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='loadRewardedVideo' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener']]"
		[Register ("loadRewardedVideo", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V", "GetLoadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadRewardedVideo (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='loadRewardedVideoForBidding' and count(parameter)=4 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener']]"
		[Register ("loadRewardedVideoForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V", "GetLoadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void LoadRewardedVideoForBidding (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, string p2, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoAdapterInterface']/method[@name='showRewardedVideo' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener']]"
		[Register ("showRewardedVideo", "(Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V", "GetShowRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterfaceInvoker, MatchSolitaire.Android")]
		void ShowRewardedVideo (global::Org.Json.JSONObject p0, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/RewardedVideoAdapterInterface", DoNotGenerateAcw=true)]
	internal partial class IRewardedVideoAdapterInterfaceInvoker : global::Java.Lang.Object, IRewardedVideoAdapterInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/RewardedVideoAdapterInterface", typeof (IRewardedVideoAdapterInterfaceInvoker));

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

		public static IRewardedVideoAdapterInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRewardedVideoAdapterInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.RewardedVideoAdapterInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRewardedVideoAdapterInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
#pragma warning disable 0169
		static Delegate GetCollectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_Handler ()
		{
			if (cb_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == null)
				cb_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_CollectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_));
			return cb_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		}

		static void n_CollectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CollectRewardedVideoBiddingData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_;
		public unsafe void CollectRewardedVideoBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback p2)
		{
			if (id_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ == IntPtr.Zero)
				id_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_ = JNIEnv.GetMethodID (class_ref, "collectRewardedVideoBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/bidding/BiddingDataCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collectRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_bidding_BiddingDataCallback_, __args);
		}

		static Delegate cb_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == null)
				cb_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_GetRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_));
			return cb_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetRewardedVideoBiddingData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetRewardedVideoBiddingData (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1)
		{
			if (id_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "getRewardedVideoBiddingData", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Ljava/util/Map;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRewardedVideoBiddingData_Lorg_json_JSONObject_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler ()
		{
			if (cb_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == null)
				cb_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_InitAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_));
			return cb_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		}

		static void n_InitAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.InitAndLoadRewardedVideo (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		public unsafe void InitAndLoadRewardedVideo (string p0, string p1, global::Org.Json.JSONObject p2, global::Org.Json.JSONObject p3, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p4)
		{
			if (id_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == IntPtr.Zero)
				id_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNIEnv.GetMethodID (class_ref, "initAndLoadRewardedVideo", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initAndLoadRewardedVideo_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler ()
		{
			if (cb_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == null)
				cb_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_));
			return cb_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		}

		static void n_InitRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InitRewardedVideoForDemandOnly (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		public unsafe void InitRewardedVideoForDemandOnly (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p3)
		{
			if (id_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == IntPtr.Zero)
				id_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNIEnv.GetMethodID (class_ref, "initRewardedVideoForDemandOnly", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initRewardedVideoForDemandOnly_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
#pragma warning disable 0169
		static Delegate GetInitRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler ()
		{
			if (cb_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == null)
				cb_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_InitRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_));
			return cb_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		}

		static void n_InitRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InitRewardedVideoWithCallback (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		public unsafe void InitRewardedVideoWithCallback (string p0, string p1, global::Org.Json.JSONObject p2, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p3)
		{
			if (id_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == IntPtr.Zero)
				id_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNIEnv.GetMethodID (class_ref, "initRewardedVideoWithCallback", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initRewardedVideoWithCallback_Ljava_lang_String_Ljava_lang_String_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_isRewardedVideoAvailable_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetIsRewardedVideoAvailable_Lorg_json_JSONObject_Handler ()
		{
			if (cb_isRewardedVideoAvailable_Lorg_json_JSONObject_ == null)
				cb_isRewardedVideoAvailable_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsRewardedVideoAvailable_Lorg_json_JSONObject_));
			return cb_isRewardedVideoAvailable_Lorg_json_JSONObject_;
		}

		static bool n_IsRewardedVideoAvailable_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRewardedVideoAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isRewardedVideoAvailable_Lorg_json_JSONObject_;
		public unsafe bool IsRewardedVideoAvailable (global::Org.Json.JSONObject p0)
		{
			if (id_isRewardedVideoAvailable_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_isRewardedVideoAvailable_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "isRewardedVideoAvailable", "(Lorg/json/JSONObject;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRewardedVideoAvailable_Lorg_json_JSONObject_, __args);
			return __ret;
		}

		static Delegate cb_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler ()
		{
			if (cb_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == null)
				cb_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_LoadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_));
			return cb_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		}

		static void n_LoadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadRewardedVideo (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		public unsafe void LoadRewardedVideo (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p2)
		{
			if (id_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == IntPtr.Zero)
				id_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadRewardedVideo", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadRewardedVideo_Lorg_json_JSONObject_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_, __args);
		}

		static Delegate cb_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
#pragma warning disable 0169
		static Delegate GetLoadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler ()
		{
			if (cb_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == null)
				cb_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_LoadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_));
			return cb_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		}

		static void n_LoadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadRewardedVideoForBidding (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		public unsafe void LoadRewardedVideoForBidding (global::Org.Json.JSONObject p0, global::Org.Json.JSONObject p1, string p2, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p3)
		{
			if (id_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == IntPtr.Zero)
				id_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNIEnv.GetMethodID (class_ref, "loadRewardedVideoForBidding", "(Lorg/json/JSONObject;Lorg/json/JSONObject;Ljava/lang/String;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V");
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadRewardedVideoForBidding_Lorg_json_JSONObject_Lorg_json_JSONObject_Ljava_lang_String_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
#pragma warning disable 0169
		static Delegate GetShowRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_Handler ()
		{
			if (cb_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == null)
				cb_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_ShowRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_));
			return cb_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		}

		static void n_ShowRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowRewardedVideo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_;
		public unsafe void ShowRewardedVideo (global::Org.Json.JSONObject p0, global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener p1)
		{
			if (id_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ == IntPtr.Zero)
				id_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_ = JNIEnv.GetMethodID (class_ref, "showRewardedVideo", "(Lorg/json/JSONObject;Lcom/ironsource/mediationsdk/sdk/RewardedVideoSmashListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showRewardedVideo_Lorg_json_JSONObject_Lcom_ironsource_mediationsdk_sdk_RewardedVideoSmashListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
