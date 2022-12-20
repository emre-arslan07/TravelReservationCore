using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationDal.Abstract;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void Delete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.Get(x => x.ReservationID == id);
        }

        public List<Reservation> GetListApprovalReservationByID(int id)
        {
            return _reservationDal.GetAll(x => x.AppUserID == id).Where(x=>x.Status=="Onay Bekliyor").ToList();
        }

        public List<Reservation> GetListOldReservationByID(int id)
        {
            return _reservationDal.GetAll(x => x.AppUserID == id).Where(x => x.Status == "Geçmiş Rezervasyon").ToList();
        }

        public void Update(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
