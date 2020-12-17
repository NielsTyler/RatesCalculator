namespace RatesCalculator.DAL.Interfaces
{
    using RatesCalculator.DAL.Domain.Models;
    using System.Collections.Generic;

    public interface ICustomerRepository
    {
        List<Customer> List();
    }
}
