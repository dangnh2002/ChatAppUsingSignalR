using Microsoft.AspNet.SignalR;
namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string ID_channel, string name, string message)
        {
            Clients.All.SendMessage(ID_channel,name, message);
        }
    }
}