using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.Abstract
{
   public interface IDestinationService:IGenericService<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
    }
}
