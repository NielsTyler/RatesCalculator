namespace RatesCalculator.DAL.Persistence.DBContext
{
    using RatesCalculator.DAL.Domain.Enums;
    using RatesCalculator.DAL.Domain.Models;
    using System.Collections.Generic;

    public class RatesCalculatorInitializer : System.Data.Entity.DropCreateDatabaseAlways<RatesCalculatorContext>
    {
        protected override void Seed(RatesCalculatorContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{ ID = 1, FullName = "Goras Trusevičius", PersonalID = 67812203006 },
                new Customer{ ID = 2, FullName = "Dange Kulkavičiutė", PersonalID = 78706151287 }
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var agreements = new List<Agreement>
            {
                new Agreement {ID = 1, Amount = 12000, BaseRateCode = EBaseRateCode.VILIBOR3m, Margin = 1.6M, Duration = 60, CustomerID = 1 },
                new Agreement { ID = 2, Amount = 8000, BaseRateCode = EBaseRateCode.VILIBOR1y, Margin = 2.2M, Duration = 36, CustomerID = 2 },
                new Agreement { ID = 3, Amount = 1000, BaseRateCode = EBaseRateCode.VILIBOR6m, Margin = 1.85M, Duration = 24, CustomerID = 2 }
            };

            agreements.ForEach(s => context.Agreements.Add(s));
            context.SaveChanges();
        }
    }
}
