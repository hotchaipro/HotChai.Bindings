using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal.listener']/interface[@name='AdapterAdRewardListener']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdRewardListener", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListenerInvoker")]
	public partial interface IAdapterAdRewardListener : global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdInteractionListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal.listener']/interface[@name='AdapterAdRewardListener']/method[@name='onAdRewarded' and count(parameter)=0]"
		[Register ("onAdRewarded", "()V", "GetOnAdRewardedHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListenerInvoker, MatchSolitaire.Android")]
		void OnAdRewarded ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdRewardListener", DoNotGenerateAcw=true)]
	internal partial class IAdapterAdRewardListenerInvoker : global::Java.Lang.Object, IAdapterAdRewardListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdRewardListener", typeof (IAdapterAdRewardListenerInvoker));

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

		public static IAdapterAdRewardListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterAdRewardListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.listener.AdapterAdRewardListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterAdRewardListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdRewarded;
#pragma warning disable 0169
		static Delegate GetOnAdRewardedHandler ()
		{
			if (cb_onAdRewarded == null)
				cb_onAdRewarded = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdRewarded));
			return cb_onAdRewarded;
		}

		static void n_OnAdRewarded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdRewarded ();
		}
#pragma warning restore 0169

		IntPtr id_onAdRewarded;
		public unsafe void OnAdRewarded ()
		{
			if (id_onAdRewarded == IntPtr.Zero)
				id_onAdRewarded = JNIEnv.GetMethodID (class_ref, "onAdRewarded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdRewarded);
		}

		static Delegate cb_onAdClosed;
#pragma warning disable 0169
		static Delegate GetOnAdClosedHandler ()
		{
			if (cb_onAdClosed == null)
				cb_onAdClosed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdClosed));
			return cb_onAdClosed;
		}

		static void n_OnAdClosed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClosed ();
		}
#pragma warning restore 0169

		IntPtr id_onAdClosed;
		public unsafe void OnAdClosed ()
		{
			if (id_onAdClosed == IntPtr.Zero)
				id_onAdClosed = JNIEnv.GetMethodID (class_ref, "onAdClosed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClosed);
		}

		static Delegate cb_onAdEnded;
#pragma warning disable 0169
		static Delegate GetOnAdEndedHandler ()
		{
			if (cb_onAdEnded == null)
				cb_onAdEnded = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdEnded));
			return cb_onAdEnded;
		}

		static void n_OnAdEnded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdEnded ();
		}
#pragma warning restore 0169

		IntPtr id_onAdEnded;
		public unsafe void OnAdEnded ()
		{
			if (id_onAdEnded == IntPtr.Zero)
				id_onAdEnded = JNIEnv.GetMethodID (class_ref, "onAdEnded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdEnded);
		}

		static Delegate cb_onAdShowFailed_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdShowFailed_ILjava_lang_String_Handler ()
		{
			if (cb_onAdShowFailed_ILjava_lang_String_ == null)
				cb_onAdShowFailed_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnAdShowFailed_ILjava_lang_String_));
			return cb_onAdShowFailed_ILjava_lang_String_;
		}

		static void n_OnAdShowFailed_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdShowFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdShowFailed_ILjava_lang_String_;
		public unsafe void OnAdShowFailed (int p0, string p1)
		{
			if (id_onAdShowFailed_ILjava_lang_String_ == IntPtr.Zero)
				id_onAdShowFailed_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdShowFailed", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdShowFailed_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onAdShowSuccess;
#pragma warning disable 0169
		static Delegate GetOnAdShowSuccessHandler ()
		{
			if (cb_onAdShowSuccess == null)
				cb_onAdShowSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdShowSuccess));
			return cb_onAdShowSuccess;
		}

		static void n_OnAdShowSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdShowSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onAdShowSuccess;
		public unsafe void OnAdShowSuccess ()
		{
			if (id_onAdShowSuccess == IntPtr.Zero)
				id_onAdShowSuccess = JNIEnv.GetMethodID (class_ref, "onAdShowSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdShowSuccess);
		}

		static Delegate cb_onAdStarted;
#pragma warning disable 0169
		static Delegate GetOnAdStartedHandler ()
		{
			if (cb_onAdStarted == null)
				cb_onAdStarted = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdStarted));
			return cb_onAdStarted;
		}

		static void n_OnAdStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onAdStarted;
		public unsafe void OnAdStarted ()
		{
			if (id_onAdStarted == IntPtr.Zero)
				id_onAdStarted = JNIEnv.GetMethodID (class_ref, "onAdStarted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdStarted);
		}

		static Delegate cb_onAdVisible;
#pragma warning disable 0169
		static Delegate GetOnAdVisibleHandler ()
		{
			if (cb_onAdVisible == null)
				cb_onAdVisible = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdVisible));
			return cb_onAdVisible;
		}

		static void n_OnAdVisible (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdVisible ();
		}
#pragma warning restore 0169

		IntPtr id_onAdVisible;
		public unsafe void OnAdVisible ()
		{
			if (id_onAdVisible == IntPtr.Zero)
				id_onAdVisible = JNIEnv.GetMethodID (class_ref, "onAdVisible", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdVisible);
		}

		static Delegate cb_onAdClicked;
#pragma warning disable 0169
		static Delegate GetOnAdClickedHandler ()
		{
			if (cb_onAdClicked == null)
				cb_onAdClicked = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdClicked));
			return cb_onAdClicked;
		}

		static void n_OnAdClicked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onAdClicked;
		public unsafe void OnAdClicked ()
		{
			if (id_onAdClicked == IntPtr.Zero)
				id_onAdClicked = JNIEnv.GetMethodID (class_ref, "onAdClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClicked);
		}

		static Delegate cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_Handler ()
		{
			if (cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_ == null)
				cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_V (n_OnAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_));
			return cb_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_;
		}

		static void n_OnAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdapterErrorType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadFailed (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_;
		public unsafe void OnAdLoadFailed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdapterErrorType p0, int p1, string p2)
		{
			if (id_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_ == IntPtr.Zero)
				id_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdLoadFailed", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdapterErrorType;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onAdLoadSuccess;
#pragma warning disable 0169
		static Delegate GetOnAdLoadSuccessHandler ()
		{
			if (cb_onAdLoadSuccess == null)
				cb_onAdLoadSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdLoadSuccess));
			return cb_onAdLoadSuccess;
		}

		static void n_OnAdLoadSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onAdLoadSuccess;
		public unsafe void OnAdLoadSuccess ()
		{
			if (id_onAdLoadSuccess == IntPtr.Zero)
				id_onAdLoadSuccess = JNIEnv.GetMethodID (class_ref, "onAdLoadSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadSuccess);
		}

		static Delegate cb_onAdOpened;
#pragma warning disable 0169
		static Delegate GetOnAdOpenedHandler ()
		{
			if (cb_onAdOpened == null)
				cb_onAdOpened = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdOpened));
			return cb_onAdOpened;
		}

		static void n_OnAdOpened (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdRewardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdOpened ();
		}
#pragma warning restore 0169

		IntPtr id_onAdOpened;
		public unsafe void OnAdOpened ()
		{
			if (id_onAdOpened == IntPtr.Zero)
				id_onAdOpened = JNIEnv.GetMethodID (class_ref, "onAdOpened", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdOpened);
		}

	}
}
