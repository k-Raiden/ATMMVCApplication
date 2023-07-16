using ATMDataAccess.Model;

namespace ATMMVCApplication.Models
{
    public class AccountViewModel
    {
        public int AccountNumber { get; set; }

        public int CardNumber { get; set; }

        public int AccountID { get; set; }

        public string FullName { get; set; } = null!;

        public int PinNumber { get; set; }

        public double PreviousBalance { get; set; }

        public double DepositAmount { get; set; }

        public double WithdrawAmount { get; set; }

        public double NewBalance { get; set; }

        public DateTime TransactionDate { get; set; }

        public AccountModel? CurrentAccount { get; set; }

        public List<AccountModel>? AccountList { get; set; }
    }
}
