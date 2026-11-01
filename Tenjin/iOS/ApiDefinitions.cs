using System;
using Foundation;
using ObjCRuntime;
using StoreKit;

namespace Tenjin
{
	// The documented API of TenjinSDK.h (1.20.1), less what's deprecated: the class methods the SDK
	// is used through, and the instance's attribution info and deep link handler
	[BaseType(typeof(NSObject), Name = "TenjinSDK")]
	[DisableDefaultCtor]
	interface TenjinSDK
	{
		// + (TenjinSDK *)initialize:(NSString *)apiToken;
		[Static]
		[Export("initialize:")]
		TenjinSDK Initialize(string apiToken);

		// + (TenjinSDK *)initialize:(NSString *)apiToken andSharedSecret:(NSString *)secret;
		[Static]
		[Export("initialize:andSharedSecret:")]
		TenjinSDK Initialize(string apiToken, string secret);

		// + (TenjinSDK *)sharedInstance;
		[Static]
		[NullAllowed, Export("sharedInstance")]
		TenjinSDK SharedInstance { get; }

		// + (void)connect;
		[Static]
		[Export("connect")]
		void Connect();

		// + (void)connectWithDeferredDeeplink:(NSURL *)url;
		[Static]
		[Export("connectWithDeferredDeeplink:")]
		void Connect(NSUrl url);

		// + (void)handleOpenURL:(NSURL *)url;
		[Static]
		[Export("handleOpenURL:")]
		void HandleOpenUrl(NSUrl url);

		// + (void)handleOpenURLString:(NSString *)urlString;
		[Static]
		[Export("handleOpenURLString:")]
		void HandleOpenUrl(string urlString);

		// + (void)sendEventWithName:(NSString *)eventName;
		[Static]
		[Export("sendEventWithName:")]
		void SendEvent(string eventName);

		// + (void)sendEventWithName:(NSString *)eventName andValue:(NSInteger)eventValue;
		[Static]
		[Export("sendEventWithName:andValue:")]
		void SendEvent(string eventName, nint eventValue);

		// + (void)transaction:(SKPaymentTransaction *)transaction andReceipt:(NSData *)receipt;
		[Static]
		[Export("transaction:andReceipt:")]
		void Transaction(SKPaymentTransaction transaction, NSData receipt);

		// + (void)transactionWithProductName:(NSString *)productName andCurrencyCode:(NSString *)currencyCode andQuantity:(NSInteger)quantity andUnitPrice:(NSDecimalNumber *)price andTransactionId:(NSString *)transactionId andBase64Receipt:(NSString *)receipt;
		[Static]
		[Export("transactionWithProductName:andCurrencyCode:andQuantity:andUnitPrice:andTransactionId:andBase64Receipt:")]
		void Transaction(string productName, string currencyCode, nint quantity, NSDecimalNumber price, string transactionId, string base64Receipt);

		// + (void)optOut;
		[Static]
		[Export("optOut")]
		void OptOut();

		// + (void)optIn;
		[Static]
		[Export("optIn")]
		void OptIn();

		// + (bool)optInOutUsingCMP;
		[Static]
		[Export("optInOutUsingCMP")]
		bool OptInOutUsingCmp();

		// + (void)optOutGoogleDMA;
		[Static]
		[Export("optOutGoogleDMA")]
		void OptOutGoogleDma();

		// + (void)optInGoogleDMA;
		[Static]
		[Export("optInGoogleDMA")]
		void OptInGoogleDma();

		// + (void)updatePostbackConversionValue:(int)conversionValue;
		[Static]
		[Export("updatePostbackConversionValue:")]
		void UpdatePostbackConversionValue(int conversionValue);

		// + (void)updatePostbackConversionValue:(int)conversionValue coarseValue:(NSString*)coarseValue lockWindow:(BOOL)lockWindow;
		[Static]
		[Export("updatePostbackConversionValue:coarseValue:lockWindow:")]
		void UpdatePostbackConversionValue(int conversionValue, string coarseValue, bool lockWindow);

		// + (void)setCustomerUserId:(NSString *)userId;
		[Static]
		[Export("setCustomerUserId:")]
		void SetCustomerUserId([NullAllowed] string userId);

		// + (NSString *)getCustomerUserId;
		[Static]
		[NullAllowed, Export("getCustomerUserId")]
		string CustomerUserId { get; }

		// + (void)setCacheEventSetting:(BOOL)isCacheEventsEnabled;
		[Static]
		[Export("setCacheEventSetting:")]
		void SetCacheEventSetting(bool isCacheEventsEnabled);

		// + (NSString*)getAnalyticsInstallationId;
		[Static]
		[Export("getAnalyticsInstallationId")]
		string AnalyticsInstallationId { get; }

		// + (void)debugLogs;
		[Static]
		[Export("debugLogs")]
		void DebugLogs();

		// + (void)verboseLogs;
		[Static]
		[Export("verboseLogs")]
		void VerboseLogs();

		// + (void)setLogHandler:(void (^)(NSString *))handler;
		[Static]
		[Export("setLogHandler:")]
		void SetLogHandler(Action<NSString> handler);

		// + (NSString *)sdkVersion;
		[Static]
		[Export("sdkVersion")]
		string SdkVersion { get; }

		// + (void)setWrapperVersion:(NSString *)wrapperVersion;
		[Static]
		[Export("setWrapperVersion:")]
		void SetWrapperVersion(string wrapperVersion);

		// - (void)registerDeepLinkHandler:(void (^)(NSDictionary *params, NSError *error))deeplinkHandler;
		[Export("registerDeepLinkHandler:")]
		void RegisterDeepLinkHandler(Action<NSDictionary, NSError> deeplinkHandler);

		// - (void)getAttributionInfo:(void (^)(NSDictionary *attributionInfo, NSError *error))completionHandler;
		[Export("getAttributionInfo:")]
		void GetAttributionInfo(Action<NSDictionary, NSError> completionHandler);

		// - (void)setGoogleDMAParametersWithAdPersonalization:(BOOL)adPersonalization adUserData:(BOOL)adUserData;
		[Export("setGoogleDMAParametersWithAdPersonalization:adUserData:")]
		void SetGoogleDmaParameters(bool adPersonalization, bool adUserData);

		// + (void)ironSourceImpressionFromJSON:(NSString *)jsonString;  (TenjinSDK+IronSourceILRD.h)
		[Static]
		[Export("ironSourceImpressionFromJSON:")]
		void IronSourceImpressionFromJson(string jsonString);

		// + (void)customImpressionFromJSON:(NSString *)jsonString;  (TenjinSDK+CustomILRD.h)
		[Static]
		[Export("customImpressionFromJSON:")]
		void CustomImpressionFromJson(string jsonString);
	}
}
