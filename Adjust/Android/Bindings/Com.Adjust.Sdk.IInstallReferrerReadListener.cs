using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='InstallReferrerReadListener']"
	[Register ("com/adjust/sdk/InstallReferrerReadListener", "", "Com.Adjust.Sdk.IInstallReferrerReadListenerInvoker")]
	public partial interface IInstallReferrerReadListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='InstallReferrerReadListener']/method[@name='onInstallReferrerRead' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.ReferrerDetails'] and parameter[2][@type='java.lang.String']]"
		[Register ("onInstallReferrerRead", "(Lcom/adjust/sdk/ReferrerDetails;Ljava/lang/String;)V", "GetOnInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_Handler:Com.Adjust.Sdk.IInstallReferrerReadListenerInvoker, MatchBlocks.Android")]
		void OnInstallReferrerRead (global::Com.Adjust.Sdk.ReferrerDetails p0, string p1);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/InstallReferrerReadListener", DoNotGenerateAcw=true)]
	internal partial class IInstallReferrerReadListenerInvoker : global::Java.Lang.Object, IInstallReferrerReadListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/InstallReferrerReadListener", typeof (IInstallReferrerReadListenerInvoker));

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

		public static IInstallReferrerReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInstallReferrerReadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.InstallReferrerReadListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInstallReferrerReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_Handler ()
		{
			if (cb_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ == null)
				cb_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_));
			return cb_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_;
		}

		static void n_OnInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IInstallReferrerReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ReferrerDetails> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInstallReferrerRead (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_;
		public unsafe void OnInstallReferrerRead (global::Com.Adjust.Sdk.ReferrerDetails p0, string p1)
		{
			if (id_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ == IntPtr.Zero)
				id_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInstallReferrerRead", "(Lcom/adjust/sdk/ReferrerDetails;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInstallReferrerRead_Lcom_adjust_sdk_ReferrerDetails_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.adjust.sdk.InstallReferrerReadListener.onInstallReferrerRead
	public partial class InstallReferrerReadEventArgs : global::System.EventArgs {
		public InstallReferrerReadEventArgs (global::Com.Adjust.Sdk.ReferrerDetails p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Adjust.Sdk.ReferrerDetails p0;

		public global::Com.Adjust.Sdk.ReferrerDetails P0 {
			get { return p0; }
		}

		string p1;

		public string P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/InstallReferrerReadListenerImplementor")]
	internal sealed partial class IInstallReferrerReadListenerImplementor : global::Java.Lang.Object, IInstallReferrerReadListener {

		object sender;

		public unsafe IInstallReferrerReadListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<InstallReferrerReadEventArgs> Handler;
		#pragma warning restore 0649

		public void OnInstallReferrerRead (global::Com.Adjust.Sdk.ReferrerDetails p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new InstallReferrerReadEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IInstallReferrerReadListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
