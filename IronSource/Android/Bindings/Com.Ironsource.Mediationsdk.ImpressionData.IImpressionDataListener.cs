using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.ImpressionData {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/interface[@name='ImpressionDataListener']"
	[Register ("com/ironsource/mediationsdk/impressionData/ImpressionDataListener", "", "Com.IronSource.MediationSdk.ImpressionData.IImpressionDataListenerInvoker")]
	public partial interface IImpressionDataListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.impressionData']/interface[@name='ImpressionDataListener']/method[@name='onImpressionSuccess' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.impressionData.ImpressionData']]"
		[Register ("onImpressionSuccess", "(Lcom/ironsource/mediationsdk/impressionData/ImpressionData;)V", "GetOnImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_Handler:Com.IronSource.MediationSdk.ImpressionData.IImpressionDataListenerInvoker, MatchSolitaire.Android")]
		void OnImpressionSuccess (global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData p0);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/impressionData/ImpressionDataListener", DoNotGenerateAcw=true)]
	internal partial class IImpressionDataListenerInvoker : global::Java.Lang.Object, IImpressionDataListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/impressionData/ImpressionDataListener", typeof (IImpressionDataListenerInvoker));

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

		public static IImpressionDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImpressionDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.impressionData.ImpressionDataListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImpressionDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_;
#pragma warning disable 0169
		static Delegate GetOnImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_Handler ()
		{
			if (cb_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_ == null)
				cb_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_));
			return cb_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_;
		}

		static void n_OnImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.IImpressionDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnImpressionSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_;
		public unsafe void OnImpressionSuccess (global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData p0)
		{
			if (id_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_ == IntPtr.Zero)
				id_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_ = JNIEnv.GetMethodID (class_ref, "onImpressionSuccess", "(Lcom/ironsource/mediationsdk/impressionData/ImpressionData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImpressionSuccess_Lcom_ironsource_mediationsdk_impressionData_ImpressionData_, __args);
		}

	}

	// event args for com.ironsource.mediationsdk.impressionData.ImpressionDataListener.onImpressionSuccess
	public partial class ImpressionDataEventArgs : global::System.EventArgs {
		public ImpressionDataEventArgs (global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData p0)
		{
			this.p0 = p0;
		}

		global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData p0;

		public global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/impressionData/ImpressionDataListenerImplementor")]
	internal sealed partial class IImpressionDataListenerImplementor : global::Java.Lang.Object, IImpressionDataListener {

		object sender;

		public unsafe IImpressionDataListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<ImpressionDataEventArgs> Handler;
		#pragma warning restore 0649

		public void OnImpressionSuccess (global::Com.IronSource.MediationSdk.ImpressionData.ImpressionData p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ImpressionDataEventArgs (p0));
		}

		internal static bool __IsEmpty (IImpressionDataListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
