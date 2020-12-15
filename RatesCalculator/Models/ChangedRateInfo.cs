using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatesCalculator.Models
{
    public class ChangedRateInfo
    {
        public Customer Person { get; set; }
        public Agreement Agreement { get; set; }
        public decimal InterestRateDelta { get; set; }
        public decimal NewInterestRateDelta { get; set; }
    }
}