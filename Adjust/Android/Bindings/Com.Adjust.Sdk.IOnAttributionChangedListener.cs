using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnAttributionChangedListener']"
	[Register ("com/adjust/sdk/OnAttributionChangedListener", "", "Com.Adjust.Sdk.IOnAttributionChangedListenerInvoker")]
	public partial interface IOnAttributionChangedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnAttributionChangedListener']/method[@name='onAttributionChanged' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustAttribution']]"
		[Register ("onAttributionChanged", "(Lcom/adjust/sdk/AdjustAttribution;)V", "GetOnAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_Handler:Com.Adjust.Sdk.IOnAttributionChangedListenerInvoker, MatchBlocks.Android")]
		void OnAttributionChanged (global::Com.Adjust.Sdk.AdjustAttribution p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnAttributionChangedListener", DoNotGenerateAcw=true)]
	internal partial class IOnAttributionChangedListenerInvoker : global::Java.Lang.Object, IOnAttributionChangedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnAttributionChangedListener", typeof (IOnAttributionChangedListenerInvoker));

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

		public static IOnAttributionChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnAttributionChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnAttributionChangedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnAttributionChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_;
#pragma warning disable 0169
		static Delegate GetOnAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_Handler ()
		{
			if (cb_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_ == null)
				cb_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_));
			return cb_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_;
		}

		static void n_OnAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnAttributionChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustAttribution> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAttributionChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_;
		public unsafe void OnAttributionChanged (global::Com.Adjust.Sdk.AdjustAttribution p0)
		{
			if (id_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_ == IntPtr.Zero)
				id_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_ = JNIEnv.GetMethodID (class_ref, "onAttributionChanged", "(Lcom/adjust/sdk/AdjustAttribution;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttributionChanged_Lcom_adjust_sdk_AdjustAttribution_, __args);
		}

	}

	// event args for com.adjust.sdk.OnAttributionChangedListener.onAttributionChanged
	public partial class AttributionChangedEventArgs : global::System.EventArgs {
		public AttributionChangedEventArgs (global::Com.Adjust.Sdk.AdjustAttribution p0)
		{
			this.p0 = p0;
		}

		global::Com.Adjust.Sdk.AdjustAttribution p0;

		public global::Com.Adjust.Sdk.AdjustAttribution P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnAttributionChangedListenerImplementor")]
	internal sealed partial class IOnAttributionChangedListenerImplementor : global::Java.Lang.Object, IOnAttributionChangedListener {

		object sender;

		public unsafe IOnAttributionChangedListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<AttributionChangedEventArgs> Handler;
		#pragma warning restore 0649

		public void OnAttributionChanged (global::Com.Adjust.Sdk.AdjustAttribution p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AttributionChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnAttributionChangedListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
