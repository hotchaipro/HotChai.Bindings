using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook", Managed="Xamarin.Facebook")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents", Managed="Xamarin.Facebook.AppEvents")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.aam", Managed="Xamarin.Facebook.AppEvents.Aam")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.codeless", Managed="Xamarin.Facebook.AppEvents.Codeless")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.codeless.internal", Managed="Xamarin.Facebook.AppEvents.Codeless.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.eventdeactivation", Managed="Xamarin.Facebook.Appevents.Eventdeactivation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.iap", Managed="Com.Facebook.Appevents.Iap")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.integrity", Managed="Xamarin.Facebook.Appevents.Integrity")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.internal", Managed="Xamarin.Facebook.AppEvents.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.ml", Managed="Xamarin.Facebook.AppEvents.ML")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.ondeviceprocessing", Managed="Xamarin.Facebook.AppEvents.OnDeviceProcessing")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.restrictivedatafilter", Managed="Xamarin.Facebook.AppEvents.RestrictiveDataFilter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.appevents.suggestedevents", Managed="Xamarin.Facebook.AppEvents.SuggestedEvents")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.bolts", Managed="Xamarin.Facebook.Bolts")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.core", Managed="Xamarin.Facebook.Core")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal", Managed="Xamarin.Facebook.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.gatekeeper", Managed="Com.Facebook.Internal.Gatekeeper")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.instrument", Managed="Xamarin.Facebook.Internal.Instrument")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.instrument.anrreport", Managed="Com.Facebook.Internal.Instrument.Anrreport")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.instrument.crashreport", Managed="Xamarin.Facebook.Internal.Instrument.CrashReport")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.instrument.crashshield", Managed="Xamarin.Facebook.Internal.Instrument.Crashshield")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.instrument.errorreport", Managed="Xamarin.Facebook.Internal.Instrument.ErrorReport")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.instrument.threadcheck", Managed="Xamarin.Facebook.Internal.Instrument.Threadcheck")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.logging.dumpsys", Managed="Com.Facebook.Internal.Logging.Dumpsys")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.qualityvalidation", Managed="Xamarin.Facebook.Internal.QualityValidation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.internal.security", Managed="Xamarin.Facebook.Internal.Security")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.login", Managed="Xamarin.Facebook.Login")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.facebook.ppml.receiver", Managed="Xamarin.Facebook.Ppml.Receiver")]

namespace Xamarin.Facebook
{
    delegate int _JniMarshal_PP_I(IntPtr jnienv, IntPtr klass);
    delegate IntPtr _JniMarshal_PP_L(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PP_V(IntPtr jnienv, IntPtr klass);
    delegate bool _JniMarshal_PP_Z(IntPtr jnienv, IntPtr klass);
    delegate bool _JniMarshal_PPIIL_Z(IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
    delegate bool _JniMarshal_PPIL_Z(IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
    delegate bool _JniMarshal_PPILLI_Z(IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3);
    delegate void _JniMarshal_PPJJ_V(IntPtr jnienv, IntPtr klass, long p0, long p1);
    delegate int _JniMarshal_PPL_I(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate IntPtr _JniMarshal_PPL_L(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPL_V(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate bool _JniMarshal_PPL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPLJJ_V(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1, long p2);
    delegate IntPtr _JniMarshal_PPLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate void _JniMarshal_PPLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate bool _JniMarshal_PPLL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate void _JniMarshal_PPLLIJ_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, long p3);
    delegate void _JniMarshal_PPLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
    delegate IntPtr _JniMarshal_PPLLLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
    delegate void _JniMarshal_PPZ_V(IntPtr jnienv, IntPtr klass, bool p0);
}
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

