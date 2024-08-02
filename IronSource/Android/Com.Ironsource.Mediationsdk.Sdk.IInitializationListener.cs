using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InitializationListener']"
	[Register ("com/ironsource/mediationsdk/sdk/InitializationListener", "", "Com.IronSource.MediationSdk.Sdk.IInitializationListenerInvoker")]
	public partial interface IInitializationListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.sdk']/interface[@name='InitializationListener']/method[@name='onInitializationComplete' and count(parameter)=0]"
		[Register ("onInitializationComplete", "()V", "GetOnInitializationCompleteHandler:Com.IronSource.MediationSdk.Sdk.IInitializationListenerInvoker, MatchSolitaire.Android")]
		void OnInitializationComplete ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/sdk/InitializationListener", DoNotGenerateAcw=true)]
	internal partial class IInitializationListenerInvoker : global::Java.Lang.Object, IInitializationListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/sdk/InitializationListener", typeof (IInitializationListenerInvoker));

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

		public static IInitializationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInitializationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.sdk.InitializationListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInitializationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInitializationComplete;
#pragma warning disable 0169
		static Delegate GetOnInitializationCompleteHandler ()
		{
			if (cb_onInitializationComplete == null)
				cb_onInitializationComplete = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnInitializationComplete));
			return cb_onInitializationComplete;
		}

		static void n_OnInitializationComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Sdk.IInitializationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInitializationComplete ();
		}
#pragma warning restore 0169

		IntPtr id_onInitializationComplete;
		public unsafe void OnInitializationComplete ()
		{
			if (id_onInitializationComplete == IntPtr.Zero)
				id_onInitializationComplete = JNIEnv.GetMethodID (class_ref, "onInitializationComplete", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitializationComplete);
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/sdk/InitializationListenerImplementor")]
	internal sealed partial class IInitializationListenerImplementor : global::Java.Lang.Object, IInitializationListener {

		object sender;

		public unsafe IInitializationListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler Handler;
		#pragma warning restore 0649

		public void OnInitializationComplete ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IInitializationListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
