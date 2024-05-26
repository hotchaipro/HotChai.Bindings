using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnPurchaseVerificationFinishedListener']"
	[Register ("com/adjust/sdk/OnPurchaseVerificationFinishedListener", "", "Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListenerInvoker")]
	public partial interface IOnPurchaseVerificationFinishedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnPurchaseVerificationFinishedListener']/method[@name='onVerificationFinished' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustPurchaseVerificationResult']]"
		[Register ("onVerificationFinished", "(Lcom/adjust/sdk/AdjustPurchaseVerificationResult;)V", "GetOnVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_Handler:Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListenerInvoker, MatchBlocks.Android")]
		void OnVerificationFinished (global::Com.Adjust.Sdk.AdjustPurchaseVerificationResult p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnPurchaseVerificationFinishedListener", DoNotGenerateAcw=true)]
	internal partial class IOnPurchaseVerificationFinishedListenerInvoker : global::Java.Lang.Object, IOnPurchaseVerificationFinishedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnPurchaseVerificationFinishedListener", typeof (IOnPurchaseVerificationFinishedListenerInvoker));

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

		public static IOnPurchaseVerificationFinishedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPurchaseVerificationFinishedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnPurchaseVerificationFinishedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPurchaseVerificationFinishedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_;
#pragma warning disable 0169
		static Delegate GetOnVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_Handler ()
		{
			if (cb_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_ == null)
				cb_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_));
			return cb_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_;
		}

		static void n_OnVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustPurchaseVerificationResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVerificationFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_;
		public unsafe void OnVerificationFinished (global::Com.Adjust.Sdk.AdjustPurchaseVerificationResult p0)
		{
			if (id_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_ == IntPtr.Zero)
				id_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_ = JNIEnv.GetMethodID (class_ref, "onVerificationFinished", "(Lcom/adjust/sdk/AdjustPurchaseVerificationResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVerificationFinished_Lcom_adjust_sdk_AdjustPurchaseVerificationResult_, __args);
		}

	}

	// event args for com.adjust.sdk.OnPurchaseVerificationFinishedListener.onVerificationFinished
	public partial class PurchaseVerificationFinishedEventArgs : global::System.EventArgs {
		public PurchaseVerificationFinishedEventArgs (global::Com.Adjust.Sdk.AdjustPurchaseVerificationResult p0)
		{
			this.p0 = p0;
		}

		global::Com.Adjust.Sdk.AdjustPurchaseVerificationResult p0;

		public global::Com.Adjust.Sdk.AdjustPurchaseVerificationResult P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnPurchaseVerificationFinishedListenerImplementor")]
	internal sealed partial class IOnPurchaseVerificationFinishedListenerImplementor : global::Java.Lang.Object, IOnPurchaseVerificationFinishedListener {

		object sender;

		public unsafe IOnPurchaseVerificationFinishedListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<PurchaseVerificationFinishedEventArgs> Handler;
		#pragma warning restore 0649

		public void OnVerificationFinished (global::Com.Adjust.Sdk.AdjustPurchaseVerificationResult p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PurchaseVerificationFinishedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnPurchaseVerificationFinishedListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
