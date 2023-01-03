using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetAll());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            _destinationService.Add(destination);
            var values=JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.GetById(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.GetById(id);
            _destinationService.Delete(values);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.Update(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }

    }
}
