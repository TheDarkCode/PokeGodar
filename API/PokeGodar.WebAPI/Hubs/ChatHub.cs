using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace PokeGodar.WebAPI.Hubs
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
    }
}
