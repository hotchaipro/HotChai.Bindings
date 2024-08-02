using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter']/interface[@name='AdapterDebugInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/AdapterDebugInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.IAdapterDebugInterfaceInvoker")]
	public partial interface IAdapterDebugInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter']/interface[@name='AdapterDebugInterface']/method[@name='setAdapterDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAdapterDebug", "(Z)V", "GetSetAdapterDebug_ZHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.IAdapterDebugInterfaceInvoker, MatchSolitaire.Android")]
		void SetAdapterDebug (bool p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/AdapterDebugInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterDebugInterfaceInvoker : global::Java.Lang.Object, IAdapterDebugInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/AdapterDebugInterface", typeof (IAdapterDebugInterfaceInvoker));

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

		public static IAdapterDebugInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterDebugInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.AdapterDebugInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterDebugInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setAdapterDebug_Z;
#pragma warning disable 0169
		static Delegate GetSetAdapterDebug_ZHandler ()
		{
			if (cb_setAdapterDebug_Z == null)
				cb_setAdapterDebug_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetAdapterDebug_Z));
			return cb_setAdapterDebug_Z;
		}

		static void n_SetAdapterDebug_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.IAdapterDebugInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapterDebug (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAdapterDebug_Z;
		public unsafe void SetAdapterDebug (bool p0)
		{
			if (id_setAdapterDebug_Z == IntPtr.Zero)
				id_setAdapterDebug_Z = JNIEnv.GetMethodID (class_ref, "setAdapterDebug", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdapterDebug_Z, __args);
		}

	}
}
