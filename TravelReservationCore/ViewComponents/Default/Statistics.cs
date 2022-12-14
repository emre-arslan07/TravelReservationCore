using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Concrete;
using TravelReservationDal.EntityFramework;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.ViewComponents.Default
{
    public class Statistics:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        GuideManager guideManager = new GuideManager(new EFGuideDal());
        public IViewComponentResult Invoke()
        {
            //rotalar rehberler müşteriler ödüller
            ViewBag.Destination = destinationManager.GetAll().Count();
            ViewBag.Guide = guideManager.GetAll().Count();
            ViewBag.Customers = "285";
            ViewBag.Awards = "150";
            return View();
        }
    }
}
