using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelReservationCore.ViewComponents.AdminDashboard
{
    public class Cards1Statistic:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
