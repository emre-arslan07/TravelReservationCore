using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Abstract;

namespace TravelReservationEntity.Concrete
{
   public class Comment:IEntity
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
        public bool CommentState { get; set; }

        public Destination Destination { get; set; }
        public int DestinationID { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserID { get; set; }
    }
}
