namespace AccountHolderList.Models
{
    public class AccountHolder
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public List<BankAccount>? BankAccounts { get; set; }
        public int? AccountId { get; set; }

    }
}
