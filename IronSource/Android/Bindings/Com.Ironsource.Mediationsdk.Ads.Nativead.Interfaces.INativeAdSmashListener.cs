using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdSmashListener']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListenerInvoker")]
	public partial interface INativeAdSmashListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdSmashListener']/method[@name='onNativeAdClicked' and count(parameter)=0]"
		[Register ("onNativeAdClicked", "()V", "GetOnNativeAdClickedHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdSmashListener']/method[@name='onNativeAdInitFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onNativeAdInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdSmashListener']/method[@name='onNativeAdInitSuccess' and count(parameter)=0]"
		[Register ("onNativeAdInitSuccess", "()V", "GetOnNativeAdInitSuccessHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdInitSuccess ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdSmashListener']/method[@name='onNativeAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onNativeAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnNativeAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdSmashListener']/method[@name='onNativeAdLoaded' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.ads.nativead.AdapterNativeAdData'] and parameter[2][@type='com.ironsource.mediationsdk.adunit.adapter.internal.nativead.AdapterNativeAdViewBinder']]"
		[Register ("onNativeAdLoaded", "(Lcom/ironsource/mediationsdk/ads/nativead/AdapterNativeAdData;Lcom/ironsource/mediationsdk/adunit/adapter/internal/nativead/AdapterNativeAdViewBinder;)V", "GetOnNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdLoaded (global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdSmashListener']/method[@name='onNativeAdShown' and count(parameter)=0]"
		[Register ("onNativeAdShown", "()V", "GetOnNativeAdShownHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListenerInvoker, MatchSolitaire.Android")]
		void OnNativeAdShown ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener", DoNotGenerateAcw=true)]
	internal partial class INativeAdSmashListenerInvoker : global::Java.Lang.Object, INativeAdSmashListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListener", typeof (INativeAdSmashListenerInvoker));

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

		public static INativeAdSmashListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdSmashListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdSmashListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNativeAdClicked;
#pragma warning disable 0169
		static Delegate GetOnNativeAdClickedHandler ()
		{
			if (cb_onNativeAdClicked == null)
				cb_onNativeAdClicked = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnNativeAdClicked));
			return cb_onNativeAdClicked;
		}

		static void n_OnNativeAdClicked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdClicked;
		public unsafe void OnNativeAdClicked ()
		{
			if (id_onNativeAdClicked == IntPtr.Zero)
				id_onNativeAdClicked = JNIEnv.GetMethodID (class_ref, "onNativeAdClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdClicked);
		}

		static Delegate cb_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdInitFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnNativeAdInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onNativeAdInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onNativeAdInitSuccess;
#pragma warning disable 0169
		static Delegate GetOnNativeAdInitSuccessHandler ()
		{
			if (cb_onNativeAdInitSuccess == null)
				cb_onNativeAdInitSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnNativeAdInitSuccess));
			return cb_onNativeAdInitSuccess;
		}

		static void n_OnNativeAdInitSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdInitSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdInitSuccess;
		public unsafe void OnNativeAdInitSuccess ()
		{
			if (id_onNativeAdInitSuccess == IntPtr.Zero)
				id_onNativeAdInitSuccess = JNIEnv.GetMethodID (class_ref, "onNativeAdInitSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdInitSuccess);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_;
#pragma warning disable 0169
		static Delegate GetOnNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_Handler ()
		{
			if (cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ == null)
				cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_));
			return cb_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_;
		}

		static void n_OnNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapterNativeAdData, IntPtr native_nativeAdViewBinder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adapterNativeAdData = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData> (native_adapterNativeAdData, JniHandleOwnership.DoNotTransfer);
			var nativeAdViewBinder = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder> (native_nativeAdViewBinder, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdLoaded (adapterNativeAdData, nativeAdViewBinder);
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_;
		public unsafe void OnNativeAdLoaded (global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder)
		{
			if (id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ == IntPtr.Zero)
				id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_ = JNIEnv.GetMethodID (class_ref, "onNativeAdLoaded", "(Lcom/ironsource/mediationsdk/ads/nativead/AdapterNativeAdData;Lcom/ironsource/mediationsdk/adunit/adapter/internal/nativead/AdapterNativeAdViewBinder;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((adapterNativeAdData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapterNativeAdData).Handle);
			__args [1] = new JValue ((nativeAdViewBinder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nativeAdViewBinder).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdLoaded_Lcom_ironsource_mediationsdk_ads_nativead_AdapterNativeAdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_nativead_AdapterNativeAdViewBinder_, __args);
		}

		static Delegate cb_onNativeAdShown;
#pragma warning disable 0169
		static Delegate GetOnNativeAdShownHandler ()
		{
			if (cb_onNativeAdShown == null)
				cb_onNativeAdShown = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnNativeAdShown));
			return cb_onNativeAdShown;
		}

		static void n_OnNativeAdShown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdShown ();
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdShown;
		public unsafe void OnNativeAdShown ()
		{
			if (id_onNativeAdShown == IntPtr.Zero)
				id_onNativeAdShown = JNIEnv.GetMethodID (class_ref, "onNativeAdShown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdShown);
		}

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener.onNativeAdInitFailed
	public partial class NativeAdInitFailedEventArgs : global::System.EventArgs {
		public NativeAdInitFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.error = error;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener.onNativeAdLoadFailed
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

	// event args for com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdSmashListener.onNativeAdLoaded
	public partial class NativeAdLoadedEventArgs : global::System.EventArgs {
		public NativeAdLoadedEventArgs (global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder)
		{
			this.adapterNativeAdData = adapterNativeAdData;
			this.nativeAdViewBinder = nativeAdViewBinder;
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

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdSmashListenerImplementor")]
	internal sealed partial class INativeAdSmashListenerImplementor : global::Java.Lang.Object, INativeAdSmashListener {

		object sender;

		public unsafe INativeAdSmashListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler OnNativeAdClickedHandler;
		#pragma warning restore 0649

		public void OnNativeAdClicked ()
		{
			var __h = OnNativeAdClickedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<NativeAdInitFailedEventArgs> OnNativeAdInitFailedHandler;
		#pragma warning restore 0649

		public void OnNativeAdInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnNativeAdInitFailedHandler;
			if (__h != null)
				__h (sender, new NativeAdInitFailedEventArgs (error));
		}

		#pragma warning disable 0649
		public EventHandler OnNativeAdInitSuccessHandler;
		#pragma warning restore 0649

		public void OnNativeAdInitSuccess ()
		{
			var __h = OnNativeAdInitSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
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

		public void OnNativeAdLoaded (global::Com.IronSource.MediationSdk.Ads.NativeAd.AdapterNativeAdData adapterNativeAdData, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd.AdapterNativeAdViewBinder nativeAdViewBinder)
		{
			var __h = OnNativeAdLoadedHandler;
			if (__h != null)
				__h (sender, new NativeAdLoadedEventArgs (adapterNativeAdData, nativeAdViewBinder));
		}

		#pragma warning disable 0649
		public EventHandler OnNativeAdShownHandler;
		#pragma warning restore 0649

		public void OnNativeAdShown ()
		{
			var __h = OnNativeAdShownHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (INativeAdSmashListenerImplementor value)
		{
			return value.OnNativeAdClickedHandler == null && value.OnNativeAdInitFailedHandler == null && value.OnNativeAdInitSuccessHandler == null && value.OnNativeAdLoadFailedHandler == null && value.OnNativeAdLoadedHandler == null && value.OnNativeAdShownHandler == null;
		}

	}
}
