namespace RatesCalculator.DAL.Domain.Models
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public Int64 ID { get; set; }

        public Int64 PersonalID { get; set; }

        public string FullName { get; set; }

        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
