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
    public class EFCommentDal : GenericRepository<Comment, TravelReservationDbContext>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using(var context=new TravelReservationDbContext())
            {
                return context.Comments.Include(x => x.Destination).ToList();
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            using (var context = new TravelReservationDbContext())
            {
                return context.Comments.Where(x=>x.DestinationID==id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
