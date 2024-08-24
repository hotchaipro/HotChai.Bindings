using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.DemandOnly {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyBannerListener']"
	[Register ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyBannerListener", "", "Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListenerInvoker")]
	public partial interface ISDemandOnlyBannerListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyBannerListener']/method[@name='onBannerAdClicked' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onBannerAdClicked", "(Ljava/lang/String;)V", "GetOnBannerAdClicked_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdClicked (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyBannerListener']/method[@name='onBannerAdLeftApplication' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onBannerAdLeftApplication", "(Ljava/lang/String;)V", "GetOnBannerAdLeftApplication_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLeftApplication (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyBannerListener']/method[@name='onBannerAdLoadFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onBannerAdLoadFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyBannerListener']/method[@name='onBannerAdLoaded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onBannerAdLoaded", "(Ljava/lang/String;)V", "GetOnBannerAdLoaded_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLoaded (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.demandOnly']/interface[@name='ISDemandOnlyBannerListener']/method[@name='onBannerAdShown' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onBannerAdShown", "(Ljava/lang/String;)V", "GetOnBannerAdShown_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdShown (string p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyBannerListener", DoNotGenerateAcw=true)]
	internal partial class ISDemandOnlyBannerListenerInvoker : global::Java.Lang.Object, ISDemandOnlyBannerListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/demandOnly/ISDemandOnlyBannerListener", typeof (ISDemandOnlyBannerListenerInvoker));

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

		public static ISDemandOnlyBannerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISDemandOnlyBannerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.demandOnly.ISDemandOnlyBannerListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISDemandOnlyBannerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBannerAdClicked_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdClicked_Ljava_lang_String_Handler ()
		{
			if (cb_onBannerAdClicked_Ljava_lang_String_ == null)
				cb_onBannerAdClicked_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdClicked_Ljava_lang_String_));
			return cb_onBannerAdClicked_Ljava_lang_String_;
		}

		static void n_OnBannerAdClicked_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdClicked_Ljava_lang_String_;
		public unsafe void OnBannerAdClicked (string p0)
		{
			if (id_onBannerAdClicked_Ljava_lang_String_ == IntPtr.Zero)
				id_onBannerAdClicked_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onBannerAdClicked", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdClicked_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onBannerAdLeftApplication_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLeftApplication_Ljava_lang_String_Handler ()
		{
			if (cb_onBannerAdLeftApplication_Ljava_lang_String_ == null)
				cb_onBannerAdLeftApplication_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdLeftApplication_Ljava_lang_String_));
			return cb_onBannerAdLeftApplication_Ljava_lang_String_;
		}

		static void n_OnBannerAdLeftApplication_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLeftApplication (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLeftApplication_Ljava_lang_String_;
		public unsafe void OnBannerAdLeftApplication (string p0)
		{
			if (id_onBannerAdLeftApplication_Ljava_lang_String_ == IntPtr.Zero)
				id_onBannerAdLeftApplication_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onBannerAdLeftApplication", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLeftApplication_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLoadFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnBannerAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
		{
			if (id_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onBannerAdLoadFailed", "(Ljava/lang/String;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLoadFailed_Ljava_lang_String_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onBannerAdLoaded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLoaded_Ljava_lang_String_Handler ()
		{
			if (cb_onBannerAdLoaded_Ljava_lang_String_ == null)
				cb_onBannerAdLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdLoaded_Ljava_lang_String_));
			return cb_onBannerAdLoaded_Ljava_lang_String_;
		}

		static void n_OnBannerAdLoaded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLoaded_Ljava_lang_String_;
		public unsafe void OnBannerAdLoaded (string p0)
		{
			if (id_onBannerAdLoaded_Ljava_lang_String_ == IntPtr.Zero)
				id_onBannerAdLoaded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onBannerAdLoaded", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLoaded_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onBannerAdShown_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdShown_Ljava_lang_String_Handler ()
		{
			if (cb_onBannerAdShown_Ljava_lang_String_ == null)
				cb_onBannerAdShown_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdShown_Ljava_lang_String_));
			return cb_onBannerAdShown_Ljava_lang_String_;
		}

		static void n_OnBannerAdShown_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.DemandOnly.ISDemandOnlyBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdShown (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdShown_Ljava_lang_String_;
		public unsafe void OnBannerAdShown (string p0)
		{
			if (id_onBannerAdShown_Ljava_lang_String_ == IntPtr.Zero)
				id_onBannerAdShown_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onBannerAdShown", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdShown_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyBannerListener.onBannerAdClicked
	//public partial class BannerAdClickedEventArgs : global::System.EventArgs {
	//	public BannerAdClickedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyBannerListener.onBannerAdLeftApplication
	//public partial class BannerAdLeftApplicationEventArgs : global::System.EventArgs {
	//	public BannerAdLeftApplicationEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyBannerListener.onBannerAdLoadFailed
	//public partial class BannerAdLoadFailedEventArgs : global::System.EventArgs {
	//	public BannerAdLoadFailedEventArgs (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
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

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyBannerListener.onBannerAdLoaded
	//public partial class BannerAdLoadedEventArgs : global::System.EventArgs {
	//	public BannerAdLoadedEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	// event args for com.ironsource.mediationsdk.demandOnly.ISDemandOnlyBannerListener.onBannerAdShown
	//public partial class BannerAdShownEventArgs : global::System.EventArgs {
	//	public BannerAdShownEventArgs (string p0)
	//	{
	//		this.p0 = p0;
	//	}

	//	string p0;

	//	public string P0 {
	//		get { return p0; }
	//	}

	//}

	//[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/demandOnly/ISDemandOnlyBannerListenerImplementor")]
	//internal sealed partial class ISDemandOnlyBannerListenerImplementor : global::Java.Lang.Object, ISDemandOnlyBannerListener {

	//	object sender;

	//	public unsafe ISDemandOnlyBannerListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
	//	public EventHandler<BannerAdClickedEventArgs> OnBannerAdClickedHandler;
	//	#pragma warning restore 0649

	//	public void OnBannerAdClicked (string p0)
	//	{
	//		var __h = OnBannerAdClickedHandler;
	//		if (__h != null)
	//			__h (sender, new BannerAdClickedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<BannerAdLeftApplicationEventArgs> OnBannerAdLeftApplicationHandler;
	//	#pragma warning restore 0649

	//	public void OnBannerAdLeftApplication (string p0)
	//	{
	//		var __h = OnBannerAdLeftApplicationHandler;
	//		if (__h != null)
	//			__h (sender, new BannerAdLeftApplicationEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<BannerAdLoadFailedEventArgs> OnBannerAdLoadFailedHandler;
	//	#pragma warning restore 0649

	//	public void OnBannerAdLoadFailed (string p0, global::Com.IronSource.MediationSdk.Logger.IronSourceError p1)
	//	{
	//		var __h = OnBannerAdLoadFailedHandler;
	//		if (__h != null)
	//			__h (sender, new BannerAdLoadFailedEventArgs (p0, p1));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<BannerAdLoadedEventArgs> OnBannerAdLoadedHandler;
	//	#pragma warning restore 0649

	//	public void OnBannerAdLoaded (string p0)
	//	{
	//		var __h = OnBannerAdLoadedHandler;
	//		if (__h != null)
	//			__h (sender, new BannerAdLoadedEventArgs (p0));
	//	}

	//	#pragma warning disable 0649
	//	public EventHandler<BannerAdShownEventArgs> OnBannerAdShownHandler;
	//	#pragma warning restore 0649

	//	public void OnBannerAdShown (string p0)
	//	{
	//		var __h = OnBannerAdShownHandler;
	//		if (__h != null)
	//			__h (sender, new BannerAdShownEventArgs (p0));
	//	}

	//	internal static bool __IsEmpty (ISDemandOnlyBannerListenerImplementor value)
	//	{
	//		return value.OnBannerAdClickedHandler == null && value.OnBannerAdLeftApplicationHandler == null && value.OnBannerAdLoadFailedHandler == null && value.OnBannerAdLoadedHandler == null && value.OnBannerAdShownHandler == null;
	//	}

	//}
}
