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

namespace Com.Unity3d.IronSourceAds {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest']"
	[global::Android.Runtime.Register ("com/unity3d/ironsourceads/InitRequest", DoNotGenerateAcw=true)]
	public sealed partial class InitRequest : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest.Builder']"
		[global::Android.Runtime.Register ("com/unity3d/ironsourceads/InitRequest$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/InitRequest$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest.Builder']/constructor[@name='InitRequest.Builder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Builder (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString ((string)p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			public unsafe string AppKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest.Builder']/method[@name='getAppKey' and count(parameter)=0]"
				[Register ("getAppKey", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getAppKey.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/unity3d/ironsourceads/InitRequest;", "")]
			public unsafe global::Com.Unity3d.IronSourceAds.InitRequest Build ()
			{
				const string __id = "build.()Lcom/unity3d/ironsourceads/InitRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.InitRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest.Builder']/method[@name='withLegacyAdFormats' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.unity3d.ironsourceads.IronSourceAds.AdFormat&gt;']]"
			[Register ("withLegacyAdFormats", "(Ljava/util/List;)Lcom/unity3d/ironsourceads/InitRequest$Builder;", "")]
			public unsafe global::Com.Unity3d.IronSourceAds.InitRequest.Builder WithLegacyAdFormats (global::System.Collections.Generic.IList<global::Com.Unity3d.IronSourceAds.IronSourceAds.AdFormat> legacyAdFormats)
			{
				const string __id = "withLegacyAdFormats.(Ljava/util/List;)Lcom/unity3d/ironsourceads/InitRequest$Builder;";
				IntPtr native_legacyAdFormats = global::Android.Runtime.JavaList<global::Com.Unity3d.IronSourceAds.IronSourceAds.AdFormat>.ToLocalJniHandle (legacyAdFormats);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_legacyAdFormats);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.InitRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_legacyAdFormats);
					global::System.GC.KeepAlive (legacyAdFormats);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest.Builder']/method[@name='withLogLevel' and count(parameter)=1 and parameter[1][@type='com.unity3d.ironsourceads.LogLevel']]"
			[Register ("withLogLevel", "(Lcom/unity3d/ironsourceads/LogLevel;)Lcom/unity3d/ironsourceads/InitRequest$Builder;", "")]
			public unsafe global::Com.Unity3d.IronSourceAds.InitRequest.Builder WithLogLevel (global::Com.Unity3d.IronSourceAds.LogLevel logLevel)
			{
				const string __id = "withLogLevel.(Lcom/unity3d/ironsourceads/LogLevel;)Lcom/unity3d/ironsourceads/InitRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.InitRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (logLevel);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/ironsourceads/InitRequest", typeof (InitRequest));

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

		internal InitRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest']/constructor[@name='InitRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.unity3d.ironsourceads.LogLevel'] and parameter[4][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Lcom/unity3d/ironsourceads/LogLevel;Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe InitRequest (string p0, global::System.Collections.IList p1, global::Com.Unity3d.IronSourceAds.LogLevel p2, global::Kotlin.Jvm.Internal.DefaultConstructorMarker p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/List;Lcom/unity3d/ironsourceads/LogLevel;Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		public unsafe string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAppKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Unity3d.IronSourceAds.IronSourceAds.AdFormat> LegacyAdFormats {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest']/method[@name='getLegacyAdFormats' and count(parameter)=0]"
			[Register ("getLegacyAdFormats", "()Ljava/util/List;", "")]
			get {
				const string __id = "getLegacyAdFormats.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Unity3d.IronSourceAds.IronSourceAds.AdFormat>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Unity3d.IronSourceAds.LogLevel LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.ironsourceads']/class[@name='InitRequest']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lcom/unity3d/ironsourceads/LogLevel;", "")]
			get {
				const string __id = "getLogLevel.()Lcom/unity3d/ironsourceads/LogLevel;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.IronSourceAds.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}