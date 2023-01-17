using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationCore.Areas.Admin.Models;
using TravelReservationDTO.DTOs.AnnouncementDTOs;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Announcement")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService,IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.GetAll());
            return View(values);
            //List<Announcement> announcements = _announcementService.GetAll();
            //List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            //foreach (var item in announcements)
            //{
            //    AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
            //    announcementListViewModel.ID = item.AnnouncementID;
            //    announcementListViewModel.Title = item.Title;
            //    announcementListViewModel.Content = item.Content;
            //    model.Add(announcementListViewModel);
            //}
            //return View(model);
        }

        [HttpGet]
        [Route("")]
        [Route("AddAnnouncement")]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        [Route("AddAnnouncement")]
        public IActionResult AddAnnouncement(AnnouncementAddDTO dTO)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Add(new Announcement() 
                {
                    Content=dTO.Content,
                    Title=dTO.Title,
                    Date=Convert.ToDateTime(DateTime.Now.ToLongDateString())
                });
                return RedirectToAction("Index");
            }
            return View(dTO);
        }
        [HttpPost]
        [Route("DeleteAnnouncement/{id}")]
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetById(id);
            _announcementService.Delete(values);
            ViewBag.Message = "";
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateAnnouncement/{id}")]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.GetById(id));
            return View(values);
        }

        [HttpPost]
        [Route("UpdateAnnouncement/{id}")]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO dTO)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Update(new Announcement
                {
                    AnnouncementID=dTO.AnnouncementID,
                    Title=dTO.Title,
                    Content=dTO.Content,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index", "Announcement", new { area = "Admin" });
            }
            return View(dTO);
        }
    }
}
