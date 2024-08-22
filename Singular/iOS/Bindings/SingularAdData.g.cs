#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using CoreFoundation;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace SingularSDK
{
	[Register("SingularAdData", true)]
	public unsafe partial class SingularAdData : NSMutableDictionary {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SingularAdData");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SingularAdData () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SingularAdData (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SingularAdData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SingularAdData (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAdPlatfrom:withCurrency:withRevenue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SingularAdData (string adPlatform, string currency, NSNumber revenue)
			: base (NSObjectFlag.Empty)
		{
			if (adPlatform is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlatform));
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var revenue__handle__ = revenue!.GetNonNullHandle (nameof (revenue));
			var nsadPlatform = CFString.CreateNative (adPlatform);
			var nscurrency = CFString.CreateNative (currency);
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithAdPlatfrom:withCurrency:withRevenue:"), nsadPlatform, nscurrency, revenue__handle__), "initWithAdPlatfrom:withCurrency:withRevenue:");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAdPlatfrom:withCurrency:withRevenue:"), nsadPlatform, nscurrency, revenue__handle__), "initWithAdPlatfrom:withCurrency:withRevenue:");
			}
			CFString.ReleaseNative (nsadPlatform);
			CFString.ReleaseNative (nscurrency);
		}
		[Export ("setAdGroupId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdGroupId (string adGroupId)
		{
			if (adGroupId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adGroupId));
			var nsadGroupId = CFString.CreateNative (adGroupId);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdGroupId:"), nsadGroupId);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdGroupId:"), nsadGroupId);
			}
			CFString.ReleaseNative (nsadGroupId);
		}
		[Export ("setAdGroupName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdGroupName (string adGroupName)
		{
			if (adGroupName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adGroupName));
			var nsadGroupName = CFString.CreateNative (adGroupName);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdGroupName:"), nsadGroupName);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdGroupName:"), nsadGroupName);
			}
			CFString.ReleaseNative (nsadGroupName);
		}
		[Export ("setAdGroupPriority:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdGroupPriority (string adGroupPriority)
		{
			if (adGroupPriority is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adGroupPriority));
			var nsadGroupPriority = CFString.CreateNative (adGroupPriority);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdGroupPriority:"), nsadGroupPriority);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdGroupPriority:"), nsadGroupPriority);
			}
			CFString.ReleaseNative (nsadGroupPriority);
		}
		[Export ("setAdPlacementName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdPlacementName (string adPlacementName)
		{
			if (adPlacementName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacementName));
			var nsadPlacementName = CFString.CreateNative (adPlacementName);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdPlacementName:"), nsadPlacementName);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdPlacementName:"), nsadPlacementName);
			}
			CFString.ReleaseNative (nsadPlacementName);
		}
		[Export ("setAdType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdType (string adType)
		{
			if (adType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adType));
			var nsadType = CFString.CreateNative (adType);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdType:"), nsadType);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdType:"), nsadType);
			}
			CFString.ReleaseNative (nsadType);
		}
		[Export ("setAdUnitId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdUnitId (string adUnitId)
		{
			if (adUnitId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnitId));
			var nsadUnitId = CFString.CreateNative (adUnitId);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdUnitId:"), nsadUnitId);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdUnitId:"), nsadUnitId);
			}
			CFString.ReleaseNative (nsadUnitId);
		}
		[Export ("setAdUnitName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAdUnitName (string adUnitName)
		{
			if (adUnitName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adUnitName));
			var nsadUnitName = CFString.CreateNative (adUnitName);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAdUnitName:"), nsadUnitName);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAdUnitName:"), nsadUnitName);
			}
			CFString.ReleaseNative (nsadUnitName);
		}
		[Export ("setGroupType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetGroupType (string adGroupType)
		{
			if (adGroupType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adGroupType));
			var nsadGroupType = CFString.CreateNative (adGroupType);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setGroupType:"), nsadGroupType);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setGroupType:"), nsadGroupType);
			}
			CFString.ReleaseNative (nsadGroupType);
		}
		[Export ("setImpressionId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImpressionId (string impressionId)
		{
			if (impressionId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (impressionId));
			var nsimpressionId = CFString.CreateNative (impressionId);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setImpressionId:"), nsimpressionId);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setImpressionId:"), nsimpressionId);
			}
			CFString.ReleaseNative (nsimpressionId);
		}
		[Export ("setNetworkName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNetworkName (string networkName)
		{
			if (networkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (networkName));
			var nsnetworkName = CFString.CreateNative (networkName);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNetworkName:"), nsnetworkName);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setNetworkName:"), nsnetworkName);
			}
			CFString.ReleaseNative (nsnetworkName);
		}
		[Export ("setPlacementId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPlacementId (string placementId)
		{
			if (placementId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (placementId));
			var nsplacementId = CFString.CreateNative (placementId);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPlacementId:"), nsplacementId);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPlacementId:"), nsplacementId);
			}
			CFString.ReleaseNative (nsplacementId);
		}
		[Export ("setPrecision:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPrecision (string precision)
		{
			if (precision is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (precision));
			var nsprecision = CFString.CreateNative (precision);
			if (IsDirectBinding) {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrecision:"), nsprecision);
			} else {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPrecision:"), nsprecision);
			}
			CFString.ReleaseNative (nsprecision);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasRequiredParams {
			[Export ("hasRequiredParams")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasRequiredParams"));
				} else {
					ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasRequiredParams"));
				}
				return ret != 0;
			}
		}
	} /* class SingularAdData */
}
