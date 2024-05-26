using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk.Network {

	[Register ("com/adjust/sdk/network/ErrorCodes", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Adjust.Sdk.Network.IErrorCodes' type. This class will be removed in a future release.")]
	public abstract class ErrorCodes : Java.Lang.Object {
		internal ErrorCodes ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='IO_EXCEPTION']"
		[Register ("IO_EXCEPTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.IoException'. This class will be removed in a future release.")]
		public const int IoException = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='MALFORMED_URL_EXCEPTION']"
		[Register ("MALFORMED_URL_EXCEPTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.MalformedUrlException'. This class will be removed in a future release.")]
		public const int MalformedUrlException = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='NULL_JSON_RESPONSE']"
		[Register ("NULL_JSON_RESPONSE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.NullJsonResponse'. This class will be removed in a future release.")]
		public const int NullJsonResponse = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='PROTOCOL_EXCEPTION']"
		[Register ("PROTOCOL_EXCEPTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.ProtocolException'. This class will be removed in a future release.")]
		public const int ProtocolException = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='SERVER_RETRY_IN']"
		[Register ("SERVER_RETRY_IN")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.ServerRetryIn'. This class will be removed in a future release.")]
		public const int ServerRetryIn = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='SOCKET_TIMEOUT_EXCEPTION']"
		[Register ("SOCKET_TIMEOUT_EXCEPTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.SocketTimeoutException'. This class will be removed in a future release.")]
		public const int SocketTimeoutException = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='SSL_HANDSHAKE_EXCEPTION']"
		[Register ("SSL_HANDSHAKE_EXCEPTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.SslHandshakeException'. This class will be removed in a future release.")]
		public const int SslHandshakeException = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='THROWABLE']"
		[Register ("THROWABLE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.Throwable'. This class will be removed in a future release.")]
		public const int Throwable = (int) 1100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='UNSUPPORTED_ENCODING_EXCEPTION']"
		[Register ("UNSUPPORTED_ENCODING_EXCEPTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.Network.IErrorCodes.UnsupportedEncodingException'. This class will be removed in a future release.")]
		public const int UnsupportedEncodingException = (int) 1002;

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']"
	[Register ("com/adjust/sdk/network/ErrorCodes", "", "Com.Adjust.Sdk.Network.IErrorCodesInvoker")]
	public partial interface IErrorCodes : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='IO_EXCEPTION']"
		[Register ("IO_EXCEPTION")]
		public const int IoException = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='MALFORMED_URL_EXCEPTION']"
		[Register ("MALFORMED_URL_EXCEPTION")]
		public const int MalformedUrlException = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='NULL_JSON_RESPONSE']"
		[Register ("NULL_JSON_RESPONSE")]
		public const int NullJsonResponse = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='PROTOCOL_EXCEPTION']"
		[Register ("PROTOCOL_EXCEPTION")]
		public const int ProtocolException = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='SERVER_RETRY_IN']"
		[Register ("SERVER_RETRY_IN")]
		public const int ServerRetryIn = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='SOCKET_TIMEOUT_EXCEPTION']"
		[Register ("SOCKET_TIMEOUT_EXCEPTION")]
		public const int SocketTimeoutException = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='SSL_HANDSHAKE_EXCEPTION']"
		[Register ("SSL_HANDSHAKE_EXCEPTION")]
		public const int SslHandshakeException = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='THROWABLE']"
		[Register ("THROWABLE")]
		public const int Throwable = (int) 1100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk.network']/interface[@name='ErrorCodes']/field[@name='UNSUPPORTED_ENCODING_EXCEPTION']"
		[Register ("UNSUPPORTED_ENCODING_EXCEPTION")]
		public const int UnsupportedEncodingException = (int) 1002;

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/network/ErrorCodes", DoNotGenerateAcw=true)]
	internal partial class IErrorCodesInvoker : global::Java.Lang.Object, IErrorCodes {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/network/ErrorCodes", typeof (IErrorCodesInvoker));

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

		public static IErrorCodes GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IErrorCodes> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.network.ErrorCodes'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IErrorCodesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
