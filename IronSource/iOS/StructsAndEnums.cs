using ObjCRuntime;

namespace IronSourceSdk
{
	[Native]
	public enum ISAAdFormatType : ulong
	{
		Interstitial,
		Rewarded,
		Banner
	}

	[Native]
	public enum ISALogLevel : long
	{
		None,
		Error,
		Verbose
	}

	[Native]
	public enum ISGender : long
	{
		Unknown,
		Male,
		Female
	}

	[Native]
	public enum DebugLevel : long
	{
		None,
		Error,
		Info,
		Verbose
	}

	public enum ISLogLevel
	{
		None = -1,
		Internal = 0,
		Info = 1,
		Warning = 2,
		Error = 3,
		General = 4,
		Critical = 5
	}

	public enum LogTag : uint
	{
		Api,
		Delegate,
		AdapterApi,
		AdapterDelegate,
		Network,
		Native,
		Internal,
		Event
	}

	[Native]
	public enum ISAdapterErrors : long
	{
		Internal = 1000,
		AdExpired = 1001,
		MissingParams = 1002
	}

	[Native]
	public enum ISAdapterErrorType : long
	{
		NoFill,
		AdExpired,
		Internal
	}

	[Native]
	public enum ISLoadWhileShowSupportState : long
	{
		None = 0,
		ByInstance = 1,
		ByNetwork = 2
	}

	[Native]
	public enum ISErrorCode : ulong
	{
		ErrorCodeDecryptFailed = 1,
		ErrorCodeNoAdaptiveSupportiveNetworks = 2,
		ErrorCodeNoConfigurationAvailable = 501,
		ErrorCodeUsingCachedConfiguration = 502,
		ErrorCodeKeyNotSet = 505,
		ErrorCodeInvalidKeyValue = 506,
		ErrorCodeInitFailed = 508,
		ErrorCodeNoAdsToShow = 509,
		ErrorCodeGeneric = 510,
		ErrorCodeNoAdsToReload = 519,
		ErrorNoInternetConnection = 520,
		ErrorMultipleIronsourceAppKey = 522,
		ErrorPlacementCapped = 524,
		ErrorAdFormatCapped = 525,
		ErrorReachedCapLimitPerSession = 526,
		ErrorUnknownInstanceId = 527,
		ErrorSendEventsFailure = 528,
		ErrorPullLocalFailureFailure = 529,
		ErrorAdUnitCapped = 530,
		ErrorBnLoadAfterInitFailed = 600,
		ErrorBnLoadAfterLongInitiation = 601,
		ErrorBnInitFailedAfterLoad = 602,
		ErrorBnLoadPlacementCapped = 604,
		ErrorBnLoadException = 605,
		ErrorBnLoadNoFill = 606,
		ErrorBnInstanceInitTimeout = 607,
		ErrorBnInstanceLoadTimeout = 608,
		ErrorBnInstanceReloadTimeout = 609,
		ErrorBnInstanceLoadEmptyBanner = 610,
		ErrorBnInstanceLoadEmptyAdapter = 611,
		ErrorBnInstanceInitException = 612,
		ErrorBnReloadSkipInvisible = 613,
		ErrorBnReloadSkipBackground = 614,
		ErrorBnLoadNoConfig = 615,
		ErrorBnUnsupportedSize = 616,
		ErrorDoBnInstanceLoadEmptyServerData = 618,
		ErrorDoBnLoadAlreadyInProgress = 619,
		ErrorDoBnLoadBeforeInitSuccess = 620,
		ErrorDoBnInstanceLoadAuctionFailed = 621,
		ErrorCodeNoAdUnitSpecified = 624,
		ErrorCodeLoadBeforeInitSuccessCallback = 625,
		ErrorCodeInvalidAdUnitId = 626,
		ErrorCodeLoadFailedAlreadyCalled = 627,
		ErrorCodeShowBeforeLoadSuccessCallback = 628,
		ErrorCodeLoadWhileShow = 629,
		ErrorCodeShowWhileShow = 630,
		ErrorCodeShowControllerNil = 631,
		ErrorCodeShowViewControllerNil = 632,
		ErrorNtLoadAfterInitFailed = 700,
		ErrorNtLoadAfterLongInitiation = 701,
		ErrorNtInitFailedAfterLoad = 702,
		ErrorNtLoadWhileLongInitiation = 703,
		ErrorNtLoadPlacementCapped = 704,
		ErrorNtLoadException = 705,
		ErrorNtLoadNoFill = 706,
		ErrorNtInstanceInitTimeout = 707,
		ErrorNtInstanceLoadTimeout = 708,
		ErrorNtInstanceLoadEmptyAdapter = 711,
		ErrorNtInstanceInitException = 712,
		ErrorNtLoadNoConfig = 715,
		ErrorNtInstanceLoadEmptyServerData = 718,
		ErrorNtNetworkAdapterIsNull = 719,
		ErrorNtNetworkNativeAdParamsNil = 720,
		ErrorNtNetworkNativeAdLoadFailed = 721,
		AuctionErrorRequest = 1000,
		AuctionErrorResponseCodeNotValid = 1001,
		AuctionErrorParse = 1002,
		AuctionErrorDecryption = 1003,
		AuctionErrorEmptyWaterfall = 1004,
		AuctionErrorNoCandidates = 1005,
		AuctionErrorConnectionTimedOut = 1006,
		AuctionErrorRequestMissingParams = 1007,
		AuctionErrorDecompression = 1008,
		NotificationsErrorLoadedNotFound = 1010,
		NotificationsErrorShowingNotFound = 1011,
		ErrorSessionKeyEncryptionFailure = 1015,
		ErrorNtEmptyDefaultPlacement = 1018,
		ErrorIsEmptyDefaultPlacement = 1020,
		ErrorRvEmptyDefaultPlacement = 1021,
		ErrorRvShowCalledDuringShow = 1022,
		ErrorRvShowCalledWrongState = 1023,
		ErrorRvLoadFailedNoCandidates = 1024,
		ErrorLoadFailedTimeout = 1025,
		ErrorRvLoadDuringLoad = 1026,
		ErrorRvLoadDuringShow = 1027,
		ErrorRvLoadSuccessUnexpected = 1028,
		ErrorRvLoadSuccessWrongAuctionId = 1029,
		ErrorRvLoadFailUnexpected = 1030,
		ErrorRvLoadFailWrongAuctionId = 1031,
		ErrorRvInitFailedTimeout = 1032,
		ErrorRvLoadFailDueToInit = 1033,
		ErrorRvLoadUnexpectedCallback = 1034,
		ErrorIsLoadFailedNoCandidates = 1035,
		ErrorIsShowCalledDuringShow = 1036,
		ErrorIsLoadDuringShow = 1037,
		ErrorRvShowException = 1038,
		ErrorIsShowException = 1039,
		ErrorRvInstanceInitException = 1040,
		ErrorIsInstanceInitException = 1041,
		ErrorBnLoadFailedNoCandidates = 1044,
		ErrorNtLoadFailedNoCandidates = 1045,
		ErrorDoIsLoadAlreadyInProgress = 1050,
		ErrorDoIsCallLoadBeforeShow = 1051,
		ErrorDoIsLoadTimedOut = 1052,
		ErrorDoRvLoadAlreadyInProgress = 1053,
		ErrorDoRvShowCalledBeforeLoad = 1054,
		ErrorDoRvLoadTimedOut = 1055,
		ErrorDoRvLoadDuringShow = 1056,
		ErrorRvExpiredAds = 1057,
		ErrorDoBnLoadMissingViewController = 1060,
		ErrorRvLoadAfterLongInitiation = 1061,
		ErrorDoRvInstanceLoadEmptyServerData = 1062,
		ErrorCodeMissingConfiguration = 1063,
		ErrorDoIsShowDuringShow = 1064,
		ErrorDoIsShowDuringLoad = 1065,
		ErrorDoIsShowNoAvailableAds = 1066,
		ErrorDoRvShowDuringShow = 1067,
		ErrorDoRvShowDuringLoad = 1068,
		ErrorDoRvShowNoAvailableAds = 1069,
		ErrorDoRvInstanceLoadAuctionFailed = 1070,
		ErrorRvLoadAfterInitFailed = 1072,
		ErrorRvLoadNoFill = 1058,
		ErrorIsLoadNoFill = 1158,
		ErrorIsLoadAfterInitFailed = 1160,
		ErrorIsLoadAfterLongInitiation = 1161,
		ErrorDoIsInstanceLoadEmptyServerData = 1162,
		ErrorDoIsInstanceLoadEmptyAdapter = 1163,
		ErrorDoIsInstanceLoadAuctionFailed = 1164,
		ErrorConsentViewTypeNotFound = 1601,
		ErrorConsentViewDictionaryNotFound = 1602,
		ErrorConsentViewUrlNotFound = 1603,
		ErrorConsentViewNotLoaded = 1604,
		ErrorConsentViewLoadFailed = 1605,
		ErrorConsentViewShowDuringShow = 1606,
		ErrorConsentViewCannotBeOpened = 1607,
		ErrorConsentViewLoadDuringLoad = 1608,
		ErrorCodeTestSuiteSdkNotInitialized = 1721,
		ErrorCodeTestSuiteDisabled = 1722,
		ErrorCodeTestSuiteExceptionOnLaunch = 1723,
		ErrorCodeTestSuiteWebControllerNotLoaded = 1724,
		ErrorCodeTestSuiteNoNetworkConnectivity = 1725,
		ErrorCodeBiddingDataException = 5001,
		ErrorCodeIsReadyException = 5002,
		ErrorCodeLoadInProgressException = 5003,
		ErrorCodeShowInProgressException = 5004,
		ErrorCodeLoadException = 5005,
		ErrorCodeShowFailedException = 5006,
		ErrorCodeInitSuccessException = 5007,
		ErrorCodeInitFailedException = 5008,
		ErrorCodeAdCloseException = 5008,
		ErrorCodeDestroyException = 5009,
		ErrorCodeInternalException = 5010,
		ErrorCodeSmashIsNil = 5012,
		ErrorCodeSmashInstanceNameIsNil = 5013,
		ErrorOldInitApiAppKeyNotValid = 2010,
		ErrorNewInitApiAlreadyCalled = 2020,
		ErrorOldApiInitInProgress = 2030,
		ErrorInitAlreadyFinished = 2040,
		ErrorLegacyInitFailed = 2060,
		ErrorInitHttpRequestFailed = 2070,
		ErrorInitInvalidResponse = 2080,
		ErrorInitDecryptFailed = 2090,
		ErrorInitNoResponseKey = 2100,
		ErrorOldInitApiMultipleCalls = 2110,
		ErrorInitDecompressFailed = 2120,
		ErrorCappingValidationFailed = 3000,
		ErrorDeliveryCappingValidationFailed = 3001,
		ErrorCappingEnabledFalse = 3002,
		ErrorCappingConfigAdditionFailed = 3003,
		ErrorRewardValidationFailed = 3004
	}

	[Native]
	public enum LPMAdSizeType : long
	{
		Banner,
		Large,
		MediumRectangle,
		Custom,
		LeaderBoard
	}

	[Native]
	public enum ISAdOptionsPosition : long
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	[Native]
	public enum ISMetaDataValueTypes : ulong
	{
		String,
		Bool,
		Int,
		Long,
		Double,
		Float
	}

	[Native]
	public enum ISNLogLevel : ulong
	{
		Verbose = 0,
		Info,
		Error
	}

	[Native]
	public enum ISNLogTag : ulong
	{
		Native,
		Internal,
		ControllerInternal,
		ControllerApi,
		ControllerDelegate,
		NativeAd
	}
}
