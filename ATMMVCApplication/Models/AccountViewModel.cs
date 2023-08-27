using ATMDataAccess.Model;

namespace ATMMVCApplication.Models
{
    public class AccountViewModel
    {
        public int AccountNumber { get; set; }

        public int CardNumber { get; set; }

        public int AccountID { get; set; }

        public string? FullName { get; set; }

        public int PinNumber { get; set; }

        public decimal PreviousBalance { get; set; }

        public decimal DepositAmount { get; set; }

        public decimal WithdrawAmount { get; set; }

        public decimal NewBalance { get; set; }

        public string? PassWord { get; set; }

        public string? UserID { get; set; }

        public DateTime TransactionDate { get; set; }
        

        public AccountModel? CurrentAccount { get; set; }

        public List<AccountModel>? AccountList { get; set; }

        public AccountViewModel() 
        { 
            CurrentAccount= new AccountModel();
            AccountList = new List<AccountModel>();
        
        }
    }
    
   
}
