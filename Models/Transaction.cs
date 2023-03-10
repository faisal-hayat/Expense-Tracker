using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }

        
        [Column(TypeName = "nvarchar(50)")]
        public string? Note { get; set; }

        // current date is the default
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
