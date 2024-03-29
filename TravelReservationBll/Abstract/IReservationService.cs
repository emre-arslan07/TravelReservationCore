﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.Abstract
{
   public interface IReservationService:IGenericService<Reservation>
    {
        //List<Reservation> GetListApprovalReservationByID(int id);
        //List<Reservation> GetListOldReservationByID(int id);

        List<Reservation> GetListWithReservationByWaitAppoval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
