using Microsoft.AspNetCore.SignalR;


namespace Application.SignalR.Hubs
{
    public class MediaHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        public async Task SendOffer(string offer)
        {
            await Clients.Others.SendAsync("ReceiveOffer", offer);
        }

        public async Task SendAnswer(string answer)
        {
            await Clients.Others.SendAsync("ReceiveAnswer", answer);
        }

        public async Task SendIceCandidate(string candidate)
        {
            await Clients.Others.SendAsync("ReceiveIceCandidate", candidate);
        }
    }
}
