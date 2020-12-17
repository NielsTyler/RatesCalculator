namespace RatesCalculator.DAL.Persistence.Repositories
{
    using RatesCalculator.DAL.Domain.Models;
    using RatesCalculator.DAL.Interfaces;
    using RatesCalculator.DAL.Persistence.DBContext;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(RatesCalculatorContext context) : base(context)
        {
        }

        public List<Customer> List()
        {
            return _context.Customers.Include(nameof(Agreement)).ToList();
        }
    }
}
