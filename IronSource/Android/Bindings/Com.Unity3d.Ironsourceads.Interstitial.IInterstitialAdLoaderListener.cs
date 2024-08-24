using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.IronSourceAds.Interstitial {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdLoaderListener']"
	[Register ("com/unity3d/ironsourceads/interstitial/InterstitialAdLoaderListener", "", "Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdLoaderListenerInvoker")]
	public partial interface IInterstitialAdLoaderListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdLoaderListener']/method[@name='onInterstitialAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onInterstitialAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdLoaderListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.interstitial']/interface[@name='InterstitialAdLoaderListener']/method[@name='onInterstitialAdLoaded' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.interstitial.InterstitialAd']]"
		[Register ("onInterstitialAdLoaded", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V", "GetOnInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler:Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdLoaderListenerInvoker, MatchSolitaire.Android")]
		void OnInterstitialAdLoaded (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd);

	}

	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/interstitial/InterstitialAdLoaderListener", DoNotGenerateAcw=true)]
	internal partial class IInterstitialAdLoaderListenerInvoker : global::Java.Lang.Object, IInterstitialAdLoaderListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/interstitial/InterstitialAdLoaderListener", typeof (IInterstitialAdLoaderListenerInvoker));

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

		public static IInterstitialAdLoaderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterstitialAdLoaderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.ironsourceads.interstitial.InterstitialAdLoaderListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterstitialAdLoaderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdLoaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdLoadFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnInterstitialAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_Handler ()
		{
			if (cb_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == null)
				cb_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_));
			return cb_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		}

		static void n_OnInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interstitialAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.IInterstitialAdLoaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interstitialAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd> (native_interstitialAd, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialAdLoaded (interstitialAd);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_;
		public unsafe void OnInterstitialAdLoaded (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			if (id_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ == IntPtr.Zero)
				id_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onInterstitialAdLoaded", "(Lcom/unity3d/ironsourceads/interstitial/InterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((interstitialAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interstitialAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialAdLoaded_Lcom_unity3d_ironsourceads_interstitial_InterstitialAd_, __args);
		}

	}

	// event args for com.unity3d.ironsourceads.interstitial.InterstitialAdLoaderListener.onInterstitialAdLoadFailed
	public partial class InterstitialAdLoadFailedEventArgs : global::System.EventArgs {
		public InterstitialAdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.error = error;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.ironsourceads.interstitial.InterstitialAdLoaderListener.onInterstitialAdLoaded
	public partial class InterstitialAdLoadedEventArgs : global::System.EventArgs {
		public InterstitialAdLoadedEventArgs (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			this.interstitialAd = interstitialAd;
		}

		global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd;

		public global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd InterstitialAd {
			get { return interstitialAd; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/ironsourceads/interstitial/InterstitialAdLoaderListenerImplementor")]
	internal sealed partial class IInterstitialAdLoaderListenerImplementor : global::Java.Lang.Object, IInterstitialAdLoaderListener {

		object sender;

		public unsafe IInterstitialAdLoaderListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<InterstitialAdLoadFailedEventArgs> OnInterstitialAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnInterstitialAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new InterstitialAdLoadFailedEventArgs (error));
		}

		#pragma warning disable 0649
		public EventHandler<InterstitialAdLoadedEventArgs> OnInterstitialAdLoadedHandler;
		#pragma warning restore 0649

		public void OnInterstitialAdLoaded (global::Com.Unity3d.IronSourceAds.Interstitial.InterstitialAd interstitialAd)
		{
			var __h = OnInterstitialAdLoadedHandler;
			if (__h != null)
				__h (sender, new InterstitialAdLoadedEventArgs (interstitialAd));
		}

		internal static bool __IsEmpty (IInterstitialAdLoaderListenerImplementor value)
		{
			return value.OnInterstitialAdLoadFailedHandler == null && value.OnInterstitialAdLoadedHandler == null;
		}

	}
}
