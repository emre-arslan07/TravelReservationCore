using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Abstract;

namespace TravelReservationEntity.Concrete
{
   public class AppRole:IdentityRole<int>,IEntity
    {
    }
}
