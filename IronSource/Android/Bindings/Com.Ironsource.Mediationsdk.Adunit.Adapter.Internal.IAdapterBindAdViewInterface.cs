using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBindAdViewInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBindAdViewInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBindAdViewInterfaceInvoker")]
	public partial interface IAdapterBindAdViewInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBindAdViewInterface']/method[@name='onAdViewBound' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData']]"
		[Register ("onAdViewBound", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V", "GetOnAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBindAdViewInterfaceInvoker, MatchSolitaire.Android")]
		void OnAdViewBound (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBindAdViewInterface']/method[@name='onAdViewWillBind' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData']]"
		[Register ("onAdViewWillBind", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V", "GetOnAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBindAdViewInterfaceInvoker, MatchSolitaire.Android")]
		void OnAdViewWillBind (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBindAdViewInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterBindAdViewInterfaceInvoker : global::Java.Lang.Object, IAdapterBindAdViewInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBindAdViewInterface", typeof (IAdapterBindAdViewInterfaceInvoker));

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

		public static IAdapterBindAdViewInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterBindAdViewInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterBindAdViewInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterBindAdViewInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
#pragma warning disable 0169
		static Delegate GetOnAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler ()
		{
			if (cb_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == null)
				cb_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_));
			return cb_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		}

		static void n_OnAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBindAdViewInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_adData, JniHandleOwnership.DoNotTransfer);
			__this.OnAdViewBound (adData);
		}
#pragma warning restore 0169

		IntPtr id_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		public unsafe void OnAdViewBound (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData)
		{
			if (id_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == IntPtr.Zero)
				id_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNIEnv.GetMethodID (class_ref, "onAdViewBound", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdViewBound_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_, __args);
		}

		static Delegate cb_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
#pragma warning disable 0169
		static Delegate GetOnAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Handler ()
		{
			if (cb_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == null)
				cb_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_));
			return cb_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		}

		static void n_OnAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBindAdViewInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adData = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_adData, JniHandleOwnership.DoNotTransfer);
			__this.OnAdViewWillBind (adData);
		}
#pragma warning restore 0169

		IntPtr id_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_;
		public unsafe void OnAdViewWillBind (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData adData)
		{
			if (id_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ == IntPtr.Zero)
				id_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_ = JNIEnv.GetMethodID (class_ref, "onAdViewWillBind", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adData).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdViewWillBind_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_, __args);
		}

	}
}
