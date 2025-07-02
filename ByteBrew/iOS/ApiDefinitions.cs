//using ByteBrewNativeiOSPlugin;
using Foundation;

namespace ByteBrew
{
// @interface ByteBrewNativeiOSPlugin : NSObject
	[BaseType(typeof(NSObject))]
	interface ByteBrewNativeiOSPlugin
	{
		// +(void)InitializeWithSettings:(NSString *)gameID SecretKey:(NSString *)secretKey EngineVersion:(NSString *)engineV BuildVersion:(NSString *)buildV;
		[Static]
		[Export("InitializeWithSettings:SecretKey:EngineVersion:BuildVersion:")]
		void InitializeWithSettings(string gameID, string secretKey, string engineV, string buildV);

		// +(BOOL)IsByteBrewInitialized;
		[Static]
		[Export("IsByteBrewInitialized")]
		bool IsByteBrewInitialized { get; }

		// +(void)StartPushNotification;
		[Static]
		[Export("StartPushNotification")]
		void StartPushNotification();

		// +(void)StartPushNotification:(NSDictionary *)launchOptions;
		[Static]
		[Export("StartPushNotification:")]
		void StartPushNotification(NSDictionary launchOptions);

		// +(void)LowLevelPushStart;
		[Static]
		[Export("LowLevelPushStart")]
		void LowLevelPushStart();

		// +(void)AddNewCustomEvent:(NSString *)eventName;
		[Static]
		[Export("AddNewCustomEvent:")]
		void AddNewCustomEvent(string eventName);

		// +(void)AddNewCustomEventWithNumericValue:(NSString *)eventName Value:(Float64)value;
		[Static]
		[Export("AddNewCustomEventWithNumericValue:Value:")]
		void AddNewCustomEventWithNumericValue(string eventName, double value);

		// +(void)AddNewCustomEventWithStringValue:(NSString *)eventName Value:(NSString *)value;
		[Static]
		[Export("AddNewCustomEventWithStringValue:Value:")]
		void AddNewCustomEventWithStringValue(string eventName, string value);

		// +(void)AddCustomDataAttributeWithStringValue:(NSString *)key Value:(NSString *)value;
		[Static]
		[Export("AddCustomDataAttributeWithStringValue:Value:")]
		void AddCustomDataAttributeWithStringValue(string key, string value);

		// +(void)AddCustomDataAttributeWithDoubleValue:(NSString *)key Value:(double)value;
		[Static]
		[Export("AddCustomDataAttributeWithDoubleValue:Value:")]
		void AddCustomDataAttributeWithDoubleValue(string key, double value);

		// +(void)AddCustomDataAttributeWithIntegerValue:(NSString *)key Value:(int)value;
		[Static]
		[Export("AddCustomDataAttributeWithIntegerValue:Value:")]
		void AddCustomDataAttributeWithIntegerValue(string key, int value);

		// +(void)AddCustomDataAttributeWithBooleanValue:(NSString *)key Value:(BOOL)value;
		[Static]
		[Export("AddCustomDataAttributeWithBooleanValue:Value:")]
		void AddCustomDataAttributeWithBooleanValue(string key, bool value);

		// +(void)AddProgressionEvent:(ByteBrewProgressionType)progressionStatus Environment:(NSString *)environment Stage:(NSString *)stage;
		[Static]
		[Export("AddProgressionEvent:Environment:Stage:")]
		void AddProgressionEvent(ByteBrewProgressionType progressionStatus, string environment, string stage);

		// +(void)AddProgressionEventWithNumericValue:(ByteBrewProgressionType)progressionStatus Environment:(NSString *)environment Stage:(NSString *)stage Value:(Float64)value;
		[Static]
		[Export("AddProgressionEventWithNumericValue:Environment:Stage:Value:")]
		void AddProgressionEventWithNumericValue(ByteBrewProgressionType progressionStatus, string environment,
			string stage, double value);

		// +(void)AddProgressionEventWithStringValue:(ByteBrewProgressionType)progressionStatus Environment:(NSString *)environment Stage:(NSString *)stage Value:(NSString *)value;
		[Static]
		[Export("AddProgressionEventWithStringValue:Environment:Stage:Value:")]
		void AddProgressionEventWithStringValue(ByteBrewProgressionType progressionStatus, string environment,
			string stage, string value);

		// +(void)NewTrackedAdEvent:(NSString *)placementType AdLocation:(NSString *)adLoaction;
		[Static]
		[Export("NewTrackedAdEvent:AdLocation:")]
		void NewTrackedAdEvent(string placementType, string adLoaction);

		// +(void)NewTrackedAdEvent:(NSString *)placementType AdLocation:(NSString *)adLocation AdID:(NSString *)adID;
		[Static]
		[Export("NewTrackedAdEvent:AdLocation:AdID:")]
		void NewTrackedAdEvent(string placementType, string adLocation, string adID);

		// +(void)NewTrackedAdEvent:(NSString *)placementType AdLocation:(NSString *)adLocation AdID:(NSString *)adID AdProvider:(NSString *)adProvider;
		[Static]
		[Export("NewTrackedAdEvent:AdLocation:AdID:AdProvider:")]
		void NewTrackedAdEvent(string placementType, string adLocation, string adID, string adProvider);

		// +(void)NewTrackedAdEvent:(NSString *)placementType AdProvider:(NSString *)adProvider AdUnitName:(NSString *)adUnitName Revenue:(double)revenue;
		[Static]
		[Export("NewTrackedAdEvent:AdProvider:AdUnitName:Revenue:")]
		void NewTrackedAdEvent(string placementType, string adProvider, string adUnitName, double revenue);

		// +(void)NewTrackedAdEvent:(NSString *)placementType AdProvider:(NSString *)adProvider AdUnitName:(NSString *)adUnitName AdLocation:(NSString *)adLocation Revenue:(double)revenue;
		[Static]
		[Export("NewTrackedAdEvent:AdProvider:AdUnitName:AdLocation:Revenue:")]
		void NewTrackedAdEvent(string placementType, string adProvider, string adUnitName, string adLocation,
			double revenue);

		// +(void)AddTrackedInAppPurchaseEvent:(NSString *)store Currency:(NSString *)currency Amount:(Float64)amount ItemID:(NSString *)itemID Category:(NSString *)category;
		[Static]
		[Export("AddTrackedInAppPurchaseEvent:Currency:Amount:ItemID:Category:")]
		void AddTrackedInAppPurchaseEvent(string store, string currency, double amount, string itemID, string category);

		// +(void)AddTrackediOSInAppPurchaseEvent:(NSString *)store Currency:(NSString *)currency Amount:(Float64)amount ItemID:(NSString *)itemID Category:(NSString *)category Receipt:(NSString *)receipt;
		[Static]
		[Export("AddTrackediOSInAppPurchaseEvent:Currency:Amount:ItemID:Category:Receipt:")]
		void AddTrackediOSInAppPurchaseEvent(string store, string currency, double amount, string itemID,
			string category, string receipt);

		// +(void)ValidateiOSInAppPurchaseEvent:(NSString *)store Currency:(NSString *)currency Amount:(Float64)amount ItemID:(NSString *)itemID Category:(NSString *)category Receipt:(NSString *)receipt finishedValidationResult:(FinishedValidation)validationResult;
		[Static]
		[Export("ValidateiOSInAppPurchaseEvent:Currency:Amount:ItemID:Category:Receipt:finishedValidationResult:")]
		void ValidateiOSInAppPurchaseEvent(string store, string currency, double amount, string itemID, string category,
			string receipt, FinishedValidation validationResult);

		// +(BOOL)HasRemoteConfigs;
		[Static] [Export("HasRemoteConfigs")] bool HasRemoteConfigs { get; }

		// +(void)LoadRemoteConfigs:(FinishedRetrieval)finished;
		[Static]
		[Export("LoadRemoteConfigs:")]
		void LoadRemoteConfigs(FinishedRetrieval finished);

		// +(NSString *)RetrieveRemoteConfigs:(NSString *)key DefaultValue:(NSString *)defaultValue;
		[Static]
		[Export("RetrieveRemoteConfigs:DefaultValue:")]
		string RetrieveRemoteConfigs(string key, string defaultValue);

		// +(NSString *)GetUserID;
		[Static] [Export("GetUserID")] string UserID { get; }

		// +(void)RestartTracking;
		[Static]
		[Export("RestartTracking")]
		void RestartTracking();

		// +(void)StopTracking;
		[Static]
		[Export("StopTracking")]
		void StopTracking();
	}

	// typedef void (^FinishedValidation)(NSMutableDictionary *);
	delegate void FinishedValidation(NSMutableDictionary arg0);

	// typedef void (^FinishedRetrieval)(BOOL);
	delegate void FinishedRetrieval(bool arg0);
}
