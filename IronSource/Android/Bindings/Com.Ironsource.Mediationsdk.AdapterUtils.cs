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

namespace Com.IronSource.MediationSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsource.mediationsdk']/class[@name='AdapterUtils']"
	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/AdapterUtils", DoNotGenerateAcw=true)]
	public partial class AdapterUtils : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsource.mediationsdk']/class[@name='AdapterUtils']/field[@name='MIN_TABLET_DP_SIZE']"
		[Register ("MIN_TABLET_DP_SIZE")]
		public const int MinTabletDpSize = (int) 600;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/AdapterUtils", typeof (AdapterUtils));

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

		protected AdapterUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsource.mediationsdk']/class[@name='AdapterUtils']/constructor[@name='AdapterUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdapterUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/class[@name='AdapterUtils']/method[@name='dpToPixels' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("dpToPixels", "(Landroid/content/Context;I)I", "")]
		public static unsafe int DpToPixels (global::Android.Content.Context p0, int p1)
		{
			const string __id = "dpToPixels.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/class[@name='AdapterUtils']/method[@name='getScreenSizeParams' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenSizeParams", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetScreenSizeParams (global::Android.Content.Context p0)
		{
			const string __id = "getScreenSizeParams.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk']/class[@name='AdapterUtils']/method[@name='isLargeScreen' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isLargeScreen", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsLargeScreen (global::Android.Content.Context p0)
		{
			const string __id = "isLargeScreen.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}