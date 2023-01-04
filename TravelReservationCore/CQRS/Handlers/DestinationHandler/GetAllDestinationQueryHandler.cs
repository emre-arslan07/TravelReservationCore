using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationCore.CQRS.Results.DestinationResult;
using TravelReservationDal.Concrete;
using TravelReservationDal.EntityFramework;

namespace TravelReservationCore.CQRS.Handlers.DestinationHandler
{
    public class GetAllDestinationQueryHandler
    {
        //private readonly IDestinationService _destinationService;

        //public GetAllDestinationQueryHandler(IDestinationService destinationService)
        //{
        //    _destinationService = destinationService;
        //}
        private readonly TravelReservationDbContext _reservationdbcontext;

        public GetAllDestinationQueryHandler(TravelReservationDbContext reservationdbcontext)
        {
            _reservationdbcontext = reservationdbcontext;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _reservationdbcontext.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id=x.DestinationID,
                capacity=x.Capacity,
                city=x.City,
                daynight=x.DayNight,
                price=x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
