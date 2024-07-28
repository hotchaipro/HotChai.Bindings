using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Singular.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.singular.sdk']/interface[@name='DeferredDeepLinkHandler']"
	[Register ("com/singular/sdk/DeferredDeepLinkHandler", "", "Com.Singular.Sdk.IDeferredDeepLinkHandlerInvoker")]
	public partial interface IDeferredDeepLinkHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/interface[@name='DeferredDeepLinkHandler']/method[@name='handleLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handleLink", "(Ljava/lang/String;)V", "GetHandleLink_Ljava_lang_String_Handler:Com.Singular.Sdk.IDeferredDeepLinkHandlerInvoker, MatchSolitaire.Android")]
		void HandleLink (string p0);

	}

	[global::Android.Runtime.Register ("com/singular/sdk/DeferredDeepLinkHandler", DoNotGenerateAcw=true)]
	internal partial class IDeferredDeepLinkHandlerInvoker : global::Java.Lang.Object, IDeferredDeepLinkHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/singular/sdk/DeferredDeepLinkHandler", typeof (IDeferredDeepLinkHandlerInvoker));

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

		public static IDeferredDeepLinkHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeferredDeepLinkHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.singular.sdk.DeferredDeepLinkHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeferredDeepLinkHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleLink_Ljava_lang_String_Handler ()
		{
			if (cb_handleLink_Ljava_lang_String_ == null)
				cb_handleLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_HandleLink_Ljava_lang_String_));
			return cb_handleLink_Ljava_lang_String_;
		}

		static void n_HandleLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.IDeferredDeepLinkHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleLink (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleLink_Ljava_lang_String_;
		public unsafe void HandleLink (string p0)
		{
			if (id_handleLink_Ljava_lang_String_ == IntPtr.Zero)
				id_handleLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleLink", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleLink_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
