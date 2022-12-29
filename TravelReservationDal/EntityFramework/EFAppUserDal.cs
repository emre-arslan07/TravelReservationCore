using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationDal.Abstract;
using TravelReservationDal.Concrete;
using TravelReservationDal.Repositories;
using TravelReservationEntity.Concrete;

namespace TravelReservationDal.EntityFramework
{
    public class EFAppUserDal : GenericRepository<AppUser, TravelReservationDbContext>, IAppUserDal
    {
        
    }
}
