using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using RealTimeChat1.Shared;

namespace RealTimeChat1.Hubs
{
	public class WebHub : Hub
	{
		public async Task SendMessage(Message _message)
			=> await Clients.All.SendAsync("ReceiveMessage", _message);
	}
}
