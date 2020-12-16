namespace RatesCalculator.Services.Interfaces
{
    using RatesCalculator.DAL.Models;
    using RatesCalculator.Services.ResultModels;
    using System;
    using System.Threading.Tasks;

    public interface IRatesCalculationSerivce
    {
        Task<ChangedRateInfo> GetNewRateCustomerDataAsync(Int64 AgreementID, EBaseRateCode newBaseRateCode);
    }
}
