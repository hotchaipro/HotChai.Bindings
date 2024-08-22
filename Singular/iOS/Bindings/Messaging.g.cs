#pragma warning disable 414
using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace SingularSDK.ApiDefinitions
{
    static partial class Messaging
    {
        internal const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";
        static internal System.Reflection.Assembly this_assembly = typeof(Messaging).Assembly;
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public extern static IntPtr IntPtr_objc_msgSend(IntPtr receiever, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public extern static IntPtr IntPtr_objc_msgSendSuper(IntPtr receiever, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public extern static IntPtr IntPtr_objc_msgSend_IntPtr(IntPtr receiever, IntPtr selector, IntPtr arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr(IntPtr receiever, IntPtr selector, IntPtr arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSend(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static double Double_objc_msgSend(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static double Double_objc_msgSendSuper(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static int int_objc_msgSend(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static int int_objc_msgSendSuper(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, nint arg5);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, nint arg5);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, nint arg5, NativeHandle arg6);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, nint arg5, NativeHandle arg6);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper(IntPtr receiver, IntPtr selector);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, nint arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, nint arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static int int_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static int int_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_bool(IntPtr receiver, IntPtr selector, byte arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_bool(IntPtr receiver, IntPtr selector, byte arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, nint arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, nint arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, nint arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, nint arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_Double_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2, NativeHandle arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_Double_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2, NativeHandle arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_int_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5, int arg6, double arg7);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_int_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, double arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5, int arg6, double arg7);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3, NativeHandle arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_Double_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3, NativeHandle arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_int_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3, NativeHandle arg4, NativeHandle arg5, NativeHandle arg6, int arg7, double arg8);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_int_Double(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, double arg3, NativeHandle arg4, NativeHandle arg5, NativeHandle arg6, int arg7, double arg8);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle_bool(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle_bool(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static byte bool_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, nint arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static byte bool_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, nint arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, nint arg1, nint arg2, byte arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, nint arg1, nint arg2, byte arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, nint arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, nint arg1);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_bool(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_bool(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, NativeHandle arg4);
        [DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
        public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool_NativeHandle(IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3, NativeHandle arg4);
    }
}
