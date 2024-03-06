using Application.Dto;
using Domain.Entities;
using Microsoft.AspNetCore.SignalR;

namespace Application.SignalR.Hubs
{
    public class DiscussionHub : Hub
    {
        public async override Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            await Clients.Caller.SendAsync("Message", "Connected successfully!");
        }

        //This function will be invoked by joining the discussion
        public async Task SubscribeToDiscussion(Guid discussionId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, discussionId.ToString());
            await Clients.Caller.SendAsync("Message", "Added to discussion successfully!");
        }
    }

}
