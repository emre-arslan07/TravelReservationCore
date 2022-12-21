using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelReservationCore.ViewComponents.MemberDashboard
{
    public class PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
