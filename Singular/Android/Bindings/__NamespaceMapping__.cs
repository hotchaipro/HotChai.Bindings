using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.singular.sdk", Managed="Com.Singular.Sdk")]

namespace Com.Singular.Sdk
{
    delegate double _JniMarshal_PP_D(IntPtr jnienv, IntPtr klass);
    delegate long _JniMarshal_PP_J(IntPtr jnienv, IntPtr klass);
    delegate IntPtr _JniMarshal_PP_L(IntPtr jnienv, IntPtr klass);
    delegate void _JniMarshal_PP_V(IntPtr jnienv, IntPtr klass);
    delegate bool _JniMarshal_PP_Z(IntPtr jnienv, IntPtr klass);
    delegate IntPtr _JniMarshal_PPI_L(IntPtr jnienv, IntPtr klass, int p0);
    delegate void _JniMarshal_PPI_V(IntPtr jnienv, IntPtr klass, int p0);
    delegate bool _JniMarshal_PPI_Z(IntPtr jnienv, IntPtr klass, int p0);
    delegate void _JniMarshal_PPILL_V(IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
    delegate bool _JniMarshal_PPILLI_Z(IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3);
    delegate IntPtr _JniMarshal_PPJ_L(IntPtr jnienv, IntPtr klass, long p0);
    delegate void _JniMarshal_PPJ_V(IntPtr jnienv, IntPtr klass, long p0);
    delegate void _JniMarshal_PPJLL_V(IntPtr jnienv, IntPtr klass, long p0, IntPtr p1, IntPtr p2);
    delegate int _JniMarshal_PPL_I(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate IntPtr _JniMarshal_PPL_L(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPL_V(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate bool _JniMarshal_PPL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0);
    delegate void _JniMarshal_PPLD_V(IntPtr jnienv, IntPtr klass, IntPtr p0, double p1);
    delegate IntPtr _JniMarshal_PPLI_L(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
    delegate void _JniMarshal_PPLI_V(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
    delegate bool _JniMarshal_PPLIL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
    delegate IntPtr _JniMarshal_PPLILI_L(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, int p3);
    delegate int _JniMarshal_PPLL_I(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate IntPtr _JniMarshal_PPLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate void _JniMarshal_PPLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate bool _JniMarshal_PPLL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
    delegate IntPtr _JniMarshal_PPLLIZ_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, bool p3);
    delegate IntPtr _JniMarshal_PPLLJ_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, long p2);
    delegate IntPtr _JniMarshal_PPLLJL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, long p2, IntPtr p3);
    delegate IntPtr _JniMarshal_PPLLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
    delegate void _JniMarshal_PPLLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
    delegate void _JniMarshal_PPLLLLL_V(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
    delegate IntPtr _JniMarshal_PPLLZ_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2);
    delegate IntPtr _JniMarshal_PPZ_L(IntPtr jnienv, IntPtr klass, bool p0);
    delegate void _JniMarshal_PPZ_V(IntPtr jnienv, IntPtr klass, bool p0);
}
