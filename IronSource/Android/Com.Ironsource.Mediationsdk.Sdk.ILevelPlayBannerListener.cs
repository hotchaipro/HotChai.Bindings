using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayBannerListener']"
	[Register ("com/ironsource/mediationsdk/sdk/LevelPlayBannerListener", "", "Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListenerInvoker")]
	public partial interface ILevelPlayBannerListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayBannerListener']/method[@name='onAdClicked' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdClicked", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListenerInvoker, MatchSolitaire.Android")]
		void OnAdClicked (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayBannerListener']/method[@name='onAdLeftApplication' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdLeftApplication", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListenerInvoker, MatchSolitaire.Android")]
		void OnAdLeftApplication (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayBannerListener']/method[@name='onAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayBannerListener']/method[@name='onAdLoaded' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdLoaded", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoaded (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayBannerListener']/method[@name='onAdScreenDismissed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdScreenDismissed", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListenerInvoker, MatchSolitaire.Android")]
		void OnAdScreenDismissed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayBannerListener']/method[@name='onAdScreenPresented' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdScreenPresented", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListenerInvoker, MatchSolitaire.Android")]
		void OnAdScreenPresented (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/LevelPlayBannerListener", DoNotGenerateAcw=true)]
	internal partial class ILevelPlayBannerListenerInvoker : global::Java.Lang.Object, ILevelPlayBannerListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/LevelPlayBannerListener", typeof (ILevelPlayBannerListenerInvoker));

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

		public static ILevelPlayBannerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILevelPlayBannerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.LevelPlayBannerListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILevelPlayBannerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdClicked (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdClicked", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClicked_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLeftApplication (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdLeftApplication (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdLeftApplication", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLeftApplication_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdLoaded (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdLoaded", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoaded_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdScreenDismissed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdScreenDismissed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdScreenDismissed", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdScreenDismissed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

		static Delegate cb_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler ()
		{
			if (cb_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == null)
				cb_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_));
			return cb_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		}

		static void n_OnAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdScreenPresented (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_;
		public unsafe void OnAdScreenPresented (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
		{
			if (id_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ == IntPtr.Zero)
				id_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdScreenPresented", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdScreenPresented_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_, __args);
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayBannerListener.onAdClicked
	//public partial class AdClickedEventArgs : global::System.EventArgs {
	//	public AdClickedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayBannerListener.onAdLeftApplication
	//public partial class AdLeftApplicationEventArgs : global::System.EventArgs {
	//	public AdLeftApplicationEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayBannerListener.onAdLoadFailed
	//public partial class AdLoadFailedEventArgs : global::System.EventArgs {
	//	public AdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

	//	public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayBannerListener.onAdLoaded
	//public partial class AdLoadedEventArgs : global::System.EventArgs {
	//	public AdLoadedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayBannerListener.onAdScreenDismissed
	//public partial class AdScreenDismissedEventArgs : global::System.EventArgs {
	//	public AdScreenDismissedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayBannerListener.onAdScreenPresented
	//public partial class AdScreenPresentedEventArgs : global::System.EventArgs {
	//	public AdScreenPresentedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P0 {
	//		get { return p0; }
	//	}

	//}

	//[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/sdk/LevelPlayBannerListenerImplementor")]
	//internal sealed partial class ILevelPlayBannerListenerImplementor : global::Java.Lang.Object, ILevelPlayBannerListener {

	//	object sender;

	//	public unsafe ILevelPlayBannerListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
	//	{
	//		const string __id = "()V";
	//		if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
	//			return;
	//		var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
	//		SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
	//		JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
	//		this.sender = sender;
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdClickedEventArgs> OnAdClickedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdClicked (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		var __h = OnAdClickedHandler;
	//		if (__h != null)
	//			__h (sender, new AdClickedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdLeftApplicationEventArgs> OnAdLeftApplicationHandler;
	//	#pragma warning restore 0649

	//	public void OnAdLeftApplication (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		var __h = OnAdLeftApplicationHandler;
	//		if (__h != null)
	//			__h (sender, new AdLeftApplicationEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdLoadFailedEventArgs> OnAdLoadFailedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
	//	{
	//		var __h = OnAdLoadFailedHandler;
	//		if (__h != null)
	//			__h (sender, new AdLoadFailedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdLoadedEventArgs> OnAdLoadedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdLoaded (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		var __h = OnAdLoadedHandler;
	//		if (__h != null)
	//			__h (sender, new AdLoadedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdScreenDismissedEventArgs> OnAdScreenDismissedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdScreenDismissed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		var __h = OnAdScreenDismissedHandler;
	//		if (__h != null)
	//			__h (sender, new AdScreenDismissedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdScreenPresentedEventArgs> OnAdScreenPresentedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdScreenPresented (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		var __h = OnAdScreenPresentedHandler;
	//		if (__h != null)
	//			__h (sender, new AdScreenPresentedEventArgs (p0));
	//	}

	//	internal static bool __IsEmpty (ILevelPlayBannerListenerImplementor value)
	//	{
	//		return value.OnAdClickedHandler == null && value.OnAdLeftApplicationHandler == null && value.OnAdLoadFailedHandler == null && value.OnAdLoadedHandler == null && value.OnAdScreenDismissedHandler == null && value.OnAdScreenPresentedHandler == null;
	//	}

	//}
}
