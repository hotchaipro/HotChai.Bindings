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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']"
	[global::Android.Runtime.Register ("com/adjust/sdk/PackageBuilder", DoNotGenerateAcw=true)]
	public partial class PackageBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/PackageBuilder", typeof (PackageBuilder));

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

		protected PackageBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='addBoolean' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Boolean']]"
		[Register ("addBoolean", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
		public static unsafe void AddBoolean (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, global::Java.Lang.Boolean p2)
		{
			const string __id = "addBoolean.(Ljava/util/Map;Ljava/lang/String;Ljava/lang/Boolean;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='addDouble' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("addDouble", "(Ljava/util/Map;Ljava/lang/String;D)V", "")]
		public static unsafe void AddDouble (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, double p2)
		{
			const string __id = "addDouble.(Ljava/util/Map;Ljava/lang/String;D)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='addJsonObject' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("addJsonObject", "(Ljava/util/Map;Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public static unsafe void AddJsonObject (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, global::Org.Json.JSONObject p2)
		{
			const string __id = "addJsonObject.(Ljava/util/Map;Ljava/lang/String;Lorg/json/JSONObject;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='addLong' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("addLong", "(Ljava/util/Map;Ljava/lang/String;J)V", "")]
		public static unsafe void AddLong (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, long p2)
		{
			const string __id = "addLong.(Ljava/util/Map;Ljava/lang/String;J)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='addMapJson' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("addMapJson", "(Ljava/util/Map;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void AddMapJson (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, global::System.Collections.IDictionary p2)
		{
			const string __id = "addMapJson.(Ljava/util/Map;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='addString' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addString", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddString (global::System.Collections.Generic.IDictionary<string, string> p0, string p1, string p2)
		{
			const string __id = "addString.(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_buildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_Z;
#pragma warning disable 0169
		static Delegate GetBuildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_ZHandler ()
		{
			if (cb_buildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_Z == null)
				cb_buildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_L (n_BuildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_Z));
			return cb_buildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_Z;
		}

		static IntPtr n_BuildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustAdRevenue> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildAdRevenuePackage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildAdRevenuePackage' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.AdjustAdRevenue'] and parameter[2][@type='boolean']]"
		[Register ("buildAdRevenuePackage", "(Lcom/adjust/sdk/AdjustAdRevenue;Z)Lcom/adjust/sdk/ActivityPackage;", "GetBuildAdRevenuePackage_Lcom_adjust_sdk_AdjustAdRevenue_ZHandler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildAdRevenuePackage (global::Com.Adjust.Sdk.AdjustAdRevenue p0, bool p1)
		{
			const string __id = "buildAdRevenuePackage.(Lcom/adjust/sdk/AdjustAdRevenue;Z)Lcom/adjust/sdk/ActivityPackage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_buildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetBuildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_buildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_buildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_BuildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_));
			return cb_buildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static IntPtr n_BuildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildAdRevenuePackage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildAdRevenuePackage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("buildAdRevenuePackage", "(Ljava/lang/String;Lorg/json/JSONObject;)Lcom/adjust/sdk/ActivityPackage;", "GetBuildAdRevenuePackage_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildAdRevenuePackage (string p0, global::Org.Json.JSONObject p1)
		{
			const string __id = "buildAdRevenuePackage.(Ljava/lang/String;Lorg/json/JSONObject;)Lcom/adjust/sdk/ActivityPackage;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_buildAttributionPackage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBuildAttributionPackage_Ljava_lang_String_Handler ()
		{
			if (cb_buildAttributionPackage_Ljava_lang_String_ == null)
				cb_buildAttributionPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_BuildAttributionPackage_Ljava_lang_String_));
			return cb_buildAttributionPackage_Ljava_lang_String_;
		}

		static IntPtr n_BuildAttributionPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildAttributionPackage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildAttributionPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("buildAttributionPackage", "(Ljava/lang/String;)Lcom/adjust/sdk/ActivityPackage;", "GetBuildAttributionPackage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildAttributionPackage (string p0)
		{
			const string __id = "buildAttributionPackage.(Ljava/lang/String;)Lcom/adjust/sdk/ActivityPackage;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_buildClickPackage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBuildClickPackage_Ljava_lang_String_Handler ()
		{
			if (cb_buildClickPackage_Ljava_lang_String_ == null)
				cb_buildClickPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_BuildClickPackage_Ljava_lang_String_));
			return cb_buildClickPackage_Ljava_lang_String_;
		}

		static IntPtr n_BuildClickPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildClickPackage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildClickPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("buildClickPackage", "(Ljava/lang/String;)Lcom/adjust/sdk/ActivityPackage;", "GetBuildClickPackage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildClickPackage (string p0)
		{
			const string __id = "buildClickPackage.(Ljava/lang/String;)Lcom/adjust/sdk/ActivityPackage;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_buildDisableThirdPartySharingPackage;
#pragma warning disable 0169
		static Delegate GetBuildDisableThirdPartySharingPackageHandler ()
		{
			if (cb_buildDisableThirdPartySharingPackage == null)
				cb_buildDisableThirdPartySharingPackage = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_BuildDisableThirdPartySharingPackage));
			return cb_buildDisableThirdPartySharingPackage;
		}

		static IntPtr n_BuildDisableThirdPartySharingPackage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildDisableThirdPartySharingPackage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildDisableThirdPartySharingPackage' and count(parameter)=0]"
		[Register ("buildDisableThirdPartySharingPackage", "()Lcom/adjust/sdk/ActivityPackage;", "GetBuildDisableThirdPartySharingPackageHandler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildDisableThirdPartySharingPackage ()
		{
			const string __id = "buildDisableThirdPartySharingPackage.()Lcom/adjust/sdk/ActivityPackage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildEventPackage_Lcom_adjust_sdk_AdjustEvent_Z;
#pragma warning disable 0169
		static Delegate GetBuildEventPackage_Lcom_adjust_sdk_AdjustEvent_ZHandler ()
		{
			if (cb_buildEventPackage_Lcom_adjust_sdk_AdjustEvent_Z == null)
				cb_buildEventPackage_Lcom_adjust_sdk_AdjustEvent_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_L (n_BuildEventPackage_Lcom_adjust_sdk_AdjustEvent_Z));
			return cb_buildEventPackage_Lcom_adjust_sdk_AdjustEvent_Z;
		}

		static IntPtr n_BuildEventPackage_Lcom_adjust_sdk_AdjustEvent_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildEventPackage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildEventPackage' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.AdjustEvent'] and parameter[2][@type='boolean']]"
		[Register ("buildEventPackage", "(Lcom/adjust/sdk/AdjustEvent;Z)Lcom/adjust/sdk/ActivityPackage;", "GetBuildEventPackage_Lcom_adjust_sdk_AdjustEvent_ZHandler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildEventPackage (global::Com.Adjust.Sdk.AdjustEvent p0, bool p1)
		{
			const string __id = "buildEventPackage.(Lcom/adjust/sdk/AdjustEvent;Z)Lcom/adjust/sdk/ActivityPackage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_buildGdprPackage;
#pragma warning disable 0169
		static Delegate GetBuildGdprPackageHandler ()
		{
			if (cb_buildGdprPackage == null)
				cb_buildGdprPackage = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_BuildGdprPackage));
			return cb_buildGdprPackage;
		}

		static IntPtr n_BuildGdprPackage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildGdprPackage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildGdprPackage' and count(parameter)=0]"
		[Register ("buildGdprPackage", "()Lcom/adjust/sdk/ActivityPackage;", "GetBuildGdprPackageHandler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildGdprPackage ()
		{
			const string __id = "buildGdprPackage.()Lcom/adjust/sdk/ActivityPackage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildInfoPackage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBuildInfoPackage_Ljava_lang_String_Handler ()
		{
			if (cb_buildInfoPackage_Ljava_lang_String_ == null)
				cb_buildInfoPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_BuildInfoPackage_Ljava_lang_String_));
			return cb_buildInfoPackage_Ljava_lang_String_;
		}

		static IntPtr n_BuildInfoPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildInfoPackage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildInfoPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("buildInfoPackage", "(Ljava/lang/String;)Lcom/adjust/sdk/ActivityPackage;", "GetBuildInfoPackage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildInfoPackage (string p0)
		{
			const string __id = "buildInfoPackage.(Ljava/lang/String;)Lcom/adjust/sdk/ActivityPackage;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_buildMeasurementConsentPackage_Z;
#pragma warning disable 0169
		static Delegate GetBuildMeasurementConsentPackage_ZHandler ()
		{
			if (cb_buildMeasurementConsentPackage_Z == null)
				cb_buildMeasurementConsentPackage_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_L (n_BuildMeasurementConsentPackage_Z));
			return cb_buildMeasurementConsentPackage_Z;
		}

		static IntPtr n_BuildMeasurementConsentPackage_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildMeasurementConsentPackage (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildMeasurementConsentPackage' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildMeasurementConsentPackage", "(Z)Lcom/adjust/sdk/ActivityPackage;", "GetBuildMeasurementConsentPackage_ZHandler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildMeasurementConsentPackage (bool p0)
		{
			const string __id = "buildMeasurementConsentPackage.(Z)Lcom/adjust/sdk/ActivityPackage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildSessionPackage_Z;
#pragma warning disable 0169
		static Delegate GetBuildSessionPackage_ZHandler ()
		{
			if (cb_buildSessionPackage_Z == null)
				cb_buildSessionPackage_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_L (n_BuildSessionPackage_Z));
			return cb_buildSessionPackage_Z;
		}

		static IntPtr n_BuildSessionPackage_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildSessionPackage (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildSessionPackage' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildSessionPackage", "(Z)Lcom/adjust/sdk/ActivityPackage;", "GetBuildSessionPackage_ZHandler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildSessionPackage (bool p0)
		{
			const string __id = "buildSessionPackage.(Z)Lcom/adjust/sdk/ActivityPackage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Z;
#pragma warning disable 0169
		static Delegate GetBuildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_ZHandler ()
		{
			if (cb_buildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Z == null)
				cb_buildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_L (n_BuildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Z));
			return cb_buildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Z;
		}

		static IntPtr n_BuildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustPlayStoreSubscription> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildSubscriptionPackage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildSubscriptionPackage' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.AdjustPlayStoreSubscription'] and parameter[2][@type='boolean']]"
		[Register ("buildSubscriptionPackage", "(Lcom/adjust/sdk/AdjustPlayStoreSubscription;Z)Lcom/adjust/sdk/ActivityPackage;", "GetBuildSubscriptionPackage_Lcom_adjust_sdk_AdjustPlayStoreSubscription_ZHandler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildSubscriptionPackage (global::Com.Adjust.Sdk.AdjustPlayStoreSubscription p0, bool p1)
		{
			const string __id = "buildSubscriptionPackage.(Lcom/adjust/sdk/AdjustPlayStoreSubscription;Z)Lcom/adjust/sdk/ActivityPackage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_buildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_;
#pragma warning disable 0169
		static Delegate GetBuildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_Handler ()
		{
			if (cb_buildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_ == null)
				cb_buildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_BuildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_));
			return cb_buildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_;
		}

		static IntPtr n_BuildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustThirdPartySharing> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildThirdPartySharingPackage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildThirdPartySharingPackage' and count(parameter)=1 and parameter[1][@type='com.adjust.sdk.AdjustThirdPartySharing']]"
		[Register ("buildThirdPartySharingPackage", "(Lcom/adjust/sdk/AdjustThirdPartySharing;)Lcom/adjust/sdk/ActivityPackage;", "GetBuildThirdPartySharingPackage_Lcom_adjust_sdk_AdjustThirdPartySharing_Handler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildThirdPartySharingPackage (global::Com.Adjust.Sdk.AdjustThirdPartySharing p0)
		{
			const string __id = "buildThirdPartySharingPackage.(Lcom/adjust/sdk/AdjustThirdPartySharing;)Lcom/adjust/sdk/ActivityPackage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_buildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_;
#pragma warning disable 0169
		static Delegate GetBuildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_Handler ()
		{
			if (cb_buildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ == null)
				cb_buildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_BuildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_));
			return cb_buildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_;
		}

		static IntPtr n_BuildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustPurchase> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener)global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildVerificationPackage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='buildVerificationPackage' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.AdjustPurchase'] and parameter[2][@type='com.adjust.sdk.OnPurchaseVerificationFinishedListener']]"
		[Register ("buildVerificationPackage", "(Lcom/adjust/sdk/AdjustPurchase;Lcom/adjust/sdk/OnPurchaseVerificationFinishedListener;)Lcom/adjust/sdk/ActivityPackage;", "GetBuildVerificationPackage_Lcom_adjust_sdk_AdjustPurchase_Lcom_adjust_sdk_OnPurchaseVerificationFinishedListener_Handler")]
		public virtual unsafe global::Com.Adjust.Sdk.ActivityPackage BuildVerificationPackage (global::Com.Adjust.Sdk.AdjustPurchase p0, global::Com.Adjust.Sdk.IOnPurchaseVerificationFinishedListener p1)
		{
			const string __id = "buildVerificationPackage.(Lcom/adjust/sdk/AdjustPurchase;Lcom/adjust/sdk/OnPurchaseVerificationFinishedListener;)Lcom/adjust/sdk/ActivityPackage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getEventParameters_Lcom_adjust_sdk_AdjustEvent_Z;
#pragma warning disable 0169
		static Delegate GetGetEventParameters_Lcom_adjust_sdk_AdjustEvent_ZHandler ()
		{
			if (cb_getEventParameters_Lcom_adjust_sdk_AdjustEvent_Z == null)
				cb_getEventParameters_Lcom_adjust_sdk_AdjustEvent_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_L (n_GetEventParameters_Lcom_adjust_sdk_AdjustEvent_Z));
			return cb_getEventParameters_Lcom_adjust_sdk_AdjustEvent_Z;
		}

		static IntPtr n_GetEventParameters_Lcom_adjust_sdk_AdjustEvent_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.PackageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetEventParameters (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='PackageBuilder']/method[@name='getEventParameters' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.AdjustEvent'] and parameter[2][@type='boolean']]"
		[Register ("getEventParameters", "(Lcom/adjust/sdk/AdjustEvent;Z)Ljava/util/Map;", "GetGetEventParameters_Lcom_adjust_sdk_AdjustEvent_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetEventParameters (global::Com.Adjust.Sdk.AdjustEvent p0, bool p1)
		{
			const string __id = "getEventParameters.(Lcom/adjust/sdk/AdjustEvent;Z)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}