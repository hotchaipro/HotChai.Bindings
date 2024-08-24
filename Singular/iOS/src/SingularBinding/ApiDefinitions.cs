using System;
using Foundation;
using ObjCRuntime;
using WebKit;

namespace Singular
{
	// @interface SingularAdData : NSMutableDictionary
	[BaseType(typeof(NSMutableDictionary))]
	interface SingularAdData
	{
		// -(id _Nonnull)initWithAdPlatfrom:(NSString * _Nonnull)adPlatform withCurrency:(NSString * _Nonnull)currency withRevenue:(NSNumber * _Nonnull)revenue;
		[Export("initWithAdPlatfrom:withCurrency:withRevenue:")]
		NativeHandle Constructor(string adPlatform, string currency, NSNumber revenue);

		// -(void)setNetworkName:(NSString * _Nonnull)networkName;
		[Export("setNetworkName:")]
		void SetNetworkName(string networkName);

		// -(void)setAdType:(NSString * _Nonnull)adType;
		[Export("setAdType:")]
		void SetAdType(string adType);

		// -(void)setGroupType:(NSString * _Nonnull)adGroupType;
		[Export("setGroupType:")]
		void SetGroupType(string adGroupType);

		// -(void)setImpressionId:(NSString * _Nonnull)impressionId;
		[Export("setImpressionId:")]
		void SetImpressionId(string impressionId);

		// -(void)setAdPlacementName:(NSString * _Nonnull)adPlacementName;
		[Export("setAdPlacementName:")]
		void SetAdPlacementName(string adPlacementName);

		// -(void)setAdUnitId:(NSString * _Nonnull)adUnitId;
		[Export("setAdUnitId:")]
		void SetAdUnitId(string adUnitId);

		// -(void)setAdGroupId:(NSString * _Nonnull)adGroupId;
		[Export("setAdGroupId:")]
		void SetAdGroupId(string adGroupId);

		// -(void)setAdGroupName:(NSString * _Nonnull)adGroupName;
		[Export("setAdGroupName:")]
		void SetAdGroupName(string adGroupName);

		// -(void)setAdGroupPriority:(NSString * _Nonnull)adGroupPriority;
		[Export("setAdGroupPriority:")]
		void SetAdGroupPriority(string adGroupPriority);

		// -(void)setPrecision:(NSString * _Nonnull)precision;
		[Export("setPrecision:")]
		void SetPrecision(string precision);

		// -(void)setPlacementId:(NSString * _Nonnull)placementId;
		[Export("setPlacementId:")]
		void SetPlacementId(string placementId);

		// -(void)setAdUnitName:(NSString * _Nonnull)adUnitName;
		[Export("setAdUnitName:")]
		void SetAdUnitName(string adUnitName);

		// -(BOOL)hasRequiredParams;
		[Export("hasRequiredParams")]
		bool HasRequiredParams { get; }
	}

	// @interface SingularLinkParams : NSObject
	[BaseType(typeof(NSObject))]
	interface SingularLinkParams
	{
		// -(id)initWithDeeplink:(NSString *)deeplink passthrough:(NSString *)passthrough isDeferred:(BOOL)isDeferred url:(NSURL *)url;
		[Export("initWithDeeplink:passthrough:isDeferred:url:")]
		NativeHandle Constructor(string deeplink, string passthrough, bool isDeferred, NSUrl url);

		// -(NSString *)getDeepLink;
		[Export("getDeepLink")]
		string DeepLink { get; }

		// -(NSString *)getPassthrough;
		[Export("getPassthrough")]
		string Passthrough { get; }

		// -(BOOL)isDeferred;
		[Export("isDeferred")]
		bool IsDeferred { get; }

		// -(NSDictionary *)getUrlParameters;
		[Export("getUrlParameters")]
		NSDictionary UrlParameters { get; }
	}

	// @interface SingularConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface SingularConfig
	{
		// @property NSString * apikey;
		[Export("apikey")]
		string Apikey { get; set; }

		// @property NSString * secret;
		[Export("secret")]
		string Secret { get; set; }

		// @property BOOL clipboardAttribution;
		[Export("clipboardAttribution")]
		bool ClipboardAttribution { get; set; }

		// @property NSDictionary * launchOptions;
		[Export("launchOptions", ArgumentSemantic.Assign)]
		NSDictionary LaunchOptions { get; set; }

		// @property NSUserActivity * userActivity;
		[Export("userActivity", ArgumentSemantic.Assign)]
		NSUserActivity UserActivity { get; set; }

		// @property NSURL * openUrl;
		[Export("openUrl", ArgumentSemantic.Assign)]
		NSUrl OpenUrl { get; set; }

		// @property void (^singularLinksHandler)(SingularLinkParams *);
		[Export("singularLinksHandler", ArgumentSemantic.Assign)]
		Action<SingularLinkParams> SingularLinksHandler { get; set; }

		// @property long shortLinkResolveTimeOut;
		[Export("shortLinkResolveTimeOut")]
		nint ShortLinkResolveTimeOut { get; set; }

		// @property NSArray * supportedDomains __attribute__((deprecated("")));
		//[Export ("supportedDomains", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		//NSObject[] SupportedDomains { get; set; }

		// @property NSArray * espDomains;
		[Export("espDomains", ArgumentSemantic.Assign)]
		NSObject[] EspDomains { get; set; }

		// @property (readonly) NSMutableDictionary * globalProperties;
		[Export("globalProperties")]
		NSMutableDictionary GlobalProperties { get; }

		// @property BOOL skAdNetworkEnabled;
		[Export("skAdNetworkEnabled")]
		bool SkAdNetworkEnabled { get; set; }

		// @property BOOL manualSkanConversionManagement;
		[Export("manualSkanConversionManagement")]
		bool ManualSkanConversionManagement { get; set; }

		// @property void (^conversionValueUpdatedCallback)(NSInteger);
		[Export("conversionValueUpdatedCallback", ArgumentSemantic.Assign)]
		Action<nint> ConversionValueUpdatedCallback { get; set; }

		// @property void (^conversionValuesUpdatedCallback)(NSNumber *, NSNumber *, BOOL);
		[Export("conversionValuesUpdatedCallback", ArgumentSemantic.Assign)]
		Action<NSNumber, NSNumber, bool> ConversionValuesUpdatedCallback { get; set; }

		// @property NSInteger waitForTrackingAuthorizationWithTimeoutInterval;
		[Export("waitForTrackingAuthorizationWithTimeoutInterval")]
		nint WaitForTrackingAuthorizationWithTimeoutInterval { get; set; }

		// @property void (^deviceAttributionCallback)(NSDictionary *);
		[Export("deviceAttributionCallback", ArgumentSemantic.Assign)]
		Action<NSDictionary> DeviceAttributionCallback { get; set; }

		// @property NSString * customSdid;
		[Export("customSdid")]
		string CustomSdid { get; set; }

		// @property SdidAccessorHandler didSetSdidHandler;
		[Export("didSetSdidHandler", ArgumentSemantic.Assign)]
		SdidAccessorHandler DidSetSdidHandler { get; set; }

		// @property SdidAccessorHandler sdidReceivedHandler;
		[Export("sdidReceivedHandler", ArgumentSemantic.Assign)]
		SdidAccessorHandler SdidReceivedHandler { get; set; }

		// -(id)initWithApiKey:(NSString *)apikey andSecret:(NSString *)secret;
		[Export("initWithApiKey:andSecret:")]
		NativeHandle Constructor(string apikey, string secret);

		// -(void)setGlobalProperty:(NSString *)key withValue:(NSString *)value overrideExisting:(BOOL)overrideExisiting;
		[Export("setGlobalProperty:withValue:overrideExisting:")]
		void SetGlobalProperty(string key, string value, bool overrideExisiting);

		// -(NSString *)toJsonString;
		[Export("toJsonString")]
		string ToJsonString { get; }

		// @property BOOL supportAppExtension;
		[Export("supportAppExtension")]
		bool SupportAppExtension { get; set; }

		// @property NSString * appGroupName;
		[Export("appGroupName")]
		string AppGroupName { get; set; }
	}

	// typedef void (^SdidAccessorHandler)(NSString *);
	delegate void SdidAccessorHandler(string arg0);

	// @interface Singular : NSObject
	[BaseType(typeof(NSObject))]
	interface Singular
	{
		// +(BOOL)start:(SingularConfig *)config;
		[Static]
		[Export("start:")]
		bool Start(SingularConfig config);

		// +(void)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret;
		[Static]
		[Export("startSession:withKey:")]
		void StartSession(string apiKey, string apiSecret);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andLaunchOptions:(NSDictionary *)launchOptions withSingularLinkHandler:(void (^)(SingularLinkParams *))handler;
		[Static]
		[Export("startSession:withKey:andLaunchOptions:withSingularLinkHandler:")]
		bool StartSession(string apiKey, string apiSecret, NSDictionary launchOptions, Action<SingularLinkParams> handler);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andLaunchOptions:(NSDictionary *)launchOptions withSingularLinkHandler:(void (^)(SingularLinkParams *))handler andShortLinkResolveTimeout:(long)timeoutSec;
		[Static]
		[Export("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andShortLinkResolveTimeout:")]
		bool StartSession(string apiKey, string apiSecret, NSDictionary launchOptions, Action<SingularLinkParams> handler, nint timeoutSec);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andLaunchOptions:(NSDictionary *)launchOptions withSingularLinkHandler:(void (^)(SingularLinkParams *))handler andSupportedDomains:(NSArray *)domains __attribute__((deprecated("")));
		[Static]
		[Export("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andSupportedDomains:")]
		//[Verify (StronglyTypedNSArray)]
		bool StartSession(string apiKey, string apiSecret, NSDictionary launchOptions, Action<SingularLinkParams> handler, NSObject[] domains);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andLaunchOptions:(NSDictionary *)launchOptions withSingularLinkHandler:(void (^)(SingularLinkParams *))handler andShortLinkResolveTimeout:(long)timeoutSec andSupportedDomains:(NSArray *)domains __attribute__((deprecated("")));
		[Static]
		[Export("startSession:withKey:andLaunchOptions:withSingularLinkHandler:andShortLinkResolveTimeout:andSupportedDomains:")]
		//[Verify (StronglyTypedNSArray)]
		bool StartSession(string apiKey, string apiSecret, NSDictionary launchOptions, Action<SingularLinkParams> handler, nint timeoutSec, NSObject[] domains);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andUserActivity:(NSUserActivity *)userActivity withSingularLinkHandler:(void (^)(SingularLinkParams *))handler;
		[Static]
		[Export("startSession:withKey:andUserActivity:withSingularLinkHandler:")]
		bool StartSession(string apiKey, string apiSecret, NSUserActivity userActivity, Action<SingularLinkParams> handler);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andUserActivity:(NSUserActivity *)userActivity withSingularLinkHandler:(void (^)(SingularLinkParams *))handler andShortLinkResolveTimeout:(long)timeoutSec;
		[Static]
		[Export("startSession:withKey:andUserActivity:withSingularLinkHandler:andShortLinkResolveTimeout:")]
		bool StartSession(string apiKey, string apiSecret, NSUserActivity userActivity, Action<SingularLinkParams> handler, nint timeoutSec);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andUserActivity:(NSUserActivity *)userActivity withSingularLinkHandler:(void (^)(SingularLinkParams *))handler andSupportedDomains:(NSArray *)domains __attribute__((deprecated("")));
		[Static]
		[Export("startSession:withKey:andUserActivity:withSingularLinkHandler:andSupportedDomains:")]
		//[Verify (StronglyTypedNSArray)]
		bool StartSession(string apiKey, string apiSecret, NSUserActivity userActivity, Action<SingularLinkParams> handler, NSObject[] domains);

		// +(BOOL)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andUserActivity:(NSUserActivity *)userActivity withSingularLinkHandler:(void (^)(SingularLinkParams *))handler andShortLinkResolveTimeout:(long)timeoutSec andSupportedDomains:(NSArray *)domains __attribute__((deprecated("")));
		[Static]
		[Export("startSession:withKey:andUserActivity:withSingularLinkHandler:andShortLinkResolveTimeout:andSupportedDomains:")]
		//[Verify (StronglyTypedNSArray)]
		bool StartSession(string apiKey, string apiSecret, NSUserActivity userActivity, Action<SingularLinkParams> handler, nint timeoutSec, NSObject[] domains);

		// +(void)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andLaunchOptions:(NSDictionary *)launchOptions;
		[Static]
		[Export("startSession:withKey:andLaunchOptions:")]
		void StartSession(string apiKey, string apiSecret, NSDictionary launchOptions);

		// +(void)startSession:(NSString *)apiKey withKey:(NSString *)apiSecret andLaunchURL:(NSURL *)url;
		[Static]
		[Export("startSession:withKey:andLaunchURL:")]
		void StartSession(string apiKey, string apiSecret, NSUrl url);

		// +(void)reStartSession:(NSString *)apiKey withKey:(NSString *)apiSecret;
		[Static]
		[Export("reStartSession:withKey:")]
		void ReStartSession(string apiKey, string apiSecret);

		// +(BOOL)sessionStarted;
		[Static]
		[Export("sessionStarted")]
		bool SessionStarted { get; }

		// +(void)endSession;
		[Static]
		[Export("endSession")]
		void EndSession();

		// +(void)event:(NSString *)name;
		[Static]
		[Export("event:")]
		void Event(string name);

		// +(void)event:(NSString *)name withArgs:(NSDictionary *)args;
		[Static]
		[Export("event:withArgs:")]
		void Event(string name, NSDictionary args);

		// +(void)eventWithArgs:(NSString *)name, ...;
		[Static, Internal]
		[Export("eventWithArgs:", IsVariadic = true)]
		void EventWithArgs(string name, IntPtr varArgs);

		// +(void)setDeviceCustomUserId:(NSString *)customUserId;
		[Static]
		[Export("setDeviceCustomUserId:")]
		void SetDeviceCustomUserId(string customUserId);

		// +(void)registerDeviceTokenForUninstall:(NSData *)deviceToken;
		[Static]
		[Export("registerDeviceTokenForUninstall:")]
		void RegisterDeviceTokenForUninstall(NSData deviceToken);

		// +(void)registerDeferredDeepLinkHandler:(void (^)(NSString *))handler;
		[Static]
		[Export("registerDeferredDeepLinkHandler:")]
		void RegisterDeferredDeepLinkHandler(Action<NSString> handler);

		// +(int)setDeferredDeepLinkTimeout:(int)duration;
		[Static]
		[Export("setDeferredDeepLinkTimeout:")]
		int SetDeferredDeepLinkTimeout(int duration);

		// +(Singular *)shared;
		[Static]
		[Export("shared")]
		Singular Shared { get; }

		// +(NSTimeInterval)sessionDuration;
		[Static]
		[Export("sessionDuration")]
		double SessionDuration { get; }

		// +(NSDate *)sessionStartDate;
		[Static]
		[Export("sessionStartDate")]
		NSDate SessionStartDate { get; }

		// +(NSString *)sessionID;
		[Static]
		[Export("sessionID")]
		string SessionID { get; }

		// +(NSString *)version;
		[Static]
		[Export("version")]
		string Version { get; }

		// +(NSString *)singularID;
		[Static]
		[Export("singularID")]
		string SingularID { get; }

		// +(NSString *)singularKeyspace;
		[Static]
		[Export("singularKeyspace")]
		string SingularKeyspace { get; }

		// +(void)setBufferLimit:(int)size;
		[Static]
		[Export("setBufferLimit:")]
		void SetBufferLimit(int size);

		// @property (readonly, nonatomic, strong) NSString * applicationName;
		[Export("applicationName", ArgumentSemantic.Strong)]
		string ApplicationName { get; }

		// @property (readonly, nonatomic, strong) NSString * applicationIdentifier;
		[Export("applicationIdentifier", ArgumentSemantic.Strong)]
		string ApplicationIdentifier { get; }

		// +(BOOL)processJSRequestWK:(WKWebView *)webView withURL:(NSURLRequest *)url;
		[Static]
		[Export("processJSRequestWK:withURL:")]
		bool ProcessJSRequestWK(WKWebView webView, NSUrlRequest url);

		// @property (nonatomic) int minSessionDuration;
		[Export("minSessionDuration")]
		int MinSessionDuration { get; set; }

		// +(void)setMinSessionDuration:(int)seconds;
		[Static]
		[Export("setMinSessionDuration:")]
		void SetMinSessionDuration(int seconds);

		// +(void)initializeApStore;
		[Static]
		[Export("initializeApStore")]
		void InitializeApStore();

		// +(void)setAllowAutoIAPComplete:(BOOL)boolean;
		[Static]
		[Export("setAllowAutoIAPComplete:")]
		void SetAllowAutoIAPComplete(bool boolean);

		// +(void)iapComplete:(id)transaction;
		[Static]
		[Export("iapComplete:")]
		void IapComplete(NSObject transaction);

		// +(void)iapComplete:(id)transaction withName:(NSString *)name;
		[Static]
		[Export("iapComplete:withName:")]
		void IapComplete(NSObject transaction, string name);

		// +(void)iapComplete:(id)transaction withAttributes:(id)value, ...;
		[Static, Internal]
		[Export("iapComplete:withAttributes:", IsVariadic = true)]
		void IapComplete(NSObject transaction, NSObject value, IntPtr varArgs);

		// +(void)iapComplete:(id)transaction withName:(NSString *)name withAttributes:(id)value, ...;
		[Static, Internal]
		[Export("iapComplete:withName:withAttributes:", IsVariadic = true)]
		void IapComplete(NSObject transaction, string name, NSObject value, IntPtr varArgs);

		// +(void)setGender:(NSString *)gender;
		[Static]
		[Export("setGender:")]
		void SetGender(string gender);

		// +(void)setAge:(id)age;
		[Static]
		[Export("setAge:")]
		void SetAge(NSObject age);

		// +(int)batchInterval;
		// +(void)setBatchInterval:(int)interval;
		[Static]
		[Export("batchInterval")]
		int BatchInterval { get; set; }

		// +(BOOL)batchesEvents;
		[Static]
		[Export("batchesEvents")]
		bool BatchesEvents();

		// +(void)setBatchesEvents:(BOOL)boolean;
		[Static]
		[Export("setBatchesEvents:")]
		void SetBatchesEvents(bool boolean);

		// +(void)sendAllBatches;
		[Static]
		[Export("sendAllBatches")]
		void SendAllBatches();

		// +(void)revenue:(id)transaction;
		[Static]
		[Export("revenue:")]
		void Revenue(NSObject transaction);

		// +(void)revenue:(id)transaction withAttributes:(NSDictionary *)attributes;
		[Static]
		[Export("revenue:withAttributes:")]
		void Revenue(NSObject transaction, NSDictionary attributes);

		// +(void)revenue:(NSString *)currency amount:(double)amount;
		[Static]
		[Export("revenue:amount:")]
		void Revenue(string currency, double amount);

		// +(void)revenue:(NSString *)currency amount:(double)amount withAttributes:(NSDictionary *)attributes;
		[Static]
		[Export("revenue:amount:withAttributes:")]
		void Revenue(string currency, double amount, NSDictionary attributes);

		// +(void)revenue:(NSString *)currency amount:(double)amount productSKU:(NSString *)productSKU productName:(NSString *)productName productCategory:(NSString *)productCategory productQuantity:(int)productQuantity productPrice:(double)productPrice;
		[Static]
		[Export("revenue:amount:productSKU:productName:productCategory:productQuantity:productPrice:")]
		void Revenue(string currency, double amount, string productSKU, string productName, string productCategory, int productQuantity, double productPrice);

		// +(void)customRevenue:(NSString *)eventname transaction:(id)transaction;
		[Static]
		[Export("customRevenue:transaction:")]
		void CustomRevenue(string eventname, NSObject transaction);

		// +(void)customRevenue:(NSString *)eventname transaction:(id)transaction withAttributes:(NSDictionary *)attributes;
		[Static]
		[Export("customRevenue:transaction:withAttributes:")]
		void CustomRevenue(string eventname, NSObject transaction, NSDictionary attributes);

		// +(void)customRevenue:(NSString *)eventname currency:(NSString *)currency amount:(double)amount;
		[Static]
		[Export("customRevenue:currency:amount:")]
		void CustomRevenue(string eventname, string currency, double amount);

		// +(void)customRevenue:(NSString *)eventname currency:(NSString *)currency amount:(double)amount withAttributes:(NSDictionary *)attributes;
		[Static]
		[Export("customRevenue:currency:amount:withAttributes:")]
		void CustomRevenue(string eventname, string currency, double amount, NSDictionary attributes);

		// +(void)customRevenue:(NSString *)eventname currency:(NSString *)currency amount:(double)amount productSKU:(NSString *)productSKU productName:(NSString *)productName productCategory:(NSString *)productCategory productQuantity:(int)productQuantity productPrice:(double)productPrice;
		[Static]
		[Export("customRevenue:currency:amount:productSKU:productName:productCategory:productQuantity:productPrice:")]
		void CustomRevenue(string eventname, string currency, double amount, string productSKU, string productName, string productCategory, int productQuantity, double productPrice);

		// +(void)customRevenue:(NSData *)transactionJsonRepresentation productJsonRepresentation:(NSData *)productJsonRepresentation;
		[Static]
		[Export("customRevenue:productJsonRepresentation:")]
		void CustomRevenue(NSData transactionJsonRepresentation, NSData productJsonRepresentation);

		// +(void)customRevenue:(NSString *)eventName transactionJsonRepresentation:(NSData *)transactionJsonRepresentation productJsonRepresentation:(NSData *)productJsonRepresentation;
		[Static]
		[Export("customRevenue:transactionJsonRepresentation:productJsonRepresentation:")]
		void CustomRevenue(string eventName, NSData transactionJsonRepresentation, NSData productJsonRepresentation);

		// +(void)setCustomUserId:(NSString *)customUserId;
		[Static]
		[Export("setCustomUserId:")]
		void SetCustomUserId(string customUserId);

		// +(void)unsetCustomUserId;
		[Static]
		[Export("unsetCustomUserId")]
		void UnsetCustomUserId();

		// +(void)setSessionTimeout:(int)timeout;
		[Static]
		[Export("setSessionTimeout:")]
		void SetSessionTimeout(int timeout);

		// +(NSInteger)getFirstSessionUnixTime;
		[Static]
		[Export("getFirstSessionUnixTime")]
		nint GetFirstSessionUnixTime();

		// +(void)setWrapperName:(NSString *)name andVersion:(NSString *)version;
		[Static]
		[Export("setWrapperName:andVersion:")]
		void SetWrapperName(string name, string version);

		// +(NSDictionary *)getGlobalProperties;
		[Static]
		[Export("getGlobalProperties")]
		NSDictionary GetGlobalProperties();

		// +(BOOL)setGlobalProperty:(NSString *)key andValue:(NSString *)value overrideExisting:(BOOL)overrideExisting;
		[Static]
		[Export("setGlobalProperty:andValue:overrideExisting:")]
		bool SetGlobalProperty(string key, string value, bool overrideExisting);

		// +(void)unsetGlobalProperty:(NSString *)key;
		[Static]
		[Export("unsetGlobalProperty:")]
		void UnsetGlobalProperty(string key);

		// +(void)clearGlobalProperties;
		[Static]
		[Export("clearGlobalProperties")]
		void ClearGlobalProperties();

		// +(void)trackingOptIn;
		[Static]
		[Export("trackingOptIn")]
		void TrackingOptIn();

		// +(void)trackingUnder13;
		[Static]
		[Export("trackingUnder13")]
		void TrackingUnder13();

		// +(void)stopAllTracking;
		[Static]
		[Export("stopAllTracking")]
		void StopAllTracking();

		// +(void)resumeAllTracking;
		[Static]
		[Export("resumeAllTracking")]
		void ResumeAllTracking();

		// +(BOOL)isAllTrackingStopped;
		[Static]
		[Export("isAllTrackingStopped")]
		bool IsAllTrackingStopped();

		// +(void)limitDataSharing:(BOOL)shouldLimitDataSharing;
		[Static]
		[Export("limitDataSharing:")]
		void LimitDataSharing(bool shouldLimitDataSharing);

		// +(BOOL)getLimitDataSharing;
		[Static]
		[Export("getLimitDataSharing")]
		bool GetLimitDataSharing();

		// +(void)skanRegisterAppForAdNetworkAttribution;
		[Static]
		[Export("skanRegisterAppForAdNetworkAttribution")]
		void SkanRegisterAppForAdNetworkAttribution();

		// +(BOOL)skanUpdateConversionValue:(NSInteger)conversionValue;
		[Static]
		[Export("skanUpdateConversionValue:")]
		bool SkanUpdateConversionValue(nint conversionValue);

		// +(void)skanUpdateConversionValue:(NSInteger)conversionValue coarse:(NSInteger)coarse lock:(BOOL)lock;
		[Static]
		[Export("skanUpdateConversionValue:coarse:lock:")]
		void SkanUpdateConversionValue(nint conversionValue, nint coarse, bool @lock);

		// +(NSNumber *)skanGetConversionValue;
		[Static]
		[Export("skanGetConversionValue")]
		NSNumber SkanGetConversionValue();

		// +(BOOL)isSingularLink:(id)linkHolder;
		[Static]
		[Export("isSingularLink:")]
		bool IsSingularLink(NSObject linkHolder);

		// +(void)adRevenue:(SingularAdData *)adData;
		[Static]
		[Export("adRevenue:")]
		void AdRevenue(SingularAdData adData);

		// +(void)createReferrerShortLink:(NSString *)baseLink referrerName:(NSString *)referrerName referrerId:(NSString *)referrerId completionHandler:(void (^)(NSString *, NSError *))completionHandler;
		[Static]
		[Export("createReferrerShortLink:referrerName:referrerId:completionHandler:")]
		void CreateReferrerShortLink(string baseLink, string referrerName, string referrerId, Action<NSString, NSError> completionHandler);

		// +(void)createReferrerShortLink:(NSString *)baseLink referrerName:(NSString *)referrerName referrerId:(NSString *)referrerId passthroughParams:(NSDictionary *)passthroughParams completionHandler:(void (^)(NSString *, NSError *))completionHandler;
		[Static]
		[Export("createReferrerShortLink:referrerName:referrerId:passthroughParams:completionHandler:")]
		void CreateReferrerShortLink(string baseLink, string referrerName, string referrerId, NSDictionary passthroughParams, Action<NSString, NSError> completionHandler);
	}
}
