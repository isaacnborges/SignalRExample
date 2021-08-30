using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalRWebApp.Hubs
{
    public class OrderHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveOrderStatus", "Order received");

            await Task.Delay(TimeSpan.FromSeconds(2));
            await Clients.All.SendAsync("ReceiveOrderStatus", "Order in payment analysis");

            await Task.Delay(TimeSpan.FromSeconds(4));
            await Clients.All.SendAsync("ReceiveOrderStatus", "Order approved");

            await Task.Delay(TimeSpan.FromSeconds(5));
            await Clients.All.SendAsync("ReceiveOrderStatus", "Order in separation");

            await Task.Delay(TimeSpan.FromSeconds(5));
            await Clients.All.SendAsync("ReceiveOrderStatus", "Order finalized");
        }
    }
}