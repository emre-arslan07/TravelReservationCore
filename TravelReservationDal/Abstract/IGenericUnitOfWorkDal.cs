using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservationDal.Abstract
{
   public interface IGenericUnitOfWorkDal<T> where T: class
    {
        void Insert(T t);
        void Update(T t);
        void MultipleUpdate(List<T> t);
        T GetByID(int id);
    }
}
