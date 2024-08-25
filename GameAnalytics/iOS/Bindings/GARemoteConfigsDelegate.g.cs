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
using NativeHandle = System.IntPtr;
#endif
namespace GameAnalyticsSdk
{
    [Protocol (Name = "GARemoteConfigsDelegate", WrapperType = typeof (GARemoteConfigsDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnRemoteConfigsUpdated", Selector = "onRemoteConfigsUpdated")]
	public partial interface IGARemoteConfigsDelegate : INativeObject, IDisposable
	{
	}
	public unsafe static partial class GARemoteConfigsDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnRemoteConfigsUpdated (this IGARemoteConfigsDelegate This)
		{
			ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onRemoteConfigsUpdated"));
		}
	}
	internal unsafe sealed class GARemoteConfigsDelegateWrapper : BaseWrapper, IGARemoteConfigsDelegate {
		[Preserve (Conditional = true)]
		public GARemoteConfigsDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace GameAnalyticsSdk
{
    [Protocol()]
	[Register("ApiDefinitions__GameAnalyticsSdk_GARemoteConfigsDelegate", false)]
	[Model]
	public unsafe partial class GARemoteConfigsDelegate : NSObject, IGARemoteConfigsDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GARemoteConfigsDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected GARemoteConfigsDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GARemoteConfigsDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onRemoteConfigsUpdated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnRemoteConfigsUpdated ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GARemoteConfigsDelegate */
}
