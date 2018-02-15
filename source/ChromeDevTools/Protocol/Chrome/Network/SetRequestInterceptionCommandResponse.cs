using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match a the provided patterns and optionally resource types.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetRequestInterception)]
	[SupportedBy("Chrome")]
	public class SetRequestInterceptionCommandResponse
	{
	}
}
