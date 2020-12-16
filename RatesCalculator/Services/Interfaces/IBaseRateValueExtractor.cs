using RatesCalculator.DAL.Models;
using System.Threading.Tasks;

namespace RatesCalculator.Services.Interfaces
{
    public interface IBaseRateValueExtractor
    {
        Task<decimal> RetrieveBasicRateValueAsync(EBaseRateCode basicValueCode);
    }
}