using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;

namespace TravelReservationCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/ContactUs")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _contactUsService.GetListContactUsByTrue();
            return View(values);
        }
        [Route("DeleteContactUs/{id}")]
        public IActionResult DeleteContactUs(int id)
        {
            _contactUsService.ContactUsStatusChangeToFalse(id);
            return RedirectToAction("Index", "ContactUs", new { area = "Admin" });
        }
    }
}
