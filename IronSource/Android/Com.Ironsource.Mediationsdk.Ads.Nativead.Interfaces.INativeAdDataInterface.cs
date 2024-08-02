using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdDataInterface']"
	[Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdDataInterface", "", "Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterfaceInvoker")]
	public partial interface INativeAdDataInterface : IJavaObject, IJavaPeerable {
		string Advertiser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdDataInterface']/method[@name='getAdvertiser' and count(parameter)=0]"
			[Register ("getAdvertiser", "()Ljava/lang/String;", "GetGetAdvertiserHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterfaceInvoker, MatchSolitaire.Android")]
			get; 
		}

		string Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdDataInterface']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/String;", "GetGetBodyHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterfaceInvoker, MatchSolitaire.Android")]
			get; 
		}

		string CallToAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdDataInterface']/method[@name='getCallToAction' and count(parameter)=0]"
			[Register ("getCallToAction", "()Ljava/lang/String;", "GetGetCallToActionHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterfaceInvoker, MatchSolitaire.Android")]
			get; 
		}

		global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface.Image Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdDataInterface']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdDataInterface$Image;", "GetGetIconHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterfaceInvoker, MatchSolitaire.Android")]
			get; 
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/interface[@name='NativeAdDataInterface']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterfaceInvoker, MatchSolitaire.Android")]
			get; 
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/class[@name='NativeAdDataInterface.Image']"
		[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdDataInterface$Image", DoNotGenerateAcw=true)]
		public partial class Image : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdDataInterface$Image", typeof (Image));

			internal static IntPtr class_ref {
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
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Image (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/class[@name='NativeAdDataInterface.Image']/constructor[@name='NativeAdDataInterface.Image' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.net.Uri']]"
			[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Landroid/net/Uri;)V", "")]
			public unsafe Image (global::Android.Graphics.Drawables.Drawable p0, global::Android.Net.Uri p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/graphics/drawable/Drawable;Landroid/net/Uri;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			public unsafe global::Android.Graphics.Drawables.Drawable Drawable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/class[@name='NativeAdDataInterface.Image']/method[@name='getDrawable' and count(parameter)=0]"
				[Register ("getDrawable", "()Landroid/graphics/drawable/Drawable;", "")]
				get {
					const string __id = "getDrawable.()Landroid/graphics/drawable/Drawable;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Android.Net.Uri Uri {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.interfaces']/class[@name='NativeAdDataInterface.Image']/method[@name='getUri' and count(parameter)=0]"
				[Register ("getUri", "()Landroid/net/Uri;", "")]
				get {
					const string __id = "getUri.()Landroid/net/Uri;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdDataInterface", DoNotGenerateAcw=true)]
	internal partial class INativeAdDataInterfaceInvoker : global::Java.Lang.Object, INativeAdDataInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdDataInterface", typeof (INativeAdDataInterfaceInvoker));

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

		public static INativeAdDataInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdDataInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ironsource.mediationsdk.ads.nativead.interfaces.NativeAdDataInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdDataInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdvertiser;
#pragma warning disable 0169
		static Delegate GetGetAdvertiserHandler ()
		{
			if (cb_getAdvertiser == null)
				cb_getAdvertiser = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAdvertiser));
			return cb_getAdvertiser;
		}

		static IntPtr n_GetAdvertiser (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Advertiser);
		}
#pragma warning restore 0169

		IntPtr id_getAdvertiser;
		public unsafe string Advertiser {
			get {
				if (id_getAdvertiser == IntPtr.Zero)
					id_getAdvertiser = JNIEnv.GetMethodID (class_ref, "getAdvertiser", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdvertiser), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetBody));
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Body);
		}
#pragma warning restore 0169

		IntPtr id_getBody;
		public unsafe string Body {
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCallToAction;
#pragma warning disable 0169
		static Delegate GetGetCallToActionHandler ()
		{
			if (cb_getCallToAction == null)
				cb_getCallToAction = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCallToAction));
			return cb_getCallToAction;
		}

		static IntPtr n_GetCallToAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallToAction);
		}
#pragma warning restore 0169

		IntPtr id_getCallToAction;
		public unsafe string CallToAction {
			get {
				if (id_getCallToAction == IntPtr.Zero)
					id_getCallToAction = JNIEnv.GetMethodID (class_ref, "getCallToAction", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallToAction), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIcon));
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		IntPtr id_getIcon;
		public unsafe global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface.Image Icon {
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Lcom/ironsource/mediationsdk/ads/nativead/interfaces/NativeAdDataInterface$Image;");
				return global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface.Image> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTitle));
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces.INativeAdDataInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public unsafe string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
