using RatesCalculator.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersDataRepository.DBContext
{
    public class CustomersRatesContext: DbContext
    {
        public CustomersRatesContext() : base("RatesCalculatorDB")
        {
            Database.SetInitializer(new CustomerRatesInitializer());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CustomersRatesContext>());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Agreement> Agreements { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
