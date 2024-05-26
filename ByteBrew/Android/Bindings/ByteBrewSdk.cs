using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Bytebrew.Bytebrewlibrary
{
    // Metadata.xml XPath class reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']"
    [global::Android.Runtime.Register("com/bytebrew/bytebrewlibrary/ByteBrew", DoNotGenerateAcw = true)]
    public partial class ByteBrew : global::Java.Lang.Object
    {
        static readonly JniPeerMembers _members = new XAPeerMembers("com/bytebrew/bytebrewlibrary/ByteBrew", typeof(ByteBrew));

        internal static IntPtr class_ref
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected ByteBrew(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/constructor[@name='ByteBrew' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe ByteBrew() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "()V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), null);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, null);
            }
            finally
            {
            }
        }

        public static unsafe bool HasRemoteConfigsBeenSet
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='HasRemoteConfigsBeenSet' and count(parameter)=0]"
            [Register("HasRemoteConfigsBeenSet", "()Z", "")]
            get
            {
                const string __id = "HasRemoteConfigsBeenSet.()Z";
                try
                {
                    var __rm = _members.StaticMethods.InvokeBooleanMethod(__id, null);
                    return __rm;
                }
                finally
                {
                }
            }
        }

        public static unsafe string UserID
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='GetUserID' and count(parameter)=0]"
            [Register("GetUserID", "()Ljava/lang/String;", "")]
            get
            {
                const string __id = "GetUserID.()Ljava/lang/String;";
                try
                {
                    var __rm = _members.StaticMethods.InvokeObjectMethod(__id, null);
                    return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='InitializeByteBrew' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.Context']]"
        [Register("InitializeByteBrew", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", "")]
        public static unsafe void InitializeByteBrew(string appID, string appKey, string engineVersion, global::Android.Content.Context context)
        {
            const string __id = "InitializeByteBrew.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V";
            IntPtr native_appID = JNIEnv.NewString(appID);
            IntPtr native_appKey = JNIEnv.NewString(appKey);
            IntPtr native_engineVersion = JNIEnv.NewString(engineVersion);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(native_appID);
                __args[1] = new JniArgumentValue(native_appKey);
                __args[2] = new JniArgumentValue(native_engineVersion);
                __args[3] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_appID);
                JNIEnv.DeleteLocalRef(native_appKey);
                JNIEnv.DeleteLocalRef(native_engineVersion);
                global::System.GC.KeepAlive(context);
            }
        }


        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='NewCustomEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
        [Register("NewCustomEvent", "(Ljava/lang/String;)V", "")]
        public static unsafe void NewCustomEvent(string eventName)
        {
            const string __id = "NewCustomEvent.(Ljava/lang/String;)V";
            IntPtr native_eventName = JNIEnv.NewString(eventName);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_eventName);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_eventName);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='NewCustomEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
        [Register("NewCustomEvent", "(Ljava/lang/String;F)V", "")]
        public static unsafe void NewCustomEvent(string eventName, float value)
        {
            const string __id = "NewCustomEvent.(Ljava/lang/String;F)V";
            IntPtr native_eventName = JNIEnv.NewString(eventName);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_eventName);
                __args[1] = new JniArgumentValue(value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_eventName);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='NewCustomEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
        [Register("NewCustomEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
        public static unsafe void NewCustomEvent(string eventName, string value)
        {
            const string __id = "NewCustomEvent.(Ljava/lang/String;Ljava/lang/String;)V";
            IntPtr native_eventName = JNIEnv.NewString(eventName);
            IntPtr native_value = JNIEnv.NewString(value);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_eventName);
                __args[1] = new JniArgumentValue(native_value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_eventName);
                JNIEnv.DeleteLocalRef(native_value);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='NewProgressionEvent' and count(parameter)=3 and parameter[1][@type='com.bytebrew.bytebrewlibrary.ByteBrewProgressionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
        [Register("NewProgressionEvent", "(Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;Ljava/lang/String;Ljava/lang/String;)V", "")]
        public static unsafe void NewProgressionEvent(global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType progressionStatus, string environment, string stage)
        {
            const string __id = "NewProgressionEvent.(Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;Ljava/lang/String;Ljava/lang/String;)V";
            IntPtr native_environment = JNIEnv.NewString(environment);
            IntPtr native_stage = JNIEnv.NewString(stage);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((progressionStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object)progressionStatus).Handle);
                __args[1] = new JniArgumentValue(native_environment);
                __args[2] = new JniArgumentValue(native_stage);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_environment);
                JNIEnv.DeleteLocalRef(native_stage);
                global::System.GC.KeepAlive(progressionStatus);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='NewProgressionEvent' and count(parameter)=4 and parameter[1][@type='com.bytebrew.bytebrewlibrary.ByteBrewProgressionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='float']]"
        [Register("NewProgressionEvent", "(Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;Ljava/lang/String;Ljava/lang/String;F)V", "")]
        public static unsafe void NewProgressionEvent(global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType progressionStatus, string environment, string stage, float value)
        {
            const string __id = "NewProgressionEvent.(Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;Ljava/lang/String;Ljava/lang/String;F)V";
            IntPtr native_environment = JNIEnv.NewString(environment);
            IntPtr native_stage = JNIEnv.NewString(stage);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue((progressionStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object)progressionStatus).Handle);
                __args[1] = new JniArgumentValue(native_environment);
                __args[2] = new JniArgumentValue(native_stage);
                __args[3] = new JniArgumentValue(value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_environment);
                JNIEnv.DeleteLocalRef(native_stage);
                global::System.GC.KeepAlive(progressionStatus);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='NewProgressionEvent' and count(parameter)=4 and parameter[1][@type='com.bytebrew.bytebrewlibrary.ByteBrewProgressionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
        [Register("NewProgressionEvent", "(Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
        public static unsafe void NewProgressionEvent(global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType progressionStatus, string environment, string stage, string value)
        {
            const string __id = "NewProgressionEvent.(Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
            IntPtr native_environment = JNIEnv.NewString(environment);
            IntPtr native_stage = JNIEnv.NewString(stage);
            IntPtr native_value = JNIEnv.NewString(value);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue((progressionStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object)progressionStatus).Handle);
                __args[1] = new JniArgumentValue(native_environment);
                __args[2] = new JniArgumentValue(native_stage);
                __args[3] = new JniArgumentValue(native_value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_environment);
                JNIEnv.DeleteLocalRef(native_stage);
                JNIEnv.DeleteLocalRef(native_value);
                global::System.GC.KeepAlive(progressionStatus);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='RestartTracking' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
        [Register("RestartTracking", "(Landroid/content/Context;)V", "")]
        public static unsafe void RestartTracking(global::Android.Content.Context context)
        {
            const string __id = "RestartTracking.(Landroid/content/Context;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(context);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='RetrieveRemoteConfigValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
        [Register("RetrieveRemoteConfigValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
        public static unsafe string RetrieveRemoteConfigValue(string key, string defaultValue)
        {
            const string __id = "RetrieveRemoteConfigValue.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
            IntPtr native_key = JNIEnv.NewString(key);
            IntPtr native_defaultValue = JNIEnv.NewString(defaultValue);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_key);
                __args[1] = new JniArgumentValue(native_defaultValue);
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
                return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_key);
                JNIEnv.DeleteLocalRef(native_defaultValue);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='SetCustomData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
        [Register("SetCustomData", "(Ljava/lang/String;Z)V", "")]
        public static unsafe void SetCustomData(string key, bool value)
        {
            const string __id = "SetCustomData.(Ljava/lang/String;Z)V";
            IntPtr native_key = JNIEnv.NewString(key);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_key);
                __args[1] = new JniArgumentValue(value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_key);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='SetCustomData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
        [Register("SetCustomData", "(Ljava/lang/String;D)V", "")]
        public static unsafe void SetCustomData(string key, double value)
        {
            const string __id = "SetCustomData.(Ljava/lang/String;D)V";
            IntPtr native_key = JNIEnv.NewString(key);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_key);
                __args[1] = new JniArgumentValue(value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_key);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='SetCustomData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
        [Register("SetCustomData", "(Ljava/lang/String;I)V", "")]
        public static unsafe void SetCustomData(string key, int value)
        {
            const string __id = "SetCustomData.(Ljava/lang/String;I)V";
            IntPtr native_key = JNIEnv.NewString(key);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_key);
                __args[1] = new JniArgumentValue(value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_key);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='SetCustomData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
        [Register("SetCustomData", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
        public static unsafe void SetCustomData(string key, string value)
        {
            const string __id = "SetCustomData.(Ljava/lang/String;Ljava/lang/String;)V";
            IntPtr native_key = JNIEnv.NewString(key);
            IntPtr native_value = JNIEnv.NewString(value);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_key);
                __args[1] = new JniArgumentValue(native_value);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_key);
                JNIEnv.DeleteLocalRef(native_value);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='SetSDKInitialized' and count(parameter)=0]"
        [Register("SetSDKInitialized", "()V", "")]
        protected static unsafe void SetSDKInitialized()
        {
            const string __id = "SetSDKInitialized.()V";
            try
            {
                _members.StaticMethods.InvokeVoidMethod(__id, null);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='StartPushNotifications' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
        [Register("StartPushNotifications", "(Landroid/content/Context;)V", "")]
        public static unsafe void StartPushNotifications(global::Android.Content.Context context)
        {
            const string __id = "StartPushNotifications.(Landroid/content/Context;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(context);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='StopTracking' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
        [Register("StopTracking", "(Landroid/content/Context;)V", "")]
        public static unsafe void StopTracking(global::Android.Content.Context context)
        {
            const string __id = "StopTracking.(Landroid/content/Context;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(context);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='TrackGoogleInAppPurchaseEvent' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
        [Register("TrackGoogleInAppPurchaseEvent", "(Ljava/lang/String;Ljava/lang/String;FLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
        public static unsafe void TrackGoogleInAppPurchaseEvent(string store, string currency, float amount, string itemID, string category, string receipt, string signature)
        {
            const string __id = "TrackGoogleInAppPurchaseEvent.(Ljava/lang/String;Ljava/lang/String;FLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
            IntPtr native_store = JNIEnv.NewString(store);
            IntPtr native_currency = JNIEnv.NewString(currency);
            IntPtr native_itemID = JNIEnv.NewString(itemID);
            IntPtr native_category = JNIEnv.NewString(category);
            IntPtr native_receipt = JNIEnv.NewString(receipt);
            IntPtr native_signature = JNIEnv.NewString(signature);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[7];
                __args[0] = new JniArgumentValue(native_store);
                __args[1] = new JniArgumentValue(native_currency);
                __args[2] = new JniArgumentValue(amount);
                __args[3] = new JniArgumentValue(native_itemID);
                __args[4] = new JniArgumentValue(native_category);
                __args[5] = new JniArgumentValue(native_receipt);
                __args[6] = new JniArgumentValue(native_signature);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_store);
                JNIEnv.DeleteLocalRef(native_currency);
                JNIEnv.DeleteLocalRef(native_itemID);
                JNIEnv.DeleteLocalRef(native_category);
                JNIEnv.DeleteLocalRef(native_receipt);
                JNIEnv.DeleteLocalRef(native_signature);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrew']/method[@name='TrackInAppPurchaseEvent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
        [Register("TrackInAppPurchaseEvent", "(Ljava/lang/String;Ljava/lang/String;FLjava/lang/String;Ljava/lang/String;)V", "")]
        public static unsafe void TrackInAppPurchaseEvent(string store, string currency, float amount, string itemID, string category)
        {
            const string __id = "TrackInAppPurchaseEvent.(Ljava/lang/String;Ljava/lang/String;FLjava/lang/String;Ljava/lang/String;)V";
            IntPtr native_store = JNIEnv.NewString(store);
            IntPtr native_currency = JNIEnv.NewString(currency);
            IntPtr native_itemID = JNIEnv.NewString(itemID);
            IntPtr native_category = JNIEnv.NewString(category);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[5];
                __args[0] = new JniArgumentValue(native_store);
                __args[1] = new JniArgumentValue(native_currency);
                __args[2] = new JniArgumentValue(amount);
                __args[3] = new JniArgumentValue(native_itemID);
                __args[4] = new JniArgumentValue(native_category);
                _members.StaticMethods.InvokeVoidMethod(__id, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_store);
                JNIEnv.DeleteLocalRef(native_currency);
                JNIEnv.DeleteLocalRef(native_itemID);
                JNIEnv.DeleteLocalRef(native_category);
            }
        }
    }

    // Metadata.xml XPath class reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrewProgressionType']"
    [global::Android.Runtime.Register("com/bytebrew/bytebrewlibrary/ByteBrewProgressionType", DoNotGenerateAcw = true)]
    public sealed partial class ByteBrewProgressionType : global::Java.Lang.Enum
    {

        // Metadata.xml XPath field reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrewProgressionType']/field[@name='Completed']"
        [Register("Completed")]
        public static global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType Completed
        {
            get
            {
                const string __id = "Completed.Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrewProgressionType']/field[@name='Failed']"
        [Register("Failed")]
        public static global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType Failed
        {
            get
            {
                const string __id = "Failed.Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrewProgressionType']/field[@name='Started']"
        [Register("Started")]
        public static global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType Started
        {
            get
            {
                const string __id = "Started.Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
        }

        static readonly JniPeerMembers _members = new XAPeerMembers("com/bytebrew/bytebrewlibrary/ByteBrewProgressionType", typeof(ByteBrewProgressionType));

        internal static IntPtr class_ref
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        internal ByteBrewProgressionType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        //public unsafe string Name {
        //	// Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrewProgressionType']/method[@name='GetName' and count(parameter)=0]"
        //	[Register ("GetName", "()Ljava/lang/String;", "")]
        //	get {
        //		const string __id = "GetName.()Ljava/lang/String;";
        //		try {
        //			var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
        //			return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
        //		} finally {
        //		}
        //	}
        //}

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrewProgressionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
        [Register("valueOf", "(Ljava/lang/String;)Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;", "")]
        public static unsafe global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType ValueOf(string name)
        {
            const string __id = "valueOf.(Ljava/lang/String;)Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;";
            IntPtr native_name = JNIEnv.NewString(name);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_name);
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_name);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.bytebrew.bytebrewlibrary']/class[@name='ByteBrewProgressionType']/method[@name='values' and count(parameter)=0]"
        [Register("values", "()[Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;", "")]
        public static unsafe global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType[] Values()
        {
            const string __id = "values.()[Lcom/bytebrew/bytebrewlibrary/ByteBrewProgressionType;";
            try
            {
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, null);
                return (global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType[])JNIEnv.GetArray(__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof(global::Com.Bytebrew.Bytebrewlibrary.ByteBrewProgressionType));
            }
            finally
            {
            }
        }
    }
}
