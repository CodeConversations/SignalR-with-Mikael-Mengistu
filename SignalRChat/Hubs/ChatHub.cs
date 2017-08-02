using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.InvokeAsync("Send", message);
        }
    }
}
