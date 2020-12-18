namespace RatesCalculator.Services.Interfaces
{
    using RatesCalculator.DAL.Domain.Enums;
    using RatesCalculator.Services.ResultModels;
    using System;
    using System.Threading.Tasks;

    public interface IRatesCalculationSerivce
    {
        ChangedRateInfo GetNewRateCustomerData(Int64 AgreementID, EBaseRateCode newBaseRateCode);
    }
}
