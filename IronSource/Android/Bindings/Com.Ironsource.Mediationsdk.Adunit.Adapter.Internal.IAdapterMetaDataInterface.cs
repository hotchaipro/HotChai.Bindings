using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterMetaDataInterface']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterMetaDataInterface", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterMetaDataInterfaceInvoker")]
	public partial interface IAdapterMetaDataInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal']/interface[@name='AdapterMetaDataInterface']/method[@name='setMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setMetaData", "(Ljava/lang/String;Ljava/util/List;)V", "GetSetMetaData_Ljava_lang_String_Ljava_util_List_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterMetaDataInterfaceInvoker, MatchSolitaire.Android")]
		void SetMetaData (string p0, global::System.Collections.Generic.IList<string> p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterMetaDataInterface", DoNotGenerateAcw=true)]
	internal partial class IAdapterMetaDataInterfaceInvoker : global::Java.Lang.Object, IAdapterMetaDataInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/AdapterMetaDataInterface", typeof (IAdapterMetaDataInterfaceInvoker));

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

		public static IAdapterMetaDataInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterMetaDataInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.AdapterMetaDataInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterMetaDataInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setMetaData_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMetaData_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_setMetaData_Ljava_lang_String_Ljava_util_List_ == null)
				cb_setMetaData_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SetMetaData_Ljava_lang_String_Ljava_util_List_));
			return cb_setMetaData_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_SetMetaData_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.IAdapterMetaDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMetaData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setMetaData_Ljava_lang_String_Ljava_util_List_;
		public unsafe void SetMetaData (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_setMetaData_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_setMetaData_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setMetaData", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMetaData_Ljava_lang_String_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
