using Application.Dto;
using Application.Interfaces;
using Application.SignalR.Hubs;
using Application.SignalR.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace VideoConference.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiscussionController : ControllerBase
    {
        private readonly IServiceManager _serviceMamager;
        private readonly IDiscussionHubService _hubService;
        private readonly IAuthenticationService _authenticationService; // Inject AuthenticationService


        public DiscussionController(IServiceManager serviceManager, IDiscussionHubService hubService, IAuthenticationService authenticationService)
        {
            _serviceMamager = serviceManager;
            _hubService = hubService;
            _authenticationService = authenticationService;
        }

        [HttpPost("join")]
        public async Task<ActionResult> JoinDiscussionAsync(string participantId, string discussionId, ParticipantDto participantDto)
        {
            // Validate participantId, discussionId

            // Generate JWT token with user permissions
            string token = _authenticationService.GenerateJwtToken(participantId, discussionId, participantDto);
            await _hubService.NotifyParticipantsJoinedDiscussion(participantId, new DiscussionParticipantDto());
            return Ok(token);
        }

        [HttpPost("logout")]
        public async Task<ActionResult> LogoutDiscussion(string participantId, string discussionId)
        {
            //loguot user, then update hub
            await _hubService.NotifyParticipantsLeftDiscussion(participantId, discussionId);
            return Ok();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,User")]
        public async Task<ActionResult> ModifyParticipantSettings(string participantId, string discussionId, [FromBody] ParticipantSettingsDto request)
        {
            DiscussionParticipantDto result = _serviceMamager.DiscussionService.ModifyParticipantSettings(participantId, discussionId, request);
            await _hubService.NotifyParticipantsSettingsChanged(discussionId, result);
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ModifyAllParticipantSettings(string discussionId, [FromBody] AdminChangeSettingsRequest changeSettingsRequest)
        {
            IEnumerable<DiscussionParticipantDto> result = _serviceMamager.DiscussionService.ModifyAllParticipantSettings(discussionId, changeSettingsRequest);
            await _hubService.NotifyParticipantsSettingsChanged(discussionId, result);
            return Ok(result);
        }
    }

}
