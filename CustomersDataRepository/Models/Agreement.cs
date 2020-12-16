using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RatesCalculator.DAL.Models
{
    public class Agreement
    {
        public Int64 ID { get; set; }
        public Int64 CustomerID { get; set; }
        public EBaseRateCode BaseRateCode { get; set; }
        public decimal Amount { get; set; }
        public decimal Margin { get; set; }
        public int Duration { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }
}