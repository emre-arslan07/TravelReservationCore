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
    public class EFReservationDal : GenericRepository<Reservation, TravelReservationDbContext>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var context = new TravelReservationDbContext())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.AppUserID == id && x.Status == "Onaylandı").ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new TravelReservationDbContext())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.AppUserID == id && x.Status == "Geçmiş Rezervasyon").ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitAppoval(int id)
        {
            using(var context=new TravelReservationDbContext())
            {
                return context.Reservations.Include(x => x.Destination).Where(x =>x.AppUserID==id && x.Status == "Onay Bekliyor").ToList();
            }
        }
    }
}
