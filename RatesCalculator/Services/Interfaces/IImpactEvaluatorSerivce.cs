using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.Services.Interfaces
{
    public interface IImpactEvaluatorSerivce
    {
        decimal CalculateInterestRate(decimal basicRate, decimal margin);
    }
}
