using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.adjust.sdk", Managed="Com.Adjust.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.adjust.sdk.network", Managed="Com.Adjust.Sdk.Network")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.adjust.sdk.scheduler", Managed="Com.Adjust.Sdk.Scheduler")]

namespace Com.Adjust.Sdk
{
    delegate double _JniMarshal_PP_D(IntPtr jnienv, IntPtr klass);
    delegate int _JniMarshal_PP_I(IntPtr jnienv, IntPtr klass);
    delegate long _JniMarshal_PP_J(IntPtr jnienv, IntPtr klass);
    delegate IntPtr _JniMarshal_PP_L(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PP_V(IntPtr jnienv, IntPtr klass);
    delegate bool _JniMarshal_PP_Z(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PPD_V(IntPtr jnienv, IntPtr klass, double p0);
    delegate void _JniMarshal_PPDL_V(IntPtr jnienv, IntPtr klass, double p0, IntPtr p1);
    delegate void _JniMarshal_PPI_V(IntPtr jnienv, IntPtr klass, int p0);
    delegate void _JniMarshal_PPJ_V(IntPtr jnienv, IntPtr klass, long p0);
    delegate void _JniMarshal_PPJJJJJ_V(IntPtr jnienv, IntPtr klass, long p0, long p1, long p2, long p3, long p4);
    delegate IntPtr _JniMarshal_PPL_L(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPL_V(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate bool _JniMarshal_PPL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate IntPtr _JniMarshal_PPLJ_L(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
    delegate void _JniMarshal_PPLJ_V(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
    delegate IntPtr _JniMarshal_PPLJJ_L(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1, long p2);
    delegate void _JniMarshal_PPLJL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, long p1, IntPtr p2);
    delegate IntPtr _JniMarshal_PPLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate void _JniMarshal_PPLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate IntPtr _JniMarshal_PPLLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
    delegate void _JniMarshal_PPLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
    delegate void _JniMarshal_PPLLZ_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2);
    delegate void _JniMarshal_PPLLZL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2, IntPtr p3);
    delegate IntPtr _JniMarshal_PPLZ_L(IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
    delegate void _JniMarshal_PPLZ_V(IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
    delegate void _JniMarshal_PPLZL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, IntPtr p2);
    delegate IntPtr _JniMarshal_PPZ_L(IntPtr jnienv, IntPtr klass, bool p0);
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

