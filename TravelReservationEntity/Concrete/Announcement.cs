using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Abstract;

namespace TravelReservationEntity.Concrete
{
    public class Announcement : IEntity
    {
        public int AnnouncementID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

    }
}
