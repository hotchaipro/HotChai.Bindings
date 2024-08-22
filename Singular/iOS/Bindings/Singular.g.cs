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
	[Register("Singular", true)]
	public unsafe partial class Singular : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("Singular");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Singular () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Singular (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Singular (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::SingularSDK.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("adRevenue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AdRevenue (SingularAdData adData)
		{
			var adData__handle__ = adData!.GetNonNullHandle (nameof (adData));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("adRevenue:"), adData__handle__);
		}
		[Export ("batchesEvents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool BatchesEvents ()
		{
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("batchesEvents"));
			return ret != 0;
		}
		[Export ("clearGlobalProperties")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClearGlobalProperties ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearGlobalProperties"));
		}
		[Export ("createReferrerShortLink:referrerName:referrerId:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CreateReferrerShortLink (string baseLink, string referrerName, string referrerId, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSString, NSError> completionHandler)
		{
			if (baseLink is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (baseLink));
			if (referrerName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (referrerName));
			if (referrerId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (referrerId));
			if (completionHandler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsbaseLink = CFString.CreateNative (baseLink);
			var nsreferrerName = CFString.CreateNative (referrerName);
			var nsreferrerId = CFString.CreateNative (referrerId);
			using var block_completionHandler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity2V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("createReferrerShortLink:referrerName:referrerId:completionHandler:"), nsbaseLink, nsreferrerName, nsreferrerId, (IntPtr) block_ptr_completionHandler);
			CFString.ReleaseNative (nsbaseLink);
			CFString.ReleaseNative (nsreferrerName);
			CFString.ReleaseNative (nsreferrerId);
		}
		[Export ("createReferrerShortLink:referrerName:referrerId:passthroughParams:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CreateReferrerShortLink (string baseLink, string referrerName, string referrerId, NSDictionary passthroughParams, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSString, NSError> completionHandler)
		{
			if (baseLink is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (baseLink));
			if (referrerName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (referrerName));
			if (referrerId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (referrerId));
			var passthroughParams__handle__ = passthroughParams!.GetNonNullHandle (nameof (passthroughParams));
			if (completionHandler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsbaseLink = CFString.CreateNative (baseLink);
			var nsreferrerName = CFString.CreateNative (referrerName);
			var nsreferrerId = CFString.CreateNative (referrerId);
			using var block_completionHandler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity2V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("createReferrerShortLink:referrerName:referrerId:passthroughParams:completionHandler:"), nsbaseLink, nsreferrerName, nsreferrerId, passthroughParams__handle__, (IntPtr) block_ptr_completionHandler);
			CFString.ReleaseNative (nsbaseLink);
			CFString.ReleaseNative (nsreferrerName);
			CFString.ReleaseNative (nsreferrerId);
		}
		[Export ("customRevenue:transaction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomRevenue (string eventname, NSObject transaction)
		{
			if (eventname is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventname));
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			var nseventname = CFString.CreateNative (eventname);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("customRevenue:transaction:"), nseventname, transaction__handle__);
			CFString.ReleaseNative (nseventname);
		}
		[Export ("customRevenue:transaction:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomRevenue (string eventname, NSObject transaction, NSDictionary attributes)
		{
			if (eventname is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventname));
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var nseventname = CFString.CreateNative (eventname);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("customRevenue:transaction:withAttributes:"), nseventname, transaction__handle__, attributes__handle__);
			CFString.ReleaseNative (nseventname);
		}
		[Export ("customRevenue:currency:amount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomRevenue (string eventname, string currency, double amount)
		{
			if (eventname is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventname));
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var nseventname = CFString.CreateNative (eventname);
			var nscurrency = CFString.CreateNative (currency);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double (class_ptr, Selector.GetHandle ("customRevenue:currency:amount:"), nseventname, nscurrency, amount);
			CFString.ReleaseNative (nseventname);
			CFString.ReleaseNative (nscurrency);
		}
		[Export ("customRevenue:currency:amount:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomRevenue (string eventname, string currency, double amount, NSDictionary attributes)
		{
			if (eventname is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventname));
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var nseventname = CFString.CreateNative (eventname);
			var nscurrency = CFString.CreateNative (currency);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle (class_ptr, Selector.GetHandle ("customRevenue:currency:amount:withAttributes:"), nseventname, nscurrency, amount, attributes__handle__);
			CFString.ReleaseNative (nseventname);
			CFString.ReleaseNative (nscurrency);
		}
		[Export ("customRevenue:currency:amount:productSKU:productName:productCategory:productQuantity:productPrice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomRevenue (string eventname, string currency, double amount, string productSKU, string productName, string productCategory, int productQuantity, double productPrice)
		{
			if (eventname is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventname));
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (productSKU is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productSKU));
			if (productName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productName));
			if (productCategory is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productCategory));
			var nseventname = CFString.CreateNative (eventname);
			var nscurrency = CFString.CreateNative (currency);
			var nsproductSKU = CFString.CreateNative (productSKU);
			var nsproductName = CFString.CreateNative (productName);
			var nsproductCategory = CFString.CreateNative (productCategory);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_int_Double (class_ptr, Selector.GetHandle ("customRevenue:currency:amount:productSKU:productName:productCategory:productQuantity:productPrice:"), nseventname, nscurrency, amount, nsproductSKU, nsproductName, nsproductCategory, productQuantity, productPrice);
			CFString.ReleaseNative (nseventname);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsproductSKU);
			CFString.ReleaseNative (nsproductName);
			CFString.ReleaseNative (nsproductCategory);
		}
		[Export ("customRevenue:productJsonRepresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomRevenue (NSData transactionJsonRepresentation, NSData productJsonRepresentation)
		{
			var transactionJsonRepresentation__handle__ = transactionJsonRepresentation!.GetNonNullHandle (nameof (transactionJsonRepresentation));
			var productJsonRepresentation__handle__ = productJsonRepresentation!.GetNonNullHandle (nameof (productJsonRepresentation));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("customRevenue:productJsonRepresentation:"), transactionJsonRepresentation__handle__, productJsonRepresentation__handle__);
		}
		[Export ("customRevenue:transactionJsonRepresentation:productJsonRepresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomRevenue (string eventName, NSData transactionJsonRepresentation, NSData productJsonRepresentation)
		{
			if (eventName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventName));
			var transactionJsonRepresentation__handle__ = transactionJsonRepresentation!.GetNonNullHandle (nameof (transactionJsonRepresentation));
			var productJsonRepresentation__handle__ = productJsonRepresentation!.GetNonNullHandle (nameof (productJsonRepresentation));
			var nseventName = CFString.CreateNative (eventName);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("customRevenue:transactionJsonRepresentation:productJsonRepresentation:"), nseventName, transactionJsonRepresentation__handle__, productJsonRepresentation__handle__);
			CFString.ReleaseNative (nseventName);
		}
		[Export ("endSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndSession ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("endSession"));
		}
		[Export ("event:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Event (string name)
		{
			if (name is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("event:"), nsname);
			CFString.ReleaseNative (nsname);
		}
		[Export ("event:withArgs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Event (string name, NSDictionary args)
		{
			if (name is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var args__handle__ = args!.GetNonNullHandle (nameof (args));
			var nsname = CFString.CreateNative (name);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("event:withArgs:"), nsname, args__handle__);
			CFString.ReleaseNative (nsname);
		}
		//public static void Event(string name, System.Collections.Generic.Dictionary<string, object> args)
		//{
		//	var nsDictionary = new NSMutableDictionary();
		//	foreach (var kvp in args)
		//	{
		//		nsDictionary.Add((NSString)kvp.Key, (NSObject)kvp.Value);
		//	}
		//	Event(name, nsDictionary);
		//	nsDictionary.Dispose();
		//}
		//[Export ("eventWithArgs:", IsVariadic = true)]
		//[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		//internal static void EventWithArgs (string name, nint varArgs)
		//{
		//	if (name is null)
		//		global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
		//	var nsname = CFString.CreateNative (name);
		//	global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("eventWithArgs:"), nsname, varArgs);
		//	CFString.ReleaseNative (nsname);
		//}
		[Export ("getFirstSessionUnixTime")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetFirstSessionUnixTime ()
		{
			return global::SingularSDK.ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getFirstSessionUnixTime"));
		}
		[Export ("getGlobalProperties")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetGlobalProperties ()
		{
			return  Runtime.GetNSObject<NSDictionary> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getGlobalProperties")))!;
		}
		[Export ("getLimitDataSharing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetLimitDataSharing ()
		{
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("getLimitDataSharing"));
			return ret != 0;
		}
		[Export ("iapComplete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void IapComplete (NSObject transaction)
		{
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("iapComplete:"), transaction__handle__);
		}
		[Export ("iapComplete:withName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void IapComplete (NSObject transaction, string name)
		{
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			if (name is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("iapComplete:withName:"), transaction__handle__, nsname);
			CFString.ReleaseNative (nsname);
		}
		[Export ("iapComplete:withAttributes:", IsVariadic = true)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void IapComplete (NSObject transaction, NSObject value, nint varArgs)
		{
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("iapComplete:withAttributes:"), transaction__handle__, value__handle__, varArgs);
		}
		[Export ("iapComplete:withName:withAttributes:", IsVariadic = true)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void IapComplete (NSObject transaction, string name, NSObject value, nint varArgs)
		{
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			if (name is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nsname = CFString.CreateNative (name);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("iapComplete:withName:withAttributes:"), transaction__handle__, nsname, value__handle__, varArgs);
			CFString.ReleaseNative (nsname);
		}
		[Export ("initializeApStore")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitializeApStore ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("initializeApStore"));
		}
		[Export ("isAllTrackingStopped")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAllTrackingStopped ()
		{
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isAllTrackingStopped"));
			return ret != 0;
		}
		[Export ("isSingularLink:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSingularLink (NSObject linkHolder)
		{
			var linkHolder__handle__ = linkHolder!.GetNonNullHandle (nameof (linkHolder));
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isSingularLink:"), linkHolder__handle__);
			return ret != 0;
		}
		[Export ("limitDataSharing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LimitDataSharing (bool shouldLimitDataSharing)
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("limitDataSharing:"), shouldLimitDataSharing ? (byte) 1 : (byte) 0);
		}
		[Export ("processJSRequestWK:withURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ProcessJSRequestWK (global::WebKit.WKWebView webView, NSUrlRequest url)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("processJSRequestWK:withURL:"), webView__handle__, url__handle__);
			return ret != 0;
		}
		[Export ("reStartSession:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReStartSession (string apiKey, string apiSecret)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("reStartSession:withKey:"), nsapiKey, nsapiSecret);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
		}
		[Export ("registerDeferredDeepLinkHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RegisterDeferredDeepLinkHandler ([BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSString> handler)
		{
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V0.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("registerDeferredDeepLinkHandler:"), (IntPtr) block_ptr_handler);
		}
		[Export ("registerDeviceTokenForUninstall:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterDeviceTokenForUninstall (NSData deviceToken)
		{
			var deviceToken__handle__ = deviceToken!.GetNonNullHandle (nameof (deviceToken));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("registerDeviceTokenForUninstall:"), deviceToken__handle__);
		}
		[Export ("resumeAllTracking")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResumeAllTracking ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("resumeAllTracking"));
		}
		[Export ("revenue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Revenue (NSObject transaction)
		{
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("revenue:"), transaction__handle__);
		}
		[Export ("revenue:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Revenue (NSObject transaction, NSDictionary attributes)
		{
			var transaction__handle__ = transaction!.GetNonNullHandle (nameof (transaction));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("revenue:withAttributes:"), transaction__handle__, attributes__handle__);
		}
		[Export ("revenue:amount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Revenue (string currency, double amount)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var nscurrency = CFString.CreateNative (currency);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("revenue:amount:"), nscurrency, amount);
			CFString.ReleaseNative (nscurrency);
		}
		[Export ("revenue:amount:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Revenue (string currency, double amount, NSDictionary attributes)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var nscurrency = CFString.CreateNative (currency);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_Double_NativeHandle (class_ptr, Selector.GetHandle ("revenue:amount:withAttributes:"), nscurrency, amount, attributes__handle__);
			CFString.ReleaseNative (nscurrency);
		}
		[Export ("revenue:amount:productSKU:productName:productCategory:productQuantity:productPrice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Revenue (string currency, double amount, string productSKU, string productName, string productCategory, int productQuantity, double productPrice)
		{
			if (currency is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (currency));
			if (productSKU is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productSKU));
			if (productName is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productName));
			if (productCategory is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (productCategory));
			var nscurrency = CFString.CreateNative (currency);
			var nsproductSKU = CFString.CreateNative (productSKU);
			var nsproductName = CFString.CreateNative (productName);
			var nsproductCategory = CFString.CreateNative (productCategory);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_int_Double (class_ptr, Selector.GetHandle ("revenue:amount:productSKU:productName:productCategory:productQuantity:productPrice:"), nscurrency, amount, nsproductSKU, nsproductName, nsproductCategory, productQuantity, productPrice);
			CFString.ReleaseNative (nscurrency);
			CFString.ReleaseNative (nsproductSKU);
			CFString.ReleaseNative (nsproductName);
			CFString.ReleaseNative (nsproductCategory);
		}
		[Export ("sendAllBatches")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendAllBatches ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("sendAllBatches"));
		}
		[Export ("setAge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAge (NSObject age)
		{
			var age__handle__ = age!.GetNonNullHandle (nameof (age));
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setAge:"), age__handle__);
		}
		[Export ("setAllowAutoIAPComplete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAllowAutoIAPComplete (bool boolean)
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAllowAutoIAPComplete:"), boolean ? (byte) 1 : (byte) 0);
		}
		[Export ("setBatchesEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBatchesEvents (bool boolean)
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setBatchesEvents:"), boolean ? (byte) 1 : (byte) 0);
		}
		[Export ("setBufferLimit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBufferLimit (int size)
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setBufferLimit:"), size);
		}
		[Export ("setCustomUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCustomUserId (string customUserId)
		{
			if (customUserId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (customUserId));
			var nscustomUserId = CFString.CreateNative (customUserId);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setCustomUserId:"), nscustomUserId);
			CFString.ReleaseNative (nscustomUserId);
		}
		[Export ("setDeferredDeepLinkTimeout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int SetDeferredDeepLinkTimeout (int duration)
		{
			return global::SingularSDK.ApiDefinitions.Messaging.int_objc_msgSend_int (class_ptr, Selector.GetHandle ("setDeferredDeepLinkTimeout:"), duration);
		}
		[Export ("setDeviceCustomUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDeviceCustomUserId (string customUserId)
		{
			if (customUserId is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (customUserId));
			var nscustomUserId = CFString.CreateNative (customUserId);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setDeviceCustomUserId:"), nscustomUserId);
			CFString.ReleaseNative (nscustomUserId);
		}
		[Export ("setGender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetGender (string gender)
		{
			if (gender is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gender));
			var nsgender = CFString.CreateNative (gender);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setGender:"), nsgender);
			CFString.ReleaseNative (nsgender);
		}
		[Export ("setGlobalProperty:andValue:overrideExisting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetGlobalProperty (string key, string value, bool overrideExisting)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (value is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("setGlobalProperty:andValue:overrideExisting:"), nskey, nsvalue, overrideExisting ? (byte) 1 : (byte) 0);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
		[Export ("setMinSessionDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMinSessionDuration (int seconds)
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setMinSessionDuration:"), seconds);
		}
		[Export ("setSessionTimeout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSessionTimeout (int timeout)
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setSessionTimeout:"), timeout);
		}
		[Export ("setWrapperName:andVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWrapperName (string name, string version)
		{
			if (name is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (version is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (version));
			var nsname = CFString.CreateNative (name);
			var nsversion = CFString.CreateNative (version);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setWrapperName:andVersion:"), nsname, nsversion);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsversion);
		}
		[Export ("skanGetConversionValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber SkanGetConversionValue ()
		{
			return  Runtime.GetNSObject<NSNumber> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("skanGetConversionValue")))!;
		}
		[Export ("skanRegisterAppForAdNetworkAttribution")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SkanRegisterAppForAdNetworkAttribution ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("skanRegisterAppForAdNetworkAttribution"));
		}
		[Export ("skanUpdateConversionValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SkanUpdateConversionValue (nint conversionValue)
		{
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("skanUpdateConversionValue:"), conversionValue);
			return ret != 0;
		}
		[Export ("skanUpdateConversionValue:coarse:lock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SkanUpdateConversionValue (nint conversionValue, nint coarse, bool @lock)
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("skanUpdateConversionValue:coarse:lock:"), conversionValue, coarse, @lock ? (byte) 1 : (byte) 0);
		}
		[Export ("start:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Start (SingularConfig config)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("start:"), config__handle__);
			return ret != 0;
		}
		[Export ("startSession:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartSession (string apiKey, string apiSecret)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:"), nsapiKey, nsapiSecret);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
		}
		[Export ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSDictionary launchOptions, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:"), nsapiKey, nsapiSecret, launchOptions__handle__, (IntPtr) block_ptr_handler);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			return ret != 0;
		}
		[Export ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andShortLinkResolveTimeout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSDictionary launchOptions, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler, nint timeoutSec)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andShortLinkResolveTimeout:"), nsapiKey, nsapiSecret, launchOptions__handle__, (IntPtr) block_ptr_handler, timeoutSec);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			return ret != 0;
		}
		[Export ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andSupportedDomains:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSDictionary launchOptions, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler, NSObject[] domains)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			if (domains is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domains));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			var nsa_domains = NSArray.FromNSObjects (domains);
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andSupportedDomains:"), nsapiKey, nsapiSecret, launchOptions__handle__, (IntPtr) block_ptr_handler, nsa_domains.Handle);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			nsa_domains.Dispose ();
			return ret != 0;
		}
		[Export ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andShortLinkResolveTimeout:andSupportedDomains:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSDictionary launchOptions, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler, nint timeoutSec, NSObject[] domains)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			if (domains is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domains));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			var nsa_domains = NSArray.FromNSObjects (domains);
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andShortLinkResolveTimeout:andSupportedDomains:"), nsapiKey, nsapiSecret, launchOptions__handle__, (IntPtr) block_ptr_handler, timeoutSec, nsa_domains.Handle);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			nsa_domains.Dispose ();
			return ret != 0;
		}
		[Export ("startSession:withKey:andUserActivity:withSingularLinkHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSUserActivity userActivity, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andUserActivity:withSingularLinkHandler:"), nsapiKey, nsapiSecret, userActivity__handle__, (IntPtr) block_ptr_handler);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			return ret != 0;
		}
		[Export ("startSession:withKey:andUserActivity:withSingularLinkHandler:andShortLinkResolveTimeout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSUserActivity userActivity, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler, nint timeoutSec)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("startSession:withKey:andUserActivity:withSingularLinkHandler:andShortLinkResolveTimeout:"), nsapiKey, nsapiSecret, userActivity__handle__, (IntPtr) block_ptr_handler, timeoutSec);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			return ret != 0;
		}
		[Export ("startSession:withKey:andUserActivity:withSingularLinkHandler:andSupportedDomains:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSUserActivity userActivity, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler, NSObject[] domains)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			if (domains is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domains));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			var nsa_domains = NSArray.FromNSObjects (domains);
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andUserActivity:withSingularLinkHandler:andSupportedDomains:"), nsapiKey, nsapiSecret, userActivity__handle__, (IntPtr) block_ptr_handler, nsa_domains.Handle);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			nsa_domains.Dispose ();
			return ret != 0;
		}
		[Export ("startSession:withKey:andUserActivity:withSingularLinkHandler:andShortLinkResolveTimeout:andSupportedDomains:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool StartSession (string apiKey, string apiSecret, NSUserActivity userActivity, [BlockProxy (typeof (global::SingularSDK.ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<SingularLinkParams> handler, nint timeoutSec, NSObject[] domains)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (handler is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			if (domains is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domains));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			using var block_handler = global::SingularSDK.ObjCRuntime.Trampolines.SDActionArity1V1.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			var nsa_domains = NSArray.FromNSObjects (domains);
			byte ret;
			ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andUserActivity:withSingularLinkHandler:andShortLinkResolveTimeout:andSupportedDomains:"), nsapiKey, nsapiSecret, userActivity__handle__, (IntPtr) block_ptr_handler, timeoutSec, nsa_domains.Handle);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
			nsa_domains.Dispose ();
			return ret != 0;
		}
		[Export ("startSession:withKey:andLaunchOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartSession (string apiKey, string apiSecret, NSDictionary launchOptions)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andLaunchOptions:"), nsapiKey, nsapiSecret, launchOptions__handle__);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
		}
		[Export ("startSession:withKey:andLaunchURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartSession (string apiKey, string apiSecret, NSUrl url)
		{
			if (apiKey is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (apiSecret is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiSecret));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsapiSecret = CFString.CreateNative (apiSecret);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("startSession:withKey:andLaunchURL:"), nsapiKey, nsapiSecret, url__handle__);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsapiSecret);
		}
		[Export ("stopAllTracking")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopAllTracking ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("stopAllTracking"));
		}
		[Export ("trackingOptIn")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TrackingOptIn ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("trackingOptIn"));
		}
		[Export ("trackingUnder13")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TrackingUnder13 ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("trackingUnder13"));
		}
		[Export ("unsetCustomUserId")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UnsetCustomUserId ()
		{
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("unsetCustomUserId"));
		}
		[Export ("unsetGlobalProperty:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UnsetGlobalProperty (string key)
		{
			if (key is null)
				global::ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("unsetGlobalProperty:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ApplicationIdentifier {
			[Export ("applicationIdentifier", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("applicationIdentifier")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationIdentifier")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ApplicationName {
			[Export ("applicationName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("applicationName")))!;
				} else {
					return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int BatchInterval {
			[Export ("batchInterval")]
			get {
				return global::SingularSDK.ApiDefinitions.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("batchInterval"));
			}
			[Export ("setBatchInterval:")]
			set {
				global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setBatchInterval:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int MinSessionDuration {
			[Export ("minSessionDuration")]
			get {
				if (IsDirectBinding) {
					return global::SingularSDK.ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("minSessionDuration"));
				} else {
					return global::SingularSDK.ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minSessionDuration"));
				}
			}
			[Export ("setMinSessionDuration:")]
			set {
				if (IsDirectBinding) {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMinSessionDuration:"), value);
				} else {
					global::SingularSDK.ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMinSessionDuration:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double SessionDuration {
			[Export ("sessionDuration")]
			get {
				return global::SingularSDK.ApiDefinitions.Messaging.Double_objc_msgSend (class_ptr, Selector.GetHandle ("sessionDuration"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string SessionID {
			[Export ("sessionID")]
			get {
				return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sessionID")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate SessionStartDate {
			[Export ("sessionStartDate")]
			get {
				NSDate? ret;
				ret =  Runtime.GetNSObject<NSDate> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sessionStartDate")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SessionStarted {
			[Export ("sessionStarted")]
			get {
				byte ret;
				ret = global::SingularSDK.ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("sessionStarted"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Singular Shared {
			[Export ("shared")]
			get {
				Singular? ret;
				ret =  Runtime.GetNSObject<Singular> (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("shared")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string SingularID {
			[Export ("singularID")]
			get {
				return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("singularID")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string SingularKeyspace {
			[Export ("singularKeyspace")]
			get {
				return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("singularKeyspace")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string Version {
			[Export ("version")]
			get {
				return CFString.FromHandle (global::SingularSDK.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("version")))!;
			}
		}
	} /* class Singular */
}
