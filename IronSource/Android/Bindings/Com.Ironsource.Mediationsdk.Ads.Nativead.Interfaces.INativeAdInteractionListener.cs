using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdInteractionListener']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdInteractionListener", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInteractionListenerInvoker")]
	public partial interface INativeAdInteractionListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdInteractionListener']/method[@name='onAdClicked' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.ads.nativead.LevelPlayNativeAd'] and parameter[2][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdClicked", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdClicked_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInteractionListenerInvoker, MatchSolitaire.Android")]
		void OnAdClicked (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdInteractionListener']/method[@name='onAdImpression' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.ads.nativead.LevelPlayNativeAd'] and parameter[2][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdImpression", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayNativeAd;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdImpression_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayNativeAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInteractionListenerInvoker, MatchSolitaire.Android")]
		void OnAdImpression (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdInteractionListener", DoNotGenerateAcw=true)]
	internal partial class INativeAdInteractionListenerInvoker : global::Java.Lang.Object, INativeAdInteractionListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdInteractionListener", typeof (INativeAdInteractionListenerInvoker));

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

		public static INativeAdInteractionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdInteractionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdInteractionListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdInteractionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInteractionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInteractionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdInteractionListener.onAdClicked
	public partial class AdClickedEventArgs : global::System.EventArgs {
		public AdClickedEventArgs (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
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

	// event args for com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdInteractionListener.onAdImpression
	public partial class AdImpressionEventArgs : global::System.EventArgs {
		public AdImpressionEventArgs (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
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

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdInteractionListenerImplementor")]
	internal sealed partial class INativeAdInteractionListenerImplementor : global::Java.Lang.Object, INativeAdInteractionListener {

		object sender;

		public unsafe INativeAdInteractionListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<AdClickedEventArgs> OnAdClickedHandler;
		#pragma warning restore 0649

		public void OnAdClicked (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			var __h = OnAdClickedHandler;
			if (__h != null)
				__h (sender, new AdClickedEventArgs (nativeAd, adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<AdImpressionEventArgs> OnAdImpressionHandler;
		#pragma warning restore 0649

		public void OnAdImpression (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayNativeAd nativeAd, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			var __h = OnAdImpressionHandler;
			if (__h != null)
				__h (sender, new AdImpressionEventArgs (nativeAd, adInfo));
		}

		internal static bool __IsEmpty (INativeAdInteractionListenerImplementor value)
		{
			return value.OnAdClickedHandler == null && value.OnAdImpressionHandler == null;
		}

	}
}
