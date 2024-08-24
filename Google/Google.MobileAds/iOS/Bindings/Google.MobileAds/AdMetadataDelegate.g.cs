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
    [Protocol (Name = "GADAdMetadataDelegate", WrapperType = typeof (AdMetadataDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdMetadataDidChange", Selector = "adMetadataDidChange:", ParameterType = new Type [] { typeof (Google.MobileAds.AdMetadataProvider) }, ParameterByRef = new bool [] { false })]
	public partial interface IAdMetadataDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("adMetadataDidChange:")]
		[Preserve (Conditional = true)]
		void AdMetadataDidChange (AdMetadataProvider ad);
	}
	internal sealed class AdMetadataDelegateWrapper : BaseWrapper, IAdMetadataDelegate {
		[Preserve (Conditional = true)]
		public AdMetadataDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("adMetadataDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdMetadataDidChange (AdMetadataProvider ad)
		{
			var ad__handle__ = ad!.GetNonNullHandle (nameof (ad));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("adMetadataDidChange:"), ad__handle__);
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_AdMetadataDelegate", false)]
	[Model]
	public unsafe abstract partial class AdMetadataDelegate : NSObject, IAdMetadataDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AdMetadataDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AdMetadataDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdMetadataDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("adMetadataDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void AdMetadataDidChange (AdMetadataProvider ad);
	} /* class AdMetadataDelegate */
}
