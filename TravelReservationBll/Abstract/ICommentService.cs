﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.Abstract
{
   public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> GetCommentByDestinationId(int id);
        List<Comment> GetListCommentWithDestination();

        List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
