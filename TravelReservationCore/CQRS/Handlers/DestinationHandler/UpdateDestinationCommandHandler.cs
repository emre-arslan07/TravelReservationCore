using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationCore.CQRS.Commands.DestinationCommand;
using TravelReservationDal.Concrete;

namespace TravelReservationCore.CQRS.Handlers.DestinationHandler
{
    public class UpdateDestinationCommandHandler
    {
        private readonly TravelReservationDbContext _travelReservationDb;

        public UpdateDestinationCommandHandler(TravelReservationDbContext travelReservationDb)
        {
            _travelReservationDb = travelReservationDb;
        }

        public void Handle(UpdateDestinationCommand updateDestinationCommand)
        {
            var values = _travelReservationDb.Destinations.Find(updateDestinationCommand.DestinationID);
            values.City = updateDestinationCommand.City;
            values.DayNight = updateDestinationCommand.DayNight;
            values.Price = updateDestinationCommand.Price;
            _travelReservationDb.SaveChanges();
        }
    }
}
