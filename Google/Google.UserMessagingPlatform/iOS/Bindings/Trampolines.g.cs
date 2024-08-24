//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Google.UserMessagingPlatform.ObjCRuntime
{
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines
	{
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.UserMessagingPlatform.UMPConsentFormLoadCompletionHandler))]
		unsafe internal delegate void DUMPConsentFormLoadCompletionHandler (IntPtr block, NativeHandle arg0, NativeHandle arg1);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDUMPConsentFormLoadCompletionHandler {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0, NativeHandle arg1) {
				var del = BlockLiteral.GetTarget<global::Google.UserMessagingPlatform.UMPConsentFormLoadCompletionHandler> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<Google.UserMessagingPlatform.UMPConsentForm> (arg0)!,  Runtime.GetNSObject<NSError> (arg1)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.UserMessagingPlatform.UMPConsentFormLoadCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.UserMessagingPlatform.UMPConsentFormLoadCompletionHandler callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDUMPConsentFormLoadCompletionHandler), nameof (Invoke));
			}
		} /* class SDUMPConsentFormLoadCompletionHandler */
		internal sealed class NIDUMPConsentFormLoadCompletionHandler : TrampolineBlockBase {
			DUMPConsentFormLoadCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDUMPConsentFormLoadCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DUMPConsentFormLoadCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.UserMessagingPlatform.UMPConsentFormLoadCompletionHandler? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::Google.UserMessagingPlatform.UMPConsentFormLoadCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDUMPConsentFormLoadCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::Google.UserMessagingPlatform.UMPConsentForm? arg0, NSError? arg1)
			{
				var arg0__handle__ = arg0.GetHandle ();
				var arg1__handle__ = arg1.GetHandle ();
				invoker (BlockPointer, arg0__handle__, arg1__handle__);
			}
		} /* class NIDUMPConsentFormLoadCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.UserMessagingPlatform.UMPConsentFormPresentCompletionHandler))]
		unsafe internal delegate void DUMPConsentFormPresentCompletionHandler (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDUMPConsentFormPresentCompletionHandler {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::Google.UserMessagingPlatform.UMPConsentFormPresentCompletionHandler> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSError> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.UserMessagingPlatform.UMPConsentFormPresentCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.UserMessagingPlatform.UMPConsentFormPresentCompletionHandler callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDUMPConsentFormPresentCompletionHandler), nameof (Invoke));
			}
		} /* class SDUMPConsentFormPresentCompletionHandler */
		internal sealed class NIDUMPConsentFormPresentCompletionHandler : TrampolineBlockBase {
			DUMPConsentFormPresentCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDUMPConsentFormPresentCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DUMPConsentFormPresentCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.UserMessagingPlatform.UMPConsentFormPresentCompletionHandler? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::Google.UserMessagingPlatform.UMPConsentFormPresentCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDUMPConsentFormPresentCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError? arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDUMPConsentFormPresentCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Google.UserMessagingPlatform.UMPConsentInformationUpdateCompletionHandler))]
		unsafe internal delegate void DUMPConsentInformationUpdateCompletionHandler (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDUMPConsentInformationUpdateCompletionHandler {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::Google.UserMessagingPlatform.UMPConsentInformationUpdateCompletionHandler> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSError> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::Google.UserMessagingPlatform.UMPConsentInformationUpdateCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::Google.UserMessagingPlatform.UMPConsentInformationUpdateCompletionHandler callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDUMPConsentInformationUpdateCompletionHandler), nameof (Invoke));
			}
		} /* class SDUMPConsentInformationUpdateCompletionHandler */
		internal sealed class NIDUMPConsentInformationUpdateCompletionHandler : TrampolineBlockBase {
			DUMPConsentInformationUpdateCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDUMPConsentInformationUpdateCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DUMPConsentInformationUpdateCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Google.UserMessagingPlatform.UMPConsentInformationUpdateCompletionHandler? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::Google.UserMessagingPlatform.UMPConsentInformationUpdateCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDUMPConsentInformationUpdateCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError? arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDUMPConsentInformationUpdateCompletionHandler */
	}
}
