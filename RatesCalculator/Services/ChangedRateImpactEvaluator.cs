using RatesCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace RatesCalculator.Services
{
    public class ChangedRateImpactEvaluator: IChangedRateImpactEvaluator
    {        
        public decimal CalculateInterestRate(decimal basicRateValue, decimal margin)
        {            
            return basicRateValue + margin;
        }
    }
}