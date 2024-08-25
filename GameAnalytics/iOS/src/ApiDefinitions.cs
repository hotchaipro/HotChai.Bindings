using System;
using Foundation;

namespace GameAnalyticsSdk
{
	// @protocol GARemoteConfigsDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface GARemoteConfigsDelegate
	{
		// @optional -(void)onRemoteConfigsUpdated;
		[Export ("onRemoteConfigsUpdated")]
		void OnRemoteConfigsUpdated ();
	}

	// @interface GameAnalytics : NSObject
	[BaseType (typeof(NSObject))]
	interface GameAnalytics
	{
		// +(NSString *)adTypeToString:(GAAdType)adType;
		[Static]
		[Export ("adTypeToString:")]
		string AdTypeToString (GAAdType adType);

		// +(void)configureAvailableCustomDimensions01:(NSArray *)customDimensions;
		[Static]
		[Export ("configureAvailableCustomDimensions01:")]
		void ConfigureAvailableCustomDimensions01 (NSObject[] customDimensions);

		// +(void)configureAvailableCustomDimensions02:(NSArray *)customDimensions;
		[Static]
		[Export ("configureAvailableCustomDimensions02:")]
		void ConfigureAvailableCustomDimensions02 (NSObject[] customDimensions);

		// +(void)configureAvailableCustomDimensions03:(NSArray *)customDimensions;
		[Static]
		[Export ("configureAvailableCustomDimensions03:")]
		void ConfigureAvailableCustomDimensions03 (NSObject[] customDimensions);

		// +(void)configureAvailableResourceCurrencies:(NSArray *)resourceCurrencies;
		[Static]
		[Export ("configureAvailableResourceCurrencies:")]
		void ConfigureAvailableResourceCurrencies (NSObject[] resourceCurrencies);

		// +(void)configureAvailableResourceItemTypes:(NSArray *)resourceItemTypes;
		[Static]
		[Export ("configureAvailableResourceItemTypes:")]
		void ConfigureAvailableResourceItemTypes (NSObject[] resourceItemTypes);

		// +(void)configureBuild:(NSString *)build;
		[Static]
		[Export ("configureBuild:")]
		void ConfigureBuild (string build);

		// +(void)configureUserId:(NSString *)userId;
		[Static]
		[Export ("configureUserId:")]
		void ConfigureUserId (string userId);

		// +(void)configureExternalUserId:(NSString *)userId;
		[Static]
		[Export ("configureExternalUserId:")]
		void ConfigureExternalUserId (string userId);

		// +(NSString *)getUserId;
		[Static]
		[Export ("getUserId")]
		string UserId { get; }

		// +(NSString *)getExternalUserId;
		[Static]
		[Export ("getExternalUserId")]
		string ExternalUserId { get; }

		// +(void)useRandomizedId:(Boolean)value;
		[Static]
		[Export ("useRandomizedId:")]
		void UseRandomizedId (byte value);

		// +(void)configureSdkVersion:(NSString *)wrapperSdkVersion;
		[Static]
		[Export ("configureSdkVersion:")]
		void ConfigureSdkVersion (string wrapperSdkVersion);

		// +(void)configureEngineVersion:(NSString *)engineVersion;
		[Static]
		[Export ("configureEngineVersion:")]
		void ConfigureEngineVersion (string engineVersion);

		// +(void)configureAutoDetectAppVersion:(BOOL)flag;
		[Static]
		[Export ("configureAutoDetectAppVersion:")]
		void ConfigureAutoDetectAppVersion (bool flag);

		// +(void)configureGameKey:(NSString *)gameKey gameSecret:(NSString *)gameSecret;
		[Static]
		[Export ("configureGameKey:gameSecret:")]
		void ConfigureGameKey (string gameKey, string gameSecret);

		// +(void)initializeWithGameKey:(NSString *)gameKey gameSecret:(NSString *)gameSecret;
		[Static]
		[Export ("initializeWithGameKey:gameSecret:")]
		void InitializeWithGameKey (string gameKey, string gameSecret);

		// +(void)initializeWithConfiguredGameKeyAndGameSecret;
		[Static]
		[Export ("initializeWithConfiguredGameKeyAndGameSecret")]
		void InitializeWithConfiguredGameKeyAndGameSecret ();

		// +(void)addBusinessEventWithCurrency:(NSString *)currency amount:(NSInteger)amount itemType:(NSString *)itemType itemId:(NSString *)itemId cartType:(NSString *)cartType receipt:(NSString *)receipt;
		[Static]
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:")]
		void AddBusinessEventWithCurrency (string currency, nint amount, string itemType, string itemId, string cartType, string receipt);

		// +(void)addBusinessEventWithCurrency:(NSString *)currency amount:(NSInteger)amount itemType:(NSString *)itemType itemId:(NSString *)itemId cartType:(NSString *)cartType receipt:(NSString *)receipt customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:customFields:")]
		void AddBusinessEventWithCurrency (string currency, nint amount, string itemType, string itemId, string cartType, string receipt, NSDictionary customFields);

		// +(void)addBusinessEventWithCurrency:(NSString *)currency amount:(NSInteger)amount itemType:(NSString *)itemType itemId:(NSString *)itemId cartType:(NSString *)cartType receipt:(NSString *)receipt customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:receipt:customFields:mergeFields:")]
		void AddBusinessEventWithCurrency (string currency, nint amount, string itemType, string itemId, string cartType, string receipt, NSDictionary customFields, bool mergeFields);

		// +(void)addBusinessEventWithCurrency:(NSString *)currency amount:(NSInteger)amount itemType:(NSString *)itemType itemId:(NSString *)itemId cartType:(NSString *)cartType autoFetchReceipt:(BOOL)autoFetchReceipt;
		[Static]
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:")]
		void AddBusinessEventWithCurrency (string currency, nint amount, string itemType, string itemId, string cartType, bool autoFetchReceipt);

		// +(void)addBusinessEventWithCurrency:(NSString *)currency amount:(NSInteger)amount itemType:(NSString *)itemType itemId:(NSString *)itemId cartType:(NSString *)cartType autoFetchReceipt:(BOOL)autoFetchReceipt customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:customFields:")]
		void AddBusinessEventWithCurrency (string currency, nint amount, string itemType, string itemId, string cartType, bool autoFetchReceipt, NSDictionary customFields);

		// +(void)addBusinessEventWithCurrency:(NSString *)currency amount:(NSInteger)amount itemType:(NSString *)itemType itemId:(NSString *)itemId cartType:(NSString *)cartType autoFetchReceipt:(BOOL)autoFetchReceipt customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addBusinessEventWithCurrency:amount:itemType:itemId:cartType:autoFetchReceipt:customFields:mergeFields:")]
		void AddBusinessEventWithCurrency (string currency, nint amount, string itemType, string itemId, string cartType, bool autoFetchReceipt, NSDictionary customFields, bool mergeFields);

		// +(void)addResourceEventWithFlowType:(GAResourceFlowType)flowType currency:(NSString *)currency amount:(NSNumber *)amount itemType:(NSString *)itemType itemId:(NSString *)itemId;
		[Static]
		[Export ("addResourceEventWithFlowType:currency:amount:itemType:itemId:")]
		void AddResourceEventWithFlowType (GAResourceFlowType flowType, string currency, NSNumber amount, string itemType, string itemId);

		// +(void)addResourceEventWithFlowType:(GAResourceFlowType)flowType currency:(NSString *)currency amount:(NSNumber *)amount itemType:(NSString *)itemType itemId:(NSString *)itemId customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addResourceEventWithFlowType:currency:amount:itemType:itemId:customFields:")]
		void AddResourceEventWithFlowType (GAResourceFlowType flowType, string currency, NSNumber amount, string itemType, string itemId, NSDictionary customFields);

		// +(void)addResourceEventWithFlowType:(GAResourceFlowType)flowType currency:(NSString *)currency amount:(NSNumber *)amount itemType:(NSString *)itemType itemId:(NSString *)itemId customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addResourceEventWithFlowType:currency:amount:itemType:itemId:customFields:mergeFields:")]
		void AddResourceEventWithFlowType (GAResourceFlowType flowType, string currency, NSNumber amount, string itemType, string itemId, NSDictionary customFields, bool mergeFields);

		// +(void)addProgressionEventWithProgressionStatus:(GAProgressionStatus)progressionStatus progression01:(NSString *)progression01 progression02:(NSString *)progression02 progression03:(NSString *)progression03;
		[Static]
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:")]
		void AddProgressionEventWithProgressionStatus (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03);

		// +(void)addProgressionEventWithProgressionStatus:(GAProgressionStatus)progressionStatus progression01:(NSString *)progression01 progression02:(NSString *)progression02 progression03:(NSString *)progression03 customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:customFields:")]
		void AddProgressionEventWithProgressionStatus (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, NSDictionary customFields);

		// +(void)addProgressionEventWithProgressionStatus:(GAProgressionStatus)progressionStatus progression01:(NSString *)progression01 progression02:(NSString *)progression02 progression03:(NSString *)progression03 customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:customFields:mergeFields:")]
		void AddProgressionEventWithProgressionStatus (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, NSDictionary customFields, bool mergeFields);

		// +(void)addProgressionEventWithProgressionStatus:(GAProgressionStatus)progressionStatus progression01:(NSString *)progression01 progression02:(NSString *)progression02 progression03:(NSString *)progression03 score:(NSInteger)score;
		[Static]
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:")]
		void AddProgressionEventWithProgressionStatus (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, nint score);

		// +(void)addProgressionEventWithProgressionStatus:(GAProgressionStatus)progressionStatus progression01:(NSString *)progression01 progression02:(NSString *)progression02 progression03:(NSString *)progression03 score:(NSInteger)score customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:customFields:")]
		void AddProgressionEventWithProgressionStatus (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, nint score, NSDictionary customFields);

		// +(void)addProgressionEventWithProgressionStatus:(GAProgressionStatus)progressionStatus progression01:(NSString *)progression01 progression02:(NSString *)progression02 progression03:(NSString *)progression03 score:(NSInteger)score customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addProgressionEventWithProgressionStatus:progression01:progression02:progression03:score:customFields:mergeFields:")]
		void AddProgressionEventWithProgressionStatus (GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03, nint score, NSDictionary customFields, bool mergeFields);

		// +(void)addDesignEventWithEventId:(NSString *)eventId;
		[Static]
		[Export ("addDesignEventWithEventId:")]
		void AddDesignEventWithEventId (string eventId);

		// +(void)addDesignEventWithEventId:(NSString *)eventId customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addDesignEventWithEventId:customFields:")]
		void AddDesignEventWithEventId (string eventId, NSDictionary customFields);

		// +(void)addDesignEventWithEventId:(NSString *)eventId customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addDesignEventWithEventId:customFields:mergeFields:")]
		void AddDesignEventWithEventId (string eventId, NSDictionary customFields, bool mergeFields);

		// +(void)addDesignEventWithEventId:(NSString *)eventId value:(NSNumber *)value;
		[Static]
		[Export ("addDesignEventWithEventId:value:")]
		void AddDesignEventWithEventId (string eventId, NSNumber value);

		// +(void)addDesignEventWithEventId:(NSString *)eventId value:(NSNumber *)value customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addDesignEventWithEventId:value:customFields:")]
		void AddDesignEventWithEventId (string eventId, NSNumber value, NSDictionary customFields);

		// +(void)addDesignEventWithEventId:(NSString *)eventId value:(NSNumber *)value customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addDesignEventWithEventId:value:customFields:mergeFields:")]
		void AddDesignEventWithEventId (string eventId, NSNumber value, NSDictionary customFields, bool mergeFields);

		// +(void)addErrorEventWithSeverity:(GAErrorSeverity)severity message:(NSString *)message;
		[Static]
		[Export ("addErrorEventWithSeverity:message:")]
		void AddErrorEventWithSeverity (GAErrorSeverity severity, string message);

		// +(void)addErrorEventWithSeverity:(GAErrorSeverity)severity message:(NSString *)message customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addErrorEventWithSeverity:message:customFields:")]
		void AddErrorEventWithSeverity (GAErrorSeverity severity, string message, NSDictionary customFields);

		// +(void)addErrorEventWithSeverity:(GAErrorSeverity)severity message:(NSString *)message customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addErrorEventWithSeverity:message:customFields:mergeFields:")]
		void AddErrorEventWithSeverity (GAErrorSeverity severity, string message, NSDictionary customFields, bool mergeFields);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement duration:(NSInteger)duration;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, nint duration);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement duration:(NSInteger)duration customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:customFields:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, nint duration, NSDictionary customFields);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement duration:(NSInteger)duration customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:duration:customFields:mergeFields:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, nint duration, NSDictionary customFields, bool mergeFields);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement noAdReason:(GAAdError)noAdReason;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement noAdReason:(GAAdError)noAdReason customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:customFields:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason, NSDictionary customFields);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement noAdReason:(GAAdError)noAdReason customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:noAdReason:customFields:mergeFields:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, GAAdError noAdReason, NSDictionary customFields, bool mergeFields);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:customFields:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, NSDictionary customFields);

		// +(void)addAdEventWithAction:(GAAdAction)action adType:(GAAdType)adType adSdkName:(NSString *)adSdkName adPlacement:(NSString *)adPlacement customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addAdEventWithAction:adType:adSdkName:adPlacement:customFields:mergeFields:")]
		void AddAdEventWithAction (GAAdAction action, GAAdType adType, string adSdkName, string adPlacement, NSDictionary customFields, bool mergeFields);

		// +(void)addImpressionMopubEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionMopubEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionMopubEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionMopubEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionMopubEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionMopubEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionFyberEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionFyberEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionFyberEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionFyberEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionFyberEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionFyberEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionIronSourceEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionIronSourceEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionIronSourceEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionIronSourceEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionIronSourceEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionIronSourceEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionTopOnEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionTopOnEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionTopOnEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionTopOnEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionTopOnEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionTopOnEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionHyperBidEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionHyperBidEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionHyperBidEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionHyperBidEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionHyperBidEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionHyperBidEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionMaxEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionMaxEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionMaxEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionMaxEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionMaxEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionMaxEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionAequusEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionAequusEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionAequusEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionAequusEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionAequusEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionAequusEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionAdMobEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionAdMobEventWithAdNetworkVersion:impressionData:")]
		void AddImpressionAdMobEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionAdMobEventWithAdNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionAdMobEventWithAdNetworkVersion:impressionData:customFields:")]
		void AddImpressionAdMobEventWithAdNetworkVersion (string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionEventWithAdNetworkName:(NSString *)adNetworkName adNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData;
		[Static]
		[Export ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:")]
		void AddImpressionEventWithAdNetworkName (string adNetworkName, string adNetworkVersion, NSDictionary impressionData);

		// +(void)addImpressionEventWithAdNetworkName:(NSString *)adNetworkName adNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields;
		[Static]
		[Export ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:customFields:")]
		void AddImpressionEventWithAdNetworkName (string adNetworkName, string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields);

		// +(void)addImpressionEventWithAdNetworkName:(NSString *)adNetworkName adNetworkVersion:(NSString *)adNetworkVersion impressionData:(NSDictionary *)impressionData customFields:(NSDictionary *)customFields mergeFields:(BOOL)mergeFields;
		[Static]
		[Export ("addImpressionEventWithAdNetworkName:adNetworkVersion:impressionData:customFields:mergeFields:")]
		void AddImpressionEventWithAdNetworkName (string adNetworkName, string adNetworkVersion, NSDictionary impressionData, NSDictionary customFields, bool mergeFields);

		// +(NSString *)getRemoteConfigsValueAsString:(NSString *)key;
		[Static]
		[Export ("getRemoteConfigsValueAsString:")]
		string GetRemoteConfigsValueAsString (string key);

		// +(NSString *)getRemoteConfigsValueAsString:(NSString *)key defaultValue:(NSString *)defaultValue;
		[Static]
		[Export ("getRemoteConfigsValueAsString:defaultValue:")]
		string GetRemoteConfigsValueAsString (string key, string defaultValue);

		// +(NSString *)getRemoteConfigsContentAsString;
		[Static]
		[Export ("getRemoteConfigsContentAsString")]
		string GetRemoteConfigsContentAsString ();

		// +(NSString *)getRemoteConfigsContentAsJSON;
		[Static]
		[Export ("getRemoteConfigsContentAsJSON")]
		string GetRemoteConfigsContentAsJSON ();

		// +(void)setRemoteConfigsDelegate:(id)newDelegate;
		[Static]
		[Export ("setRemoteConfigsDelegate:")]
		void SetRemoteConfigsDelegate (NSObject newDelegate);

		// +(BOOL)isRemoteConfigsReady;
		[Static]
		[Export ("isRemoteConfigsReady")]
		bool IsRemoteConfigsReady { get; }

		// +(NSString *)getABTestingId;
		[Static]
		[Export ("getABTestingId")]
		string ABTestingId { get; }

		// +(NSString *)getABTestingVariantId;
		[Static]
		[Export ("getABTestingVariantId")]
		string ABTestingVariantId { get; }

		// +(void)setEnabledInfoLog:(BOOL)flag;
		[Static]
		[Export ("setEnabledInfoLog:")]
		void SetEnabledInfoLog (bool flag);

		// +(void)setEnabledVerboseLog:(BOOL)flag;
		[Static]
		[Export ("setEnabledVerboseLog:")]
		void SetEnabledVerboseLog (bool flag);

		// +(void)setEnabledWarningLog:(BOOL)flag;
		[Static]
		[Export ("setEnabledWarningLog:")]
		void SetEnabledWarningLog (bool flag);

		// +(void)setEnabledManualSessionHandling:(BOOL)flag;
		[Static]
		[Export ("setEnabledManualSessionHandling:")]
		void SetEnabledManualSessionHandling (bool flag);

		// +(void)setEnabledErrorReporting:(BOOL)flag;
		[Static]
		[Export ("setEnabledErrorReporting:")]
		void SetEnabledErrorReporting (bool flag);

		// +(void)setEnabledEventSubmission:(BOOL)flag;
		[Static]
		[Export ("setEnabledEventSubmission:")]
		void SetEnabledEventSubmission (bool flag);

		// +(void)setEnabledEventSubmission:(BOOL)doSend doCacheLocally:(BOOL)doCache;
		[Static]
		[Export ("setEnabledEventSubmission:doCacheLocally:")]
		void SetEnabledEventSubmission (bool doSend, bool doCache);

		// +(void)startSession;
		[Static]
		[Export ("startSession")]
		void StartSession ();

		// +(void)endSession;
		[Static]
		[Export ("endSession")]
		void EndSession ();

		// +(void)setCustomDimension01:(NSString *)dimension01;
		[Static]
		[Export ("setCustomDimension01:")]
		void SetCustomDimension01 (string dimension01);

		// +(void)setCustomDimension02:(NSString *)dimension02;
		[Static]
		[Export ("setCustomDimension02:")]
		void SetCustomDimension02 (string dimension02);

		// +(void)setCustomDimension03:(NSString *)dimension03;
		[Static]
		[Export ("setCustomDimension03:")]
		void SetCustomDimension03 (string dimension03);

		// +(void)setGlobalCustomEventFields:(NSDictionary *)customFields;
		[Static]
		[Export ("setGlobalCustomEventFields:")]
		void SetGlobalCustomEventFields (NSDictionary customFields);

		// +(void)enableSDKInitEvent:(Boolean)value;
		[Static]
		[Export ("enableSDKInitEvent:")]
		void EnableSDKInitEvent (byte value);

		// +(void)enableFpsHistogram:(Boolean)value;
		[Static]
		[Export ("enableFpsHistogram:")]
		void EnableFpsHistogram (byte value);

		// +(void)enableMemoryHistogram:(Boolean)value;
		[Static]
		[Export ("enableMemoryHistogram:")]
		void EnableMemoryHistogram (byte value);

		// +(void)enableHealthHardwareInfo:(Boolean)value;
		[Static]
		[Export ("enableHealthHardwareInfo:")]
		void EnableHealthHardwareInfo (byte value);

		// +(void)startTimer:(NSString *)key;
		[Static]
		[Export ("startTimer:")]
		void StartTimer (string key);

		// +(void)pauseTimer:(NSString *)key;
		[Static]
		[Export ("pauseTimer:")]
		void PauseTimer (string key);

		// +(void)resumeTimer:(NSString *)key;
		[Static]
		[Export ("resumeTimer:")]
		void ResumeTimer (string key);

		// +(NSInteger)stopTimer:(NSString *)key;
		[Static]
		[Export ("stopTimer:")]
		nint StopTimer (string key);
	}
}
