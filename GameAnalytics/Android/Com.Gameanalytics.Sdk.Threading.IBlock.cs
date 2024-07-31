using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.GameAnalytics.Sdk.Threading {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.gameanalytics.sdk.threading']/interface[@name='IBlock']"
	[Register ("com/gameanalytics/sdk/threading/IBlock", "", "Com.GameAnalytics.Sdk.Threading.IBlockInvoker")]
	public partial interface IBlock : IJavaObject, IJavaPeerable {
		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.gameanalytics.sdk.threading']/interface[@name='IBlock']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.GameAnalytics.Sdk.Threading.IBlockInvoker, MatchSolitaire.Android")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.gameanalytics.sdk.threading']/interface[@name='IBlock']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler:Com.GameAnalytics.Sdk.Threading.IBlockInvoker, MatchSolitaire.Android")]
		void Execute ();

	}

	[global::Android.Runtime.Register ("com/gameanalytics/sdk/threading/IBlock", DoNotGenerateAcw=true)]
	internal partial class IBlockInvoker : global::Java.Lang.Object, IBlock {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/gameanalytics/sdk/threading/IBlock", typeof (IBlockInvoker));

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

		public static IBlock GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBlock> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.gameanalytics.sdk.threading.IBlock'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBlockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetName));
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.Threading.IBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Execute));
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.GameAnalytics.Sdk.Threading.IBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		IntPtr id_execute;
		public unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
		}

	}
}
