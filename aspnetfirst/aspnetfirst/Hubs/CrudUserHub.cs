using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Hubs
{
    public class CrudUserHub:Hub
    {
        public async Task SendEdit(string user, string message)
        {
            user += " Edit ";
            await Clients.All.SendAsync("ReceiveMessage",user,message);
        }
    }
}
