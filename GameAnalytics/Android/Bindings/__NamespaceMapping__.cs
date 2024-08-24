using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk", Managed="Com.GameAnalytics.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.android", Managed="Com.GameAnalytics.Sdk.Android")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.device", Managed="Com.GameAnalytics.Sdk.Device")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.errorreporter", Managed="Com.GameAnalytics.Sdk.Errorreporter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.events", Managed="Com.GameAnalytics.Sdk.Events")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.http", Managed="Com.GameAnalytics.Sdk.Http")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.logging", Managed="Com.GameAnalytics.Sdk.Logging")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.state", Managed="Com.GameAnalytics.Sdk.State")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.store", Managed="Com.GameAnalytics.Sdk.Store")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.threading", Managed="Com.GameAnalytics.Sdk.Threading")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.utilities", Managed="Com.GameAnalytics.Sdk.Utilities")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.gameanalytics.sdk.validators", Managed="Com.GameAnalytics.Sdk.Validators")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.yahoo.memory", Managed="Com.Yahoo.Memory")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.yahoo.sketches", Managed="Com.Yahoo.Sketches")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.yahoo.sketches.quantiles", Managed="Com.Yahoo.Sketches.Quantiles")]

namespace Com.GameAnalytics.Sdk
{
    delegate double _JniMarshal_PP_D(IntPtr jnienv, IntPtr klass);
    delegate int _JniMarshal_PP_I(IntPtr jnienv, IntPtr klass);
    delegate long _JniMarshal_PP_J(IntPtr jnienv, IntPtr klass);
    delegate IntPtr _JniMarshal_PP_L(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PP_V(IntPtr jnienv, IntPtr klass);
    delegate bool _JniMarshal_PP_Z(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PPB_V(IntPtr jnienv, IntPtr klass, sbyte p0);
    delegate sbyte _JniMarshal_PPJ_B(IntPtr jnienv, IntPtr klass, long p0);
    delegate char _JniMarshal_PPJ_C(IntPtr jnienv, IntPtr klass, long p0);
    delegate double _JniMarshal_PPJ_D(IntPtr jnienv, IntPtr klass, long p0);
    delegate float _JniMarshal_PPJ_F(IntPtr jnienv, IntPtr klass, long p0);
    delegate int _JniMarshal_PPJ_I(IntPtr jnienv, IntPtr klass, long p0);
    delegate long _JniMarshal_PPJ_J(IntPtr jnienv, IntPtr klass, long p0);
    delegate IntPtr _JniMarshal_PPJ_L(IntPtr jnienv, IntPtr klass, long p0);
    delegate short _JniMarshal_PPJ_S(IntPtr jnienv, IntPtr klass, long p0);
    delegate bool _JniMarshal_PPJ_Z(IntPtr jnienv, IntPtr klass, long p0);
    delegate void _JniMarshal_PPJB_V(IntPtr jnienv, IntPtr klass, long p0, sbyte p1);
    delegate void _JniMarshal_PPJC_V(IntPtr jnienv, IntPtr klass, long p0, char p1);
    delegate void _JniMarshal_PPJD_V(IntPtr jnienv, IntPtr klass, long p0, double p1);
    delegate void _JniMarshal_PPJF_V(IntPtr jnienv, IntPtr klass, long p0, float p1);
    delegate void _JniMarshal_PPJI_V(IntPtr jnienv, IntPtr klass, long p0, int p1);
    delegate IntPtr _JniMarshal_PPJJ_L(IntPtr jnienv, IntPtr klass, long p0, long p1);
    delegate void _JniMarshal_PPJJ_V(IntPtr jnienv, IntPtr klass, long p0, long p1);
    delegate void _JniMarshal_PPJJB_V(IntPtr jnienv, IntPtr klass, long p0, long p1, sbyte p2);
    delegate int _JniMarshal_PPJJLJJ_I(IntPtr jnienv, IntPtr klass, long p0, long p1, IntPtr p2, long p3, long p4);
    delegate void _JniMarshal_PPJLII_V(IntPtr jnienv, IntPtr klass, long p0, IntPtr p1, int p2, int p3);
    delegate void _JniMarshal_PPJLJJ_V(IntPtr jnienv, IntPtr klass, long p0, IntPtr p1, long p2, long p3);
    delegate void _JniMarshal_PPJS_V(IntPtr jnienv, IntPtr klass, long p0, short p1);
    delegate void _JniMarshal_PPJZ_V(IntPtr jnienv, IntPtr klass, long p0, bool p1);
    delegate long _JniMarshal_PPL_J(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate IntPtr _JniMarshal_PPL_L(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPL_V(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate bool _JniMarshal_PPL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate IntPtr _JniMarshal_PPLI_L(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
    delegate void _JniMarshal_PPLI_V(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
    delegate IntPtr _JniMarshal_PPLJI_L(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1, int p2);
    delegate void _JniMarshal_PPLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate void _JniMarshal_PPLLLLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5);
    delegate void _JniMarshal_PPLLLLLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6);
    delegate IntPtr _JniMarshal_PPLZ_L(IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
}
