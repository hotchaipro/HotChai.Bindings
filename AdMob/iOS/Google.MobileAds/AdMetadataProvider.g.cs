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
    [Protocol (Name = "GADAdMetadataProvider", WrapperType = typeof (AdMetadataProviderWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AdMetadata", Selector = "adMetadata", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "adMetadata", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AdMetadataDelegate", Selector = "adMetadataDelegate", PropertyType = typeof (Google.MobileAds.IAdMetadataDelegate), GetterSelector = "adMetadataDelegate", SetterSelector = "setAdMetadataDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	public partial interface IAdMetadataProvider : INativeObject, IDisposable
	{
	}
	public static partial class AdMetadataProvider_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSObject> GetAdMetadata (this IAdMetadataProvider This)
		{
			return  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("adMetadata")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IAdMetadataDelegate GetAdMetadataDelegate (this IAdMetadataProvider This)
		{
			return  Runtime.GetINativeObject<IAdMetadataDelegate> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("adMetadataDelegate")), false)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAdMetadataDelegate (this IAdMetadataProvider This, IAdMetadataDelegate value)
		{
			var value__handle__ = value.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAdMetadataDelegate:"), value__handle__);
		}
	}
	internal sealed class AdMetadataProviderWrapper : BaseWrapper, IAdMetadataProvider {
		[Preserve (Conditional = true)]
		public AdMetadataProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Google.MobileAds
{
    [Protocol()]
	[Register("ApiDefinition__Google_MobileAds_AdMetadataProvider", false)]
	[Model]
	public unsafe partial class AdMetadataProvider : NSObject, IAdMetadataProvider {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AdMetadataProvider () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AdMetadataProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdMetadataProvider (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> AdMetadata {
			[Export ("adMetadata")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAdMetadataDelegate? AdMetadataDelegate {
			[Export ("adMetadataDelegate", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setAdMetadataDelegate:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class AdMetadataProvider */
}
