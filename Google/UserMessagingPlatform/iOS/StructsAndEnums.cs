using System;
using System.Runtime.InteropServices;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreLocation;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Google.UserMessagingPlatform
{
    /// <summary>
    /// Debug values for testing geography.
    /// </summary>
    [Native]
    public enum DebugGeography : long
    {
        Disabled = 0,
        EEA = 1,
        NotEEA = 2,
        RegulatedUSState = 3,
        Other = 4,
    }

    /// <summary>
    /// Consent status values.
    /// </summary>
    [Native]
    public enum ConsentStatus : long
    {
        Unknown = 0,
        Required = 1,
        NotRequired = 2,
        Obtained = 3,
    }

    /// <summary>
    /// State values for whether the user has a consent form available to them. To check whether form status has changed, an update can be requested through requestConsentInfoUpdateWithParameters:completionHandler.
    /// </summary>
    [Native]
    public enum FormStatus : long
    {
        Unknown = 0,
        Available = 1,
        Unavailable = 2,
    }

    /// <summary>
    /// State values for whether the user needs to be provided a way to modify their privacy options.
    /// </summary>
    [Native]
    public enum PrivacyOptionsRequirementStatus : long
    {
        Unknown = 0,
        Required = 1,
        NotRequired = 2,
    }

    /// <summary>
    /// Error codes used when making requests to update consent info.
    /// </summary>
    [Native]
    public enum RequestErrorCode : long
    {
        Internal = 1,
        InvalidAppID = 2,
        Network = 3,
        Misconfiguration = 4,
    }

    /// <summary>
    /// Error codes used when loading and showing forms.
    /// </summary>
    [Native]
    public enum FormErrorCode : long
    {
        Internal = 5,
        AlreadyUsed = 6,
        Unavailable = 7,
        Timeout = 8,
        InvalidViewController = 9,
    }
}
