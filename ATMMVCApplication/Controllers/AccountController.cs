using ATMDataAccess.Repository;
using ATMMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATMMVCApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly ATMRepository _repo;

        public AccountController()
        {
            _repo = new ATMRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccountDetails(int id)
        {
            var account = _repo.GetbyID(id);
            AccountViewModel model = new AccountViewModel();
            model.CurrentAccount = account;
            return View(model);
        }

        public IActionResult ErrorPage()
        {
            return View();
        }

        public IActionResult LoginProcess(AccountViewModel model)
        {
            var account = _repo.GetbyCardNumber(model.CardNumber, model.PinNumber);

            if(account != null)
            {
                return View("AccountDetails", model);
            }
            return View("ErrorPage");
        }

        public IActionResult DepositFunds(AccountViewModel model)
        {
            //logic to deposit account

            return View("AccountDetails", model);
        }

        public IActionResult WithDrawnFunds(AccountViewModel model)
        {
            // logic to withdrawn money

            return View("AccountDetails", model);
        }


    }
}
