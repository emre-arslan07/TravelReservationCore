﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelReservationCore.CQRS.Commands.DestinationCommand
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}
