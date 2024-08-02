using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterConsentInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterConsentInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterConsentInterfaceInvoker")]
	public partial interface IAdapterConsentInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterConsentInterface']/method[@name='setConsent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setConsent", "(Z)V", "GetSetConsent_ZHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterConsentInterfaceInvoker, MatchSolitaire.Android")]
		void SetConsent (bool p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterConsentInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterConsentInterfaceInvoker : global::Java.Lang.Object, IAdapterConsentInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterConsentInterface", typeof (IAdapterConsentInterfaceInvoker));

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

		public static IAdapterConsentInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterConsentInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterConsentInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterConsentInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setConsent_Z;
#pragma warning disable 0169
		static Delegate GetSetConsent_ZHandler ()
		{
			if (cb_setConsent_Z == null)
				cb_setConsent_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetConsent_Z));
			return cb_setConsent_Z;
		}

		static void n_SetConsent_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterConsentInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConsent (p0);
		}
#pragma warning restore 0169

		IntPtr id_setConsent_Z;
		public unsafe void SetConsent (bool p0)
		{
			if (id_setConsent_Z == IntPtr.Zero)
				id_setConsent_Z = JNIEnv.GetMethodID (class_ref, "setConsent", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConsent_Z, __args);
		}

	}
}
