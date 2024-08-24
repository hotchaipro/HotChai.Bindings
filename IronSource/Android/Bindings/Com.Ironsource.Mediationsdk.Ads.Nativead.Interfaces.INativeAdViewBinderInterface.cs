using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdViewBinderInterface']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdViewBinderInterface", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterfaceInvoker")]
	public partial interface INativeAdViewBinderInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdViewBinderInterface']/method[@name='setAdvertiserView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setAdvertiserView", "(Landroid/view/View;)V", "GetSetAdvertiserView_Landroid_view_View_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterfaceInvoker, MatchSolitaire.Android")]
		void SetAdvertiserView (global::Android.Views.View view);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdViewBinderInterface']/method[@name='setBodyView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setBodyView", "(Landroid/view/View;)V", "GetSetBodyView_Landroid_view_View_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterfaceInvoker, MatchSolitaire.Android")]
		void SetBodyView (global::Android.Views.View view);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdViewBinderInterface']/method[@name='setCallToActionView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setCallToActionView", "(Landroid/view/View;)V", "GetSetCallToActionView_Landroid_view_View_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterfaceInvoker, MatchSolitaire.Android")]
		void SetCallToActionView (global::Android.Views.View view);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdViewBinderInterface']/method[@name='setIconView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setIconView", "(Landroid/view/View;)V", "GetSetIconView_Landroid_view_View_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterfaceInvoker, MatchSolitaire.Android")]
		void SetIconView (global::Android.Views.View view);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdViewBinderInterface']/method[@name='setMediaView' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.ads.nativead.LevelPlayMediaView']]"
		[Register ("setMediaView", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayMediaView;)V", "GetSetMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterfaceInvoker, MatchSolitaire.Android")]
		void SetMediaView (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayMediaView mediaView);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdViewBinderInterface']/method[@name='setTitleView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setTitleView", "(Landroid/view/View;)V", "GetSetTitleView_Landroid_view_View_Handler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterfaceInvoker, MatchSolitaire.Android")]
		void SetTitleView (global::Android.Views.View view);

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdViewBinderInterface", DoNotGenerateAcw=true)]
	internal partial class INativeAdViewBinderInterfaceInvoker : global::Java.Lang.Object, INativeAdViewBinderInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdViewBinderInterface", typeof (INativeAdViewBinderInterfaceInvoker));

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

		public static INativeAdViewBinderInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdViewBinderInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdViewBinderInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdViewBinderInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setAdvertiserView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetAdvertiserView_Landroid_view_View_Handler ()
		{
			if (cb_setAdvertiserView_Landroid_view_View_ == null)
				cb_setAdvertiserView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetAdvertiserView_Landroid_view_View_));
			return cb_setAdvertiserView_Landroid_view_View_;
		}

		static void n_SetAdvertiserView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetAdvertiserView (view);
		}
#pragma warning restore 0169

		IntPtr id_setAdvertiserView_Landroid_view_View_;
		public unsafe void SetAdvertiserView (global::Android.Views.View view)
		{
			if (id_setAdvertiserView_Landroid_view_View_ == IntPtr.Zero)
				id_setAdvertiserView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setAdvertiserView", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdvertiserView_Landroid_view_View_, __args);
		}

		static Delegate cb_setBodyView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetBodyView_Landroid_view_View_Handler ()
		{
			if (cb_setBodyView_Landroid_view_View_ == null)
				cb_setBodyView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetBodyView_Landroid_view_View_));
			return cb_setBodyView_Landroid_view_View_;
		}

		static void n_SetBodyView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetBodyView (view);
		}
#pragma warning restore 0169

		IntPtr id_setBodyView_Landroid_view_View_;
		public unsafe void SetBodyView (global::Android.Views.View view)
		{
			if (id_setBodyView_Landroid_view_View_ == IntPtr.Zero)
				id_setBodyView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setBodyView", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBodyView_Landroid_view_View_, __args);
		}

		static Delegate cb_setCallToActionView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCallToActionView_Landroid_view_View_Handler ()
		{
			if (cb_setCallToActionView_Landroid_view_View_ == null)
				cb_setCallToActionView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCallToActionView_Landroid_view_View_));
			return cb_setCallToActionView_Landroid_view_View_;
		}

		static void n_SetCallToActionView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetCallToActionView (view);
		}
#pragma warning restore 0169

		IntPtr id_setCallToActionView_Landroid_view_View_;
		public unsafe void SetCallToActionView (global::Android.Views.View view)
		{
			if (id_setCallToActionView_Landroid_view_View_ == IntPtr.Zero)
				id_setCallToActionView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCallToActionView", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallToActionView_Landroid_view_View_, __args);
		}

		static Delegate cb_setIconView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetIconView_Landroid_view_View_Handler ()
		{
			if (cb_setIconView_Landroid_view_View_ == null)
				cb_setIconView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetIconView_Landroid_view_View_));
			return cb_setIconView_Landroid_view_View_;
		}

		static void n_SetIconView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetIconView (view);
		}
#pragma warning restore 0169

		IntPtr id_setIconView_Landroid_view_View_;
		public unsafe void SetIconView (global::Android.Views.View view)
		{
			if (id_setIconView_Landroid_view_View_ == IntPtr.Zero)
				id_setIconView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setIconView", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconView_Landroid_view_View_, __args);
		}

		static Delegate cb_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_;
#pragma warning disable 0169
		static Delegate GetSetMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_Handler ()
		{
			if (cb_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_ == null)
				cb_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_));
			return cb_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_;
		}

		static void n_SetMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mediaView = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayMediaView> (native_mediaView, JniHandleOwnership.DoNotTransfer);
			__this.SetMediaView (mediaView);
		}
#pragma warning restore 0169

		IntPtr id_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_;
		public unsafe void SetMediaView (global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayMediaView mediaView)
		{
			if (id_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_ == IntPtr.Zero)
				id_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_ = JNIEnv.GetMethodID (class_ref, "setMediaView", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayMediaView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((mediaView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaView).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediaView_Lcom_ironsource_mediationsdk_ads_nativead_LevelPlayMediaView_, __args);
		}

		static Delegate cb_setTitleView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetTitleView_Landroid_view_View_Handler ()
		{
			if (cb_setTitleView_Landroid_view_View_ == null)
				cb_setTitleView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetTitleView_Landroid_view_View_));
			return cb_setTitleView_Landroid_view_View_;
		}

		static void n_SetTitleView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdViewBinderInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleView (view);
		}
#pragma warning restore 0169

		IntPtr id_setTitleView_Landroid_view_View_;
		public unsafe void SetTitleView (global::Android.Views.View view)
		{
			if (id_setTitleView_Landroid_view_View_ == IntPtr.Zero)
				id_setTitleView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setTitleView", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitleView_Landroid_view_View_, __args);
		}

	}
}
