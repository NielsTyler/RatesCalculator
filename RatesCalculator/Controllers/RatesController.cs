using RatesCalculator.DAL.Models;
using RatesCalculator.Models;
using RatesCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatesCalculator.Controllers
{
    public class RatesController : ApiController
    {
        //private List<Agreement> agreements = new List<Agreement>();
        private readonly IRatesCalculationSerivce _ratesCalculationSerivce;

        public RatesController()
        {            
        }

        //[HttpGet]
        ////[Route("getImpact")]
        //public ChangedRateInfo GetEvaluatedImpactInfo([FromUri]BaseRateCodes newBaseRateCode, [FromUri]Agreement userAgreement)
        //{
        //    //ValidateBaseRateCode();
        //    Console.Write(userAgreement.Amount); //+ newBaseRateCode.ToString());

        //    return new ChangedRateInfo();
        //}        

        [HttpGet]
        [Route("")]
        public ChangedRateInfo GetEvaluatedImpactInfo(BaseRateCode newBaseRateCode, int agreementId )
        {
            return new ChangedRateInfo();
        }

        [HttpGet]
        public String Get()
        {
            return "Hello";
        }
    }
}
