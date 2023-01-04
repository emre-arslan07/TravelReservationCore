using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationCore.CQRS.Queries.DestinationQuery;
using TravelReservationCore.CQRS.Results.DestinationResult;
using TravelReservationDal.Concrete;

namespace TravelReservationCore.CQRS.Handlers.DestinationHandler
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly TravelReservationDbContext _reservationdbcontext;

        public GetDestinationByIDQueryHandler(TravelReservationDbContext reservationdbcontext)
        {
            _reservationdbcontext = reservationdbcontext;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _reservationdbcontext.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
                Price=values.Price
            };
        }
    }
}
