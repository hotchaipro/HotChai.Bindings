using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']"
	[Register ("com/ironsource/mediationsdk/sdk/RewardedVideoSmashListener", "", "Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker")]
	public partial interface IRewardedVideoSmashListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdClicked' and count(parameter)=0]"
		[Register ("onRewardedVideoAdClicked", "()V", "GetOnRewardedVideoAdClickedHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdClosed' and count(parameter)=0]"
		[Register ("onRewardedVideoAdClosed", "()V", "GetOnRewardedVideoAdClosedHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdClosed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdEnded' and count(parameter)=0]"
		[Register ("onRewardedVideoAdEnded", "()V", "GetOnRewardedVideoAdEndedHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdEnded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdOpened' and count(parameter)=0]"
		[Register ("onRewardedVideoAdOpened", "()V", "GetOnRewardedVideoAdOpenedHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdOpened ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdRewarded' and count(parameter)=0]"
		[Register ("onRewardedVideoAdRewarded", "()V", "GetOnRewardedVideoAdRewardedHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdRewarded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdShowFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onRewardedVideoAdShowFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdStarted' and count(parameter)=0]"
		[Register ("onRewardedVideoAdStarted", "()V", "GetOnRewardedVideoAdStartedHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAdVisible' and count(parameter)=0]"
		[Register ("onRewardedVideoAdVisible", "()V", "GetOnRewardedVideoAdVisibleHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdVisible ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoAvailabilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRewardedVideoAvailabilityChanged", "(Z)V", "GetOnRewardedVideoAvailabilityChanged_ZHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAvailabilityChanged (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoInitFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onRewardedVideoInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoInitSuccess' and count(parameter)=0]"
		[Register ("onRewardedVideoInitSuccess", "()V", "GetOnRewardedVideoInitSuccessHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoInitSuccess ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onRewardedVideoLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='RewardedVideoSmashListener']/method[@name='onRewardedVideoLoadSuccess' and count(parameter)=0]"
		[Register ("onRewardedVideoLoadSuccess", "()V", "GetOnRewardedVideoLoadSuccessHandler:Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoLoadSuccess ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/RewardedVideoSmashListener", DoNotGenerateAcw=true)]
	internal partial class IRewardedVideoSmashListenerInvoker : global::Java.Lang.Object, IRewardedVideoSmashListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/RewardedVideoSmashListener", typeof (IRewardedVideoSmashListenerInvoker));

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

		public static IRewardedVideoSmashListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRewardedVideoSmashListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRewardedVideoSmashListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRewardedVideoAdClicked;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdClickedHandler ()
		{
			if (cb_onRewardedVideoAdClicked == null)
				cb_onRewardedVideoAdClicked = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoAdClicked));
			return cb_onRewardedVideoAdClicked;
		}

		static void n_OnRewardedVideoAdClicked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdClicked;
		public unsafe void OnRewardedVideoAdClicked ()
		{
			if (id_onRewardedVideoAdClicked == IntPtr.Zero)
				id_onRewardedVideoAdClicked = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdClicked);
		}

		static Delegate cb_onRewardedVideoAdClosed;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdClosedHandler ()
		{
			if (cb_onRewardedVideoAdClosed == null)
				cb_onRewardedVideoAdClosed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoAdClosed));
			return cb_onRewardedVideoAdClosed;
		}

		static void n_OnRewardedVideoAdClosed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdClosed ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdClosed;
		public unsafe void OnRewardedVideoAdClosed ()
		{
			if (id_onRewardedVideoAdClosed == IntPtr.Zero)
				id_onRewardedVideoAdClosed = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdClosed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdClosed);
		}

		static Delegate cb_onRewardedVideoAdEnded;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdEndedHandler ()
		{
			if (cb_onRewardedVideoAdEnded == null)
				cb_onRewardedVideoAdEnded = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoAdEnded));
			return cb_onRewardedVideoAdEnded;
		}

		static void n_OnRewardedVideoAdEnded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdEnded ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdEnded;
		public unsafe void OnRewardedVideoAdEnded ()
		{
			if (id_onRewardedVideoAdEnded == IntPtr.Zero)
				id_onRewardedVideoAdEnded = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdEnded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdEnded);
		}

		static Delegate cb_onRewardedVideoAdOpened;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdOpenedHandler ()
		{
			if (cb_onRewardedVideoAdOpened == null)
				cb_onRewardedVideoAdOpened = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoAdOpened));
			return cb_onRewardedVideoAdOpened;
		}

		static void n_OnRewardedVideoAdOpened (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdOpened ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdOpened;
		public unsafe void OnRewardedVideoAdOpened ()
		{
			if (id_onRewardedVideoAdOpened == IntPtr.Zero)
				id_onRewardedVideoAdOpened = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdOpened", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdOpened);
		}

		static Delegate cb_onRewardedVideoAdRewarded;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdRewardedHandler ()
		{
			if (cb_onRewardedVideoAdRewarded == null)
				cb_onRewardedVideoAdRewarded = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoAdRewarded));
			return cb_onRewardedVideoAdRewarded;
		}

		static void n_OnRewardedVideoAdRewarded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdRewarded ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdRewarded;
		public unsafe void OnRewardedVideoAdRewarded ()
		{
			if (id_onRewardedVideoAdRewarded == IntPtr.Zero)
				id_onRewardedVideoAdRewarded = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdRewarded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdRewarded);
		}

		static Delegate cb_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdShowFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnRewardedVideoAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdShowFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdShowFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onRewardedVideoAdStarted;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdStartedHandler ()
		{
			if (cb_onRewardedVideoAdStarted == null)
				cb_onRewardedVideoAdStarted = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoAdStarted));
			return cb_onRewardedVideoAdStarted;
		}

		static void n_OnRewardedVideoAdStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdStarted;
		public unsafe void OnRewardedVideoAdStarted ()
		{
			if (id_onRewardedVideoAdStarted == IntPtr.Zero)
				id_onRewardedVideoAdStarted = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdStarted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdStarted);
		}

		static Delegate cb_onRewardedVideoAdVisible;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdVisibleHandler ()
		{
			if (cb_onRewardedVideoAdVisible == null)
				cb_onRewardedVideoAdVisible = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoAdVisible));
			return cb_onRewardedVideoAdVisible;
		}

		static void n_OnRewardedVideoAdVisible (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdVisible ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdVisible;
		public unsafe void OnRewardedVideoAdVisible ()
		{
			if (id_onRewardedVideoAdVisible == IntPtr.Zero)
				id_onRewardedVideoAdVisible = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdVisible", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdVisible);
		}

		static Delegate cb_onRewardedVideoAvailabilityChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAvailabilityChanged_ZHandler ()
		{
			if (cb_onRewardedVideoAvailabilityChanged_Z == null)
				cb_onRewardedVideoAvailabilityChanged_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_OnRewardedVideoAvailabilityChanged_Z));
			return cb_onRewardedVideoAvailabilityChanged_Z;
		}

		static void n_OnRewardedVideoAvailabilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAvailabilityChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAvailabilityChanged_Z;
		public unsafe void OnRewardedVideoAvailabilityChanged (bool p0)
		{
			if (id_onRewardedVideoAvailabilityChanged_Z == IntPtr.Zero)
				id_onRewardedVideoAvailabilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAvailabilityChanged", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAvailabilityChanged_Z, __args);
		}

		static Delegate cb_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoInitFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnRewardedVideoInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onRewardedVideoInitSuccess;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoInitSuccessHandler ()
		{
			if (cb_onRewardedVideoInitSuccess == null)
				cb_onRewardedVideoInitSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoInitSuccess));
			return cb_onRewardedVideoInitSuccess;
		}

		static void n_OnRewardedVideoInitSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoInitSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoInitSuccess;
		public unsafe void OnRewardedVideoInitSuccess ()
		{
			if (id_onRewardedVideoInitSuccess == IntPtr.Zero)
				id_onRewardedVideoInitSuccess = JNIEnv.GetMethodID (class_ref, "onRewardedVideoInitSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoInitSuccess);
		}

		static Delegate cb_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoLoadFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnRewardedVideoLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			if (id_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onRewardedVideoLoadSuccess;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoLoadSuccessHandler ()
		{
			if (cb_onRewardedVideoLoadSuccess == null)
				cb_onRewardedVideoLoadSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRewardedVideoLoadSuccess));
			return cb_onRewardedVideoLoadSuccess;
		}

		static void n_OnRewardedVideoLoadSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IRewardedVideoSmashListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoLoadSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoLoadSuccess;
		public unsafe void OnRewardedVideoLoadSuccess ()
		{
			if (id_onRewardedVideoLoadSuccess == IntPtr.Zero)
				id_onRewardedVideoLoadSuccess = JNIEnv.GetMethodID (class_ref, "onRewardedVideoLoadSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoLoadSuccess);
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener.onRewardedVideoAdShowFailed
	public partial class RewardedVideoAdShowFailedEventArgs : global::System.EventArgs {
		public RewardedVideoAdShowFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener.onRewardedVideoAvailabilityChanged
	public partial class RewardedVideoAvailabilityChangedEventArgs : global::System.EventArgs {
		public RewardedVideoAvailabilityChangedEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;

		public bool P0 {
			get { return p0; }
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener.onRewardedVideoInitFailed
	public partial class RewardedVideoInitFailedEventArgs : global::System.EventArgs {
		public RewardedVideoInitFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	// event args for com.ironsource.mediationsdk.sdk.RewardedVideoSmashListener.onRewardedVideoLoadFailed
	public partial class RewardedVideoLoadFailedEventArgs : global::System.EventArgs {
		public RewardedVideoLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError p0;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/sdk/RewardedVideoSmashListenerImplementor")]
	internal sealed partial class IRewardedVideoSmashListenerImplementor : global::Java.Lang.Object, IRewardedVideoSmashListener {

		object sender;

		public unsafe IRewardedVideoSmashListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler OnRewardedVideoAdClickedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdClicked ()
		{
			var __h = OnRewardedVideoAdClickedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoAdClosedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdClosed ()
		{
			var __h = OnRewardedVideoAdClosedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoAdEndedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdEnded ()
		{
			var __h = OnRewardedVideoAdEndedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoAdOpenedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdOpened ()
		{
			var __h = OnRewardedVideoAdOpenedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoAdRewardedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdRewarded ()
		{
			var __h = OnRewardedVideoAdRewardedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<RewardedVideoAdShowFailedEventArgs> OnRewardedVideoAdShowFailedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdShowFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnRewardedVideoAdShowFailedHandler;
			if (__h != null)
				__h (sender, new RewardedVideoAdShowFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoAdStartedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdStarted ()
		{
			var __h = OnRewardedVideoAdStartedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoAdVisibleHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAdVisible ()
		{
			var __h = OnRewardedVideoAdVisibleHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<RewardedVideoAvailabilityChangedEventArgs> OnRewardedVideoAvailabilityChangedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoAvailabilityChanged (bool p0)
		{
			var __h = OnRewardedVideoAvailabilityChangedHandler;
			if (__h != null)
				__h (sender, new RewardedVideoAvailabilityChangedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<RewardedVideoInitFailedEventArgs> OnRewardedVideoInitFailedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnRewardedVideoInitFailedHandler;
			if (__h != null)
				__h (sender, new RewardedVideoInitFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoInitSuccessHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoInitSuccess ()
		{
			var __h = OnRewardedVideoInitSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<RewardedVideoLoadFailedEventArgs> OnRewardedVideoLoadFailedHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError p0)
		{
			var __h = OnRewardedVideoLoadFailedHandler;
			if (__h != null)
				__h (sender, new RewardedVideoLoadFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnRewardedVideoLoadSuccessHandler;
		#pragma warning restore 0649

		public void OnRewardedVideoLoadSuccess ()
		{
			var __h = OnRewardedVideoLoadSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IRewardedVideoSmashListenerImplementor value)
		{
			return value.OnRewardedVideoAdClickedHandler == null && value.OnRewardedVideoAdClosedHandler == null && value.OnRewardedVideoAdEndedHandler == null && value.OnRewardedVideoAdOpenedHandler == null && value.OnRewardedVideoAdRewardedHandler == null && value.OnRewardedVideoAdShowFailedHandler == null && value.OnRewardedVideoAdStartedHandler == null && value.OnRewardedVideoAdVisibleHandler == null && value.OnRewardedVideoAvailabilityChangedHandler == null && value.OnRewardedVideoInitFailedHandler == null && value.OnRewardedVideoInitSuccessHandler == null && value.OnRewardedVideoLoadFailedHandler == null && value.OnRewardedVideoLoadSuccessHandler == null;
		}

	}
}
