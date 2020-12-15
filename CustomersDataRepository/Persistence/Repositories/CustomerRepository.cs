using RatesCalculator.DAL.Interfaces;
using RatesCalculator.DAL.Models;
using RatesCalculator.DAL.Persistence.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.DAL.Persistence.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(RatesCalculatorContext context) : base(context)
        {
        }
        public List<Customer> List()
        {
            return _context.Customers.Include("Agreement").ToList();
        }
    }
}
