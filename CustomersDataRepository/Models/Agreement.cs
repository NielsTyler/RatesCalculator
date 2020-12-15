using System;

namespace RatesCalculator.DAL.Models
{
    public enum BaseRateCode
    {
        VILIBOR1m,
        VILIBOR3m,
        VILIBOR6m,
        VILIBOR1y
    }
    public class Agreement
    {
        public int ID { get; set; }
        public Int64 CustomerID { get; set; }
        public BaseRateCode BaseRateCode { get; set; }
        public decimal Amount { get; set; }
        public decimal Margin { get; set; }
        public int Duration { get; set; }
    }
}