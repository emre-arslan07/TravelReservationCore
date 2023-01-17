using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelReservationBll.Abstract.AbstractUnitOfWork;
using TravelReservationCore.Areas.Admin.Models;
using TravelReservationEntity.Concrete;

namespace TravelReservationCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel account)
        {
            var valueSender = _accountService.GetById(account.SenderID);
            var valueReceiver = _accountService.GetById(account.ReceiverID);

            valueSender.Balance-= account.Amount;
            valueReceiver.Balance += account.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,
                valueReceiver
            };
            _accountService.MultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
