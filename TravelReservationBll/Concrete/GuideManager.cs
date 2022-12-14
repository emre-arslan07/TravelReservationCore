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
    public class GuideManager : IGuideService
        
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void Add(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void Delete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetAll();
        }

        public Guide GetById(int id)
        {
            return _guideDal.Get(x => x.GuideID == id);
        }

        public void Update(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
