﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationBll.Concrete;
using TravelReservationDal.EntityFramework;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.Add(destination);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.GetById(id);
            _destinationService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.Update(destination);
            return RedirectToAction("Index");
        }
    }
}
