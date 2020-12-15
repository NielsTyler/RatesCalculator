﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.Services.Interfaces
{
    interface IRatesCalculationSerivce
    {
        decimal CalculateInterestRate(decimal basicRate, decimal margin);
    }
}
