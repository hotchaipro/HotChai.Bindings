//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADAdNetworkResponseInfo", true)]
	public unsafe partial class AdNetworkResponseInfo : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADAdNetworkResponseInfo");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AdNetworkResponseInfo () : base (NSObjectFlag.Empty)
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
		protected AdNetworkResponseInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdNetworkResponseInfo (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AdNetworkClassName {
			[Export ("adNetworkClassName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adNetworkClassName")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adNetworkClassName")))!;
				}
			}
		}

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string AdUnitMapping
        {
            [Export("adUnitMapping")]
            get
            {
                if (IsDirectBinding)
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("adUnitMapping")))!;
                }
                else
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("adUnitMapping")))!;
                }
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string AdSourceName
        {
            [Export("adSourceName")]
            get
            {
                if (IsDirectBinding)
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("adSourceName")))!;
                }
                else
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("adSourceName")))!;
                }
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string AdSourceId
        {
            [Export("adSourceID")]
            get
            {
                if (IsDirectBinding)
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("adSourceID")))!;
                }
                else
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("adSourceID")))!;
                }
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string AdSourceInstanceName
        {
            [Export("adSourceInstanceName")]
            get
            {
                if (IsDirectBinding)
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("adSourceInstanceName")))!;
                }
                else
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("adSourceInstanceName")))!;
                }
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string AdSourceInstanceId
        {
            [Export("adSourceInstanceID")]
            get
            {
                if (IsDirectBinding)
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("adSourceInstanceID")))!;
                }
                else
                {
                    return CFString.FromHandle(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("adSourceInstanceID")))!;
                }
            }
        }

        [BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> DictionaryRepresentation {
			[Export ("dictionaryRepresentation")]
			get {
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dictionaryRepresentation")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dictionaryRepresentation")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError? Error {
			[Export ("error")]
			get {
				NSError? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("error")))!;
				} else {
					ret =  Runtime.GetNSObject<NSError> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("error")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Latency {
			[Export ("latency")]
			get {
				if (IsDirectBinding) {
					return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("latency"));
				} else {
					return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("latency"));
				}
			}
		}
	} /* class AdNetworkResponseInfo */
}
