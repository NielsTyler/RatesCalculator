using RatesCalculator.DAL.Interfaces;
using RatesCalculator.DAL.Models;
using RatesCalculator.Services.Helpers;
using RatesCalculator.Services.Interfaces;
using RatesCalculator.Services.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace RatesCalculator.Services
{
    public class RatesCalculationSerivce: IRatesCalculationSerivce
    {
        private readonly IChangedRateImpactEvaluator _impactEvaluator;
        private readonly IAgreementRepository _agreememtRepository;
        private readonly IBaseRateValueExtractor _baseRateValueExtractor;
        //public static ILogger Logger;

        public RatesCalculationSerivce(IChangedRateImpactEvaluator impactEvaluator, IAgreementRepository agreememtRepository, IBaseRateValueExtractor baseRateValueExtractor)
        {
            _agreememtRepository = agreememtRepository;
            _impactEvaluator = impactEvaluator;
            _baseRateValueExtractor = baseRateValueExtractor;
        }

        public async Task<ChangedRateInfo> GetNewRateCustomerDataAsync(Int64 AgreementID, EBaseRateCode newBaseRateCode)
        {
            ChangedRateInfo result = new ChangedRateInfo();

            if (AgreementID != 0)
            {
                var agreement = _agreememtRepository.GetAgreementById(AgreementID);

                decimal newBasicRateValue = _baseRateValueExtractor.RetrieveBasicRateValueAsync(newBaseRateCode).Result;                
                decimal originalBasicRateValue = _baseRateValueExtractor.RetrieveBasicRateValueAsync(agreement.BaseRateCode).Result;

                result.Agreement = new AgreementInfo(agreement);
                result.Person = new PersonInfo(agreement.Customer);
                
                result.OriginalInterestRate = _impactEvaluator.CalculateInterestRate(originalBasicRateValue, agreement.Margin);
                result.NewInterestRateDelta = _impactEvaluator.CalculateInterestRate(newBasicRateValue, agreement.Margin);
            }
            //else
            // Logger.Write("Parameters AgreementID can not contain empty value.");

            return result;
        }                   
    }
}