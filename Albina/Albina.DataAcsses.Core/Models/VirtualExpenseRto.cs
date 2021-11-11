using Albina.DataAcsses.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Albina.DataAcsses.Core.Models
{
    [Table("VirtualExpense")]
    public class VirtualExpenseRto
    {
        [Key] public int Id { get; set; }
        public int AuthorId { get; set; }
        public string WhereSpend { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public VirtualExspenseStatus Status { get; set; }
        public DateTimeOffset CreateDateTime { get; set; }
        public List<DateTimeOffset> ChangeDateTimes { get; set; }
    }
}
