using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.ViewComponents.MemberDashboard
{
    public class ProfileInformation:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.Name + " " + values.Surname;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberMail = values.Email;
            return View();
        }
    }
}
