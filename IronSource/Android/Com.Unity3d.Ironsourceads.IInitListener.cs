using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.IronSourceAds {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.ironsourceads']/interface[@name='InitListener']"
	[Register ("com/unity3d/ironsourceads/InitListener", "", "Com.Unity3d.IronSourceAds.IInitListenerInvoker")]
	public partial interface IInitListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/interface[@name='InitListener']/method[@name='onInitFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.Unity3d.IronSourceAds.IInitListenerInvoker, MatchSolitaire.Android")]
		void OnInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/interface[@name='InitListener']/method[@name='onInitSuccess' and count(parameter)=0]"
		[Register ("onInitSuccess", "()V", "GetOnInitSuccessHandler:Com.Unity3d.IronSourceAds.IInitListenerInvoker, MatchSolitaire.Android")]
		void OnInitSuccess ();

	}

	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/InitListener", DoNotGenerateAcw=true)]
	internal partial class IInitListenerInvoker : global::Java.Lang.Object, IInitListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/InitListener", typeof (IInitListenerInvoker));

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

		public static IInitListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInitListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.ironsourceads.InitListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInitListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.IInitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnInitFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInitFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.IInitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.unity3d.ironsourceads.InitListener.onInitFailed
	public partial class InitFailedEventArgs : global::System.EventArgs {
		public InitFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.error = error;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/ironsourceads/InitListenerImplementor")]
	internal sealed partial class IInitListenerImplementor : global::Java.Lang.Object, IInitListener {

		object sender;

		public unsafe IInitListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public void OnInitFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnInitFailedHandler;
			if (__h != null)
				__h (sender, new InitFailedEventArgs (error));
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

		internal static bool __IsEmpty (IInitListenerImplementor value)
		{
			return value.OnInitFailedHandler == null && value.OnInitSuccessHandler == null;
		}

	}
}
