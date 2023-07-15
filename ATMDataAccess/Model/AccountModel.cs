using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDataAccess.Model
{
    public class AccountModel
    {

        public int AccountNumber { get; set; }
        public int CardNumber { get; set; }

        public int AccountID { get; set; }

        public string FullName { get; set; }

        public int PinNumber { get; set; }

        public double PreviousBalance { get; set; }

        public double DepositAmount { get; set; }

        public double WithdrawAmount { get; set; }

        public double NewBalance { get; set; }
        public DateTime TransactionDate { get; set; }

        public AccountModel(int accountID, int pinNumber, int accountNumber, int cardnumber, string fullName, double previousBalance, double depositAmount, double withdrawAmount, double newBalance, DateTime transactionDate)
        {
            AccountID = accountID;
            AccountNumber = accountNumber;
            CardNumber = cardnumber;
            FullName = fullName;
            PinNumber = pinNumber;
            PreviousBalance = previousBalance;
            DepositAmount = depositAmount;
            WithdrawAmount = withdrawAmount;
            NewBalance = newBalance;
            TransactionDate = transactionDate;


        }
        public AccountModel()
        {

        }
    }
}
