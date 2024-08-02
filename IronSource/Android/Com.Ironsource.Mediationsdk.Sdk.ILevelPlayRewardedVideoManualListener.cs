using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoManualListener']"
	[Register ("com/ironsource/mediationsdk/sdk/LevelPlayRewardedVideoManualListener", "", "Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListenerInvoker")]
	public partial interface ILevelPlayRewardedVideoManualListener : global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoManualListener']/method[@name='onAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoManualListener']/method[@name='onAdReady' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdReady", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListenerInvoker, MatchSolitaire.Android")]
		void OnAdReady (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/LevelPlayRewardedVideoManualListener", DoNotGenerateAcw=true)]
	internal partial class ILevelPlayRewardedVideoManualListenerInvoker : global::Java.Lang.Object, ILevelPlayRewardedVideoManualListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/LevelPlayRewardedVideoManualListener", typeof (ILevelPlayRewardedVideoManualListenerInvoker));

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

		public static ILevelPlayRewardedVideoManualListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILevelPlayRewardedVideoManualListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.LevelPlayRewardedVideoManualListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILevelPlayRewardedVideoManualListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdReady (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdReady", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdReady_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Model.Placement> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClicked (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdClicked (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
		{
			if (id_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdClicked", "(Lcom/ironsource/mediationsdk/model/Placement;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdClosed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdClosed", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdOpened (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdOpened (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdOpened", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Model.Placement> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdRewarded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdRewarded (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
		{
			if (id_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdRewarded", "(Lcom/ironsource/mediationsdk/model/Placement;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoManualListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdShowFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
		{
			if (id_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdShowFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

	}
}
