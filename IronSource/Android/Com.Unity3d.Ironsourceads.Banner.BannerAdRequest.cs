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

namespace Com.Unity3d.IronSourceAds.Banner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest']"
	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/banner/BannerAdRequest", DoNotGenerateAcw=true)]
	public sealed partial class BannerAdRequest : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']"
		[global::Android.Runtime.Register ("com/unity3d/ironsourceads/banner/BannerAdRequest$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/banner/BannerAdRequest$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']/constructor[@name='BannerAdRequest.Builder' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.unity3d.ironsourceads.AdSize']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/ironsourceads/AdSize;)V", "")]
			public unsafe Builder (global::Android.Content.Context p0, string p1, string p2, global::Com.Unity3d.IronSourceAds.AdSize p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/ironsourceads/AdSize;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString ((string)p1);
				IntPtr native_p2 = JNIEnv.NewString ((string)p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p3);
				}
			}

			public unsafe string Adm {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']/method[@name='getAdm' and count(parameter)=0]"
				[Register ("getAdm", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getAdm.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Android.Content.Context Context {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']/method[@name='getContext' and count(parameter)=0]"
				[Register ("getContext", "()Landroid/content/Context;", "")]
				get {
					const string __id = "getContext.()Landroid/content/Context;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string InstanceId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']/method[@name='getInstanceId' and count(parameter)=0]"
				[Register ("getInstanceId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getInstanceId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Unity3d.IronSourceAds.AdSize Size {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']/method[@name='getSize' and count(parameter)=0]"
				[Register ("getSize", "()Lcom/unity3d/ironsourceads/AdSize;", "")]
				get {
					const string __id = "getSize.()Lcom/unity3d/ironsourceads/AdSize;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.AdSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/unity3d/ironsourceads/banner/BannerAdRequest;", "")]
			public unsafe global::Com.Unity3d.IronSourceAds.Banner.BannerAdRequest Build ()
			{
				const string __id = "build.()Lcom/unity3d/ironsourceads/banner/BannerAdRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.BannerAdRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest.Builder']/method[@name='withExtraParams' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("withExtraParams", "(Landroid/os/Bundle;)Lcom/unity3d/ironsourceads/banner/BannerAdRequest$Builder;", "")]
			public unsafe global::Com.Unity3d.IronSourceAds.Banner.BannerAdRequest.Builder WithExtraParams (global::Android.OS.Bundle extraParams)
			{
				const string __id = "withExtraParams.(Landroid/os/Bundle;)Lcom/unity3d/ironsourceads/banner/BannerAdRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((extraParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extraParams).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.Banner.BannerAdRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (extraParams);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/banner/BannerAdRequest", typeof (BannerAdRequest));

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

		internal BannerAdRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest']/constructor[@name='BannerAdRequest' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.unity3d.ironsourceads.AdSize'] and parameter[5][@type='android.os.Bundle'] and parameter[6][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/ironsourceads/AdSize;Landroid/os/Bundle;Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe BannerAdRequest (global::Android.Content.Context p0, string p1, string p2, global::Com.Unity3d.IronSourceAds.AdSize p3, global::Android.OS.Bundle p4, global::Kotlin.Jvm.Internal.DefaultConstructorMarker p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/ironsourceads/AdSize;Landroid/os/Bundle;Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
			}
		}

		public unsafe string Adm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest']/method[@name='getAdm' and count(parameter)=0]"
			[Register ("getAdm", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAdm.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.Bundle ExtraParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest']/method[@name='getExtraParams' and count(parameter)=0]"
			[Register ("getExtraParams", "()Landroid/os/Bundle;", "")]
			get {
				const string __id = "getExtraParams.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string InstanceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest']/method[@name='getInstanceId' and count(parameter)=0]"
			[Register ("getInstanceId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getInstanceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Unity3d.IronSourceAds.AdSize Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads.banner']/class[@name='BannerAdRequest']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Lcom/unity3d/ironsourceads/AdSize;", "")]
			get {
				const string __id = "getSize.()Lcom/unity3d/ironsourceads/AdSize;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.AdSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}