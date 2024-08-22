using System;
using Foundation;

namespace SingularSDK
{
    public static class Events
    {
        public static readonly NSString RATE = new NSString(@"sng_rate");
        public static readonly NSString SPENT_CREDITS = new NSString(@"sng_spent_credits");
        public static readonly NSString TUTORIAL_COMPLETE = new NSString(@"sng_tutorial_complete");
        public static readonly NSString LOGIN = new NSString(@"sng_login");
        public static readonly NSString START_TRIAL = new NSString(@"sng_start_trial");
        public static readonly NSString SUBSCRIBE = new NSString(@"sng_subscribe");
        public static readonly NSString BOOK = new NSString(@"sng_book");
        public static readonly NSString CONTENT_VIEW_LIST = new NSString(@"sng_content_view_list");
        public static readonly NSString INVITE = new NSString(@"sng_invite");
        public static readonly NSString SHARE = new NSString(@"sng_share");
        public static readonly NSString SUBMIT_APPLICATION = new NSString(@"sng_submit_application");
        public static readonly NSString UPDATE = new NSString(@"sng_update");
        public static readonly NSString ECOMMERCE_PURCHASE = new NSString(@"sng_ecommerce_purchase");
        public static readonly NSString VIEW_CART = new NSString(@"sng_view_cart");
        public static readonly NSString ACHIEVEMENT_UNLOCKED = new NSString(@"sng_achievement_unlocked");
        public static readonly NSString ADD_PAYMENT_INFO = new NSString(@"sng_add_payment_info");
        public static readonly NSString ADD_TO_CART = new NSString(@"sng_add_to_cart");
        public static readonly NSString ADD_TO_WISHLIST = new NSString(@"sng_add_to_wishlist");
        public static readonly NSString CHECKOUT_INITIATED = new NSString(@"sng_checkout_initiated");
        public static readonly NSString COMPLETE_REGISTRATION = new NSString(@"sng_complete_registration");
        public static readonly NSString CONTENT_VIEW = new NSString(@"sng_content_view");
        public static readonly NSString LEVEL_ACHIEVED = new NSString(@"sng_level_achieved");
        public static readonly NSString SEARCH = new NSString(@"sng_search");
    }
}
