namespace RatesCalculator.DAL.Persistence.DBContext
{
    using RatesCalculator.DAL.Domain.Models;
    using System.Data.Entity;

    public class RatesCalculatorContext : DbContext
    {
        public RatesCalculatorContext() : base("RatesCalculatorContext")
        {
            Database.SetInitializer(new RatesCalculatorInitializer());
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Agreement> Agreements { get; set; }
    }
}
