using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Abstract;

namespace TravelReservationEntity.Concrete
{
   public class Newsletter: IEntity
    {
        [Key]
        public int NewsletterID { get; set; }
        public string Mail { get; set; }
    }
}
