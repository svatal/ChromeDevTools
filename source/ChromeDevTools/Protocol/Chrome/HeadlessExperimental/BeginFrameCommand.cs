using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a screenshot from the resulting frame. Requires that the target was created with enabled BeginFrameControl.
	/// </summary>
	[Command(ProtocolName.HeadlessExperimental.BeginFrame)]
	[SupportedBy("Chrome")]
	public class BeginFrameCommand: ICommand<BeginFrameCommandResponse>
	{
		/// <summary>
		/// Gets or sets Timestamp of this BeginFrame (milliseconds since epoch). If not set, the current time will be used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double FrameTime { get; set; }
		/// <summary>
		/// Gets or sets Deadline of this BeginFrame (milliseconds since epoch). If not set, the deadline will be calculated from the frameTime and interval.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Deadline { get; set; }
		/// <summary>
		/// Gets or sets The interval between BeginFrames that is reported to the compositor, in milliseconds. Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Interval { get; set; }
		/// <summary>
		/// Gets or sets If set, a screenshot of the frame will be captured and returned in the response. Otherwise, no screenshot will be captured.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ScreenshotParams Screenshot { get; set; }
	}
}
