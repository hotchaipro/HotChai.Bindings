using System;
using System.ComponentModel;
using CoreFoundation;
using Facebook.ApiDefinition;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Facebook.CoreKit
{
    [Register("FBSDKApplicationDelegate", true)]
    public class ApplicationDelegate : NSObject
    {
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        private static readonly NativeHandle class_ptr = global::ObjCRuntime.Class.GetHandle("FBSDKApplicationDelegate");

        public override NativeHandle ClassHandle => class_ptr;

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static ApplicationDelegate SharedInstance
        {
            [Export("sharedInstance", ArgumentSemantic.Retain)]
            get
            {
                return Runtime.GetNSObject<ApplicationDelegate>(Messaging.IntPtr_objc_msgSend(class_ptr, Selector.GetHandle("sharedInstance")))!;
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected ApplicationDelegate(NSObjectFlag t)
            : base(t)
        {
            base.IsDirectBinding = (GetType().Assembly == Messaging.this_assembly);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected internal ApplicationDelegate(NativeHandle handle)
            : base(handle)
        {
            base.IsDirectBinding = (GetType().Assembly == Messaging.this_assembly);
        }

        [Export("application:didFinishLaunchingWithOptions:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("application:didFinishLaunchingWithOptions:"), application?.Handle ?? NativeHandle.Zero, launchOptions?.Handle ?? NativeHandle.Zero);
            }
            return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, Selector.GetHandle("application:didFinishLaunchingWithOptions:"), application?.Handle ?? NativeHandle.Zero, launchOptions?.Handle ?? NativeHandle.Zero);
        }

        [Export("application:openURL:sourceApplication:annotation:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            if (application == null)
            {
                throw new ArgumentNullException("application");
            }
            if (url == null)
            {
                throw new ArgumentNullException("url");
            }
            NativeHandle intPtr = CFString.CreateNative(sourceApplication);
            bool result = (!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, Selector.GetHandle("application:openURL:sourceApplication:annotation:"), application.Handle, url.Handle, intPtr, annotation?.Handle ?? NativeHandle.Zero) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("application:openURL:sourceApplication:annotation:"), application.Handle, url.Handle, intPtr, annotation?.Handle ?? NativeHandle.Zero);
            NSString.ReleaseNative(intPtr);
            return result;
        }

        [Export("application:openURL:options:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool OpenUrl(UIApplication application, NSUrl url, NSDictionary options)
        {
            if (application == null)
            {
                throw new ArgumentNullException("application");
            }
            if (url == null)
            {
                throw new ArgumentNullException("url");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("application:openURL:options:"), application.Handle, url.Handle, options.Handle);
            }
            return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, Selector.GetHandle("application:openURL:options:"), application.Handle, url.Handle, options.Handle);
        }
    }
}
