using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationCore.CQRS.Commands.DestinationCommand;
using TravelReservationDal.Concrete;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.CQRS.Handlers.DestinationHandler
{
    public class CreateDestinationCommandHandler
    {
        private readonly TravelReservationDbContext _reservationDbContext;

        public CreateDestinationCommandHandler(TravelReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }

        public void Handle(CreateDestinationCommand createDestination)
        {
            _reservationDbContext.Destinations.Add(new Destination
            {
                City=createDestination.City,
                Price=createDestination.Price,
                DayNight=createDestination.DayNight,
                Capacity=createDestination.Capacity,
                Status=true
            });
            _reservationDbContext.SaveChanges();
        }
    }
}
