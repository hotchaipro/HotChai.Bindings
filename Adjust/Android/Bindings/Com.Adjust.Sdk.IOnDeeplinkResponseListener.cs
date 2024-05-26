using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnDeeplinkResponseListener']"
	[Register ("com/adjust/sdk/OnDeeplinkResponseListener", "", "Com.Adjust.Sdk.IOnDeeplinkResponseListenerInvoker")]
	public partial interface IOnDeeplinkResponseListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='OnDeeplinkResponseListener']/method[@name='launchReceivedDeeplink' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("launchReceivedDeeplink", "(Landroid/net/Uri;)Z", "GetLaunchReceivedDeeplink_Landroid_net_Uri_Handler:Com.Adjust.Sdk.IOnDeeplinkResponseListenerInvoker, MatchBlocks.Android")]
		bool LaunchReceivedDeeplink (global::Android.Net.Uri p0);

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/OnDeeplinkResponseListener", DoNotGenerateAcw=true)]
	internal partial class IOnDeeplinkResponseListenerInvoker : global::Java.Lang.Object, IOnDeeplinkResponseListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/OnDeeplinkResponseListener", typeof (IOnDeeplinkResponseListenerInvoker));

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

		public static IOnDeeplinkResponseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDeeplinkResponseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.OnDeeplinkResponseListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDeeplinkResponseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_launchReceivedDeeplink_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetLaunchReceivedDeeplink_Landroid_net_Uri_Handler ()
		{
			if (cb_launchReceivedDeeplink_Landroid_net_Uri_ == null)
				cb_launchReceivedDeeplink_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_LaunchReceivedDeeplink_Landroid_net_Uri_));
			return cb_launchReceivedDeeplink_Landroid_net_Uri_;
		}

		static bool n_LaunchReceivedDeeplink_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnDeeplinkResponseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LaunchReceivedDeeplink (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_launchReceivedDeeplink_Landroid_net_Uri_;
		public unsafe bool LaunchReceivedDeeplink (global::Android.Net.Uri p0)
		{
			if (id_launchReceivedDeeplink_Landroid_net_Uri_ == IntPtr.Zero)
				id_launchReceivedDeeplink_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "launchReceivedDeeplink", "(Landroid/net/Uri;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_launchReceivedDeeplink_Landroid_net_Uri_, __args);
			return __ret;
		}

	}

	// event args for com.adjust.sdk.OnDeeplinkResponseListener.launchReceivedDeeplink
	public partial class DeeplinkResponseEventArgs : global::System.EventArgs {
		bool handled;

		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		public DeeplinkResponseEventArgs (bool handled, global::Android.Net.Uri p0)
		{
			this.handled = handled;
			this.p0 = p0;
		}

		global::Android.Net.Uri p0;

		public global::Android.Net.Uri P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/adjust/sdk/OnDeeplinkResponseListenerImplementor")]
	internal sealed partial class IOnDeeplinkResponseListenerImplementor : global::Java.Lang.Object, IOnDeeplinkResponseListener {

		object sender;

		public unsafe IOnDeeplinkResponseListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DeeplinkResponseEventArgs> Handler;
		#pragma warning restore 0649

		public bool LaunchReceivedDeeplink (global::Android.Net.Uri p0)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new DeeplinkResponseEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IOnDeeplinkResponseListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
