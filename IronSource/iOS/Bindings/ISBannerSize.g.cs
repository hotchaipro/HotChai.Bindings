//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using CoreFoundation;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace IronSourceSdk
{
	[Register("ISBannerSize", true)]
	public unsafe partial class ISBannerSize : NSObject
	{
		// #define ISBannerSize_BANNER [[ISBannerSize alloc] initWithDescription: kSizeBanner width:320 height: 50]
		public static ISBannerSize Banner
		{
			get
			{
				return new ISBannerSize(@"BANNER", width: 320, height: 50);
			}
		}

        // #define ISBannerSize_LARGE [[ISBannerSize alloc] initWithDescription:kSizeLarge width:320 height:90]
        public static ISBannerSize Large
        {
            get
            {
                return new ISBannerSize(@"LARGE", width: 320, height: 90);
            }
        }

		// #define ISBannerSize_RECTANGLE [[ISBannerSize alloc] initWithDescription: kSizeRectangle width:300 height: 250]
        public static ISBannerSize Rectangle
        {
            get
            {
                return new ISBannerSize(@"RECTANGLE", width: 300, height: 250);
            }
        }

        // #define ISBannerSize_LEADERBOARD [[ISBannerSize alloc] initWithDescription:kSizeLeaderboard width:728 height:90]
        public static ISBannerSize Leaderboard
        {
            get
            {
                return new ISBannerSize(@"LEADERBOARD", width: 728, height: 90);
            }
        }

		// #define ISBannerSize_SMART [[ISBannerSize alloc] initWithDescription:kSizeSmart width:0 height:0]
        public static ISBannerSize Smart
        {
            get
            {
                return new ISBannerSize(@"SMART", width: 0, height: 0);
            }
        }


		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ISBannerSize");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ISBannerSize () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ISBannerSize (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ISBannerSize (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithWidth:andHeight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISBannerSize (nint width, nint height)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithWidth:andHeight:"), width, height), "initWithWidth:andHeight:");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithWidth:andHeight:"), width, height), "initWithWidth:andHeight:");
			}
		}
		[Export ("initWithDescription:width:height:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISBannerSize (string description, nint width, nint height)
			: base (NSObjectFlag.Empty)
		{
			if (description is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (description));
			var nsdescription = CFString.CreateNative (description);
			IsDirectBinding = GetType ().Assembly == global::IronSourceSdk.ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDescription:width:height:"), nsdescription, width, height), "initWithDescription:width:height:");
			} else {
				InitializeHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDescription:width:height:"), nsdescription, width, height), "initWithDescription:width:height:");
			}
			CFString.ReleaseNative (nsdescription);
		}
		[Export ("getMaximalAdaptiveHeightWithWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetMaximalAdaptiveHeightWithWidth (nfloat width)
		{
			return global::IronSourceSdk.ApiDefinitions.Messaging.nfloat_objc_msgSend_nfloat (class_ptr, Selector.GetHandle ("getMaximalAdaptiveHeightWithWidth:"), width);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Adaptive {
			[Export ("isAdaptive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAdaptive"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAdaptive"));
				}
				return ret != 0;
			}
			[Export ("setAdaptive:")]
			set {
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdaptive:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAdaptive:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ContainerParams_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ISContainerParams ContainerParams {
			[Export ("containerParams", ArgumentSemantic.Assign)]
			get {
				ISContainerParams? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ISContainerParams> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("containerParams")))!;
				} else {
					ret =  Runtime.GetNSObject<ISContainerParams> (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("containerParams")))!;
				}
				MarkDirty ();
				__mt_ContainerParams_var = ret;
				return ret!;
			}
			[Export ("setContainerParams:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setContainerParams:"), value__handle__);
				} else {
					global::IronSourceSdk.ApiDefinitions.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setContainerParams:"), value__handle__);
				}
				MarkDirty ();
				__mt_ContainerParams_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Height {
			[Export ("height")]
			get {
				if (IsDirectBinding) {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("height"));
				} else {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("height"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSmart {
			[Export ("isSmart")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSmart"));
				} else {
					ret = global::IronSourceSdk.ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSmart"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SizeDescription {
			[Export ("sizeDescription")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sizeDescription")))!;
				} else {
					return CFString.FromHandle (global::IronSourceSdk.ApiDefinitions.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sizeDescription")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Width {
			[Export ("width")]
			get {
				if (IsDirectBinding) {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("width"));
				} else {
					return global::IronSourceSdk.ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("width"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContainerParams_var = null;
			}
		}
	} /* class ISBannerSize */
}
