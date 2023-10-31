using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inline.API.Models
{
    public class BankAccount
    {
        [Key]
        public int BankAccountId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string AccountHolder { get; set; }
        [Required]
        public int BankId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string IFSC { get; set; }
    }
}
