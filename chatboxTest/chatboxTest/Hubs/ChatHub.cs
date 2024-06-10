using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Gửi tin nhắn cho tất cả các client
            Clients.All.addNewMessage(name, message);
        }
    }
}
