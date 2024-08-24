using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterNativeAdInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterNativeAdInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNativeAdInterfaceInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Listener extends com.ironsource.mediationsdk.adunit.adapter.internal.listener.AdapterAdListener"})]
	public partial interface IAdapterNativeAdInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterNativeAdInterface']/method[@name='destroyAd' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData']]"
		[Register ("destroyAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V", "GetDestroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNativeAdInterfaceInvoker, MatchSolitaire.Android")]
		void DestroyAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterNativeAdInterface']/method[@name='loadAd' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='Listener']]"
		[Register ("loadAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/app/Activity;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V", "GetLoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNativeAdInterfaceInvoker, MatchSolitaire.Android")]
		void LoadAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData, global::Android.App.Activity activity, global::Java.Lang.Object listener);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterNativeAdInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterNativeAdInterfaceInvoker : global::Java.Lang.Object, IAdapterNativeAdInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterNativeAdInterface", typeof (IAdapterNativeAdInterfaceInvoker));

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

		public static IAdapterNativeAdInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterNativeAdInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterNativeAdInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterNativeAdInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
#pragma warning disable 0169
		static Delegate GetDestroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler ()
		{
			if (cb_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == null)
				cb_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_DestroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_));
			return cb_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		}

		static void n_DestroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNativeAdInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_adData, JniHandleOwnership.DoNotTransfer);
			__this.DestroyAd (adData);
		}
#pragma warning restore 0169

		IntPtr id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		public unsafe void DestroyAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData)
		{
			if (id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == IntPtr.Zero)
				id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNIEnv.GetMethodID (class_ref, "destroyAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_, __args);
		}

		static Delegate cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler ()
		{
			if (cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == null)
				cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_LoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_));
			return cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		}

		static void n_LoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adData, IntPtr native_activity, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNativeAdInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_adData, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var listener = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd (adData, activity, listener);
		}
#pragma warning restore 0169

		IntPtr id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		public unsafe void LoadAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData, global::Android.App.Activity activity, global::Java.Lang.Object listener)
		{
			if (id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == IntPtr.Zero)
				id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/app/Activity;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V");
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			__args [1] = new JValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
			__args [2] = new JValue (native_listener);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_, __args);
			JNIEnv.DeleteLocalRef (native_listener);
		}

	}
}
