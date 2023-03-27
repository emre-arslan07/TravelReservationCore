using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationDTO.DTOs.ContactDTOs;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDTO sendMessageDTO)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.Add(new ContactUs() {
                    MessageBody = sendMessageDTO.MessageBody,
                    Mail = sendMessageDTO.Mail,
                    Status = true,
                    Name = sendMessageDTO.Name,
                    Subject = sendMessageDTO.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
               return RedirectToAction("Index","Default");
            }
            return View(sendMessageDTO);
        }
        
    }
}
