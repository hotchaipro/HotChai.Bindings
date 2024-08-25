using ObjCRuntime;

namespace GameAnalyticsSdk
{
	[Native]
	public enum GAResourceFlowType : long
	{
		ource = 1,
		ink = 2
	}

	[Native]
	public enum GAProgressionStatus : long
	{
		Start = 1,
		Complete = 2,
		Fail = 3
	}

	[Native]
	public enum GAErrorSeverity : long
	{
		Debug = 1,
		Info = 2,
		Warning = 3,
		Error = 4,
		Critical = 5
	}

	[Native]
	public enum GAAdAction : long
	{
		Clicked = 1,
		Show = 2,
		FailedShow = 3,
		RewardReceived = 4,
		Request = 5,
		Loaded = 6
	}

	[Native]
	public enum GAAdType : long
	{
		Video = 1,
		RewardedVideo = 2,
		Playable = 3,
		Interstitial = 4,
		OfferWall = 5,
		Banner = 6,
		AppOpen = 7
	}

	[Native]
	public enum GAAdError : long
	{
		Unknown = 1,
		Offline = 2,
		NoFill = 3,
		InternalError = 4,
		InvalidRequest = 5,
		UnableToPrecache = 6
	}
}
