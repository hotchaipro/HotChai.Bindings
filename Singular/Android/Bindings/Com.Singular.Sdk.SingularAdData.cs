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

namespace Com.Singular.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']"
	[global::Android.Runtime.Register ("com/singular/sdk/SingularAdData", DoNotGenerateAcw=true)]
	public partial class SingularAdData : global::Org.Json.JSONObject {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData.AdPlatforms']"
		[global::Android.Runtime.Register ("com/singular/sdk/SingularAdData$AdPlatforms", DoNotGenerateAcw=true)]
		public sealed partial class AdPlatforms : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData.AdPlatforms']/field[@name='MOPUB']"
			[Register ("MOPUB")]
			public const string Mopub = (string) "mopub";

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/singular/sdk/SingularAdData$AdPlatforms", typeof (AdPlatforms));

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

			internal AdPlatforms (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData.AdPlatforms']/constructor[@name='SingularAdData.AdPlatforms' and count(parameter)=1 and parameter[1][@type='com.singular.sdk.SingularAdData']]"
			[Register (".ctor", "(Lcom/singular/sdk/SingularAdData;)V", "")]
			public unsafe AdPlatforms (global::Com.Singular.Sdk.SingularAdData __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/singular/sdk/SingularAdData", typeof (SingularAdData));

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

		protected SingularAdData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/constructor[@name='SingularAdData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;D)V", "")]
		public unsafe SingularAdData (string adPlatform, string currency, double revenue) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;D)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_adPlatform = JNIEnv.NewString ((string)adPlatform);
			IntPtr native_currency = JNIEnv.NewString ((string)currency);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_adPlatform);
				__args [1] = new JniArgumentValue (native_currency);
				__args [2] = new JniArgumentValue (revenue);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_adPlatform);
				JNIEnv.DeleteLocalRef (native_currency);
			}
		}

		static Delegate cb_withAdGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_withAdGroupId_Ljava_lang_String_ == null)
				cb_withAdGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdGroupId_Ljava_lang_String_));
			return cb_withAdGroupId_Ljava_lang_String_;
		}

		static IntPtr n_WithAdGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adGroupId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adGroupId = JNIEnv.GetString (native_adGroupId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdGroupId (adGroupId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdGroupId", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdGroupId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdGroupId (string adGroupId)
		{
			const string __id = "withAdGroupId.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adGroupId = JNIEnv.NewString ((string)adGroupId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adGroupId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adGroupId);
			}
		}

		static Delegate cb_withAdGroupName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdGroupName_Ljava_lang_String_Handler ()
		{
			if (cb_withAdGroupName_Ljava_lang_String_ == null)
				cb_withAdGroupName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdGroupName_Ljava_lang_String_));
			return cb_withAdGroupName_Ljava_lang_String_;
		}

		static IntPtr n_WithAdGroupName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adGroupName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adGroupName = JNIEnv.GetString (native_adGroupName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdGroupName (adGroupName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdGroupName", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdGroupName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdGroupName (string adGroupName)
		{
			const string __id = "withAdGroupName.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adGroupName = JNIEnv.NewString ((string)adGroupName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adGroupName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adGroupName);
			}
		}

		static Delegate cb_withAdGroupPriority_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdGroupPriority_Ljava_lang_String_Handler ()
		{
			if (cb_withAdGroupPriority_Ljava_lang_String_ == null)
				cb_withAdGroupPriority_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdGroupPriority_Ljava_lang_String_));
			return cb_withAdGroupPriority_Ljava_lang_String_;
		}

		static IntPtr n_WithAdGroupPriority_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adGroupPriority)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adGroupPriority = JNIEnv.GetString (native_adGroupPriority, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdGroupPriority (adGroupPriority));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdGroupPriority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdGroupPriority", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdGroupPriority_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdGroupPriority (string adGroupPriority)
		{
			const string __id = "withAdGroupPriority.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adGroupPriority = JNIEnv.NewString ((string)adGroupPriority);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adGroupPriority);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adGroupPriority);
			}
		}

		static Delegate cb_withAdGroupType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdGroupType_Ljava_lang_String_Handler ()
		{
			if (cb_withAdGroupType_Ljava_lang_String_ == null)
				cb_withAdGroupType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdGroupType_Ljava_lang_String_));
			return cb_withAdGroupType_Ljava_lang_String_;
		}

		static IntPtr n_WithAdGroupType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adGroupType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adGroupType = JNIEnv.GetString (native_adGroupType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdGroupType (adGroupType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdGroupType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdGroupType", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdGroupType_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdGroupType (string adGroupType)
		{
			const string __id = "withAdGroupType.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adGroupType = JNIEnv.NewString ((string)adGroupType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adGroupType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adGroupType);
			}
		}

		static Delegate cb_withAdPlacementName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdPlacementName_Ljava_lang_String_Handler ()
		{
			if (cb_withAdPlacementName_Ljava_lang_String_ == null)
				cb_withAdPlacementName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdPlacementName_Ljava_lang_String_));
			return cb_withAdPlacementName_Ljava_lang_String_;
		}

		static IntPtr n_WithAdPlacementName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adPlacementName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adPlacementName = JNIEnv.GetString (native_adPlacementName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdPlacementName (adPlacementName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdPlacementName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdPlacementName", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdPlacementName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdPlacementName (string adPlacementName)
		{
			const string __id = "withAdPlacementName.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adPlacementName = JNIEnv.NewString ((string)adPlacementName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adPlacementName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adPlacementName);
			}
		}

		static Delegate cb_withAdType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdType_Ljava_lang_String_Handler ()
		{
			if (cb_withAdType_Ljava_lang_String_ == null)
				cb_withAdType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdType_Ljava_lang_String_));
			return cb_withAdType_Ljava_lang_String_;
		}

		static IntPtr n_WithAdType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adType = JNIEnv.GetString (native_adType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdType (adType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdType", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdType_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdType (string adType)
		{
			const string __id = "withAdType.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adType = JNIEnv.NewString ((string)adType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adType);
			}
		}

		static Delegate cb_withAdUnitId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdUnitId_Ljava_lang_String_Handler ()
		{
			if (cb_withAdUnitId_Ljava_lang_String_ == null)
				cb_withAdUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdUnitId_Ljava_lang_String_));
			return cb_withAdUnitId_Ljava_lang_String_;
		}

		static IntPtr n_WithAdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adUnitId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adUnitId = JNIEnv.GetString (native_adUnitId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdUnitId (adUnitId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdUnitId", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdUnitId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdUnitId (string adUnitId)
		{
			const string __id = "withAdUnitId.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adUnitId = JNIEnv.NewString ((string)adUnitId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adUnitId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adUnitId);
			}
		}

		static Delegate cb_withAdUnitName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdUnitName_Ljava_lang_String_Handler ()
		{
			if (cb_withAdUnitName_Ljava_lang_String_ == null)
				cb_withAdUnitName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithAdUnitName_Ljava_lang_String_));
			return cb_withAdUnitName_Ljava_lang_String_;
		}

		static IntPtr n_WithAdUnitName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adUnitName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var adUnitName = JNIEnv.GetString (native_adUnitName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdUnitName (adUnitName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withAdUnitName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdUnitName", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithAdUnitName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithAdUnitName (string adUnitName)
		{
			const string __id = "withAdUnitName.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_adUnitName = JNIEnv.NewString ((string)adUnitName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_adUnitName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_adUnitName);
			}
		}

		static Delegate cb_withImpressionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithImpressionId_Ljava_lang_String_Handler ()
		{
			if (cb_withImpressionId_Ljava_lang_String_ == null)
				cb_withImpressionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithImpressionId_Ljava_lang_String_));
			return cb_withImpressionId_Ljava_lang_String_;
		}

		static IntPtr n_WithImpressionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_impressionId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var impressionId = JNIEnv.GetString (native_impressionId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithImpressionId (impressionId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withImpressionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withImpressionId", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithImpressionId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithImpressionId (string impressionId)
		{
			const string __id = "withImpressionId.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_impressionId = JNIEnv.NewString ((string)impressionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_impressionId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_impressionId);
			}
		}

		static Delegate cb_withNetworkName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithNetworkName_Ljava_lang_String_Handler ()
		{
			if (cb_withNetworkName_Ljava_lang_String_ == null)
				cb_withNetworkName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithNetworkName_Ljava_lang_String_));
			return cb_withNetworkName_Ljava_lang_String_;
		}

		static IntPtr n_WithNetworkName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var networkName = JNIEnv.GetString (native_networkName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithNetworkName (networkName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withNetworkName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withNetworkName", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithNetworkName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithNetworkName (string networkName)
		{
			const string __id = "withNetworkName.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_networkName = JNIEnv.NewString ((string)networkName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_networkName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_networkName);
			}
		}

		static Delegate cb_withPlacementId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithPlacementId_Ljava_lang_String_Handler ()
		{
			if (cb_withPlacementId_Ljava_lang_String_ == null)
				cb_withPlacementId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithPlacementId_Ljava_lang_String_));
			return cb_withPlacementId_Ljava_lang_String_;
		}

		static IntPtr n_WithPlacementId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_placementId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var placementId = JNIEnv.GetString (native_placementId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithPlacementId (placementId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withPlacementId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withPlacementId", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithPlacementId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithPlacementId (string placementId)
		{
			const string __id = "withPlacementId.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_placementId = JNIEnv.NewString ((string)placementId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_placementId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_placementId);
			}
		}

		static Delegate cb_withPrecision_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithPrecision_Ljava_lang_String_Handler ()
		{
			if (cb_withPrecision_Ljava_lang_String_ == null)
				cb_withPrecision_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_WithPrecision_Ljava_lang_String_));
			return cb_withPrecision_Ljava_lang_String_;
		}

		static IntPtr n_WithPrecision_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_precision)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var precision = JNIEnv.GetString (native_precision, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithPrecision (precision));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.singular.sdk']/class[@name='SingularAdData']/method[@name='withPrecision' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withPrecision", "(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;", "GetWithPrecision_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Singular.Sdk.SingularAdData WithPrecision (string precision)
		{
			const string __id = "withPrecision.(Ljava/lang/String;)Lcom/singular/sdk/SingularAdData;";
			IntPtr native_precision = JNIEnv.NewString ((string)precision);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_precision);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Singular.Sdk.SingularAdData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_precision);
			}
		}

	}
}
