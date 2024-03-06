//using Application.SignalR.Hubs;
using Application.Dto;
using Application.SignalR.Hubs;
using Application.SignalR.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.SignalR;


namespace Application.SignalR.Services
{
    public class DiscussionHubService : IDiscussionHubService
    {
        private readonly IHubContext<DiscussionHub> _hubContext;

        public DiscussionHubService(IHubContext<DiscussionHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task NotifyParticipantsSettingsChanged(string discussionId, object participantSettings)
        {
            await _hubContext.Clients.Group(discussionId).SendAsync("ParticipantsSettingsChanged", discussionId, participantSettings);
        }

        public async Task NotifyParticipantsLeftDiscussion(string discussionId, string participantId)
        {
            await _hubContext.Clients.Group(discussionId).SendAsync("NotifyParticipantsLeftDiscussion", discussionId, participantId);
        }

        public async Task NotifyParticipantsJoinedDiscussion(string discussionId, DiscussionParticipantDto participant)
        {
            await _hubContext.Clients.Group(discussionId).SendAsync("NotifyParticipantsJoinedDiscussion", discussionId, participant);
        }
    }
}
