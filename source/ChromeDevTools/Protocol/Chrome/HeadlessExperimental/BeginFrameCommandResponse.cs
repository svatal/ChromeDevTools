using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a screenshot from the resulting frame. Requires that the target was created with enabled BeginFrameControl.
	/// </summary>
	[CommandResponse(ProtocolName.HeadlessExperimental.BeginFrame)]
	[SupportedBy("Chrome")]
	public class BeginFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Whether the BeginFrame resulted in damage and, thus, a new frame was committed to the display.
		/// </summary>
		public bool HasDamage { get; set; }
		/// <summary>
		/// Gets or sets Whether the main frame submitted a new display frame in response to this BeginFrame.
		/// </summary>
		public bool MainFrameContentUpdated { get; set; }
		/// <summary>
		/// Gets or sets Base64-encoded image data of the screenshot, if one was requested and successfully taken.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScreenshotData { get; set; }
	}
}
