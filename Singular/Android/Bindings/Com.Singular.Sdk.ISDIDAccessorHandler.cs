using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Singular.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.singular.sdk']/interface[@name='SDIDAccessorHandler']"
	[Register ("com/singular/sdk/SDIDAccessorHandler", "", "Com.Singular.Sdk.ISDIDAccessorHandlerInvoker")]
	public partial interface ISDIDAccessorHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/interface[@name='SDIDAccessorHandler']/method[@name='didSetSdid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("didSetSdid", "(Ljava/lang/String;)V", "GetDidSetSdid_Ljava_lang_String_Handler:Com.Singular.Sdk.ISDIDAccessorHandlerInvoker, MatchSolitaire.Android")]
		void DidSetSdid (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/interface[@name='SDIDAccessorHandler']/method[@name='sdidReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sdidReceived", "(Ljava/lang/String;)V", "GetSdidReceived_Ljava_lang_String_Handler:Com.Singular.Sdk.ISDIDAccessorHandlerInvoker, MatchSolitaire.Android")]
		void SdidReceived (string p0);

	}

	[global::Android.Runtime.Register ("com/singular/sdk/SDIDAccessorHandler", DoNotGenerateAcw=true)]
	internal partial class ISDIDAccessorHandlerInvoker : global::Java.Lang.Object, ISDIDAccessorHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/singular/sdk/SDIDAccessorHandler", typeof (ISDIDAccessorHandlerInvoker));

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

		public static ISDIDAccessorHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISDIDAccessorHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.singular.sdk.SDIDAccessorHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISDIDAccessorHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_didSetSdid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDidSetSdid_Ljava_lang_String_Handler ()
		{
			if (cb_didSetSdid_Ljava_lang_String_ == null)
				cb_didSetSdid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_DidSetSdid_Ljava_lang_String_));
			return cb_didSetSdid_Ljava_lang_String_;
		}

		static void n_DidSetSdid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.ISDIDAccessorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidSetSdid (p0);
		}
#pragma warning restore 0169

		IntPtr id_didSetSdid_Ljava_lang_String_;
		public unsafe void DidSetSdid (string p0)
		{
			if (id_didSetSdid_Ljava_lang_String_ == IntPtr.Zero)
				id_didSetSdid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "didSetSdid", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didSetSdid_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sdidReceived_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSdidReceived_Ljava_lang_String_Handler ()
		{
			if (cb_sdidReceived_Ljava_lang_String_ == null)
				cb_sdidReceived_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SdidReceived_Ljava_lang_String_));
			return cb_sdidReceived_Ljava_lang_String_;
		}

		static void n_SdidReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.ISDIDAccessorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SdidReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_sdidReceived_Ljava_lang_String_;
		public unsafe void SdidReceived (string p0)
		{
			if (id_sdidReceived_Ljava_lang_String_ == IntPtr.Zero)
				id_sdidReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sdidReceived", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sdidReceived_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
