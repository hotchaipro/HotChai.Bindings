using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Singular.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.singular.sdk']/interface[@name='SingularLinkHandler']"
	[Register ("com/singular/sdk/SingularLinkHandler", "", "Com.Singular.Sdk.ISingularLinkHandlerInvoker")]
	public partial interface ISingularLinkHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/interface[@name='SingularLinkHandler']/method[@name='onResolved' and count(parameter)=1 and parameter[1][@type='com.singular.sdk.SingularLinkParams']]"
		[Register ("onResolved", "(Lcom/singular/sdk/SingularLinkParams;)V", "GetOnResolved_Lcom_singular_sdk_SingularLinkParams_Handler:Com.Singular.Sdk.ISingularLinkHandlerInvoker, MatchSolitaire.Android")]
		void OnResolved (global::Com.Singular.Sdk.SingularLinkParams p0);

	}

	[global::Android.Runtime.Register ("com/singular/sdk/SingularLinkHandler", DoNotGenerateAcw=true)]
	internal partial class ISingularLinkHandlerInvoker : global::Java.Lang.Object, ISingularLinkHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/singular/sdk/SingularLinkHandler", typeof (ISingularLinkHandlerInvoker));

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

		public static ISingularLinkHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISingularLinkHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.singular.sdk.SingularLinkHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISingularLinkHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResolved_Lcom_singular_sdk_SingularLinkParams_;
#pragma warning disable 0169
		static Delegate GetOnResolved_Lcom_singular_sdk_SingularLinkParams_Handler ()
		{
			if (cb_onResolved_Lcom_singular_sdk_SingularLinkParams_ == null)
				cb_onResolved_Lcom_singular_sdk_SingularLinkParams_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnResolved_Lcom_singular_sdk_SingularLinkParams_));
			return cb_onResolved_Lcom_singular_sdk_SingularLinkParams_;
		}

		static void n_OnResolved_Lcom_singular_sdk_SingularLinkParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.ISingularLinkHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularLinkParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResolved (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResolved_Lcom_singular_sdk_SingularLinkParams_;
		public unsafe void OnResolved (global::Com.Singular.Sdk.SingularLinkParams p0)
		{
			if (id_onResolved_Lcom_singular_sdk_SingularLinkParams_ == IntPtr.Zero)
				id_onResolved_Lcom_singular_sdk_SingularLinkParams_ = JNIEnv.GetMethodID (class_ref, "onResolved", "(Lcom/singular/sdk/SingularLinkParams;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResolved_Lcom_singular_sdk_SingularLinkParams_, __args);
		}

	}
}
