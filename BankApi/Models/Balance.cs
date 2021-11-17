using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public decimal RemainingBalance { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
