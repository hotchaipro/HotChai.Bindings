using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace IronSourceSdk
{
	// @interface ISABannerAdInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISABannerAdInfo
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull instanceId;
		[Export ("instanceId", ArgumentSemantic.Strong)]
		string InstanceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull adId;
		[Export ("adId", ArgumentSemantic.Strong)]
		string AdId { get; }
	}

	// @protocol ISABannerAdViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISABannerAdViewDelegate
	{
		// @required -(void)bannerAdViewDidShow:(ISABannerAdView * _Nonnull)bannerAdView;
		[Abstract]
		[Export ("bannerAdViewDidShow:")]
		void BannerAdViewDidShow (ISABannerAdView bannerAdView);

		// @required -(void)bannerAdViewDidClick:(ISABannerAdView * _Nonnull)bannerAdView;
		[Abstract]
		[Export ("bannerAdViewDidClick:")]
		void BannerAdViewDidClick (ISABannerAdView bannerAdView);
	}

	// @interface ISABannerAdView : UIView
	[BaseType (typeof(UIView))]
	[DisableDefaultCtor]
	interface ISABannerAdView
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ISABannerAdViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ISABannerAdViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) ISABannerAdInfo * _Nonnull adInfo;
		[Export ("adInfo", ArgumentSemantic.Strong)]
		ISABannerAdInfo AdInfo { get; }

		// @property (nonatomic, weak) UIViewController * _Nullable viewController;
		[NullAllowed, Export ("viewController", ArgumentSemantic.Weak)]
		UIViewController ViewController { get; set; }
	}

	// @protocol ISABannerAdLoaderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISABannerAdLoaderDelegate
	{
		// @required -(void)bannerAdDidLoad:(ISABannerAdView * _Nonnull)bannerAdView;
		[Abstract]
		[Export ("bannerAdDidLoad:")]
		void BannerAdDidLoad (ISABannerAdView bannerAdView);

		// @required -(void)bannerAdDidFailToLoadWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("bannerAdDidFailToLoadWithError:")]
		void BannerAdDidFailToLoadWithError (NSError error);
	}

	// @interface ISAAdSize : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAAdSize
	{
		// @property (readonly, nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; }

		// @property (readonly, nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sizeDescription;
		[Export ("sizeDescription")]
		string SizeDescription { get; }

		// +(ISAAdSize * _Nonnull)banner;
		[Static]
		[Export ("banner")]
		ISAAdSize Banner { get; }

		// +(ISAAdSize * _Nonnull)large;
		[Static]
		[Export ("large")]
		ISAAdSize Large { get; }

		// +(ISAAdSize * _Nonnull)mediumRectangle;
		[Static]
		[Export ("mediumRectangle")]
		ISAAdSize MediumRectangle { get; }

		// +(ISAAdSize * _Nonnull)leaderboard;
		[Static]
		[Export ("leaderboard")]
		ISAAdSize Leaderboard { get; }
	}

	// @interface ISABannerAdRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISABannerAdRequest
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull instanceId;
		[Export ("instanceId", ArgumentSemantic.Strong)]
		string InstanceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull adm;
		[Export ("adm", ArgumentSemantic.Strong)]
		string Adm { get; }

		// @property (readonly, nonatomic, strong) ISAAdSize * _Nonnull size;
		[Export ("size", ArgumentSemantic.Strong)]
		ISAAdSize Size { get; }

		// @property (readonly, nonatomic, weak) UIViewController * _Nullable viewController;
		[NullAllowed, Export ("viewController", ArgumentSemantic.Weak)]
		UIViewController ViewController { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable extraParams;
		[NullAllowed, Export ("extraParams", ArgumentSemantic.Strong)]
		NSDictionary ExtraParams { get; }
	}

	// @interface ISABannerAdLoader : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISABannerAdLoader
	{
		// +(void)loadAdWithAdRequest:(ISABannerAdRequest * _Nonnull)adRequest delegate:(id<ISABannerAdLoaderDelegate> _Nonnull)delegate;
		[Static]
		[Export ("loadAdWithAdRequest:delegate:")]
		void LoadAdWithAdRequest (ISABannerAdRequest adRequest, ISABannerAdLoaderDelegate @delegate);
	}

	// @interface ISABannerAdRequestBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISABannerAdRequestBuilder
	{
		// -(instancetype _Nonnull)initWithInstanceId:(NSString * _Nonnull)instanceId adm:(NSString * _Nonnull)adm size:(ISAAdSize * _Nonnull)size;
		[Export ("initWithInstanceId:adm:size:")]
		NativeHandle Constructor (string instanceId, string adm, ISAAdSize size);

		// -(ISABannerAdRequestBuilder * _Nonnull)withExtraParams:(NSDictionary * _Nonnull)extraParams;
		[Export ("withExtraParams:")]
		ISABannerAdRequestBuilder WithExtraParams (NSDictionary extraParams);

		// -(ISABannerAdRequestBuilder * _Nonnull)withViewController:(UIViewController * _Nonnull)viewController;
		[Export ("withViewController:")]
		ISABannerAdRequestBuilder WithViewController (UIViewController viewController);

		// -(ISABannerAdRequest * _Nonnull)build;
		[Export ("build")]
		ISABannerAdRequest Build();
	}

	// @interface ISAAdFormat : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAAdFormat
	{
		// @property (readonly, nonatomic) ISAAdFormatType adFormatType;
		[Export ("adFormatType")]
		ISAAdFormatType AdFormatType { get; }

		// -(instancetype _Nonnull)initWithAdFormatType:(ISAAdFormatType)adFormatType;
		[Export ("initWithAdFormatType:")]
		NativeHandle Constructor (ISAAdFormatType adFormatType);
	}

	// @interface ISAInitRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAInitRequest
	{
		// @property (readonly, nonatomic) NSString * _Nonnull appKey;
		[Export ("appKey")]
		string AppKey { get; }

		// @property (readonly, nonatomic) NSArray<ISAAdFormat *> * _Nonnull legacyAdFormats;
		[Export ("legacyAdFormats")]
		ISAAdFormat[] LegacyAdFormats { get; }

		// @property (readonly, nonatomic) ISALogLevel logLevel;
		[Export ("logLevel")]
		ISALogLevel LogLevel { get; }
	}

	// @interface ISAInitRequestBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAInitRequestBuilder
	{
		// -(instancetype _Nonnull)initWithAppKey:(NSString * _Nonnull)appKey;
		[Export ("initWithAppKey:")]
		NativeHandle Constructor (string appKey);

		// -(ISAInitRequest * _Nonnull)build;
		[Export ("build")]
		ISAInitRequest Build();

		// -(ISAInitRequestBuilder * _Nonnull)withLegacyAdFormats:(NSArray<ISAAdFormat *> * _Nonnull)legacyAdFormats;
		[Export ("withLegacyAdFormats:")]
		ISAInitRequestBuilder WithLegacyAdFormats (ISAAdFormat[] legacyAdFormats);

		// -(ISAInitRequestBuilder * _Nonnull)withLogLevel:(ISALogLevel)logLevel;
		[Export ("withLogLevel:")]
		ISAInitRequestBuilder WithLogLevel (ISALogLevel logLevel);
	}

	// @protocol ISAInterstitialAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISAInterstitialAdDelegate
	{
		// @required -(void)interstitialAdDidShow:(ISAInterstitialAd * _Nonnull)interstitialAd;
		[Abstract]
		[Export ("interstitialAdDidShow:")]
		void InterstitialAdDidShow (ISAInterstitialAd interstitialAd);

		// @required -(void)interstitialAd:(ISAInterstitialAd * _Nonnull)interstitialAd didFailToShowWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("interstitialAd:didFailToShowWithError:")]
		void InterstitialAd (ISAInterstitialAd interstitialAd, NSError error);

		// @required -(void)interstitialAdDidClick:(ISAInterstitialAd * _Nonnull)interstitialAd;
		[Abstract]
		[Export ("interstitialAdDidClick:")]
		void InterstitialAdDidClick (ISAInterstitialAd interstitialAd);

		// @required -(void)interstitialAdDidDismiss:(ISAInterstitialAd * _Nonnull)interstitialAd;
		[Abstract]
		[Export ("interstitialAdDidDismiss:")]
		void InterstitialAdDidDismiss (ISAInterstitialAd interstitialAd);
	}

	// @interface ISAInterstitialAdInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAInterstitialAdInfo
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull instanceId;
		[Export ("instanceId", ArgumentSemantic.Strong)]
		string InstanceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull adId;
		[Export ("adId", ArgumentSemantic.Strong)]
		string AdId { get; }
	}

	// @interface ISAInterstitialAd : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAInterstitialAd
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ISAInterstitialAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ISAInterstitialAdDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) ISAInterstitialAdInfo * _Nonnull adInfo;
		[Export ("adInfo", ArgumentSemantic.Strong)]
		ISAInterstitialAdInfo AdInfo { get; }

		// -(BOOL)isReadyToShow;
		[Export ("isReadyToShow")]
		bool IsReadyToShow { get; }

		// -(void)showFromViewController:(UIViewController * _Nonnull)viewController;
		[Export ("showFromViewController:")]
		void ShowFromViewController (UIViewController viewController);
	}

	// @protocol ISAInterstitialAdLoaderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISAInterstitialAdLoaderDelegate
	{
		// @required -(void)interstitialAdDidLoad:(ISAInterstitialAd * _Nonnull)interstitialAd;
		[Abstract]
		[Export ("interstitialAdDidLoad:")]
		void InterstitialAdDidLoad (ISAInterstitialAd interstitialAd);

		// @required -(void)interstitialAdDidFailToLoadWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("interstitialAdDidFailToLoadWithError:")]
		void InterstitialAdDidFailToLoadWithError (NSError error);
	}

	// @interface ISAInterstitialAdRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAInterstitialAdRequest
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull instanceId;
		[Export ("instanceId", ArgumentSemantic.Strong)]
		string InstanceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull adm;
		[Export ("adm", ArgumentSemantic.Strong)]
		string Adm { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable extraParams;
		[NullAllowed, Export ("extraParams", ArgumentSemantic.Strong)]
		NSDictionary ExtraParams { get; }
	}

	// @interface ISAInterstitialAdLoader : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAInterstitialAdLoader
	{
		// +(void)loadAdWithAdRequest:(ISAInterstitialAdRequest * _Nonnull)adRequest delegate:(id<ISAInterstitialAdLoaderDelegate> _Nonnull)delegate;
		[Static]
		[Export ("loadAdWithAdRequest:delegate:")]
		void LoadAdWithAdRequest (ISAInterstitialAdRequest adRequest, ISAInterstitialAdLoaderDelegate @delegate);
	}

	// @interface ISAInterstitialAdRequestBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISAInterstitialAdRequestBuilder
	{
		// -(instancetype _Nonnull)initWithInstanceId:(NSString * _Nonnull)instanceId adm:(NSString * _Nonnull)adm;
		[Export ("initWithInstanceId:adm:")]
		NativeHandle Constructor (string instanceId, string adm);

		// -(ISAInterstitialAdRequestBuilder * _Nonnull)withExtraParams:(NSDictionary * _Nonnull)extraParams;
		[Export ("withExtraParams:")]
		ISAInterstitialAdRequestBuilder WithExtraParams (NSDictionary extraParams);

		// -(ISAInterstitialAdRequest * _Nonnull)build;
		[Export ("build")]
		ISAInterstitialAdRequest Build();
	}

	// @protocol ISARewardedAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISARewardedAdDelegate
	{
		// @required -(void)rewardedAdDidShow:(ISARewardedAd * _Nonnull)rewardedAd;
		[Abstract]
		[Export ("rewardedAdDidShow:")]
		void RewardedAdDidShow (ISARewardedAd rewardedAd);

		// @required -(void)rewardedAd:(ISARewardedAd * _Nonnull)rewardedAd didFailToShowWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("rewardedAd:didFailToShowWithError:")]
		void RewardedAd (ISARewardedAd rewardedAd, NSError error);

		// @required -(void)rewardedAdDidUserEarnReward:(ISARewardedAd * _Nonnull)rewardedAd;
		[Abstract]
		[Export ("rewardedAdDidUserEarnReward:")]
		void RewardedAdDidUserEarnReward (ISARewardedAd rewardedAd);

		// @required -(void)rewardedAdDidClick:(ISARewardedAd * _Nonnull)rewardedAd;
		[Abstract]
		[Export ("rewardedAdDidClick:")]
		void RewardedAdDidClick (ISARewardedAd rewardedAd);

		// @required -(void)rewardedAdDidDismiss:(ISARewardedAd * _Nonnull)rewardedAd;
		[Abstract]
		[Export ("rewardedAdDidDismiss:")]
		void RewardedAdDidDismiss (ISARewardedAd rewardedAd);
	}

	// @interface ISARewardedAdInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISARewardedAdInfo
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull instanceId;
		[Export ("instanceId", ArgumentSemantic.Strong)]
		string InstanceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull adId;
		[Export ("adId", ArgumentSemantic.Strong)]
		string AdId { get; }
	}

	// @interface ISARewardedAd : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISARewardedAd
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ISARewardedAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ISARewardedAdDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) ISARewardedAdInfo * _Nonnull adInfo;
		[Export ("adInfo", ArgumentSemantic.Strong)]
		ISARewardedAdInfo AdInfo { get; }

		// -(BOOL)isReadyToShow;
		[Export ("isReadyToShow")]
		bool IsReadyToShow { get; }

		// -(void)showFromViewController:(UIViewController * _Nonnull)viewController;
		[Export ("showFromViewController:")]
		void ShowFromViewController (UIViewController viewController);
	}

	// @protocol ISARewardedAdLoaderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISARewardedAdLoaderDelegate
	{
		// @required -(void)rewardedAdDidLoad:(ISARewardedAd * _Nonnull)rewardedAd;
		[Abstract]
		[Export ("rewardedAdDidLoad:")]
		void RewardedAdDidLoad (ISARewardedAd rewardedAd);

		// @required -(void)rewardedAdDidFailToLoadWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("rewardedAdDidFailToLoadWithError:")]
		void RewardedAdDidFailToLoadWithError (NSError error);
	}

	// @interface ISARewardedAdRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISARewardedAdRequest
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull instanceId;
		[Export ("instanceId", ArgumentSemantic.Strong)]
		string InstanceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull adm;
		[Export ("adm", ArgumentSemantic.Strong)]
		string Adm { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable extraParams;
		[NullAllowed, Export ("extraParams", ArgumentSemantic.Strong)]
		NSDictionary ExtraParams { get; }
	}

	// @interface ISARewardedAdLoader : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISARewardedAdLoader
	{
		// +(void)loadAdWithAdRequest:(ISARewardedAdRequest * _Nonnull)adRequest delegate:(id<ISARewardedAdLoaderDelegate> _Nonnull)delegate;
		[Static]
		[Export ("loadAdWithAdRequest:delegate:")]
		void LoadAdWithAdRequest (ISARewardedAdRequest adRequest, ISARewardedAdLoaderDelegate @delegate);
	}

	// @interface ISARewardedAdRequestBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISARewardedAdRequestBuilder
	{
		// -(instancetype _Nonnull)initWithInstanceId:(NSString * _Nonnull)instanceId adm:(NSString * _Nonnull)adm;
		[Export ("initWithInstanceId:adm:")]
		NativeHandle Constructor (string instanceId, string adm);

		// -(ISARewardedAdRequestBuilder * _Nonnull)withExtraParams:(NSDictionary * _Nonnull)extraParams;
		[Export ("withExtraParams:")]
		ISARewardedAdRequestBuilder WithExtraParams (NSDictionary extraParams);

		// -(ISARewardedAdRequest * _Nonnull)build;
		[Export ("build")]
		ISARewardedAdRequest Build();
	}

	// @protocol ISAdapterAdaptiveProtocol <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterAdaptiveProtocol
	{
		// @required -(CGFloat)getAdaptiveHeightWithWidth:(CGFloat)width;
		[Abstract]
		[Export ("getAdaptiveHeightWithWidth:")]
		nfloat GetAdaptiveHeightWithWidth (nfloat width);
	}

	// @interface ISBannerSize : NSObject
	[BaseType (typeof(NSObject))]
	interface ISBannerSize
	{
		// -(instancetype)initWithWidth:(NSInteger)width andHeight:(NSInteger)height;
		[Export ("initWithWidth:andHeight:")]
		NativeHandle Constructor (nint width, nint height);

		// -(instancetype)initWithDescription:(NSString *)description width:(NSInteger)width height:(NSInteger)height;
		[Export ("initWithDescription:width:height:")]
		NativeHandle Constructor (string description, nint width, nint height);

		// -(BOOL)isSmart;
		[Export ("isSmart")]
		bool IsSmart { get; }

		// +(CGFloat)getMaximalAdaptiveHeightWithWidth:(CGFloat)width;
		[Static]
		[Export ("getMaximalAdaptiveHeightWithWidth:")]
		nfloat GetMaximalAdaptiveHeightWithWidth (nfloat width);

		// @property (readonly) NSString * sizeDescription;
		[Export ("sizeDescription")]
		string SizeDescription { get; }

		// @property (readonly) NSInteger width;
		[Export ("width")]
		nint Width { get; }

		// @property (readonly) NSInteger height;
		[Export ("height")]
		nint Height { get; }

		// @property (getter = isAdaptive, readwrite) BOOL adaptive;
		[Export ("adaptive")]
		bool Adaptive { [Bind ("isAdaptive")] get; set; }

	}

	// @interface ISConfigurations : NSObject
	[BaseType (typeof(NSObject))]
	interface ISConfigurations
	{
		// @property (nonatomic, strong) NSString * userId;
		[Export ("userId", ArgumentSemantic.Strong)]
		string UserId { get; set; }

		// @property (nonatomic, strong) NSString * appKey;
		[Export ("appKey", ArgumentSemantic.Strong)]
		string AppKey { get; set; }

		// @property (nonatomic, strong) NSString * segmentId;
		[Export ("segmentId", ArgumentSemantic.Strong)]
		string SegmentId { get; set; }

		// @property (nonatomic, strong) NSDictionary * customSegmentParams;
		[Export ("customSegmentParams", ArgumentSemantic.Strong)]
		NSDictionary CustomSegmentParams { get; set; }

		// @property (nonatomic, strong) NSDictionary * rewardedVideoCustomParameters;
		[Export ("rewardedVideoCustomParameters", ArgumentSemantic.Strong)]
		NSDictionary RewardedVideoCustomParameters { get; set; }

		// @property (nonatomic, strong) NSString * version;
		[Export ("version", ArgumentSemantic.Strong)]
		string Version { get; set; }

		// @property (nonatomic, strong) NSNumber * adapterTimeOutInSeconds;
		[Export ("adapterTimeOutInSeconds", ArgumentSemantic.Strong)]
		NSNumber AdapterTimeOutInSeconds { get; set; }

		// @property (nonatomic, strong) NSNumber * maxNumOfAdaptersToLoadOnStart;
		[Export ("maxNumOfAdaptersToLoadOnStart", ArgumentSemantic.Strong)]
		NSNumber MaxNumOfAdaptersToLoadOnStart { get; set; }

		// @property (assign, nonatomic) BOOL advancedLoading;
		[Export ("advancedLoading")]
		bool AdvancedLoading { get; set; }

		// @property (nonatomic, strong) NSString * plugin;
		[Export ("plugin", ArgumentSemantic.Strong)]
		string Plugin { get; set; }

		// @property (nonatomic, strong) NSString * pluginVersion;
		[Export ("pluginVersion", ArgumentSemantic.Strong)]
		string PluginVersion { get; set; }

		// @property (nonatomic, strong) NSString * pluginFrameworkVersion;
		[Export ("pluginFrameworkVersion", ArgumentSemantic.Strong)]
		string PluginFrameworkVersion { get; set; }

		// @property (nonatomic, strong) NSNumber * maxVideosPerIteration;
		[Export ("maxVideosPerIteration", ArgumentSemantic.Strong)]
		NSNumber MaxVideosPerIteration { get; set; }

		// @property (assign, nonatomic) NSInteger userAge;
		[Export ("userAge")]
		nint UserAge { get; set; }

		// @property (assign, nonatomic) ISGender userGender;
		[Export ("userGender", ArgumentSemantic.Assign)]
		ISGender UserGender { get; set; }

		// @property (assign, nonatomic) BOOL trackReachability;
		[Export ("trackReachability")]
		bool TrackReachability { get; set; }

		// @property (nonatomic, strong) NSString * dynamicUserId;
		[Export ("dynamicUserId", ArgumentSemantic.Strong)]
		string DynamicUserId { get; set; }

		// @property (assign, nonatomic) BOOL adaptersDebug;
		[Export ("adaptersDebug")]
		bool AdaptersDebug { get; set; }

		// @property (nonatomic, strong) NSString * mediationType;
		[Export ("mediationType", ArgumentSemantic.Strong)]
		string MediationType { get; set; }

		// @property (nonatomic, strong) NSNumber * serr;
		[Export ("serr", ArgumentSemantic.Strong)]
		NSNumber Serr { get; set; }

		// @property (nonatomic, strong) NSString * categorizeType;
		[Export ("categorizeType", ArgumentSemantic.Strong)]
		string CategorizeType { get; set; }

		// @property (nonatomic, strong) NSDictionary * rvServerParams;
		[Export ("rvServerParams", ArgumentSemantic.Strong)]
		NSDictionary RvServerParams { get; set; }

		// @property (assign, nonatomic) NSInteger consent;
		[Export ("consent")]
		nint Consent { get; set; }

		// @property (assign, nonatomic) BOOL didSetConsent;
		[Export ("didSetConsent")]
		bool DidSetConsent { get; set; }

		// @property (nonatomic, strong) NSDictionary * batchGenericParams;
		[Export ("batchGenericParams", ArgumentSemantic.Strong)]
		NSDictionary BatchGenericParams { get; set; }

		// @property (nonatomic, strong) NSDictionary * eventGenericParams;
		[Export ("eventGenericParams", ArgumentSemantic.Strong)]
		NSDictionary EventGenericParams { get; set; }

		// @property (nonatomic, strong) NSDictionary * eventPixelParams;
		[Export ("eventPixelParams", ArgumentSemantic.Strong)]
		NSDictionary EventPixelParams { get; set; }

		// +(ISConfigurations *)getConfigurations;
		[Static]
		[Export ("getConfigurations")]
		ISConfigurations Configurations { get; }
	}

	// @interface ISDemandOnlyBannerView : UIView
	[BaseType (typeof(UIView))]
	interface ISDemandOnlyBannerView
	{
	}

	// @protocol ISDemandOnlyBannerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISDemandOnlyBannerDelegate
	{
		// @required -(void)bannerDidLoad:(ISDemandOnlyBannerView *)bannerView instanceId:(NSString *)instanceId;
		[Abstract]
		[Export ("bannerDidLoad:instanceId:")]
		void BannerDidLoad (ISDemandOnlyBannerView bannerView, string instanceId);

		// @required -(void)bannerDidFailToLoadWithError:(NSError *)error instanceId:(NSString *)instanceId;
		[Abstract]
		[Export ("bannerDidFailToLoadWithError:instanceId:")]
		void BannerDidFailToLoadWithError (NSError error, string instanceId);

		// @required -(void)bannerDidShow:(NSString *)instanceId;
		[Abstract]
		[Export ("bannerDidShow:")]
		void BannerDidShow (string instanceId);

		// @required -(void)didClickBanner:(NSString *)instanceId;
		[Abstract]
		[Export ("didClickBanner:")]
		void DidClickBanner (string instanceId);

		// @required -(void)bannerWillLeaveApplication:(NSString *)instanceId;
		[Abstract]
		[Export ("bannerWillLeaveApplication:")]
		void BannerWillLeaveApplication (string instanceId);
	}

	// @protocol ISDemandOnlyInterstitialDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISDemandOnlyInterstitialDelegate
	{
		// @required -(void)interstitialDidLoad:(NSString *)instanceId;
		[Abstract]
		[Export ("interstitialDidLoad:")]
		void InterstitialDidLoad (string instanceId);

		// @required -(void)interstitialDidFailToLoadWithError:(NSError *)error instanceId:(NSString *)instanceId;
		[Abstract]
		[Export ("interstitialDidFailToLoadWithError:instanceId:")]
		void InterstitialDidFailToLoadWithError (NSError error, string instanceId);

		// @required -(void)interstitialDidOpen:(NSString *)instanceId;
		[Abstract]
		[Export ("interstitialDidOpen:")]
		void InterstitialDidOpen (string instanceId);

		// @required -(void)interstitialDidClose:(NSString *)instanceId;
		[Abstract]
		[Export ("interstitialDidClose:")]
		void InterstitialDidClose (string instanceId);

		// @required -(void)interstitialDidFailToShowWithError:(NSError *)error instanceId:(NSString *)instanceId;
		[Abstract]
		[Export ("interstitialDidFailToShowWithError:instanceId:")]
		void InterstitialDidFailToShowWithError (NSError error, string instanceId);

		// @required -(void)didClickInterstitial:(NSString *)instanceId;
		[Abstract]
		[Export ("didClickInterstitial:")]
		void DidClickInterstitial (string instanceId);
	}

	// @protocol ISDemandOnlyRewardedVideoDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISDemandOnlyRewardedVideoDelegate
	{
		// @required -(void)rewardedVideoDidLoad:(NSString *)instanceId;
		[Abstract]
		[Export ("rewardedVideoDidLoad:")]
		void RewardedVideoDidLoad (string instanceId);

		// @required -(void)rewardedVideoDidFailToLoadWithError:(NSError *)error instanceId:(NSString *)instanceId;
		[Abstract]
		[Export ("rewardedVideoDidFailToLoadWithError:instanceId:")]
		void RewardedVideoDidFailToLoadWithError (NSError error, string instanceId);

		// @required -(void)rewardedVideoDidOpen:(NSString *)instanceId;
		[Abstract]
		[Export ("rewardedVideoDidOpen:")]
		void RewardedVideoDidOpen (string instanceId);

		// @required -(void)rewardedVideoDidFailToShowWithError:(NSError *)error instanceId:(NSString *)instanceId;
		[Abstract]
		[Export ("rewardedVideoDidFailToShowWithError:instanceId:")]
		void RewardedVideoDidFailToShowWithError (NSError error, string instanceId);

		// @required -(void)rewardedVideoDidClick:(NSString *)instanceId;
		[Abstract]
		[Export ("rewardedVideoDidClick:")]
		void RewardedVideoDidClick (string instanceId);

		// @required -(void)rewardedVideoAdRewarded:(NSString *)instanceId;
		[Abstract]
		[Export ("rewardedVideoAdRewarded:")]
		void RewardedVideoAdRewarded (string instanceId);

		// @required -(void)rewardedVideoDidClose:(NSString *)instanceId;
		[Abstract]
		[Export ("rewardedVideoDidClose:")]
		void RewardedVideoDidClose (string instanceId);
	}


	// @interface ISSupersonicAdsConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface ISSupersonicAdsConfiguration
	{
		// @property (nonatomic, strong) NSNumber * useClientSideCallbacks;
		[Export ("useClientSideCallbacks", ArgumentSemantic.Strong)]
		NSNumber UseClientSideCallbacks { get; set; }

		// @property (nonatomic, strong) NSString * language;
		[Export ("language", ArgumentSemantic.Strong)]
		string Language { get; set; }

		// @property (nonatomic, strong) NSString * minimumOfferCommission;
		[Export ("minimumOfferCommission", ArgumentSemantic.Strong)]
		string MinimumOfferCommission { get; set; }

		// @property (nonatomic, strong) NSDictionary * controllerConfig;
		[Export ("controllerConfig", ArgumentSemantic.Strong)]
		NSDictionary ControllerConfig { get; set; }

		// @property (nonatomic, strong) NSString * itemName;
		[Export ("itemName", ArgumentSemantic.Strong)]
		string ItemName { get; set; }

		// @property (nonatomic, strong) NSString * controllerUrl;
		[Export ("controllerUrl", ArgumentSemantic.Strong)]
		string ControllerUrl { get; set; }

		// @property (strong) NSNumber * itemCount;
		[Export ("itemCount", ArgumentSemantic.Strong)]
		NSNumber ItemCount { get; set; }

		// @property (strong) NSNumber * maxVideoLength;
		[Export ("maxVideoLength", ArgumentSemantic.Strong)]
		NSNumber MaxVideoLength { get; set; }

		// @property (nonatomic, strong) NSString * privateKey;
		[Export ("privateKey", ArgumentSemantic.Strong)]
		string PrivateKey { get; set; }

		// @property (nonatomic) BOOL debugMode;
		[Export ("debugMode")]
		bool DebugMode { get; set; }

		// @property (nonatomic) NSInteger debugLevel;
		[Export ("debugLevel")]
		nint DebugLevel { get; set; }

		// +(ISSupersonicAdsConfiguration *)configurations;
		[Static]
		[Export ("configurations")]
		ISSupersonicAdsConfiguration Configurations { get; }
	}


	// typedef void (^ISAInitCompletionHandler)(BOOL, NSError * _Nullable);
	delegate void ISAInitCompletionHandler (bool arg0, [NullAllowed] NSError arg1);

	// @interface IronSourceAds : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface IronSourceAds
	{
		// +(void)initWithRequest:(ISAInitRequest * _Nonnull)request completion:(ISAInitCompletionHandler _Nonnull)completion;
		[Static]
		[Export ("initWithRequest:completion:")]
		void InitWithRequest (ISAInitRequest request, ISAInitCompletionHandler completion);

		// +(NSString *)sdkVersion;
		[Static]
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// +(void)enableDebugMode:(BOOL)enable;
		[Static]
		[Export ("enableDebugMode:")]
		void EnableDebugMode (bool enable);

		// +(void)setMetaDataWithKey:(NSString *)key value:(NSString *)value;
		[Static]
		[Export ("setMetaDataWithKey:value:")]
		void SetMetaDataWithKey (string key, string value);

		// +(void)setMetaDataWithKey:(NSString *)key values:(NSMutableArray *)values;
		[Static]
		[Export ("setMetaDataWithKey:values:")]
		void SetMetaDataWithKey (string key, NSMutableArray values);

		// +(void)setConsent:(BOOL)consent;
		[Static]
		[Export ("setConsent:")]
		void SetConsent (bool consent);
	}


	// typedef void (^LPMDispatcherBlock)();
	delegate void LPMDispatcherBlock ();

	// @protocol LPMDispatcherProtocol <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface LPMDispatcherProtocol
	{
		// @required -(void)dispatch:(LPMDispatcherBlock _Nonnull)task;
		[Abstract]
		[Export ("dispatch:")]
		void Dispatch (LPMDispatcherBlock task);
	}

	// @protocol ISAdapterAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISAdapterAdDelegate
	{
		// @required -(void)adDidLoad;
		[Abstract]
		[Export ("adDidLoad")]
		void AdDidLoad ();

		// @required -(void)adDidFailToLoadWithErrorType:(ISAdapterErrorType)errorType errorCode:(NSInteger)errorCode errorMessage:(NSString * _Nullable)errorMessage;
		[Abstract]
		[Export ("adDidFailToLoadWithErrorType:errorCode:errorMessage:")]
		void AdDidFailToLoadWithErrorType (ISAdapterErrorType errorType, nint errorCode, [NullAllowed] string errorMessage);

		// @required -(void)adDidOpen;
		[Abstract]
		[Export ("adDidOpen")]
		void AdDidOpen ();

		// @required -(void)adDidFailToShowWithErrorCode:(NSInteger)errorCode errorMessage:(NSString * _Nullable)errorMessage;
		[Abstract]
		[Export ("adDidFailToShowWithErrorCode:errorMessage:")]
		void AdDidFailToShowWithErrorCode (nint errorCode, [NullAllowed] string errorMessage);

		// @required -(void)adDidClick;
		[Abstract]
		[Export ("adDidClick")]
		void AdDidClick ();
	}

	// @protocol ISAdapterAdViewDelegate <ISAdapterAdDelegate>
	[Protocol]
	interface ISAdapterAdViewDelegate : ISAdapterAdDelegate
	{
		// @required -(void)adDidLoadWithView:(UIView *)view;
		[Abstract]
		[Export ("adDidLoadWithView:")]
		void AdDidLoadWithView (UIView view);

		// @required -(void)adWillLeaveApplication;
		[Abstract]
		[Export ("adWillLeaveApplication")]
		void AdWillLeaveApplication ();

		// @required -(void)adWillPresentScreen;
		[Abstract]
		[Export ("adWillPresentScreen")]
		void AdWillPresentScreen ();

		// @required -(void)adDidDismissScreen;
		[Abstract]
		[Export ("adDidDismissScreen")]
		void AdDidDismissScreen ();
	}

	// @interface ISAdapterConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface ISAdapterConfig
	{
		// @property (readonly, nonatomic, strong) NSDictionary * settings;
		[Export ("settings", ArgumentSemantic.Strong)]
		NSDictionary Settings { get; }

		// @property (readonly, nonatomic, strong) NSString * providerName;
		[Export ("providerName", ArgumentSemantic.Strong)]
		string ProviderName { get; }

		// @property (readonly, nonatomic, strong) NSString * reflectionName;
		[Export ("reflectionName", ArgumentSemantic.Strong)]
		string ReflectionName { get; }

		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic, strong) NSString * requestUrl;
		[Export ("requestUrl", ArgumentSemantic.Strong)]
		string RequestUrl { get; }

		// @property (readonly, nonatomic, strong) NSString * subAdapterId;
		[Export ("subAdapterId", ArgumentSemantic.Strong)]
		string SubAdapterId { get; }

		// @property (readonly, nonatomic, strong) NSString * instanceId;
		[Export ("instanceId", ArgumentSemantic.Strong)]
		string InstanceId { get; }

		// @property (readonly, nonatomic, strong) NSNumber * maxAdsPerIteration;
		[Export ("maxAdsPerIteration", ArgumentSemantic.Strong)]
		NSNumber MaxAdsPerIteration { get; }

		// @property (readonly, nonatomic, strong) NSNumber * maxAdsPerSession;
		[Export ("maxAdsPerSession", ArgumentSemantic.Strong)]
		NSNumber MaxAdsPerSession { get; }

		// @property (readonly, nonatomic, strong) NSString * instanceType;
		[Export ("instanceType", ArgumentSemantic.Strong)]
		string InstanceType { get; }

		// @property (readonly, assign, nonatomic) NSInteger maxAdsPerDay;
		[Export ("maxAdsPerDay")]
		nint MaxAdsPerDay { get; }

		// @property (readonly, assign, nonatomic) double loadTimeOutSec;
		[Export ("loadTimeOutSec")]
		double LoadTimeOutSec { get; }

		// @property (readonly, assign, nonatomic) BOOL isMultiProviderInstance;
		[Export ("isMultiProviderInstance")]
		bool IsMultiProviderInstance { get; }

		// @property (readonly, nonatomic, strong) NSString * adSourceNameForEvent;
		[Export ("adSourceNameForEvent", ArgumentSemantic.Strong)]
		string AdSourceNameForEvent { get; }

		// @property (readonly, assign, nonatomic) BOOL isBidder;
		[Export ("isBidder")]
		bool IsBidder { get; }

		// @property (readonly, assign, nonatomic) BOOL shouldEarlyInit;
		[Export ("shouldEarlyInit")]
		bool ShouldEarlyInit { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * appSettings;
		[Export ("appSettings", ArgumentSemantic.Strong)]
		NSDictionary AppSettings { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * interstitialSettings;
		[Export ("interstitialSettings", ArgumentSemantic.Strong)]
		NSDictionary InterstitialSettings { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * rewardedVideoSettings;
		[Export ("rewardedVideoSettings", ArgumentSemantic.Strong)]
		NSDictionary RewardedVideoSettings { get; }

		// @property (nonatomic, strong) NSDictionary * bannerSettings;
		[Export ("bannerSettings", ArgumentSemantic.Strong)]
		NSDictionary BannerSettings { get; set; }

		// @property (readonly, nonatomic, strong) NSDictionary * nativeAdSettings;
		[Export ("nativeAdSettings", ArgumentSemantic.Strong)]
		NSDictionary NativeAdSettings { get; }

		// @property (readonly, nonatomic, strong) NSString * providerDefaultInstance;
		[Export ("providerDefaultInstance", ArgumentSemantic.Strong)]
		string ProviderDefaultInstance { get; }

		// @property (readonly, nonatomic, strong) NSString * providerNetworkKey;
		[Export ("providerNetworkKey", ArgumentSemantic.Strong)]
		string ProviderNetworkKey { get; }

		// @property (readonly, nonatomic, strong) NSString * customNetwork;
		[Export ("customNetwork", ArgumentSemantic.Strong)]
		string CustomNetwork { get; }

		// @property (readonly, assign, nonatomic) BOOL isCustomNetwork;
		[Export ("isCustomNetwork")]
		bool IsCustomNetwork { get; }

		// -(instancetype)initWithProviderName:(NSString *)providerName;
		[Export ("initWithProviderName:")]
		NativeHandle Constructor (string providerName);

		// -(void)setSettings:(NSDictionary *)settings;
		[Export ("setSettings:")]
		void SetSettings (NSDictionary settings);

		// -(void)setReflectionName:(NSString *)reflectionName;
		[Export ("setReflectionName:")]
		void SetReflectionName (string reflectionName);

		// -(void)setLoadTimeOut:(double)loadTimeOut;
		[Export ("setLoadTimeOut:")]
		void SetLoadTimeOut (double loadTimeOut);

		// -(BOOL)isIronSource;
		[Export ("isIronSource")]
		bool IsIronSource { get; }

		// -(void)setAppSettings:(NSDictionary *)appSettings;
		[Export ("setAppSettings:")]
		void SetAppSettings (NSDictionary appSettings);

		// -(void)setInterstitialSettings:(NSDictionary *)interstitialSettings;
		[Export ("setInterstitialSettings:")]
		void SetInterstitialSettings (NSDictionary interstitialSettings);

		// -(void)setRewardedVideoSettings:(NSDictionary *)rewardedVideoSettings;
		[Export ("setRewardedVideoSettings:")]
		void SetRewardedVideoSettings (NSDictionary rewardedVideoSettings);

		// -(void)setNativeAdSettings:(NSDictionary *)nativeAdSettings;
		[Export ("setNativeAdSettings:")]
		void SetNativeAdSettings (NSDictionary nativeAdSettings);

		// -(void)setProviderDefaultInstance:(NSString *)providerDefaultInstance;
		[Export ("setProviderDefaultInstance:")]
		void SetProviderDefaultInstance (string providerDefaultInstance);

		// -(void)setIsOneFlow:(BOOL)isOneFlow;
		[Export ("setIsOneFlow:")]
		void SetIsOneFlow (bool isOneFlow);

		// -(NSDictionary *)adUnitSettings;
		[Export ("adUnitSettings")]
		NSDictionary AdUnitSettings { get; }

		// -(NSString *)demandSourceName;
		[Export ("demandSourceName")]
		string DemandSourceName { get; }

		// -(NSNumber *)isOneFlow;
		[Export ("isOneFlow")]
		NSNumber IsOneFlow { get; }

		// -(BOOL)hasConsentCMP;
		[Export ("hasConsentCMP")]
		bool HasConsentCMP { get; }

		// -(BOOL)getConsentCMP;
		[Export ("getConsentCMP")]
		bool ConsentCMP { get; }
	}

	// @interface ISAdData : NSObject
	[BaseType (typeof(NSObject))]
	interface ISAdData
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable serverData;
		[NullAllowed, Export ("serverData", ArgumentSemantic.Strong)]
		string ServerData { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		NSDictionary Configuration { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable adUnitData;
		[NullAllowed, Export ("adUnitData", ArgumentSemantic.Strong)]
		NSDictionary AdUnitData { get; }

		// -(instancetype _Nonnull)initWithServerData:(NSString * _Nullable)serverData configuration:(NSDictionary * _Nonnull)configuration adUnitData:(NSDictionary * _Nullable)adUnitData;
		[Export ("initWithServerData:configuration:adUnitData:")]
		NativeHandle Constructor ([NullAllowed] string serverData, NSDictionary configuration, [NullAllowed] NSDictionary adUnitData);

		// -(NSString * _Nullable)getString:(NSString * _Nonnull)key;
		[Export ("getString:")]
		[return: NullAllowed]
		string GetString (string key);

		// -(NSInteger)getInt:(NSString * _Nonnull)key;
		[Export ("getInt:")]
		nint GetInt (string key);

		// -(BOOL)getBoolean:(NSString * _Nonnull)key;
		[Export ("getBoolean:")]
		bool GetBoolean (string key);

		// -(NSNumber * _Nullable)getNumber:(NSString * _Nonnull)key;
		[Export ("getNumber:")]
		[return: NullAllowed]
		NSNumber GetNumber (string key);

		// -(NSDictionary * _Nullable)getAdUnitData;
		[Export("getAdUnitData")]
		[return: NullAllowed]
		NSDictionary GetAdUnitData();
	}

	// @protocol ISBannerAdDelegate <ISAdapterAdViewDelegate>
	[Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ISBannerAdDelegate : ISAdapterAdViewDelegate
	{
	}

	// @protocol ISAdapterBannerProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISAdapterBannerProtocol
	{
		// @required -(void)loadAdWithAdData:(ISAdData * _Nonnull)adData viewController:(UIViewController * _Nonnull)viewController size:(ISBannerSize * _Nonnull)size delegate:(id<ISBannerAdDelegate> _Nonnull)delegate;
		[Abstract]
		[Export ("loadAdWithAdData:viewController:size:delegate:")]
		void LoadAdWithAdData (ISAdData adData, UIViewController viewController, ISBannerSize size, ISBannerAdDelegate @delegate);

		// @required -(void)destroyAdWithAdData:(ISAdData * _Nonnull)adData;
		[Abstract]
		[Export ("destroyAdWithAdData:")]
		void DestroyAdWithAdData (ISAdData adData);

		// @required -(BOOL)isSupportAdaptiveBanner;
		[Abstract]
		[Export ("isSupportAdaptiveBanner")]
		bool IsSupportAdaptiveBanner { get; }
	}

	// @protocol ISNetworkInitializationDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISNetworkInitializationDelegate
	{
		// @required -(void)onInitDidSucceed;
		[Abstract]
		[Export ("onInitDidSucceed")]
		void OnInitDidSucceed ();

		// @required -(void)onInitDidFailWithErrorCode:(NSInteger)errorCode errorMessage:(NSString * _Nullable)errorMessage;
		[Abstract]
		[Export ("onInitDidFailWithErrorCode:errorMessage:")]
		void OnInitDidFailWithErrorCode (nint errorCode, [NullAllowed] string errorMessage);
	}

	// @protocol ISAdapterBaseProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterBaseProtocol
	{
		// @required -(void)init:(ISAdData *)adData delegate:(id<ISNetworkInitializationDelegate>)delegate;
		[Abstract]
		[Export ("init:delegate:")]
		void Delegate (ISAdData adData, ISNetworkInitializationDelegate @delegate);

		// @required -(NSString *)networkSDKVersion;
		[Abstract]
		[Export ("networkSDKVersion")]
		string NetworkSDKVersion { get; }

		// @required -(NSString *)adapterVersion;
		[Abstract]
		[Export ("adapterVersion")]
		string AdapterVersion { get; }
	}

	// @interface ISBaseAdAdapter : NSObject
	[BaseType (typeof(NSObject))]
	interface ISBaseAdAdapter
	{
		// @property (readonly, nonatomic) ISAdapterConfig * _Nonnull adapterConfig;
		[Export ("adapterConfig")]
		ISAdapterConfig AdapterConfig { get; }

		// @property (readonly, nonatomic) NSUUID * _Nullable adUnitObjectId;
		[NullAllowed, Export ("adUnitObjectId")]
		NSUuid AdUnitObjectId { get; }

		// -(id<ISAdapterBaseProtocol> _Nullable)getNetworkAdapter;
		[NullAllowed, Export ("getNetworkAdapter")]
		ISAdapterBaseProtocol NetworkAdapter { get; }

		// -(void)releaseMemory;
		[Export ("releaseMemory")]
		void ReleaseMemory ();
	}

	// @interface ISBaseBanner : ISBaseAdAdapter <ISAdapterBannerProtocol>
	[BaseType (typeof(ISBaseAdAdapter))]
	interface ISBaseBanner : ISAdapterBannerProtocol
	{
		// -(instancetype _Nonnull)init:(ISAdapterConfig * _Nonnull)providerConfig;
		[Export ("init:")]
		NativeHandle Constructor (ISAdapterConfig providerConfig);

		// -(void)loadAdWithAdData:(ISAdData * _Nonnull)adData viewController:(UIViewController * _Nonnull)viewController size:(ISBannerSize * _Nonnull)size delegate:(id<ISBannerAdDelegate> _Nonnull)delegate;
		[Export ("loadAdWithAdData:viewController:size:delegate:")]
		new void LoadAdWithAdData (ISAdData adData, UIViewController viewController, ISBannerSize size, ISBannerAdDelegate @delegate);

		// -(void)destroyAdWithAdData:(ISAdData * _Nonnull)adData;
		[Export ("destroyAdWithAdData:")]
		new void DestroyAdWithAdData (ISAdData adData);
	}

	// @protocol ISAdapterAdInteractionDelegate <ISAdapterAdDelegate>
	[Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ISAdapterAdInteractionDelegate : ISAdapterAdDelegate
	{
		// @required -(void)adDidClose;
		[Abstract]
		[Export ("adDidClose")]
		void AdDidClose ();

		// @required -(void)adDidShowSucceed;
		[Abstract]
		[Export ("adDidShowSucceed")]
		void AdDidShowSucceed ();

		// @required -(void)adDidBecomeVisible;
		[Abstract]
		[Export ("adDidBecomeVisible")]
		void AdDidBecomeVisible ();

		// @required -(void)adDidStart;
		[Abstract]
		[Export ("adDidStart")]
		void AdDidStart ();

		// @required -(void)adDidEnd;
		[Abstract]
		[Export ("adDidEnd")]
		void AdDidEnd ();
	}

	// @protocol ISAdapterAdFullscreenProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterAdFullscreenProtocol
	{
		// @required -(void)loadAdWithAdData:(ISAdData *)adData delegate:(id<ISAdapterAdDelegate>)delegate;
		[Abstract]
		[Export ("loadAdWithAdData:delegate:")]
		void LoadAdWithAdData (ISAdData adData, ISAdapterAdDelegate @delegate);

		// @required -(void)showAdWithViewController:(UIViewController *)viewController adData:(ISAdData *)adData delegate:(id<ISAdapterAdInteractionDelegate>)delegate;
		[Abstract]
		[Export ("showAdWithViewController:adData:delegate:")]
		void ShowAdWithViewController (UIViewController viewController, ISAdData adData, ISAdapterAdInteractionDelegate @delegate);

		// @required -(BOOL)isAdAvailableWithAdData:(ISAdData *)adData;
		[Abstract]
		[Export ("isAdAvailableWithAdData:")]
		bool IsAdAvailableWithAdData (ISAdData adData);

		// @required -(void)disposeAd;
		[Abstract]
		[Export ("disposeAd")]
		void DisposeAd();
	}

	// @interface ISBaseAdInteractionAdapter : ISBaseAdAdapter <ISAdapterAdFullscreenProtocol>
	[BaseType (typeof(ISBaseAdAdapter))]
	interface ISBaseAdInteractionAdapter : ISAdapterAdFullscreenProtocol
	{
	}

	// @protocol ISInterstitialAdDelegate <ISAdapterAdInteractionDelegate>
	[Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ISInterstitialAdDelegate : ISAdapterAdInteractionDelegate
	{
	}

	// @interface ISBaseInterstitial : ISBaseAdInteractionAdapter
	[BaseType (typeof(ISBaseAdInteractionAdapter))]
	interface ISBaseInterstitial
	{
		// -(instancetype _Nonnull)init:(ISAdapterConfig * _Nonnull)providerConfig;
		[Export ("init:")]
		NativeHandle Constructor (ISAdapterConfig providerConfig);

		// -(void)loadAdWithAdData:(ISAdData * _Nonnull)adData delegate:(id<ISInterstitialAdDelegate> _Nonnull)delegate;
		[Export ("loadAdWithAdData:delegate:")]
		void LoadAdWithAdData (ISAdData adData, ISInterstitialAdDelegate @delegate);

		// -(void)showAdWithViewController:(UIViewController * _Nonnull)viewController adData:(ISAdData * _Nonnull)adData delegate:(id<ISInterstitialAdDelegate> _Nonnull)delegate;
		[Export ("showAdWithViewController:adData:delegate:")]
		void ShowAdWithViewController (UIViewController viewController, ISAdData adData, ISInterstitialAdDelegate @delegate);
	}

	// @protocol ISAdapterConsentProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterConsentProtocol
	{
		// @required -(void)setConsent:(BOOL)consent;
		[Abstract]
		[Export ("setConsent:")]
		void SetConsent (bool consent);
	}

	// @protocol ISAdapterDebugProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterDebugProtocol
	{
		// @required -(void)setAdapterDebug:(BOOL)adapterDebug;
		[Abstract]
		[Export ("setAdapterDebug:")]
		void SetAdapterDebug (bool adapterDebug);
	}

	// @protocol ISAdapterMetaDataProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterMetaDataProtocol
	{
		// @required -(void)setMetaDataWithKey:(NSString *)key andValues:(NSMutableArray *)values;
		[Abstract]
		[Export ("setMetaDataWithKey:andValues:")]
		void AndValues (string key, NSMutableArray values);
	}

	// @protocol ISAdapterTestModeProtocol <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterTestModeProtocol
	{
		// -(void)setTestMode:(BOOL)enabled;
		[Abstract]
		[Export ("setTestMode:")]
		void SetTestMode (bool enabled);
	}

	// @protocol ISAdapterNetworkData <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterNetworkData
	{
		// @required -(NSDictionary *)allData;
		[Abstract]
		[Export ("allData")]
		NSDictionary AllData { get; }

		// @required -(id)dataByKeyIgnoreCase:(NSString *)desiredKey valueType:(Class)valueType;
		[Abstract]
		[Export ("dataByKeyIgnoreCase:valueType:")]
		NSObject DataByKeyIgnoreCase(string desiredKey, Class valueType);
	}

	// @protocol ISAdapterNetworkDataProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterNetworkDataProtocol
	{
		// @required -(void)setNetworkData:(id<ISAdapterNetworkData>)networkData;
		[Abstract]
		[Export ("setNetworkData:")]
		void SetNetworkData (ISAdapterNetworkData networkData);
	}

	// @interface ISBaseNetworkAdapter : NSObject <ISAdapterBaseProtocol, ISAdapterDebugProtocol, ISAdapterConsentProtocol, ISAdapterMetaDataProtocol, ISAdapterNetworkDataProtocol>
	[BaseType (typeof(NSObject))]
	interface ISBaseNetworkAdapter : ISAdapterBaseProtocol, ISAdapterDebugProtocol, ISAdapterConsentProtocol, ISAdapterMetaDataProtocol, ISAdapterNetworkDataProtocol
	{
	}

	// @interface LevelPlayBaseAdapter : ISBaseNetworkAdapter <ISAdapterAdaptiveProtocol, ISAdapterMetaDataProtocol, ISAdapterTestModeProtocol>
	[BaseType (typeof(ISBaseNetworkAdapter))]
	interface LevelPlayBaseAdapter : ISAdapterAdaptiveProtocol, ISAdapterMetaDataProtocol, ISAdapterTestModeProtocol
	{
	}

	// @protocol ISAdapterAdRewardedDelegate <ISAdapterAdInteractionDelegate>
	[Protocol]
	interface ISAdapterAdRewardedDelegate : ISAdapterAdInteractionDelegate
	{
		// @required -(void)adRewarded;
		[Abstract]
		[Export ("adRewarded")]
		void AdRewarded ();
	}

	// @protocol ISRewardedVideoAdDelegate <ISAdapterAdRewardedDelegate>
	[Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ISRewardedVideoAdDelegate : ISAdapterAdRewardedDelegate
	{
	}

	// @interface ISBaseRewardedVideo : ISBaseAdInteractionAdapter
	[BaseType (typeof(ISBaseAdInteractionAdapter))]
	interface ISBaseRewardedVideo
	{
		// -(instancetype _Nonnull)init:(ISAdapterConfig * _Nonnull)providerConfig;
		[Export ("init:")]
		NativeHandle Constructor (ISAdapterConfig providerConfig);

		// -(void)loadAdWithAdData:(ISAdData * _Nonnull)adData delegate:(id<ISRewardedVideoAdDelegate> _Nonnull)delegate;
		[Export ("loadAdWithAdData:delegate:")]
		void LoadAdWithAdData (ISAdData adData, ISRewardedVideoAdDelegate @delegate);

		// -(void)showAdWithViewController:(UIViewController * _Nonnull)viewController adData:(ISAdData * _Nonnull)adData delegate:(id<ISRewardedVideoAdDelegate> _Nonnull)delegate;
		[Export ("showAdWithViewController:adData:delegate:")]
		void ShowAdWithViewController (UIViewController viewController, ISAdData adData, ISRewardedVideoAdDelegate @delegate);
	}

	// @interface LevelPlayBaseBannerAdapter : ISBaseBanner <ISBiddingDataProtocol>
	[BaseType (typeof(ISBaseBanner))]
	interface LevelPlayBaseBannerAdapter : ISBiddingDataProtocol
	{
	}

	// @interface LevelPlayBaseInterstitialAdapter : ISBaseInterstitial <ISBiddingDataProtocol>
	[BaseType (typeof(ISBaseInterstitial))]
	interface LevelPlayBaseInterstitialAdapter : ISBiddingDataProtocol
	{
	}

	// @interface LevelPlayBaseNativeAdAdapter : ISBaseNativeAd <ISBiddingDataProtocol>
	[BaseType (typeof(ISBaseNativeAd))]
	interface LevelPlayBaseNativeAdAdapter : ISBiddingDataProtocol
	{
	}

	// @interface LevelPlayBaseRewardedAdapter : ISBaseRewardedVideo <ISBiddingDataProtocol>
	[BaseType (typeof(ISBaseRewardedVideo))]
	interface LevelPlayBaseRewardedAdapter : ISBiddingDataProtocol
	{
		// -(NSString *)dynamicUserId;
		[Export ("dynamicUserId")]
		string DynamicUserId { get; }
	}

	// @interface ISDataKeys : NSObject
	[BaseType (typeof(NSObject))]
	interface ISDataKeys
	{
		// +(NSString * _Nonnull)USER_ID;
		[Static]
		[Export ("USER_ID")]
		string UserId { get; }

		// +(NSString * _Nonnull)AD_UNIT;
		[Static]
		[Export ("AD_UNIT")]
		string AdUnit { get; }

		// +(NSString * _Nonnull)AD_DATA_IS_MULTIPLE_AD_UNITS_FLOW;
		[Static]
		[Export ("AD_DATA_IS_MULTIPLE_AD_UNITS_FLOW")]
        string AdDataIsMultipleAdUnitsFlow { get; }

        // +(NSString * _Nonnull)AD_UNIT_ID;
        [Static]
		[Export ("AD_UNIT_ID")]
		string AdUnitId { get; }
	}

	// @protocol ISSetAPSDataProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISSetAPSDataProtocol
	{
		// @required -(void)setAPSDataWithAdUnit:(NSString * _Nonnull)adUnit apsData:(NSDictionary * _Nonnull)apsData;
		[Abstract]
		[Export ("setAPSDataWithAdUnit:apsData:")]
		void ApsData (string adUnit, NSDictionary apsData);
	}

	// @interface ISAdInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface ISAdInfo
	{
		// @property (readonly, copy) NSString * _Nonnull auction_id;
		[Export ("auction_id")]
		string AuctionId { get; }

		// @property (readonly, copy) NSString * _Nonnull ad_unit;
		[Export ("ad_unit")]
		string AdUnit { get; }

		// @property (readonly, copy) NSString * _Nonnull ad_network;
		[Export ("ad_network")]
		string AdNetwork { get; }

		// @property (readonly, copy) NSString * _Nonnull instance_name;
		[Export ("instance_name")]
		string InstanceName { get; }

		// @property (readonly, copy) NSString * _Nonnull instance_id;
		[Export ("instance_id")]
		string InstanceId { get; }

		// @property (readonly, copy) NSString * _Nonnull country;
		[Export ("country")]
		string Country { get; }

		// @property (readonly, copy) NSNumber * _Nonnull revenue;
		[Export ("revenue", ArgumentSemantic.Copy)]
		NSNumber Revenue { get; }

		// @property (readonly, copy) NSString * _Nonnull precision;
		[Export ("precision")]
		string Precision { get; }

		// @property (readonly, copy) NSString * _Nonnull ab;
		[Export ("ab")]
		string Ab { get; }

		// @property (readonly, copy) NSString * _Nonnull segment_name;
		[Export ("segment_name")]
		string SegmentName { get; }

		// @property (readonly, copy) NSNumber * _Nonnull lifetime_revenue;
		[Export ("lifetime_revenue", ArgumentSemantic.Copy)]
		NSNumber LifetimeRevenue { get; }

		// @property (readonly, copy) NSString * _Nonnull encrypted_cpm;
		[Export ("encrypted_cpm")]
		string EncryptedCpm { get; }

		// @property (readonly, copy) NSNumber * _Nonnull conversion_value;
		[Export ("conversion_value", ArgumentSemantic.Copy)]
		NSNumber ConversionValue { get; }

	}

	// @protocol ISNativeAdProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISNativeAdProtocol
	{
		// @required -(void)loadAd;
		[Abstract]
		[Export ("loadAd")]
		void LoadAd ();

		// @required -(void)destroyAd;
		[Abstract]
		[Export ("destroyAd")]
		void DestroyAd ();
	}

	// @interface LevelPlayMediaView : UIView
	[BaseType (typeof(UIView))]
	interface LevelPlayMediaView
	{
	}

	// @protocol ISNativeAdViewBinderProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISNativeAdViewBinderProtocol
	{
		// @required -(void)setIconView:(UIImageView *)iconView;
		[Abstract]
		[Export ("setIconView:")]
		void SetIconView (UIImageView iconView);

		// @required -(void)setTitleView:(UILabel *)titleView;
		[Abstract]
		[Export ("setTitleView:")]
		void SetTitleView (UILabel titleView);

		// @required -(void)setAdvertiserView:(UILabel *)advertiserView;
		[Abstract]
		[Export ("setAdvertiserView:")]
		void SetAdvertiserView (UILabel advertiserView);

		// @required -(void)setBodyView:(UILabel *)bodyView;
		[Abstract]
		[Export ("setBodyView:")]
		void SetBodyView (UILabel bodyView);

		// @required -(void)setMediaView:(LevelPlayMediaView *)mediaView;
		[Abstract]
		[Export ("setMediaView:")]
		void SetMediaView (LevelPlayMediaView mediaView);

		// @required -(void)setCallToActionView:(UIButton *)callToActionView;
		[Abstract]
		[Export ("setCallToActionView:")]
		void SetCallToActionView (UIButton callToActionView);
	}

	// @protocol ISAdapterNativeAdViewBinderProtocol <ISNativeAdViewBinderProtocol>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	interface ISAdapterNativeAdViewBinderProtocol : ISNativeAdViewBinderProtocol
	{
		// @required @property (nonatomic, strong) UIView * _Nullable networkNativeAdView;
		[Abstract]
		[NullAllowed, Export ("networkNativeAdView", ArgumentSemantic.Strong)]
		UIView NetworkNativeAdView { get; set; }

		// @required -(void)setNativeAdView:(UIView * _Nullable)nativeAdView;
		[Abstract]
		[Export ("setNativeAdView:")]
		void SetNativeAdView ([NullAllowed] UIView nativeAdView);
	}

	// @interface ISNativeAdViewHolder : NSObject
	[BaseType (typeof(NSObject))]
	interface ISNativeAdViewHolder
	{
		// @property (nonatomic, weak) UIImageView * _Nullable iconView;
		[NullAllowed, Export ("iconView", ArgumentSemantic.Weak)]
		UIImageView IconView { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable titleView;
		[NullAllowed, Export ("titleView", ArgumentSemantic.Weak)]
		UILabel TitleView { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable advertiserView;
		[NullAllowed, Export ("advertiserView", ArgumentSemantic.Weak)]
		UILabel AdvertiserView { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable bodyView;
		[NullAllowed, Export ("bodyView", ArgumentSemantic.Weak)]
		UILabel BodyView { get; set; }

		// @property (nonatomic, weak) LevelPlayMediaView * _Nullable mediaView;
		[NullAllowed, Export ("mediaView", ArgumentSemantic.Weak)]
		LevelPlayMediaView MediaView { get; set; }

		// @property (nonatomic, weak) UIButton * _Nullable callToActionView;
		[NullAllowed, Export ("callToActionView", ArgumentSemantic.Weak)]
		UIButton CallToActionView { get; set; }
	}

	// @interface ISAdapterNativeAdViewBinder : NSObject <ISAdapterNativeAdViewBinderProtocol>
	[BaseType (typeof(NSObject))]
	interface ISAdapterNativeAdViewBinder : ISAdapterNativeAdViewBinderProtocol
	{
		// @property (nonatomic, strong) ISNativeAdViewHolder * _Nullable adViewHolder;
		[NullAllowed, Export ("adViewHolder", ArgumentSemantic.Strong)]
		ISNativeAdViewHolder AdViewHolder { get; set; }
	}

	// @interface ISNativeAdDataImage : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISNativeAdDataImage
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; }

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image url:(NSURL * _Nullable)url;
		[Export ("initWithImage:url:")]
		NativeHandle Constructor ([NullAllowed] UIImage image, [NullAllowed] NSUrl url);
	}

	// @protocol ISNativeAdDataProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISNativeAdDataProtocol
	{
		// @required @property (nonatomic, strong) NSString * _Nullable title;
		[Abstract]
		[NullAllowed, Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @required @property (nonatomic, strong) NSString * _Nullable advertiser;
		[Abstract]
		[NullAllowed, Export ("advertiser", ArgumentSemantic.Strong)]
		string Advertiser { get; set; }

		// @required @property (nonatomic, strong) NSString * _Nullable body;
		[Abstract]
		[NullAllowed, Export ("body", ArgumentSemantic.Strong)]
		string Body { get; set; }

		// @required @property (nonatomic, strong) NSString * _Nullable callToAction;
		[Abstract]
		[NullAllowed, Export ("callToAction", ArgumentSemantic.Strong)]
		string CallToAction { get; set; }

		// @required @property (nonatomic, strong) ISNativeAdDataImage * _Nullable icon;
		[Abstract]
		[NullAllowed, Export ("icon", ArgumentSemantic.Strong)]
		ISNativeAdDataImage Icon { get; set; }
	}

	// @protocol ISNativeAdInteractionDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISNativeAdInteractionDelegate
	{
		// @required -(void)didRecordImpression:(LevelPlayNativeAd * _Nonnull)nativeAd withAdInfo:(ISAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didRecordImpression:withAdInfo:")]
		void DidRecordImpression (LevelPlayNativeAd nativeAd, ISAdInfo adInfo);

		// @required -(void)didClick:(LevelPlayNativeAd * _Nonnull)nativeAd withAdInfo:(ISAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didClick:withAdInfo:")]
		void DidClick (LevelPlayNativeAd nativeAd, ISAdInfo adInfo);
	}

	// @interface ISError : NSError
	[BaseType (typeof(NSError))]
	interface ISError
	{
		// @property (strong) NSString * prefix;
		[Export ("prefix", ArgumentSemantic.Strong)]
		string Prefix { get; set; }

		// @property (strong) NSString * suffix;
		[Export ("suffix", ArgumentSemantic.Strong)]
		string Suffix { get; set; }

		// +(NSError *)createError:(ISErrorCode)errorCode;
		[Static]
		[Export ("createError:")]
		NSError CreateError (ISErrorCode errorCode);

		// +(NSError *)createError:(ISErrorCode)errorCode withParams:(NSArray *)params;
		[Static]
		[Export ("createError:withParams:")]
		NSError CreateError (ISErrorCode errorCode, NSObject[] @params);

		// +(NSError *)createError:(ISErrorCode)errorCode withMessage:(NSString *)message;
		[Static]
		[Export ("createError:withMessage:")]
		NSError CreateError (ISErrorCode errorCode, string message);

		// +(NSError *)createErrorWithDomain:(NSString *)domain code:(ISErrorCode)code message:(NSString *)message;
		[Static]
		[Export ("createErrorWithDomain:code:message:")]
		NSError CreateErrorWithDomain (string domain, ISErrorCode code, string message);

		// +(NSError *)appendError:(NSError *)error withPrefix:(NSString *)prefix;
		[Static]
		[Export ("appendError:withPrefix:")]
		NSError AppendErrorWithPrefix (NSError error, string prefix);

		// +(NSError *)appendError:(NSError *)error withSuffix:(NSString *)suffix;
		[Static]
		[Export ("appendError:withSuffix:")]
		NSError AppendErrorWithSuffix (NSError error, string suffix);

		// +(ISErrorCode)getCode:(ISErrorCode)errorCode;
		[Static]
		[Export ("getCode:")]
		ISErrorCode GetCode (ISErrorCode errorCode);
	}

	// @protocol ISNativeAdLoadDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISNativeAdLoadDelegate
	{
		// @required -(void)didLoad:(LevelPlayNativeAd * _Nonnull)nativeAd withAdInfo:(ISAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didLoad:withAdInfo:")]
		void DidLoad (LevelPlayNativeAd nativeAd, ISAdInfo adInfo);

		// @required -(void)didFailToLoad:(LevelPlayNativeAd * _Nonnull)nativeAd withError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("didFailToLoad:withError:")]
		void DidFailToLoad (LevelPlayNativeAd nativeAd, NSError error);
	}

	// @protocol LevelPlayNativeAdDelegate <ISNativeAdLoadDelegate, ISNativeAdInteractionDelegate>
	[Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface LevelPlayNativeAdDelegate : ISNativeAdLoadDelegate, ISNativeAdInteractionDelegate
	{
	}

	// @interface LevelPlayNativeAdBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface LevelPlayNativeAdBuilder
	{
		// @property (nonatomic, strong) NSString * placementName;
		[Export ("placementName", ArgumentSemantic.Strong)]
		string PlacementName { get; set; }

		[Wrap ("WeakDelegate")]
		LevelPlayNativeAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<LevelPlayNativeAdDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) UIViewController * viewController;
		[Export ("viewController", ArgumentSemantic.Weak)]
		UIViewController ViewController { get; set; }

		// -(LevelPlayNativeAdBuilder *)withViewController:(UIViewController *)viewController;
		[Export ("withViewController:")]
		LevelPlayNativeAdBuilder WithViewController (UIViewController viewController);

		// -(LevelPlayNativeAdBuilder *)withPlacementName:(NSString *)placementName;
		[Export ("withPlacementName:")]
		LevelPlayNativeAdBuilder WithPlacementName (string placementName);

		// -(LevelPlayNativeAdBuilder *)withDelegate:(id<LevelPlayNativeAdDelegate>)delegate;
		[Export ("withDelegate:")]
		LevelPlayNativeAdBuilder WithDelegate (LevelPlayNativeAdDelegate @delegate);

		// -(LevelPlayNativeAd *)build;
		[Export ("build")]
		LevelPlayNativeAd Build();
	}

	// @interface LevelPlayNativeAd : NSObject <ISNativeAdDataProtocol>
	[BaseType (typeof(NSObject))]
	interface LevelPlayNativeAd : ISNativeAdDataProtocol
	{
		// @property (nonatomic, strong) ISAdapterNativeAdViewBinder * _Nullable nativeAdViewBinder;
		[NullAllowed, Export ("nativeAdViewBinder", ArgumentSemantic.Strong)]
		ISAdapterNativeAdViewBinder NativeAdViewBinder { get; set; }

		// -(instancetype _Nonnull)initWithBuilder:(LevelPlayNativeAdBuilder * _Nonnull)builder;
		[Export ("initWithBuilder:")]
		NativeHandle Constructor (LevelPlayNativeAdBuilder builder);

		// -(void)loadAd;
		[Export ("loadAd")]
		void LoadAd ();

		// -(void)destroyAd;
		[Export ("destroyAd")]
		void DestroyAd ();

		// -(void)setDelegate:(id<LevelPlayNativeAdDelegate> _Nonnull)delegate;
		[Export ("setDelegate:")]
		void SetDelegate (LevelPlayNativeAdDelegate @delegate);

		// -(NSString * _Nonnull)getObjectId;
		[Export ("getObjectId")]
		string ObjectId { get; }
	}

	// @interface ISNativeAdView : UIView
	[BaseType (typeof(UIView))]
	interface ISNativeAdView
	{
		// @property (nonatomic, weak) UIImageView * _Nullable adAppIcon __attribute__((iboutlet));
		[NullAllowed, Export ("adAppIcon", ArgumentSemantic.Weak)]
		UIImageView AdAppIcon { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable adTitleView __attribute__((iboutlet));
		[NullAllowed, Export ("adTitleView", ArgumentSemantic.Weak)]
		UILabel AdTitleView { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable adAdvertiserView __attribute__((iboutlet));
		[NullAllowed, Export ("adAdvertiserView", ArgumentSemantic.Weak)]
		UILabel AdAdvertiserView { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable adBodyView __attribute__((iboutlet));
		[NullAllowed, Export ("adBodyView", ArgumentSemantic.Weak)]
		UILabel AdBodyView { get; set; }

		// @property (nonatomic, weak) LevelPlayMediaView * _Nullable adMediaView __attribute__((iboutlet));
		[NullAllowed, Export ("adMediaView", ArgumentSemantic.Weak)]
		LevelPlayMediaView AdMediaView { get; set; }

		// @property (nonatomic, weak) UIButton * _Nullable adCallToActionView __attribute__((iboutlet));
		[NullAllowed, Export ("adCallToActionView", ArgumentSemantic.Weak)]
		UIButton AdCallToActionView { get; set; }

		// -(void)registerNativeAdViews:(LevelPlayNativeAd * _Nonnull)nativeAd;
		[Export ("registerNativeAdViews:")]
		void RegisterNativeAdViews (LevelPlayNativeAd nativeAd);
	}

	// @interface LPMAdSize : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMAdSize : INSCopying
	{
		// @property (readonly, nonatomic) LPMAdSizeType type;
		[Export ("type")]
		LPMAdSizeType Type { get; }

		// @property (readonly, nonatomic) NSInteger width;
		[Export ("width")]
		nint Width { get; }

		// @property (readonly, nonatomic) NSInteger height;
		[Export ("height")]
		nint Height { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sizeDescription;
		[Export ("sizeDescription")]
		string SizeDescription { get; }

		// @property (readonly, nonatomic) BOOL isAdaptive;
		[Export ("isAdaptive")]
		bool IsAdaptive { get; }

		// +(instancetype _Nonnull)bannerSize;
		[Static]
		[Export ("bannerSize")]
		LPMAdSize BannerSize { get; }

		// +(instancetype _Nonnull)largeSize;
		[Static]
		[Export ("largeSize")]
		LPMAdSize LargeSize { get; }

		// +(instancetype _Nonnull)mediumRectangleSize;
		[Static]
		[Export ("mediumRectangleSize")]
		LPMAdSize MediumRectangleSize { get; }

		// +(instancetype _Nonnull)leaderBoardSize;
		[Static]
		[Export ("leaderBoardSize")]
		LPMAdSize LeaderBoardSize { get; }

		// +(instancetype _Nonnull)customSizeWithWidth:(NSInteger)width height:(NSInteger)height;
		[Static]
		[Export ("customSizeWithWidth:height:")]
		LPMAdSize CustomSizeWithWidth (nint width, nint height);

		// +(instancetype _Nullable)createAdaptiveAdSizeWithWidth:(CGFloat)width;
		[Static]
		[Export ("createAdaptiveAdSizeWithWidth:")]
		[return: NullAllowed]
		LPMAdSize CreateAdaptiveAdSizeWithWidth (nfloat width);

		// +(instancetype _Nullable)createAdaptiveAdSize;
		[Static]
		[Export ("createAdaptiveAdSize")]
		[return: NullAllowed]
		LPMAdSize CreateAdaptiveAdSize ();
	}

	// @interface LPMAdInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMAdInfo
	{
		// @property (readonly, copy) NSString * _Nonnull adId;
		[Export ("adId")]
		string AdId { get; }

		// @property (readonly, copy) NSString * _Nonnull adUnitId;
		[Export ("adUnitId")]
		string AdUnitId { get; }

		// @property (readonly, copy) NSString * _Nonnull adUnitName;
		[Export ("adUnitName")]
		string AdUnitName { get; }

		// @property (readonly, copy) NSString * _Nullable placementName;
		[NullAllowed, Export ("placementName")]
		string PlacementName { get; }

		// @property (readonly, copy) LPMAdSize * _Nullable adSize;
		[NullAllowed, Export ("adSize", ArgumentSemantic.Copy)]
		LPMAdSize AdSize { get; }

		// @property (readonly, copy) NSString * _Nonnull adFormat;
		[Export ("adFormat")]
		string AdFormat { get; }

		// @property (readonly, copy) NSString * _Nonnull auctionId;
		[Export ("auctionId")]
		string AuctionId { get; }

		// @property (readonly, copy) NSString * _Nonnull country;
		[Export ("country")]
		string Country { get; }

		// @property (readonly, copy) NSString * _Nonnull ab;
		[Export ("ab")]
		string Ab { get; }

		// @property (readonly, copy) NSString * _Nonnull segmentName;
		[Export ("segmentName")]
		string SegmentName { get; }

		// @property (readonly, copy) NSString * _Nonnull adNetwork;
		[Export ("adNetwork")]
		string AdNetwork { get; }

		// @property (readonly, copy) NSString * _Nonnull instanceName;
		[Export ("instanceName")]
		string InstanceName { get; }

		// @property (readonly, copy) NSString * _Nonnull instanceId;
		[Export ("instanceId")]
		string InstanceId { get; }

		// @property (readonly, copy) NSNumber * _Nonnull revenue;
		[Export ("revenue", ArgumentSemantic.Copy)]
		NSNumber Revenue { get; }

		// @property (readonly, copy) NSString * _Nonnull precision;
		[Export ("precision")]
		string Precision { get; }

		// @property (readonly, copy) NSString * _Nonnull encryptedCPM;
		[Export ("encryptedCPM")]
		string EncryptedCPM { get; }

		// @property (readonly, copy) NSNumber * _Nonnull conversionValue;
		[Export ("conversionValue", ArgumentSemantic.Copy)]
		NSNumber ConversionValue { get; }

		// @property (readonly, copy) NSString * _Nonnull creativeId;
		[Export ("creativeId")]
		string CreativeId { get; }
	}

	// @protocol LPMBannerAdViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface LPMBannerAdViewDelegate
	{
		// @required -(void)didLoadAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didLoadAdWithAdInfo:")]
		void DidLoadAdWithAdInfo (LPMAdInfo adInfo);

		// @required -(void)didFailToLoadAdWithAdUnitId:(NSString * _Nonnull)adUnitId error:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("didFailToLoadAdWithAdUnitId:error:")]
		void DidFailToLoadAdWithAdUnitId (string adUnitId, NSError error);

		// @optional -(void)didClickAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didClickAdWithAdInfo:")]
		void DidClickAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didDisplayAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didDisplayAdWithAdInfo:")]
		void DidDisplayAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didFailToDisplayAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo error:(NSError * _Nonnull)error;
		[Export ("didFailToDisplayAdWithAdInfo:error:")]
		void DidFailToDisplayAdWithAdInfo (LPMAdInfo adInfo, NSError error);

		// @optional -(void)didLeaveAppWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didLeaveAppWithAdInfo:")]
		void DidLeaveAppWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didExpandAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didExpandAdWithAdInfo:")]
		void DidExpandAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didCollapseAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didCollapseAdWithAdInfo:")]
		void DidCollapseAdWithAdInfo (LPMAdInfo adInfo);
	}

	// @interface LPMBannerAdView : UIView
	[BaseType (typeof(UIView))]
	[DisableDefaultCtor]
	interface LPMBannerAdView
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull adId;
		[Export ("adId", ArgumentSemantic.Strong)]
		string AdId { get; }

		// -(instancetype _Nonnull)initWithAdUnitId:(NSString * _Nonnull)adUnitId;
		[Export ("initWithAdUnitId:")]
		NativeHandle Constructor (string adUnitId);

		// -(instancetype)initWithAdUnitId:(NSString *)adUnitId config:(LPMBannerAdViewConfig *)config;
		[Export ("initWithAdUnitId:config:")]
		NativeHandle Constructor (string adUnitId, LPMBannerAdViewConfig config);

		// -(void)setDelegate:(id<LPMBannerAdViewDelegate> _Nonnull)delegate;
		[Export ("setDelegate:")]
		void SetDelegate (LPMBannerAdViewDelegate @delegate);

		// -(void)loadAdWithViewController:(UIViewController * _Nonnull)viewController;
		[Export ("loadAdWithViewController:")]
		void LoadAdWithViewController (UIViewController viewController);

		// -(void)destroy;
		[Export ("destroy")]
		void Destroy ();

		// -(void)pauseAutoRefresh;
		[Export ("pauseAutoRefresh")]
		void PauseAutoRefresh ();

		// -(void)resumeAutoRefresh;
		[Export ("resumeAutoRefresh")]
		void ResumeAutoRefresh ();
	}

	// @interface LPMInitRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMInitRequest
	{
		// -(instancetype)initWithAppKey:(NSString *)appKey userId:(nullable NSString *)userId;
		[Export ("initWithAppKey:userId:")]
		NativeHandle Constructor (string appKey, [NullAllowed] string userId);

		// @property (readonly, nonatomic) NSString * _Nonnull appKey;
		[Export ("appKey")]
		string AppKey { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull legacyAdFormats;
		[Export ("legacyAdFormats")]
		string[] LegacyAdFormats { get; }

		// @property (readonly, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export ("userId")]
		string UserId { get; }
	}

	// @interface LPMInitRequestBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMInitRequestBuilder
	{
		// -(instancetype _Nonnull)initWithAppKey:(NSString * _Nonnull)appKey;
		[Export ("initWithAppKey:")]
		NativeHandle Constructor (string appKey);

		// -(LPMInitRequest * _Nonnull)build;
		[Export("build")]
		LPMInitRequest Build();

		// -(LPMInitRequestBuilder * _Nonnull)withUserId:(NSString * _Nonnull)userId;
		[Export ("withUserId:")]
		LPMInitRequestBuilder WithUserId (string userId);
	}

	// @protocol LPMInterstitialAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface LPMInterstitialAdDelegate
	{
		// @required -(void)didLoadAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didLoadAdWithAdInfo:")]
		void DidLoadAdWithAdInfo (LPMAdInfo adInfo);

		// @required -(void)didFailToLoadAdWithAdUnitId:(NSString * _Nonnull)adUnitId error:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("didFailToLoadAdWithAdUnitId:error:")]
		void DidFailToLoadAdWithAdUnitId (string adUnitId, NSError error);

		// @required -(void)didDisplayAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didDisplayAdWithAdInfo:")]
		void DidDisplayAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didFailToDisplayAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo error:(NSError * _Nonnull)error;
		[Export ("didFailToDisplayAdWithAdInfo:error:")]
		void DidFailToDisplayAdWithAdInfo (LPMAdInfo adInfo, NSError error);

		// @optional -(void)didClickAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didClickAdWithAdInfo:")]
		void DidClickAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didCloseAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didCloseAdWithAdInfo:")]
		void DidCloseAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didChangeAdInfo:(LPMAdInfo * _Nonnull)adInfo __attribute__((swift_name("didChangeAdInfo(_:)")));
		[Export ("didChangeAdInfo:")]
		void DidChangeAdInfo (LPMAdInfo adInfo);
	}

	// @interface LPMInterstitialAd : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMInterstitialAd
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull adId;
		[Export ("adId", ArgumentSemantic.Strong)]
		string AdId { get; }

		// -(instancetype _Nonnull)initWithAdUnitId:(NSString * _Nonnull)adUnitId;
		[Export ("initWithAdUnitId:")]
		NativeHandle Constructor (string adUnitId);

		// -(instancetype)initWithAdUnitId:(NSString *)adUnitId config:(LPMInterstitialAdConfig *)config;
		[Export ("initWithAdUnitId:config:")]
		NativeHandle Constructor (string adUnitId, LPMInterstitialAdConfig config);

		// -(void)setDelegate:(id<LPMInterstitialAdDelegate> _Nonnull)delegate;
		[Export ("setDelegate:")]
		void SetDelegate (LPMInterstitialAdDelegate @delegate);

		// -(void)loadAd __attribute__((swift_name("loadAd()")));
		[Export ("loadAd")]
		void LoadAd ();

		// -(void)showAdWithViewController:(UIViewController * _Nonnull)viewController placementName:(NSString * _Nullable)placementName __attribute__((swift_name("showAd(viewController:placementName:)")));
		[Export ("showAdWithViewController:placementName:")]
		void ShowAdWithViewController (UIViewController viewController, [NullAllowed] string placementName);

		// -(BOOL)isAdReady;
		[Export ("isAdReady")]
		bool IsAdReady { get; }

		// +(BOOL)isPlacementCapped:(NSString * _Nonnull)placementName;
		[Static]
		[Export ("isPlacementCapped:")]
		bool IsPlacementCapped (string placementName);
	}

	// @interface LPMReward : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMReward
	{
		// @property (readonly, nonatomic) NSInteger amount;
		[Export ("amount")]
		nint Amount { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name amount:(NSInteger)amount;
		[Export ("initWithName:amount:")]
		NativeHandle Constructor (string name, nint amount);
	}

	// @protocol LPMRewardedAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface LPMRewardedAdDelegate
	{
		// @required -(void)didLoadAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didLoadAdWithAdInfo:")]
		void DidLoadAdWithAdInfo (LPMAdInfo adInfo);

		// @required -(void)didFailToLoadAdWithAdUnitId:(NSString * _Nonnull)adUnitId error:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("didFailToLoadAdWithAdUnitId:error:")]
		void DidFailToLoadAdWithAdUnitId (string adUnitId, NSError error);

		// @required -(void)didDisplayAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Abstract]
		[Export ("didDisplayAdWithAdInfo:")]
		void DidDisplayAdWithAdInfo (LPMAdInfo adInfo);

		// @required -(void)didRewardAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo reward:(LPMReward * _Nonnull)reward;
		[Abstract]
		[Export ("didRewardAdWithAdInfo:reward:")]
		void DidRewardAdWithAdInfo (LPMAdInfo adInfo, LPMReward reward);

		// @optional -(void)didFailToDisplayAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo error:(NSError * _Nonnull)error;
		[Export ("didFailToDisplayAdWithAdInfo:error:")]
		void DidFailToDisplayAdWithAdInfo (LPMAdInfo adInfo, NSError error);

		// @optional -(void)didClickAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didClickAdWithAdInfo:")]
		void DidClickAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didCloseAdWithAdInfo:(LPMAdInfo * _Nonnull)adInfo;
		[Export ("didCloseAdWithAdInfo:")]
		void DidCloseAdWithAdInfo (LPMAdInfo adInfo);

		// @optional -(void)didChangeAdInfo:(LPMAdInfo * _Nonnull)adInfo __attribute__((swift_name("didChangeAdInfo(_:)")));
		[Export ("didChangeAdInfo:")]
		void DidChangeAdInfo (LPMAdInfo adInfo);
	}

	// @interface LPMRewardedAd : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMRewardedAd
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull adId;
		[Export ("adId", ArgumentSemantic.Strong)]
		string AdId { get; }

		// -(instancetype _Nonnull)initWithAdUnitId:(NSString * _Nonnull)adUnitId;
		[Export ("initWithAdUnitId:")]
		NativeHandle Constructor (string adUnitId);

		// -(instancetype)initWithAdUnitId:(NSString *)adUnitId config:(LPMRewardedAdConfig *)config;
		[Export ("initWithAdUnitId:config:")]
		NativeHandle Constructor (string adUnitId, LPMRewardedAdConfig config);

		// -(void)setDelegate:(id<LPMRewardedAdDelegate> _Nonnull)delegate;
		[Export ("setDelegate:")]
		void SetDelegate (LPMRewardedAdDelegate @delegate);

		// -(void)loadAd __attribute__((swift_name("loadAd()")));
		[Export ("loadAd")]
		void LoadAd ();

		// -(void)showAdWithViewController:(UIViewController * _Nonnull)viewController placementName:(NSString * _Nullable)placementName __attribute__((swift_name("showAd(viewController:placementName:)")));
		[Export ("showAdWithViewController:placementName:")]
		void ShowAdWithViewController (UIViewController viewController, [NullAllowed] string placementName);

		// -(BOOL)isAdReady;
		[Export ("isAdReady")]
		bool IsAdReady { get; }

		// -(LPMReward *)getRewardWithPlacementName:(nullable NSString *)placement;
		[Export ("getRewardWithPlacementName:")]
		LPMReward GetRewardWithPlacementName ([NullAllowed] string placement);

		// +(BOOL)isPlacementCapped:(NSString * _Nonnull)placementName;
		[Static]
		[Export ("isPlacementCapped:")]
		bool IsPlacementCapped (string placementName);
	}

	// @interface LPMConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMConfiguration
	{
		// @property (assign, nonatomic) BOOL isAdQualityEnabled;
		[Export ("isAdQualityEnabled")]
		bool IsAdQualityEnabled { get; set; }
	}

	// typedef void (^LPMInitCompletionHandler)(LPMConfiguration * _Nullable, NSError * _Nullable);
	delegate void LPMInitCompletionHandler ([NullAllowed] LPMConfiguration arg0, [NullAllowed] NSError arg1);

	// @interface LPMBannerAdViewConfig : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMBannerAdViewConfig
	{
		// @property(nonatomic, strong, nullable, readonly) LPMAdSize *adSize;
		[NullAllowed, Export ("adSize", ArgumentSemantic.Strong)]
		LPMAdSize AdSize { get; }

		// @property(nonatomic, strong, nullable, readonly) NSNumber *bidFloor;
		[NullAllowed, Export ("bidFloor", ArgumentSemantic.Strong)]
		NSNumber BidFloor { get; }

		// @property(nonatomic, strong, nullable, readonly) NSString *placementName;
		[NullAllowed, Export ("placementName", ArgumentSemantic.Strong)]
		string PlacementName { get; }
	}

	// @interface LPMBannerAdViewConfigBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMBannerAdViewConfigBuilder
	{
		// -(LPMBannerAdViewConfigBuilder *)setWithAdSize:(LPMAdSize *)adSize;
		[Export ("setWithAdSize:")]
		LPMBannerAdViewConfigBuilder SetWithAdSize (LPMAdSize adSize);

		// -(LPMBannerAdViewConfigBuilder *)setWithBidFloor:(NSNumber *)bidFloor;
		[Export ("setWithBidFloor:")]
		LPMBannerAdViewConfigBuilder SetWithBidFloor (NSNumber bidFloor);

		// -(LPMBannerAdViewConfigBuilder *)setWithPlacementName:(NSString *)placementName;
		[Export ("setWithPlacementName:")]
		LPMBannerAdViewConfigBuilder SetWithPlacementName (string placementName);

		// -(LPMBannerAdViewConfig *)build;
		[Export ("build")]
		LPMBannerAdViewConfig Build();
	}

	// @interface LPMInterstitialAdConfig : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMInterstitialAdConfig
	{
		// @property(nonatomic, strong, nullable, readonly) NSNumber *bidFloor;
		[NullAllowed, Export ("bidFloor", ArgumentSemantic.Strong)]
		NSNumber BidFloor { get; }
	}

	// @interface LPMInterstitialAdConfigBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMInterstitialAdConfigBuilder
	{
		// -(LPMInterstitialAdConfigBuilder *)setWithBidFloor:(NSNumber *)bidFloor;
		[Export ("setWithBidFloor:")]
		LPMInterstitialAdConfigBuilder SetWithBidFloor (NSNumber bidFloor);

		// -(LPMInterstitialAdConfig *)build;
		[Export ("build")]
		LPMInterstitialAdConfig Build();
	}

	// @interface LPMRewardedAdConfig : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LPMRewardedAdConfig
	{
		// @property(nonatomic, strong, nullable, readonly) NSNumber *bidFloor;
		[NullAllowed, Export ("bidFloor", ArgumentSemantic.Strong)]
		NSNumber BidFloor { get; }
	}

	// @interface LPMRewardedAdConfigBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMRewardedAdConfigBuilder
	{
		// -(LPMRewardedAdConfigBuilder *)setWithBidFloor:(NSNumber *)bidFloor;
		[Export ("setWithBidFloor:")]
		LPMRewardedAdConfigBuilder SetWithBidFloor (NSNumber bidFloor);

		// -(LPMRewardedAdConfig *)build;
		[Export ("build")]
		LPMRewardedAdConfig Build();
	}

	// @interface LPMImpressionData : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMImpressionData
	{
		// @property(readonly, copy, nullable) NSString *auctionId;
		[NullAllowed, Export ("auctionId")]
		string AuctionId { get; }

		// @property(readonly, copy, nullable) NSString *mediationAdUnitName;
		[NullAllowed, Export ("mediationAdUnitName")]
		string MediationAdUnitName { get; }

		// @property(readonly, copy, nullable) NSString *mediationAdUnitId;
		[NullAllowed, Export ("mediationAdUnitId")]
		string MediationAdUnitId { get; }

		// @property(readonly, copy, nullable) NSString *adFormat;
		[NullAllowed, Export ("adFormat")]
		string AdFormat { get; }

		// @property(readonly, copy, nullable) NSString *adNetwork;
		[NullAllowed, Export ("adNetwork")]
		string AdNetwork { get; }

		// @property(readonly, copy, nullable) NSString *instanceName;
		[NullAllowed, Export ("instanceName")]
		string InstanceName { get; }

		// @property(readonly, copy, nullable) NSString *instanceId;
		[NullAllowed, Export ("instanceId")]
		string InstanceId { get; }

		// @property(readonly, copy, nullable) NSString *country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property(readonly, copy, nullable) NSString *placement;
		[NullAllowed, Export ("placement")]
		string Placement { get; }

		// @property(readonly, copy, nullable) NSNumber *revenue;
		[NullAllowed, Export ("revenue", ArgumentSemantic.Copy)]
		NSNumber Revenue { get; }

		// @property(readonly, copy, nullable) NSString *precision;
		[NullAllowed, Export ("precision")]
		string Precision { get; }

		// @property(readonly, copy, nullable) NSString *ab;
		[NullAllowed, Export ("ab")]
		string Ab { get; }

		// @property(readonly, copy, nullable) NSString *segmentName;
		[NullAllowed, Export ("segmentName")]
		string SegmentName { get; }

		// @property(readonly, copy, nullable) NSString *encryptedCpm;
		[NullAllowed, Export ("encryptedCpm")]
		string EncryptedCpm { get; }

		// @property(readonly, copy, nullable) NSNumber *conversionValue;
		[NullAllowed, Export ("conversionValue", ArgumentSemantic.Copy)]
		NSNumber ConversionValue { get; }

		// @property(readonly, copy, nullable) NSString *creativeId;
		[NullAllowed, Export ("creativeId")]
		string CreativeId { get; }

		// @property(readonly, copy, nullable) NSDictionary *allData;
		[NullAllowed, Export ("allData", ArgumentSemantic.Copy)]
		NSDictionary AllData { get; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
		[Export ("initWithDictionary:")]
		NativeHandle Constructor (NSDictionary dictionary);

		// -(instancetype)initWithImpressionData:(LPMImpressionData *)impressionData;
		[Export ("initWithImpressionData:")]
		NativeHandle Constructor (LPMImpressionData impressionData);

		// -(void)replacePlacementMacro:(NSString *)macro value:(NSString *)value;
		[Export ("replacePlacementMacro:value:")]
		void ReplacePlacementMacro (string macro, string value);
	}

	// @protocol LPMImpressionDataDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface LPMImpressionDataDelegate
	{
		// -(void)impressionDataDidSucceed:(LPMImpressionData *)impressionData;
		[Abstract]
		[Export ("impressionDataDidSucceed:")]
		void ImpressionDataDidSucceed (LPMImpressionData impressionData);
	}

	// @interface LPMSegment : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMSegment
	{
		// @property(nonatomic) int level;
		[Export ("level")]
		int Level { get; set; }

		// @property(nonatomic) double iapTotal;
		[Export ("iapTotal")]
		double IapTotal { get; set; }

		// @property(nonatomic) BOOL paying;
		[Export ("paying")]
		bool Paying { get; set; }

		// @property(nonatomic, strong) NSDate *userCreationDate;
		[Export ("userCreationDate", ArgumentSemantic.Strong)]
		NSDate UserCreationDate { get; set; }

		// @property(nonatomic, strong) NSString *segmentName;
		[Export ("segmentName", ArgumentSemantic.Strong)]
		string SegmentName { get; set; }

		// @property(nonatomic, strong, readonly) NSDictionary<NSString *, NSString *> *customKeys;
		[Export ("customKeys", ArgumentSemantic.Strong)]
		NSDictionary CustomKeys { get; }

		// -(void)setCustomValue:(NSString *)value forKey:(NSString *)key;
		[Export ("setCustomValue:forKey:")]
		void SetCustomValue (string value, string key);

		// -(NSDictionary *)getData;
		[Export ("getData")]
		NSDictionary Data { get; }
	}

	// @interface LPMPrivacySettings : NSObject
	[BaseType (typeof(NSObject))]
	interface LPMPrivacySettings
	{
		// +(void)setGDPRConsents:(NSDictionary<NSString *, NSNumber *> *)networkConsents;
		[Static]
		[Export ("setGDPRConsents:")]
		void SetGDPRConsents (NSDictionary networkConsents);

		// +(void)setCCPA:(BOOL)value;
		[Static]
		[Export ("setCCPA:")]
		void SetCCPA (bool value);

		// +(void)setCOPPA:(BOOL)value;
		[Static]
		[Export ("setCOPPA:")]
		void SetCOPPA (bool value);
	}

	// @interface LevelPlay : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LevelPlay
	{
		// +(void)initWithRequest:(LPMInitRequest * _Nonnull)request completion:(LPMInitCompletionHandler _Nonnull)completion;
		[Static]
		[Export ("initWithRequest:completion:")]
		void InitWithRequest (LPMInitRequest request, LPMInitCompletionHandler completion);

		// +(NSString *)sdkVersion;
		[Static]
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// +(void)addImpressionDataDelegate:(id<LPMImpressionDataDelegate>)delegate;
		[Static]
		[Export ("addImpressionDataDelegate:")]
		void AddImpressionDataDelegate (LPMImpressionDataDelegate @delegate);

		// +(void)removeImpressionDataDelegate:(id<LPMImpressionDataDelegate>)delegate;
		[Static]
		[Export ("removeImpressionDataDelegate:")]
		void RemoveImpressionDataDelegate (LPMImpressionDataDelegate @delegate);

		// +(void)setMetaDataWithKey:(NSString *)key value:(NSString *)value;
		[Static]
		[Export ("setMetaDataWithKey:value:")]
		void SetMetaDataWithKey (string key, string value);

		// +(void)setMetaDataWithKey:(NSString *)key values:(NSMutableArray *)values;
		[Static]
		[Export ("setMetaDataWithKey:values:")]
		void SetMetaDataWithKey (string key, NSMutableArray values);

		// +(void)setNetworkDataWithNetworkKey:(NSString *)networkKey andNetworkData:(NSDictionary *)networkData;
		[Static]
		[Export ("setNetworkDataWithNetworkKey:andNetworkData:")]
		void SetNetworkDataWithNetworkKey (string networkKey, NSDictionary networkData);

		// +(BOOL)setDynamicUserId:(NSString *)dynamicUserId;
		[Static]
		[Export ("setDynamicUserId:")]
		bool SetDynamicUserId (string dynamicUserId);

		// +(void)setAdaptersDebug:(BOOL)flag;
		[Static]
		[Export ("setAdaptersDebug:")]
		void SetAdaptersDebug (bool flag);

		// +(void)setSegment:(LPMSegment *)segment;
		[Static]
		[Export ("setSegment:")]
		void SetSegment (LPMSegment segment);

		// +(void)launchTestSuite:(UIViewController *)viewController;
		[Static]
		[Export ("launchTestSuite:")]
		void LaunchTestSuite (UIViewController viewController);

		// +(void)validateIntegration;
		[Static]
		[Export ("validateIntegration")]
		void ValidateIntegration ();

	}

	// @protocol ISNAppStoreVCRootViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISNAppStoreVCRootViewDelegate
	{
		// @required -(void)didReceiveOutOfAppStoreTouchWithType:(NSString * _Nonnull)type;
		[Abstract]
		[Export ("didReceiveOutOfAppStoreTouchWithType:")]
		void DidReceiveOutOfAppStoreTouchWithType (string type);
	}

	// @protocol ISAppStoreErrorDelegate <NSObject, ISNAppStoreVCRootViewDelegate>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISAppStoreErrorDelegate : ISNAppStoreVCRootViewDelegate
	{
	}

	// @protocol ISNetworkInitCallbackProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISNetworkInitCallbackProtocol
	{
		// @optional -(void)onNetworkInitCallbackSuccess;
		[Export ("onNetworkInitCallbackSuccess")]
		void OnNetworkInitCallbackSuccess ();

		// @optional -(void)onNetworkInitCallbackFailed:(NSString * _Nonnull)errorMessage;
		[Export ("onNetworkInitCallbackFailed:")]
		void OnNetworkInitCallbackFailed (string errorMessage);
	}

	// @interface ISBaseAdUnitAdapter : NSObject <ISNetworkInitCallbackProtocol>
	[BaseType (typeof(NSObject))]
	interface ISBaseAdUnitAdapter : ISNetworkInitCallbackProtocol
	{
		// -(NSString *)getStringValueFromAdapterConfig:(ISAdapterConfig *)adapterConfig forKey:(NSString *)key;
		[Export ("getStringValueFromAdapterConfig:forKey:")]
		string GetStringValueFromAdapterConfig (ISAdapterConfig adapterConfig, string key);

		// -(NSString *)getMissingParamErrorStringWithKey:(NSString *)key;
		[Export ("getMissingParamErrorStringWithKey:")]
		string GetMissingParamErrorStringWithKey (string key);
	}

	// @protocol ISAdUnitAdapterProtocol <ISNetworkInitCallbackProtocol>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface ISAdUnitAdapterProtocol : ISNetworkInitCallbackProtocol
	{
	}

	// @protocol ISBiddingDataDelegate <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISBiddingDataDelegate
	{
		// @required -(void)successWithBiddingData:(NSDictionary *)biddingData;
		[Abstract]
		[Export ("successWithBiddingData:")]
		void SuccessWithBiddingData (NSDictionary biddingData);

		// @required -(void)failureWithError:(NSString *)error;
		[Abstract]
		[Export ("failureWithError:")]
		void FailureWithError (string error);
	}

	// @protocol ISBiddingDataProtocol <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISBiddingDataProtocol
	{
		// -(void)collectBiddingDataWithAdData:(ISAdData *)adData delegate:(id<ISBiddingDataDelegate>)delegate;
		[Abstract]
		[Export ("collectBiddingDataWithAdData:delegate:")]
		void CollectBiddingDataWithAdData (ISAdData adData, ISBiddingDataDelegate @delegate);
	}

	// @interface ISAdapterNativeAdData : NSObject <ISNativeAdDataProtocol>
	[BaseType (typeof(NSObject))]
	interface ISAdapterNativeAdData : ISNativeAdDataProtocol
	{
	}

	// @protocol ISNativeAdAdapterDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISNativeAdAdapterDelegate
	{
		// @required -(void)adapterNativeAdInitSuccess;
		[Abstract]
		[Export ("adapterNativeAdInitSuccess")]
		void AdapterNativeAdInitSuccess ();

		// @required -(void)adapterNativeAdInitFailedWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterNativeAdInitFailedWithError:")]
		void AdapterNativeAdInitFailedWithError (NSError error);

		// @required -(void)adapterNativeAdDidLoadWithAdData:(ISAdapterNativeAdData *)adapterNativeAdData adViewBinder:(ISAdapterNativeAdViewBinder *)nativeAdViewBinder;
		[Abstract]
		[Export ("adapterNativeAdDidLoadWithAdData:adViewBinder:")]
		void AdapterNativeAdDidLoadWithAdData (ISAdapterNativeAdData adapterNativeAdData, ISAdapterNativeAdViewBinder nativeAdViewBinder);

		// @required -(void)adapterNativeAdDidFailToLoadWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterNativeAdDidFailToLoadWithError:")]
		void AdapterNativeAdDidFailToLoadWithError (NSError error);

		// @required -(void)adapterNativeAdDidShow;
		[Abstract]
		[Export ("adapterNativeAdDidShow")]
		void AdapterNativeAdDidShow ();

		// @required -(void)adapterNativeAdDidClick;
		[Abstract]
		[Export ("adapterNativeAdDidClick")]
		void AdapterNativeAdDidClick ();
	}

	// @protocol ISNativeAdAdapterProtocol <ISAdUnitAdapterProtocol>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
    [BaseType(typeof(NSObject))]
    interface ISNativeAdAdapterProtocol : ISAdUnitAdapterProtocol
	{
		// @optional -(void)initNativeAdsWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISNativeAdAdapterDelegate>)delegate;
		[Export ("initNativeAdsWithUserId:adapterConfig:delegate:")]
		void InitNativeAdsWithUserId (string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate);

		// @optional -(void)initNativeAdForBiddingWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISNativeAdAdapterDelegate>)delegate;
		[Export ("initNativeAdForBiddingWithUserId:adapterConfig:delegate:")]
		void InitNativeAdForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISNativeAdAdapterDelegate @delegate);

		// @optional -(void)loadNativeAdWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData viewController:(UIViewController *)viewController delegate:(id<ISNativeAdAdapterDelegate>)delegate;
		[Export ("loadNativeAdWithAdapterConfig:adData:viewController:delegate:")]
		void LoadNativeAdWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, UIViewController viewController, ISNativeAdAdapterDelegate @delegate);

		// @optional -(void)loadNativeAdForBiddingWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData serverData:(NSString *)serverData viewController:(UIViewController *)viewController delegate:(id<ISNativeAdAdapterDelegate>)delegate;
		[Export ("loadNativeAdForBiddingWithAdapterConfig:adData:serverData:viewController:delegate:")]
		void LoadNativeAdForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, UIViewController viewController, ISNativeAdAdapterDelegate @delegate);

		// @optional -(void)destroyNativeAdWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("destroyNativeAdWithAdapterConfig:")]
		void DestroyNativeAdWithAdapterConfig (ISAdapterConfig adapterConfig);

		// @optional -(NSDictionary *)getNativeAdBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData;
		[Export ("getNativeAdBiddingDataWithAdapterConfig:adData:")]
		NSDictionary GetNativeAdBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData);

		// @optional -(void)collectNativeAdBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData delegate:(id<ISBiddingDataDelegate>)delegate;
		[Export ("collectNativeAdBiddingDataWithAdapterConfig:adData:delegate:")]
		void CollectNativeAdBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate);
	}

	// @protocol ISNativeAdDelegate <ISAdapterAdDelegate>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISNativeAdDelegate : ISAdapterAdDelegate
	{
		// -(void)adDidLoadWithAdData:(ISAdapterNativeAdData *)adapterNativeAdData adViewBinder:(ISAdapterNativeAdViewBinder *)nativeAdViewBinder;
		[Abstract]
		[Export ("adDidLoadWithAdData:adViewBinder:")]
		void AdDidLoadWithAdData (ISAdapterNativeAdData adapterNativeAdData, ISAdapterNativeAdViewBinder nativeAdViewBinder);
	}

	// @protocol ISAdapterNativeAdProtocol <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISAdapterNativeAdProtocol
	{
		// -(void)loadAdWithAdData:(ISAdData *)adData viewController:(UIViewController *)viewController delegate:(id<ISNativeAdDelegate>)delegate;
		[Abstract]
		[Export ("loadAdWithAdData:viewController:delegate:")]
		void LoadAdWithAdData (ISAdData adData, UIViewController viewController, ISNativeAdDelegate @delegate);

		// -(void)destroyAdWithAdData:(ISAdData *)adData;
		[Abstract]
		[Export ("destroyAdWithAdData:")]
		void DestroyAdWithAdData (ISAdData adData);
	}

	// @interface ISNativeAdProperties : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ISNativeAdProperties
	{
		// @property (readonly, assign, nonatomic) ISAdOptionsPosition adOptionsPosition;
		[Export ("adOptionsPosition", ArgumentSemantic.Assign)]
		ISAdOptionsPosition AdOptionsPosition { get; }

		// -(instancetype)initWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("initWithAdapterConfig:")]
		NativeHandle Constructor (ISAdapterConfig adapterConfig);
	}

	// @interface ISBaseNativeAdAdapter : ISBaseAdUnitAdapter <ISNativeAdAdapterProtocol>
	[BaseType (typeof(ISBaseAdUnitAdapter))]
	interface ISBaseNativeAdAdapter : ISNativeAdAdapterProtocol
	{
		// -(ISNativeAdProperties * _Nonnull)getNativeAdPropertiesWithAdapterConfig:(ISAdapterConfig * _Nonnull)adapterConfig;
		[Export ("getNativeAdPropertiesWithAdapterConfig:")]
		ISNativeAdProperties GetNativeAdPropertiesWithAdapterConfig (ISAdapterConfig adapterConfig);
	}

	// @interface ISBaseNativeAd : ISBaseAdAdapter <ISAdapterNativeAdProtocol>
	[BaseType (typeof(ISBaseAdAdapter))]
	interface ISBaseNativeAd : ISAdapterNativeAdProtocol
	{
		// -(instancetype)init:(ISAdapterConfig *)providerConfig;
		[Export ("init:")]
		NativeHandle Constructor (ISAdapterConfig providerConfig);

		// -(void)loadAdWithAdData:(ISAdData *)adData viewController:(UIViewController *)viewController delegate:(id<ISNativeAdDelegate>)delegate;
		[Export ("loadAdWithAdData:viewController:delegate:")]
		new void LoadAdWithAdData (ISAdData adData, UIViewController viewController, ISNativeAdDelegate @delegate);

		// -(void)destroyAdWithAdData:(ISAdData *)adData;
		[Export ("destroyAdWithAdData:")]
		new void DestroyAdWithAdData (ISAdData adData);

		// -(ISNativeAdProperties *)getNativeAdPropertiesWithAdData:(ISAdData *)adData;
		[Export ("getNativeAdPropertiesWithAdData:")]
		ISNativeAdProperties GetNativeAdPropertiesWithAdData (ISAdData adData);
	}

	// @protocol ISBannerAdapterDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISBannerAdapterDelegate
	{
		// @required -(void)adapterBannerInitSuccess;
		[Abstract]
		[Export ("adapterBannerInitSuccess")]
		void AdapterBannerInitSuccess ();

		// @required -(void)adapterBannerInitFailedWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterBannerInitFailedWithError:")]
		void AdapterBannerInitFailedWithError (NSError error);

		// @required -(void)adapterBannerDidLoad:(UIView *)bannerView;
		[Abstract]
		[Export ("adapterBannerDidLoad:")]
		void AdapterBannerDidLoad (UIView bannerView);

		// @required -(void)adapterBannerDidFailToLoadWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterBannerDidFailToLoadWithError:")]
		void AdapterBannerDidFailToLoadWithError (NSError error);

		// @required -(void)adapterBannerDidClick;
		[Abstract]
		[Export ("adapterBannerDidClick")]
		void AdapterBannerDidClick ();

		// @required -(void)adapterBannerWillPresentScreen;
		[Abstract]
		[Export ("adapterBannerWillPresentScreen")]
		void AdapterBannerWillPresentScreen ();

		// @required -(void)adapterBannerDidDismissScreen;
		[Abstract]
		[Export ("adapterBannerDidDismissScreen")]
		void AdapterBannerDidDismissScreen ();

		// @required -(void)adapterBannerWillLeaveApplication;
		[Abstract]
		[Export ("adapterBannerWillLeaveApplication")]
		void AdapterBannerWillLeaveApplication ();

		// @required -(void)adapterBannerDidShow;
		[Abstract]
		[Export ("adapterBannerDidShow")]
		void AdapterBannerDidShow ();

		// @required -(void)adapterBannerDidFailToShowWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterBannerDidFailToShowWithError:")]
		void AdapterBannerDidFailToShowWithError (NSError error);
	}

	// @protocol ISBannerAdapterProtocol <ISAdUnitAdapterProtocol>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
    [BaseType(typeof(NSObject))]
    interface ISBannerAdapterProtocol : ISAdUnitAdapterProtocol
	{
		// @optional -(void)destroyBannerWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("destroyBannerWithAdapterConfig:")]
		void DestroyBannerWithAdapterConfig (ISAdapterConfig adapterConfig);

		// @optional -(CGFloat)getAdaptiveHeightWithWidth:(CGFloat)width;
		[Export ("getAdaptiveHeightWithWidth:")]
		nfloat GetAdaptiveHeightWithWidth (nfloat width);

		// @optional -(void)initBannerWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISBannerAdapterDelegate>)delegate;
		[Export ("initBannerWithUserId:adapterConfig:delegate:")]
		void InitBannerWithUserId (string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate);

		// @optional -(void)loadBannerWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData viewController:(UIViewController *)viewController size:(ISBannerSize *)size delegate:(id<ISBannerAdapterDelegate>)delegate;
		[Export ("loadBannerWithAdapterConfig:adData:viewController:size:delegate:")]
		void LoadBannerWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate);

		// @optional -(NSDictionary *)getBannerBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData;
		[Export ("getBannerBiddingDataWithAdapterConfig:adData:")]
		NSDictionary GetBannerBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData);

		// @optional -(void)collectBannerBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData delegate:(id<ISBiddingDataDelegate>)delegate;
		[Export ("collectBannerBiddingDataWithAdapterConfig:adData:delegate:")]
		void CollectBannerBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate);

		// @optional -(void)initBannerForBiddingWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISBannerAdapterDelegate>)delegate;
		[Export ("initBannerForBiddingWithUserId:adapterConfig:delegate:")]
		void InitBannerForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISBannerAdapterDelegate @delegate);

		// @optional -(void)loadBannerForBiddingWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData serverData:(NSString *)serverData viewController:(UIViewController *)viewController size:(ISBannerSize *)size delegate:(id<ISBannerAdapterDelegate>)delegate;
		[Export ("loadBannerForBiddingWithAdapterConfig:adData:serverData:viewController:size:delegate:")]
		void LoadBannerForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, UIViewController viewController, ISBannerSize size, ISBannerAdapterDelegate @delegate);
	}

	// @protocol LPMThreadSafeDictionaryProtocol <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface LPMThreadSafeDictionaryProtocol
	{
		// -(NSUInteger)count;
		[Abstract]
		[Export ("count")]
		nuint Count { get; }

		// -(id)objectForKey:(NSString *)key;
		[Abstract]
		[Export ("objectForKey:")]
		NSObject ObjectForKey (string key);

		// -(void)setObject:(id)object forKey:(NSString *)key;
		[Abstract]
		[Export ("setObject:forKey:")]
		void SetObject (NSObject @object, string key);

		// -(BOOL)hasObjectForKey:(NSString *)key;
		[Abstract]
		[Export ("hasObjectForKey:")]
		bool HasObjectForKey (string key);

		// -(void)removeObjectForKey:(NSString *)key;
		[Abstract]
		[Export ("removeObjectForKey:")]
		void RemoveObjectForKey (string key);

		// -(void)removeAllObjects;
		[Abstract]
		[Export ("removeAllObjects")]
		void RemoveAllObjects ();

		// -(NSArray<NSString *> *)allKeys;
		[Abstract]
		[Export ("allKeys")]
		string[] AllKeys { get; }

		// -(NSArray *)allValues;
		[Abstract]
		[Export ("allValues")]
		NSObject[] AllValues { get; }

		// -(NSDictionary<NSString *, id> *)allData;
		[Abstract]
		[Export ("allData")]
		NSDictionary AllData { get; }
	}

	// @interface ISConcurrentMutableDictionary : NSObject <LPMThreadSafeDictionaryProtocol>
	[BaseType (typeof(NSObject))]
	interface ISConcurrentMutableDictionary : LPMThreadSafeDictionaryProtocol
	{
		// +(id<LPMThreadSafeDictionaryProtocol>)lpmDictionary;
		[Static]
		[Export ("lpmDictionary")]
		LPMThreadSafeDictionaryProtocol LpmDictionary { get; }

		// -(NSUInteger)count;
		[Export ("count")]
		new nuint Count { get; }

		// -(id)objectForKey:(id)key;
		[Export ("objectForKey:")]
		NSObject ObjectForKey (NSObject key);

		// -(void)setObject:(id)object forKey:(id<NSCopying>)key;
		[Export ("setObject:forKey:")]
		void SetObject (NSObject @object, INSCopying key);

		// -(void)removeObjectForKey:(id)key;
		[Export ("removeObjectForKey:")]
		void RemoveObjectForKey (NSObject key);

		// -(void)removeAllObjects;
		[Export ("removeAllObjects")]
		new void RemoveAllObjects ();

		// -(NSArray *)allKeys;
		[Export ("allKeys")]
		new NSObject[] AllKeys { get; }

		// -(NSArray *)allValues;
		[Export ("allValues")]
		new NSObject[] AllValues { get; }

		// -(NSDictionary *)allData;
		[Export ("allData")]
		new NSDictionary AllData { get; }

		// -(BOOL)hasObjectForKey:(id)key;
		[Export ("hasObjectForKey:")]
		bool HasObjectForKey (NSObject key);
	}

	// @interface ISConcurrentMutableArray<__covariant ObjectType> : NSObject
	[BaseType (typeof(NSObject))]
	interface ISConcurrentMutableArray
	{
		// -(NSUInteger)count;
		[Export ("count")]
		nuint Count { get; }

		// -(void)addObject:(ObjectType)object;
		[Export ("addObject:")]
		void AddObject (NSObject obj);

		// -(ObjectType)objectAtIndex:(NSUInteger)index;
		[Export ("objectAtIndex:")]
		NSObject ObjectAtIndex (nuint index);

		// -(void)removeObjectAtIndex:(NSUInteger)index;
		[Export ("removeObjectAtIndex:")]
		void RemoveObjectAtIndex (nuint index);

		// -(void)addObjectsFromArray:(NSArray *)array;
		[Export ("addObjectsFromArray:")]
		void AddObjectsFromArray (NSArray array);

		// -(void)removeAllObjects;
		[Export ("removeAllObjects")]
		void RemoveAllObjects ();

		// -(BOOL)containsObject:(ObjectType)object;
		[Export ("containsObject:")]
		bool ContainsObject (NSObject obj);

		// -(NSArray *)copy;
		[Export ("copy")]
		NSArray CopyArray ();
	}

	// @protocol ISInterstitialAdapterDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISInterstitialAdapterDelegate
	{
		// @required -(void)adapterInterstitialInitSuccess;
		[Abstract]
		[Export ("adapterInterstitialInitSuccess")]
		void AdapterInterstitialInitSuccess ();

		// @required -(void)adapterInterstitialInitFailedWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterInterstitialInitFailedWithError:")]
		void AdapterInterstitialInitFailedWithError (NSError error);

		// @required -(void)adapterInterstitialDidLoad;
		[Abstract]
		[Export ("adapterInterstitialDidLoad")]
		void AdapterInterstitialDidLoad ();

		// @required -(void)adapterInterstitialDidFailToLoadWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterInterstitialDidFailToLoadWithError:")]
		void AdapterInterstitialDidFailToLoadWithError (NSError error);

		// @required -(void)adapterInterstitialDidOpen;
		[Abstract]
		[Export ("adapterInterstitialDidOpen")]
		void AdapterInterstitialDidOpen ();

		// @required -(void)adapterInterstitialDidClose;
		[Abstract]
		[Export ("adapterInterstitialDidClose")]
		void AdapterInterstitialDidClose ();

		// @required -(void)adapterInterstitialDidShow;
		[Abstract]
		[Export ("adapterInterstitialDidShow")]
		void AdapterInterstitialDidShow ();

		// @required -(void)adapterInterstitialDidFailToShowWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterInterstitialDidFailToShowWithError:")]
		void AdapterInterstitialDidFailToShowWithError (NSError error);

		// @required -(void)adapterInterstitialDidClick;
		[Abstract]
		[Export ("adapterInterstitialDidClick")]
		void AdapterInterstitialDidClick ();

		// @required -(void)adapterInterstitialDidBecomeVisible;
		[Abstract]
		[Export ("adapterInterstitialDidBecomeVisible")]
		void AdapterInterstitialDidBecomeVisible ();
	}

	// @protocol ISInterstitialAdapterProtocol <ISAdUnitAdapterProtocol>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
    [BaseType(typeof(NSObject))]
    interface ISInterstitialAdapterProtocol : ISAdUnitAdapterProtocol
	{
		// @optional -(void)showInterstitialWithViewController:(UIViewController *)viewController adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISInterstitialAdapterDelegate>)delegate;
		[Export ("showInterstitialWithViewController:adapterConfig:delegate:")]
		void ShowInterstitialWithViewController (UIViewController viewController, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate);

		// @optional -(BOOL)hasInterstitialWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("hasInterstitialWithAdapterConfig:")]
		bool HasInterstitialWithAdapterConfig (ISAdapterConfig adapterConfig);

		// @optional -(void)disposeInterstitialAdWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("disposeInterstitialAdWithAdapterConfig:")]
		void DisposeInterstitialAdWithAdapterConfig (ISAdapterConfig adapterConfig);

		// @optional -(void)initInterstitialWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISInterstitialAdapterDelegate>)delegate;
		[Export ("initInterstitialWithUserId:adapterConfig:delegate:")]
		void InitInterstitialWithUserId (string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate);

		// @optional -(void)loadInterstitialWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData delegate:(id<ISInterstitialAdapterDelegate>)delegate;
		[Export ("loadInterstitialWithAdapterConfig:adData:delegate:")]
		void LoadInterstitialWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISInterstitialAdapterDelegate @delegate);

		// @optional -(NSDictionary *)getInterstitialBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData;
		[Export ("getInterstitialBiddingDataWithAdapterConfig:adData:")]
		NSDictionary GetInterstitialBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData);

		// @optional -(void)collectInterstitialBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData delegate:(id<ISBiddingDataDelegate>)delegate;
		[Export ("collectInterstitialBiddingDataWithAdapterConfig:adData:delegate:")]
		void CollectInterstitialBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate);

		// @optional -(void)initInterstitialForBiddingWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISInterstitialAdapterDelegate>)delegate;
		[Export ("initInterstitialForBiddingWithUserId:adapterConfig:delegate:")]
		void InitInterstitialForBiddingWithUserId (string userId, ISAdapterConfig adapterConfig, ISInterstitialAdapterDelegate @delegate);

		// @optional -(void)loadInterstitialForBiddingWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData serverData:(NSString *)serverData delegate:(id<ISInterstitialAdapterDelegate>)delegate;
		[Export ("loadInterstitialForBiddingWithAdapterConfig:adData:serverData:delegate:")]
		void LoadInterstitialForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, ISInterstitialAdapterDelegate @delegate);
	}

	// @protocol ISRewardedVideoAdapterDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISRewardedVideoAdapterDelegate
	{
		// @required -(void)adapterRewardedVideoHasChangedAvailability:(BOOL)available;
		[Abstract]
		[Export ("adapterRewardedVideoHasChangedAvailability:")]
		void AdapterRewardedVideoHasChangedAvailability (bool available);

		// @required -(void)adapterRewardedVideoDidFailToLoadWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterRewardedVideoDidFailToLoadWithError:")]
		void AdapterRewardedVideoDidFailToLoadWithError (NSError error);

		// @required -(void)adapterRewardedVideoDidReceiveReward;
		[Abstract]
		[Export ("adapterRewardedVideoDidReceiveReward")]
		void AdapterRewardedVideoDidReceiveReward ();

		// @required -(void)adapterRewardedVideoDidFailToShowWithError:(NSError *)error;
		[Abstract]
		[Export ("adapterRewardedVideoDidFailToShowWithError:")]
		void AdapterRewardedVideoDidFailToShowWithError (NSError error);

		// @required -(void)adapterRewardedVideoDidOpen;
		[Abstract]
		[Export ("adapterRewardedVideoDidOpen")]
		void AdapterRewardedVideoDidOpen ();

		// @required -(void)adapterRewardedVideoDidClose;
		[Abstract]
		[Export ("adapterRewardedVideoDidClose")]
		void AdapterRewardedVideoDidClose ();

		// @required -(void)adapterRewardedVideoDidLoad;
		[Abstract]
		[Export ("adapterRewardedVideoDidLoad")]
		void AdapterRewardedVideoDidLoad ();

		// @required -(void)adapterRewardedVideoDidClick;
		[Abstract]
		[Export ("adapterRewardedVideoDidClick")]
		void AdapterRewardedVideoDidClick ();

		// @required -(void)adapterRewardedVideoDidStart;
		[Abstract]
		[Export ("adapterRewardedVideoDidStart")]
		void AdapterRewardedVideoDidStart ();

		// @required -(void)adapterRewardedVideoDidEnd;
		[Abstract]
		[Export ("adapterRewardedVideoDidEnd")]
		void AdapterRewardedVideoDidEnd ();

		// @required -(void)adapterRewardedVideoInitSuccess;
		[Abstract]
		[Export ("adapterRewardedVideoInitSuccess")]
		void AdapterRewardedVideoInitSuccess ();

		// @required -(void)adapterRewardedVideoInitFailed:(NSError *)error;
		[Abstract]
		[Export ("adapterRewardedVideoInitFailed:")]
		void AdapterRewardedVideoInitFailed (NSError error);

		// @required -(void)adapterRewardedVideoDidBecomeVisible;
		[Abstract]
		[Export ("adapterRewardedVideoDidBecomeVisible")]
		void AdapterRewardedVideoDidBecomeVisible ();
	}

	// @protocol ISRewardedVideoAdapterProtocol <ISAdUnitAdapterProtocol>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
    [BaseType(typeof(NSObject))]
    interface ISRewardedVideoAdapterProtocol : ISAdUnitAdapterProtocol
	{
		// @optional -(BOOL)hasRewardedVideoWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("hasRewardedVideoWithAdapterConfig:")]
		bool HasRewardedVideoWithAdapterConfig (ISAdapterConfig adapterConfig);

		// @optional -(void)showRewardedVideoWithViewController:(UIViewController *)viewController adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("showRewardedVideoWithViewController:adapterConfig:delegate:")]
		void ShowRewardedVideoWithViewController (UIViewController viewController, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate);

		// @optional -(void)disposeRewardedVideoAdWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("disposeRewardedVideoAdWithAdapterConfig:")]
		void DisposeRewardedVideoAdWithAdapterConfig (ISAdapterConfig adapterConfig);

		// @optional -(void)initAndLoadRewardedVideoWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("initAndLoadRewardedVideoWithUserId:adapterConfig:adData:delegate:")]
		void InitAndLoadRewardedVideoWithUserId (string userId, ISAdapterConfig adapterConfig, NSDictionary adData, ISRewardedVideoAdapterDelegate @delegate);

		// @optional -(void)initRewardedVideoForCallbacksWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("initRewardedVideoForCallbacksWithUserId:adapterConfig:delegate:")]
		void InitRewardedVideoForCallbacksWithUserId (string userId, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate);

		// @optional -(void)loadRewardedVideoWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("loadRewardedVideoWithAdapterConfig:adData:delegate:")]
		void LoadRewardedVideoWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISRewardedVideoAdapterDelegate @delegate);

		// @optional -(NSDictionary *)getRewardedVideoBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData;
		[Export ("getRewardedVideoBiddingDataWithAdapterConfig:adData:")]
		NSDictionary GetRewardedVideoBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData);

		// @optional -(void)collectRewardedVideoBiddingDataWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData delegate:(id<ISBiddingDataDelegate>)delegate;
		[Export ("collectRewardedVideoBiddingDataWithAdapterConfig:adData:delegate:")]
		void CollectRewardedVideoBiddingDataWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, ISBiddingDataDelegate @delegate);

		// @optional -(void)loadRewardedVideoForBiddingWithAdapterConfig:(ISAdapterConfig *)adapterConfig adData:(NSDictionary *)adData serverData:(NSString *)serverData delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("loadRewardedVideoForBiddingWithAdapterConfig:adData:serverData:delegate:")]
		void LoadRewardedVideoForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, NSDictionary adData, string serverData, ISRewardedVideoAdapterDelegate @delegate);

		// @optional -(void)initRewardedVideoForDemandOnlyWithUserId:(NSString *)userId adapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("initRewardedVideoForDemandOnlyWithUserId:adapterConfig:delegate:")]
		void InitRewardedVideoForDemandOnlyWithUserId (string userId, ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate);

		// @optional -(void)loadRewardedVideoForDemandOnlyWithAdapterConfig:(ISAdapterConfig *)adapterConfig delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("loadRewardedVideoForDemandOnlyWithAdapterConfig:delegate:")]
		void LoadRewardedVideoForDemandOnlyWithAdapterConfig (ISAdapterConfig adapterConfig, ISRewardedVideoAdapterDelegate @delegate);

		// @optional -(void)loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:(ISAdapterConfig *)adapterConfig serverData:(NSString *)serverData delegate:(id<ISRewardedVideoAdapterDelegate>)delegate;
		[Export ("loadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig:serverData:delegate:")]
		void LoadRewardedVideoForDemandOnlyForBiddingWithAdapterConfig (ISAdapterConfig adapterConfig, string serverData, ISRewardedVideoAdapterDelegate @delegate);
	}

	// @interface ISBaseAdapter : NSObject <ISInterstitialAdapterProtocol, ISRewardedVideoAdapterProtocol, ISBannerAdapterProtocol, ISAdapterNetworkDataProtocol, ISNativeAdAdapterProtocol>
	[BaseType (typeof(NSObject))]
	interface ISBaseAdapter : ISInterstitialAdapterProtocol, ISRewardedVideoAdapterProtocol, ISBannerAdapterProtocol, ISAdapterNetworkDataProtocol, ISNativeAdAdapterProtocol
	{
		// @property (nonatomic, strong) NSString * adapterName;
		[Export ("adapterName", ArgumentSemantic.Strong)]
		string AdapterName { get; set; }

		// @property (nonatomic, strong) NSString * providerNetworkKey;
		[Export ("providerNetworkKey", ArgumentSemantic.Strong)]
		string ProviderNetworkKey { get; set; }

		// @property (nonatomic, strong) NSString * pluginType;
		[Export ("pluginType", ArgumentSemantic.Strong)]
		string PluginType { get; set; }

		// @property (nonatomic, strong) NSString * userId;
		[Export ("userId", ArgumentSemantic.Strong)]
		string UserId { get; set; }

		// @property (nonatomic, strong) ISConcurrentMutableDictionary * adUnitAdapters;
		[Export ("adUnitAdapters", ArgumentSemantic.Strong)]
		ISConcurrentMutableDictionary AdUnitAdapters { get; set; }

		// -(instancetype)initAdapter:(NSString *)name;
		[Export ("initAdapter:")]
		NativeHandle Constructor (string name);

		// -(void)earlyInitWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("earlyInitWithAdapterConfig:")]
		void EarlyInitWithAdapterConfig (ISAdapterConfig adapterConfig);

		// -(NSString *)sdkVersion;
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// -(NSString *)version;
		[Export ("version")]
		string Version { get; }

		// -(NSString *)dynamicUserId;
		[Export ("dynamicUserId")]
		string DynamicUserId { get; }

		// -(ISLoadWhileShowSupportState)getLWSSupportState:(ISAdapterConfig *)adapterConfig;
		[Export ("getLWSSupportState:")]
		ISLoadWhileShowSupportState GetLWSSupportState (ISAdapterConfig adapterConfig);

		// -(void)setNetworkData:(id<ISAdapterNetworkData>)networkData;
		[Export ("setNetworkData:")]
		new void SetNetworkData (ISAdapterNetworkData networkData);

		// -(void)setRewardedVideoAdapter:(id<ISRewardedVideoAdapterProtocol>)rewardedVideoAdapter;
		[Export ("setRewardedVideoAdapter:")]
		void SetRewardedVideoAdapter (ISRewardedVideoAdapterProtocol rewardedVideoAdapter);

		// -(void)setInterstitialAdapter:(id<ISInterstitialAdapterProtocol>)interstitialAdapter;
		[Export ("setInterstitialAdapter:")]
		void SetInterstitialAdapter (ISInterstitialAdapterProtocol interstitialAdapter);

		// -(void)setBannerAdapter:(id<ISBannerAdapterProtocol>)bannerAdapter;
		[Export ("setBannerAdapter:")]
		void SetBannerAdapter (ISBannerAdapterProtocol bannerAdapter);

		// -(void)setNativeAdAdapter:(id<ISNativeAdAdapterProtocol>)nativeAdAdapter;
		[Export ("setNativeAdAdapter:")]
		void SetNativeAdAdapter (ISNativeAdAdapterProtocol nativeAdAdapter);

		// -(void)setConsent:(BOOL)consent;
		[Export ("setConsent:")]
		void SetConsent (bool consent);

		// -(id<ISRewardedVideoAdapterProtocol>)getRewardedVideoAdapter;
		[Export ("getRewardedVideoAdapter")]
		ISRewardedVideoAdapterProtocol RewardedVideoAdapter { get; }

		// -(id<ISInterstitialAdapterProtocol>)getInterstitialAdapter;
		[Export ("getInterstitialAdapter")]
		ISInterstitialAdapterProtocol InterstitialAdapter { get; }

		// -(id<ISBannerAdapterProtocol>)getBannerAdapter;
		[Export ("getBannerAdapter")]
		ISBannerAdapterProtocol BannerAdapter { get; }

		// -(id<ISNativeAdAdapterProtocol>)getNativeAdAdapter;
		[Export ("getNativeAdAdapter")]
		ISNativeAdAdapterProtocol NativeAdAdapter { get; }

		// -(CGFloat)getAdaptiveHeightWithWidth:(CGFloat)width;
		[Export ("getAdaptiveHeightWithWidth:")]
		new nfloat GetAdaptiveHeightWithWidth (nfloat width);

		// -(void)disposeRewardedVideoAdWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("disposeRewardedVideoAdWithAdapterConfig:")]
		new void DisposeRewardedVideoAdWithAdapterConfig (ISAdapterConfig adapterConfig);

		// -(void)disposeInterstitialAdWithAdapterConfig:(ISAdapterConfig *)adapterConfig;
		[Export ("disposeInterstitialAdWithAdapterConfig:")]
		new void DisposeInterstitialAdWithAdapterConfig (ISAdapterConfig adapterConfig);
	}

	// @interface ISMetaData : NSObject
	[BaseType (typeof(NSObject))]
	interface ISMetaData
	{
		// -(instancetype)initWithKey:(NSString *)key andValues:(NSMutableArray *)values;
		[Export ("initWithKey:andValues:")]
		NativeHandle Constructor (string key, NSMutableArray values);

		// -(instancetype)initWithKey:(NSString *)key values:(NSMutableArray *)values andValuesType:(NSMutableArray *)valuesType;
		[Export ("initWithKey:values:andValuesType:")]
		NativeHandle Constructor (string key, NSMutableArray values, NSMutableArray valuesType);

		// @property NSString * key;
		[Export ("key")]
		string Key { get; set; }

		// @property NSMutableArray * values;
		[Export ("values", ArgumentSemantic.Assign)]
		NSMutableArray Values { get; set; }

		// @property NSMutableArray * valuesType;
		[Export ("valuesType", ArgumentSemantic.Assign)]
		NSMutableArray ValuesType { get; set; }
	}

	// @interface ISMetaDataUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface ISMetaDataUtils
	{
		// +(ISMetaDataValueTypes)getValueTypeForKey:(NSString *)key;
		[Static]
		[Export ("getValueTypeForKey:")]
		ISMetaDataValueTypes GetValueTypeForKey (string key);

		// +(BOOL)isKnownKey:(NSString *)key;
		[Static]
		[Export ("isKnownKey:")]
		bool IsKnownKey (string key);

		// +(BOOL)isMediationOnlyKey:(NSString *)key;
		[Static]
		[Export ("isMediationOnlyKey:")]
		bool IsMediationOnlyKey (string key);

		// +(NSString *)formatValue:(NSString *)value forType:(ISMetaDataValueTypes)valueType;
		[Static]
		[Export ("formatValue:forType:")]
		string FormatValue (string value, ISMetaDataValueTypes valueType);

		// +(ISMetaData *)formatMetaDataKey:(NSString *)key andValues:(NSMutableArray *)values;
		[Static]
		[Export ("formatMetaDataKey:andValues:")]
		ISMetaData FormatMetaDataKey (string key, NSMutableArray values);

		// +(BOOL)isMetaDataKeyValid:(NSString *)key error:(NSString **)error;
		[Static]
		[Export ("isMetaDataKeyValid:error:")]
		bool IsMetaDataKeyValid (string key, out string error);

		// +(BOOL)isMetaDataValuesValid:(NSMutableArray *)values error:(NSString **)error;
		[Static]
		[Export ("isMetaDataValuesValid:error:")]
		bool IsMetaDataValuesValid (NSMutableArray values, out string error);

		// +(BOOL)isValidCCPAMetaDataWithKey:(NSString *)key andValue:(NSString *)value;
		[Static]
		[Export ("isValidCCPAMetaDataWithKey:andValue:")]
		bool IsValidCCPAMetaDataWithKey (string key, string value);

		// +(BOOL)isValidMetaDataWithKey:(NSString *)key flag:(NSString *)flag andValue:(NSString *)value;
		[Static]
		[Export ("isValidMetaDataWithKey:flag:andValue:")]
		bool IsValidMetaDataWithKey (string key, string flag, string value);

		// +(BOOL)getMetaDataBooleanValue:(NSString *)value;
		[Static]
		[Export ("getMetaDataBooleanValue:")]
		bool GetMetaDataBooleanValue (string value);
	}

	// @interface ISConcurrentMutableSet : NSObject
	[BaseType (typeof(NSObject))]
	interface ISConcurrentMutableSet
	{
		// +(instancetype)set;
		[Static]
		[Export ("set")]
		ISConcurrentMutableSet Set ();

		// +(instancetype)setWithSet:(id)set;
		[Static]
		[Export ("setWithSet:")]
		ISConcurrentMutableSet SetWithSet (NSObject set);

		// -(instancetype)initWithCapacity:(NSUInteger)numItems;
		[Export ("initWithCapacity:")]
		NativeHandle Constructor (nuint numItems);

		// -(instancetype)initWithCoder:(NSCoder *)aDecoder;
		[Export ("initWithCoder:")]
		NativeHandle Constructor (NSCoder aDecoder);

		// -(instancetype)initWithSet:(NSMutableSet *)set;
		[Export ("initWithSet:")]
		NativeHandle Constructor (NSMutableSet set);

		// -(instancetype)initWithArray:(NSArray *)array;
		[Export ("initWithArray:")]
		NativeHandle Constructor (NSObject[] array);

		// -(NSUInteger)count;
		[Export ("count")]
		nuint Count { get; }

		// -(void)addObject:(id)object;
		[Export ("addObject:")]
		void AddObject (NSObject @object);

		// -(void)removeObject:(id)object;
		[Export ("removeObject:")]
		void RemoveObject (NSObject @object);

		// -(void)addObjectsFromArray:(NSArray *)array;
		[Export ("addObjectsFromArray:")]
		void AddObjectsFromArray (NSObject[] array);

		// -(void)intersectSet:(NSSet *)otherSet;
		[Export ("intersectSet:")]
		void IntersectSet (NSSet otherSet);

		// -(void)minusSet:(NSSet *)otherSet;
		[Export ("minusSet:")]
		void MinusSet (NSSet otherSet);

		// -(void)removeAllObjects;
		[Export ("removeAllObjects")]
		void RemoveAllObjects ();

		// -(void)unionSet:(NSSet *)otherSet;
		[Export ("unionSet:")]
		void UnionSet (NSSet otherSet);

		// -(NSArray *)allObjects;
		[Export ("allObjects")]
		NSObject[] AllObjects { get; }

		// -(BOOL)hasObject:(id)object;
		[Export ("hasObject:")]
		bool HasObject (NSObject @object);

		// -(NSEnumerator *)objectEnumerator;
		[Export ("objectEnumerator")]
		NSEnumerator ObjectEnumerator { get; }
	}

	// @interface ISLoggerManager : NSObject
	[BaseType (typeof(NSObject))]
	interface ISLoggerManager
	{
		// +(ISLoggerManager *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		ISLoggerManager SharedInstance { get; }

		// -(void)setLoggingLevels:(NSInteger)server publisher:(NSInteger)publisher console:(NSInteger)console;
		[Export ("setLoggingLevels:publisher:console:")]
		void SetLoggingLevels (nint server, nint publisher, nint console);

		// -(void)log:(NSString *)message level:(ISLogLevel)logLevel tag:(LogTag)logTag;
		[Export ("log:level:tag:")]
		void Log (string message, ISLogLevel logLevel, LogTag logTag);

		// -(void)logFromError:(NSError *)error level:(ISLogLevel)logLevel tag:(LogTag)logTag;
		[Export ("logFromError:level:tag:")]
		void LogFromError (NSError error, ISLogLevel logLevel, LogTag logTag);

		// -(void)logFromException:(NSException *)exception level:(ISLogLevel)logLevel tag:(LogTag)logTag;
		[Export ("logFromException:level:tag:")]
		void LogFromException (NSException exception, ISLogLevel logLevel, LogTag logTag);

		// -(void)logFromException:(NSException *)exception message:(NSString *)message level:(ISLogLevel)logLevel tag:(LogTag)logTag;
		[Export ("logFromException:message:level:tag:")]
		void LogFromException (NSException exception, string message, ISLogLevel logLevel, LogTag logTag);

		// -(void)dynamicLog:(char *)calledFrom message:(NSString *)message level:(ISLogLevel)logLevel withTag:(LogTag)logTag;
		[Export ("dynamicLog:message:level:withTag:")]
		unsafe void DynamicLog (sbyte* calledFrom, string message, ISLogLevel logLevel, LogTag logTag);

		// -(void)automationLog:(NSString *)message level:(ISLogLevel)logLevel withTag:(LogTag)logTag;
		[Export ("automationLog:level:withTag:")]
		void AutomationLog (string message, ISLogLevel logLevel, LogTag logTag);
	}

	// @interface ISLog : NSObject
	[BaseType (typeof(NSObject))]
	interface ISLog
	{
	}

	// @interface ISBaseBannerAdapter : ISBaseAdUnitAdapter <ISBannerAdapterProtocol>
	[BaseType (typeof(ISBaseAdUnitAdapter))]
	interface ISBaseBannerAdapter : ISBannerAdapterProtocol
	{
	}

	// @interface ISBaseInterstitialAdapter : ISBaseAdUnitAdapter <ISInterstitialAdapterProtocol>
	[BaseType (typeof(ISBaseAdUnitAdapter))]
	interface ISBaseInterstitialAdapter : ISInterstitialAdapterProtocol
	{
	}

	// @interface ISBaseRewardedVideoAdapter : ISBaseAdUnitAdapter <ISRewardedVideoAdapterProtocol>
	[BaseType (typeof(ISBaseAdUnitAdapter))]
	interface ISBaseRewardedVideoAdapter : ISRewardedVideoAdapterProtocol
	{
	}

	//// @interface  (ISBaseAdapter)
	//[Category]
	//[BaseType (typeof(ISBaseAdapter))]
	//interface ISBaseAdapter_
	//{
	//	// -(BOOL)isConfigValueValid:(NSString *)value;
	//	[Export ("isConfigValueValid:")]
	//	bool IsConfigValueValid (string value);
	//
	//	// -(NSError *)errorForMissingCredentialFieldWithName:(NSString *)fieldName;
	//	[Export ("errorForMissingCredentialFieldWithName:")]
	//	NSError ErrorForMissingCredentialFieldWithName (string fieldName);
	//
	//	// -(UIViewController *)topMostController;
	//	[Export ("topMostController")]
	//	UIViewController TopMostController { get; }
	//
	//	// -(void)setMetaDataWithKey:(NSString *)key andValues:(NSMutableArray *)values;
	//	[Export ("setMetaDataWithKey:andValues:")]
	//	void SetMetaDataWithKey (string key, NSMutableArray values);
	//}

	// @interface ISIronSourceAdapter : ISBaseAdapter
	[BaseType (typeof(ISBaseAdapter))]
	interface ISIronSourceAdapter
	{
		// -(void)initSDK:(ISAdapterConfig *)adapterConfig;
		[Export ("initSDK:")]
		void InitSDK (ISAdapterConfig adapterConfig);

		// -(NSDictionary *)createInitExtraParams;
		[Export("createInitExtraParams")]
		NSDictionary CreateInitExtraParams();
	}

	// @interface ISMediationGlobalDataWriterFacade : NSObject
	[BaseType (typeof(NSObject))]
	interface ISMediationGlobalDataWriterFacade
	{
		// -(void)setGoogleWaterMark:(NSString *)waterMark;
		[Export ("setGoogleWaterMark:")]
		void SetGoogleWaterMark (string waterMark);
	}

	// @protocol ISNAdViewsManagerSwiftFacade
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	//[Protocol]
	//interface ISNAdViewsManagerSwiftFacade
	//{
	//	// @required -(UIView *)getAdViewById:(NSString *)adViewId;
	//	[Abstract]
	//	[Export ("getAdViewById:")]
	//	UIView GetAdViewById (string adViewId);
	//}

	//// @interface ISNAdViewsManagerSwiftFacade : NSObject <ISNAdViewsManagerSwiftFacade>
	//[BaseType (typeof(NSObject))]
	//interface ISNAdViewsManagerSwiftFacade : IISNAdViewsManagerSwiftFacade
	//{
	//}

	//// @interface ISNControllerManagerSwiftFacade : NSObject
	//[BaseType (typeof(NSObject))]
	//interface ISNControllerManagerSwiftFacade
	//{
	//	// -(void)sendMessage:(MessageToController *)message callbackHandler:(void (^)(CallbackToNative *))callbackHandler;
	//	[Export ("sendMessage:callbackHandler:")]
	//	void SendMessage (MessageToController message, Action<CallbackToNative> callbackHandler);

	//	// -(void)setControllerMessageListenerWithAdId:(NSString *)adId listener:(id<ISNControllerMessageListener>)listener;
	//	[Export ("setControllerMessageListenerWithAdId:listener:")]
	//	void SetControllerMessageListenerWithAdId (string adId, ISNControllerMessageListener listener);

	//	// -(void)removeControllerMessageListenerWithAdId:(NSString *)adId;
	//	[Export ("removeControllerMessageListenerWithAdId:")]
	//	void RemoveControllerMessageListenerWithAdId (string adId);
	//}

	// @protocol ISNControllerMessageListener <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	//[Protocol]
	//[BaseType (typeof(NSObject))]
	//interface ISNControllerMessageListener
	//{
	//	// @required -(void)onReceiveWithMessage:(MessageToNative * _Nullable)message;
	//	[Abstract]
	//	[Export ("onReceiveWithMessage:")]
	//	void OnReceiveWithMessage ([NullAllowed] MessageToNative message);
	//}

	// @interface ISNEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface ISNEvent
	{
		// @property (nonatomic, strong) NSString * eventName;
		[Export ("eventName", ArgumentSemantic.Strong)]
		string EventName { get; set; }

		// @property (nonatomic, strong) NSNumber * eventId;
		[Export ("eventId", ArgumentSemantic.Strong)]
		NSNumber EventId { get; set; }

		// -(instancetype)initWithEventId:(NSNumber *)eventId eventName:(NSString *)eventName;
		[Export ("initWithEventId:eventName:")]
		NativeHandle Constructor (NSNumber eventId, string eventName);
	}

	// @protocol ISNEventTrackerInterface <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ISNEventTrackerInterface
	{
		// @required -(void)logEvent:(ISNEvent *)event data:(NSDictionary *)data;
		[Abstract]
		[Export ("logEvent:data:")]
		void Data (ISNEvent @event, NSDictionary data);
	}

	// @interface ISNEventTrackerWrapper : NSObject <ISNEventTrackerInterface>
	[BaseType (typeof(NSObject))]
	interface ISNEventTrackerWrapper : ISNEventTrackerInterface
	{
	}

	// @interface ISNSupersonicAdsPublisherSwiftFacade : NSObject
	[BaseType (typeof(NSObject))]
	interface ISNSupersonicAdsPublisherSwiftFacade
	{
		// -(void)setControllerConfig:(NSString *)config;
		[Export ("setControllerConfig:")]
		void SetControllerConfig (string config);
	}


	// @interface IronSource : NSObject
	[BaseType (typeof(NSObject))]
	interface IronSource
	{
		// +(NSString * _Nonnull)sdkVersion;
		[Static]
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// +(void)shouldTrackReachability:(BOOL)flag;
		[Static]
		[Export ("shouldTrackReachability:")]
		void ShouldTrackReachability (bool flag);

		// +(void)setAdaptersDebug:(BOOL)flag;
		[Static]
		[Export ("setAdaptersDebug:")]
		void SetAdaptersDebug (bool flag);

		// +(BOOL)setDynamicUserId:(NSString * _Nonnull)dynamicUserId;
		[Static]
		[Export ("setDynamicUserId:")]
		bool SetDynamicUserId (string dynamicUserId);

		// +(NSString * _Nonnull)advertiserId;
		[Static]
		[Export ("advertiserId")]
		string AdvertiserId { get; }

		// +(void)setMediationType:(NSString * _Nonnull)mediationType;
		[Static]
		[Export ("setMediationType:")]
		void SetMediationType (string mediationType);

		// +(void)setMetaDataWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Static]
		[Export ("setMetaDataWithKey:value:")]
		void SetMetaDataWithKey (string key, string value);

		// +(void)setMetaDataWithKey:(NSString * _Nonnull)key values:(NSMutableArray * _Nonnull)values;
		[Static]
		[Export ("setMetaDataWithKey:values:")]
		void SetMetaDataWithKey (string key, NSMutableArray values);

		// +(void)setNetworkDataWithNetworkKey:(NSString * _Nonnull)networkKey andNetworkData:(NSDictionary * _Nonnull)networkData;
		[Static]
		[Export ("setNetworkDataWithNetworkKey:andNetworkData:")]
		void SetNetworkDataWithNetworkKey (string networkKey, NSDictionary networkData);

		// +(NSString * _Nonnull)getISDemandOnlyBiddingData;
		[Static]
		[Export ("getISDemandOnlyBiddingData")]
		string ISDemandOnlyBiddingData { get; }

		// +(void)setUserId:(NSString * _Nonnull)userId;
		[Static]
		[Export ("setUserId:")]
		void SetUserId (string userId);

		// +(void)initWithAppKey:(NSString * _Nonnull)appKey;
		[Static]
		[Export ("initWithAppKey:")]
		void InitWithAppKey (string appKey);

		// +(void)initWithAppKey:(NSString * _Nonnull)appKey adUnits:(NSArray<NSString *> * _Nonnull)adUnits;
		[Static]
		[Export ("initWithAppKey:adUnits:")]
		void InitWithAppKey (string appKey, string[] adUnits);

		// +(void)showRewardedVideoWithViewController:(UIViewController * _Nonnull)viewController;
		[Static]
		[Export ("showRewardedVideoWithViewController:")]
		void ShowRewardedVideoWithViewController (UIViewController viewController);

		// +(void)showRewardedVideoWithViewController:(UIViewController * _Nonnull)viewController placement:(NSString * _Nullable)placementName;
		[Static]
		[Export ("showRewardedVideoWithViewController:placement:")]
		void ShowRewardedVideoWithViewController (UIViewController viewController, [NullAllowed] string placementName);

		// +(BOOL)hasRewardedVideo;
		[Static]
		[Export ("hasRewardedVideo")]
		bool HasRewardedVideo { get; }

		// +(BOOL)isRewardedVideoCappedForPlacement:(NSString * _Nonnull)placementName;
		[Static]
		[Export ("isRewardedVideoCappedForPlacement:")]
		bool IsRewardedVideoCappedForPlacement (string placementName);

		// +(void)setRewardedVideoServerParameters:(NSDictionary * _Nonnull)parameters;
		[Static]
		[Export ("setRewardedVideoServerParameters:")]
		void SetRewardedVideoServerParameters (NSDictionary parameters);

		// +(void)clearRewardedVideoServerParameters;
		[Static]
		[Export ("clearRewardedVideoServerParameters")]
		void ClearRewardedVideoServerParameters ();

		// +(void)setISDemandOnlyRewardedVideoDelegate:(id<ISDemandOnlyRewardedVideoDelegate> _Nonnull)delegate;
		[Static]
		[Export ("setISDemandOnlyRewardedVideoDelegate:")]
		void SetISDemandOnlyRewardedVideoDelegate (ISDemandOnlyRewardedVideoDelegate @delegate);

		// +(void)loadISDemandOnlyRewardedVideo:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("loadISDemandOnlyRewardedVideo:")]
		void LoadISDemandOnlyRewardedVideo (string instanceId);

		// +(void)showISDemandOnlyRewardedVideo:(UIViewController * _Nonnull)viewController instanceId:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("showISDemandOnlyRewardedVideo:instanceId:")]
		void ShowISDemandOnlyRewardedVideo (UIViewController viewController, string instanceId);

		// +(BOOL)hasISDemandOnlyRewardedVideo:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("hasISDemandOnlyRewardedVideo:")]
		bool HasISDemandOnlyRewardedVideo (string instanceId);

		// +(void)loadRewardedVideo;
		[Static]
		[Export ("loadRewardedVideo")]
		void LoadRewardedVideo ();


		// +(void)setISDemandOnlyInterstitialDelegate:(id<ISDemandOnlyInterstitialDelegate> _Nonnull)delegate;
		[Static]
		[Export ("setISDemandOnlyInterstitialDelegate:")]
		void SetISDemandOnlyInterstitialDelegate (ISDemandOnlyInterstitialDelegate @delegate);

		// +(void)loadISDemandOnlyInterstitial:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("loadISDemandOnlyInterstitial:")]
		void LoadISDemandOnlyInterstitial (string instanceId);

		// +(void)showISDemandOnlyInterstitial:(UIViewController * _Nonnull)viewController instanceId:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("showISDemandOnlyInterstitial:instanceId:")]
		void ShowISDemandOnlyInterstitial (UIViewController viewController, string instanceId);

		// +(BOOL)hasISDemandOnlyInterstitial:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("hasISDemandOnlyInterstitial:")]
		bool HasISDemandOnlyInterstitial (string instanceId);


		// +(void)setISDemandOnlyBannerDelegate:(id<ISDemandOnlyBannerDelegate> _Nonnull)delegate forInstanceId:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("setISDemandOnlyBannerDelegate:forInstanceId:")]
		void SetISDemandOnlyBannerDelegate (ISDemandOnlyBannerDelegate @delegate, string instanceId);

		// +(void)loadISDemandOnlyBannerWithAdm:(NSString * _Nonnull)adm instanceId:(NSString * _Nonnull)instanceId viewController:(UIViewController * _Nonnull)viewController size:(ISBannerSize * _Nonnull)size;
		[Static]
		[Export ("loadISDemandOnlyBannerWithAdm:instanceId:viewController:size:")]
		void LoadISDemandOnlyBannerWithAdm (string adm, string instanceId, UIViewController viewController, ISBannerSize size);

		// +(void)loadISDemandOnlyBannerWithInstanceId:(NSString * _Nonnull)instanceId viewController:(UIViewController * _Nonnull)viewController size:(ISBannerSize * _Nonnull)size;
		[Static]
		[Export ("loadISDemandOnlyBannerWithInstanceId:viewController:size:")]
		void LoadISDemandOnlyBannerWithInstanceId (string instanceId, UIViewController viewController, ISBannerSize size);

		// +(void)destroyISDemandOnlyBannerWithInstanceId:(NSString * _Nonnull)instanceId;
		[Static]
		[Export ("destroyISDemandOnlyBannerWithInstanceId:")]
		void DestroyISDemandOnlyBannerWithInstanceId (string instanceId);

		// +(void)setConsent:(BOOL)consent;
		[Static]
		[Export ("setConsent:")]
		void SetConsent (bool consent);

		// +(void)setAdRevenueDataWithDataSource:(NSString * _Nonnull)dataSource impressionData:(NSData * _Nonnull)impressionData;
		[Static]
		[Export ("setAdRevenueDataWithDataSource:impressionData:")]
		void SetAdRevenueDataWithDataSource (string dataSource, NSData impressionData);

		// +(void)loadConsentViewWithType:(NSString * _Nonnull)consentViewType;
		[Static]
		[Export ("loadConsentViewWithType:")]
		void LoadConsentViewWithType (string consentViewType);

		// +(void)showConsentViewWithViewController:(UIViewController * _Nonnull)viewController andType:(NSString * _Nonnull)consentViewType;
		[Static]
		[Export ("showConsentViewWithViewController:andType:")]
		void ShowConsentViewWithViewController (UIViewController viewController, string consentViewType);

		// +(NSNumber * _Nonnull)getConversionValue;
		[Static]
		[Export ("getConversionValue")]
		NSNumber ConversionValue { get; }

		// +(void)launchTestSuite:(UIViewController * _Nonnull)viewController;
		[Static]
		[Export ("launchTestSuite:")]
		void LaunchTestSuite (UIViewController viewController);

	}
}
