﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.Abstract.AbstractUnitOfWork
{
   public interface IAccountService:IGenericUnitOfWorkService<Account>
    {
    }
}