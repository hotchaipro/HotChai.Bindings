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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']"
	[global::Android.Runtime.Register ("com/adjust/sdk/ResponseData", DoNotGenerateAcw=true)]
	public partial class ResponseData : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='activityKind']"
		[Register ("activityKind")]
		public global::Com.Adjust.Sdk.ActivityKind ActivityKind {
			get {
				const string __id = "activityKind.Lcom/adjust/sdk/ActivityKind;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "activityKind.Lcom/adjust/sdk/ActivityKind;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='activityPackage']"
		[Register ("activityPackage")]
		public global::Com.Adjust.Sdk.ActivityPackage ActivityPackage {
			get {
				const string __id = "activityPackage.Lcom/adjust/sdk/ActivityPackage;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ActivityPackage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "activityPackage.Lcom/adjust/sdk/ActivityPackage;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='adid']"
		[Register ("adid")]
		public string Adid {
			get {
				const string __id = "adid.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "adid.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='askIn']"
		[Register ("askIn")]
		public global::Java.Lang.Long AskIn {
			get {
				const string __id = "askIn.Ljava/lang/Long;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "askIn.Ljava/lang/Long;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='attribution']"
		[Register ("attribution")]
		public global::Com.Adjust.Sdk.AdjustAttribution Attribution {
			get {
				const string __id = "attribution.Lcom/adjust/sdk/AdjustAttribution;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.AdjustAttribution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "attribution.Lcom/adjust/sdk/AdjustAttribution;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='continueIn']"
		[Register ("continueIn")]
		public global::Java.Lang.Long ContinueIn {
			get {
				const string __id = "continueIn.Ljava/lang/Long;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "continueIn.Ljava/lang/Long;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='jsonResponse']"
		[Register ("jsonResponse")]
		public global::Org.Json.JSONObject JsonResponse {
			get {
				const string __id = "jsonResponse.Lorg/json/JSONObject;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "jsonResponse.Lorg/json/JSONObject;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				const string __id = "message.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "message.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='resolvedDeeplink']"
		[Register ("resolvedDeeplink")]
		public string ResolvedDeeplink {
			get {
				const string __id = "resolvedDeeplink.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "resolvedDeeplink.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='retryIn']"
		[Register ("retryIn")]
		public global::Java.Lang.Long RetryIn {
			get {
				const string __id = "retryIn.Ljava/lang/Long;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "retryIn.Ljava/lang/Long;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='sendingParameters']"
		[Register ("sendingParameters")]
		public global::System.Collections.IDictionary SendingParameters {
			get {
				const string __id = "sendingParameters.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sendingParameters.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='success']"
		[Register ("success")]
		public bool Success {
			get {
				const string __id = "success.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "success.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='timestamp']"
		[Register ("timestamp")]
		public string Timestamp {
			get {
				const string __id = "timestamp.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "timestamp.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='trackingState']"
		[Register ("trackingState")]
		public global::Com.Adjust.Sdk.TrackingState TrackingState {
			get {
				const string __id = "trackingState.Lcom/adjust/sdk/TrackingState;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.TrackingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trackingState.Lcom/adjust/sdk/TrackingState;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/field[@name='willRetry']"
		[Register ("willRetry")]
		public bool WillRetry {
			get {
				const string __id = "willRetry.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "willRetry.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/ResponseData", typeof (ResponseData));

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

		protected ResponseData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/constructor[@name='ResponseData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.adjust.sdk']/class[@name='ResponseData']/method[@name='buildResponseData' and count(parameter)=2 and parameter[1][@type='com.adjust.sdk.ActivityPackage'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("buildResponseData", "(Lcom/adjust/sdk/ActivityPackage;Ljava/util/Map;)Lcom/adjust/sdk/ResponseData;", "")]
		public static unsafe global::Com.Adjust.Sdk.ResponseData BuildResponseData (global::Com.Adjust.Sdk.ActivityPackage p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "buildResponseData.(Lcom/adjust/sdk/ActivityPackage;Ljava/util/Map;)Lcom/adjust/sdk/ResponseData;";
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Adjust.Sdk.ResponseData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}