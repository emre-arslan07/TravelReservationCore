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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void Add(ContactUs t)
        {
            _contactUsDal.Insert(t);
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            var values = _contactUsDal.Get(x => x.ContactUsID == id);
            values.Status = false;
            _contactUsDal.Update(values);
        }

        public void Delete(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetAll()
        {
            return _contactUsDal.GetAll();
        }

        public ContactUs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            return _contactUsDal.GetAll(x => x.Status == false);
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            return _contactUsDal.GetAll(x => x.Status == true);
        }

        public void Update(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
