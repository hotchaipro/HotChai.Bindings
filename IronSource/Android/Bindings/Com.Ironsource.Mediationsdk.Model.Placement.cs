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

namespace Com.IronSource.MediationSdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsource.mediationsdk.model']/class[@name='Placement']"
	[global::Android.Runtime.Register ("com/ironsource/mediationsdk/model/Placement", DoNotGenerateAcw=true)]
	public sealed partial class Placement : global::Com.IronSource.MediationSdk.Model.BasePlacement {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ironsource/mediationsdk/model/Placement", typeof (Placement));

		internal static new IntPtr class_ref {
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

		internal Placement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsource.mediationsdk.model']/class[@name='Placement']/constructor[@name='Placement' and count(parameter)=1 and parameter[1][@type='com.ironsource.mediationsdk.model.BasePlacement']]"
		[Register (".ctor", "(Lcom/ironsource/mediationsdk/model/BasePlacement;)V", "")]
		public unsafe Placement (global::Com.IronSource.MediationSdk.Model.BasePlacement p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/ironsource/mediationsdk/model/BasePlacement;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe int RewardAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.model']/class[@name='Placement']/method[@name='getRewardAmount' and count(parameter)=0]"
			[Register ("getRewardAmount", "()I", "")]
			get {
				const string __id = "getRewardAmount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string RewardName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsource.mediationsdk.model']/class[@name='Placement']/method[@name='getRewardName' and count(parameter)=0]"
			[Register ("getRewardName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRewardName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}