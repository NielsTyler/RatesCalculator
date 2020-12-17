using RatesCalculator.DAL.Domain.Enums;
using RatesCalculator.ErrorHandling;
using RatesCalculator.Services.Interfaces;
using RatesCalculator.Services.ResultModels;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatesCalculator.Controllers
{
    public class RatesCalculatorController : ApiController
    {
        private readonly IRatesCalculationSerivce _ratesCalculationSerivce;

        public RatesCalculatorController(IRatesCalculationSerivce ratesCalculationSerivce)
        {
            _ratesCalculationSerivce = ratesCalculationSerivce;
        }

        /// <summary>
        /// This Api method will help to evaluate how the change of base rate will impact the interest rate.
        /// </summary>
        /// <param name="agreementId">Agreement ID for retrieving specific person, margin and base rate information</param>
        /// <param name="newBaseRateCode">New base rate code</param>
        /// <returns>The response contains information about person, agreement, interest rate for current base rate, interest rate for new base rate and
        /// difference between current and new interest rates.</returns>
        [HttpGet]
        [Route("api/GetEvaluatedImpactInfo")]
        #region Swagger attributes
        [SwaggerResponse(HttpStatusCode.OK, "Indicates that the request succeeded and that the requested information is in the response.",
            typeof(ChangedRateInfo))]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Bad Request - the request could not be understood or was missing required parameters.")]
        [SwaggerResponse(HttpStatusCode.NotFound, @"Indicates that the requested resource does not exist on the server.
            <br/>Error codes:
            <br/>502 - Agreement not found;"/*, typeof(ErrorResponse)*/)]
        #endregion
        public HttpResponseMessage GetEvaluatedImpactInfo([FromUri] Int64 agreementId, [FromUri] EBaseRateCode newBaseRateCode)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            ChangedRateInfo changedRateInfo = new ChangedRateInfo();

            //TODO: Add parameters validation here

            try
            {                
                changedRateInfo = _ratesCalculationSerivce.GetNewRateCustomerDataAsync(agreementId, newBaseRateCode).Result;
            }
            catch (RCException ex)
            {
                
            }

            return this.Request.CreateResponse(statusCode, changedRateInfo);
        }
    }
}
