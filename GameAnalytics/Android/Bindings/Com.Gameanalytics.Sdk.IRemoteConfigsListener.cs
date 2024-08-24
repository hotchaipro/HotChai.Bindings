using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.GameAnalytics.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.gameanalytics.sdk']/interface[@name='IRemoteConfigsListener']"
	[Register ("com/gameanalytics/sdk/IRemoteConfigsListener", "", "Com.GameAnalytics.Sdk.IRemoteConfigsListenerInvoker")]
	public partial interface IRemoteConfigsListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.gameanalytics.sdk']/interface[@name='IRemoteConfigsListener']/method[@name='onRemoteConfigsUpdated' and count(parameter)=0]"
		[Register ("onRemoteConfigsUpdated", "()V", "GetOnRemoteConfigsUpdatedHandler:Com.GameAnalytics.Sdk.IRemoteConfigsListenerInvoker, MatchSolitaire.Android")]
		void OnRemoteConfigsUpdated ();

	}

	[global::Android.Runtime.Register ("com/gameanalytics/sdk/IRemoteConfigsListener", DoNotGenerateAcw=true)]
	internal partial class IRemoteConfigsListenerInvoker : global::Java.Lang.Object, IRemoteConfigsListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gameanalytics/sdk/IRemoteConfigsListener", typeof (IRemoteConfigsListenerInvoker));

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

		public static IRemoteConfigsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteConfigsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.gameanalytics.sdk.IRemoteConfigsListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteConfigsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRemoteConfigsUpdated;
#pragma warning disable 0169
		static Delegate GetOnRemoteConfigsUpdatedHandler ()
		{
			if (cb_onRemoteConfigsUpdated == null)
				cb_onRemoteConfigsUpdated = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnRemoteConfigsUpdated));
			return cb_onRemoteConfigsUpdated;
		}

		static void n_OnRemoteConfigsUpdated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.IRemoteConfigsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteConfigsUpdated ();
		}
#pragma warning restore 0169

		IntPtr id_onRemoteConfigsUpdated;
		public unsafe void OnRemoteConfigsUpdated ()
		{
			if (id_onRemoteConfigsUpdated == IntPtr.Zero)
				id_onRemoteConfigsUpdated = JNIEnv.GetMethodID (class_ref, "onRemoteConfigsUpdated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemoteConfigsUpdated);
		}

	}

	[global::Android.Runtime.Register ("mono/com/gameanalytics/sdk/IRemoteConfigsListenerImplementor")]
	internal sealed partial class IRemoteConfigsListenerImplementor : global::Java.Lang.Object, IRemoteConfigsListener {

		object sender;

		public unsafe IRemoteConfigsListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public void OnRemoteConfigsUpdated ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IRemoteConfigsListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
