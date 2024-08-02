using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.DemandOnly {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']"
	[Register ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyRewardedVideoListener", "", "Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker")]
	public partial interface ISDemandOnlyRewardedVideoListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']/method[@name='onRewardedVideoAdClicked' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoAdClicked", "(Ljava/lang/String;)V", "GetOnRewardedVideoAdClicked_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdClicked (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']/method[@name='onRewardedVideoAdClosed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoAdClosed", "(Ljava/lang/String;)V", "GetOnRewardedVideoAdClosed_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdClosed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']/method[@name='onRewardedVideoAdLoadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onRewardedVideoAdLoadFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']/method[@name='onRewardedVideoAdLoadSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoAdLoadSuccess", "(Ljava/lang/String;)V", "GetOnRewardedVideoAdLoadSuccess_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdLoadSuccess (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']/method[@name='onRewardedVideoAdOpened' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoAdOpened", "(Ljava/lang/String;)V", "GetOnRewardedVideoAdOpened_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdOpened (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']/method[@name='onRewardedVideoAdRewarded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoAdRewarded", "(Ljava/lang/String;)V", "GetOnRewardedVideoAdRewarded_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdRewarded (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyRewardedVideoListener']/method[@name='onRewardedVideoAdShowFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onRewardedVideoAdShowFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedVideoAdShowFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyRewardedVideoListener", DoNotGenerateAcw=true)]
	internal partial class ISDemandOnlyRewardedVideoListenerInvoker : global::Java.Lang.Object, ISDemandOnlyRewardedVideoListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyRewardedVideoListener", typeof (ISDemandOnlyRewardedVideoListenerInvoker));

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

		public static ISDemandOnlyRewardedVideoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISDemandOnlyRewardedVideoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISDemandOnlyRewardedVideoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRewardedVideoAdClicked_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdClicked_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoAdClicked_Ljava_lang_String_ == null)
				cb_onRewardedVideoAdClicked_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoAdClicked_Ljava_lang_String_));
			return cb_onRewardedVideoAdClicked_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoAdClicked_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdClicked_Ljava_lang_String_;
		public unsafe void OnRewardedVideoAdClicked (string p0)
		{
			if (id_onRewardedVideoAdClicked_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoAdClicked_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdClicked", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdClicked_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoAdClosed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdClosed_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoAdClosed_Ljava_lang_String_ == null)
				cb_onRewardedVideoAdClosed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoAdClosed_Ljava_lang_String_));
			return cb_onRewardedVideoAdClosed_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoAdClosed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdClosed_Ljava_lang_String_;
		public unsafe void OnRewardedVideoAdClosed (string p0)
		{
			if (id_onRewardedVideoAdClosed_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoAdClosed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdClosed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdClosed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdLoadFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnRewardedVideoAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
		{
			if (id_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdLoadFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoAdLoadSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdLoadSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoAdLoadSuccess_Ljava_lang_String_ == null)
				cb_onRewardedVideoAdLoadSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoAdLoadSuccess_Ljava_lang_String_));
			return cb_onRewardedVideoAdLoadSuccess_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoAdLoadSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdLoadSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdLoadSuccess_Ljava_lang_String_;
		public unsafe void OnRewardedVideoAdLoadSuccess (string p0)
		{
			if (id_onRewardedVideoAdLoadSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoAdLoadSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdLoadSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdLoadSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoAdOpened_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdOpened_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoAdOpened_Ljava_lang_String_ == null)
				cb_onRewardedVideoAdOpened_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoAdOpened_Ljava_lang_String_));
			return cb_onRewardedVideoAdOpened_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoAdOpened_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdOpened (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdOpened_Ljava_lang_String_;
		public unsafe void OnRewardedVideoAdOpened (string p0)
		{
			if (id_onRewardedVideoAdOpened_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoAdOpened_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdOpened", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdOpened_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoAdRewarded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdRewarded_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoAdRewarded_Ljava_lang_String_ == null)
				cb_onRewardedVideoAdRewarded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedVideoAdRewarded_Ljava_lang_String_));
			return cb_onRewardedVideoAdRewarded_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoAdRewarded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdRewarded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdRewarded_Ljava_lang_String_;
		public unsafe void OnRewardedVideoAdRewarded (string p0)
		{
			if (id_onRewardedVideoAdRewarded_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoAdRewarded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdRewarded", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdRewarded_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoAdShowFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnRewardedVideoAdShowFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
		{
			if (id_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoAdShowFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener.onRewardedVideoAdClicked
	//public partial class RewardedVideoAdClickedEventArgs : global::System.EventArgs {
	//	public RewardedVideoAdClickedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener.onRewardedVideoAdClosed
	//public partial class RewardedVideoAdClosedEventArgs : global::System.EventArgs {
	//	public RewardedVideoAdClosedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener.onRewardedVideoAdLoadFailed
	//public partial class RewardedVideoAdLoadFailedEventArgs : global::System.EventArgs {
	//	public RewardedVideoAdLoadFailedEventArgs (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
	//	{
	//		this.p0 = p0;
	//		this.p1 = p1;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//	global::Com.IronSource.MediationSdk.Logger.IronSourceError p1;

	//	public global::Com.IronSource.MediationSdk.Logger.IronSourceError P1 {
	//		get { return p1; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener.onRewardedVideoAdLoadSuccess
	//public partial class RewardedVideoAdLoadSuccessEventArgs : global::System.EventArgs {
	//	public RewardedVideoAdLoadSuccessEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener.onRewardedVideoAdOpened
	//public partial class RewardedVideoAdOpenedEventArgs : global::System.EventArgs {
	//	public RewardedVideoAdOpenedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener.onRewardedVideoAdRewarded
	//public partial class RewardedVideoAdRewardedEventArgs : global::System.EventArgs {
	//	public RewardedVideoAdRewardedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyRewardedVideoListener.onRewardedVideoAdShowFailed
	//public partial class RewardedVideoAdShowFailedEventArgs : global::System.EventArgs {
	//	public RewardedVideoAdShowFailedEventArgs (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
	//	{
	//		this.p0 = p0;
	//		this.p1 = p1;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//	global::Com.IronSource.MediationSdk.Logger.IronSourceError p1;

	//	public global::Com.IronSource.MediationSdk.Logger.IronSourceError P1 {
	//		get { return p1; }
	//	}

	//}

	//[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/demandOnly/ISDemandOnlyRewardedVideoListenerImplementor")]
	//internal sealed partial class ISDemandOnlyRewardedVideoListenerImplementor : global::Java.Lang.Object, ISDemandOnlyRewardedVideoListener {

	//	object sender;

	//	public unsafe ISDemandOnlyRewardedVideoListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
	//	{
	//		const string __id = "()V";
	//		if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
	//			return;
	//		var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
	//		SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
	//		JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
	//		this.sender = sender;
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<RewardedVideoAdClickedEventArgs> OnRewardedVideoAdClickedHandler;
	//	#pragma warning restore 0649

	//	public void OnRewardedVideoAdClicked (string p0)
	//	{
	//		var __h = OnRewardedVideoAdClickedHandler;
	//		if (__h != null)
	//			__h (sender, new RewardedVideoAdClickedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<RewardedVideoAdClosedEventArgs> OnRewardedVideoAdClosedHandler;
	//	#pragma warning restore 0649

	//	public void OnRewardedVideoAdClosed (string p0)
	//	{
	//		var __h = OnRewardedVideoAdClosedHandler;
	//		if (__h != null)
	//			__h (sender, new RewardedVideoAdClosedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<RewardedVideoAdLoadFailedEventArgs> OnRewardedVideoAdLoadFailedHandler;
	//	#pragma warning restore 0649

	//	public void OnRewardedVideoAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
	//	{
	//		var __h = OnRewardedVideoAdLoadFailedHandler;
	//		if (__h != null)
	//			__h (sender, new RewardedVideoAdLoadFailedEventArgs (p0, p1));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<RewardedVideoAdLoadSuccessEventArgs> OnRewardedVideoAdLoadSuccessHandler;
	//	#pragma warning restore 0649

	//	public void OnRewardedVideoAdLoadSuccess (string p0)
	//	{
	//		var __h = OnRewardedVideoAdLoadSuccessHandler;
	//		if (__h != null)
	//			__h (sender, new RewardedVideoAdLoadSuccessEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<RewardedVideoAdOpenedEventArgs> OnRewardedVideoAdOpenedHandler;
	//	#pragma warning restore 0649

	//	public void OnRewardedVideoAdOpened (string p0)
	//	{
	//		var __h = OnRewardedVideoAdOpenedHandler;
	//		if (__h != null)
	//			__h (sender, new RewardedVideoAdOpenedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<RewardedVideoAdRewardedEventArgs> OnRewardedVideoAdRewardedHandler;
	//	#pragma warning restore 0649

	//	public void OnRewardedVideoAdRewarded (string p0)
	//	{
	//		var __h = OnRewardedVideoAdRewardedHandler;
	//		if (__h != null)
	//			__h (sender, new RewardedVideoAdRewardedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<RewardedVideoAdShowFailedEventArgs> OnRewardedVideoAdShowFailedHandler;
	//	#pragma warning restore 0649

	//	public void OnRewardedVideoAdShowFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
	//	{
	//		var __h = OnRewardedVideoAdShowFailedHandler;
	//		if (__h != null)
	//			__h (sender, new RewardedVideoAdShowFailedEventArgs (p0, p1));
	//	}

	//	internal static bool __IsEmpty (ISDemandOnlyRewardedVideoListenerImplementor value)
	//	{
	//		return value.OnRewardedVideoAdClickedHandler == null && value.OnRewardedVideoAdClosedHandler == null && value.OnRewardedVideoAdLoadFailedHandler == null && value.OnRewardedVideoAdLoadSuccessHandler == null && value.OnRewardedVideoAdOpenedHandler == null && value.OnRewardedVideoAdRewardedHandler == null && value.OnRewardedVideoAdShowFailedHandler == null;
	//	}

	//}
}
