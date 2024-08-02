using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBaseInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBaseInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBaseInterfaceInvoker")]
	public partial interface IAdapterBaseInterface : IJavaObject, IJavaPeerable {
		string AdapterVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBaseInterface']/method[@name='getAdapterVersion' and count(parameter)=0]"
			[Register ("getAdapterVersion", "()Ljava/lang/String;", "GetGetAdapterVersionHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBaseInterfaceInvoker, MatchSolitaire.Android")]
			get; 
		}

		string NetworkSDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBaseInterface']/method[@name='getNetworkSDKVersion' and count(parameter)=0]"
			[Register ("getNetworkSDKVersion", "()Ljava/lang/String;", "GetGetNetworkSDKVersionHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBaseInterfaceInvoker, MatchSolitaire.Android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterBaseInterface']/method[@name='init' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdData'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.ironsource.mediationsdk.adunit.adapter.listener.NetworkInitializationListener']]"
		[Register ("init", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/content/Context;Lcom/ironsource/mediationsdk/adunit/adapter/listener/NetworkInitializationListener;)V", "GetInit_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBaseInterfaceInvoker, MatchSolitaire.Android")]
		void Init (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Android.Content.Context p1, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListener p2);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBaseInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterBaseInterfaceInvoker : global::Java.Lang.Object, IAdapterBaseInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterBaseInterface", typeof (IAdapterBaseInterfaceInvoker));

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

		public static IAdapterBaseInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterBaseInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterBaseInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterBaseInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdapterVersion;
#pragma warning disable 0169
		static Delegate GetGetAdapterVersionHandler ()
		{
			if (cb_getAdapterVersion == null)
				cb_getAdapterVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdapterVersion));
			return cb_getAdapterVersion;
		}

		static IntPtr n_GetAdapterVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBaseInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdapterVersion);
		}
#pragma warning restore 0169

		IntPtr id_getAdapterVersion;
		public unsafe string AdapterVersion {
			get {
				if (id_getAdapterVersion == IntPtr.Zero)
					id_getAdapterVersion = JNIEnv.GetMethodID (class_ref, "getAdapterVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapterVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNetworkSDKVersion;
#pragma warning disable 0169
		static Delegate GetGetNetworkSDKVersionHandler ()
		{
			if (cb_getNetworkSDKVersion == null)
				cb_getNetworkSDKVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNetworkSDKVersion));
			return cb_getNetworkSDKVersion;
		}

		static IntPtr n_GetNetworkSDKVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBaseInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkSDKVersion);
		}
#pragma warning restore 0169

		IntPtr id_getNetworkSDKVersion;
		public unsafe string NetworkSDKVersion {
			get {
				if (id_getNetworkSDKVersion == IntPtr.Zero)
					id_getNetworkSDKVersion = JNIEnv.GetMethodID (class_ref, "getNetworkSDKVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkSDKVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_Handler ()
		{
			if (cb_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_ == null)
				cb_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_Init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_));
			return cb_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_;
		}

		static void n_Init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterBaseInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListener)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_;
		public unsafe void Init (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdData p0, global::Android.Content.Context p1, global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListener p2)
		{
			if (id_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_ == IntPtr.Zero)
				id_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdData;Landroid/content/Context;Lcom/ironsource/mediationsdk/adunit/adapter/listener/NetworkInitializationListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdData_Landroid_content_Context_Lcom_ironsource_mediationsdk_adunit_adapter_listener_NetworkInitializationListener_, __args);
		}

	}
}
