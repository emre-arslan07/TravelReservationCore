using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Concrete;
using TravelReservationDal.EntityFramework;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EFReservationDal());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async  Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalWaitingReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByWaitAppoval(values.Id);

            return View(valuesList);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values=(from x in destinationManager.GetAll()
                                         select new SelectListItem
                                         {
                Text=x.City,
                Value=x.DestinationID.ToString()
                                         }).ToList();
            ViewBag.DestinationName = values;

            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserID = 1;
            reservation.Status = "Onay Bekliyor";
            reservationManager.Add(reservation);
            return View("MyCurrentReservation");
        }
    }
}
