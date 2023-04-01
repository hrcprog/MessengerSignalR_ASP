using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalR.HRC.Hubs
{
    public class SiteChatHub : Hub
    {

        public async Task SendNewMessage(object Message)
        {

            await Clients.All.SendAsync("getNewMessage", Message);
        }


        public override Task OnConnectedAsync()
        {
            var connId = Context.ConnectionId;
            return base.OnConnectedAsync();

        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
