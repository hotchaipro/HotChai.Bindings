using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.DemandOnly {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyInterstitialListener']"
	[Register ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyInterstitialListener", "", "Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListenerInvoker")]
	public partial interface ISDemandOnlyInterstitialListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyInterstitialListener']/method[@name='onInterstitialAdClicked' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onInterstitialAdClicked", "(Ljava/lang/String;)V", "GetOnInterstitialAdClicked_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdClicked (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyInterstitialListener']/method[@name='onInterstitialAdClosed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onInterstitialAdClosed", "(Ljava/lang/String;)V", "GetOnInterstitialAdClosed_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdClosed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyInterstitialListener']/method[@name='onInterstitialAdLoadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInterstitialAdLoadFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyInterstitialListener']/method[@name='onInterstitialAdOpened' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onInterstitialAdOpened", "(Ljava/lang/String;)V", "GetOnInterstitialAdOpened_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdOpened (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyInterstitialListener']/method[@name='onInterstitialAdReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onInterstitialAdReady", "(Ljava/lang/String;)V", "GetOnInterstitialAdReady_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdReady (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyInterstitialListener']/method[@name='onInterstitialAdShowFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInterstitialAdShowFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdShowFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyInterstitialListener", DoNotGenerateAcw=true)]
	internal partial class ISDemandOnlyInterstitialListenerInvoker : global::Java.Lang.Object, ISDemandOnlyInterstitialListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyInterstitialListener", typeof (ISDemandOnlyInterstitialListenerInvoker));

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

		public static ISDemandOnlyInterstitialListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISDemandOnlyInterstitialListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.demandOnly.ISDemandOnlyInterstitialListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISDemandOnlyInterstitialListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInterstitialAdClicked_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdClicked_Ljava_lang_String_Handler ()
		{
			if (cb_onInterstitialAdClicked_Ljava_lang_String_ == null)
				cb_onInterstitialAdClicked_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdClicked_Ljava_lang_String_));
			return cb_onInterstitialAdClicked_Ljava_lang_String_;
		}

		static void n_OnInterstitialAdClicked_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdClicked_Ljava_lang_String_;
		public unsafe void OnInterstitialAdClicked (string p0)
		{
			if (id_onInterstitialAdClicked_Ljava_lang_String_ == IntPtr.Zero)
				id_onInterstitialAdClicked_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdClicked", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdClicked_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onInterstitialAdClosed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdClosed_Ljava_lang_String_Handler ()
		{
			if (cb_onInterstitialAdClosed_Ljava_lang_String_ == null)
				cb_onInterstitialAdClosed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdClosed_Ljava_lang_String_));
			return cb_onInterstitialAdClosed_Ljava_lang_String_;
		}

		static void n_OnInterstitialAdClosed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdClosed_Ljava_lang_String_;
		public unsafe void OnInterstitialAdClosed (string p0)
		{
			if (id_onInterstitialAdClosed_Ljava_lang_String_ == IntPtr.Zero)
				id_onInterstitialAdClosed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdClosed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdClosed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdLoadFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInterstitialAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
		{
			if (id_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdLoadFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onInterstitialAdOpened_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdOpened_Ljava_lang_String_Handler ()
		{
			if (cb_onInterstitialAdOpened_Ljava_lang_String_ == null)
				cb_onInterstitialAdOpened_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdOpened_Ljava_lang_String_));
			return cb_onInterstitialAdOpened_Ljava_lang_String_;
		}

		static void n_OnInterstitialAdOpened_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdOpened (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdOpened_Ljava_lang_String_;
		public unsafe void OnInterstitialAdOpened (string p0)
		{
			if (id_onInterstitialAdOpened_Ljava_lang_String_ == IntPtr.Zero)
				id_onInterstitialAdOpened_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdOpened", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdOpened_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onInterstitialAdReady_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdReady_Ljava_lang_String_Handler ()
		{
			if (cb_onInterstitialAdReady_Ljava_lang_String_ == null)
				cb_onInterstitialAdReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdReady_Ljava_lang_String_));
			return cb_onInterstitialAdReady_Ljava_lang_String_;
		}

		static void n_OnInterstitialAdReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdReady_Ljava_lang_String_;
		public unsafe void OnInterstitialAdReady (string p0)
		{
			if (id_onInterstitialAdReady_Ljava_lang_String_ == IntPtr.Zero)
				id_onInterstitialAdReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdReady", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdReady_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdShowFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInterstitialAdShowFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
		{
			if (id_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdShowFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdShowFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyInterstitialListener.onInterstitialAdClicked
	//public partial class InterstitialAdClickedEventArgs : global::System.EventArgs {
	//	public InterstitialAdClickedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyInterstitialListener.onInterstitialAdClosed
	//public partial class InterstitialAdClosedEventArgs : global::System.EventArgs {
	//	public InterstitialAdClosedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyInterstitialListener.onInterstitialAdLoadFailed
	//public partial class InterstitialAdLoadFailedEventArgs : global::System.EventArgs {
	//	public InterstitialAdLoadFailedEventArgs (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
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

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyInterstitialListener.onInterstitialAdOpened
	//public partial class InterstitialAdOpenedEventArgs : global::System.EventArgs {
	//	public InterstitialAdOpenedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyInterstitialListener.onInterstitialAdReady
	//public partial class InterstitialAdReadyEventArgs : global::System.EventArgs {
	//	public InterstitialAdReadyEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyInterstitialListener.onInterstitialAdShowFailed
	//public partial class InterstitialAdShowFailedEventArgs : global::System.EventArgs {
	//	public InterstitialAdShowFailedEventArgs (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
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

	//[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/demandOnly/ISDemandOnlyInterstitialListenerImplementor")]
	//internal sealed partial class ISDemandOnlyInterstitialListenerImplementor : global::Java.Lang.Object, ISDemandOnlyInterstitialListener {

	//	object sender;

	//	public unsafe ISDemandOnlyInterstitialListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
	//	public EventHandler<InterstitialAdClickedEventArgs> OnInterstitialAdClickedHandler;
	//	#pragma warning restore 0649

	//	public void OnInterstitialAdClicked (string p0)
	//	{
	//		var __h = OnInterstitialAdClickedHandler;
	//		if (__h != null)
	//			__h (sender, new InterstitialAdClickedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<InterstitialAdClosedEventArgs> OnInterstitialAdClosedHandler;
	//	#pragma warning restore 0649

	//	public void OnInterstitialAdClosed (string p0)
	//	{
	//		var __h = OnInterstitialAdClosedHandler;
	//		if (__h != null)
	//			__h (sender, new InterstitialAdClosedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<InterstitialAdLoadFailedEventArgs> OnInterstitialAdLoadFailedHandler;
	//	#pragma warning restore 0649

	//	public void OnInterstitialAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
	//	{
	//		var __h = OnInterstitialAdLoadFailedHandler;
	//		if (__h != null)
	//			__h (sender, new InterstitialAdLoadFailedEventArgs (p0, p1));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<InterstitialAdOpenedEventArgs> OnInterstitialAdOpenedHandler;
	//	#pragma warning restore 0649

	//	public void OnInterstitialAdOpened (string p0)
	//	{
	//		var __h = OnInterstitialAdOpenedHandler;
	//		if (__h != null)
	//			__h (sender, new InterstitialAdOpenedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<InterstitialAdReadyEventArgs> OnInterstitialAdReadyHandler;
	//	#pragma warning restore 0649

	//	public void OnInterstitialAdReady (string p0)
	//	{
	//		var __h = OnInterstitialAdReadyHandler;
	//		if (__h != null)
	//			__h (sender, new InterstitialAdReadyEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<InterstitialAdShowFailedEventArgs> OnInterstitialAdShowFailedHandler;
	//	#pragma warning restore 0649

	//	public void OnInterstitialAdShowFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
	//	{
	//		var __h = OnInterstitialAdShowFailedHandler;
	//		if (__h != null)
	//			__h (sender, new InterstitialAdShowFailedEventArgs (p0, p1));
	//	}

	//	internal static bool __IsEmpty (ISDemandOnlyInterstitialListenerImplementor value)
	//	{
	//		return value.OnInterstitialAdClickedHandler == null && value.OnInterstitialAdClosedHandler == null && value.OnInterstitialAdLoadFailedHandler == null && value.OnInterstitialAdOpenedHandler == null && value.OnInterstitialAdReadyHandler == null && value.OnInterstitialAdShowFailedHandler == null;
	//	}

	//}
}
