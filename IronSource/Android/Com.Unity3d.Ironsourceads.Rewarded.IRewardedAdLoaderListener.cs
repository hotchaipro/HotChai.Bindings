using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.IronSourceAds.Rewarded {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdLoaderListener']"
	[Register ("com/unity3d/ironsourceads/rewarded/RewardedAdLoaderListener", "", "Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdLoaderListenerInvoker")]
	public partial interface IRewardedAdLoaderListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdLoaderListener']/method[@name='onRewardedAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onRewardedAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdLoaderListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdLoaderListener']/method[@name='onRewardedAdLoaded' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.rewarded.RewardedAd']]"
		[Register ("onRewardedAdLoaded", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V", "GetOnRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler:Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdLoaderListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedAdLoaded (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd);

	}

	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/rewarded/RewardedAdLoaderListener", DoNotGenerateAcw=true)]
	internal partial class IRewardedAdLoaderListenerInvoker : global::Java.Lang.Object, IRewardedAdLoaderListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/rewarded/RewardedAdLoaderListener", typeof (IRewardedAdLoaderListenerInvoker));

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

		public static IRewardedAdLoaderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRewardedAdLoaderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.ironsourceads.rewarded.RewardedAdLoaderListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRewardedAdLoaderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdLoaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedAdLoadFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnRewardedAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onRewardedAdLoadFailed", "(Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedAdLoadFailed_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
#pragma warning disable 0169
		static Delegate GetOnRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler ()
		{
			if (cb_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == null)
				cb_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_));
			return cb_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		}

		static void n_OnRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdLoaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rewardedAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd> (native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedAdLoaded (rewardedAd);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		public unsafe void OnRewardedAdLoaded (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			if (id_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == IntPtr.Zero)
				id_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNIEnv.GetMethodID (class_ref, "onRewardedAdLoaded", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((rewardedAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rewardedAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedAdLoaded_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_, __args);
		}

	}

	// event args for com.unity3d.ironsourceads.rewarded.RewardedAdLoaderListener.onRewardedAdLoadFailed
	public partial class RewardedAdLoadFailedEventArgs : global::System.EventArgs {
		public RewardedAdLoadFailedEventArgs (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.error = error;
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.ironsourceads.rewarded.RewardedAdLoaderListener.onRewardedAdLoaded
	public partial class RewardedAdLoadedEventArgs : global::System.EventArgs {
		public RewardedAdLoadedEventArgs (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			this.rewardedAd = rewardedAd;
		}

		global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd;

		public global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd RewardedAd {
			get { return rewardedAd; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/ironsourceads/rewarded/RewardedAdLoaderListenerImplementor")]
	internal sealed partial class IRewardedAdLoaderListenerImplementor : global::Java.Lang.Object, IRewardedAdLoaderListener {

		object sender;

		public unsafe IRewardedAdLoaderListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<RewardedAdLoadFailedEventArgs> OnRewardedAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnRewardedAdLoadFailed (global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnRewardedAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new RewardedAdLoadFailedEventArgs (error));
		}

		#pragma warning disable 0649
		public EventHandler<RewardedAdLoadedEventArgs> OnRewardedAdLoadedHandler;
		#pragma warning restore 0649

		public void OnRewardedAdLoaded (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			var __h = OnRewardedAdLoadedHandler;
			if (__h != null)
				__h (sender, new RewardedAdLoadedEventArgs (rewardedAd));
		}

		internal static bool __IsEmpty (IRewardedAdLoaderListenerImplementor value)
		{
			return value.OnRewardedAdLoadFailedHandler == null && value.OnRewardedAdLoadedHandler == null;
		}

	}
}
