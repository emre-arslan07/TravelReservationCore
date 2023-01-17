using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservationBll.Abstract.AbstractUnitOfWork;
using TravelReservationDal.Abstract;
using TravelReservationDal.UnitOfWork;
using TravelReservationEntity.Concrete;

namespace TravelReservationBll.Concrete.ConcreteUnitOfWork
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _accountDal = accountDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public Account GetById(int id)
        {
            return _accountDal.GetByID(id);
        }

        public void Insert(Account t)
        {
            _accountDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void MultiUpdate(List<Account> t)
        {
            _accountDal.MultipleUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void Update(Account t)
        {
            _accountDal.Update(t);
            _unitOfWorkDal.Save();
        }
    }
}
