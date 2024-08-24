using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Mediation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.mediation']/interface[@name='LevelPlayInitListener']"
	[Register ("com/unity3d/mediation/LevelPlayInitListener", "", "Com.Unity3d.Mediation.ILevelPlayInitListenerInvoker")]
	public partial interface ILevelPlayInitListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation']/interface[@name='LevelPlayInitListener']/method[@name='onInitFailed' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayInitError']]"
		[Register ("onInitFailed", "(Lcom/unity3d/mediation/LevelPlayInitError;)V", "GetOnInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_Handler:Com.Unity3d.Mediation.ILevelPlayInitListenerInvoker, MatchSolitaire.Android")]
		void OnInitFailed (global::Com.Unity3d.Mediation.LevelPlayInitError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation']/interface[@name='LevelPlayInitListener']/method[@name='onInitSuccess' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayConfiguration']]"
		[Register ("onInitSuccess", "(Lcom/unity3d/mediation/LevelPlayConfiguration;)V", "GetOnInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_Handler:Com.Unity3d.Mediation.ILevelPlayInitListenerInvoker, MatchSolitaire.Android")]
		void OnInitSuccess (global::Com.Unity3d.Mediation.LevelPlayConfiguration configuration);

	}

	[global::Android.Runtime.Register ("com/unity3d/mediation/LevelPlayInitListener", DoNotGenerateAcw=true)]
	internal partial class ILevelPlayInitListenerInvoker : global::Java.Lang.Object, ILevelPlayInitListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/mediation/LevelPlayInitListener", typeof (ILevelPlayInitListenerInvoker));

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

		public static ILevelPlayInitListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILevelPlayInitListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.mediation.LevelPlayInitListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILevelPlayInitListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_;
#pragma warning disable 0169
		static Delegate GetOnInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_Handler ()
		{
			if (cb_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_ == null)
				cb_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_));
			return cb_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_;
		}

		static void n_OnInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.ILevelPlayInitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayInitError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnInitFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_;
		public unsafe void OnInitFailed (global::Com.Unity3d.Mediation.LevelPlayInitError error)
		{
			if (id_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_ == IntPtr.Zero)
				id_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_ = JNIEnv.GetMethodID (class_ref, "onInitFailed", "(Lcom/unity3d/mediation/LevelPlayInitError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitFailed_Lcom_unity3d_mediation_LevelPlayInitError_, __args);
		}

		static Delegate cb_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_;
#pragma warning disable 0169
		static Delegate GetOnInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_Handler ()
		{
			if (cb_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_ == null)
				cb_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_));
			return cb_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_;
		}

		static void n_OnInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.ILevelPlayInitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var configuration = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayConfiguration> (native_configuration, JniHandleOwnership.DoNotTransfer);
			__this.OnInitSuccess (configuration);
		}
#pragma warning restore 0169

		IntPtr id_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_;
		public unsafe void OnInitSuccess (global::Com.Unity3d.Mediation.LevelPlayConfiguration configuration)
		{
			if (id_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_ == IntPtr.Zero)
				id_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_ = JNIEnv.GetMethodID (class_ref, "onInitSuccess", "(Lcom/unity3d/mediation/LevelPlayConfiguration;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitSuccess_Lcom_unity3d_mediation_LevelPlayConfiguration_, __args);
		}

	}

	// event args for com.unity3d.mediation.LevelPlayInitListener.onInitFailed
	public partial class InitFailedEventArgs : global::System.EventArgs {
		public InitFailedEventArgs (global::Com.Unity3d.Mediation.LevelPlayInitError error)
		{
			this.error = error;
		}

		global::Com.Unity3d.Mediation.LevelPlayInitError error;

		public global::Com.Unity3d.Mediation.LevelPlayInitError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.mediation.LevelPlayInitListener.onInitSuccess
	public partial class InitSuccessEventArgs : global::System.EventArgs {
		public InitSuccessEventArgs (global::Com.Unity3d.Mediation.LevelPlayConfiguration configuration)
		{
			this.configuration = configuration;
		}

		global::Com.Unity3d.Mediation.LevelPlayConfiguration configuration;

		public global::Com.Unity3d.Mediation.LevelPlayConfiguration Configuration {
			get { return configuration; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/mediation/LevelPlayInitListenerImplementor")]
	internal sealed partial class ILevelPlayInitListenerImplementor : global::Java.Lang.Object, ILevelPlayInitListener {

		object sender;

		public unsafe ILevelPlayInitListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public void OnInitFailed (global::Com.Unity3d.Mediation.LevelPlayInitError error)
		{
			var __h = OnInitFailedHandler;
			if (__h != null)
				__h (sender, new InitFailedEventArgs (error));
		}

		#pragma warning disable 0649
		public EventHandler<InitSuccessEventArgs> OnInitSuccessHandler;
		#pragma warning restore 0649

		public void OnInitSuccess (global::Com.Unity3d.Mediation.LevelPlayConfiguration configuration)
		{
			var __h = OnInitSuccessHandler;
			if (__h != null)
				__h (sender, new InitSuccessEventArgs (configuration));
		}

		internal static bool __IsEmpty (ILevelPlayInitListenerImplementor value)
		{
			return value.OnInitFailedHandler == null && value.OnInitSuccessHandler == null;
		}

	}
}
