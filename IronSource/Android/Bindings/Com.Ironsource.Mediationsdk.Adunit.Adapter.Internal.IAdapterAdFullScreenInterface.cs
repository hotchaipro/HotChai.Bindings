using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterAdFullScreenInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterAdFullScreenInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAdFullScreenInterfaceInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Listener extends com.ironsource.mediationsdk.adunit.adapter.internal.listener.AdapterAdListener"})]
	public partial interface IAdapterAdFullScreenInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterAdFullScreenInterface']/method[@name='isAdAvailable' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData']]"
		[Register ("isAdAvailable", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)Z", "GetIsAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAdFullScreenInterfaceInvoker, MatchSolitaire.Android")]
		bool IsAdAvailable (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterAdFullScreenInterface']/method[@name='loadAd' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='Listener']]"
		[Register ("loadAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/app/Activity;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V", "GetLoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAdFullScreenInterfaceInvoker, MatchSolitaire.Android")]
		void LoadAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Android.App.Activity p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterAdFullScreenInterface']/method[@name='showAd' and count(parameter)=2 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData'] and parameter[2][@type='Listener']]"
		[Register ("showAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V", "GetShowAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAdFullScreenInterfaceInvoker, MatchSolitaire.Android")]
		void ShowAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterAdFullScreenInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterAdFullScreenInterfaceInvoker : global::Java.Lang.Object, IAdapterAdFullScreenInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterAdFullScreenInterface", typeof (IAdapterAdFullScreenInterfaceInvoker));

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

		public static IAdapterAdFullScreenInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterAdFullScreenInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterAdFullScreenInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterAdFullScreenInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
#pragma warning disable 0169
		static Delegate GetIsAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler ()
		{
			if (cb_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == null)
				cb_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_IsAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_));
			return cb_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		}

		static bool n_IsAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAdFullScreenInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAdAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		public unsafe bool IsAdAvailable (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0)
		{
			if (id_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == IntPtr.Zero)
				id_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNIEnv.GetMethodID (class_ref, "isAdAvailable", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAdAvailable_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_, __args);
			return __ret;
		}

		static Delegate cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler ()
		{
			if (cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == null)
				cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_LoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_));
			return cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		}

		static void n_LoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAdFullScreenInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		public unsafe void LoadAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Android.App.Activity p1, global::Java.Lang.Object p2)
		{
			if (id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == IntPtr.Zero)
				id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/app/Activity;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V");
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
#pragma warning disable 0169
		static Delegate GetShowAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler ()
		{
			if (cb_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == null)
				cb_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_ShowAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_));
			return cb_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		}

		static void n_ShowAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterAdFullScreenInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowAd (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		public unsafe void ShowAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Java.Lang.Object p1)
		{
			if (id_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == IntPtr.Zero)
				id_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNIEnv.GetMethodID (class_ref, "showAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
