using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='INetworkInitCallbackListener']"
	[Register ("com/ironsource/mediationsdk/INetworkInitCallbackListener", "", "Com.IronSource.MediationSdk.INetworkInitCallbackListenerInvoker")]
	public partial interface INetworkInitCallbackListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='INetworkInitCallbackListener']/method[@name='onNetworkInitCallbackFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onNetworkInitCallbackFailed", "(Ljava/lang/String;)V", "GetOnNetworkInitCallbackFailed_Ljava_lang_String_Handler:Com.IronSource.MediationSdk.INetworkInitCallbackListenerInvoker, MatchSolitaire.Android")]
		void OnNetworkInitCallbackFailed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/interface[@name='INetworkInitCallbackListener']/method[@name='onNetworkInitCallbackSuccess' and count(parameter)=0]"
		[Register ("onNetworkInitCallbackSuccess", "()V", "GetOnNetworkInitCallbackSuccessHandler:Com.IronSource.MediationSdk.INetworkInitCallbackListenerInvoker, MatchSolitaire.Android")]
		void OnNetworkInitCallbackSuccess ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/INetworkInitCallbackListener", DoNotGenerateAcw=true)]
	internal partial class INetworkInitCallbackListenerInvoker : global::Java.Lang.Object, INetworkInitCallbackListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/INetworkInitCallbackListener", typeof (INetworkInitCallbackListenerInvoker));

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

		public static INetworkInitCallbackListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkInitCallbackListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.INetworkInitCallbackListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkInitCallbackListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNetworkInitCallbackFailed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnNetworkInitCallbackFailed_Ljava_lang_String_Handler ()
		{
			if (cb_onNetworkInitCallbackFailed_Ljava_lang_String_ == null)
				cb_onNetworkInitCallbackFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnNetworkInitCallbackFailed_Ljava_lang_String_));
			return cb_onNetworkInitCallbackFailed_Ljava_lang_String_;
		}

		static void n_OnNetworkInitCallbackFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.INetworkInitCallbackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInitCallbackFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNetworkInitCallbackFailed_Ljava_lang_String_;
		public unsafe void OnNetworkInitCallbackFailed (string p0)
		{
			if (id_onNetworkInitCallbackFailed_Ljava_lang_String_ == IntPtr.Zero)
				id_onNetworkInitCallbackFailed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNetworkInitCallbackFailed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkInitCallbackFailed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onNetworkInitCallbackSuccess;
#pragma warning disable 0169
		static Delegate GetOnNetworkInitCallbackSuccessHandler ()
		{
			if (cb_onNetworkInitCallbackSuccess == null)
				cb_onNetworkInitCallbackSuccess = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnNetworkInitCallbackSuccess));
			return cb_onNetworkInitCallbackSuccess;
		}

		static void n_OnNetworkInitCallbackSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.INetworkInitCallbackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkInitCallbackSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onNetworkInitCallbackSuccess;
		public unsafe void OnNetworkInitCallbackSuccess ()
		{
			if (id_onNetworkInitCallbackSuccess == IntPtr.Zero)
				id_onNetworkInitCallbackSuccess = JNIEnv.GetMethodID (class_ref, "onNetworkInitCallbackSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkInitCallbackSuccess);
		}

	}

	// event args for com.ironsource.mediationsdk.INetworkInitCallbackListener.onNetworkInitCallbackFailed
	public partial class NetworkInitCallbackFailedEventArgs : global::System.EventArgs {
		public NetworkInitCallbackFailedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;

		public string P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/INetworkInitCallbackListenerImplementor")]
	internal sealed partial class INetworkInitCallbackListenerImplementor : global::Java.Lang.Object, INetworkInitCallbackListener {

		object sender;

		public unsafe INetworkInitCallbackListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<NetworkInitCallbackFailedEventArgs> OnNetworkInitCallbackFailedHandler;
		#pragma warning restore 0649

		public void OnNetworkInitCallbackFailed (string p0)
		{
			var __h = OnNetworkInitCallbackFailedHandler;
			if (__h != null)
				__h (sender, new NetworkInitCallbackFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler OnNetworkInitCallbackSuccessHandler;
		#pragma warning restore 0649

		public void OnNetworkInitCallbackSuccess ()
		{
			var __h = OnNetworkInitCallbackSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (INetworkInitCallbackListenerImplementor value)
		{
			return value.OnNetworkInitCallbackFailedHandler == null && value.OnNetworkInitCallbackSuccessHandler == null;
		}

	}
}
