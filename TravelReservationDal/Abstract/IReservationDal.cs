using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationDal.Abstract
{
   public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitAppoval(int id );
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
