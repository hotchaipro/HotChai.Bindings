namespace IronSourceSdk;

public unsafe partial class ISBannerSize : NSObject
{
    // NOTE: From ISBannerSize.h
    
    //static NSString* const kSizeBanner = @"BANNER";
    //static NSString* const kSizeLarge = @"LARGE";
    //static NSString* const kSizeRectangle = @"RECTANGLE";
    //static NSString* const kSizeLeaderboard = @"LEADERBOARD";
    //static NSString* const kSizeSmart = @"SMART";
    //static NSString* const kSizeCustom = @"CUSTOM";

    //#define ISBannerSize_BANNER \
    //    [[ISBannerSize alloc] initWithDescription:kSizeBanner width:320 height:50]
    //#define ISBannerSize_LARGE [[ISBannerSize alloc] initWithDescription:kSizeLarge width:320 height:90]
    //#define ISBannerSize_RECTANGLE \
    //    [[ISBannerSize alloc] initWithDescription:kSizeRectangle width:300 height:250]
    //#define ISBannerSize_SMART [[ISBannerSize alloc] initWithDescription:kSizeSmart width:0 height:0]

    public static ISBannerSize Banner => new ISBannerSize(description: @"BANNER", width: 320, height: 50);
    public static ISBannerSize Large => new ISBannerSize(description: @"LARGE", width: 320, height: 90);
    public static ISBannerSize Rectangle => new ISBannerSize(description: @"RECTANGLE", width: 300, height: 250);
    public static ISBannerSize Smart => new ISBannerSize(description: @"SMART", width: 0, height: 0);
}
