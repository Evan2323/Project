using Albina.DataAcsses.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAcsses.Core.Models
{
    [Table("RejectExpense")]
    public class RejectExpenseRto
    {
        [Key] public int Id { get; set; }
        public int AuthorId { get; set; }
        public float Cost { get; set; }
        public string WhereSpend { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public DateTimeOffset CreateDateTime { get; set; }
        public DateTimeOffset RejectDateTime { get; set; }
    }
}
