using BankApi.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models
{
    public class PaymentListItem
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public Status Status { get; set; }
        public bool IsReason { get; set; }
        public string Reason { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
