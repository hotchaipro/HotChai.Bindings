using System;
using AuthenticationServices;
using AVFoundation;
using BackgroundAssets;
using CoreAnimation;
using CoreFoundation;
using CoreImage;
using CoreLocation;
using CoreMedia;
using Foundation;
using ImageIO;
using MapKit;
using Metal;
using ObjCRuntime;
using CoreGraphics;
using UIKit;
using UserNotifications;
using WebKit;

namespace Google.UserMessagingPlatform
{
    /// <summary>
    /// Overrides settings for debugging or testing.
    /// </summary>
    [BaseType(typeof(NSObject), Name = "UMPDebugSettings")]
    partial interface DebugSettings : INSCopying
    {
        /// <summary>
        /// Array of device identifier strings. Debug features are enabled for devices with these identifiers. Debug features are always enabled for simulators.
        /// </summary>
        [Export("testDeviceIdentifiers", ArgumentSemantic.Copy)]
        [NullAllowed]
        // Element type: string
        string[] TestDeviceIdentifiers {
            get;
            [Export("setTestDeviceIdentifiers:")] set;
        }

        /// <summary>
        /// Debug geography.
        /// </summary>
        [Export("geography", ArgumentSemantic.Assign)]
        DebugGeography Geography {
            get;
            [Export("setGeography:")] set;
        }

    }

    /// <summary>
    /// Parameters sent on updates to user consent info.
    /// </summary>
    [BaseType(typeof(NSObject), Name = "UMPRequestParameters")]
    partial interface RequestParameters : INSCopying
    {
        /// <summary>
        /// Indicates whether the user is tagged for under age of consent.
        /// </summary>
        [Export("tagForUnderAgeOfConsent", ArgumentSemantic.Assign)]
        bool TagForUnderAgeOfConsent {
            get;
            [Export("setTagForUnderAgeOfConsent:")] set;
        }

        /// <summary>
        /// Debug settings for the request.
        /// </summary>
        [Export("debugSettings", ArgumentSemantic.Copy)]
        [NullAllowed]
        DebugSettings DebugSettings {
            get;
            [Export("setDebugSettings:")] set;
        }

        /// <summary>
        /// The consent sync ID to sync the user consent status collected with the same ID. The consent sync ID must meet the following requirements: - Constructed as a UUID string, or matches the regular expression (regex) ^[0-9a-zA-Z+.=\/_\-$,{}]{22,150}$ . - A minimum of 22 characters. - A maximum of 150 characters. Failure to meet the requirements results in the consent sync ID not being set and the  SDK logging a warning to the console.
        /// </summary>
        [Export("consentSyncID", ArgumentSemantic.Copy)]
        [NullAllowed]
        string ConsentSyncID {
            get;
            [Export("setConsentSyncID:")] set;
        }

    }

    /// <summary>
    /// Consent information. All methods must be called on the main thread.
    /// </summary>
    [BaseType(typeof(NSObject), Name = "UMPConsentInformation")]
    partial interface ConsentInformation
    {
        /// <summary>
        /// Requests consent information update. Must be called in every app session before checking the user's consentStatus or loading a consent form. After calling this method, consentStatus will be updated synchronously to hold the consent state from the previous app session, if one exists. consentStatus may be updated again immediately before the completion handler is called.
        /// </summary>
        [Export("requestConsentInfoUpdateWithParameters:completionHandler:")]
        void RequestConsentInfoUpdateWithParameters([NullAllowed] RequestParameters parameters, Action<NSError> handler);

        /// <summary>
        /// Clears all consent state from persistent storage.
        /// </summary>
        [Export("reset")]
        void Reset();

        /// <summary>
        /// The shared consent information instance.
        /// </summary>
        [Static]
        [Export("sharedInstance")]
        ConsentInformation SharedInstance { get; }

        /// <summary>
        /// The user's consent status. This value defaults to ConsentStatusUnknown until requestConsentInfoUpdateWithParameters:completionHandler: is called, and defaults to the previous session's value until |completionHandler| from requestConsentInfoUpdateWithParameters:completionHandler: is called.
        /// </summary>
        [Export("consentStatus")]
        ConsentStatus ConsentStatus { get; }

        /// <summary>
        /// Indicates whether the SDK has gathered consent aligned with the app's configured messages. Returns NO until requestConsentInfoUpdateWithParameters:completionHandler: is called.
        /// </summary>
        [Export("canRequestAds")]
        bool CanRequestAds { get; }

        /// <summary>
        /// Consent form status. This value defaults to FormStatusUnknown and requires a call to requestConsentInfoUpdateWithParameters:completionHandler: to update.
        /// </summary>
        [Export("formStatus")]
        FormStatus FormStatus { get; }

        /// <summary>
        /// Privacy options requirement status. This value defaults to PrivacyOptionsRequirementStatusUnknown until requestConsentInfoUpdateWithParameters:completionHandler: is called, and defaults to the previous session's value until |completionHandler| from requestConsentInfoUpdateWithParameters:completionHandler: is called.
        /// </summary>
        [Export("privacyOptionsRequirementStatus")]
        PrivacyOptionsRequirementStatus PrivacyOptionsRequirementStatus { get; }

    }

    /// <summary>
    /// A single use consent form object.
    /// </summary>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject), Name = "UMPConsentForm")]
    partial interface ConsentForm
    {
        /// <summary>
        /// Loads a consent form and calls completionHandler on completion. Must be called on the main queue.
        /// </summary>
        [Static]
        [Export("loadWithCompletionHandler:")]
        void LoadWithCompletionHandler(Action<ConsentForm, NSError> completionHandler);

        /// <summary>
        /// Loads a consent form and immediately presents it from the provided viewController if ConsentInformation.sharedInstance.consentStatus is ConsentStatusRequired. Calls completionHandler after the user selects an option and the form is dismissed, or on the next run loop if no form is presented. Must be called on the main queue. If viewController is nil, uses the top view controller of the application's main window.
        /// </summary>
        [Static]
        [Export("loadAndPresentIfRequiredFromViewController:completionHandler:")]
        void LoadAndPresentIfRequiredFromViewController([NullAllowed] UIViewController viewController, [NullAllowed] Action<NSError> completionHandler);

        /// <summary>
        /// Presents a privacy options form from the provided viewController if ConsentInformation.sharedInstance.privacyOptionsRequirementStatus is PrivacyOptionsRequirementStatusRequired. Calls completionHandler with nil error after the user selects an option and the form is dismissed, or on the next run loop with a non-nil error if no form is presented. Must be called on the main queue. This method should only be called in response to a user input to request a privacy options form to be shown. The privacy options form is preloaded by the SDK automatically when a form becomes available. If no form is preloaded, the SDK will invoke the completionHandler on the next run loop, but will asynchronously retry to load one. If viewController is nil, uses the top view controller of the application's main window.
        /// </summary>
        [Static]
        [Export("presentPrivacyOptionsFormFromViewController:completionHandler:")]
        void PresentPrivacyOptionsFormFromViewController([NullAllowed] UIViewController viewController, [NullAllowed] Action<NSError> completionHandler);

        /// <summary>
        /// Presents the full screen consent form over viewController. The form is dismissed and completionHandler is called after the user selects an option. ConsentInformation.sharedInstance.consentStatus is updated prior to completionHandler being called. completionHandler is called on the main queue. If viewController is nil, uses the top view controller of the application's main window.
        /// </summary>
        [Export("presentFromViewController:completionHandler:")]
        void PresentFromViewController([NullAllowed] UIViewController viewController, [NullAllowed] Action<NSError> completionHandler);

    }

}
