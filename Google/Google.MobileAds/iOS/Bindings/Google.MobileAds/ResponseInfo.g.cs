//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Libraries = Google.MobileAds.ObjCRuntime.Libraries;

#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    [Register("GADResponseInfo", true)]
	public unsafe partial class ResponseInfo : NSObject
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GADResponseInfo");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ResponseInfo () : base (NSObjectFlag.Empty)
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
		protected ResponseInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ResponseInfo (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::Google.MobileAds.ObjCRuntime.Messaging.this_assembly;
		}

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual AdNetworkResponseInfo LoadedAdNetworkInfo
        {
            [Export("loadedAdNetworkResponseInfo")]
            get
            {
                AdNetworkResponseInfo? ret;
                if (IsDirectBinding)
                {
                    ret = Runtime.GetNSObject<AdNetworkResponseInfo>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("loadedAdNetworkResponseInfo")))!;
                }
                else
                {
                    ret = Runtime.GetNSObject<AdNetworkResponseInfo>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("loadedAdNetworkResponseInfo")))!;
                }
                return ret!;
            }
        }

        [BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AdNetworkResponseInfo[] AdNetworkInfoArray {
			[Export ("adNetworkInfoArray")]
			get {
				AdNetworkResponseInfo[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AdNetworkResponseInfo>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adNetworkInfoArray")))!;
				} else {
					ret = CFArray.ArrayFromHandle<AdNetworkResponseInfo>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adNetworkInfoArray")))!;
				}
				return ret!;
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
		public virtual string? ResponseIdentifier {
			[Export ("responseIdentifier")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseIdentifier")))!;
				} else {
					return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseIdentifier")))!;
				}
			}
		}
	} /* class ResponseInfo */
}
