using Microsoft.AspNetCore.SignalR;
using SignalRApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService vistorService)
        {
            _visitorService = vistorService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("ReceiveVisitorList", _visitorService.GetVisitorChartList());
        }
    }
}
