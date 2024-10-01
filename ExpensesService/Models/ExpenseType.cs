using System.ComponentModel.DataAnnotations;

namespace ExpensesService.Models
{
    public class ExpenseType
    {
        public int ID { get; set; }

        [Display(Name = "Expense Type")]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
