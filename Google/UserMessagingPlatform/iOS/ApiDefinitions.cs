using Foundation;
using ObjCRuntime;
using UIKit;

namespace Google.UserMessagingPlatform
{
	// @interface UMPDebugSettings : NSObject <NSCopying>
	[BaseType (typeof(NSObject), Name = "UMPDebugSettings")]
	interface DebugSettings : INSCopying
	{
		// @property (nonatomic) NSArray<NSString *> * _Nullable testDeviceIdentifiers;
		[NullAllowed, Export ("testDeviceIdentifiers", ArgumentSemantic.Assign)]
		string[] TestDeviceIdentifiers { get; set; }

		// @property (nonatomic) UMPDebugGeography geography;
		[Export ("geography", ArgumentSemantic.Assign)]
		DebugGeography Geography { get; set; }
	}

	// @interface UMPRequestParameters : NSObject
	[BaseType (typeof(NSObject), Name = "UMPRequestParameters")]
	interface RequestParameters : INSCopying
	{
		// @property (nonatomic) BOOL tagForUnderAgeOfConsent;
		[Export ("tagForUnderAgeOfConsent")]
		bool TagForUnderAgeOfConsent { get; set; }

		// @property (copy, nonatomic) UMPDebugSettings * _Nullable debugSettings;
		[NullAllowed, Export ("debugSettings", ArgumentSemantic.Copy)]
		DebugSettings DebugSettings { get; set; }
	}

	// typedef void (^UMPConsentInformationUpdateCompletionHandler)(NSError * _Nullable);
	delegate void ConsentInformationUpdateCompletionHandler ([NullAllowed] NSError arg0);

    // @interface UMPConsentInformation : NSObject
    [BaseType (typeof(NSObject), Name = "UMPConsentInformation")]
    interface ConsentInformation
    {
	    // @property (readonly, nonatomic, class) UMPConsentInformation * _Nonnull sharedInstance;
	    [Static]
	    [Export ("sharedInstance")]
	    ConsentInformation SharedInstance { get; }

	    // @property (readonly, nonatomic) UMPConsentStatus consentStatus;
	    [Export ("consentStatus")]
	    ConsentStatus ConsentStatus { get; }

		// @property (readonly, nonatomic) BOOL canRequestAds;
		[Export ("canRequestAds")]
		bool CanRequestAds { get; }

	    // @property (readonly, nonatomic) UMPFormStatus formStatus;
	    [Export ("formStatus")]
	    FormStatus FormStatus { get; }

		// @property (readonly, nonatomic) UMPPrivacyOptionsRequirementStatus privacyOptionsRequirementStatus;
		[Export ("privacyOptionsRequirementStatus")]
		PrivacyOptionsRequirementStatus PrivacyOptionsRequirementStatus { get; }

		// -(void)requestConsentInfoUpdateWithParameters:(UMPRequestParameters * _Nullable)parameters completionHandler:(UMPConsentInformationUpdateCompletionHandler _Nonnull)handler;
	    [Export ("requestConsentInfoUpdateWithParameters:completionHandler:")]
	    void RequestConsentInfoUpdateWithParameters ([NullAllowed] RequestParameters parameters, ConsentInformationUpdateCompletionHandler handler);

	    // -(void)reset;
	    [Export ("reset")]
	    void Reset ();
    }

	// typedef void (^UMPConsentFormLoadCompletionHandler)(UMPConsentForm * _Nullable, NSError * _Nullable);
	delegate void ConsentFormLoadCompletionHandler ([NullAllowed] ConsentForm arg0, [NullAllowed] NSError arg1);

	// typedef void (^UMPConsentFormPresentCompletionHandler)(NSError * _Nullable);
    delegate void ConsentFormPresentCompletionHandler([NullAllowed] NSError error);

	// @interface UMPConsentForm : NSObject
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject), Name = "UMPConsentForm")]
	interface ConsentForm
	{
		// +(void)loadWithCompletionHandler:(UMPConsentFormLoadCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export ("loadWithCompletionHandler:")]
		void LoadWithCompletionHandler (ConsentFormLoadCompletionHandler completionHandler);

		// +(void)loadAndPresentIfRequiredFromViewController:(UIViewController * _Nonnull)viewController completionHandler:(UMPConsentFormPresentCompletionHandler _Nullable)completionHandler;
		[Static]
		[Export ("loadAndPresentIfRequiredFromViewController:completionHandler:")]
		void LoadAndPresentIfRequiredFromViewController (UIViewController viewController, [NullAllowed] ConsentFormPresentCompletionHandler completionHandler);

		// +(void)presentPrivacyOptionsFormFromViewController:(UIViewController * _Nonnull)viewController completionHandler:(UMPConsentFormPresentCompletionHandler _Nullable)completionHandler;
		[Static]
		[Export ("presentPrivacyOptionsFormFromViewController:completionHandler:")]
		void PresentPrivacyOptionsFormFromViewController (UIViewController viewController, [NullAllowed] ConsentFormPresentCompletionHandler completionHandler);

		// -(void)presentFromViewController:(id)viewController completionHandler:(UMPConsentFormPresentCompletionHandler _Nullable)completionHandler;
		[Export ("presentFromViewController:completionHandler:")]
		void PresentFromViewController (UIViewController viewController, [NullAllowed] ConsentFormPresentCompletionHandler completionHandler);
	}
}
