using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.IronSourceAds.Interstitial {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdListener']"
	[Register ("com/unity3d/ironsourceads/interstitial/InterstitialAdListener", "", "Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListenerInvoker")]
	public partial interface IInterstitialAdListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdListener']/method[@name='onInterstitialAdClicked' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.interstitial.InterstitialAd']]"
		[Register ("onInterstitialAdClicked", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V", "GetOnInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler:Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdClicked (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdListener']/method[@name='onInterstitialAdDismissed' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.interstitial.InterstitialAd']]"
		[Register ("onInterstitialAdDismissed", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V", "GetOnInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler:Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdDismissed (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdListener']/method[@name='onInterstitialAdFailedToShow' and count(parameter)=2 and parameter[1][@type='com.unity3d.ironsourceads.interstitial.InterstitialAd'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInterstitialAdFailedToShow", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdFailedToShow (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdListener']/method[@name='onInterstitialAdShown' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.interstitial.InterstitialAd']]"
		[Register ("onInterstitialAdShown", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V", "GetOnInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler:Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdShown (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd);

	}

	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/interstitial/InterstitialAdListener", DoNotGenerateAcw=true)]
	internal partial class IInterstitialAdListenerInvoker : global::Java.Lang.Object, IInterstitialAdListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/interstitial/InterstitialAdListener", typeof (IInterstitialAdListenerInvoker));

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

		public static IInterstitialAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterstitialAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.ironsourceads.interstitial.InterstitialAdListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterstitialAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler ()
		{
			if (cb_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == null)
				cb_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_));
			return cb_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		}

		static void n_OnInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interstitialAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interstitialAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd> (native_interstitialAd, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdClicked (interstitialAd);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		public unsafe void OnInterstitialAdClicked (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			if (id_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == IntPtr.Zero)
				id_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdClicked", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((interstitialAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interstitialAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdClicked_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_, __args);
		}

		static Delegate cb_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler ()
		{
			if (cb_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == null)
				cb_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_));
			return cb_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		}

		static void n_OnInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interstitialAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interstitialAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd> (native_interstitialAd, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdDismissed (interstitialAd);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		public unsafe void OnInterstitialAdDismissed (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			if (id_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == IntPtr.Zero)
				id_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdDismissed", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((interstitialAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interstitialAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdDismissed_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_, __args);
		}

		static Delegate cb_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interstitialAd, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interstitialAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd> (native_interstitialAd, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdFailedToShow (interstitialAd, error);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInterstitialAdFailedToShow (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdFailedToShow", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((interstitialAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interstitialAd).Handle);
			__args [1] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdFailedToShow_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler ()
		{
			if (cb_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == null)
				cb_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_));
			return cb_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		}

		static void n_OnInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interstitialAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interstitialAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd> (native_interstitialAd, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdShown (interstitialAd);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		public unsafe void OnInterstitialAdShown (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			if (id_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == IntPtr.Zero)
				id_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdShown", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((interstitialAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interstitialAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdShown_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_, __args);
		}

	}

	// event args for com.unity3d.ironsourceads.interstitial.InterstitialAdListener.onInterstitialAdClicked
	public partial class InterstitialAdClickedEventArgs : global::System.EventArgs {
		public InterstitialAdClickedEventArgs (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			this.interstitialAd = interstitialAd;
		}

		global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd;

		public global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd InterstitialAd {
			get { return interstitialAd; }
		}

	}

	// event args for com.unity3d.ironsourceads.interstitial.InterstitialAdListener.onInterstitialAdDismissed
	public partial class InterstitialAdDismissedEventArgs : global::System.EventArgs {
		public InterstitialAdDismissedEventArgs (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			this.interstitialAd = interstitialAd;
		}

		global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd;

		public global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd InterstitialAd {
			get { return interstitialAd; }
		}

	}

	// event args for com.unity3d.ironsourceads.interstitial.InterstitialAdListener.onInterstitialAdFailedToShow
	public partial class InterstitialAdFailedToShowEventArgs : global::System.EventArgs {
		public InterstitialAdFailedToShowEventArgs (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.interstitialAd = interstitialAd;
			this.error = error;
		}

		global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd;

		public global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd InterstitialAd {
			get { return interstitialAd; }
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.ironsourceads.interstitial.InterstitialAdListener.onInterstitialAdShown
	public partial class InterstitialAdShownEventArgs : global::System.EventArgs {
		public InterstitialAdShownEventArgs (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			this.interstitialAd = interstitialAd;
		}

		global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd;

		public global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd InterstitialAd {
			get { return interstitialAd; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/ironsourceads/interstitial/InterstitialAdListenerImplementor")]
	internal sealed partial class IInterstitialAdListenerImplementor : global::Java.Lang.Object, IInterstitialAdListener {

		object sender;

		public unsafe IInterstitialAdListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<InterstitialAdClickedEventArgs> OnInterstitialAdClickedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdClicked (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			var __h = OnInterstitialAdClickedHandler;
			if (__h != null)
				__h (sender, new InterstitialAdClickedEventArgs (interstitialAd));
		}

		#pragma warning disable 0649
		public EventHandler<InterstitialAdDismissedEventArgs> OnInterstitialAdDismissedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdDismissed (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			var __h = OnInterstitialAdDismissedHandler;
			if (__h != null)
				__h (sender, new InterstitialAdDismissedEventArgs (interstitialAd));
		}

		#pragma warning disable 0649
		public EventHandler<InterstitialAdFailedToShowEventArgs> OnInterstitialAdFailedToShowHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdFailedToShow (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnInterstitialAdFailedToShowHandler;
			if (__h != null)
				__h (sender, new InterstitialAdFailedToShowEventArgs (interstitialAd, error));
		}

		#pragma warning disable 0649
		public EventHandler<InterstitialAdShownEventArgs> OnInterstitialAdShownHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdShown (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			var __h = OnInterstitialAdShownHandler;
			if (__h != null)
				__h (sender, new InterstitialAdShownEventArgs (interstitialAd));
		}

		internal static bool __IsEmpty (IInterstitialAdListenerImplementor value)
		{
			return value.OnInterstitialAdClickedHandler == null && value.OnInterstitialAdDismissedHandler == null && value.OnInterstitialAdFailedToShowHandler == null && value.OnInterstitialAdShownHandler == null;
		}

	}
}
