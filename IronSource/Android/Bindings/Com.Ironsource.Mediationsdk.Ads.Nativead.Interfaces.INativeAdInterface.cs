using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdInterface']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdInterface", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInterfaceInvoker")]
	public partial interface INativeAdInterface : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdInterface']/method[@name='destroyAd' and count(parameter)=0]"
		[Register ("destroyAd", "()V", "GetDestroyAdHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInterfaceInvoker, MatchSolitaire.Android")]
		void DestroyAd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdInterface']/method[@name='loadAd' and count(parameter)=0]"
		[Register ("loadAd", "()V", "GetLoadAdHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInterfaceInvoker, MatchSolitaire.Android")]
		void LoadAd ();

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdInterface", DoNotGenerateAcw=true)]
	internal partial class INativeAdInterfaceInvoker : global::Java.Lang.Object, INativeAdInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdInterface", typeof (INativeAdInterfaceInvoker));

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

		public static INativeAdInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_destroyAd;
#pragma warning disable 0169
		static Delegate GetDestroyAdHandler ()
		{
			if (cb_destroyAd == null)
				cb_destroyAd = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_DestroyAd));
			return cb_destroyAd;
		}

		static void n_DestroyAd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyAd ();
		}
#pragma warning restore 0169

		IntPtr id_destroyAd;
		public unsafe void DestroyAd ()
		{
			if (id_destroyAd == IntPtr.Zero)
				id_destroyAd = JNIEnv.GetMethodID (class_ref, "destroyAd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyAd);
		}

		static Delegate cb_loadAd;
#pragma warning disable 0169
		static Delegate GetLoadAdHandler ()
		{
			if (cb_loadAd == null)
				cb_loadAd = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LoadAd));
			return cb_loadAd;
		}

		static void n_LoadAd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd ();
		}
#pragma warning restore 0169

		IntPtr id_loadAd;
		public unsafe void LoadAd ()
		{
			if (id_loadAd == IntPtr.Zero)
				id_loadAd = JNIEnv.GetMethodID (class_ref, "loadAd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd);
		}

	}
}
