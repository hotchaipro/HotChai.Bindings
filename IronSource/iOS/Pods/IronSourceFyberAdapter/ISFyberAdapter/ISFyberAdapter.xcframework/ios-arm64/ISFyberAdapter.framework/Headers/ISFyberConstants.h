//
//  ISFyberConstants.h
//  ISFyberAdapter
//
//  Copyright © 2021-2025 Unity Technologies. All rights reserved.
//

// Mediation keys
static NSString* const kMediationService = @"IronSource";

// Network keys
static NSString* const kAdapterVersion = FyberAdapterVersion;
static NSString* const kAdapterDomain = @"ISFyberAdapter";
static NSString* const kAdapterName = @"Fyber";
static NSString* const kAppId = @"appId";
static NSString* const kSpotId = @"adSpotId";

// Meta data flags
static NSString* const kMetaDataCOPPAKey = @"DT_COPPA";

// Fyber error codes
static NSInteger kFyberNoFillErrorCode = 204;

// init state possible values
typedef NS_ENUM(NSInteger, INIT_STATE) {
  INIT_STATE_NONE,
  INIT_STATE_IN_PROGRESS,
  INIT_STATE_SUCCESS,
  INIT_STATE_FAILED
};
