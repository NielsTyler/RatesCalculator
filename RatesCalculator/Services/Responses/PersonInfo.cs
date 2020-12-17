namespace RatesCalculator.Services.ResultModels
{
    using RatesCalculator.DAL.Domain.Models;
    using System;

    public class PersonInfo
    {
        public PersonInfo(Customer customer)
        {
            FullName = customer.FullName;
            PersonalId = customer.PersonalID;
        }
        public string FullName { get; set; }

        public Int64 PersonalId { get; set; }
    }
}
