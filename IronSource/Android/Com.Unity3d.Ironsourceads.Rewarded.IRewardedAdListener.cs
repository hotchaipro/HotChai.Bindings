using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.IronSourceAds.Rewarded {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdListener']"
	[Register ("com/unity3d/ironsourceads/rewarded/RewardedAdListener", "", "Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListenerInvoker")]
	public partial interface IRewardedAdListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdListener']/method[@name='onRewardedAdClicked' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.rewarded.RewardedAd']]"
		[Register ("onRewardedAdClicked", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V", "GetOnRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler:Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedAdClicked (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdListener']/method[@name='onRewardedAdDismissed' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.rewarded.RewardedAd']]"
		[Register ("onRewardedAdDismissed", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V", "GetOnRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler:Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedAdDismissed (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdListener']/method[@name='onRewardedAdFailedToShow' and count(parameter)=2 and parameter[1][@type='com.unity3d.ironsourceads.rewarded.RewardedAd'] and parameter[2][@type='com.ironsource.mediationsdk.logger.IronSourceError']]"
		[Register ("onRewardedAdFailedToShow", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V", "GetOnRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler:Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedAdFailedToShow (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdListener']/method[@name='onRewardedAdShown' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.rewarded.RewardedAd']]"
		[Register ("onRewardedAdShown", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V", "GetOnRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler:Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListenerInvoker, MatchSolitaire.Android")]
		void OnRewardedAdShown (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.rewarded']/interface[@name='RewardedAdListener']/method[@name='onUserEarnedReward' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.rewarded.RewardedAd']]"
		[Register ("onUserEarnedReward", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V", "GetOnUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler:Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListenerInvoker, MatchSolitaire.Android")]
		void OnUserEarnedReward (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd);

	}

	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/rewarded/RewardedAdListener", DoNotGenerateAcw=true)]
	internal partial class IRewardedAdListenerInvoker : global::Java.Lang.Object, IRewardedAdListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/rewarded/RewardedAdListener", typeof (IRewardedAdListenerInvoker));

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

		public static IRewardedAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRewardedAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.ironsourceads.rewarded.RewardedAdListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRewardedAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
#pragma warning disable 0169
		static Delegate GetOnRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler ()
		{
			if (cb_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == null)
				cb_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_));
			return cb_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		}

		static void n_OnRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rewardedAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd> (native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedAdClicked (rewardedAd);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		public unsafe void OnRewardedAdClicked (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			if (id_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == IntPtr.Zero)
				id_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNIEnv.GetMethodID (class_ref, "onRewardedAdClicked", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((rewardedAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rewardedAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedAdClicked_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_, __args);
		}

		static Delegate cb_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
#pragma warning disable 0169
		static Delegate GetOnRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler ()
		{
			if (cb_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == null)
				cb_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_));
			return cb_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		}

		static void n_OnRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rewardedAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd> (native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedAdDismissed (rewardedAd);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		public unsafe void OnRewardedAdDismissed (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			if (id_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == IntPtr.Zero)
				id_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNIEnv.GetMethodID (class_ref, "onRewardedAdDismissed", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((rewardedAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rewardedAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedAdDismissed_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_, __args);
		}

		static Delegate cb_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
#pragma warning disable 0169
		static Delegate GetOnRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_Handler ()
		{
			if (cb_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == null)
				cb_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_));
			return cb_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		}

		static void n_OnRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rewardedAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd> (native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedAdFailedToShow (rewardedAd, error);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_;
		public unsafe void OnRewardedAdFailedToShow (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			if (id_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ == IntPtr.Zero)
				id_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_ = JNIEnv.GetMethodID (class_ref, "onRewardedAdFailedToShow", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;Lcom/ironsource/mediationsdk/logger/IronSourceError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((rewardedAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rewardedAd).Handle);
			__args [1] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedAdFailedToShow_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Lcom_ironsource_mediationsdk_logger_IronSourceError_, __args);
		}

		static Delegate cb_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
#pragma warning disable 0169
		static Delegate GetOnRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler ()
		{
			if (cb_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == null)
				cb_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_));
			return cb_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		}

		static void n_OnRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rewardedAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd> (native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedAdShown (rewardedAd);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		public unsafe void OnRewardedAdShown (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			if (id_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == IntPtr.Zero)
				id_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNIEnv.GetMethodID (class_ref, "onRewardedAdShown", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((rewardedAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rewardedAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedAdShown_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_, __args);
		}

		static Delegate cb_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
#pragma warning disable 0169
		static Delegate GetOnUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_Handler ()
		{
			if (cb_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == null)
				cb_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_));
			return cb_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		}

		static void n_OnUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rewardedAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.IRewardedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rewardedAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd> (native_rewardedAd, JniHandleOwnership.DoNotTransfer);
			__this.OnUserEarnedReward (rewardedAd);
		}
#pragma warning restore 0169

		IntPtr id_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_;
		public unsafe void OnUserEarnedReward (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			if (id_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ == IntPtr.Zero)
				id_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_ = JNIEnv.GetMethodID (class_ref, "onUserEarnedReward", "(Lcom/unity3d/ironsourceads/rewarded/RewardedAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((rewardedAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rewardedAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserEarnedReward_Lcom_unity3d_ironsourceads_rewarded_RewardedAd_, __args);
		}

	}

	// event args for com.unity3d.ironsourceads.rewarded.RewardedAdListener.onRewardedAdClicked
	public partial class RewardedAdClickedEventArgs : global::System.EventArgs {
		public RewardedAdClickedEventArgs (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			this.rewardedAd = rewardedAd;
		}

		global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd;

		public global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd RewardedAd {
			get { return rewardedAd; }
		}

	}

	// event args for com.unity3d.ironsourceads.rewarded.RewardedAdListener.onRewardedAdDismissed
	public partial class RewardedAdDismissedEventArgs : global::System.EventArgs {
		public RewardedAdDismissedEventArgs (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			this.rewardedAd = rewardedAd;
		}

		global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd;

		public global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd RewardedAd {
			get { return rewardedAd; }
		}

	}

	// event args for com.unity3d.ironsourceads.rewarded.RewardedAdListener.onRewardedAdFailedToShow
	public partial class RewardedAdFailedToShowEventArgs : global::System.EventArgs {
		public RewardedAdFailedToShowEventArgs (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			this.rewardedAd = rewardedAd;
			this.error = error;
		}

		global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd;

		public global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd RewardedAd {
			get { return rewardedAd; }
		}

		global::Com.IronSource.MediationSdk.Logger.IronSourceError error;

		public global::Com.IronSource.MediationSdk.Logger.IronSourceError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.ironsourceads.rewarded.RewardedAdListener.onRewardedAdShown
	public partial class RewardedAdShownEventArgs : global::System.EventArgs {
		public RewardedAdShownEventArgs (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			this.rewardedAd = rewardedAd;
		}

		global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd;

		public global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd RewardedAd {
			get { return rewardedAd; }
		}

	}

	// event args for com.unity3d.ironsourceads.rewarded.RewardedAdListener.onUserEarnedReward
	public partial class UserEarnedRewardEventArgs : global::System.EventArgs {
		public UserEarnedRewardEventArgs (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			this.rewardedAd = rewardedAd;
		}

		global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd;

		public global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd RewardedAd {
			get { return rewardedAd; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/ironsourceads/rewarded/RewardedAdListenerImplementor")]
	internal sealed partial class IRewardedAdListenerImplementor : global::Java.Lang.Object, IRewardedAdListener {

		object sender;

		public unsafe IRewardedAdListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<RewardedAdClickedEventArgs> OnRewardedAdClickedHandler;
		#pragma warning restore 0649

		public void OnRewardedAdClicked (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			var __h = OnRewardedAdClickedHandler;
			if (__h != null)
				__h (sender, new RewardedAdClickedEventArgs (rewardedAd));
		}

		#pragma warning disable 0649
		public EventHandler<RewardedAdDismissedEventArgs> OnRewardedAdDismissedHandler;
		#pragma warning restore 0649

		public void OnRewardedAdDismissed (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			var __h = OnRewardedAdDismissedHandler;
			if (__h != null)
				__h (sender, new RewardedAdDismissedEventArgs (rewardedAd));
		}

		#pragma warning disable 0649
		public EventHandler<RewardedAdFailedToShowEventArgs> OnRewardedAdFailedToShowHandler;
		#pragma warning restore 0649

		public void OnRewardedAdFailedToShow (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd, global::Com.IronSource.MediationSdk.Logger.IronSourceError error)
		{
			var __h = OnRewardedAdFailedToShowHandler;
			if (__h != null)
				__h (sender, new RewardedAdFailedToShowEventArgs (rewardedAd, error));
		}

		#pragma warning disable 0649
		public EventHandler<RewardedAdShownEventArgs> OnRewardedAdShownHandler;
		#pragma warning restore 0649

		public void OnRewardedAdShown (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			var __h = OnRewardedAdShownHandler;
			if (__h != null)
				__h (sender, new RewardedAdShownEventArgs (rewardedAd));
		}

		#pragma warning disable 0649
		public EventHandler<UserEarnedRewardEventArgs> OnUserEarnedRewardHandler;
		#pragma warning restore 0649

		public void OnUserEarnedReward (global::Com.Unity3d.IronSourceAds.Rewarded.RewardedAd rewardedAd)
		{
			var __h = OnUserEarnedRewardHandler;
			if (__h != null)
				__h (sender, new UserEarnedRewardEventArgs (rewardedAd));
		}

		internal static bool __IsEmpty (IRewardedAdListenerImplementor value)
		{
			return value.OnRewardedAdClickedHandler == null && value.OnRewardedAdDismissedHandler == null && value.OnRewardedAdFailedToShowHandler == null && value.OnRewardedAdShownHandler == null && value.OnUserEarnedRewardHandler == null;
		}

	}
}
