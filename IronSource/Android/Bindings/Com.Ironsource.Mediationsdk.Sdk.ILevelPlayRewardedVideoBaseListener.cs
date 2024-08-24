using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoBaseListener']"
	[Register ("com/ironsource/mediationsdk/sdk/LevelPlayRewardedVideoBaseListener", "", "Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListenerInvoker")]
	public partial interface ILevelPlayRewardedVideoBaseListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoBaseListener']/method[@name='onAdClicked' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.model.Placement'] and parameter[2][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdClicked", "(Lcom/ironsource/mediationsdk/model/Placement;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdClicked_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListenerInvoker, MatchSolitaire.Android")]
		void OnAdClicked (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoBaseListener']/method[@name='onAdClosed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdClosed", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdClosed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListenerInvoker, MatchSolitaire.Android")]
		void OnAdClosed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoBaseListener']/method[@name='onAdOpened' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdOpened", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdOpened_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListenerInvoker, MatchSolitaire.Android")]
		void OnAdOpened (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoBaseListener']/method[@name='onAdRewarded' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.model.Placement'] and parameter[2][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdRewarded", "(Lcom/ironsource/mediationsdk/model/Placement;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdRewarded_Lcom_ironsource_mediationsdk_model_Placement_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListenerInvoker, MatchSolitaire.Android")]
		void OnAdRewarded (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='LevelPlayRewardedVideoBaseListener']/method[@name='onAdShowFailed' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError'] and parameter[2][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdInfo']]"
		[Register ("onAdShowFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdInfo;)V", "GetOnAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdInfo_Handler:Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListenerInvoker, MatchSolitaire.Android")]
		void OnAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/LevelPlayRewardedVideoBaseListener", DoNotGenerateAcw=true)]
	internal partial class ILevelPlayRewardedVideoBaseListenerInvoker : global::Java.Lang.Object, ILevelPlayRewardedVideoBaseListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/LevelPlayRewardedVideoBaseListener", typeof (ILevelPlayRewardedVideoBaseListenerInvoker));

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

		public static ILevelPlayRewardedVideoBaseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILevelPlayRewardedVideoBaseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.LevelPlayRewardedVideoBaseListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILevelPlayRewardedVideoBaseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.ILevelPlayRewardedVideoBaseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayRewardedVideoBaseListener.onAdClicked
	//public partial class AdClickedEventArgs : global::System.EventArgs {
	//	public AdClickedEventArgs (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
	//	{
	//		this.p0 = p0;
	//		this.p1 = p1;
	//	}

	//	global::Com.IronSource.MediationSdk.Model.Placement p0;

	//	public global::Com.IronSource.MediationSdk.Model.Placement P0 {
	//		get { return p0; }
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P1 {
	//		get { return p1; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayRewardedVideoBaseListener.onAdClosed
	//public partial class AdClosedEventArgs : global::System.EventArgs {
	//	public AdClosedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayRewardedVideoBaseListener.onAdOpened
	//public partial class AdOpenedEventArgs : global::System.EventArgs {
	//	public AdOpenedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayRewardedVideoBaseListener.onAdRewarded
	//public partial class AdRewardedEventArgs : global::System.EventArgs {
	//	public AdRewardedEventArgs (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
	//	{
	//		this.p0 = p0;
	//		this.p1 = p1;
	//	}

	//	global::Com.IronSource.MediationSdk.Model.Placement p0;

	//	public global::Com.IronSource.MediationSdk.Model.Placement P0 {
	//		get { return p0; }
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P1 {
	//		get { return p1; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.sdk.LevelPlayRewardedVideoBaseListener.onAdShowFailed
	//public partial class AdShowFailedEventArgs : global::System.EventArgs {
	//	public AdShowFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
	//	{
	//		this.p0 = p0;
	//		this.p1 = p1;
	//	}

	//	global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

	//	public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
	//		get { return p0; }
	//	}

	//	global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1;

	//	public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo P1 {
	//		get { return p1; }
	//	}

	//}

	//[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/sdk/LevelPlayRewardedVideoBaseListenerImplementor")]
	//internal sealed partial class ILevelPlayRewardedVideoBaseListenerImplementor : global::Java.Lang.Object, ILevelPlayRewardedVideoBaseListener {

	//	object sender;

	//	public unsafe ILevelPlayRewardedVideoBaseListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	//	public void OnAdClicked (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
	//	{
	//		var __h = OnAdClickedHandler;
	//		if (__h != null)
	//			__h (sender, new AdClickedEventArgs (p0, p1));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdClosedEventArgs> OnAdClosedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdClosed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		var __h = OnAdClosedHandler;
	//		if (__h != null)
	//			__h (sender, new AdClosedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdOpenedEventArgs> OnAdOpenedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdOpened (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p0)
	//	{
	//		var __h = OnAdOpenedHandler;
	//		if (__h != null)
	//			__h (sender, new AdOpenedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdRewardedEventArgs> OnAdRewardedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdRewarded (global::Com.IronSource.MediationSdk.Model.Placement p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
	//	{
	//		var __h = OnAdRewardedHandler;
	//		if (__h != null)
	//			__h (sender, new AdRewardedEventArgs (p0, p1));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<AdShowFailedEventArgs> OnAdShowFailedHandler;
	//	#pragma warning restore 0649

	//	public void OnAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdInfo p1)
	//	{
	//		var __h = OnAdShowFailedHandler;
	//		if (__h != null)
	//			__h (sender, new AdShowFailedEventArgs (p0, p1));
	//	}

	//	internal static bool __IsEmpty (ILevelPlayRewardedVideoBaseListenerImplementor value)
	//	{
	//		return value.OnAdClickedHandler == null && value.OnAdClosedHandler == null && value.OnAdOpenedHandler == null && value.OnAdRewardedHandler == null && value.OnAdShowFailedHandler == null;
	//	}

	//}
}
