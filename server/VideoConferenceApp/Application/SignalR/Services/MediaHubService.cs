using Application.SignalR.Hubs;
using Application.SignalR.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SignalR.Services
{
    public class MediaHubService : IMediaHubService
    {
        private readonly IHubContext<MediaHub> _hubContext;

        public MediaHubService(IHubContext<MediaHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task SendOffer(string offer, string participantId)
        {
            throw new NotImplementedException();
        }

        public async Task SendAnswer(string answer, string participantId)
        {
            throw new NotImplementedException();
        }

        public async Task SendIceCandidate(string candidate, string participantId)
        {
            throw new NotImplementedException();
        }
    }
}
