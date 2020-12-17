using RatesCalculator.DAL.Models;
using RatesCalculator.DAL.Interfaces;
using RatesCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RatesCalculator.Services.ResultModels;

namespace RatesCalculator.Controllers
{
    public class RatesController : ApiController
    {
        //private List<Agreement> agreements = new List<Agreement>();
        private readonly IRatesCalculationSerivce _ratesCalculationSerivce;        

        public RatesController(IRatesCalculationSerivce ratesCalculationSerivce)
        {
            _ratesCalculationSerivce = ratesCalculationSerivce;             
        }
        
        [HttpGet]
        [Route("api/GetEvaluatedImpactInfo")]
        public ChangedRateInfo GetEvaluatedImpactInfo([FromUri]Int64 agreementId, [FromUri]EBaseRateCode newBaseRateCode)
        {
            ChangedRateInfo changedRateInfo = new ChangedRateInfo();

            changedRateInfo = _ratesCalculationSerivce.GetNewRateCustomerDataAsync(agreementId, newBaseRateCode).Result;           

            return changedRateInfo;
        }        
    }
}
