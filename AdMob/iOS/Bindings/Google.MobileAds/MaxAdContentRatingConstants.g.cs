//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using Foundation;
using ObjCRuntime;
using Trampolines = Google.MobileAds.ObjCRuntime.Trampolines;
using Libraries = Google.MobileAds.ObjCRuntime.Libraries;
#nullable enable
#if !NET
using NativeHandle = System.NativeHandle;
#endif
namespace Google.MobileAds
{
    public unsafe static partial class MaxAdContentRatingConstants  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _General;
		[Field ("GADMaxAdContentRatingGeneral",  "__Internal")]
		public static NSString General {
			get {
				if (_General is null)
					_General = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "GADMaxAdContentRatingGeneral")!;
				return _General;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MatureAudience;
		[Field ("GADMaxAdContentRatingMatureAudience",  "__Internal")]
		public static NSString MatureAudience {
			get {
				if (_MatureAudience is null)
					_MatureAudience = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "GADMaxAdContentRatingMatureAudience")!;
				return _MatureAudience;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentalGuidance;
		[Field ("GADMaxAdContentRatingParentalGuidance",  "__Internal")]
		public static NSString ParentalGuidance {
			get {
				if (_ParentalGuidance is null)
					_ParentalGuidance = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "GADMaxAdContentRatingParentalGuidance")!;
				return _ParentalGuidance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Teen;
		[Field ("GADMaxAdContentRatingTeen",  "__Internal")]
		public static NSString Teen {
			get {
				if (_Teen is null)
					_Teen = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "GADMaxAdContentRatingTeen")!;
				return _Teen;
			}
		}
	} /* class MaxAdContentRatingConstants */
}
