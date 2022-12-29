using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetAll();
            return View(values);
        }
        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetById(id);
            _appUserService.Delete(values);
            Thread.Sleep(1000);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.Update(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.GetAll();
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
            var values =_reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
