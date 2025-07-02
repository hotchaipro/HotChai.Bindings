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

    public static class Attributes
    {
        public static readonly NSString FROM_DATE = new NSString(@"sng_attr_from_date");
        public static readonly NSString TO_DATE = new NSString(@"sng_attr_to_date");
        public static readonly NSString ACHIEVEMENT_ID = new NSString(@"sng_attr_achievement_id");
        public static readonly NSString CONTENT = new NSString(@"sng_attr_content");
        public static readonly NSString CONTENT_ID = new NSString(@"sng_attr_content_id");
        public static readonly NSString CONTENT_LIST = new NSString(@"sng_attr_content_list");
        public static readonly NSString CONTENT_TYPE = new NSString(@"sng_attr_content_type");
        public static readonly NSString COUPON_CODE = new NSString(@"sng_attr_coupon_code");
        public static readonly NSString DEEP_LINK = new NSString(@"sng_attr_deep_link");
        public static readonly NSString EVENT_END = new NSString(@"sng_attr_event_end");
        public static readonly NSString EVENT_START = new NSString(@"sng_attr_event_start");
        public static readonly NSString HOTEL_SCORE = new NSString(@"sng_attr_hotel_score");
        public static readonly NSString ITEM_DESCRIPTION = new NSString(@"sng_attr_item_description");
        public static readonly NSString ITEM_PRICE = new NSString(@"sng_attr_item_price");
        public static readonly NSString LEVEL = new NSString(@"sng_attr_level");
        public static readonly NSString COUNTRY = new NSString(@"sng_attr_country");
        public static readonly NSString REGION = new NSString(@"sng_attr_region");
        public static readonly NSString MAX = new NSString(@"sng_attr_max");
        public static readonly NSString NEW_VERSION = new NSString(@"sng_attr_new_version");
        public static readonly NSString ORIGIN = new NSString(@"sng_attr_origin");
        public static readonly NSString PAYMENT_INFO_AVAILABLE = new NSString(@"sng_attr_payment_info_available");
        public static readonly NSString QUANTITY = new NSString(@"sng_attr_quantity");
        public static readonly NSString RATING = new NSString(@"sng_attr_rating");
        public static readonly NSString REGISTRATION_METHOD = new NSString(@"sng_attr_registration_method");
        public static readonly NSString REVIEW_TEXT = new NSString(@"sng_attr_review_text");
        public static readonly NSString SCORE = new NSString(@"sng_attr_score");
        public static readonly NSString SEARCH_STRING = new NSString(@"sng_attr_search_string");
        public static readonly NSString SUBSCRIPTION_ID = new NSString(@"sng_attr_subscription_id");
        public static readonly NSString SUCCESS = new NSString(@"sng_attr_success");
        public static readonly NSString TRANSACTION_ID = new NSString(@"sng_attr_transaction_id");
        public static readonly NSString TUTORIAL_ID = new NSString(@"sng_attr_tutorial_id");
        public static readonly NSString VALID = new NSString(@"sng_attr_valid");
    }
}
