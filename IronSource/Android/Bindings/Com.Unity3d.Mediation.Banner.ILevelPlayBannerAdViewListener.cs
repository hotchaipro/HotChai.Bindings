using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.IronSource.MediationSdk;
using Java.Interop;

namespace Com.Unity3d.Mediation.Banner {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']"
	[Register ("com/unity3d/mediation/banner/LevelPlayBannerAdViewListener", "", "Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListenerInvoker")]
	public partial interface ILevelPlayBannerAdViewListener : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/mediation/banner/LevelPlayBannerAdViewListener", typeof (ILevelPlayBannerAdViewListener), isInterface: true);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdLoadFailed' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdError']]"
		[Register ("onAdLoadFailed", "(Lcom/unity3d/mediation/LevelPlayAdError;)V", "GetOnAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoadFailed (global::Com.Unity3d.Mediation.LevelPlayAdError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdLoaded' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdInfo']]"
		[Register ("onAdLoaded", "(Lcom/unity3d/mediation/LevelPlayAdInfo;)V", "GetOnAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListenerInvoker, MatchSolitaire.Android")]
		void OnAdLoaded (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo);

		private static Delegate cb_onAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_;
#pragma warning disable 0169
		private static Delegate GetOnAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler ()
		{
			if (cb_onAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_ == null)
				cb_onAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_));
			return cb_onAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_;
		}

		private static void n_OnAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClicked (adInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdClicked' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdInfo']]"
		[Register ("onAdClicked", "(Lcom/unity3d/mediation/LevelPlayAdInfo;)V", "GetOnAdClicked_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener, MatchSolitaire.Android")]
		virtual unsafe void OnAdClicked (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			const string __id = "onAdClicked.(Lcom/unity3d/mediation/LevelPlayAdInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adInfo);
			}
		}

		private static Delegate cb_onAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_;
#pragma warning disable 0169
		private static Delegate GetOnAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler ()
		{
			if (cb_onAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_ == null)
				cb_onAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_));
			return cb_onAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_;
		}

		private static void n_OnAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdCollapsed (adInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdCollapsed' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdInfo']]"
		[Register ("onAdCollapsed", "(Lcom/unity3d/mediation/LevelPlayAdInfo;)V", "GetOnAdCollapsed_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener, MatchSolitaire.Android")]
		virtual unsafe void OnAdCollapsed (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			const string __id = "onAdCollapsed.(Lcom/unity3d/mediation/LevelPlayAdInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adInfo);
			}
		}

		private static Delegate cb_onAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_;
#pragma warning disable 0169
		private static Delegate GetOnAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_Handler ()
		{
			if (cb_onAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_ == null)
				cb_onAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_));
			return cb_onAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_;
		}

		private static void n_OnAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnAdDisplayFailed (adInfo, error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdDisplayFailed' and count(parameter)=2 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdInfo'] and parameter[2][@type='com.unity3d.mediation.LevelPlayAdError']]"
		[Register ("onAdDisplayFailed", "(Lcom/unity3d/mediation/LevelPlayAdInfo;Lcom/unity3d/mediation/LevelPlayAdError;)V", "GetOnAdDisplayFailed_Lcom_unity3d_mediation_LevelPlayAdInfo_Lcom_unity3d_mediation_LevelPlayAdError_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener, MatchSolitaire.Android")]
		virtual unsafe void OnAdDisplayFailed (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo, global::Com.Unity3d.Mediation.LevelPlayAdError error)
		{
			const string __id = "onAdDisplayFailed.(Lcom/unity3d/mediation/LevelPlayAdInfo;Lcom/unity3d/mediation/LevelPlayAdError;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
				__args [1] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adInfo);
				global::System.GC.KeepAlive (error);
			}
		}

		private static Delegate cb_onAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_;
#pragma warning disable 0169
		private static Delegate GetOnAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler ()
		{
			if (cb_onAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_ == null)
				cb_onAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_));
			return cb_onAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_;
		}

		private static void n_OnAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdDisplayed (adInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdDisplayed' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdInfo']]"
		[Register ("onAdDisplayed", "(Lcom/unity3d/mediation/LevelPlayAdInfo;)V", "GetOnAdDisplayed_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener, MatchSolitaire.Android")]
		virtual unsafe void OnAdDisplayed (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			const string __id = "onAdDisplayed.(Lcom/unity3d/mediation/LevelPlayAdInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adInfo);
			}
		}

		private static Delegate cb_onAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_;
#pragma warning disable 0169
		private static Delegate GetOnAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler ()
		{
			if (cb_onAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_ == null)
				cb_onAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_));
			return cb_onAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_;
		}

		private static void n_OnAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdExpanded (adInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdExpanded' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdInfo']]"
		[Register ("onAdExpanded", "(Lcom/unity3d/mediation/LevelPlayAdInfo;)V", "GetOnAdExpanded_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener, MatchSolitaire.Android")]
		virtual unsafe void OnAdExpanded (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			const string __id = "onAdExpanded.(Lcom/unity3d/mediation/LevelPlayAdInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adInfo);
			}
		}

		private static Delegate cb_onAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_;
#pragma warning disable 0169
		private static Delegate GetOnAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler ()
		{
			if (cb_onAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_ == null)
				cb_onAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_));
			return cb_onAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_;
		}

		private static void n_OnAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLeftApplication (adInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.mediation.banner']/interface[@name='LevelPlayBannerAdViewListener']/method[@name='onAdLeftApplication' and count(parameter)=1 and parameter[1][@type='com.unity3d.mediation.LevelPlayAdInfo']]"
		[Register ("onAdLeftApplication", "(Lcom/unity3d/mediation/LevelPlayAdInfo;)V", "GetOnAdLeftApplication_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler:Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener, MatchSolitaire.Android")]
		virtual unsafe void OnAdLeftApplication (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			const string __id = "onAdLeftApplication.(Lcom/unity3d/mediation/LevelPlayAdInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adInfo);
			}
		}

	}

	[global::Android.Runtime.Register ("com/unity3d/mediation/banner/LevelPlayBannerAdViewListener", DoNotGenerateAcw=true)]
	internal partial class ILevelPlayBannerAdViewListenerInvoker : global::Java.Lang.Object, ILevelPlayBannerAdViewListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/mediation/banner/LevelPlayBannerAdViewListener", typeof (ILevelPlayBannerAdViewListenerInvoker));

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

		public static ILevelPlayBannerAdViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILevelPlayBannerAdViewListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.mediation.banner.LevelPlayBannerAdViewListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILevelPlayBannerAdViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_;
#pragma warning disable 0169
		static Delegate GetOnAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_Handler ()
		{
			if (cb_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_ == null)
				cb_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_));
			return cb_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_;
		}

		static void n_OnAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadFailed (error);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_;
		public unsafe void OnAdLoadFailed (global::Com.Unity3d.Mediation.LevelPlayAdError error)
		{
			if (id_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_ == IntPtr.Zero)
				id_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_ = JNIEnv.GetMethodID (class_ref, "onAdLoadFailed", "(Lcom/unity3d/mediation/LevelPlayAdError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadFailed_Lcom_unity3d_mediation_LevelPlayAdError_, __args);
		}

		static Delegate cb_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_;
#pragma warning disable 0169
		static Delegate GetOnAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_Handler ()
		{
			if (cb_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_ == null)
				cb_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_));
			return cb_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_;
		}

		static void n_OnAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.Banner.ILevelPlayBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adInfo = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Mediation.LevelPlayAdInfo> (native_adInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoaded (adInfo);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_;
		public unsafe void OnAdLoaded (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			if (id_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_ == IntPtr.Zero)
				id_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_ = JNIEnv.GetMethodID (class_ref, "onAdLoaded", "(Lcom/unity3d/mediation/LevelPlayAdInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((adInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adInfo).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoaded_Lcom_unity3d_mediation_LevelPlayAdInfo_, __args);
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdClicked
	public partial class AdClickedEventArgs : global::System.EventArgs {
		public AdClickedEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo;

		public global::Com.Unity3d.Mediation.LevelPlayAdInfo AdInfo {
			get { return adInfo; }
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdCollapsed
	public partial class AdCollapsedEventArgs : global::System.EventArgs {
		public AdCollapsedEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo;

		public global::Com.Unity3d.Mediation.LevelPlayAdInfo AdInfo {
			get { return adInfo; }
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdDisplayFailed
	public partial class AdDisplayFailedEventArgs : global::System.EventArgs {
		public AdDisplayFailedEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo, global::Com.Unity3d.Mediation.LevelPlayAdError error)
		{
			this.adInfo = adInfo;
			this.error = error;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo;

		public global::Com.Unity3d.Mediation.LevelPlayAdInfo AdInfo {
			get { return adInfo; }
		}

		global::Com.Unity3d.Mediation.LevelPlayAdError error;

		public global::Com.Unity3d.Mediation.LevelPlayAdError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdDisplayed
	public partial class AdDisplayedEventArgs : global::System.EventArgs {
		public AdDisplayedEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo;

		public global::Com.Unity3d.Mediation.LevelPlayAdInfo AdInfo {
			get { return adInfo; }
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdExpanded
	public partial class AdExpandedEventArgs : global::System.EventArgs {
		public AdExpandedEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo;

		public global::Com.Unity3d.Mediation.LevelPlayAdInfo AdInfo {
			get { return adInfo; }
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdLeftApplication
	public partial class AdLeftApplicationEventArgs : global::System.EventArgs {
		public AdLeftApplicationEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo;

		public global::Com.Unity3d.Mediation.LevelPlayAdInfo AdInfo {
			get { return adInfo; }
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdLoadFailed
	public partial class AdLoadFailedEventArgs : global::System.EventArgs {
		public AdLoadFailedEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdError error)
		{
			this.error = error;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdError error;

		public global::Com.Unity3d.Mediation.LevelPlayAdError Error {
			get { return error; }
		}

	}

	// event args for com.unity3d.mediation.banner.LevelPlayBannerAdViewListener.onAdLoaded
	public partial class AdLoadedEventArgs : global::System.EventArgs {
		public AdLoadedEventArgs (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			this.adInfo = adInfo;
		}

		global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo;

		public global::Com.Unity3d.Mediation.LevelPlayAdInfo AdInfo {
			get { return adInfo; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/mediation/banner/LevelPlayBannerAdViewListenerImplementor")]
	internal sealed partial class ILevelPlayBannerAdViewListenerImplementor : global::Java.Lang.Object, ILevelPlayBannerAdViewListener {

		object sender;

		public unsafe ILevelPlayBannerAdViewListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<AdClickedEventArgs> OnAdClickedHandler;
		#pragma warning restore 0649

		public void OnAdClicked (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			var __h = OnAdClickedHandler;
			if (__h != null)
				__h (sender, new AdClickedEventArgs (adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<AdCollapsedEventArgs> OnAdCollapsedHandler;
		#pragma warning restore 0649

		public void OnAdCollapsed (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			var __h = OnAdCollapsedHandler;
			if (__h != null)
				__h (sender, new AdCollapsedEventArgs (adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<AdDisplayFailedEventArgs> OnAdDisplayFailedHandler;
		#pragma warning restore 0649

		public void OnAdDisplayFailed (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo, global::Com.Unity3d.Mediation.LevelPlayAdError error)
		{
			var __h = OnAdDisplayFailedHandler;
			if (__h != null)
				__h (sender, new AdDisplayFailedEventArgs (adInfo, error));
		}

		#pragma warning disable 0649
		public EventHandler<AdDisplayedEventArgs> OnAdDisplayedHandler;
		#pragma warning restore 0649

		public void OnAdDisplayed (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			var __h = OnAdDisplayedHandler;
			if (__h != null)
				__h (sender, new AdDisplayedEventArgs (adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<AdExpandedEventArgs> OnAdExpandedHandler;
		#pragma warning restore 0649

		public void OnAdExpanded (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			var __h = OnAdExpandedHandler;
			if (__h != null)
				__h (sender, new AdExpandedEventArgs (adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<AdLeftApplicationEventArgs> OnAdLeftApplicationHandler;
		#pragma warning restore 0649

		public void OnAdLeftApplication (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			var __h = OnAdLeftApplicationHandler;
			if (__h != null)
				__h (sender, new AdLeftApplicationEventArgs (adInfo));
		}

		#pragma warning disable 0649
		public EventHandler<AdLoadFailedEventArgs> OnAdLoadFailedHandler;
		#pragma warning restore 0649

		public void OnAdLoadFailed (global::Com.Unity3d.Mediation.LevelPlayAdError error)
		{
			var __h = OnAdLoadFailedHandler;
			if (__h != null)
				__h (sender, new AdLoadFailedEventArgs (error));
		}

		#pragma warning disable 0649
		public EventHandler<AdLoadedEventArgs> OnAdLoadedHandler;
		#pragma warning restore 0649

		public void OnAdLoaded (global::Com.Unity3d.Mediation.LevelPlayAdInfo adInfo)
		{
			var __h = OnAdLoadedHandler;
			if (__h != null)
				__h (sender, new AdLoadedEventArgs (adInfo));
		}

		internal static bool __IsEmpty (ILevelPlayBannerAdViewListenerImplementor value)
		{
			return value.OnAdClickedHandler == null && value.OnAdCollapsedHandler == null && value.OnAdDisplayFailedHandler == null && value.OnAdDisplayedHandler == null && value.OnAdExpandedHandler == null && value.OnAdLeftApplicationHandler == null && value.OnAdLoadFailedHandler == null && value.OnAdLoadedHandler == null;
		}

	}
}
