using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationDal.Concrete;

namespace TravelReservationDal.UnitOfWork
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly TravelReservationDbContext _reservationDbContext;

        public UnitOfWorkDal(TravelReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }

        public void Save()
        {
            _reservationDbContext.SaveChanges();
        }
    }
}
