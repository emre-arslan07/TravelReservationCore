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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Add(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void Delete(AppUser t)
        {
            _appUserDal.Delete(t);
        }

        public List<AppUser> GetAll()
        {
            return _appUserDal.GetAll();
        }

        public AppUser GetById(int id)
        {
            return _appUserDal.Get(x => x.Id == id);
        }

      

        public void Update(AppUser t)
        {
            _appUserDal.Update(t);
        }
    }
}
