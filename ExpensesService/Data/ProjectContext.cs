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
        public DbSet<Product> Products { get; set; }

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

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                    new Product
                    {
                        Description = "A robot head with an unusually large eye and teloscpic neck -- excellent for exploring high spaces.",
                        Name = "Large Cyclops",
                        ImageName = "head-big-eye.png",
                        Category = "Heads",
                        Price = 1220.5,
                        Discount = 0.2,
                    },
                    new Product
                    {
                        Description = "A spring base - great for reaching high places.",
                        Name = "Spring Base",
                        ImageName = "base-spring.png",
                        Category = "Bases",
                        Price = 1190.5,
                        Discount = 0,
                    }
                    ,
                    new Product
                    {
                        Description = "An articulated arm with a claw -- great for reaching around corners or working in tight spaces.",
                        Name = "Articulated Arm",
                        ImageName = "arm-articulated-claw.png",
                        Category = "Arms",
                        Price = 275,
                        Discount = 0,
                    },
                    new Product
                    {
                      Description = "A simple torso with a pouch for carrying items.",
                      Name = "Pouch Torso",
                      ImageName = "torso-pouch.png",
                      Category = "Torsos",
                      Price = 785,
                      Discount = 0,
                    });

                    context.SaveChanges();
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
