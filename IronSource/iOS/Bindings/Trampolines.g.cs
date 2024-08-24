//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace IronSourceSdk.ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::IronSourceSdk.ISAInitCompletionHandler))]
		unsafe internal delegate void DISAInitCompletionHandler (IntPtr block, byte arg0, NativeHandle arg1);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDISAInitCompletionHandler {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, byte arg0, NativeHandle arg1) {
				var del = BlockLiteral.GetTarget<global::IronSourceSdk.ISAInitCompletionHandler> (block);
				if (del is not null) {
					del (arg0 != 0,  Runtime.GetNSObject<NSError> (arg1)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::IronSourceSdk.ISAInitCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::IronSourceSdk.ISAInitCompletionHandler callback)
			{
				delegate* unmanaged<IntPtr, byte, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDISAInitCompletionHandler), nameof (Invoke));
			}
		} /* class SDISAInitCompletionHandler */
		internal sealed class NIDISAInitCompletionHandler : TrampolineBlockBase {
			DISAInitCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDISAInitCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DISAInitCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::IronSourceSdk.ISAInitCompletionHandler? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::IronSourceSdk.ISAInitCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDISAInitCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool arg0, NSError? arg1)
			{
				var arg1__handle__ = arg1.GetHandle ();
				invoker (BlockPointer, arg0 ? (byte) 1 : (byte) 0, arg1__handle__);
			}
		} /* class NIDISAInitCompletionHandler */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::IronSourceSdk.LPMInitCompletionHandler))]
		unsafe internal delegate void DLPMInitCompletionHandler (IntPtr block, NativeHandle arg0, NativeHandle arg1);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDLPMInitCompletionHandler {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0, NativeHandle arg1) {
				var del = BlockLiteral.GetTarget<global::IronSourceSdk.LPMInitCompletionHandler> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<IronSourceSdk.LPMConfiguration> (arg0)!,  Runtime.GetNSObject<NSError> (arg1)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::IronSourceSdk.LPMInitCompletionHandler? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::IronSourceSdk.LPMInitCompletionHandler callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDLPMInitCompletionHandler), nameof (Invoke));
			}
		} /* class SDLPMInitCompletionHandler */
		internal sealed class NIDLPMInitCompletionHandler : TrampolineBlockBase {
			DLPMInitCompletionHandler invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDLPMInitCompletionHandler (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DLPMInitCompletionHandler> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::IronSourceSdk.LPMInitCompletionHandler? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::IronSourceSdk.LPMInitCompletionHandler) GetExistingManagedDelegate (block);
				return del ?? new NIDLPMInitCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::IronSourceSdk.LPMConfiguration? arg0, NSError? arg1)
			{
				var arg0__handle__ = arg0.GetHandle ();
				var arg1__handle__ = arg1.GetHandle ();
				invoker (BlockPointer, arg0__handle__, arg1__handle__);
			}
		} /* class NIDLPMInitCompletionHandler */
	}
}
