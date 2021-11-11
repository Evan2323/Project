using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Albina.DataAcsses.Core.Models
{
    [Table("User")]
    public class UserRto
    {
        #region Главное
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required] public string PhoneNumberPrefix { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required, MinLength(7)] public string  Password{ get; set; }
        public string ImageName { get; set; }
        #endregion Главное Конец
        #region Ключи
        public List<VirtualExpenseRto> VirtualExpenses { get; set; }
        public List<RejectExpenseRto> RejectExpense { get; set; }
        public List<AcceptExpenseRto> AcceptExpense { get; set; }
        #endregion Конец Ключей

    }
}