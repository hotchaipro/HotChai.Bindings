using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead']/interface[@name='LevelPlayNativeAdListener']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAdListener", "", "Com.IronSource.MediationSdk.Ads.NativeAd.ILevelPlayNativeAdListenerInvoker")]
	public partial interface ILevelPlayNativeAdListener : global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInteractionListener, global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdLoadListener {
	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAdListener", DoNotGenerateAcw=true)]
	internal partial class ILevelPlayNativeAdListenerInvoker : global::Java.Lang.Object, ILevelPlayNativeAdListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAdListener", typeof (ILevelPlayNativeAdListenerInvoker));

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

		public static ILevelPlayNativeAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILevelPlayNativeAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.LevelPlayNativeAdListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILevelPlayNativeAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nativeAd, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.ILevelPlayNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nativeAd = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd> (native_nativeAd, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClicked (nativeAd, adInfo);
		}
#pragma warning restore 0169

		IntPtr id_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdClicked (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			if (id_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdClicked", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((nativeAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nativeAd).Handle);
			__args [1] = new JValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nativeAd, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.ILevelPlayNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nativeAd = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd> (native_nativeAd, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdImpression (nativeAd, adInfo);
		}
#pragma warning restore 0169

		IntPtr id_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdImpression (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			if (id_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdImpression", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((nativeAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nativeAd).Handle);
			__args [1] = new JValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nativeAd, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.ILevelPlayNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nativeAd = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd> (native_nativeAd, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadFailed (nativeAd, error);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnAdLoadFailed (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onAdLoadFailed", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((nativeAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nativeAd).Handle);
			__args [1] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nativeAd, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.ILevelPlayNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nativeAd = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd> (native_nativeAd, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoaded (nativeAd, adInfo);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdLoaded (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			if (id_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdLoaded", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((nativeAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nativeAd).Handle);
			__args [1] = new JValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

	}
}
