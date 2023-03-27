using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;

namespace TravelReservationCore.ViewComponents.Destination
{
    public class GuideDetails:ViewComponent
    {
        private readonly IGuideService _guideService;

        public GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
