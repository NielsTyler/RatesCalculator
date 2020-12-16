using RatesCalculator.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.DAL.Interfaces
{
    public interface IAgreementRepository
    {
        Agreement GetAgreementById(Int64 id);
    }
}
