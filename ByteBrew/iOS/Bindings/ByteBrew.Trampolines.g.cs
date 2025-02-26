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
namespace ByteBrew.ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::ByteBrew.FinishedRetrieval))]
		unsafe internal delegate void DFinishedRetrieval (IntPtr block, byte arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFinishedRetrieval {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::ByteBrew.FinishedRetrieval))]
			internal static unsafe void Invoke (IntPtr block, byte arg0) {
				var del = BlockLiteral.GetTarget<global::ByteBrew.FinishedRetrieval> (block);
				if (del is not null) {
					del (arg0 != 0);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::ByteBrew.FinishedRetrieval? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::ByteBrew.FinishedRetrieval callback)
			{
				delegate* unmanaged<IntPtr, byte, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDFinishedRetrieval), nameof (Invoke));
			}
		} /* class SDFinishedRetrieval */
		internal sealed class NIDFinishedRetrieval : TrampolineBlockBase {
			DFinishedRetrieval invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFinishedRetrieval (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFinishedRetrieval> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::ByteBrew.FinishedRetrieval? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::ByteBrew.FinishedRetrieval) GetExistingManagedDelegate (block);
				return del ?? new NIDFinishedRetrieval ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool arg0)
			{
				invoker (BlockPointer, arg0 ? (byte) 1 : (byte) 0);
			}
		} /* class NIDFinishedRetrieval */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::ByteBrew.FinishedValidation))]
		unsafe internal delegate void DFinishedValidation (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFinishedValidation {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::ByteBrew.FinishedValidation))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::ByteBrew.FinishedValidation> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSMutableDictionary> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::ByteBrew.FinishedValidation? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::ByteBrew.FinishedValidation callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDFinishedValidation), nameof (Invoke));
			}
		} /* class SDFinishedValidation */
		internal sealed class NIDFinishedValidation : TrampolineBlockBase {
			DFinishedValidation invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFinishedValidation (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFinishedValidation> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::ByteBrew.FinishedValidation? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::ByteBrew.FinishedValidation) GetExistingManagedDelegate (block);
				return del ?? new NIDFinishedValidation ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSMutableDictionary arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDFinishedValidation */
	}
}
