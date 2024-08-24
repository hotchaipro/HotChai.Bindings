using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using static Com.IronSource.MediationSdk.Logger.ILogListenerInvoker;

namespace Com.IronSource.MediationSdk.Logger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/interface[@name='LogListener']"
	[Register ("com/ironsource/mediationsdk/logger/LogListener", "", "Com.IronSource.MediationSdk.Logger.ILogListenerInvoker")]
	public partial interface ILogListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.logger']/interface[@name='LogListener']/method[@name='onLog' and count(parameter)=3 and parameter[1][@type='com.ironsource.mediationsdk.logger.IronSourceLogger.IronSourceTag'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("onLog", "(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;I)V", "GetOnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_IHandler:Com.IronSource.MediationSdk.Logger.ILogListenerInvoker, MatchSolitaire.Android")]
		void OnLog (global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0, string p1, int p2);

	}

	[global::Android.Runtime.Register("com/ironsource/mediationsdk/logger/LogListener", DoNotGenerateAcw = true)]
	internal partial class ILogListenerInvoker : global::Java.Lang.Object, ILogListener
	{
		static readonly JniPeerMembers _members = new XAPeerMembers("com/ironsource/mediationsdk/logger/LogListener", typeof(ILogListenerInvoker));

		static IntPtr java_class_ref
		{
			get
			{
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get
			{
				return _members;
			}
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return class_ref;
			}
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType
		{
			get
			{
				return _members.ManagedPeerType;
			}
		}

		IntPtr class_ref;

		public static ILogListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogListener>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance(handle)}' to type 'com.ironsource.mediationsdk.logger.LogListener'.");
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public ILogListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_IHandler()
		{
			if (cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I == null)
				cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(n_OnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I));
			return cb_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I;
		}

		static void n_OnLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.ILogListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag>(native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLog(p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I;
		public unsafe void OnLog(global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0, string p1, int p2)
		{
			if (id_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I == IntPtr.Zero)
				id_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I = JNIEnv.GetMethodID(class_ref, "onLog", "(Lcom/ironsource/mediationsdk/logger/IronSourceLogger$IronSourceTag;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString((string)p1);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
			__args[1] = new JValue(native_p1);
			__args[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onLog_Lcom_ironsource_mediationsdk_logger_IronSourceLogger_IronSourceTag_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef(native_p1);
		}


		// event args for com.ironsource.mediationsdk.logger.LogListener.onLog
		public partial class LogEventArgs : global::System.EventArgs
		{
			public LogEventArgs(global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0, string p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0;

			public global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag P0
			{
				get
				{
					return p0;
				}
			}

			string p1;

			public string P1
			{
				get
				{
					return p1;
				}
			}

			int p2;

			public int P2
			{
				get
				{
					return p2;
				}
			}

		}
	}

		[global::Android.Runtime.Register ("mono/com/ironsource/mediationsdk/logger/LogListenerImplementor")]
	internal sealed partial class ILogListenerImplementor : global::Java.Lang.Object, ILogListener {

		object sender;

		public unsafe ILogListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<LogEventArgs> Handler;
		#pragma warning restore 0649

		public void OnLog (global::Com.IronSource.MediationSdk.Logger.IronSourceLogger.IronSourceTag p0, string p1, int p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LogEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ILogListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
