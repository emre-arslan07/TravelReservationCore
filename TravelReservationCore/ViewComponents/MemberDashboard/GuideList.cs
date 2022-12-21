using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Concrete;
using TravelReservationDal.EntityFramework;

namespace TravelReservationCore.ViewComponents.MemberDashboard
{
    public class GuideList:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EFGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.GetAll();
            return View(values);
        }
    }
}
