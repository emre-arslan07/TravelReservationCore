using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservationBll.Abstract.AbstractUnitOfWork
{
   public interface IGenericUnitOfWorkService<T>
    {
        void Insert(T t);
        void Update(T t);
        void MultiUpdate(List<T> t);
        T GetById(int id);
    }
}
