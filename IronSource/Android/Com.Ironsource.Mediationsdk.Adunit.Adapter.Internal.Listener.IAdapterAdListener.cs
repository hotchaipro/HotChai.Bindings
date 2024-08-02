using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal.listener']/interface[@name='AdapterAdListener']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListenerInvoker")]
	public partial interface IAdapterAdListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal.listener']/interface[@name='AdapterAdListener']/method[@name='onAdClicked' and count(parameter)=0]"
		[Register ("onAdClicked", "()V", "GetOnAdClickedHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListenerInvoker, MatchSolitaire.Android")]
		void OnAdClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal.listener']/interface[@name='AdapterAdListener']/method[@name='onAdLoadFailed' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.adunit.adapter.utility.AdapterErrorType'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onAdLoadFailed", "(Lcom/ironsource/mediationsdk/adunit/adapter/utility/AdapterErrorType;ILjava/lang/String;)V", "GetOnAdLoadFailed_Lcom_ironsource_mediationsdk_adunit_adapter_utility_AdapterErrorType_ILjava_lang_String_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoadFailed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdapterErrorType p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal.listener']/interface[@name='AdapterAdListener']/method[@name='onAdLoadSuccess' and count(parameter)=0]"
		[Register ("onAdLoadSuccess", "()V", "GetOnAdLoadSuccessHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoadSuccess ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.internal.listener']/interface[@name='AdapterAdListener']/method[@name='onAdOpened' and count(parameter)=0]"
		[Register ("onAdOpened", "()V", "GetOnAdOpenedHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListenerInvoker, MatchSolitaire.Android")]
		void OnAdOpened ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener", DoNotGenerateAcw=true)]
	internal partial class IAdapterAdListenerInvoker : global::Java.Lang.Object, IAdapterAdListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListener", typeof (IAdapterAdListenerInvoker));

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

		public static IAdapterAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapterAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.internal.listener.AdapterAdListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener.IAdapterAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.ironsource.mediationsdk.adunit.adapter.internal.listener.AdapterAdListener.onAdLoadFailed
	public partial class AdLoadFailedEventArgs : global::System.EventArgs {
		public AdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdapterErrorType p0, int p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdapterErrorType p0;

		public global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdapterErrorType P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

		string p2;

		public string P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/adunit/adapter/internal/listener/AdapterAdListenerImplementor")]
	internal sealed partial class IAdapterAdListenerImplementor : global::Java.Lang.Object, IAdapterAdListener {

		object sender;

		public unsafe IAdapterAdListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler OnAdClickedHandler;
		#pragma warning restore 0649

		public void OnAdClicked ()
		{
			var __h = OnAdClickedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<AdLoadFailedEventArgs> OnAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnAdLoadFailed (global::Com.IronSource.MediationSdk.AdUnit.Adapter.Utility.AdapterErrorType p0, int p1, string p2)
		{
			var __h = OnAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new AdLoadFailedEventArgs (p0, p1, p2));
		}

		#pragma warning disable 0649
		public EventHandler OnAdLoadSuccessHandler;
		#pragma warning restore 0649

		public void OnAdLoadSuccess ()
		{
			var __h = OnAdLoadSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler OnAdOpenedHandler;
		#pragma warning restore 0649

		public void OnAdOpened ()
		{
			var __h = OnAdOpenedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IAdapterAdListenerImplementor value)
		{
			return value.OnAdClickedHandler == null && value.OnAdLoadFailedHandler == null && value.OnAdLoadSuccessHandler == null && value.OnAdOpenedHandler == null;
		}

	}
}
