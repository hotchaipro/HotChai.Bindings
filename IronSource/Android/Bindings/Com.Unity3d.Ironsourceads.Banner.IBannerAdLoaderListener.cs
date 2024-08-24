using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.IronSourceAds.Banner {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/interface[@name='BannerAdLoaderListener']"
	[Register ("com/unity3d/ironsourceads/banner/BannerAdLoaderListener", "", "Com.Unity3d.IronSourceAds.Banner.IBannerAdLoaderListenerInvoker")]
	public partial interface IBannerAdLoaderListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/interface[@name='BannerAdLoaderListener']/method[@name='onBannerAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onBannerAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.Unity3d.IronSourceAds.Banner.IBannerAdLoaderListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/interface[@name='BannerAdLoaderListener']/method[@name='onBannerAdLoaded' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.banner.BannerAdView']]"
		[Register ("onBannerAdLoaded", "(Lcom/unity3d/ironsourceads/banner/BannerAdView;)V", "GetOnBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_Handler:Com.Unity3d.IronSourceAds.Banner.IBannerAdLoaderListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdLoaded (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAdView);

	}

	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/banner/BannerAdLoaderListener", DoNotGenerateAcw=true)]
	internal partial class IBannerAdLoaderListenerInvoker : global::Java.Lang.Object, IBannerAdLoaderListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/banner/BannerAdLoaderListener", typeof (IBannerAdLoaderListenerInvoker));

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

		public static IBannerAdLoaderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBannerAdLoaderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.ironsourceads.banner.BannerAdLoaderListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBannerAdLoaderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.IBannerAdLoaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLoadFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnBannerAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onBannerAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_Handler ()
		{
			if (cb_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_ == null)
				cb_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_));
			return cb_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
		}

		static void n_OnBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAdView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.IBannerAdLoaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bannerAdView = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.BannerAdView> (native_bannerAdView, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdLoaded (bannerAdView);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
		public unsafe void OnBannerAdLoaded (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAdView)
		{
			if (id_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_ == IntPtr.Zero)
				id_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_ = JNIEnv.GetMethodID (class_ref, "onBannerAdLoaded", "(Lcom/unity3d/ironsourceads/banner/BannerAdView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((bannerAdView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bannerAdView).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdLoaded_Lcom_unity3d_ironsourceads_banner_BannerAdView_, __args);
		}

	}

	// event args for com.unity3d.ironsourceads.banner.BannerAdLoaderListener.onBannerAdLoadFailed
	public partial class BannerAdLoadFailedEventArgs : global::System.EventArgs {
		public BannerAdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.error = error;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.ironsourceads.banner.BannerAdLoaderListener.onBannerAdLoaded
	public partial class BannerAdLoadedEventArgs : global::System.EventArgs {
		public BannerAdLoadedEventArgs (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAdView)
		{
			this.bannerAdView = bannerAdView;
		}

		global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAdView;

		public global::Com.Unity3d.IronSourceAds.Banner.BannerAdView BannerAdView {
			get { return bannerAdView; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/ironsourceads/banner/BannerAdLoaderListenerImplementor")]
	internal sealed partial class IBannerAdLoaderListenerImplementor : global::Java.Lang.Object, IBannerAdLoaderListener {

		object sender;

		public unsafe IBannerAdLoaderListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<BannerAdLoadFailedEventArgs> OnBannerAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnBannerAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnBannerAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new BannerAdLoadFailedEventArgs (error));
		}

		#pragma warning disable 0649
		public EventHandler<BannerAdLoadedEventArgs> OnBannerAdLoadedHandler;
		#pragma warning restore 0649

		public void OnBannerAdLoaded (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAdView)
		{
			var __h = OnBannerAdLoadedHandler;
			if (__h != null)
				__h (sender, new BannerAdLoadedEventArgs (bannerAdView));
		}

		internal static bool __IsEmpty (IBannerAdLoaderListenerImplementor value)
		{
			return value.OnBannerAdLoadFailedHandler == null && value.OnBannerAdLoadedHandler == null;
		}

	}
}
