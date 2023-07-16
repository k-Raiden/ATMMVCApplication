using ATMDataAccess.Context;
using ATMDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDataAccess.Repository
{
    public class ATMRepository
    {
        private readonly ATMDBContext _context;

        public ATMRepository()
        {
            _context = new ATMDBContext();

        }
        public int Create(AccountModel acctModel)
        {

            _context.Add(acctModel);
            _context.SaveChanges();

            return acctModel.AccountID;

        }

        public int Update(AccountModel acctModel)
        {
            AccountModel acctId = _context.Account.Find(acctModel.AccountID);
            acctId.AccountNumber = acctModel.AccountNumber;
            acctId.PinNumber = acctModel.PinNumber;
            acctId.FullName = acctModel.FullName;
            acctId.PreviousBalance = acctModel.PreviousBalance;
            acctId.DepositAmount = acctModel.DepositAmount;
            acctId.TransactionDate = DateTime.UtcNow;
            acctId.NewBalance = acctModel.NewBalance;
            acctId.WithdrawAmount = acctModel.WithdrawAmount;
            _context.SaveChanges();

            return acctModel.AccountID;

        }

        public bool Delete(int acctModel)
        {
            AccountModel Linka = _context.Account.Find(acctModel);

            _context.Remove(Linka);

            _context.SaveChanges();

            return true;

        }
        public List<AccountModel> GetAllAccounts()
        {


            return _context.Account.ToList();

        }

        public AccountModel GetbyID(int Id)
        {
            //so u creatinga an obeject kugira uronke igo ku return,but
            //_context.Account.Find(ID) kuko ni just parametre.
            AccountModel Liam = _context.Account.Find(Id);

            return Liam;
        }

        public IQueryable<AccountModel> GetbyCardNumber(int cardNumber, int pinNumber)
        {
            return _context.Set<AccountModel>().Where(X => X.CardNumber == cardNumber && X.PinNumber == pinNumber);



        }
    }
}
