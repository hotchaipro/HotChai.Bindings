using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBannerInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBannerInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBannerInterfaceInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Listener extends com.ironsource.mediationsdk.adunit.adapter.internal.listener.AdapterAdListener"})]
	public partial interface IAdapterBannerInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBannerInterface']/method[@name='destroyAd' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData']]"
		[Register ("destroyAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V", "GetDestroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBannerInterfaceInvoker, MatchSolitaire.Android")]
		void DestroyAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBannerInterface']/method[@name='loadAd' and count(parameter)=4 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='com.ironsource.mediationsdk.ISBannerSize'] and parameter[4][@type='Listener']]"
		[Register ("loadAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/app/Activity;Lcom/ironsource/mediationsdk/ISBannerSize;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V", "GetLoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBannerInterfaceInvoker, MatchSolitaire.Android")]
		void LoadAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Android.App.Activity p1, global::Com.IronSource.MediationSdk.ISBannerSize p2, global::Java.Lang.Object p3);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBannerInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterBannerInterfaceInvoker : global::Java.Lang.Object, IAdapterBannerInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBannerInterface", typeof (IAdapterBannerInterfaceInvoker));

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

		public static IAdapterBannerInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterBannerInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterBannerInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterBannerInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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

		static void n_DestroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBannerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DestroyAd (p0);
		}
#pragma warning restore 0169

		IntPtr id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		public unsafe void DestroyAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0)
		{
			if (id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == IntPtr.Zero)
				id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNIEnv.GetMethodID (class_ref, "destroyAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_, __args);
		}

		static Delegate cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_Handler ()
		{
			if (cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == null)
				cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_LoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_));
			return cb_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		}

		static void n_LoadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBannerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ISBannerSize> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_;
		public unsafe void LoadAd (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Android.App.Activity p1, global::Com.IronSource.MediationSdk.ISBannerSize p2, global::Java.Lang.Object p3)
		{
			if (id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ == IntPtr.Zero)
				id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/app/Activity;Lcom/ironsource/mediationsdk/ISBannerSize;Lcom/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener;)V");
			IntPtr native_p3 = JNIEnv.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_app_Activity_Lcom_ironsource_mediationsdk_ISBannerSize_Lcom_ironsource_mediationsdk_adunit_adapter_internal_listener_AdapterAdListener_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}
}
