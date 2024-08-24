using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Bidding {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.bidding']/interface[@name='BiddingDataCallback']"
	[Register ("com/ironsource/mediationsdk/bidding/BiddingDataCallback", "", "Com.IronSource.MediationSdk.Bidding.IBiddingDataCallbackInvoker")]
	public partial interface IBiddingDataCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.bidding']/interface[@name='BiddingDataCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.Bidding.IBiddingDataCallbackInvoker, MatchSolitaire.Android")]
		void OnFailure (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.bidding']/interface[@name='BiddingDataCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onSuccess", "(Ljava/util/Map;)V", "GetOnSuccess_Ljava_util_Map_Handler:Com.IronSource.MediationSdk.Bidding.IBiddingDataCallbackInvoker, MatchSolitaire.Android")]
		void OnSuccess (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/bidding/BiddingDataCallback", DoNotGenerateAcw=true)]
	internal partial class IBiddingDataCallbackInvoker : global::Java.Lang.Object, IBiddingDataCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/bidding/BiddingDataCallback", typeof (IBiddingDataCallbackInvoker));

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

		public static IBiddingDataCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiddingDataCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.bidding.BiddingDataCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiddingDataCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnFailure_Ljava_lang_String_));
			return cb_onFailure_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_String_;
		public unsafe void OnFailure (string p0)
		{
			if (id_onFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSuccess_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_util_Map_Handler ()
		{
			if (cb_onSuccess_Ljava_util_Map_ == null)
				cb_onSuccess_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnSuccess_Ljava_util_Map_));
			return cb_onSuccess_Ljava_util_Map_;
		}

		static void n_OnSuccess_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Bidding.IBiddingDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_util_Map_;
		public unsafe void OnSuccess (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_onSuccess_Ljava_util_Map_ == IntPtr.Zero)
				id_onSuccess_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
