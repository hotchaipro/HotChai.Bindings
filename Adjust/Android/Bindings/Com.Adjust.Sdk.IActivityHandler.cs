using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']"
	[Register ("com/adjust/sdk/IActivityHandler", "", "Com.Adjust.Sdk.IActivityHandlerInvoker")]
	public partial interface IActivityHandler : IJavaObject, IJavaPeerable {
		global::Com.Adjust.Sdk.ActivityState ActivityState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getActivityState' and count(parameter)=0]"
			[Register ("getActivityState", "()Lcom/adjust/sdk/ActivityState;", "GetGetActivityStateHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 
		}

		string Adid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getAdid' and count(parameter)=0]"
			[Register ("getAdid", "()Ljava/lang/String;", "GetGetAdidHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 
		}

		global::Com.Adjust.Sdk.AdjustConfig AdjustConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getAdjustConfig' and count(parameter)=0]"
			[Register ("getAdjustConfig", "()Lcom/adjust/sdk/AdjustConfig;", "GetGetAdjustConfigHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 
		}

		global::Com.Adjust.Sdk.AdjustAttribution Attribution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getAttribution' and count(parameter)=0]"
			[Register ("getAttribution", "()Lcom/adjust/sdk/AdjustAttribution;", "GetGetAttributionHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 
		}

		global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 
		}

		global::Java.Lang.Object DeviceInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getDeviceInfo' and count(parameter)=0]"
			[Register ("getDeviceInfo", "()Ljava/lang/Object;", "GetGetDeviceInfoHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 
		}

		bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			set; 
		}

		//global::Com.Adjust.Sdk.ActivityHandler.InternalState InternalState {
		//	// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getInternalState' and count(parameter)=0]"
		//	[Register ("getInternalState", "()Lcom/adjust/sdk/ActivityHandler$InternalState;", "GetGetInternalStateHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		//	get; 
		//}

		global::Com.Adjust.Sdk.SessionParameters SessionParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='getSessionParameters' and count(parameter)=0]"
			[Register ("getSessionParameters", "()Lcom/adjust/sdk/SessionParameters;", "GetGetSessionParametersHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='addSessionCallbackParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addSessionCallbackParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void AddSessionCallbackParameter (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='addSessionPartnerParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addSessionPartnerParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void AddSessionPartnerParameter (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='disableThirdPartySharing' and count(parameter)=0]"
		[Register ("disableThirdPartySharing", "()V", "GetDisableThirdPartySharingHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void DisableThirdPartySharing ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='finishedTrackingActivity' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.ResponseData']]"
		[Register ("finishedTrackingActivity", "(Lcom/adjust/sdk/ResponseData;)V", "GetFinishedTrackingActivity_Lcom_adjust_sdk_ResponseData_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void FinishedTrackingActivity (global::Com.Adjust.Sdk.ResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='gdprForgetMe' and count(parameter)=0]"
		[Register ("gdprForgetMe", "()V", "GetGdprForgetMeHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void GdprForgetMe ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='gotOptOutResponse' and count(parameter)=0]"
		[Register ("gotOptOutResponse", "()V", "GetGotOptOutResponseHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void GotOptOutResponse ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustConfig']]"
		[Register ("init", "(Lcom/adjust/sdk/AdjustConfig;)V", "GetInit_Lcom_adjust_sdk_AdjustConfig_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void Init (global::Com.Adjust.Sdk.AdjustConfig p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='launchAttributionResponseTasks' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AttributionResponseData']]"
		[Register ("launchAttributionResponseTasks", "(Lcom/adjust/sdk/AttributionResponseData;)V", "GetLaunchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void LaunchAttributionResponseTasks (global::Com.Adjust.Sdk.AttributionResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='launchEventResponseTasks' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.EventResponseData']]"
		[Register ("launchEventResponseTasks", "(Lcom/adjust/sdk/EventResponseData;)V", "GetLaunchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void LaunchEventResponseTasks (global::Com.Adjust.Sdk.EventResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='launchPurchaseVerificationResponseTasks' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.PurchaseVerificationResponseData']]"
		[Register ("launchPurchaseVerificationResponseTasks", "(Lcom/adjust/sdk/PurchaseVerificationResponseData;)V", "GetLaunchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void LaunchPurchaseVerificationResponseTasks (global::Com.Adjust.Sdk.PurchaseVerificationResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='launchSdkClickResponseTasks' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.SdkClickResponseData']]"
		[Register ("launchSdkClickResponseTasks", "(Lcom/adjust/sdk/SdkClickResponseData;)V", "GetLaunchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void LaunchSdkClickResponseTasks (global::Com.Adjust.Sdk.SdkClickResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='launchSessionResponseTasks' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.SessionResponseData']]"
		[Register ("launchSessionResponseTasks", "(Lcom/adjust/sdk/SessionResponseData;)V", "GetLaunchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void LaunchSessionResponseTasks (global::Com.Adjust.Sdk.SessionResponseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void OnPause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void OnResume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='readOpenUrl' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='long']]"
		[Register ("readOpenUrl", "(Landroid/net/Uri;J)V", "GetReadOpenUrl_Landroid_net_Uri_JHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void ReadOpenUrl (global::Android.Net.Uri p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='readOpenUrl' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='long'] and parameter[3][@type='com.adjust.sdk.OnDeeplinkResolvedListener']]"
		[Register ("readOpenUrl", "(Landroid/net/Uri;JLcom/adjust/sdk/OnDeeplinkResolvedListener;)V", "GetReadOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void ReadOpenUrl (global::Android.Net.Uri p0, long p1, global::Com.Adjust.Sdk.IOnDeeplinkResolvedListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='removeSessionCallbackParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeSessionCallbackParameter", "(Ljava/lang/String;)V", "GetRemoveSessionCallbackParameter_Ljava_lang_String_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void RemoveSessionCallbackParameter (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='removeSessionPartnerParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeSessionPartnerParameter", "(Ljava/lang/String;)V", "GetRemoveSessionPartnerParameter_Ljava_lang_String_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void RemoveSessionPartnerParameter (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='resetSessionCallbackParameters' and count(parameter)=0]"
		[Register ("resetSessionCallbackParameters", "()V", "GetResetSessionCallbackParametersHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void ResetSessionCallbackParameters ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='resetSessionPartnerParameters' and count(parameter)=0]"
		[Register ("resetSessionPartnerParameters", "()V", "GetResetSessionPartnerParametersHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void ResetSessionPartnerParameters ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='sendFirstPackages' and count(parameter)=0]"
		[Register ("sendFirstPackages", "()V", "GetSendFirstPackagesHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void SendFirstPackages ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='sendInstallReferrer' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.ReferrerDetails'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendInstallReferrer", "(Lcom/adjust/sdk/ReferrerDetails;Ljava/lang/String;)V", "GetSendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void SendInstallReferrer (global::Com.Adjust.Sdk.ReferrerDetails p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='sendPreinstallReferrer' and count(parameter)=0]"
		[Register ("sendPreinstallReferrer", "()V", "GetSendPreinstallReferrerHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void SendPreinstallReferrer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='sendReftagReferrer' and count(parameter)=0]"
		[Register ("sendReftagReferrer", "()V", "GetSendReftagReferrerHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void SendReftagReferrer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='setAskingAttribution' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAskingAttribution", "(Z)V", "GetSetAskingAttribution_ZHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void SetAskingAttribution (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='setOfflineMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOfflineMode", "(Z)V", "GetSetOfflineMode_ZHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void SetOfflineMode (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='setPushToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setPushToken", "(Ljava/lang/String;Z)V", "GetSetPushToken_Ljava_lang_String_ZHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void SetPushToken (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='teardown' and count(parameter)=0]"
		[Register ("teardown", "()V", "GetTeardownHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void Teardown ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='trackAdRevenue' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustAdRevenue']]"
		[Register ("trackAdRevenue", "(Lcom/adjust/sdk/AdjustAdRevenue;)V", "GetTrackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void TrackAdRevenue (global::Com.Adjust.Sdk.AdjustAdRevenue p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='trackAdRevenue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("trackAdRevenue", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetTrackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void TrackAdRevenue (string p0, global::Org.Json.JSONObject p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='trackEvent' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustEvent']]"
		[Register ("trackEvent", "(Lcom/adjust/sdk/AdjustEvent;)V", "GetTrackEvent_Lcom_adjust_sdk_AdjustEvent_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void TrackEvent (global::Com.Adjust.Sdk.AdjustEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='trackMeasurementConsent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("trackMeasurementConsent", "(Z)V", "GetTrackMeasurementConsent_ZHandler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void TrackMeasurementConsent (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='trackPlayStoreSubscription' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustPlayStoreSubscription']]"
		[Register ("trackPlayStoreSubscription", "(Lcom/adjust/sdk/AdjustPlayStoreSubscription;)V", "GetTrackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void TrackPlayStoreSubscription (global::Com.Adjust.Sdk.AdjustPlayStoreSubscription p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='trackThirdPartySharing' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustThirdPartySharing']]"
		[Register ("trackThirdPartySharing", "(Lcom/adjust/sdk/AdjustThirdPartySharing;)V", "GetTrackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void TrackThirdPartySharing (global::Com.Adjust.Sdk.AdjustThirdPartySharing p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='updateAttributionI' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustAttribution']]"
		[Register ("updateAttributionI", "(Lcom/adjust/sdk/AdjustAttribution;)Z", "GetUpdateAttributionI_Lcom_adjust_sdk_AdjustAttribution_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		bool UpdateAttributionI (global::Com.Adjust.Sdk.AdjustAttribution p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='IActivityHandler']/method[@name='verifyPurchase' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.AdjustPurchase'] and parameter[2][@type='com.adjust.sdk.OnPurchaseVerificationFinishedListener']]"
		[Register ("verifyPurchase", "(Lcom/adjust/sdk/AdjustPurchase;Lcom/adjust/sdk/OnPurchaseVerificationFinishedListener;)V", "GetVerifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_Handler:Com.Adjust.Sdk.IActivityHandlerInvoker, MatchBlocks.Android")]
		void VerifyPurchase (global::Com.Adjust.Sdk.AdjustPurchase p0, global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener p1);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/IActivityHandler", DoNotGenerateAcw=true)]
	internal partial class IActivityHandlerInvoker : global::Java.Lang.Object, IActivityHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/IActivityHandler", typeof (IActivityHandlerInvoker));

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

		public static IActivityHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IActivityHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.IActivityHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IActivityHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getActivityState;
#pragma warning disable 0169
		static Delegate GetGetActivityStateHandler ()
		{
			if (cb_getActivityState == null)
				cb_getActivityState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetActivityState));
			return cb_getActivityState;
		}

		static IntPtr n_GetActivityState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActivityState);
		}
#pragma warning restore 0169

		IntPtr id_getActivityState;
		public unsafe global::Com.Adjust.Sdk.ActivityState ActivityState {
			get {
				if (id_getActivityState == IntPtr.Zero)
					id_getActivityState = JNIEnv.GetMethodID (class_ref, "getActivityState", "()Lcom/adjust/sdk/ActivityState;");
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivityState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdid;
#pragma warning disable 0169
		static Delegate GetGetAdidHandler ()
		{
			if (cb_getAdid == null)
				cb_getAdid = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdid));
			return cb_getAdid;
		}

		static IntPtr n_GetAdid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Adid);
		}
#pragma warning restore 0169

		IntPtr id_getAdid;
		public unsafe string Adid {
			get {
				if (id_getAdid == IntPtr.Zero)
					id_getAdid = JNIEnv.GetMethodID (class_ref, "getAdid", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdid), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdjustConfig;
#pragma warning disable 0169
		static Delegate GetGetAdjustConfigHandler ()
		{
			if (cb_getAdjustConfig == null)
				cb_getAdjustConfig = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdjustConfig));
			return cb_getAdjustConfig;
		}

		static IntPtr n_GetAdjustConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdjustConfig);
		}
#pragma warning restore 0169

		IntPtr id_getAdjustConfig;
		public unsafe global::Com.Adjust.Sdk.AdjustConfig AdjustConfig {
			get {
				if (id_getAdjustConfig == IntPtr.Zero)
					id_getAdjustConfig = JNIEnv.GetMethodID (class_ref, "getAdjustConfig", "()Lcom/adjust/sdk/AdjustConfig;");
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustConfig), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAttribution;
#pragma warning disable 0169
		static Delegate GetGetAttributionHandler ()
		{
			if (cb_getAttribution == null)
				cb_getAttribution = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAttribution));
			return cb_getAttribution;
		}

		static IntPtr n_GetAttribution (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attribution);
		}
#pragma warning restore 0169

		IntPtr id_getAttribution;
		public unsafe global::Com.Adjust.Sdk.AdjustAttribution Attribution {
			get {
				if (id_getAttribution == IntPtr.Zero)
					id_getAttribution = JNIEnv.GetMethodID (class_ref, "getAttribution", "()Lcom/adjust/sdk/AdjustAttribution;");
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustAttribution> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttribution), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetContext));
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		IntPtr id_getContext;
		public unsafe global::Android.Content.Context Context {
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceInfo;
#pragma warning disable 0169
		static Delegate GetGetDeviceInfoHandler ()
		{
			if (cb_getDeviceInfo == null)
				cb_getDeviceInfo = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDeviceInfo));
			return cb_getDeviceInfo;
		}

		static IntPtr n_GetDeviceInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceInfo);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceInfo;
		public unsafe global::Java.Lang.Object DeviceInfo {
			get {
				if (id_getDeviceInfo == IntPtr.Zero)
					id_getDeviceInfo = JNIEnv.GetMethodID (class_ref, "getDeviceInfo", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsEnabled));
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetEnabled_Z));
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isEnabled;
		IntPtr id_setEnabled_Z;
		public unsafe bool Enabled {
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
			}
			set {
				if (id_setEnabled_Z == IntPtr.Zero)
					id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnabled_Z, __args);
			}
		}

		//static Delegate cb_getInternalState;
#pragma warning disable 0169
		//static Delegate GetGetInternalStateHandler ()
		//{
		//	if (cb_getInternalState == null)
		//		cb_getInternalState = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetInternalState));
		//	return cb_getInternalState;
		//}

		//static IntPtr n_GetInternalState (IntPtr jnienv, IntPtr native__this)
		//{
		//	var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
		//	return JNIEnv.ToLocalJniHandle (__this.InternalState);
		//}
#pragma warning restore 0169

		IntPtr id_getInternalState;
		public unsafe global::Com.Adjust.Sdk.ActivityHandler.InternalState InternalState {
			get {
				if (id_getInternalState == IntPtr.Zero)
					id_getInternalState = JNIEnv.GetMethodID (class_ref, "getInternalState", "()Lcom/adjust/sdk/ActivityHandler$InternalState;");
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityHandler.InternalState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInternalState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSessionParameters;
#pragma warning disable 0169
		static Delegate GetGetSessionParametersHandler ()
		{
			if (cb_getSessionParameters == null)
				cb_getSessionParameters = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSessionParameters));
			return cb_getSessionParameters;
		}

		static IntPtr n_GetSessionParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SessionParameters);
		}
#pragma warning restore 0169

		IntPtr id_getSessionParameters;
		public unsafe global::Com.Adjust.Sdk.SessionParameters SessionParameters {
			get {
				if (id_getSessionParameters == IntPtr.Zero)
					id_getSessionParameters = JNIEnv.GetMethodID (class_ref, "getSessionParameters", "()Lcom/adjust/sdk/SessionParameters;");
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.SessionParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AddSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_));
			return cb_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSessionCallbackParameter (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void AddSessionCallbackParameter (string p0, string p1)
		{
			if (id_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addSessionCallbackParameter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSessionCallbackParameter_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AddSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_));
			return cb_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSessionPartnerParameter (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void AddSessionPartnerParameter (string p0, string p1)
		{
			if (id_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addSessionPartnerParameter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSessionPartnerParameter_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_disableThirdPartySharing;
#pragma warning disable 0169
		static Delegate GetDisableThirdPartySharingHandler ()
		{
			if (cb_disableThirdPartySharing == null)
				cb_disableThirdPartySharing = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_DisableThirdPartySharing));
			return cb_disableThirdPartySharing;
		}

		static void n_DisableThirdPartySharing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableThirdPartySharing ();
		}
#pragma warning restore 0169

		IntPtr id_disableThirdPartySharing;
		public unsafe void DisableThirdPartySharing ()
		{
			if (id_disableThirdPartySharing == IntPtr.Zero)
				id_disableThirdPartySharing = JNIEnv.GetMethodID (class_ref, "disableThirdPartySharing", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableThirdPartySharing);
		}

		static Delegate cb_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_;
#pragma warning disable 0169
		static Delegate GetFinishedTrackingActivity_Lcom_adjust_sdk_ResponseData_Handler ()
		{
			if (cb_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_ == null)
				cb_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_FinishedTrackingActivity_Lcom_adjust_sdk_ResponseData_));
			return cb_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_;
		}

		static void n_FinishedTrackingActivity_Lcom_adjust_sdk_ResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FinishedTrackingActivity (p0);
		}
#pragma warning restore 0169

		IntPtr id_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_;
		public unsafe void FinishedTrackingActivity (global::Com.Adjust.Sdk.ResponseData p0)
		{
			if (id_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_ == IntPtr.Zero)
				id_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_ = JNIEnv.GetMethodID (class_ref, "finishedTrackingActivity", "(Lcom/adjust/sdk/ResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishedTrackingActivity_Lcom_adjust_sdk_ResponseData_, __args);
		}

		static Delegate cb_gdprForgetMe;
#pragma warning disable 0169
		static Delegate GetGdprForgetMeHandler ()
		{
			if (cb_gdprForgetMe == null)
				cb_gdprForgetMe = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_GdprForgetMe));
			return cb_gdprForgetMe;
		}

		static void n_GdprForgetMe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GdprForgetMe ();
		}
#pragma warning restore 0169

		IntPtr id_gdprForgetMe;
		public unsafe void GdprForgetMe ()
		{
			if (id_gdprForgetMe == IntPtr.Zero)
				id_gdprForgetMe = JNIEnv.GetMethodID (class_ref, "gdprForgetMe", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_gdprForgetMe);
		}

		static Delegate cb_gotOptOutResponse;
#pragma warning disable 0169
		static Delegate GetGotOptOutResponseHandler ()
		{
			if (cb_gotOptOutResponse == null)
				cb_gotOptOutResponse = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_GotOptOutResponse));
			return cb_gotOptOutResponse;
		}

		static void n_GotOptOutResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GotOptOutResponse ();
		}
#pragma warning restore 0169

		IntPtr id_gotOptOutResponse;
		public unsafe void GotOptOutResponse ()
		{
			if (id_gotOptOutResponse == IntPtr.Zero)
				id_gotOptOutResponse = JNIEnv.GetMethodID (class_ref, "gotOptOutResponse", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_gotOptOutResponse);
		}

		static Delegate cb_init_Lcom_adjust_sdk_AdjustConfig_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_adjust_sdk_AdjustConfig_Handler ()
		{
			if (cb_init_Lcom_adjust_sdk_AdjustConfig_ == null)
				cb_init_Lcom_adjust_sdk_AdjustConfig_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Init_Lcom_adjust_sdk_AdjustConfig_));
			return cb_init_Lcom_adjust_sdk_AdjustConfig_;
		}

		static void n_Init_Lcom_adjust_sdk_AdjustConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_adjust_sdk_AdjustConfig_;
		public unsafe void Init (global::Com.Adjust.Sdk.AdjustConfig p0)
		{
			if (id_init_Lcom_adjust_sdk_AdjustConfig_ == IntPtr.Zero)
				id_init_Lcom_adjust_sdk_AdjustConfig_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/adjust/sdk/AdjustConfig;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_adjust_sdk_AdjustConfig_, __args);
		}

		static Delegate cb_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_;
#pragma warning disable 0169
		static Delegate GetLaunchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_Handler ()
		{
			if (cb_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_ == null)
				cb_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LaunchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_));
			return cb_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_;
		}

		static void n_LaunchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AttributionResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LaunchAttributionResponseTasks (p0);
		}
#pragma warning restore 0169

		IntPtr id_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_;
		public unsafe void LaunchAttributionResponseTasks (global::Com.Adjust.Sdk.AttributionResponseData p0)
		{
			if (id_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_ == IntPtr.Zero)
				id_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_ = JNIEnv.GetMethodID (class_ref, "launchAttributionResponseTasks", "(Lcom/adjust/sdk/AttributionResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_launchAttributionResponseTasks_Lcom_adjust_sdk_AttributionResponseData_, __args);
		}

		static Delegate cb_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_;
#pragma warning disable 0169
		static Delegate GetLaunchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_Handler ()
		{
			if (cb_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_ == null)
				cb_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LaunchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_));
			return cb_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_;
		}

		static void n_LaunchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.EventResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LaunchEventResponseTasks (p0);
		}
#pragma warning restore 0169

		IntPtr id_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_;
		public unsafe void LaunchEventResponseTasks (global::Com.Adjust.Sdk.EventResponseData p0)
		{
			if (id_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_ == IntPtr.Zero)
				id_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_ = JNIEnv.GetMethodID (class_ref, "launchEventResponseTasks", "(Lcom/adjust/sdk/EventResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_launchEventResponseTasks_Lcom_adjust_sdk_EventResponseData_, __args);
		}

		static Delegate cb_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_;
#pragma warning disable 0169
		static Delegate GetLaunchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_Handler ()
		{
			if (cb_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_ == null)
				cb_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LaunchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_));
			return cb_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_;
		}

		static void n_LaunchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PurchaseVerificationResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LaunchPurchaseVerificationResponseTasks (p0);
		}
#pragma warning restore 0169

		IntPtr id_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_;
		public unsafe void LaunchPurchaseVerificationResponseTasks (global::Com.Adjust.Sdk.PurchaseVerificationResponseData p0)
		{
			if (id_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_ == IntPtr.Zero)
				id_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_ = JNIEnv.GetMethodID (class_ref, "launchPurchaseVerificationResponseTasks", "(Lcom/adjust/sdk/PurchaseVerificationResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_launchPurchaseVerificationResponseTasks_Lcom_adjust_sdk_PurchaseVerificationResponseData_, __args);
		}

		static Delegate cb_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_;
#pragma warning disable 0169
		static Delegate GetLaunchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_Handler ()
		{
			if (cb_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_ == null)
				cb_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LaunchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_));
			return cb_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_;
		}

		static void n_LaunchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.SdkClickResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LaunchSdkClickResponseTasks (p0);
		}
#pragma warning restore 0169

		IntPtr id_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_;
		public unsafe void LaunchSdkClickResponseTasks (global::Com.Adjust.Sdk.SdkClickResponseData p0)
		{
			if (id_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_ == IntPtr.Zero)
				id_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_ = JNIEnv.GetMethodID (class_ref, "launchSdkClickResponseTasks", "(Lcom/adjust/sdk/SdkClickResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_launchSdkClickResponseTasks_Lcom_adjust_sdk_SdkClickResponseData_, __args);
		}

		static Delegate cb_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_;
#pragma warning disable 0169
		static Delegate GetLaunchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_Handler ()
		{
			if (cb_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_ == null)
				cb_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LaunchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_));
			return cb_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_;
		}

		static void n_LaunchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.SessionResponseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LaunchSessionResponseTasks (p0);
		}
#pragma warning restore 0169

		IntPtr id_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_;
		public unsafe void LaunchSessionResponseTasks (global::Com.Adjust.Sdk.SessionResponseData p0)
		{
			if (id_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_ == IntPtr.Zero)
				id_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_ = JNIEnv.GetMethodID (class_ref, "launchSessionResponseTasks", "(Lcom/adjust/sdk/SessionResponseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_launchSessionResponseTasks_Lcom_adjust_sdk_SessionResponseData_, __args);
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnPause));
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		IntPtr id_onPause;
		public unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnResume));
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		IntPtr id_onResume;
		public unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
		}

		static Delegate cb_readOpenUrl_Landroid_net_Uri_J;
#pragma warning disable 0169
		static Delegate GetReadOpenUrl_Landroid_net_Uri_JHandler ()
		{
			if (cb_readOpenUrl_Landroid_net_Uri_J == null)
				cb_readOpenUrl_Landroid_net_Uri_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJ_V (n_ReadOpenUrl_Landroid_net_Uri_J));
			return cb_readOpenUrl_Landroid_net_Uri_J;
		}

		static void n_ReadOpenUrl_Landroid_net_Uri_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadOpenUrl (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_readOpenUrl_Landroid_net_Uri_J;
		public unsafe void ReadOpenUrl (global::Android.Net.Uri p0, long p1)
		{
			if (id_readOpenUrl_Landroid_net_Uri_J == IntPtr.Zero)
				id_readOpenUrl_Landroid_net_Uri_J = JNIEnv.GetMethodID (class_ref, "readOpenUrl", "(Landroid/net/Uri;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readOpenUrl_Landroid_net_Uri_J, __args);
		}

		static Delegate cb_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_;
#pragma warning disable 0169
		static Delegate GetReadOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_Handler ()
		{
			if (cb_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_ == null)
				cb_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJL_V (n_ReadOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_));
			return cb_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_;
		}

		static void n_ReadOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Adjust.Sdk.IOnDeeplinkResolvedListener)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnDeeplinkResolvedListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ReadOpenUrl (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_;
		public unsafe void ReadOpenUrl (global::Android.Net.Uri p0, long p1, global::Com.Adjust.Sdk.IOnDeeplinkResolvedListener p2)
		{
			if (id_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_ == IntPtr.Zero)
				id_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_ = JNIEnv.GetMethodID (class_ref, "readOpenUrl", "(Landroid/net/Uri;JLcom/adjust/sdk/OnDeeplinkResolvedListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readOpenUrl_Landroid_net_Uri_JLcom_adjust_sdk_OnDeeplinkResolvedListener_, __args);
		}

		static Delegate cb_removeSessionCallbackParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveSessionCallbackParameter_Ljava_lang_String_Handler ()
		{
			if (cb_removeSessionCallbackParameter_Ljava_lang_String_ == null)
				cb_removeSessionCallbackParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RemoveSessionCallbackParameter_Ljava_lang_String_));
			return cb_removeSessionCallbackParameter_Ljava_lang_String_;
		}

		static void n_RemoveSessionCallbackParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSessionCallbackParameter (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeSessionCallbackParameter_Ljava_lang_String_;
		public unsafe void RemoveSessionCallbackParameter (string p0)
		{
			if (id_removeSessionCallbackParameter_Ljava_lang_String_ == IntPtr.Zero)
				id_removeSessionCallbackParameter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeSessionCallbackParameter", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSessionCallbackParameter_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeSessionPartnerParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveSessionPartnerParameter_Ljava_lang_String_Handler ()
		{
			if (cb_removeSessionPartnerParameter_Ljava_lang_String_ == null)
				cb_removeSessionPartnerParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RemoveSessionPartnerParameter_Ljava_lang_String_));
			return cb_removeSessionPartnerParameter_Ljava_lang_String_;
		}

		static void n_RemoveSessionPartnerParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSessionPartnerParameter (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeSessionPartnerParameter_Ljava_lang_String_;
		public unsafe void RemoveSessionPartnerParameter (string p0)
		{
			if (id_removeSessionPartnerParameter_Ljava_lang_String_ == IntPtr.Zero)
				id_removeSessionPartnerParameter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeSessionPartnerParameter", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSessionPartnerParameter_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_resetSessionCallbackParameters;
#pragma warning disable 0169
		static Delegate GetResetSessionCallbackParametersHandler ()
		{
			if (cb_resetSessionCallbackParameters == null)
				cb_resetSessionCallbackParameters = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ResetSessionCallbackParameters));
			return cb_resetSessionCallbackParameters;
		}

		static void n_ResetSessionCallbackParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetSessionCallbackParameters ();
		}
#pragma warning restore 0169

		IntPtr id_resetSessionCallbackParameters;
		public unsafe void ResetSessionCallbackParameters ()
		{
			if (id_resetSessionCallbackParameters == IntPtr.Zero)
				id_resetSessionCallbackParameters = JNIEnv.GetMethodID (class_ref, "resetSessionCallbackParameters", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetSessionCallbackParameters);
		}

		static Delegate cb_resetSessionPartnerParameters;
#pragma warning disable 0169
		static Delegate GetResetSessionPartnerParametersHandler ()
		{
			if (cb_resetSessionPartnerParameters == null)
				cb_resetSessionPartnerParameters = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ResetSessionPartnerParameters));
			return cb_resetSessionPartnerParameters;
		}

		static void n_ResetSessionPartnerParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetSessionPartnerParameters ();
		}
#pragma warning restore 0169

		IntPtr id_resetSessionPartnerParameters;
		public unsafe void ResetSessionPartnerParameters ()
		{
			if (id_resetSessionPartnerParameters == IntPtr.Zero)
				id_resetSessionPartnerParameters = JNIEnv.GetMethodID (class_ref, "resetSessionPartnerParameters", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetSessionPartnerParameters);
		}

		static Delegate cb_sendFirstPackages;
#pragma warning disable 0169
		static Delegate GetSendFirstPackagesHandler ()
		{
			if (cb_sendFirstPackages == null)
				cb_sendFirstPackages = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SendFirstPackages));
			return cb_sendFirstPackages;
		}

		static void n_SendFirstPackages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendFirstPackages ();
		}
#pragma warning restore 0169

		IntPtr id_sendFirstPackages;
		public unsafe void SendFirstPackages ()
		{
			if (id_sendFirstPackages == IntPtr.Zero)
				id_sendFirstPackages = JNIEnv.GetMethodID (class_ref, "sendFirstPackages", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFirstPackages);
		}

		static Delegate cb_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_Handler ()
		{
			if (cb_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ == null)
				cb_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_));
			return cb_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_;
		}

		static void n_SendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ReferrerDetails> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendInstallReferrer (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_;
		public unsafe void SendInstallReferrer (global::Com.Adjust.Sdk.ReferrerDetails p0, string p1)
		{
			if (id_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ == IntPtr.Zero)
				id_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendInstallReferrer", "(Lcom/adjust/sdk/ReferrerDetails;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendInstallReferrer_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sendPreinstallReferrer;
#pragma warning disable 0169
		static Delegate GetSendPreinstallReferrerHandler ()
		{
			if (cb_sendPreinstallReferrer == null)
				cb_sendPreinstallReferrer = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SendPreinstallReferrer));
			return cb_sendPreinstallReferrer;
		}

		static void n_SendPreinstallReferrer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendPreinstallReferrer ();
		}
#pragma warning restore 0169

		IntPtr id_sendPreinstallReferrer;
		public unsafe void SendPreinstallReferrer ()
		{
			if (id_sendPreinstallReferrer == IntPtr.Zero)
				id_sendPreinstallReferrer = JNIEnv.GetMethodID (class_ref, "sendPreinstallReferrer", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPreinstallReferrer);
		}

		static Delegate cb_sendReftagReferrer;
#pragma warning disable 0169
		static Delegate GetSendReftagReferrerHandler ()
		{
			if (cb_sendReftagReferrer == null)
				cb_sendReftagReferrer = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SendReftagReferrer));
			return cb_sendReftagReferrer;
		}

		static void n_SendReftagReferrer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendReftagReferrer ();
		}
#pragma warning restore 0169

		IntPtr id_sendReftagReferrer;
		public unsafe void SendReftagReferrer ()
		{
			if (id_sendReftagReferrer == IntPtr.Zero)
				id_sendReftagReferrer = JNIEnv.GetMethodID (class_ref, "sendReftagReferrer", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendReftagReferrer);
		}

		static Delegate cb_setAskingAttribution_Z;
#pragma warning disable 0169
		static Delegate GetSetAskingAttribution_ZHandler ()
		{
			if (cb_setAskingAttribution_Z == null)
				cb_setAskingAttribution_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetAskingAttribution_Z));
			return cb_setAskingAttribution_Z;
		}

		static void n_SetAskingAttribution_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAskingAttribution (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAskingAttribution_Z;
		public unsafe void SetAskingAttribution (bool p0)
		{
			if (id_setAskingAttribution_Z == IntPtr.Zero)
				id_setAskingAttribution_Z = JNIEnv.GetMethodID (class_ref, "setAskingAttribution", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAskingAttribution_Z, __args);
		}

		static Delegate cb_setOfflineMode_Z;
#pragma warning disable 0169
		static Delegate GetSetOfflineMode_ZHandler ()
		{
			if (cb_setOfflineMode_Z == null)
				cb_setOfflineMode_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetOfflineMode_Z));
			return cb_setOfflineMode_Z;
		}

		static void n_SetOfflineMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOfflineMode (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOfflineMode_Z;
		public unsafe void SetOfflineMode (bool p0)
		{
			if (id_setOfflineMode_Z == IntPtr.Zero)
				id_setOfflineMode_Z = JNIEnv.GetMethodID (class_ref, "setOfflineMode", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOfflineMode_Z, __args);
		}

		static Delegate cb_setPushToken_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetPushToken_Ljava_lang_String_ZHandler ()
		{
			if (cb_setPushToken_Ljava_lang_String_Z == null)
				cb_setPushToken_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_V (n_SetPushToken_Ljava_lang_String_Z));
			return cb_setPushToken_Ljava_lang_String_Z;
		}

		static void n_SetPushToken_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPushToken (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPushToken_Ljava_lang_String_Z;
		public unsafe void SetPushToken (string p0, bool p1)
		{
			if (id_setPushToken_Ljava_lang_String_Z == IntPtr.Zero)
				id_setPushToken_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setPushToken", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPushToken_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_teardown;
#pragma warning disable 0169
		static Delegate GetTeardownHandler ()
		{
			if (cb_teardown == null)
				cb_teardown = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Teardown));
			return cb_teardown;
		}

		static void n_Teardown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Teardown ();
		}
#pragma warning restore 0169

		IntPtr id_teardown;
		public unsafe void Teardown ()
		{
			if (id_teardown == IntPtr.Zero)
				id_teardown = JNIEnv.GetMethodID (class_ref, "teardown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_teardown);
		}

		static Delegate cb_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_;
#pragma warning disable 0169
		static Delegate GetTrackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_Handler ()
		{
			if (cb_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_ == null)
				cb_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_TrackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_));
			return cb_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_;
		}

		static void n_TrackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustAdRevenue> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackAdRevenue (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_;
		public unsafe void TrackAdRevenue (global::Com.Adjust.Sdk.AdjustAdRevenue p0)
		{
			if (id_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_ == IntPtr.Zero)
				id_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_ = JNIEnv.GetMethodID (class_ref, "trackAdRevenue", "(Lcom/adjust/sdk/AdjustAdRevenue;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackAdRevenue_Lcom_adjust_sdk_AdjustAdRevenue_, __args);
		}

		static Delegate cb_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetTrackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_TrackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_));
			return cb_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static void n_TrackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TrackAdRevenue (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_;
		public unsafe void TrackAdRevenue (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "trackAdRevenue", "(Ljava/lang/String;Lorg/json/JSONObject;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackAdRevenue_Ljava_lang_String_Lorg_json_JSONObject_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_trackEvent_Lcom_adjust_sdk_AdjustEvent_;
#pragma warning disable 0169
		static Delegate GetTrackEvent_Lcom_adjust_sdk_AdjustEvent_Handler ()
		{
			if (cb_trackEvent_Lcom_adjust_sdk_AdjustEvent_ == null)
				cb_trackEvent_Lcom_adjust_sdk_AdjustEvent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_TrackEvent_Lcom_adjust_sdk_AdjustEvent_));
			return cb_trackEvent_Lcom_adjust_sdk_AdjustEvent_;
		}

		static void n_TrackEvent_Lcom_adjust_sdk_AdjustEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackEvent_Lcom_adjust_sdk_AdjustEvent_;
		public unsafe void TrackEvent (global::Com.Adjust.Sdk.AdjustEvent p0)
		{
			if (id_trackEvent_Lcom_adjust_sdk_AdjustEvent_ == IntPtr.Zero)
				id_trackEvent_Lcom_adjust_sdk_AdjustEvent_ = JNIEnv.GetMethodID (class_ref, "trackEvent", "(Lcom/adjust/sdk/AdjustEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackEvent_Lcom_adjust_sdk_AdjustEvent_, __args);
		}

		static Delegate cb_trackMeasurementConsent_Z;
#pragma warning disable 0169
		static Delegate GetTrackMeasurementConsent_ZHandler ()
		{
			if (cb_trackMeasurementConsent_Z == null)
				cb_trackMeasurementConsent_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_TrackMeasurementConsent_Z));
			return cb_trackMeasurementConsent_Z;
		}

		static void n_TrackMeasurementConsent_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackMeasurementConsent (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackMeasurementConsent_Z;
		public unsafe void TrackMeasurementConsent (bool p0)
		{
			if (id_trackMeasurementConsent_Z == IntPtr.Zero)
				id_trackMeasurementConsent_Z = JNIEnv.GetMethodID (class_ref, "trackMeasurementConsent", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackMeasurementConsent_Z, __args);
		}

		static Delegate cb_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_;
#pragma warning disable 0169
		static Delegate GetTrackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Handler ()
		{
			if (cb_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_ == null)
				cb_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_TrackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_));
			return cb_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_;
		}

		static void n_TrackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustPlayStoreSubscription> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackPlayStoreSubscription (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_;
		public unsafe void TrackPlayStoreSubscription (global::Com.Adjust.Sdk.AdjustPlayStoreSubscription p0)
		{
			if (id_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_ == IntPtr.Zero)
				id_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_ = JNIEnv.GetMethodID (class_ref, "trackPlayStoreSubscription", "(Lcom/adjust/sdk/AdjustPlayStoreSubscription;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackPlayStoreSubscription_Lcom_adjust_sdk_AdjustPlayStoreSubscription_, __args);
		}

		static Delegate cb_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_;
#pragma warning disable 0169
		static Delegate GetTrackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_Handler ()
		{
			if (cb_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_ == null)
				cb_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_TrackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_));
			return cb_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_;
		}

		static void n_TrackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustThirdPartySharing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackThirdPartySharing (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_;
		public unsafe void TrackThirdPartySharing (global::Com.Adjust.Sdk.AdjustThirdPartySharing p0)
		{
			if (id_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_ == IntPtr.Zero)
				id_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_ = JNIEnv.GetMethodID (class_ref, "trackThirdPartySharing", "(Lcom/adjust/sdk/AdjustThirdPartySharing;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackThirdPartySharing_Lcom_adjust_sdk_AdjustThirdPartySharing_, __args);
		}

		static Delegate cb_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_;
#pragma warning disable 0169
		static Delegate GetUpdateAttributionI_Lcom_adjust_sdk_AdjustAttribution_Handler ()
		{
			if (cb_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_ == null)
				cb_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_UpdateAttributionI_Lcom_adjust_sdk_AdjustAttribution_));
			return cb_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_;
		}

		static bool n_UpdateAttributionI_Lcom_adjust_sdk_AdjustAttribution_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustAttribution> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateAttributionI (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_;
		public unsafe bool UpdateAttributionI (global::Com.Adjust.Sdk.AdjustAttribution p0)
		{
			if (id_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_ == IntPtr.Zero)
				id_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_ = JNIEnv.GetMethodID (class_ref, "updateAttributionI", "(Lcom/adjust/sdk/AdjustAttribution;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateAttributionI_Lcom_adjust_sdk_AdjustAttribution_, __args);
			return __ret;
		}

		static Delegate cb_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_;
#pragma warning disable 0169
		static Delegate GetVerifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_Handler ()
		{
			if (cb_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ == null)
				cb_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_VerifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_));
			return cb_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_;
		}

		static void n_VerifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IActivityHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustPurchase> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.VerifyPurchase (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_;
		public unsafe void VerifyPurchase (global::Com.Adjust.Sdk.AdjustPurchase p0, global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener p1)
		{
			if (id_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ == IntPtr.Zero)
				id_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ = JNIEnv.GetMethodID (class_ref, "verifyPurchase", "(Lcom/adjust/sdk/AdjustPurchase;Lcom/adjust/sdk/OnPurchaseVerificationFinishedListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verifyPurchase_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_, __args);
		}

	}
}
