using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationBll.Abstract;
using TravelReservationDal.Abstract;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void Delete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public List<Destination> GetAll()
        {
            return _destinationDal.GetAll();
        }

        public Destination GetById(int id)
        {
            return _destinationDal.Get(x => x.DestinationID == id);
        }

        public Destination GetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public void Update(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
