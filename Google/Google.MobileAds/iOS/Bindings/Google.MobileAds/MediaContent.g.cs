//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADMediaContent", true)]
	public unsafe partial class MediaContent : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADMediaContent");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MediaContent () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MediaContent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MediaContent (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat AspectRatio {
			[Export ("aspectRatio")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("aspectRatio"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("aspectRatio"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double CurrentTime {
			[Export ("currentTime")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("currentTime"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentTime"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Duration {
			[Export ("duration")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("duration"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasVideoContent {
			[Export ("hasVideoContent")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasVideoContent"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasVideoContent"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_MainImage_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? MainImage {
			[Export ("mainImage", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mainImage")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mainImage")))!;
				}
				MarkDirty ();
				__mt_MainImage_var = ret;
				return ret!;
			}
			[Export ("setMainImage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMainImage:"), value__handle__);
				} else {
					global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMainImage:"), value__handle__);
				}
				MarkDirty ();
				__mt_MainImage_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VideoController VideoController {
			[Export ("videoController")]
			get {
				VideoController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<VideoController> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoController")))!;
				} else {
					ret =  Runtime.GetNSObject<VideoController> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoController")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == NativeHandle.Zero) {
				__mt_MainImage_var = null;
			}
		}
	} /* class MediaContent */
}
