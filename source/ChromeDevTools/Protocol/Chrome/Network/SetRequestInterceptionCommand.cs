using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match a the provided patterns and optionally resource types.
	/// </summary>
	[Command(ProtocolName.Network.SetRequestInterception)]
	[SupportedBy("Chrome")]
	public class SetRequestInterceptionCommand: ICommand<SetRequestInterceptionCommandResponse>
	{
		/// <summary>
		/// Gets or sets Requests matching any of these patterns will be forwarded and wait for the corresponding continueInterceptedRequest call.
		/// </summary>
		public RequestPattern[] Patterns { get; set; }
	}
}
