//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.IronSource.MediationSdk.Ads.NativeAd.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']"
	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/ads/nativead/internal/NativeAdViewHolder", DoNotGenerateAcw=true)]
	public sealed partial class NativeAdViewHolder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/ads/nativead/internal/NativeAdViewHolder", typeof (NativeAdViewHolder));

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

		internal NativeAdViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/constructor[@name='NativeAdViewHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NativeAdViewHolder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public unsafe global::Android.Views.View AdvertiserView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='getAdvertiserView' and count(parameter)=0]"
			[Register ("getAdvertiserView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getAdvertiserView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='setAdvertiserView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setAdvertiserView", "(Landroid/view/View;)V", "")]
			set {
				const string __id = "setAdvertiserView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Android.Views.View BodyView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='getBodyView' and count(parameter)=0]"
			[Register ("getBodyView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getBodyView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='setBodyView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setBodyView", "(Landroid/view/View;)V", "")]
			set {
				const string __id = "setBodyView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Android.Views.View CallToActionView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='getCallToActionView' and count(parameter)=0]"
			[Register ("getCallToActionView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getCallToActionView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='setCallToActionView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setCallToActionView", "(Landroid/view/View;)V", "")]
			set {
				const string __id = "setCallToActionView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Android.Views.View IconView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='getIconView' and count(parameter)=0]"
			[Register ("getIconView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getIconView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='setIconView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setIconView", "(Landroid/view/View;)V", "")]
			set {
				const string __id = "setIconView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayMediaView MediaView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='getMediaView' and count(parameter)=0]"
			[Register ("getMediaView", "()Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayMediaView;", "")]
			get {
				const string __id = "getMediaView.()Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayMediaView;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Ads.NativeAd.LevelPlayMediaView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='setMediaView' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.ads.nativead.LevelPlayMediaView']]"
			[Register ("setMediaView", "(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayMediaView;)V", "")]
			set {
				const string __id = "setMediaView.(Lcom/ironsource/mediationsdk/ads/nativead/LevelPlayMediaView;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Android.Views.View TitleView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='getTitleView' and count(parameter)=0]"
			[Register ("getTitleView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getTitleView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.ads.nativead.internal']/class[@name='NativeAdViewHolder']/method[@name='setTitleView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setTitleView", "(Landroid/view/View;)V", "")]
			set {
				const string __id = "setTitleView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
