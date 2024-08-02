using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterNetworkDataInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterNetworkDataInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNetworkDataInterfaceInvoker")]
	public partial interface IAdapterNetworkDataInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterNetworkDataInterface']/method[@name='setNetworkData' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.AdapterNetworkData']]"
		[Register ("setNetworkData", "(Lcom/ironsource/mediationsdk/AdapterNetworkData;)V", "GetSetNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNetworkDataInterfaceInvoker, MatchSolitaire.Android")]
		void SetNetworkData (global::Com.IronSource.MediationSdk.IAdapterNetworkData networkData);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterNetworkDataInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterNetworkDataInterfaceInvoker : global::Java.Lang.Object, IAdapterNetworkDataInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterNetworkDataInterface", typeof (IAdapterNetworkDataInterfaceInvoker));

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

		public static IAdapterNetworkDataInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterNetworkDataInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterNetworkDataInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterNetworkDataInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_;
#pragma warning disable 0169
		static Delegate GetSetNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_Handler ()
		{
			if (cb_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_ == null)
				cb_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_));
			return cb_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_;
		}

		static void n_SetNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterNetworkDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var networkData = (global::Com.IronSource.MediationSdk.IAdapterNetworkData)global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.IAdapterNetworkData> (native_networkData, JniHandleOwnership.DoNotTransfer);
			__this.SetNetworkData (networkData);
		}
#pragma warning restore 0169

		IntPtr id_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_;
		public unsafe void SetNetworkData (global::Com.IronSource.MediationSdk.IAdapterNetworkData networkData)
		{
			if (id_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_ == IntPtr.Zero)
				id_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_ = JNIEnv.GetMethodID (class_ref, "setNetworkData", "(Lcom/ironsource/mediationsdk/AdapterNetworkData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((networkData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) networkData).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkData_Lcom_ironsource_mediationsdk_AdapterNetworkData_, __args);
		}

	}
}
