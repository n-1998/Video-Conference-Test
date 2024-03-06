//using Application.SignalR.Hubs;
using Application.Dto;
using Domain.Entities;

namespace Application.SignalR.Interfaces
{
    public interface IDiscussionHubService
    {
        Task NotifyParticipantsSettingsChanged(string discussionId, object participantsSettings);
        Task NotifyParticipantsLeftDiscussion(string discussionId, string participantId);
        Task NotifyParticipantsJoinedDiscussion(string discussionId, DiscussionParticipantDto participant);
    }
}