//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Protocol (Name = "GADDebugOptionsViewControllerDelegate", WrapperType = typeof (DebugOptionsViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "debugOptionsViewControllerDidDismiss:", ParameterType = new Type [] { typeof (Google.MobileAds.DebugOptionsViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IDebugOptionsViewControllerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("debugOptionsViewControllerDidDismiss:")]
		[Preserve (Conditional = true)]
		void DidDismiss (DebugOptionsViewController controller);
	}
	internal sealed class DebugOptionsViewControllerDelegateWrapper : BaseWrapper, IDebugOptionsViewControllerDelegate {
		[Preserve (Conditional = true)]
		public DebugOptionsViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("debugOptionsViewControllerDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDismiss (DebugOptionsViewController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("debugOptionsViewControllerDidDismiss:"), controller__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_DebugOptionsViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class DebugOptionsViewControllerDelegate : NSObject, IDebugOptionsViewControllerDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected DebugOptionsViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected DebugOptionsViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal DebugOptionsViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("debugOptionsViewControllerDidDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DidDismiss (DebugOptionsViewController controller);
	} /* class DebugOptionsViewControllerDelegate */
}
