using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ASPNETCoreSignalR21
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("SendAction", "Name Here", "joined");
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("SendAction", "Name Here", "left");
        }

        public async Task Send(string message)
        {
            await Clients.All.SendAsync("SendMessage", "Name Here", message);
        }
    }
}
