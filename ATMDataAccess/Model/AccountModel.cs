namespace ATMDataAccess.Model
{
    public class AccountModel
    {

        public int AccountNumber { get; set; }
        public int CardNumber { get; set; }

        public int AccountID { get; set; }

        public string? UserID { get; set; }

        public string? FullName { get; set; }

        public int PinNumber { get; set; }

        public decimal PreviousBalance { get; set; }

        public decimal DepositAmount { get; set; }

        public decimal WithdrawAmount { get; set; }

        public decimal NewBalance { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? PassWord { get; set; }


        public AccountModel(int accountID, int pinNumber, int accountNumber, int cardnumber, string fullName, decimal previousBalance, decimal depositAmount, decimal withdrawAmount, decimal newBalance, DateTime transactionDate, string pWord)
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
            PassWord = pWord;



        }
        public AccountModel()
        {

        }
    }
}
