using Application.Dto;
using Application.Interfaces;
using Jose;



namespace Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly JwtSettings _jwtSettings; //class for JWT settings

        public AuthenticationService(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public string GenerateJwtToken(string userId, string discussionId, ParticipantDto participantDto)
        {
            //generate token with permission information
            throw new NotImplementedException();
        }
    }
}
