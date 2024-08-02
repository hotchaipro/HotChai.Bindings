using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdLoadListener']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdLoadListener", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdLoadListenerInvoker")]
	public partial interface INativeAdLoadListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdLoadListener']/method[@name='onAdLoadFailed' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.ads.nativead.LevelPlayNativeAd'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onAdLoadFailed", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnAdLoadFailed_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdLoadListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoadFailed (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdLoadListener']/method[@name='onAdLoaded' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.ads.nativead.LevelPlayNativeAd'] and parameter[2][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdLoaded", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdLoadListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoaded (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdLoadListener", DoNotGenerateAcw=true)]
	internal partial class INativeAdLoadListenerInvoker : global::Java.Lang.Object, INativeAdLoadListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdLoadListener", typeof (INativeAdLoadListenerInvoker));

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

		public static INativeAdLoadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdLoadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdLoadListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdLoadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdLoadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdLoadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdLoadListener.onAdLoadFailed
	public partial class AdLoadFailedEventArgs : global::System.EventArgs {
		public AdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.nativeAd = nativeAd;
			this.error = error;
		}

		global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd;

		public global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd NativeAd {
			get { return nativeAd; }
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdLoadListener.onAdLoaded
	public partial class AdLoadedEventArgs : global::System.EventArgs {
		public AdLoadedEventArgs (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			this.nativeAd = nativeAd;
			this.adInfo = adInfo;
		}

		global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd;

		public global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd NativeAd {
			get { return nativeAd; }
		}

		global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo;

		public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo AdInfo {
			get { return adInfo; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdLoadListenerImplementor")]
	internal sealed partial class INativeAdLoadListenerImplementor : global::Java.Lang.Object, INativeAdLoadListener {

		object sender;

		public unsafe INativeAdLoadListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<AdLoadFailedEventArgs> OnAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnAdLoadFailed (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new AdLoadFailedEventArgs (nativeAd, error));
		}

		#pragma warning disable 0649
		public EventHandler<AdLoadedEventArgs> OnAdLoadedHandler;
		#pragma warning restore 0649

		public void OnAdLoaded (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			var __h = OnAdLoadedHandler;
			if (__h != null)
				__h (sender, new AdLoadedEventArgs (nativeAd, adInfo));
		}

		internal static bool __IsEmpty (INativeAdLoadListenerImplementor value)
		{
			return value.OnAdLoadFailedHandler == null && value.OnAdLoadedHandler == null;
		}

	}
}
