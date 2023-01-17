using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationEntity.Abstract;

namespace TravelReservationEntity.Concrete
{
   public class Account:IEntity
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
