using System;
using System.Reflection;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreMedia;
using ObjCRuntime;
using UIKit;

namespace Facebook.ApiDefinition
{
	internal static class Messaging
	{
		internal const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";

		internal static Assembly this_assembly = typeof(Messaging).Assembly;

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend(NativeHandle receiever, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper(NativeHandle receiever, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr(NativeHandle receiever, NativeHandle selector, NativeHandle arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr(NativeHandle receiever, NativeHandle selector, NativeHandle arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool(NativeHandle receiver, NativeHandle selector, [MarshalAs(UnmanagedType.I1)] bool arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool(NativeHandle receiver, NativeHandle selector, [MarshalAs(UnmanagedType.I1)] bool arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint(NativeHandle receiver, NativeHandle selector, nuint arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint(NativeHandle receiver, NativeHandle selector, nuint arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend_stret")]
		public static extern void UIEdgeInsets_objc_msgSend_stret(out UIEdgeInsets retval, NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIEdgeInsets_objc_msgSendSuper_stret(out UIEdgeInsets retval, NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIEdgeInsets(NativeHandle receiver, NativeHandle selector, UIEdgeInsets arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIEdgeInsets(NativeHandle receiver, NativeHandle selector, UIEdgeInsets arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_bool(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, [MarshalAs(UnmanagedType.I1)] bool arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_bool(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, [MarshalAs(UnmanagedType.I1)] bool arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_bool_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, [MarshalAs(UnmanagedType.I1)] bool arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, [MarshalAs(UnmanagedType.I1)] bool arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_UIEdgeInsets(NativeHandle receiver, NativeHandle selector, nuint arg1, UIEdgeInsets arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_UIEdgeInsets(NativeHandle receiver, NativeHandle selector, nuint arg1, UIEdgeInsets arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_CGRect(NativeHandle receiver, NativeHandle selector, CGRect arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_CGRect(NativeHandle receiver, NativeHandle selector, CGRect arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_nint_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, nint arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_nint_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, nint arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_IntPtr_int_nint_IntPtr(NativeHandle receiver, NativeHandle selector, nint arg1, NativeHandle arg2, int arg3, nint arg4, NativeHandle arg5);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_IntPtr_int_nint_IntPtr(NativeHandle receiver, NativeHandle selector, nint arg1, NativeHandle arg2, int arg3, nint arg4, NativeHandle arg5);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint(NativeHandle receiver, NativeHandle selector, nint arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint(NativeHandle receiver, NativeHandle selector, nint arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, nint arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, nint arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, ref NativeHandle arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, ref NativeHandle arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSend_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSendSuper_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern float float_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern float float_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_float(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, float arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_float(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, float arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern CMTime CMTime_objc_msgSend(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern CMTime CMTime_objc_msgSendSuper(NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend_stret")]
		public static extern void CMTime_objc_msgSend_stret(out CMTime retval, NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMTime_objc_msgSendSuper_stret(out CMTime retval, NativeHandle receiver, NativeHandle selector);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float(NativeHandle receiver, NativeHandle selector, float arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float(NativeHandle receiver, NativeHandle selector, float arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTime(NativeHandle receiver, NativeHandle selector, CMTime arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTime(NativeHandle receiver, NativeHandle selector, CMTime arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, CMTime arg1, NativeHandle arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, CMTime arg1, NativeHandle arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, ref NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, ref NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSend_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nuint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSendSuper_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nuint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nuint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nuint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_nuint_nuint(NativeHandle receiver, NativeHandle selector, nuint arg1, nuint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_nuint_nuint(NativeHandle receiver, NativeHandle selector, nuint arg1, nuint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_nint_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat(NativeHandle receiver, NativeHandle selector, nfloat arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat(NativeHandle receiver, NativeHandle selector, nfloat arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_nint_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, NativeHandle arg3, nuint arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2, NativeHandle arg3, nuint arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, nuint arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, nuint arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_nint(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, nint arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_nint(NativeHandle receiver, NativeHandle selector, nint arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_nint(NativeHandle receiver, NativeHandle selector, nint arg1);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern NativeHandle IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern NativeHandle IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSend_IntPtr_bool(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, [MarshalAs(UnmanagedType.I1)] bool arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool bool_objc_msgSendSuper_IntPtr_bool(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, [MarshalAs(UnmanagedType.I1)] bool arg2);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(NativeHandle receiver, NativeHandle selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
	}
}
