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
    [Protocol (Name = "GADAdNetworkExtras", WrapperType = typeof (AdNetworkExtrasWrapper))]
	public partial interface IAdNetworkExtras : INativeObject, IDisposable
	{
	}
	internal sealed class AdNetworkExtrasWrapper : BaseWrapper, IAdNetworkExtras {
		[Preserve (Conditional = true)]
		public AdNetworkExtrasWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_AdNetworkExtras", false)]
	[Model]
	public unsafe partial class AdNetworkExtras : NSObject, IAdNetworkExtras {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AdNetworkExtras () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AdNetworkExtras (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdNetworkExtras (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

	} /* class AdNetworkExtras */
}
