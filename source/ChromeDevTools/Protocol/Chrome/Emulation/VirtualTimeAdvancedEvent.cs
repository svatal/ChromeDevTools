using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Notification sent after the virtual time has advanced.
	/// </summary>
	[Event(ProtocolName.Emulation.VirtualTimeAdvanced)]
	[SupportedBy("Chrome")]
	public class VirtualTimeAdvancedEvent
	{
		/// <summary>
		/// Gets or sets The amount of virtual time that has elapsed in milliseconds since virtual time was first enabled.
		/// </summary>
		public double VirtualTimeElapsed { get; set; }
	}
}
