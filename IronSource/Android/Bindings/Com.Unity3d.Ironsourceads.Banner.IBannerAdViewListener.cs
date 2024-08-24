using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.IronSourceAds.Banner {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/interface[@name='BannerAdViewListener']"
	[Register ("com/unity3d/ironsourceads/banner/BannerAdViewListener", "", "Com.Unity3d.IronSourceAds.Banner.IBannerAdViewListenerInvoker")]
	public partial interface IBannerAdViewListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/interface[@name='BannerAdViewListener']/method[@name='onBannerAdClicked' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.banner.BannerAdView']]"
		[Register ("onBannerAdClicked", "(Lcom/unity3d/ironsourceads/banner/BannerAdView;)V", "GetOnBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_Handler:Com.Unity3d.IronSourceAds.Banner.IBannerAdViewListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdClicked (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/interface[@name='BannerAdViewListener']/method[@name='onBannerAdShown' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.banner.BannerAdView']]"
		[Register ("onBannerAdShown", "(Lcom/unity3d/ironsourceads/banner/BannerAdView;)V", "GetOnBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_Handler:Com.Unity3d.IronSourceAds.Banner.IBannerAdViewListenerInvoker, MatchSolitaire.Android")]
		void OnBannerAdShown (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd);

	}

	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/banner/BannerAdViewListener", DoNotGenerateAcw=true)]
	internal partial class IBannerAdViewListenerInvoker : global::Java.Lang.Object, IBannerAdViewListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/banner/BannerAdViewListener", typeof (IBannerAdViewListenerInvoker));

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

		public static IBannerAdViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBannerAdViewListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.unity3d.ironsourceads.banner.BannerAdViewListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBannerAdViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_Handler ()
		{
			if (cb_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_ == null)
				cb_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_));
			return cb_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
		}

		static void n_OnBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.IBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bannerAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.BannerAdView> (native_bannerAd, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdClicked (bannerAd);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
		public unsafe void OnBannerAdClicked (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd)
		{
			if (id_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_ == IntPtr.Zero)
				id_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_ = JNIEnv.GetMethodID (class_ref, "onBannerAdClicked", "(Lcom/unity3d/ironsourceads/banner/BannerAdView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((bannerAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bannerAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdClicked_Lcom_unity3d_ironsourceads_banner_BannerAdView_, __args);
		}

		static Delegate cb_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
#pragma warning disable 0169
		static Delegate GetOnBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_Handler ()
		{
			if (cb_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_ == null)
				cb_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_));
			return cb_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
		}

		static void n_OnBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bannerAd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.IBannerAdViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bannerAd = global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.BannerAdView> (native_bannerAd, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerAdShown (bannerAd);
		}
#pragma warning restore 0169

		IntPtr id_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_;
		public unsafe void OnBannerAdShown (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd)
		{
			if (id_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_ == IntPtr.Zero)
				id_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_ = JNIEnv.GetMethodID (class_ref, "onBannerAdShown", "(Lcom/unity3d/ironsourceads/banner/BannerAdView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((bannerAd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bannerAd).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerAdShown_Lcom_unity3d_ironsourceads_banner_BannerAdView_, __args);
		}

	}

	// event args for com.unity3d.ironsourceads.banner.BannerAdViewListener.onBannerAdClicked
	public partial class BannerAdClickedEventArgs : global::System.EventArgs {
		public BannerAdClickedEventArgs (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd)
		{
			this.bannerAd = bannerAd;
		}

		global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd;

		public global::Com.Unity3d.IronSourceAds.Banner.BannerAdView BannerAd {
			get { return bannerAd; }
		}

	}

	// event args for com.unity3d.ironsourceads.banner.BannerAdViewListener.onBannerAdShown
	public partial class BannerAdShownEventArgs : global::System.EventArgs {
		public BannerAdShownEventArgs (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd)
		{
			this.bannerAd = bannerAd;
		}

		global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd;

		public global::Com.Unity3d.IronSourceAds.Banner.BannerAdView BannerAd {
			get { return bannerAd; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/unity3d/ironsourceads/banner/BannerAdViewListenerImplementor")]
	internal sealed partial class IBannerAdViewListenerImplementor : global::Java.Lang.Object, IBannerAdViewListener {

		object sender;

		public unsafe IBannerAdViewListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<BannerAdClickedEventArgs> OnBannerAdClickedHandler;
		#pragma warning restore 0649

		public void OnBannerAdClicked (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd)
		{
			var __h = OnBannerAdClickedHandler;
			if (__h != null)
				__h (sender, new BannerAdClickedEventArgs (bannerAd));
		}

		#pragma warning disable 0649
		public EventHandler<BannerAdShownEventArgs> OnBannerAdShownHandler;
		#pragma warning restore 0649

		public void OnBannerAdShown (global::Com.Unity3d.IronSourceAds.Banner.BannerAdView bannerAd)
		{
			var __h = OnBannerAdShownHandler;
			if (__h != null)
				__h (sender, new BannerAdShownEventArgs (bannerAd));
		}

		internal static bool __IsEmpty (IBannerAdViewListenerImplementor value)
		{
			return value.OnBannerAdClickedHandler == null && value.OnBannerAdShownHandler == null;
		}

	}
}
