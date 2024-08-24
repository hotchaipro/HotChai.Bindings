using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']"
	[Register ("com/ironsource/mediationsdk/sdk/InterstitialSmashListener", "", "Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker")]
	public partial interface IInterstitialSmashListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdClicked' and count(parameter)=0]"
		[Register ("onInterstitialAdClicked", "()V", "GetOnInterstitialAdClickedHandler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdClosed' and count(parameter)=0]"
		[Register ("onInterstitialAdClosed", "()V", "GetOnInterstitialAdClosedHandler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdClosed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInterstitialAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdOpened' and count(parameter)=0]"
		[Register ("onInterstitialAdOpened", "()V", "GetOnInterstitialAdOpenedHandler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdOpened ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdReady' and count(parameter)=0]"
		[Register ("onInterstitialAdReady", "()V", "GetOnInterstitialAdReadyHandler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdReady ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdShowFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInterstitialAdShowFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdShowSucceeded' and count(parameter)=0]"
		[Register ("onInterstitialAdShowSucceeded", "()V", "GetOnInterstitialAdShowSucceededHandler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdShowSucceeded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialAdVisible' and count(parameter)=0]"
		[Register ("onInterstitialAdVisible", "()V", "GetOnInterstitialAdVisibleHandler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdVisible ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialInitFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInterstitialInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InterstitialSmashListener']/method[@name='onInterstitialInitSuccess' and count(parameter)=0]"
		[Register ("onInterstitialInitSuccess", "()V", "GetOnInterstitialInitSuccessHandler:Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialInitSuccess ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/InterstitialSmashListener", DoNotGenerateAcw=true)]
	internal partial class IInterstitialSmashListenerInvoker : global::Java.Lang.Object, IInterstitialSmashListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/InterstitialSmashListener", typeof (IInterstitialSmashListenerInvoker));

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

		public static IInterstitialSmashListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterstitialSmashListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.InterstitialSmashListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterstitialSmashListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInterstitialAdClicked;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdClickedHandler ()
		{
			if (cb_onInterstitialAdClicked == null)
				cb_onInterstitialAdClicked = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInterstitialAdClicked));
			return cb_onInterstitialAdClicked;
		}

		static void n_OnInterstitialAdClicked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdClicked;
		public unsafe void OnInterstitialAdClicked ()
		{
			if (id_onInterstitialAdClicked == IntPtr.Zero)
				id_onInterstitialAdClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialAdClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdClicked);
		}

		static Delegate cb_onInterstitialAdClosed;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdClosedHandler ()
		{
			if (cb_onInterstitialAdClosed == null)
				cb_onInterstitialAdClosed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInterstitialAdClosed));
			return cb_onInterstitialAdClosed;
		}

		static void n_OnInterstitialAdClosed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdClosed ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdClosed;
		public unsafe void OnInterstitialAdClosed ()
		{
			if (id_onInterstitialAdClosed == IntPtr.Zero)
				id_onInterstitialAdClosed = JNIEnv.GetMethodID (class_ref, "onInterstitialAdClosed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdClosed);
		}

		static Delegate cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdLoadFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInterstitialAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onInterstitialAdOpened;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdOpenedHandler ()
		{
			if (cb_onInterstitialAdOpened == null)
				cb_onInterstitialAdOpened = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInterstitialAdOpened));
			return cb_onInterstitialAdOpened;
		}

		static void n_OnInterstitialAdOpened (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdOpened ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdOpened;
		public unsafe void OnInterstitialAdOpened ()
		{
			if (id_onInterstitialAdOpened == IntPtr.Zero)
				id_onInterstitialAdOpened = JNIEnv.GetMethodID (class_ref, "onInterstitialAdOpened", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdOpened);
		}

		static Delegate cb_onInterstitialAdReady;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdReadyHandler ()
		{
			if (cb_onInterstitialAdReady == null)
				cb_onInterstitialAdReady = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInterstitialAdReady));
			return cb_onInterstitialAdReady;
		}

		static void n_OnInterstitialAdReady (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdReady ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdReady;
		public unsafe void OnInterstitialAdReady ()
		{
			if (id_onInterstitialAdReady == IntPtr.Zero)
				id_onInterstitialAdReady = JNIEnv.GetMethodID (class_ref, "onInterstitialAdReady", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdReady);
		}

		static Delegate cb_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdShowFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInterstitialAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdShowFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onInterstitialAdShowSucceeded;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdShowSucceededHandler ()
		{
			if (cb_onInterstitialAdShowSucceeded == null)
				cb_onInterstitialAdShowSucceeded = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInterstitialAdShowSucceeded));
			return cb_onInterstitialAdShowSucceeded;
		}

		static void n_OnInterstitialAdShowSucceeded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdShowSucceeded ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdShowSucceeded;
		public unsafe void OnInterstitialAdShowSucceeded ()
		{
			if (id_onInterstitialAdShowSucceeded == IntPtr.Zero)
				id_onInterstitialAdShowSucceeded = JNIEnv.GetMethodID (class_ref, "onInterstitialAdShowSucceeded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdShowSucceeded);
		}

		static Delegate cb_onInterstitialAdVisible;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdVisibleHandler ()
		{
			if (cb_onInterstitialAdVisible == null)
				cb_onInterstitialAdVisible = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInterstitialAdVisible));
			return cb_onInterstitialAdVisible;
		}

		static void n_OnInterstitialAdVisible (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdVisible ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdVisible;
		public unsafe void OnInterstitialAdVisible ()
		{
			if (id_onInterstitialAdVisible == IntPtr.Zero)
				id_onInterstitialAdVisible = JNIEnv.GetMethodID (class_ref, "onInterstitialAdVisible", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdVisible);
		}

		static Delegate cb_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialInitFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInterstitialInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInterstitialInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onInterstitialInitSuccess;
#pragma warning disable 0169
		static Delegate GetOnInterstitialInitSuccessHandler ()
		{
			if (cb_onInterstitialInitSuccess == null)
				cb_onInterstitialInitSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInterstitialInitSuccess));
			return cb_onInterstitialInitSuccess;
		}

		static void n_OnInterstitialInitSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInterstitialSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialInitSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialInitSuccess;
		public unsafe void OnInterstitialInitSuccess ()
		{
			if (id_onInterstitialInitSuccess == IntPtr.Zero)
				id_onInterstitialInitSuccess = JNIEnv.GetMethodID (class_ref, "onInterstitialInitSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialInitSuccess);
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.InterstitialSmashListener.onInterstitialAdLoadFailed
	public partial class InterstitialAdLoadFailedEventArgs : global::System.EventArgs {
		public InterstitialAdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.InterstitialSmashListener.onInterstitialAdShowFailed
	public partial class InterstitialAdShowFailedEventArgs : global::System.EventArgs {
		public InterstitialAdShowFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.InterstitialSmashListener.onInterstitialInitFailed
	public partial class InterstitialInitFailedEventArgs : global::System.EventArgs {
		public InterstitialInitFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/sdk/InterstitialSmashListenerImplementor")]
	internal sealed partial class IInterstitialSmashListenerImplementor : global::Java.Lang.Object, IInterstitialSmashListener {

		object sender;

		public unsafe IInterstitialSmashListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler OnInterstitialAdClickedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdClicked ()
		{
			var __h = OnInterstitialAdClickedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnInterstitialAdClosedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdClosed ()
		{
			var __h = OnInterstitialAdClosedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<InterstitialAdLoadFailedEventArgs> OnInterstitialAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnInterstitialAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new InterstitialAdLoadFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnInterstitialAdOpenedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdOpened ()
		{
			var __h = OnInterstitialAdOpenedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnInterstitialAdReadyHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdReady ()
		{
			var __h = OnInterstitialAdReadyHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<InterstitialAdShowFailedEventArgs> OnInterstitialAdShowFailedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnInterstitialAdShowFailedHandler;
			if (__h != null)
				__h (sender, new InterstitialAdShowFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnInterstitialAdShowSucceededHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdShowSucceeded ()
		{
			var __h = OnInterstitialAdShowSucceededHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnInterstitialAdVisibleHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdVisible ()
		{
			var __h = OnInterstitialAdVisibleHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<InterstitialInitFailedEventArgs> OnInterstitialInitFailedHandler;
		#pragma warning restore 0649

		public void OnInterstitialInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnInterstitialInitFailedHandler;
			if (__h != null)
				__h (sender, new InterstitialInitFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnInterstitialInitSuccessHandler;
		#pragma warning restore 0649

		public void OnInterstitialInitSuccess ()
		{
			var __h = OnInterstitialInitSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IInterstitialSmashListenerImplementor value)
		{
			return value.OnInterstitialAdClickedHandler == null && value.OnInterstitialAdClosedHandler == null && value.OnInterstitialAdLoadFailedHandler == null && value.OnInterstitialAdOpenedHandler == null && value.OnInterstitialAdReadyHandler == null && value.OnInterstitialAdShowFailedHandler == null && value.OnInterstitialAdShowSucceededHandler == null && value.OnInterstitialAdVisibleHandler == null && value.OnInterstitialInitFailedHandler == null && value.OnInterstitialInitSuccessHandler == null;
		}

	}
}
