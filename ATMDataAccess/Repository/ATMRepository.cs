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
            Random num = new Random();
            string result="";

            string numbers = "123456789";

            // random account Number

            for (int i = 0;i<9; i++)
            {
                int number = num.Next(0, numbers.Length);

                char c = numbers[number];

                result += c;
            }
            acctModel.AccountNumber = Convert.ToInt32(result);

            // random card number

            for (int i = 0; i < 10; i++) 
            { 
                int number2 =num.Next(0, numbers.Length);

                char c2 = numbers[number2];

                result += c2;
            
            }

            acctModel.CardNumber = Convert.ToInt32(result);

            _context.Add(acctModel);
            _context.SaveChanges();

            return acctModel.AccountID;

        }

         public AccountModel Update(AccountModel acctModel)
        {
            AccountModel acctId = _context.Account.Find(acctModel.AccountID);
            acctId.AccountNumber = acctModel.AccountNumber;
            acctId.PinNumber = acctModel.PinNumber;
            acctId.CardNumber = acctModel.CardNumber;
            acctId.FullName = acctModel.FullName;
            acctId.PreviousBalance = acctModel.PreviousBalance;
            acctId.DepositAmount = acctModel.DepositAmount;
            acctId.TransactionDate = DateTime.UtcNow;
            acctId.NewBalance = acctModel.NewBalance;
            acctId.WithdrawAmount = acctModel.WithdrawAmount;

            _context.SaveChanges();

            return acctModel;    

            

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
