using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inline.API.Models
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string BankName { get; set; }                 
    }
}
