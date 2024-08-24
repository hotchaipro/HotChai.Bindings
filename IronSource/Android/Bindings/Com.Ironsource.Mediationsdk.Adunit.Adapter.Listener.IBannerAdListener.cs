using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.listener']/interface[@name='BannerAdListener']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/listener/BannerAdListener", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListenerInvoker")]
	public partial interface IBannerAdListener : global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdViewListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.listener']/interface[@name='BannerAdListener']/method[@name='onAdLoadSuccess' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.widget.FrameLayout.LayoutParams']]"
		[Register ("onAdLoadSuccess", "(Landroid/view/View;Landroid/widget/FrameLayout$LayoutParams;)V", "GetOnAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoadSuccess (global::Android.Views.View p0, global::Android.Widget.FrameLayout.LayoutParams p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/listener/BannerAdListener", DoNotGenerateAcw=true)]
	internal partial class IBannerAdListenerInvoker : global::Java.Lang.Object, IBannerAdListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/listener/BannerAdListener", typeof (IBannerAdListenerInvoker));

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

		public static IBannerAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBannerAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.listener.BannerAdListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBannerAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetOnAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_Handler ()
		{
			if (cb_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ == null)
				cb_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_));
			return cb_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_;
		}

		static void n_OnAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_;
		public unsafe void OnAdLoadSuccess (global::Android.Views.View p0, global::Android.Widget.FrameLayout.LayoutParams p1)
		{
			if (id_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ == IntPtr.Zero)
				id_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "onAdLoadSuccess", "(Landroid/view/View;Landroid/widget/FrameLayout$LayoutParams;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadSuccess_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_, __args);
		}

		static Delegate cb_onAdLeftApplication;
#pragma warning disable 0169
		static Delegate GetOnAdLeftApplicationHandler ()
		{
			if (cb_onAdLeftApplication == null)
				cb_onAdLeftApplication = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdLeftApplication));
			return cb_onAdLeftApplication;
		}

		static void n_OnAdLeftApplication (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLeftApplication ();
		}
#pragma warning restore 0169

		IntPtr id_onAdLeftApplication;
		public unsafe void OnAdLeftApplication ()
		{
			if (id_onAdLeftApplication == IntPtr.Zero)
				id_onAdLeftApplication = JNIEnv.GetMethodID (class_ref, "onAdLeftApplication", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLeftApplication);
		}

		static Delegate cb_onAdScreenDismissed;
#pragma warning disable 0169
		static Delegate GetOnAdScreenDismissedHandler ()
		{
			if (cb_onAdScreenDismissed == null)
				cb_onAdScreenDismissed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdScreenDismissed));
			return cb_onAdScreenDismissed;
		}

		static void n_OnAdScreenDismissed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdScreenDismissed ();
		}
#pragma warning restore 0169

		IntPtr id_onAdScreenDismissed;
		public unsafe void OnAdScreenDismissed ()
		{
			if (id_onAdScreenDismissed == IntPtr.Zero)
				id_onAdScreenDismissed = JNIEnv.GetMethodID (class_ref, "onAdScreenDismissed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdScreenDismissed);
		}

		static Delegate cb_onAdScreenPresented;
#pragma warning disable 0169
		static Delegate GetOnAdScreenPresentedHandler ()
		{
			if (cb_onAdScreenPresented == null)
				cb_onAdScreenPresented = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnAdScreenPresented));
			return cb_onAdScreenPresented;
		}

		static void n_OnAdScreenPresented (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdScreenPresented ();
		}
#pragma warning restore 0169

		IntPtr id_onAdScreenPresented;
		public unsafe void OnAdScreenPresented ()
		{
			if (id_onAdScreenPresented == IntPtr.Zero)
				id_onAdScreenPresented = JNIEnv.GetMethodID (class_ref, "onAdScreenPresented", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdScreenPresented);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
