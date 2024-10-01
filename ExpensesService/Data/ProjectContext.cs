using Microsoft.EntityFrameworkCore;
using ExpensesService.Models;

namespace ExpensesService.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }

    }

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
                if (context == null || context.ExpenseTypes == null)
                {
                    throw new ArgumentNullException("Null ProjectContext");
                }

                if (!context.ExpenseTypes.Any())
                {
                    context.ExpenseTypes.AddRange(
                         new ExpenseType
                         {
                             Name = "Advertising"
                         },
                         new ExpenseType
                         {
                             Name = "Gas"
                         },
                         new ExpenseType
                         {
                             Name = "Repairs & Maintenance"
                         },
                         new ExpenseType
                         {
                             Name = "Meals & Entertainment"
                         },
                         new ExpenseType
                         {
                             Name = "Supplies"
                         },
                         new ExpenseType
                         {
                             Name = "Office Expenses"
                         },
                         new ExpenseType
                         {
                             Name = "Rent"
                         },
                         new ExpenseType
                         {
                             Name = "Travel"
                         },
                         new ExpenseType
                         {
                             Name = "Telephone & Utilities"
                         },
                         new ExpenseType
                         {
                             Name = "Licenses, Dues, Memberships"
                         },
                         new ExpenseType
                         {
                             Name = "Salaries, Wages and Benefits"
                         },
                         new ExpenseType
                         {
                             Name = "Misc"
                         }
                     );

                    context.SaveChanges();
                }
            }
        }
    }
}
