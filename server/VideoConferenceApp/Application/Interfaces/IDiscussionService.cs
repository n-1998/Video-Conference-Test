using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDiscussionService
    {
        DiscussionDto GetDiscussionById(Guid discussionId);
        DiscussionParticipantDto ModifyParticipantSettings(string participantId, string discussionId, ParticipantSettingsDto request);
        IEnumerable<DiscussionParticipantDto> ModifyAllParticipantSettings(string discussionId, AdminChangeSettingsRequest request);
        void StartDiscussion(DiscussionDto discussion);
        void EndDiscussion(string discussionId);
    }
}
