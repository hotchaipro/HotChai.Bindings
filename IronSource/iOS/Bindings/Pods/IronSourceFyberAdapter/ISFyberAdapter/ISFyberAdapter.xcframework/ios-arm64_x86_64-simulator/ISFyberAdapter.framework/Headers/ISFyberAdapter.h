//
//  ISFyberAdapter.h
//  ISFyberAdapter
//
//  Copyright © 2023 ironSource Mobile Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <IronSource/ISBaseAdapter+Internal.h>

static NSString * const FyberAdapterVersion = @"4.3.41";
static NSString * Githash = @"d4d60f7";

//System Frameworks For Fyber Adapter

@import AdSupport;
@import AVFoundation;
@import CoreGraphics;
@import CoreMedia;
@import CoreTelephony;
@import MediaPlayer;
@import StoreKit;
@import SystemConfiguration;
@import WebKit;

@interface ISFyberAdapter : ISBaseAdapter

@end

