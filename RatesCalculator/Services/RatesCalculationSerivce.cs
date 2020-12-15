using RatesCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatesCalculator.Services
{
    public class RatesCalculationSerivce: IImpactEvaluatorSerivce
    {
        public RatesCalculationSerivce()
        {             
        }
        public decimal CalculateInterestRate(decimal basicRate, decimal margin)
        {
            return basicRate + margin;
        }
    }
}