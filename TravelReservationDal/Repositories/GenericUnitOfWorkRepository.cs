using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationDal.Abstract;
using TravelReservationDal.Concrete;
using TravelReservationDal.EntityFramework;

namespace TravelReservationDal.Repositories
{
    public class GenericUnitOfWorkRepository<T> : IGenericUnitOfWorkDal<T> where T : class
    {
        private readonly TravelReservationDbContext _reservationdbcontext;

        public GenericUnitOfWorkRepository(TravelReservationDbContext reservationdbcontext)
        {
            _reservationdbcontext = reservationdbcontext;
        }

        public T GetByID(int id)
        {
            return _reservationdbcontext.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _reservationdbcontext.Add(t);
        }

        public void MultipleUpdate(List<T> t)
        {
            _reservationdbcontext.UpdateRange(t);
        }

        public void Update(T t)
        {
            _reservationdbcontext.Update(t);
        }
    }
}
