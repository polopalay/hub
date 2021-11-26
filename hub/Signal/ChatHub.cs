using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Signal.Signal
{
    public class ChatHub : Hub
    {
        //public async Task Message(MessageModel message)
        //{
        //    await Clients.All.SendAsync(message.Id.ToString(), message);
        //}
    }

    public class MessageModel
    {
        public string Id { get; set; }
        public string Message { get; set; }
    }
}
