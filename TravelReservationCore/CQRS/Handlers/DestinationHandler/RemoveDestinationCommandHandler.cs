using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationCore.CQRS.Commands.DestinationCommand;
using TravelReservationDal.Concrete;

namespace TravelReservationCore.CQRS.Handlers.DestinationHandler
{
    public class RemoveDestinationCommandHandler
    {
        private readonly TravelReservationDbContext _reservationDbContext;

        public RemoveDestinationCommandHandler(TravelReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }

        public void Handle(RemoveDestinationCommand removeDestinationCommand)
        {
            var values = _reservationDbContext.Destinations.Find(removeDestinationCommand.Id);
            _reservationDbContext.Remove(values);
            _reservationDbContext.SaveChanges();
        }
    }
}
