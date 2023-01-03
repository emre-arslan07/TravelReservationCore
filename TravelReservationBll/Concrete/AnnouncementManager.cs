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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementdDal _announcementdDal;

        public AnnouncementManager(IAnnouncementdDal announcementdDal)
        {
            _announcementdDal = announcementdDal;
        }

        public void Add(Announcement t)
        {
            _announcementdDal.Insert(t);
        }

        public void Delete(Announcement t)
        {
            _announcementdDal.Delete(t);
        }

        public List<Announcement> GetAll()
        {
            return _announcementdDal.GetAll();
        }

        public Announcement GetById(int id)
        {
            return _announcementdDal.Get(x => x.AnnouncementID == id);
        }

        public void Update(Announcement t)
        {
            _announcementdDal.Update(t);
        }
    }
}
