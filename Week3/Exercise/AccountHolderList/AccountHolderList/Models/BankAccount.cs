using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace AccountHolderList.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [DisplayName("Current Balance")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CurrentBalance { get; set; }

        [DisplayName("Account Name")]
        public string AccountName { get; set; }

        [DisplayName("Create TimeStamp")]
        public DateTime CreateTimeStamp { get; set; }

        [DisplayName("Account Type")]
        public string AccountType { get; set; }

        [DisplayName("Account Holder's SSN")]
        public AccountHolder? AccountHolder { get; set; }
        public int? AccountHolderId { get; set; }

    }
}
