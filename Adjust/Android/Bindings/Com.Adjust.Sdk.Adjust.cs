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

namespace Com.Adjust.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']"
	[global::Android.Runtime.Register ("com/adjust/sdk/Adjust", DoNotGenerateAcw=true)]
	public partial class Adjust : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/Adjust", typeof (Adjust));

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

		protected Adjust (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe string Adid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='getAdid' and count(parameter)=0]"
			[Register ("getAdid", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAdid.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Adjust.Sdk.AdjustAttribution Attribution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='getAttribution' and count(parameter)=0]"
			[Register ("getAttribution", "()Lcom/adjust/sdk/AdjustAttribution;", "")]
			get {
				const string __id = "getAttribution.()Lcom/adjust/sdk/AdjustAttribution;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustAttribution> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Adjust.Sdk.AdjustInstance DefaultInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='getDefaultInstance' and count(parameter)=0]"
			[Register ("getDefaultInstance", "()Lcom/adjust/sdk/AdjustInstance;", "")]
			get {
				const string __id = "getDefaultInstance.()Lcom/adjust/sdk/AdjustInstance;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustInstance> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "")]
			get {
				const string __id = "isEnabled.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "")]
			set {
				const string __id = "setEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSdkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='addSessionCallbackParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addSessionCallbackParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddSessionCallbackParameter (string p0, string p1)
		{
			const string __id = "addSessionCallbackParameter.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='addSessionPartnerParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addSessionPartnerParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddSessionPartnerParameter (string p0, string p1)
		{
			const string __id = "addSessionPartnerParameter.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='appWillOpenUrl' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("appWillOpenUrl", "(Landroid/net/Uri;)V", "")]
		public static unsafe void AppWillOpenUrl (global::Android.Net.Uri p0)
		{
			const string __id = "appWillOpenUrl.(Landroid/net/Uri;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='appWillOpenUrl' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.Context']]"
		[Register ("appWillOpenUrl", "(Landroid/net/Uri;Landroid/content/Context;)V", "")]
		public static unsafe void AppWillOpenUrl (global::Android.Net.Uri p0, global::Android.Content.Context p1)
		{
			const string __id = "appWillOpenUrl.(Landroid/net/Uri;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='disableThirdPartySharing' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disableThirdPartySharing", "(Landroid/content/Context;)V", "")]
		public static unsafe void DisableThirdPartySharing (global::Android.Content.Context p0)
		{
			const string __id = "disableThirdPartySharing.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='gdprForgetMe' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("gdprForgetMe", "(Landroid/content/Context;)V", "")]
		public static unsafe void GdprForgetMe (global::Android.Content.Context p0)
		{
			const string __id = "gdprForgetMe.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='getAmazonAdId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAmazonAdId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAmazonAdId (global::Android.Content.Context p0)
		{
			const string __id = "getAmazonAdId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='getGoogleAdId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.adjust.sdk.OnDeviceIdsRead']]"
		[Register ("getGoogleAdId", "(Landroid/content/Context;Lcom/adjust/sdk/OnDeviceIdsRead;)V", "")]
		public static unsafe void GetGoogleAdId (global::Android.Content.Context p0, global::Com.Adjust.Sdk.IOnDeviceIdsRead p1)
		{
			const string __id = "getGoogleAdId.(Landroid/content/Context;Lcom/adjust/sdk/OnDeviceIdsRead;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='isAdjustUninstallDetectionPayload' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("isAdjustUninstallDetectionPayload", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool IsAdjustUninstallDetectionPayload (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			const string __id = "isAdjustUninstallDetectionPayload.(Ljava/util/Map;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustConfig']]"
		[Register ("onCreate", "(Lcom/adjust/sdk/AdjustConfig;)V", "")]
		public static unsafe void OnCreate (global::Com.Adjust.Sdk.AdjustConfig p0)
		{
			const string __id = "onCreate.(Lcom/adjust/sdk/AdjustConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "")]
		public static unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "")]
		public static unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='processDeeplink' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.adjust.sdk.OnDeeplinkResolvedListener']]"
		[Register ("processDeeplink", "(Landroid/net/Uri;Landroid/content/Context;Lcom/adjust/sdk/OnDeeplinkResolvedListener;)V", "")]
		public static unsafe void ProcessDeeplink (global::Android.Net.Uri p0, global::Android.Content.Context p1, global::Com.Adjust.Sdk.IOnDeeplinkResolvedListener p2)
		{
			const string __id = "processDeeplink.(Landroid/net/Uri;Landroid/content/Context;Lcom/adjust/sdk/OnDeeplinkResolvedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='removeSessionCallbackParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeSessionCallbackParameter", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveSessionCallbackParameter (string p0)
		{
			const string __id = "removeSessionCallbackParameter.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='removeSessionPartnerParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeSessionPartnerParameter", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveSessionPartnerParameter (string p0)
		{
			const string __id = "removeSessionPartnerParameter.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='resetSessionCallbackParameters' and count(parameter)=0]"
		[Register ("resetSessionCallbackParameters", "()V", "")]
		public static unsafe void ResetSessionCallbackParameters ()
		{
			const string __id = "resetSessionCallbackParameters.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='resetSessionPartnerParameters' and count(parameter)=0]"
		[Register ("resetSessionPartnerParameters", "()V", "")]
		public static unsafe void ResetSessionPartnerParameters ()
		{
			const string __id = "resetSessionPartnerParameters.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='sendFirstPackages' and count(parameter)=0]"
		[Register ("sendFirstPackages", "()V", "")]
		public static unsafe void SendFirstPackages ()
		{
			const string __id = "sendFirstPackages.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='setOfflineMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOfflineMode", "(Z)V", "")]
		public static unsafe void SetOfflineMode (bool p0)
		{
			const string __id = "setOfflineMode.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='setPushToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("setPushToken", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetPushToken (string p0)
		{
			const string __id = "setPushToken.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='setPushToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("setPushToken", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void SetPushToken (string p0, global::Android.Content.Context p1)
		{
			const string __id = "setPushToken.(Ljava/lang/String;Landroid/content/Context;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='setReferrer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("setReferrer", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void SetReferrer (string p0, global::Android.Content.Context p1)
		{
			const string __id = "setReferrer.(Ljava/lang/String;Landroid/content/Context;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='setTestOptions' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustTestOptions']]"
		[Register ("setTestOptions", "(Lcom/adjust/sdk/AdjustTestOptions;)V", "")]
		public static unsafe void SetTestOptions (global::Com.Adjust.Sdk.AdjustTestOptions p0)
		{
			const string __id = "setTestOptions.(Lcom/adjust/sdk/AdjustTestOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='trackAdRevenue' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustAdRevenue']]"
		[Register ("trackAdRevenue", "(Lcom/adjust/sdk/AdjustAdRevenue;)V", "")]
		public static unsafe void TrackAdRevenue (global::Com.Adjust.Sdk.AdjustAdRevenue p0)
		{
			const string __id = "trackAdRevenue.(Lcom/adjust/sdk/AdjustAdRevenue;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='trackAdRevenue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("trackAdRevenue", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public static unsafe void TrackAdRevenue (string p0, global::Org.Json.JSONObject p1)
		{
			const string __id = "trackAdRevenue.(Ljava/lang/String;Lorg/json/JSONObject;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='trackEvent' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustEvent']]"
		[Register ("trackEvent", "(Lcom/adjust/sdk/AdjustEvent;)V", "")]
		public static unsafe void TrackEvent (global::Com.Adjust.Sdk.AdjustEvent p0)
		{
			const string __id = "trackEvent.(Lcom/adjust/sdk/AdjustEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='trackMeasurementConsent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("trackMeasurementConsent", "(Z)V", "")]
		public static unsafe void TrackMeasurementConsent (bool p0)
		{
			const string __id = "trackMeasurementConsent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='trackPlayStoreSubscription' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustPlayStoreSubscription']]"
		[Register ("trackPlayStoreSubscription", "(Lcom/adjust/sdk/AdjustPlayStoreSubscription;)V", "")]
		public static unsafe void TrackPlayStoreSubscription (global::Com.Adjust.Sdk.AdjustPlayStoreSubscription p0)
		{
			const string __id = "trackPlayStoreSubscription.(Lcom/adjust/sdk/AdjustPlayStoreSubscription;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='trackThirdPartySharing' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustThirdPartySharing']]"
		[Register ("trackThirdPartySharing", "(Lcom/adjust/sdk/AdjustThirdPartySharing;)V", "")]
		public static unsafe void TrackThirdPartySharing (global::Com.Adjust.Sdk.AdjustThirdPartySharing p0)
		{
			const string __id = "trackThirdPartySharing.(Lcom/adjust/sdk/AdjustThirdPartySharing;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='Adjust']/method[@name='verifyPurchase' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.AdjustPurchase'] and parameter[2][@type='com.adjust.sdk.OnPurchaseVerificationFinishedListener']]"
		[Register ("verifyPurchase", "(Lcom/adjust/sdk/AdjustPurchase;Lcom/adjust/sdk/OnPurchaseVerificationFinishedListener;)V", "")]
		public static unsafe void VerifyPurchase (global::Com.Adjust.Sdk.AdjustPurchase p0, global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener p1)
		{
			const string __id = "verifyPurchase.(Lcom/adjust/sdk/AdjustPurchase;Lcom/adjust/sdk/OnPurchaseVerificationFinishedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}