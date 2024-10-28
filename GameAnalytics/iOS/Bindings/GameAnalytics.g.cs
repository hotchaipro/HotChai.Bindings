//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using global::ObjCRuntime;
using CoreFoundation;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace GameAnalyticsSdk
{
    [Register("GameAnalytics", true)]
	public unsafe partial class GameAnalytics : NSObject
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GameAnalytics");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GameAnalytics () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected GameAnalytics (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GameAnalytics (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("adTypeToString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string AdTypeToString (GAAdType adType)
		{
			return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("adTypeToString:"), (IntPtr) (long) adType))!;
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, nint duration)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, duration);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, nint duration, NSDictionary customFields)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:customFields:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, duration, customFields__handle__);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, nint duration, NSDictionary customFields, bool mergeFields)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle_bool (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:customFields:mergeFields:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, duration, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, (IntPtr) (long) noAdReason);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason, NSDictionary customFields)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:customFields:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, (IntPtr) (long) noAdReason, customFields__handle__);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason, NSDictionary customFields, bool mergeFields)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_IntPtr_NativeHandle_bool (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:customFields:mergeFields:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, (IntPtr) (long) noAdReason, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, NSDictionary customFields)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:customFields:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, customFields__handle__);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddAdEvent (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, NSDictionary customFields, bool mergeFields)
		{
			if (adSdkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adSdkName));
			if (adPlacement is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adPlacement));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadSdkName = CFString.CreateNative (adSdkName);
			var nsadPlacement = CFString.CreateNative (adPlacement);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addAdEventWithAction:adType:adSdkName:adPlacement:customFields:mergeFields:"), (IntPtr) (long) action, (IntPtr) (long) adType, nsadSdkName, nsadPlacement, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nsadSdkName);
			CFString.ReleaseNative (nsadPlacement);
		}
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddBusinessEvent (string currency, nint amount, string itemType, string itemId, string cartType, string? receipt)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			if (cartType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cartType));
			if (receipt is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (receipt));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			var nscartType = CFString.CreateNative (cartType);
			var nsreceipt = CFString.CreateNative (receipt);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:"), nscurrency, amount, nsitemType, nsitemId, nscartType, nsreceipt);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
			CFString.ReleaseNative (nscartType);
			CFString.ReleaseNative (nsreceipt);
		}
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddBusinessEvent (string currency, nint amount, string itemType, string itemId, string cartType, string receipt, NSDictionary customFields)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			if (cartType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cartType));
			if (receipt is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (receipt));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			var nscartType = CFString.CreateNative (cartType);
			var nsreceipt = CFString.CreateNative (receipt);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:customFields:"), nscurrency, amount, nsitemType, nsitemId, nscartType, nsreceipt, customFields__handle__);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
			CFString.ReleaseNative (nscartType);
			CFString.ReleaseNative (nsreceipt);
		}
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddBusinessEvent (string currency, nint amount, string itemType, string itemId, string cartType, string receipt, NSDictionary customFields, bool mergeFields)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			if (cartType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cartType));
			if (receipt is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (receipt));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			var nscartType = CFString.CreateNative (cartType);
			var nsreceipt = CFString.CreateNative (receipt);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:customFields:mergeFields:"), nscurrency, amount, nsitemType, nsitemId, nscartType, nsreceipt, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
			CFString.ReleaseNative (nscartType);
			CFString.ReleaseNative (nsreceipt);
		}
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddBusinessEvent (string currency, nint amount, string itemType, string itemId, string cartType, bool autoFetchReceipt)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			if (cartType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cartType));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			var nscartType = CFString.CreateNative (cartType);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:"), nscurrency, amount, nsitemType, nsitemId, nscartType, autoFetchReceipt ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
			CFString.ReleaseNative (nscartType);
		}
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddBusinessEvent (string currency, nint amount, string itemType, string itemId, string cartType, bool autoFetchReceipt, NSDictionary customFields)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			if (cartType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cartType));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			var nscartType = CFString.CreateNative (cartType);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (class_ptr, Selector.GetHandle ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:customFields:"), nscurrency, amount, nsitemType, nsitemId, nscartType, autoFetchReceipt ? (byte) 1 : (byte) 0, customFields__handle__);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
			CFString.ReleaseNative (nscartType);
		}
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddBusinessEvent (string currency, nint amount, string itemType, string itemId, string cartType, bool autoFetchReceipt, NSDictionary customFields, bool mergeFields)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			if (cartType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cartType));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			var nscartType = CFString.CreateNative (cartType);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle_bool (class_ptr, Selector.GetHandle ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:customFields:mergeFields:"), nscurrency, amount, nsitemType, nsitemId, nscartType, autoFetchReceipt ? (byte) 1 : (byte) 0, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
			CFString.ReleaseNative (nscartType);
		}
		[Export ("addDesignEventWithEventId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddDesignEvent (string eventId)
		{
			if (eventId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventId));
			var nseventId = CFString.CreateNative (eventId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addDesignEventWithEventId:"), nseventId);
			CFString.ReleaseNative (nseventId);
		}
		[Export ("addDesignEventWithEventId:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddDesignEvent (string eventId, NSDictionary customFields)
		{
			if (eventId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventId));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nseventId = CFString.CreateNative (eventId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addDesignEventWithEventId:customFields:"), nseventId, customFields__handle__);
			CFString.ReleaseNative (nseventId);
		}
		[Export ("addDesignEventWithEventId:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddDesignEvent (string eventId, NSDictionary customFields, bool mergeFields)
		{
			if (eventId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventId));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nseventId = CFString.CreateNative (eventId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addDesignEventWithEventId:customFields:mergeFields:"), nseventId, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nseventId);
		}
		[Export ("addDesignEventWithEventId:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddDesignEvent (string eventId, NSNumber value)
		{
			if (eventId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventId));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nseventId = CFString.CreateNative (eventId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addDesignEventWithEventId:value:"), nseventId, value__handle__);
			CFString.ReleaseNative (nseventId);
		}
		[Export ("addDesignEventWithEventId:value:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddDesignEvent (string eventId, NSNumber value, NSDictionary customFields)
		{
			if (eventId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventId));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nseventId = CFString.CreateNative (eventId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addDesignEventWithEventId:value:customFields:"), nseventId, value__handle__, customFields__handle__);
			CFString.ReleaseNative (nseventId);
		}
		[Export ("addDesignEventWithEventId:value:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddDesignEvent (string eventId, NSNumber value, NSDictionary customFields, bool mergeFields)
		{
			if (eventId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventId));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nseventId = CFString.CreateNative (eventId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addDesignEventWithEventId:value:customFields:mergeFields:"), nseventId, value__handle__, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nseventId);
		}
		[Export ("addErrorEventWithSeverity:message:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddErrorEvent (GAErrorSeverity severity, string message)
		{
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("addErrorEventWithSeverity:message:"), (IntPtr) (long) severity, nsmessage);
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("addErrorEventWithSeverity:message:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddErrorEvent (GAErrorSeverity severity, string message, NSDictionary customFields)
		{
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsmessage = CFString.CreateNative (message);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addErrorEventWithSeverity:message:customFields:"), (IntPtr) (long) severity, nsmessage, customFields__handle__);
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("addErrorEventWithSeverity:message:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddErrorEvent (GAErrorSeverity severity, string message, NSDictionary customFields, bool mergeFields)
		{
			if (message is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsmessage = CFString.CreateNative (message);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addErrorEventWithSeverity:message:customFields:mergeFields:"), (IntPtr) (long) severity, nsmessage, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("addImpressionAdMobEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionAdMobEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionAdMobEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionAdMobEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionAdMobEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionAdMobEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionAequusEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionAequusEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionAequusEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionAequusEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionAequusEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionAequusEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionEvent (string adNetworkName, string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkName));
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkName = CFString.CreateNative (adNetworkName);
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:"), nsadNetworkName, nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkName);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionEvent (string adNetworkName, string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkName));
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkName = CFString.CreateNative (adNetworkName);
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:customFields:"), nsadNetworkName, nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkName);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionEvent (string adNetworkName, string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields, bool mergeFields)
		{
			if (adNetworkName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkName));
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkName = CFString.CreateNative (adNetworkName);
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:customFields:mergeFields:"), nsadNetworkName, nsadNetworkVersion, impressionData__handle__, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nsadNetworkName);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionFyberEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionFyberEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionFyberEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionFyberEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionFyberEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionFyberEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionHyperBidEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionHyperBidEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionHyperBidEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionHyperBidEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionHyperBidEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionHyperBidEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionIronSourceEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionIronSourceEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionIronSourceEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionIronSourceEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionIronSourceEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionIronSourceEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionMaxEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionMaxEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionMaxEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionMaxEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionMaxEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionMaxEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionMopubEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionMopubEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionMopubEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionMopubEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionMopubEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionMopubEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionTopOnEventWithAdNetworkVersion:impressionData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionTopOnEvent (string adNetworkVersion, NSDictionary impressionData)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionTopOnEventWithAdNetworkVersion:impressionData:"), nsadNetworkVersion, impressionData__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addImpressionTopOnEventWithAdNetworkVersion:impressionData:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddImpressionTopOnEvent (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields)
		{
			if (adNetworkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (adNetworkVersion));
			var impressionData__handle__ = impressionData!.GetNonNullHandle (nameof (impressionData));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsadNetworkVersion = CFString.CreateNative (adNetworkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addImpressionTopOnEventWithAdNetworkVersion:impressionData:customFields:"), nsadNetworkVersion, impressionData__handle__, customFields__handle__);
			CFString.ReleaseNative (nsadNetworkVersion);
		}
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddProgressionEvent (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03)
		{
			if (progression01 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression01));
			if (progression02 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression02));
			if (progression03 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression03));
			var nsprogression01 = CFString.CreateNative (progression01);
			var nsprogression02 = CFString.CreateNative (progression02);
			var nsprogression03 = CFString.CreateNative (progression03);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:"), (IntPtr) (long) progressionStatus, nsprogression01, nsprogression02, nsprogression03);
			CFString.ReleaseNative (nsprogression01);
			CFString.ReleaseNative (nsprogression02);
			CFString.ReleaseNative (nsprogression03);
		}
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddProgressionEvent (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, NSDictionary customFields)
		{
			if (progression01 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression01));
			if (progression02 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression02));
			if (progression03 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression03));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsprogression01 = CFString.CreateNative (progression01);
			var nsprogression02 = CFString.CreateNative (progression02);
			var nsprogression03 = CFString.CreateNative (progression03);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:customFields:"), (IntPtr) (long) progressionStatus, nsprogression01, nsprogression02, nsprogression03, customFields__handle__);
			CFString.ReleaseNative (nsprogression01);
			CFString.ReleaseNative (nsprogression02);
			CFString.ReleaseNative (nsprogression03);
		}
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddProgressionEvent (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, NSDictionary customFields, bool mergeFields)
		{
			if (progression01 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression01));
			if (progression02 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression02));
			if (progression03 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression03));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsprogression01 = CFString.CreateNative (progression01);
			var nsprogression02 = CFString.CreateNative (progression02);
			var nsprogression03 = CFString.CreateNative (progression03);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:customFields:mergeFields:"), (IntPtr) (long) progressionStatus, nsprogression01, nsprogression02, nsprogression03, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nsprogression01);
			CFString.ReleaseNative (nsprogression02);
			CFString.ReleaseNative (nsprogression03);
		}
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddProgressionEvent (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, nint score)
		{
			if (progression01 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression01));
			if (progression02 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression02));
			if (progression03 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression03));
			var nsprogression01 = CFString.CreateNative (progression01);
			var nsprogression02 = CFString.CreateNative (progression02);
			var nsprogression03 = CFString.CreateNative (progression03);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:"), (IntPtr) (long) progressionStatus, nsprogression01, nsprogression02, nsprogression03, score);
			CFString.ReleaseNative (nsprogression01);
			CFString.ReleaseNative (nsprogression02);
			CFString.ReleaseNative (nsprogression03);
		}
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddProgressionEvent (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, nint score, NSDictionary customFields)
		{
			if (progression01 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression01));
			if (progression02 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression02));
			if (progression03 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression03));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsprogression01 = CFString.CreateNative (progression01);
			var nsprogression02 = CFString.CreateNative (progression02);
			var nsprogression03 = CFString.CreateNative (progression03);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:customFields:"), (IntPtr) (long) progressionStatus, nsprogression01, nsprogression02, nsprogression03, score, customFields__handle__);
			CFString.ReleaseNative (nsprogression01);
			CFString.ReleaseNative (nsprogression02);
			CFString.ReleaseNative (nsprogression03);
		}
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddProgressionEvent (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, nint score, NSDictionary customFields, bool mergeFields)
		{
			if (progression01 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression01));
			if (progression02 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression02));
			if (progression03 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (progression03));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nsprogression01 = CFString.CreateNative (progression01);
			var nsprogression02 = CFString.CreateNative (progression02);
			var nsprogression03 = CFString.CreateNative (progression03);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_bool (class_ptr, Selector.GetHandle ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:customFields:mergeFields:"), (IntPtr) (long) progressionStatus, nsprogression01, nsprogression02, nsprogression03, score, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nsprogression01);
			CFString.ReleaseNative (nsprogression02);
			CFString.ReleaseNative (nsprogression03);
		}
		[Export ("addResourceEventWithFlowType:currency:amount:itemType:itemId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddResourceEvent (GAResourceFlowType flowType, string currency, NSNumber amount, string itemType, string itemId)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var amount__handle__ = amount!.GetNonNullHandle (nameof (amount));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addResourceEventWithFlowType:currency:amount:itemType:itemId:"), (IntPtr) (long) flowType, nscurrency, amount__handle__, nsitemType, nsitemId);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
		}
		[Export ("addResourceEventWithFlowType:currency:amount:itemType:itemId:customFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddResourceEvent (GAResourceFlowType flowType, string currency, NSNumber amount, string itemType, string itemId, NSDictionary customFields)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var amount__handle__ = amount!.GetNonNullHandle (nameof (amount));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addResourceEventWithFlowType:currency:amount:itemType:itemId:customFields:"), (IntPtr) (long) flowType, nscurrency, amount__handle__, nsitemType, nsitemId, customFields__handle__);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
		}
		[Export ("addResourceEventWithFlowType:currency:amount:itemType:itemId:customFields:mergeFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddResourceEvent (GAResourceFlowType flowType, string currency, NSNumber amount, string itemType, string itemId, NSDictionary customFields, bool mergeFields)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var amount__handle__ = amount!.GetNonNullHandle (nameof (amount));
			if (itemType is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemType));
			if (itemId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemId));
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			var nscurrency = CFString.CreateNative (currency);
			var nsitemType = CFString.CreateNative (itemType);
			var nsitemId = CFString.CreateNative (itemId);
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("addResourceEventWithFlowType:currency:amount:itemType:itemId:customFields:mergeFields:"), (IntPtr) (long) flowType, nscurrency, amount__handle__, nsitemType, nsitemId, customFields__handle__, mergeFields ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsitemType);
			CFString.ReleaseNative (nsitemId);
		}
		[Export ("configureAutoDetectAppVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureAutoDetectAppVersion (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("configureAutoDetectAppVersion:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("configureAvailableCustomDimensions01:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureAvailableCustomDimensions01 (NSObject[] customDimensions)
		{
			if (customDimensions is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (customDimensions));
			var nsa_customDimensions = NSArray.FromNSObjects (customDimensions);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureAvailableCustomDimensions01:"), nsa_customDimensions.Handle);
			nsa_customDimensions.Dispose ();
		}
		[Export ("configureAvailableCustomDimensions02:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureAvailableCustomDimensions02 (NSObject[] customDimensions)
		{
			if (customDimensions is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (customDimensions));
			var nsa_customDimensions = NSArray.FromNSObjects (customDimensions);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureAvailableCustomDimensions02:"), nsa_customDimensions.Handle);
			nsa_customDimensions.Dispose ();
		}
		[Export ("configureAvailableCustomDimensions03:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureAvailableCustomDimensions03 (NSObject[] customDimensions)
		{
			if (customDimensions is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (customDimensions));
			var nsa_customDimensions = NSArray.FromNSObjects (customDimensions);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureAvailableCustomDimensions03:"), nsa_customDimensions.Handle);
			nsa_customDimensions.Dispose ();
		}
		[Export ("configureAvailableResourceCurrencies:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureAvailableResourceCurrencies (NSObject[] resourceCurrencies)
		{
			if (resourceCurrencies is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceCurrencies));
			var nsa_resourceCurrencies = NSArray.FromNSObjects (resourceCurrencies);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureAvailableResourceCurrencies:"), nsa_resourceCurrencies.Handle);
			nsa_resourceCurrencies.Dispose ();
		}
		[Export ("configureAvailableResourceItemTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureAvailableResourceItemTypes (NSObject[] resourceItemTypes)
		{
			if (resourceItemTypes is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceItemTypes));
			var nsa_resourceItemTypes = NSArray.FromNSObjects (resourceItemTypes);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureAvailableResourceItemTypes:"), nsa_resourceItemTypes.Handle);
			nsa_resourceItemTypes.Dispose ();
		}
		[Export ("configureBuild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureBuild (string build)
		{
			if (build is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (build));
			var nsbuild = CFString.CreateNative (build);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureBuild:"), nsbuild);
			CFString.ReleaseNative (nsbuild);
		}
		[Export ("configureEngineVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureEngineVersion (string engineVersion)
		{
			if (engineVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (engineVersion));
			var nsengineVersion = CFString.CreateNative (engineVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureEngineVersion:"), nsengineVersion);
			CFString.ReleaseNative (nsengineVersion);
		}
		[Export ("configureExternalUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureExternalUserId (string userId)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureExternalUserId:"), nsuserId);
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("configureGameKey:gameSecret:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureGameKey (string gameKey, string gameSecret)
		{
			if (gameKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gameKey));
			if (gameSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gameSecret));
			var nsgameKey = CFString.CreateNative (gameKey);
			var nsgameSecret = CFString.CreateNative (gameSecret);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("configureGameKey:gameSecret:"), nsgameKey, nsgameSecret);
			CFString.ReleaseNative (nsgameKey);
			CFString.ReleaseNative (nsgameSecret);
		}
		[Export ("configureSdkVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureSdkVersion (string wrapperSdkVersion)
		{
			if (wrapperSdkVersion is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (wrapperSdkVersion));
			var nswrapperSdkVersion = CFString.CreateNative (wrapperSdkVersion);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureSdkVersion:"), nswrapperSdkVersion);
			CFString.ReleaseNative (nswrapperSdkVersion);
		}
		[Export ("configureUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConfigureUserId (string userId)
		{
			if (userId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configureUserId:"), nsuserId);
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("enableFpsHistogram:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnableFpsHistogram (byte value)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_byte (class_ptr, Selector.GetHandle ("enableFpsHistogram:"), value);
		}
		[Export ("enableHealthHardwareInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnableHealthHardwareInfo (byte value)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_byte (class_ptr, Selector.GetHandle ("enableHealthHardwareInfo:"), value);
		}
		[Export ("enableMemoryHistogram:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnableMemoryHistogram (byte value)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_byte (class_ptr, Selector.GetHandle ("enableMemoryHistogram:"), value);
		}
		[Export ("enableSDKInitEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnableSDKInitEvent (byte value)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_byte (class_ptr, Selector.GetHandle ("enableSDKInitEvent:"), value);
		}
		[Export ("endSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndSession ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("endSession"));
		}
		[Export ("getRemoteConfigsContentAsJSON")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetRemoteConfigsContentAsJSON ()
		{
			return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getRemoteConfigsContentAsJSON")))!;
		}
		[Export ("getRemoteConfigsContentAsString")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetRemoteConfigsContentAsString ()
		{
			return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getRemoteConfigsContentAsString")))!;
		}
		[Export ("getRemoteConfigsValueAsString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetRemoteConfigsValueAsString (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			string? ret;
			ret = CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getRemoteConfigsValueAsString:"), nskey))!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("getRemoteConfigsValueAsString:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetRemoteConfigsValueAsString (string key, string defaultValue)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (defaultValue is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultValue));
			var nskey = CFString.CreateNative (key);
			var nsdefaultValue = CFString.CreateNative (defaultValue);
			string? ret;
			ret = CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("getRemoteConfigsValueAsString:defaultValue:"), nskey, nsdefaultValue))!;
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsdefaultValue);
			return ret!;
		}
		[Export ("initializeWithConfiguredGameKeyAndGameSecret")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitializeWithConfiguredGameKeyAndGameSecret ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("initializeWithConfiguredGameKeyAndGameSecret"));
		}
		[Export ("initializeWithGameKey:gameSecret:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Initialize (string gameKey, string gameSecret)
		{
			if (gameKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gameKey));
			if (gameSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gameSecret));
			var nsgameKey = CFString.CreateNative (gameKey);
			var nsgameSecret = CFString.CreateNative (gameSecret);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("initializeWithGameKey:gameSecret:"), nsgameKey, nsgameSecret);
			CFString.ReleaseNative (nsgameKey);
			CFString.ReleaseNative (nsgameSecret);
		}
		[Export ("pauseTimer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PauseTimer (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("pauseTimer:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("resumeTimer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResumeTimer (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("resumeTimer:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("setCustomDimension01:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCustomDimension01 (string dimension01)
		{
			if (dimension01 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dimension01));
			var nsdimension01 = CFString.CreateNative (dimension01);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setCustomDimension01:"), nsdimension01);
			CFString.ReleaseNative (nsdimension01);
		}
		[Export ("setCustomDimension02:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCustomDimension02 (string dimension02)
		{
			if (dimension02 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dimension02));
			var nsdimension02 = CFString.CreateNative (dimension02);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setCustomDimension02:"), nsdimension02);
			CFString.ReleaseNative (nsdimension02);
		}
		[Export ("setCustomDimension03:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCustomDimension03 (string dimension03)
		{
			if (dimension03 is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dimension03));
			var nsdimension03 = CFString.CreateNative (dimension03);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setCustomDimension03:"), nsdimension03);
			CFString.ReleaseNative (nsdimension03);
		}
		[Export ("setEnabledErrorReporting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnabledErrorReporting (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnabledErrorReporting:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setEnabledEventSubmission:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnabledEventSubmission (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnabledEventSubmission:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setEnabledEventSubmission:doCacheLocally:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnabledEventSubmission (bool doSend, bool doCache)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool_bool (class_ptr, Selector.GetHandle ("setEnabledEventSubmission:doCacheLocally:"), doSend ? (byte) 1 : (byte) 0, doCache ? (byte) 1 : (byte) 0);
		}
		[Export ("setEnabledInfoLog:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnabledInfoLog (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnabledInfoLog:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setEnabledManualSessionHandling:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnabledManualSessionHandling (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnabledManualSessionHandling:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setEnabledVerboseLog:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnabledVerboseLog (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnabledVerboseLog:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setEnabledWarningLog:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnabledWarningLog (bool flag)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnabledWarningLog:"), flag ? (byte) 1 : (byte) 0);
		}
		[Export ("setGlobalCustomEventFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetGlobalCustomEventFields (NSDictionary customFields)
		{
			var customFields__handle__ = customFields!.GetNonNullHandle (nameof (customFields));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setGlobalCustomEventFields:"), customFields__handle__);
		}
		[Export ("setRemoteConfigsDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetRemoteConfigsDelegate (NSObject newDelegate)
		{
			var newDelegate__handle__ = newDelegate!.GetNonNullHandle (nameof (newDelegate));
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setRemoteConfigsDelegate:"), newDelegate__handle__);
		}
		[Export ("startSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartSession ()
		{
			ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("startSession"));
		}
		[Export ("startTimer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartTimer (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("startTimer:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("stopTimer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint StopTimer (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			nint ret;
			ret = ApiDefinitions.Messaging.IntPtr_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("stopTimer:"), nskey);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("useRandomizedId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UseRandomizedId (byte value)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_byte (class_ptr, Selector.GetHandle ("useRandomizedId:"), value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ABTestingId {
			[Export ("getABTestingId")]
			get {
				return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getABTestingId")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ABTestingVariantId {
			[Export ("getABTestingVariantId")]
			get {
				return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getABTestingVariantId")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ExternalUserId {
			[Export ("getExternalUserId")]
			get {
				return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getExternalUserId")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsRemoteConfigsReady {
			[Export ("isRemoteConfigsReady")]
			get {
				byte ret;
				ret = ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isRemoteConfigsReady"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UserId {
			[Export ("getUserId")]
			get {
				return CFString.FromHandle (ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getUserId")))!;
			}
		}
	} /* class GameAnalytics */
}
