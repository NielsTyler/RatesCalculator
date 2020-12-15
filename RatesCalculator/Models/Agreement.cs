using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatesCalculator.Models
{
    public class Agreement
    {
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public decimal Margin { get; set; }
        public int Duration { get; set; }
    }
}