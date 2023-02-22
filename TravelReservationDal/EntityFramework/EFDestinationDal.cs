using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationDal.Abstract;
using TravelReservationDal.Concrete;
using TravelReservationDal.Repositories;
using TravelReservationEntity.Concrete;

namespace TravelReservationDal.EntityFramework
{
    public class EFDestinationDal : GenericRepository<Destination, TravelReservationDbContext>, IDestinationDal
    {
        public Destination GetDestinationWithGuide(int id)
        {
            using (var context = new TravelReservationDbContext())
            {
                return context.Destinations.Where(x => x.DestinationID == id).Include(x => x.Guide).FirstOrDefault();
            }

        }
    }
}
