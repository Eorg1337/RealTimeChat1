using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace RealTimeChat1.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string userName, string message)
            => await Clients.All.SendAsync("ReceiveMessage", userName, message);
    }
}
