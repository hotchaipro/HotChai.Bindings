using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/interface[@name='InternalNativeAdListener']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/internal/InternalNativeAdListener", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListenerInvoker")]
	public partial interface IInternalNativeAdListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/interface[@name='InternalNativeAdListener']/method[@name='onNativeAdClicked' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onNativeAdClicked", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdClicked (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/interface[@name='InternalNativeAdListener']/method[@name='onNativeAdImpression' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onNativeAdImpression", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdImpression (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/interface[@name='InternalNativeAdListener']/method[@name='onNativeAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onNativeAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/interface[@name='InternalNativeAdListener']/method[@name='onNativeAdLoaded' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo'] and parameter[2][@type='com.ironsource.mediationsdk.ads.nativead.AdapterNativeAdData'] and parameter[3][@type='com.ironsource.mediationsdk.adunit.adapter.internal.nativead.AdapterNativeAdViewBinder']]"
		[Register ("onNativeAdLoaded", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;Lcom/ironsource/mediationsdk/ads/nativead/AdapterNativeAdData;Lcom/ironsource/mediationsdk/adunit/adapter/internal/nativead/AdapterNativeAdViewBinder;)V", "GetOnNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdLoaded (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo, global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/internal/InternalNativeAdListener", DoNotGenerateAcw=true)]
	internal partial class IInternalNativeAdListenerInvoker : global::Java.Lang.Object, IInternalNativeAdListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/internal/InternalNativeAdListener", typeof (IInternalNativeAdListenerInvoker));

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

		public static IInternalNativeAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternalNativeAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.internal.InternalNativeAdListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternalNativeAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdClicked (adInfo);
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnNativeAdClicked (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			if (id_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onNativeAdClicked", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdImpression (adInfo);
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnNativeAdImpression (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			if (id_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onNativeAdImpression", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdImpression_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdLoadFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnNativeAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onNativeAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_;
#pragma warning disable 0169
		static Delegate GetOnNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_Handler ()
		{
			if (cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ == null)
				cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_OnNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_));
			return cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_;
		}

		static void n_OnNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo, IntPtr native_adapterNativeAdData, IntPtr native_nativeAdViewBinder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Internal.IInternalNativeAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			var adapterNativeAdData = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData> (native_adapterNativeAdData, JniHandleOwnership.DoNotTransfer);
			var nativeAdViewBinder = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder> (native_nativeAdViewBinder, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdLoaded (adInfo, adapterNativeAdData, nativeAdViewBinder);
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_;
		public unsafe void OnNativeAdLoaded (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo, global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder)
		{
			if (id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ == IntPtr.Zero)
				id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ = JNIEnv.GetMethodID (class_ref, "onNativeAdLoaded", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;Lcom/ironsource/mediationsdk/ads/nativead/AdapterNativeAdData;Lcom/ironsource/mediationsdk/adunit/adapter/internal/nativead/AdapterNativeAdViewBinder;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
			__args [1] = new JValue ((adapterNativeAdData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapterNativeAdData).Handle);
			__args [2] = new JValue ((nativeAdViewBinder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nativeAdViewBinder).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_, __args);
		}

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.internal.InternalNativeAdListener.onNativeAdClicked
	public partial class NativeAdClickedEventArgs : global::System.EventArgs {
		public NativeAdClickedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo;

		public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo AdInfo {
			get { return adInfo; }
		}

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.internal.InternalNativeAdListener.onNativeAdImpression
	public partial class NativeAdImpressionEventArgs : global::System.EventArgs {
		public NativeAdImpressionEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo;

		public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo AdInfo {
			get { return adInfo; }
		}

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.internal.InternalNativeAdListener.onNativeAdLoadFailed
	public partial class NativeAdLoadFailedEventArgs : global::System.EventArgs {
		public NativeAdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.error = error;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.internal.InternalNativeAdListener.onNativeAdLoaded
	public partial class NativeAdLoadedEventArgs : global::System.EventArgs {
		public NativeAdLoadedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo, global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder)
		{
			this.adInfo = adInfo;
			this.adapterNativeAdData = adapterNativeAdData;
			this.nativeAdViewBinder = nativeAdViewBinder;
		}

		global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo;

		public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo AdInfo {
			get { return adInfo; }
		}

		global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData;

		public global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData AdapterNativeAdData {
			get { return adapterNativeAdData; }
		}

		global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder;

		public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder NativeAdViewBinder {
			get { return nativeAdViewBinder; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/ads/nativead/internal/InternalNativeAdListenerImplementor")]
	internal sealed partial class IInternalNativeAdListenerImplementor : global::Java.Lang.Object, IInternalNativeAdListener {

		object sender;

		public unsafe IInternalNativeAdListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<NativeAdClickedEventArgs> OnNativeAdClickedHandler;
		#pragma warning restore 0649

		public void OnNativeAdClicked (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			var __h = OnNativeAdClickedHandler;
			if (__h != null)
				__h (sender, new NativeAdClickedEventArgs (adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<NativeAdImpressionEventArgs> OnNativeAdImpressionHandler;
		#pragma warning restore 0649

		public void OnNativeAdImpression (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo)
		{
			var __h = OnNativeAdImpressionHandler;
			if (__h != null)
				__h (sender, new NativeAdImpressionEventArgs (adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<NativeAdLoadFailedEventArgs> OnNativeAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnNativeAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnNativeAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new NativeAdLoadFailedEventArgs (error));
		}

		#pragma warning disable 0649
		public EventHandler<NativeAdLoadedEventArgs> OnNativeAdLoadedHandler;
		#pragma warning restore 0649

		public void OnNativeAdLoaded (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo adInfo, global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder)
		{
			var __h = OnNativeAdLoadedHandler;
			if (__h != null)
				__h (sender, new NativeAdLoadedEventArgs (adInfo, adapterNativeAdData, nativeAdViewBinder));
		}

		internal static bool __IsEmpty (IInternalNativeAdListenerImplementor value)
		{
			return value.OnNativeAdClickedHandler == null && value.OnNativeAdImpressionHandler == null && value.OnNativeAdLoadFailedHandler == null && value.OnNativeAdLoadedHandler == null;
		}

	}
}
