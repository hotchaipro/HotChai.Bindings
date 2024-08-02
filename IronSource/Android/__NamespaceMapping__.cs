using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk", Managed="Com.IronSource.MediationSdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adapter", Managed="Com.IronSource.MediationSdk.Adapter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adquality", Managed="Com.IronSource.MediationSdk.AdQuality")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.ads.nativead", Managed="Com.IronSource.MediationSdk.Ads.NativeAd")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.ads.nativead.interfaces", Managed="Com.IronSource.MediationSdk.Ads.NativeAd.Interfaces")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.ads.nativead.internal", Managed="Com.IronSource.MediationSdk.Ads.NativeAd.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adunit.adapter", Managed="Com.IronSource.MediationSdk.AdUnit.Adapter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adunit.adapter.internal", Managed="Com.IronSource.MediationSdk.AdUnit.Adapter.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adunit.adapter.internal.listener", Managed="Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.Listener")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adunit.adapter.internal.nativead", Managed="Com.IronSource.MediationSdk.AdUnit.Adapter.Internal.NativeAd")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adunit.adapter.listener", Managed="Com.IronSource.MediationSdk.AdUnit.Adapter.Listener")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adunit.adapter.utility", Managed="Com.IronSource.MediationSdk.AdUnit.Adapter.Utility")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.adunit.data", Managed="Com.IronSource.MediationSdk.AdUnit.Data")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.bidding", Managed="Com.IronSource.MediationSdk.Bidding")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.config", Managed="Com.IronSource.MediationSdk.Config")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.demandOnly", Managed="Com.IronSource.MediationSdk.DemandOnly")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.events", Managed="Com.IronSource.MediationSdk.Events")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.impressionData", Managed="Com.IronSource.MediationSdk.ImpressionData")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.integration", Managed="Com.IronSource.MediationSdk.Integration")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.logger", Managed="Com.IronSource.MediationSdk.Logger")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.metadata", Managed="Com.IronSource.MediationSdk.Metadata")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.model", Managed="Com.IronSource.MediationSdk.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.sdk", Managed="Com.IronSource.MediationSdk.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.server", Managed="Com.IronSource.MediationSdk.Server")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.testSuite", Managed="Com.IronSource.MediationSdk.TestSuite")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.mediationsdk.utils", Managed="Com.IronSource.MediationSdk.Utils")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.sdk", Managed="Com.IronSource.Sdk")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.sdk.controller", Managed="Com.IronSource.Sdk.Controller")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.sdk.service.Connectivity", Managed="Com.IronSource.Sdk.Service.Connectivity")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ironsource.sdk.utils", Managed="Com.IronSource.Sdk.Utils")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.unity3d.ironsourceads", Managed="Com.Unity3d.IronSourceAds")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.unity3d.ironsourceads.banner", Managed="Com.Unity3d.IronSourceAds.Banner")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.unity3d.ironsourceads.interstitial", Managed="Com.Unity3d.IronSourceAds.Interstitial")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.unity3d.ironsourceads.rewarded", Managed="Com.Unity3d.IronSourceAds.Rewarded")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.unity3d.mediation", Managed="Com.Unity3d.Mediation")]
//[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.unity3d.mediation.banner", Managed="Com.Unity3d.Mediation.Banner")]

namespace Com.IronSource.MediationSdk
{
    delegate double _JniMarshal_PP_D(IntPtr jnienv, IntPtr klass);
    delegate int _JniMarshal_PP_I(IntPtr jnienv, IntPtr klass);
    delegate long _JniMarshal_PP_J(IntPtr jnienv, IntPtr klass);
    delegate IntPtr _JniMarshal_PP_L(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PP_V(IntPtr jnienv, IntPtr klass);
    delegate bool _JniMarshal_PP_Z(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PPD_V(IntPtr jnienv, IntPtr klass, double p0);
    delegate void _JniMarshal_PPF_V(IntPtr jnienv, IntPtr klass, float p0);
    delegate int _JniMarshal_PPI_I(IntPtr jnienv, IntPtr klass, int p0);
    delegate void _JniMarshal_PPI_V(IntPtr jnienv, IntPtr klass, int p0);
    delegate void _JniMarshal_PPIJ_V(IntPtr jnienv, IntPtr klass, int p0, long p1);
    delegate void _JniMarshal_PPIL_V(IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
    delegate void _JniMarshal_PPJ_V(IntPtr jnienv, IntPtr klass, long p0);
    delegate int _JniMarshal_PPL_I(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate IntPtr _JniMarshal_PPL_L(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPL_V(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate bool _JniMarshal_PPL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPLI_V(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
    delegate void _JniMarshal_PPLIL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
    delegate void _JniMarshal_PPLJ_V(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
    delegate void _JniMarshal_PPLJL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1, IntPtr p2);
    delegate IntPtr _JniMarshal_PPLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate void _JniMarshal_PPLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate void _JniMarshal_PPLLI_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
    delegate int _JniMarshal_PPLLL_I(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
    delegate void _JniMarshal_PPLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
    delegate int _JniMarshal_PPLLLL_I(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
    delegate void _JniMarshal_PPLLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
    delegate IntPtr _JniMarshal_PPLLLLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
    delegate void _JniMarshal_PPLLLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
    delegate void _JniMarshal_PPZ_V(IntPtr jnienv, IntPtr klass, bool p0);
}

