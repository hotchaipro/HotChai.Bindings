using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterSettingsInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterSettingsInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterSettingsInterfaceInvoker")]
	public partial interface IAdapterSettingsInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterSettingsInterface']/method[@name='getBannerLoadWhileShowSupportedState' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.model.NetworkSettings']]"
		[Register ("getBannerLoadWhileShowSupportedState", "(Lcom/ironsource/mediationsdk/model/NetworkSettings;)Lcom/ironsource/mediationsdk/LoadWhileShowSupportState;", "GetGetBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterSettingsInterfaceInvoker, MatchSolitaire.Android")]
		global::Com.IronSource.MediationSdk.LoadWhileShowSupportState GetBannerLoadWhileShowSupportedState (global::Com.IronSource.MediationSdk.Model.NetworkSettings p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterSettingsInterface']/method[@name='getLoadWhileShowSupportedState' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.model.NetworkSettings']]"
		[Register ("getLoadWhileShowSupportedState", "(Lcom/ironsource/mediationsdk/model/NetworkSettings;)Lcom/ironsource/mediationsdk/LoadWhileShowSupportState;", "GetGetLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterSettingsInterfaceInvoker, MatchSolitaire.Android")]
		global::Com.IronSource.MediationSdk.LoadWhileShowSupportState GetLoadWhileShowSupportedState (global::Com.IronSource.MediationSdk.Model.NetworkSettings p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterSettingsInterface']/method[@name='isUsingActivityBeforeImpression' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.IronSource.AD_UNIT']]"
		[Register ("isUsingActivityBeforeImpression", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;)Z", "GetIsUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterSettingsInterfaceInvoker, MatchSolitaire.Android")]
		bool IsUsingActivityBeforeImpression (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterSettingsInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterSettingsInterfaceInvoker : global::Java.Lang.Object, IAdapterSettingsInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterSettingsInterface", typeof (IAdapterSettingsInterfaceInvoker));

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

		public static IAdapterSettingsInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterSettingsInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterSettingsInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterSettingsInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_;
#pragma warning disable 0169
		static Delegate GetGetBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_Handler ()
		{
			if (cb_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ == null)
				cb_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_));
			return cb_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_;
		}

		static IntPtr n_GetBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterSettingsInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Model.NetworkSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBannerLoadWhileShowSupportedState (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_;
		public unsafe global::Com.IronSource.MediationSdk.LoadWhileShowSupportState GetBannerLoadWhileShowSupportedState (global::Com.IronSource.MediationSdk.Model.NetworkSettings p0)
		{
			if (id_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ == IntPtr.Zero)
				id_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ = JNIEnv.GetMethodID (class_ref, "getBannerLoadWhileShowSupportedState", "(Lcom/ironsource/mediationsdk/model/NetworkSettings;)Lcom/ironsource/mediationsdk/LoadWhileShowSupportState;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.LoadWhileShowSupportState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBannerLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_;
#pragma warning disable 0169
		static Delegate GetGetLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_Handler ()
		{
			if (cb_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ == null)
				cb_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_));
			return cb_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_;
		}

		static IntPtr n_GetLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterSettingsInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Model.NetworkSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLoadWhileShowSupportedState (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_;
		public unsafe global::Com.IronSource.MediationSdk.LoadWhileShowSupportState GetLoadWhileShowSupportedState (global::Com.IronSource.MediationSdk.Model.NetworkSettings p0)
		{
			if (id_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ == IntPtr.Zero)
				id_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_ = JNIEnv.GetMethodID (class_ref, "getLoadWhileShowSupportedState", "(Lcom/ironsource/mediationsdk/model/NetworkSettings;)Lcom/ironsource/mediationsdk/LoadWhileShowSupportState;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.LoadWhileShowSupportState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoadWhileShowSupportedState_Lcom_ironsource_mediationsdk_model_NetworkSettings_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_;
#pragma warning disable 0169
		static Delegate GetIsUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_Handler ()
		{
			if (cb_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ == null)
				cb_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_));
			return cb_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_;
		}

		static bool n_IsUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterSettingsInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IronSource.AD_UNIT> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsUsingActivityBeforeImpression (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_;
		public unsafe bool IsUsingActivityBeforeImpression (global::Com.IronSource.MediationSdk.IronSource.AD_UNIT p0)
		{
			if (id_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ == IntPtr.Zero)
				id_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_ = JNIEnv.GetMethodID (class_ref, "isUsingActivityBeforeImpression", "(Lcom/ironsource/mediationsdk/IronSource$AD_UNIT;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUsingActivityBeforeImpression_Lcom_ironsource_mediationsdk_IronSource_AD_UNIT_, __args);
			return __ret;
		}

	}
}
