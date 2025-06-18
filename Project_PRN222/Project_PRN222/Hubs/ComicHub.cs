using Microsoft.AspNetCore.SignalR;

namespace Project_PRN222.Hubs
{
    public class ComicHub : Hub
    {
        public async Task SendComicUpdate(Guid comicId, int followCount, int likeCount)
        {
            await Clients.All.SendAsync("ReceiveComicUpdate", comicId, followCount, likeCount);
        }
    }
}
