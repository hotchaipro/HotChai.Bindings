using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.AdUnit.Adapter.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.listener']/interface[@name='NetworkInitializationListener']"
	[Register ("com/ironsource/mediationsdk/adunit/adapter/listener/NetworkInitializationListener", "", "Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListenerInvoker")]
	public partial interface INetworkInitializationListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.listener']/interface[@name='NetworkInitializationListener']/method[@name='onInitFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onInitFailed", "(ILjava/lang/String;)V", "GetOnInitFailed_ILjava_lang_String_Handler:Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListenerInvoker, MatchSolitaire.Android")]
		void OnInitFailed (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.adunit.adapter.listener']/interface[@name='NetworkInitializationListener']/method[@name='onInitSuccess' and count(parameter)=0]"
		[Register ("onInitSuccess", "()V", "GetOnInitSuccessHandler:Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListenerInvoker, MatchSolitaire.Android")]
		void OnInitSuccess ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/adunit/adapter/listener/NetworkInitializationListener", DoNotGenerateAcw=true)]
	internal partial class INetworkInitializationListenerInvoker : global::Java.Lang.Object, INetworkInitializationListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/adunit/adapter/listener/NetworkInitializationListener", typeof (INetworkInitializationListenerInvoker));

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

		public static INetworkInitializationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkInitializationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.adunit.adapter.listener.NetworkInitializationListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkInitializationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInitFailed_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInitFailed_ILjava_lang_String_Handler ()
		{
			if (cb_onInitFailed_ILjava_lang_String_ == null)
				cb_onInitFailed_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnInitFailed_ILjava_lang_String_));
			return cb_onInitFailed_ILjava_lang_String_;
		}

		static void n_OnInitFailed_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInitFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInitFailed_ILjava_lang_String_;
		public unsafe void OnInitFailed (int p0, string p1)
		{
			if (id_onInitFailed_ILjava_lang_String_ == IntPtr.Zero)
				id_onInitFailed_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInitFailed", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitFailed_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onInitSuccess;
#pragma warning disable 0169
		static Delegate GetOnInitSuccessHandler ()
		{
			if (cb_onInitSuccess == null)
				cb_onInitSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInitSuccess));
			return cb_onInitSuccess;
		}

		static void n_OnInitSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.AdUnit.Adapter.Listener.INetworkInitializationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInitSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onInitSuccess;
		public unsafe void OnInitSuccess ()
		{
			if (id_onInitSuccess == IntPtr.Zero)
				id_onInitSuccess = JNIEnv.GetMethodID (class_ref, "onInitSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitSuccess);
		}

	}

	// event args for com.ironsource.mediationsdk.adunit.adapter.listener.NetworkInitializationListener.onInitFailed
	public partial class InitFailedEventArgs : global::System.EventArgs {
		public InitFailedEventArgs (int p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		string p1;

		public string P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/adunit/adapter/listener/NetworkInitializationListenerImplementor")]
	internal sealed partial class INetworkInitializationListenerImplementor : global::Java.Lang.Object, INetworkInitializationListener {

		object sender;

		public unsafe INetworkInitializationListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<InitFailedEventArgs> OnInitFailedHandler;
		#pragma warning restore 0649

		public void OnInitFailed (int p0, string p1)
		{
			var __h = OnInitFailedHandler;
			if (__h != null)
				__h (sender, new InitFailedEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler OnInitSuccessHandler;
		#pragma warning restore 0649

		public void OnInitSuccess ()
		{
			var __h = OnInitSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (INetworkInitializationListenerImplementor value)
		{
			return value.OnInitFailedHandler == null && value.OnInitSuccessHandler == null;
		}

	}
}
