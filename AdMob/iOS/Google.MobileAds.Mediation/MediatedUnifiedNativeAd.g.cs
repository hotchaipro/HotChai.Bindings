//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Google.MobileAds.Mediation {
	[Protocol (Name = "GADMediatedUnifiedNativeAd", WrapperType = typeof (MediatedUnifiedNativeAdWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAdChoicesView", Selector = "adChoicesView", ReturnType = typeof (UIView))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMediaView", Selector = "mediaView", ReturnType = typeof (UIView))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasVideoContent", Selector = "hasVideoContent", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMediaContentAspectRatio", Selector = "mediaContentAspectRatio", ReturnType = typeof (nfloat))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDuration", Selector = "duration", ReturnType = typeof (double))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCurrentTime", Selector = "currentTime", ReturnType = typeof (double))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRenderInView", Selector = "didRenderInView:clickableAssetViews:nonclickableAssetViews:viewController:", ParameterType = new Type [] { typeof (UIView), typeof (global::Foundation.NSDictionary<NSString, global::UIKit.UIView>), typeof (global::Foundation.NSDictionary<NSString, global::UIKit.UIView>), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordImpression", Selector = "didRecordImpression")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRecordClick", Selector = "didRecordClickOnAssetWithName:view:viewController:", ParameterType = new Type [] { typeof (string), typeof (UIView), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUntrackView", Selector = "didUntrackView:", ParameterType = new Type [] { typeof (UIView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Headline", Selector = "headline", PropertyType = typeof (string), GetterSelector = "headline", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Images", Selector = "images", PropertyType = typeof (Google.MobileAds.NativeAdImage[]), GetterSelector = "images", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Body", Selector = "body", PropertyType = typeof (string), GetterSelector = "body", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Icon", Selector = "icon", PropertyType = typeof (Google.MobileAds.NativeAdImage), GetterSelector = "icon", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CallToAction", Selector = "callToAction", PropertyType = typeof (string), GetterSelector = "callToAction", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StarRating", Selector = "starRating", PropertyType = typeof (NSDecimalNumber), GetterSelector = "starRating", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Store", Selector = "store", PropertyType = typeof (string), GetterSelector = "store", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Price", Selector = "price", PropertyType = typeof (string), GetterSelector = "price", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Advertiser", Selector = "advertiser", PropertyType = typeof (string), GetterSelector = "advertiser", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ExtraAssets", Selector = "extraAssets", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "extraAssets", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IMediatedUnifiedNativeAd : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		string? Headline {
			[Export ("headline")]
			get;
		}
		[Preserve (Conditional = true)]
		global::Google.MobileAds.NativeAdImage[]? Images {
			[Export ("images")]
			get;
		}
		[Preserve (Conditional = true)]
		string? Body {
			[Export ("body")]
			get;
		}
		[Preserve (Conditional = true)]
		global::Google.MobileAds.NativeAdImage? Icon {
			[Export ("icon")]
			get;
		}
		[Preserve (Conditional = true)]
		string? CallToAction {
			[Export ("callToAction")]
			get;
		}
		[Preserve (Conditional = true)]
		NSDecimalNumber? StarRating {
			[Export ("starRating", ArgumentSemantic.Copy)]
			get;
		}
		[Preserve (Conditional = true)]
		string? Store {
			[Export ("store")]
			get;
		}
		[Preserve (Conditional = true)]
		string? Price {
			[Export ("price")]
			get;
		}
		[Preserve (Conditional = true)]
		string? Advertiser {
			[Export ("advertiser")]
			get;
		}
		[Preserve (Conditional = true)]
		NSDictionary<NSString, NSObject>? ExtraAssets {
			[Export ("extraAssets", ArgumentSemantic.Copy)]
			get;
		}
	}
	public static partial class MediatedUnifiedNativeAd_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView? GetAdChoicesView (this IMediatedUnifiedNativeAd This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("adChoicesView")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView? GetMediaView (this IMediatedUnifiedNativeAd This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIView> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mediaView")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasVideoContent (this IMediatedUnifiedNativeAd This)
		{
			return global::Google.MobileAds.ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasVideoContent"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetMediaContentAspectRatio (this IMediatedUnifiedNativeAd This)
		{
			return global::Google.MobileAds.ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("mediaContentAspectRatio"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetDuration (this IMediatedUnifiedNativeAd This)
		{
			return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("duration"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetCurrentTime (this IMediatedUnifiedNativeAd This)
		{
			return global::Google.MobileAds.ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("currentTime"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRenderInView (this IMediatedUnifiedNativeAd This, global::UIKit.UIView view, NSDictionary<NSString, global::UIKit.UIView> clickableAssetViews, NSDictionary<NSString, global::UIKit.UIView> nonclickableAssetViews, global::UIKit.UIViewController viewController)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var clickableAssetViews__handle__ = clickableAssetViews!.GetNonNullHandle (nameof (clickableAssetViews));
			var nonclickableAssetViews__handle__ = nonclickableAssetViews!.GetNonNullHandle (nameof (nonclickableAssetViews));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didRenderInView:clickableAssetViews:nonclickableAssetViews:viewController:"), view__handle__, clickableAssetViews__handle__, nonclickableAssetViews__handle__, viewController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordImpression (this IMediatedUnifiedNativeAd This)
		{
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didRecordImpression"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRecordClick (this IMediatedUnifiedNativeAd This, string assetName, global::UIKit.UIView view, global::UIKit.UIViewController viewController)
		{
			if (assetName is null)
				ThrowHelper.ThrowArgumentNullException (nameof (assetName));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var nsassetName = CFString.CreateNative (assetName);
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didRecordClickOnAssetWithName:view:viewController:"), nsassetName, view__handle__, viewController__handle__);
			CFString.ReleaseNative (nsassetName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUntrackView (this IMediatedUnifiedNativeAd This, global::UIKit.UIView? view)
		{
			var view__handle__ = view.GetHandle ();
			global::Google.MobileAds.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didUntrackView:"), view__handle__);
		}
	}
	internal sealed class MediatedUnifiedNativeAdWrapper : BaseWrapper, IMediatedUnifiedNativeAd {
		[Preserve (Conditional = true)]
		public MediatedUnifiedNativeAdWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Headline {
			[Export ("headline")]
			get {
				return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("headline")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Google.MobileAds.NativeAdImage[]? Images {
			[Export ("images")]
			get {
				return CFArray.ArrayFromHandle<global::Google.MobileAds.NativeAdImage>(global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("images")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Body {
			[Export ("body")]
			get {
				return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("body")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::Google.MobileAds.NativeAdImage? Icon {
			[Export ("icon")]
			get {
				return  Runtime.GetNSObject<global::Google.MobileAds.NativeAdImage> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("icon")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? CallToAction {
			[Export ("callToAction")]
			get {
				return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("callToAction")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDecimalNumber? StarRating {
			[Export ("starRating", ArgumentSemantic.Copy)]
			get {
				return  Runtime.GetNSObject<NSDecimalNumber> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("starRating")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Store {
			[Export ("store")]
			get {
				return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("store")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Price {
			[Export ("price")]
			get {
				return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("price")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Advertiser {
			[Export ("advertiser")]
			get {
				return CFString.FromHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("advertiser")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject>? ExtraAssets {
			[Export ("extraAssets", ArgumentSemantic.Copy)]
			get {
				return  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("extraAssets")))!;
			}
		}
	}
}
namespace Google.MobileAds.Mediation {
	[Protocol()]
	[Register("ApiDefinition__Google_MobileAds_Mediation_MediatedUnifiedNativeAd", false)]
	[Model]
	public unsafe abstract partial class MediatedUnifiedNativeAd : NSObject, IMediatedUnifiedNativeAd {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MediatedUnifiedNativeAd () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::Google.MobileAds.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MediatedUnifiedNativeAd (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MediatedUnifiedNativeAd (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didRecordClickOnAssetWithName:view:viewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordClick (string assetName, global::UIKit.UIView view, global::UIKit.UIViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didRecordImpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRecordImpression ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didRenderInView:clickableAssetViews:nonclickableAssetViews:viewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRenderInView (global::UIKit.UIView view, NSDictionary<NSString, global::UIKit.UIView> clickableAssetViews, NSDictionary<NSString, global::UIKit.UIView> nonclickableAssetViews, global::UIKit.UIViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didUntrackView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUntrackView (global::UIKit.UIView? view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("adChoicesView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? GetAdChoicesView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("currentTime")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetCurrentTime ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("duration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetDuration ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mediaContentAspectRatio")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetMediaContentAspectRatio ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("mediaView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? GetMediaView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("hasVideoContent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasVideoContent ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract string? Advertiser {
			[Export ("advertiser")]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract string? Body {
			[Export ("body")]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract string? CallToAction {
			[Export ("callToAction")]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract NSDictionary<NSString, NSObject>? ExtraAssets {
			[Export ("extraAssets", ArgumentSemantic.Copy)]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract string? Headline {
			[Export ("headline")]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::Google.MobileAds.NativeAdImage? Icon {
			[Export ("icon")]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::Google.MobileAds.NativeAdImage[]? Images {
			[Export ("images")]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract string? Price {
			[Export ("price")]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract NSDecimalNumber? StarRating {
			[Export ("starRating", ArgumentSemantic.Copy)]
			get; 
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract string? Store {
			[Export ("store")]
			get; 
		}
	} /* class MediatedUnifiedNativeAd */
}
