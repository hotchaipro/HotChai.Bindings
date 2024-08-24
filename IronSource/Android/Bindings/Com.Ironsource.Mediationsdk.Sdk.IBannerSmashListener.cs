using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']"
	[Register ("com/ironsource/mediationsdk/sdk/BannerSmashListener", "", "Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker")]
	public partial interface IBannerSmashListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerAdClicked' and count(parameter)=0]"
		[Register ("onBannerAdClicked", "()V", "GetOnBannerAdClickedHandler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerAdLeftApplication' and count(parameter)=0]"
		[Register ("onBannerAdLeftApplication", "()V", "GetOnBannerAdLeftApplicationHandler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLeftApplication ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onBannerAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerAdLoaded' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.widget.FrameLayout.LayoutParams']]"
		[Register ("onBannerAdLoaded", "(Landroid/view/View;Landroid/widget/FrameLayout$LayoutParams;)V", "GetOnBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_Handler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLoaded (global::Android.Views.View p0, global::Android.Widget.FrameLayout.LayoutParams p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerAdScreenDismissed' and count(parameter)=0]"
		[Register ("onBannerAdScreenDismissed", "()V", "GetOnBannerAdScreenDismissedHandler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdScreenDismissed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerAdScreenPresented' and count(parameter)=0]"
		[Register ("onBannerAdScreenPresented", "()V", "GetOnBannerAdScreenPresentedHandler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdScreenPresented ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerAdShown' and count(parameter)=0]"
		[Register ("onBannerAdShown", "()V", "GetOnBannerAdShownHandler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdShown ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerInitFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onBannerInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='BannerSmashListener']/method[@name='onBannerInitSuccess' and count(parameter)=0]"
		[Register ("onBannerInitSuccess", "()V", "GetOnBannerInitSuccessHandler:Com.IronSource.MediationSdk.Sdk.IBannerSmashListenerInvoker, MatchSolitaire.Android")]
		void OnBannerInitSuccess ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/BannerSmashListener", DoNotGenerateAcw=true)]
	internal partial class IBannerSmashListenerInvoker : global::Java.Lang.Object, IBannerSmashListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/BannerSmashListener", typeof (IBannerSmashListenerInvoker));

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

		public static IBannerSmashListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBannerSmashListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.BannerSmashListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBannerSmashListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBannerAdClicked;
#pragma warning disable 0169
		static Delegate GetOnBannerAdClickedHandler ()
		{
			if (cb_onBannerAdClicked == null)
				cb_onBannerAdClicked = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnBannerAdClicked));
			return cb_onBannerAdClicked;
		}

		static void n_OnBannerAdClicked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdClicked;
		public unsafe void OnBannerAdClicked ()
		{
			if (id_onBannerAdClicked == IntPtr.Zero)
				id_onBannerAdClicked = JNIEnv.GetMethodID (class_ref, "onBannerAdClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdClicked);
		}

		static Delegate cb_onBannerAdLeftApplication;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLeftApplicationHandler ()
		{
			if (cb_onBannerAdLeftApplication == null)
				cb_onBannerAdLeftApplication = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnBannerAdLeftApplication));
			return cb_onBannerAdLeftApplication;
		}

		static void n_OnBannerAdLeftApplication (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLeftApplication ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLeftApplication;
		public unsafe void OnBannerAdLeftApplication ()
		{
			if (id_onBannerAdLeftApplication == IntPtr.Zero)
				id_onBannerAdLeftApplication = JNIEnv.GetMethodID (class_ref, "onBannerAdLeftApplication", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLeftApplication);
		}

		static Delegate cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLoadFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnBannerAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onBannerAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_Handler ()
		{
			if (cb_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ == null)
				cb_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_));
			return cb_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_;
		}

		static void n_OnBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_;
		public unsafe void OnBannerAdLoaded (global::Android.Views.View p0, global::Android.Widget.FrameLayout.LayoutParams p1)
		{
			if (id_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ == IntPtr.Zero)
				id_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "onBannerAdLoaded", "(Landroid/view/View;Landroid/widget/FrameLayout$LayoutParams;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLoaded_Landroid_view_View_Landroid_widget_FrameLayout_LayoutParams_, __args);
		}

		static Delegate cb_onBannerAdScreenDismissed;
#pragma warning disable 0169
		static Delegate GetOnBannerAdScreenDismissedHandler ()
		{
			if (cb_onBannerAdScreenDismissed == null)
				cb_onBannerAdScreenDismissed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnBannerAdScreenDismissed));
			return cb_onBannerAdScreenDismissed;
		}

		static void n_OnBannerAdScreenDismissed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdScreenDismissed ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdScreenDismissed;
		public unsafe void OnBannerAdScreenDismissed ()
		{
			if (id_onBannerAdScreenDismissed == IntPtr.Zero)
				id_onBannerAdScreenDismissed = JNIEnv.GetMethodID (class_ref, "onBannerAdScreenDismissed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdScreenDismissed);
		}

		static Delegate cb_onBannerAdScreenPresented;
#pragma warning disable 0169
		static Delegate GetOnBannerAdScreenPresentedHandler ()
		{
			if (cb_onBannerAdScreenPresented == null)
				cb_onBannerAdScreenPresented = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnBannerAdScreenPresented));
			return cb_onBannerAdScreenPresented;
		}

		static void n_OnBannerAdScreenPresented (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdScreenPresented ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdScreenPresented;
		public unsafe void OnBannerAdScreenPresented ()
		{
			if (id_onBannerAdScreenPresented == IntPtr.Zero)
				id_onBannerAdScreenPresented = JNIEnv.GetMethodID (class_ref, "onBannerAdScreenPresented", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdScreenPresented);
		}

		static Delegate cb_onBannerAdShown;
#pragma warning disable 0169
		static Delegate GetOnBannerAdShownHandler ()
		{
			if (cb_onBannerAdShown == null)
				cb_onBannerAdShown = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnBannerAdShown));
			return cb_onBannerAdShown;
		}

		static void n_OnBannerAdShown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdShown ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdShown;
		public unsafe void OnBannerAdShown ()
		{
			if (id_onBannerAdShown == IntPtr.Zero)
				id_onBannerAdShown = JNIEnv.GetMethodID (class_ref, "onBannerAdShown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdShown);
		}

		static Delegate cb_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerInitFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnBannerInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onBannerInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onBannerInitSuccess;
#pragma warning disable 0169
		static Delegate GetOnBannerInitSuccessHandler ()
		{
			if (cb_onBannerInitSuccess == null)
				cb_onBannerInitSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnBannerInitSuccess));
			return cb_onBannerInitSuccess;
		}

		static void n_OnBannerInitSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IBannerSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerInitSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerInitSuccess;
		public unsafe void OnBannerInitSuccess ()
		{
			if (id_onBannerInitSuccess == IntPtr.Zero)
				id_onBannerInitSuccess = JNIEnv.GetMethodID (class_ref, "onBannerInitSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerInitSuccess);
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.BannerSmashListener.onBannerAdLoadFailed
	public partial class BannerAdLoadFailedEventArgs : global::System.EventArgs {
		public BannerAdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.BannerSmashListener.onBannerAdLoaded
	public partial class BannerAdLoadedEventArgs : global::System.EventArgs {
		public BannerAdLoadedEventArgs (global::Android.Views.View p0, global::Android.Widget.FrameLayout.LayoutParams p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Views.View p0;

		public global::Android.Views.View P0 {
			get { return p0; }
		}

		global::Android.Widget.FrameLayout.LayoutParams p1;

		public global::Android.Widget.FrameLayout.LayoutParams P1 {
			get { return p1; }
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.BannerSmashListener.onBannerInitFailed
	public partial class BannerInitFailedEventArgs : global::System.EventArgs {
		public BannerInitFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/sdk/BannerSmashListenerImplementor")]
	internal sealed partial class IBannerSmashListenerImplementor : global::Java.Lang.Object, IBannerSmashListener {

		object sender;

		public unsafe IBannerSmashListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler OnBannerAdClickedHandler;
		#pragma warning restore 0649

		public void OnBannerAdClicked ()
		{
			var __h = OnBannerAdClickedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnBannerAdLeftApplicationHandler;
		#pragma warning restore 0649

		public void OnBannerAdLeftApplication ()
		{
			var __h = OnBannerAdLeftApplicationHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<BannerAdLoadFailedEventArgs> OnBannerAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnBannerAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnBannerAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new BannerAdLoadFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<BannerAdLoadedEventArgs> OnBannerAdLoadedHandler;
		#pragma warning restore 0649

		public void OnBannerAdLoaded (global::Android.Views.View p0, global::Android.Widget.FrameLayout.LayoutParams p1)
		{
			var __h = OnBannerAdLoadedHandler;
			if (__h != null)
				__h (sender, new BannerAdLoadedEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler OnBannerAdScreenDismissedHandler;
		#pragma warning restore 0649

		public void OnBannerAdScreenDismissed ()
		{
			var __h = OnBannerAdScreenDismissedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnBannerAdScreenPresentedHandler;
		#pragma warning restore 0649

		public void OnBannerAdScreenPresented ()
		{
			var __h = OnBannerAdScreenPresentedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnBannerAdShownHandler;
		#pragma warning restore 0649

		public void OnBannerAdShown ()
		{
			var __h = OnBannerAdShownHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<BannerInitFailedEventArgs> OnBannerInitFailedHandler;
		#pragma warning restore 0649

		public void OnBannerInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnBannerInitFailedHandler;
			if (__h != null)
				__h (sender, new BannerInitFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnBannerInitSuccessHandler;
		#pragma warning restore 0649

		public void OnBannerInitSuccess ()
		{
			var __h = OnBannerInitSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IBannerSmashListenerImplementor value)
		{
			return value.OnBannerAdClickedHandler == null && value.OnBannerAdLeftApplicationHandler == null && value.OnBannerAdLoadFailedHandler == null && value.OnBannerAdLoadedHandler == null && value.OnBannerAdScreenDismissedHandler == null && value.OnBannerAdScreenPresentedHandler == null && value.OnBannerAdShownHandler == null && value.OnBannerInitFailedHandler == null && value.OnBannerInitSuccessHandler == null;
		}

	}
}
