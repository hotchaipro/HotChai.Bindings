//
//  ISVungleAdapter.h
//  ISVungleAdapter
//
//  Copyright © 2024 ironSource Mobile Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <IronSource/ISBaseAdapter+Internal.h>

static NSString * const VungleAdapterVersion = @"4.3.43";
static NSString * Githash = @"f0a114a";

//System Frameworks For Vungle Adapter

@import AdSupport;
@import AudioToolbox;
@import AVFoundation;
@import CFNetwork;
@import CoreGraphics;
@import CoreMedia;
@import Foundation;
@import MediaPlayer;
@import QuartzCore;
@import StoreKit;
@import SystemConfiguration;
@import UIKit;
@import WebKit;

@interface ISVungleAdapter : ISBaseAdapter

@end
