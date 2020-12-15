using RatesCalculator.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CustomersDataRepository.DBContext
{
    public class CustomerRatesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CustomersRatesContext>
    {
        protected override void Seed(CustomersRatesContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{FullName="Goras Trusevičius",ID=67812203006},
                new Customer{FullName="Dange Kulkavičiutė",ID=78706151287}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            var agreements = new List<Agreement>
            {
            new Agreement { Amount = 12000, BaseRateCode = BaseRateCode.VILIBOR3m, Margin = 1.6M, Duration = 60, CustomerID = 67812203006 },
            new Agreement { Amount = 8000, BaseRateCode = BaseRateCode.VILIBOR1y, Margin = 2.2M, Duration = 36, CustomerID = 78706151287 },
            new Agreement { Amount = 1000, BaseRateCode = BaseRateCode.VILIBOR6m, Margin = 1.85M, Duration = 24, CustomerID = 78706151287 }
            };
            agreements.ForEach(s => context.Agreements.Add(s));
            context.SaveChanges();            
        }
    }
}
