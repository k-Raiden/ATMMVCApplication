
using ATMDataAccess.Model;
using ATMDataAccess.Repository;
using ATMMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

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
            AccountViewModel account = new AccountViewModel();
            account.AccountList = _repo.GetAllAccounts();
            account.CurrentAccount =account.AccountList.FirstOrDefault();
            
            return View(account);
        }
        

        public IActionResult AccountDetails(int id)
        {
            var account = _repo.GetbyID(id);
            
            AccountViewModel model = new AccountViewModel();
            
            model.CurrentAccount = account;
            return View(model);
        }

        public IActionResult DepositFunds(AccountViewModel model)
        {
            var currentAccount = _repo.GetbyID(model.AccountID);
            decimal newBalance = 0.0m;

            if(currentAccount != null) 
            {
                newBalance = currentAccount.PreviousBalance + model.DepositAmount;
            
                model.NewBalance= newBalance;

                model.PreviousBalance= newBalance;

                var newMoney = new AccountModel
                {
                    AccountID = model.AccountID,
                    PreviousBalance = model.PreviousBalance,
                    NewBalance = model.NewBalance,
                    UserID = model.UserID,
                    WithdrawAmount = model.WithdrawAmount,
                    CardNumber = model.CardNumber,
                    AccountNumber = model.AccountNumber,
                    PinNumber = model.PinNumber,
                    DepositAmount = model.DepositAmount,
                    FullName = model.FullName,
                    TransactionDate = DateTime.Now,
                    PassWord = model.PassWord,

                };
                
               var result= _repo.Update(newMoney);
                return View("Index", model);
            }
            return View(model);
            
        }
        public IActionResult DepositView () 
        { 
            AccountViewModel myobjct = new AccountViewModel();

            myobjct.AccountList = _repo.GetAllAccounts();
            myobjct.CurrentAccount= myobjct.AccountList.FirstOrDefault();

            return View(myobjct);
        }
        public IActionResult WithDrawnFunds(AccountViewModel model)
        {
            model.NewBalance = model.PreviousBalance - model.WithdrawAmount;
            // logic to withdrawn money

            return View("AccountDetails", model);
        }
        public IActionResult WithdrawView () 
        {
            return View();
        }

    }
}
