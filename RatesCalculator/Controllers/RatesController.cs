using RatesCalculator.DAL.Models;
using RatesCalculator.DAL.Interfaces;
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
        private readonly IImpactEvaluatorSerivce _ratesCalculationSerivce;
        private readonly ICustomerRepository _customerRepository;

        public RatesController(ICustomerRepository customerRepository, IImpactEvaluatorSerivce ratesCalculationSerivce)
        {
            _customerRepository = customerRepository;
            _ratesCalculationSerivce = ratesCalculationSerivce;
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
        public List<DAL.Models.Customer> Get()
        {
            List<DAL.Models.Customer> lst = _customerRepository.List();
            Console.WriteLine(lst.Count);

            return lst;
        }
    }
}
