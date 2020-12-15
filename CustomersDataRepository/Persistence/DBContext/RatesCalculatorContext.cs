using RatesCalculator.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.DAL.Persistence.DBContext
{
    public class RatesCalculatorContext : DbContext
    {
        public RatesCalculatorContext () : base("RatesCalculatorContext")
        {
            Database.SetInitializer(new RatesCalculatorInitializer());
            //Database.SetInitializer(new DropCreateDatabaseAlways<RatesCalculatorContext >());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Agreement> Agreements { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
