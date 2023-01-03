﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservationDTO.DTOs.DestinationDTOs
{
   public class DestinationAddDTO
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
