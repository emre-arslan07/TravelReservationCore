using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationBll.ValidationRules;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _guideService.GetAll();
            return View(values);
        }
        [Route("AddGuide")]
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [Route("AddGuide")]
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult validationResult = validationRules.Validate(guide);
            if (validationResult.IsValid)
            {
                _guideService.Add(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
           
        }
        [Route("EditGuide")]
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.GetById(id);
            return View(values);
        }
        [Route("EditGuide")]
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToTrue(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
