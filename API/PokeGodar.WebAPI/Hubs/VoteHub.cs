using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace PokeGodar.WebAPI.Hubs
{
    [HubName("voteHub")]
    public class VoteHub : Hub
    {
    }
}
