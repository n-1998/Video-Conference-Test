using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class DiscussionService : IDiscussionService
    {
        private readonly IRepositoryManager _repositoryManager;

        public DiscussionService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public DiscussionDto GetDiscussionById(Guid discussionId)
        {
            var discussion = _repositoryManager.DiscussionRepository.Get(discussionId);
            if (discussion == null)
            {
                throw new DiscussionNotFoundException(discussionId);
            }
            //TODO: map discussion to Dto object
            return new DiscussionDto { /*...*/};
        }

        public DiscussionParticipantDto ModifyParticipantSettings(string participantId, string discussionId, ParticipantSettingsDto settingsDto)
        {
            //store participant setings changes (mute/unmute, camera on/off, etc.) in temporary storage (like redis) 
            //returns updated settings Object
            return new DiscussionParticipantDto();
        }

        public IEnumerable<DiscussionParticipantDto> ModifyAllParticipantSettings(string discussionId, AdminChangeSettingsRequest changeSettingsRequest)
        {
            //get all discussion participants by discussionn id
            //update the requested change for all discussion participants in temporary storage
            //return updated settings
            throw new NotImplementedException();
        }

        public void EndDiscussion(string discussionId)
        {
            throw new NotImplementedException();
        }

        public void StartDiscussion(DiscussionDto discussion)
        {
            throw new NotImplementedException();
        }

    }
}
