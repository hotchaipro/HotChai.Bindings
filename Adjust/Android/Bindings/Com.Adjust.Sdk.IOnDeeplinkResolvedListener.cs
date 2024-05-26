using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnDeeplinkResolvedListener']"
	[Register ("com/adjust/sdk/OnDeeplinkResolvedListener", "", "Com.Adjust.Sdk.IOnDeeplinkResolvedListenerInvoker")]
	public partial interface IOnDeeplinkResolvedListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnDeeplinkResolvedListener']/method[@name='onDeeplinkResolved' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDeeplinkResolved", "(Ljava/lang/String;)V", "GetOnDeeplinkResolved_Ljava_lang_String_Handler:Com.Adjust.Sdk.IOnDeeplinkResolvedListenerInvoker, MatchBlocks.Android")]
		void OnDeeplinkResolved (string p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnDeeplinkResolvedListener", DoNotGenerateAcw=true)]
	internal partial class IOnDeeplinkResolvedListenerInvoker : global::Java.Lang.Object, IOnDeeplinkResolvedListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnDeeplinkResolvedListener", typeof (IOnDeeplinkResolvedListenerInvoker));

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

		public static IOnDeeplinkResolvedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDeeplinkResolvedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnDeeplinkResolvedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDeeplinkResolvedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDeeplinkResolved_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDeeplinkResolved_Ljava_lang_String_Handler ()
		{
			if (cb_onDeeplinkResolved_Ljava_lang_String_ == null)
				cb_onDeeplinkResolved_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnDeeplinkResolved_Ljava_lang_String_));
			return cb_onDeeplinkResolved_Ljava_lang_String_;
		}

		static void n_OnDeeplinkResolved_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnDeeplinkResolvedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeeplinkResolved (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDeeplinkResolved_Ljava_lang_String_;
		public unsafe void OnDeeplinkResolved (string p0)
		{
			if (id_onDeeplinkResolved_Ljava_lang_String_ == IntPtr.Zero)
				id_onDeeplinkResolved_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDeeplinkResolved", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeeplinkResolved_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.adjust.sdk.OnDeeplinkResolvedListener.onDeeplinkResolved
	public partial class DeeplinkResolvedEventArgs : global::System.EventArgs {
		public DeeplinkResolvedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;

		public string P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnDeeplinkResolvedListenerImplementor")]
	internal sealed partial class IOnDeeplinkResolvedListenerImplementor : global::Java.Lang.Object, IOnDeeplinkResolvedListener {

		object sender;

		public unsafe IOnDeeplinkResolvedListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DeeplinkResolvedEventArgs> Handler;
		#pragma warning restore 0649

		public void OnDeeplinkResolved (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DeeplinkResolvedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnDeeplinkResolvedListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
