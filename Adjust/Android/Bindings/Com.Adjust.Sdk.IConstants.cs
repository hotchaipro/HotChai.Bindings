using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Adjust.Sdk {

	[Register ("com/adjust/sdk/Constants", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Adjust.Sdk.IConstants' type. This class will be removed in a future release.")]
	public abstract class Constants : Java.Lang.Object {
		internal Constants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ACTIVITY_STATE_FILENAME']"
		[Register ("ACTIVITY_STATE_FILENAME")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ActivityStateFilename'. This class will be removed in a future release.")]
		public const string ActivityStateFilename = (string) "AdjustIoActivityState";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_CONTENT_PROVIDER_INTENT_ACTION']"
		[Register ("ADJUST_PREINSTALL_CONTENT_PROVIDER_INTENT_ACTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.AdjustPreinstallContentProviderIntentAction'. This class will be removed in a future release.")]
		public const string AdjustPreinstallContentProviderIntentAction = (string) "com.attribution.REFERRAL_PROVIDER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_CONTENT_URI_AUTHORITY']"
		[Register ("ADJUST_PREINSTALL_CONTENT_URI_AUTHORITY")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.AdjustPreinstallContentUriAuthority'. This class will be removed in a future release.")]
		public const string AdjustPreinstallContentUriAuthority = (string) "com.adjust.preinstall";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_CONTENT_URI_PATH']"
		[Register ("ADJUST_PREINSTALL_CONTENT_URI_PATH")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.AdjustPreinstallContentUriPath'. This class will be removed in a future release.")]
		public const string AdjustPreinstallContentUriPath = (string) "trackers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_FILE_SYSTEM_PATH']"
		[Register ("ADJUST_PREINSTALL_FILE_SYSTEM_PATH")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.AdjustPreinstallFileSystemPath'. This class will be removed in a future release.")]
		public const string AdjustPreinstallFileSystemPath = (string) "/data/local/tmp/adjust.preinstall";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_SYSTEM_PROPERTY_PATH']"
		[Register ("ADJUST_PREINSTALL_SYSTEM_PROPERTY_PATH")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.AdjustPreinstallSystemPropertyPath'. This class will be removed in a future release.")]
		public const string AdjustPreinstallSystemPropertyPath = (string) "adjust.preinstall.path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_SYSTEM_PROPERTY_PREFIX']"
		[Register ("ADJUST_PREINSTALL_SYSTEM_PROPERTY_PREFIX")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.AdjustPreinstallSystemPropertyPrefix'. This class will be removed in a future release.")]
		public const string AdjustPreinstallSystemPropertyPrefix = (string) "adjust.preinstall.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ATTRIBUTION_FILENAME']"
		[Register ("ATTRIBUTION_FILENAME")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.AttributionFilename'. This class will be removed in a future release.")]
		public const string AttributionFilename = (string) "AdjustAttribution";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='AUTHORITY']"
		[Register ("AUTHORITY")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Authority'. This class will be removed in a future release.")]
		public const string Authority = (string) "app.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='BASE_URL']"
		[Register ("BASE_URL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.BaseUrl'. This class will be removed in a future release.")]
		public const string BaseUrl = (string) "https://app.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CALLBACK_PARAMETERS']"
		[Register ("CALLBACK_PARAMETERS")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.CallbackParameters'. This class will be removed in a future release.")]
		public const string CallbackParameters = (string) "callback_params";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CLIENT_SDK']"
		[Register ("CLIENT_SDK")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ClientSdk'. This class will be removed in a future release.")]
		public const string ClientSdk = (string) "android4.38.4";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONNECTION_TIMEOUT']"
		[Register ("CONNECTION_TIMEOUT")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ConnectionTimeout'. This class will be removed in a future release.")]
		public const int ConnectionTimeout = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONTENT_PROVIDER']"
		[Register ("CONTENT_PROVIDER")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ContentProvider'. This class will be removed in a future release.")]
		public const string ContentProvider = (string) "content_provider";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONTENT_PROVIDER_INTENT_ACTION']"
		[Register ("CONTENT_PROVIDER_INTENT_ACTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ContentProviderIntentAction'. This class will be removed in a future release.")]
		public const string ContentProviderIntentAction = (string) "content_provider_intent_action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONTENT_PROVIDER_NO_PERMISSION']"
		[Register ("CONTENT_PROVIDER_NO_PERMISSION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ContentProviderNoPermission'. This class will be removed in a future release.")]
		public const string ContentProviderNoPermission = (string) "content_provider_no_permission";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='DEEPLINK']"
		[Register ("DEEPLINK")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Deeplink'. This class will be removed in a future release.")]
		public const string Deeplink = (string) "deeplink";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ENCODING']"
		[Register ("ENCODING")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Encoding'. This class will be removed in a future release.")]
		public const string Encoding = (string) "UTF-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='EXTRA_SYSTEM_INSTALLER_REFERRER']"
		[Register ("EXTRA_SYSTEM_INSTALLER_REFERRER")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ExtraSystemInstallerReferrer'. This class will be removed in a future release.")]
		public const string ExtraSystemInstallerReferrer = (string) "com.attribution.EXTRA_SYSTEM_INSTALLER_REFERRER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FB_AUTH_REGEX']"
		[Register ("FB_AUTH_REGEX")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.FbAuthRegex'. This class will be removed in a future release.")]
		public const string FbAuthRegex = (string) "^(fb|vk)[0-9]{5,}[^:]*://authorize.*access_token=.*";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FCM_PAYLOAD_KEY']"
		[Register ("FCM_PAYLOAD_KEY")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.FcmPayloadKey'. This class will be removed in a future release.")]
		public const string FcmPayloadKey = (string) "adjust_purpose";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FCM_PAYLOAD_VALUE']"
		[Register ("FCM_PAYLOAD_VALUE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.FcmPayloadValue'. This class will be removed in a future release.")]
		public const string FcmPayloadValue = (string) "uninstall detection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FILE_SYSTEM']"
		[Register ("FILE_SYSTEM")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.FileSystem'. This class will be removed in a future release.")]
		public const string FileSystem = (string) "file_system";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='GDPR_URL']"
		[Register ("GDPR_URL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.GdprUrl'. This class will be removed in a future release.")]
		public const string GdprUrl = (string) "https://gdpr.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='HIGH']"
		[Register ("HIGH")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.High'. This class will be removed in a future release.")]
		public const string High = (string) "high";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='INSTALL_REFERRER']"
		[Register ("INSTALL_REFERRER")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.InstallReferrer'. This class will be removed in a future release.")]
		public const string InstallReferrer = (string) "install_referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LARGE']"
		[Register ("LARGE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Large'. This class will be removed in a future release.")]
		public const string Large = (string) "large";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Logtag'. This class will be removed in a future release.")]
		public const string Logtag = (string) "Adjust";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LONG']"
		[Register ("LONG")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Long'. This class will be removed in a future release.")]
		public const string Long = (string) "long";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LOW']"
		[Register ("LOW")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Low'. This class will be removed in a future release.")]
		public const string Low = (string) "low";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MALFORMED']"
		[Register ("MALFORMED")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Malformed'. This class will be removed in a future release.")]
		public const string Malformed = (string) "malformed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MAX_INSTALL_REFERRER_RETRIES']"
		[Register ("MAX_INSTALL_REFERRER_RETRIES")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.MaxInstallReferrerRetries'. This class will be removed in a future release.")]
		public const int MaxInstallReferrerRetries = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MAX_WAIT_INTERVAL']"
		[Register ("MAX_WAIT_INTERVAL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.MaxWaitInterval'. This class will be removed in a future release.")]
		public const int MaxWaitInterval = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MEDIUM']"
		[Register ("MEDIUM")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Medium'. This class will be removed in a future release.")]
		public const string Medium = (string) "medium";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MINIMAL_ERROR_STATUS_CODE']"
		[Register ("MINIMAL_ERROR_STATUS_CODE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.MinimalErrorStatusCode'. This class will be removed in a future release.")]
		public const int MinimalErrorStatusCode = (int) 400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Normal'. This class will be removed in a future release.")]
		public const string Normal = (string) "normal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ONE_HOUR']"
		[Register ("ONE_HOUR")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.OneHour'. This class will be removed in a future release.")]
		public const int OneHour = (int) 3600000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ONE_MINUTE']"
		[Register ("ONE_MINUTE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.OneMinute'. This class will be removed in a future release.")]
		public const int OneMinute = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ONE_SECOND']"
		[Register ("ONE_SECOND")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.OneSecond'. This class will be removed in a future release.")]
		public const int OneSecond = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PARTNER_PARAMETERS']"
		[Register ("PARTNER_PARAMETERS")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.PartnerParameters'. This class will be removed in a future release.")]
		public const string PartnerParameters = (string) "partner_params";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PREINSTALL']"
		[Register ("PREINSTALL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Preinstall'. This class will be removed in a future release.")]
		public const string Preinstall = (string) "preinstall";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PURCHASE_VERIFICATION_URL']"
		[Register ("PURCHASE_VERIFICATION_URL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.PurchaseVerificationUrl'. This class will be removed in a future release.")]
		public const string PurchaseVerificationUrl = (string) "https://ssrv.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PUSH']"
		[Register ("PUSH")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Push'. This class will be removed in a future release.")]
		public const string Push = (string) "push";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER']"
		[Register ("REFERRER")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Referrer'. This class will be removed in a future release.")]
		public const string Referrer = (string) "referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_GOOGLE']"
		[Register ("REFERRER_API_GOOGLE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ReferrerApiGoogle'. This class will be removed in a future release.")]
		public const string ReferrerApiGoogle = (string) "google";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_HUAWEI_ADS']"
		[Register ("REFERRER_API_HUAWEI_ADS")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ReferrerApiHuaweiAds'. This class will be removed in a future release.")]
		public const string ReferrerApiHuaweiAds = (string) "huawei_ads";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_HUAWEI_APP_GALLERY']"
		[Register ("REFERRER_API_HUAWEI_APP_GALLERY")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ReferrerApiHuaweiAppGallery'. This class will be removed in a future release.")]
		public const string ReferrerApiHuaweiAppGallery = (string) "huawei_app_gallery";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_META']"
		[Register ("REFERRER_API_META")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ReferrerApiMeta'. This class will be removed in a future release.")]
		public const string ReferrerApiMeta = (string) "meta";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_SAMSUNG']"
		[Register ("REFERRER_API_SAMSUNG")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ReferrerApiSamsung'. This class will be removed in a future release.")]
		public const string ReferrerApiSamsung = (string) "samsung";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_VIVO']"
		[Register ("REFERRER_API_VIVO")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ReferrerApiVivo'. This class will be removed in a future release.")]
		public const string ReferrerApiVivo = (string) "vivo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_XIAOMI']"
		[Register ("REFERRER_API_XIAOMI")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ReferrerApiXiaomi'. This class will be removed in a future release.")]
		public const string ReferrerApiXiaomi = (string) "xiaomi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFTAG']"
		[Register ("REFTAG")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Reftag'. This class will be removed in a future release.")]
		public const string Reftag = (string) "reftag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SCHEME']"
		[Register ("SCHEME")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Scheme'. This class will be removed in a future release.")]
		public const string Scheme = (string) "https";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SESSION_CALLBACK_PARAMETERS_FILENAME']"
		[Register ("SESSION_CALLBACK_PARAMETERS_FILENAME")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SessionCallbackParametersFilename'. This class will be removed in a future release.")]
		public const string SessionCallbackParametersFilename = (string) "AdjustSessionCallbackParameters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SESSION_PARTNER_PARAMETERS_FILENAME']"
		[Register ("SESSION_PARTNER_PARAMETERS_FILENAME")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SessionPartnerParametersFilename'. This class will be removed in a future release.")]
		public const string SessionPartnerParametersFilename = (string) "AdjustSessionPartnerParameters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SHA256']"
		[Register ("SHA256")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Sha256'. This class will be removed in a future release.")]
		public const string Sha256 = (string) "SHA-256";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SMALL']"
		[Register ("SMALL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Small'. This class will be removed in a future release.")]
		public const string Small = (string) "small";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SOCKET_TIMEOUT']"
		[Register ("SOCKET_TIMEOUT")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SocketTimeout'. This class will be removed in a future release.")]
		public const int SocketTimeout = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SUBSCRIPTION_URL']"
		[Register ("SUBSCRIPTION_URL")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SubscriptionUrl'. This class will be removed in a future release.")]
		public const string SubscriptionUrl = (string) "https://subscription.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_INSTALLER_REFERRER']"
		[Register ("SYSTEM_INSTALLER_REFERRER")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SystemInstallerReferrer'. This class will be removed in a future release.")]
		public const string SystemInstallerReferrer = (string) "system_installer_referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES']"
		[Register ("SYSTEM_PROPERTIES")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SystemProperties'. This class will be removed in a future release.")]
		public const string SystemProperties = (string) "system_properties";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES_PATH']"
		[Register ("SYSTEM_PROPERTIES_PATH")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SystemPropertiesPath'. This class will be removed in a future release.")]
		public const string SystemPropertiesPath = (string) "system_properties_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES_PATH_REFLECTION']"
		[Register ("SYSTEM_PROPERTIES_PATH_REFLECTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SystemPropertiesPathReflection'. This class will be removed in a future release.")]
		public const string SystemPropertiesPathReflection = (string) "system_properties_path_reflection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES_REFLECTION']"
		[Register ("SYSTEM_PROPERTIES_REFLECTION")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.SystemPropertiesReflection'. This class will be removed in a future release.")]
		public const string SystemPropertiesReflection = (string) "system_properties_reflection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='THIRTY_MINUTES']"
		[Register ("THIRTY_MINUTES")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ThirtyMinutes'. This class will be removed in a future release.")]
		public const int ThirtyMinutes = (int) 1800000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='THREAD_PREFIX']"
		[Register ("THREAD_PREFIX")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.ThreadPrefix'. This class will be removed in a future release.")]
		public const string ThreadPrefix = (string) "Adjust-";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='XLARGE']"
		[Register ("XLARGE")]
		[global::System.Obsolete (@"Use 'Com.Adjust.Sdk.IConstants.Xlarge'. This class will be removed in a future release.")]
		public const string Xlarge = (string) "xlarge";

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']"
	[Register ("com/adjust/sdk/Constants", "", "Com.Adjust.Sdk.IConstantsInvoker")]
	public partial interface IConstants : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ACTIVITY_STATE_FILENAME']"
		[Register ("ACTIVITY_STATE_FILENAME")]
		public const string ActivityStateFilename = (string) "AdjustIoActivityState";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_CONTENT_PROVIDER_INTENT_ACTION']"
		[Register ("ADJUST_PREINSTALL_CONTENT_PROVIDER_INTENT_ACTION")]
		public const string AdjustPreinstallContentProviderIntentAction = (string) "com.attribution.REFERRAL_PROVIDER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_CONTENT_URI_AUTHORITY']"
		[Register ("ADJUST_PREINSTALL_CONTENT_URI_AUTHORITY")]
		public const string AdjustPreinstallContentUriAuthority = (string) "com.adjust.preinstall";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_CONTENT_URI_PATH']"
		[Register ("ADJUST_PREINSTALL_CONTENT_URI_PATH")]
		public const string AdjustPreinstallContentUriPath = (string) "trackers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_FILE_SYSTEM_PATH']"
		[Register ("ADJUST_PREINSTALL_FILE_SYSTEM_PATH")]
		public const string AdjustPreinstallFileSystemPath = (string) "/data/local/tmp/adjust.preinstall";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_SYSTEM_PROPERTY_PATH']"
		[Register ("ADJUST_PREINSTALL_SYSTEM_PROPERTY_PATH")]
		public const string AdjustPreinstallSystemPropertyPath = (string) "adjust.preinstall.path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ADJUST_PREINSTALL_SYSTEM_PROPERTY_PREFIX']"
		[Register ("ADJUST_PREINSTALL_SYSTEM_PROPERTY_PREFIX")]
		public const string AdjustPreinstallSystemPropertyPrefix = (string) "adjust.preinstall.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ATTRIBUTION_FILENAME']"
		[Register ("ATTRIBUTION_FILENAME")]
		public const string AttributionFilename = (string) "AdjustAttribution";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='AUTHORITY']"
		[Register ("AUTHORITY")]
		public const string Authority = (string) "app.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='BASE_URL']"
		[Register ("BASE_URL")]
		public const string BaseUrl = (string) "https://app.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CALLBACK_PARAMETERS']"
		[Register ("CALLBACK_PARAMETERS")]
		public const string CallbackParameters = (string) "callback_params";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CLIENT_SDK']"
		[Register ("CLIENT_SDK")]
		public const string ClientSdk = (string) "android4.38.4";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONNECTION_TIMEOUT']"
		[Register ("CONNECTION_TIMEOUT")]
		public const int ConnectionTimeout = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONTENT_PROVIDER']"
		[Register ("CONTENT_PROVIDER")]
		public const string ContentProvider = (string) "content_provider";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONTENT_PROVIDER_INTENT_ACTION']"
		[Register ("CONTENT_PROVIDER_INTENT_ACTION")]
		public const string ContentProviderIntentAction = (string) "content_provider_intent_action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='CONTENT_PROVIDER_NO_PERMISSION']"
		[Register ("CONTENT_PROVIDER_NO_PERMISSION")]
		public const string ContentProviderNoPermission = (string) "content_provider_no_permission";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='DEEPLINK']"
		[Register ("DEEPLINK")]
		public const string Deeplink = (string) "deeplink";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ENCODING']"
		[Register ("ENCODING")]
		public const string Encoding = (string) "UTF-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='EXTRA_SYSTEM_INSTALLER_REFERRER']"
		[Register ("EXTRA_SYSTEM_INSTALLER_REFERRER")]
		public const string ExtraSystemInstallerReferrer = (string) "com.attribution.EXTRA_SYSTEM_INSTALLER_REFERRER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FB_AUTH_REGEX']"
		[Register ("FB_AUTH_REGEX")]
		public const string FbAuthRegex = (string) "^(fb|vk)[0-9]{5,}[^:]*://authorize.*access_token=.*";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FCM_PAYLOAD_KEY']"
		[Register ("FCM_PAYLOAD_KEY")]
		public const string FcmPayloadKey = (string) "adjust_purpose";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FCM_PAYLOAD_VALUE']"
		[Register ("FCM_PAYLOAD_VALUE")]
		public const string FcmPayloadValue = (string) "uninstall detection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='FILE_SYSTEM']"
		[Register ("FILE_SYSTEM")]
		public const string FileSystem = (string) "file_system";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='GDPR_URL']"
		[Register ("GDPR_URL")]
		public const string GdprUrl = (string) "https://gdpr.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='HIGH']"
		[Register ("HIGH")]
		public const string High = (string) "high";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='INSTALL_REFERRER']"
		[Register ("INSTALL_REFERRER")]
		public const string InstallReferrer = (string) "install_referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LARGE']"
		[Register ("LARGE")]
		public const string Large = (string) "large";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		public const string Logtag = (string) "Adjust";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LONG']"
		[Register ("LONG")]
		public const string Long = (string) "long";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='LOW']"
		[Register ("LOW")]
		public const string Low = (string) "low";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MALFORMED']"
		[Register ("MALFORMED")]
		public const string Malformed = (string) "malformed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MAX_INSTALL_REFERRER_RETRIES']"
		[Register ("MAX_INSTALL_REFERRER_RETRIES")]
		public const int MaxInstallReferrerRetries = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MAX_WAIT_INTERVAL']"
		[Register ("MAX_WAIT_INTERVAL")]
		public const int MaxWaitInterval = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MEDIUM']"
		[Register ("MEDIUM")]
		public const string Medium = (string) "medium";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='MINIMAL_ERROR_STATUS_CODE']"
		[Register ("MINIMAL_ERROR_STATUS_CODE")]
		public const int MinimalErrorStatusCode = (int) 400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public const string Normal = (string) "normal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ONE_HOUR']"
		[Register ("ONE_HOUR")]
		public const int OneHour = (int) 3600000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ONE_MINUTE']"
		[Register ("ONE_MINUTE")]
		public const int OneMinute = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='ONE_SECOND']"
		[Register ("ONE_SECOND")]
		public const int OneSecond = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PARTNER_PARAMETERS']"
		[Register ("PARTNER_PARAMETERS")]
		public const string PartnerParameters = (string) "partner_params";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PREINSTALL']"
		[Register ("PREINSTALL")]
		public const string Preinstall = (string) "preinstall";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PURCHASE_VERIFICATION_URL']"
		[Register ("PURCHASE_VERIFICATION_URL")]
		public const string PurchaseVerificationUrl = (string) "https://ssrv.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='PUSH']"
		[Register ("PUSH")]
		public const string Push = (string) "push";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER']"
		[Register ("REFERRER")]
		public const string Referrer = (string) "referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_GOOGLE']"
		[Register ("REFERRER_API_GOOGLE")]
		public const string ReferrerApiGoogle = (string) "google";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_HUAWEI_ADS']"
		[Register ("REFERRER_API_HUAWEI_ADS")]
		public const string ReferrerApiHuaweiAds = (string) "huawei_ads";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_HUAWEI_APP_GALLERY']"
		[Register ("REFERRER_API_HUAWEI_APP_GALLERY")]
		public const string ReferrerApiHuaweiAppGallery = (string) "huawei_app_gallery";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_META']"
		[Register ("REFERRER_API_META")]
		public const string ReferrerApiMeta = (string) "meta";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_SAMSUNG']"
		[Register ("REFERRER_API_SAMSUNG")]
		public const string ReferrerApiSamsung = (string) "samsung";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_VIVO']"
		[Register ("REFERRER_API_VIVO")]
		public const string ReferrerApiVivo = (string) "vivo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFERRER_API_XIAOMI']"
		[Register ("REFERRER_API_XIAOMI")]
		public const string ReferrerApiXiaomi = (string) "xiaomi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='REFTAG']"
		[Register ("REFTAG")]
		public const string Reftag = (string) "reftag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SCHEME']"
		[Register ("SCHEME")]
		public const string Scheme = (string) "https";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SESSION_CALLBACK_PARAMETERS_FILENAME']"
		[Register ("SESSION_CALLBACK_PARAMETERS_FILENAME")]
		public const string SessionCallbackParametersFilename = (string) "AdjustSessionCallbackParameters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SESSION_PARTNER_PARAMETERS_FILENAME']"
		[Register ("SESSION_PARTNER_PARAMETERS_FILENAME")]
		public const string SessionPartnerParametersFilename = (string) "AdjustSessionPartnerParameters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SHA256']"
		[Register ("SHA256")]
		public const string Sha256 = (string) "SHA-256";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SMALL']"
		[Register ("SMALL")]
		public const string Small = (string) "small";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SOCKET_TIMEOUT']"
		[Register ("SOCKET_TIMEOUT")]
		public const int SocketTimeout = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SUBSCRIPTION_URL']"
		[Register ("SUBSCRIPTION_URL")]
		public const string SubscriptionUrl = (string) "https://subscription.adjust.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_INSTALLER_REFERRER']"
		[Register ("SYSTEM_INSTALLER_REFERRER")]
		public const string SystemInstallerReferrer = (string) "system_installer_referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES']"
		[Register ("SYSTEM_PROPERTIES")]
		public const string SystemProperties = (string) "system_properties";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES_PATH']"
		[Register ("SYSTEM_PROPERTIES_PATH")]
		public const string SystemPropertiesPath = (string) "system_properties_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES_PATH_REFLECTION']"
		[Register ("SYSTEM_PROPERTIES_PATH_REFLECTION")]
		public const string SystemPropertiesPathReflection = (string) "system_properties_path_reflection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='SYSTEM_PROPERTIES_REFLECTION']"
		[Register ("SYSTEM_PROPERTIES_REFLECTION")]
		public const string SystemPropertiesReflection = (string) "system_properties_reflection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='THIRTY_MINUTES']"
		[Register ("THIRTY_MINUTES")]
		public const int ThirtyMinutes = (int) 1800000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='THREAD_PREFIX']"
		[Register ("THREAD_PREFIX")]
		public const string ThreadPrefix = (string) "Adjust-";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adjust.sdk']/interface[@name='Constants']/field[@name='XLARGE']"
		[Register ("XLARGE")]
		public const string Xlarge = (string) "xlarge";

	}

	[global::Android.Runtime.Register ("com/adjust/sdk/Constants", DoNotGenerateAcw=true)]
	internal partial class IConstantsInvoker : global::Java.Lang.Object, IConstants {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/adjust/sdk/Constants", typeof (IConstantsInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IConstants GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConstants> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.adjust.sdk.Constants'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConstantsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
