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

namespace Com.GameAnalytics.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']"
	[global::Android.Runtime.Register ("com/gameanalytics/sdk/GAProgressionStatus", DoNotGenerateAcw=true)]
	public sealed partial class GAProgressionStatus : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']/field[@name='Complete']"
		[Register ("Complete")]
		public static global::Com.GameAnalytics.Sdk.GAProgressionStatus Complete {
			get {
				const string __id = "Complete.Lcom/gameanalytics/sdk/GAProgressionStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.GAProgressionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']/field[@name='Fail']"
		[Register ("Fail")]
		public static global::Com.GameAnalytics.Sdk.GAProgressionStatus Fail {
			get {
				const string __id = "Fail.Lcom/gameanalytics/sdk/GAProgressionStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.GAProgressionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']/field[@name='Start']"
		[Register ("Start")]
		public static global::Com.GameAnalytics.Sdk.GAProgressionStatus Start {
			get {
				const string __id = "Start.Lcom/gameanalytics/sdk/GAProgressionStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.GAProgressionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']/field[@name='Undefined']"
		[Register ("Undefined")]
		public static global::Com.GameAnalytics.Sdk.GAProgressionStatus Undefined {
			get {
				const string __id = "Undefined.Lcom/gameanalytics/sdk/GAProgressionStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.GAProgressionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gameanalytics/sdk/GAProgressionStatus", typeof (GAProgressionStatus));

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

		internal GAProgressionStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/gameanalytics/sdk/GAProgressionStatus;", "")]
		public static unsafe global::Com.GameAnalytics.Sdk.GAProgressionStatus ValueOf (int id)
		{
			const string __id = "valueOf.(I)Lcom/gameanalytics/sdk/GAProgressionStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.GAProgressionStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/gameanalytics/sdk/GAProgressionStatus;", "")]
		public static unsafe global::Com.GameAnalytics.Sdk.GAProgressionStatus ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/gameanalytics/sdk/GAProgressionStatus;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.GAProgressionStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gameanalytics.sdk']/class[@name='GAProgressionStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/gameanalytics/sdk/GAProgressionStatus;", "")]
		public static unsafe global::Com.GameAnalytics.Sdk.GAProgressionStatus[] Values ()
		{
			const string __id = "values.()[Lcom/gameanalytics/sdk/GAProgressionStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.GameAnalytics.Sdk.GAProgressionStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.GameAnalytics.Sdk.GAProgressionStatus));
			} finally {
			}
		}

	}
}