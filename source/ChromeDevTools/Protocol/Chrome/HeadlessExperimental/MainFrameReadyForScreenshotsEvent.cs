using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Issued when the main frame has first submitted a frame to the browser. May only be fired while a BeginFrame is in flight. Before this event, screenshotting requests may fail.
	/// </summary>
	[Event(ProtocolName.HeadlessExperimental.MainFrameReadyForScreenshots)]
	[SupportedBy("Chrome")]
	public class MainFrameReadyForScreenshotsEvent
	{
	}
}
