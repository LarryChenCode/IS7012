namespace AccountHolderList.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public DateTime CreateTimeStamp { get; set; }
        public string AccountType { get; set; }
        public AccountHolder? AccountHolder { get; set; }
        public int? HolderId { get; set; }

    }
}
