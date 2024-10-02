namespace ExpensesService.Models
{
    public class Product
    {
        public int Id { get; set; }

        public required string Description { get; set; }

        public required string Name { get; set; }

        public required string ImageName { get; set; }

        public required string Category { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }
    }
}
