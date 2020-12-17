using RatesCalculator.DAL.Domain.Enums;
using RatesCalculator.Services.Interfaces;
using RatesCalculator.Services.ResultModels;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Web.Http;

namespace RatesCalculator.Controllers
{
    public class RatesController : ApiController
    {
        private readonly IRatesCalculationSerivce _ratesCalculationSerivce;

        public RatesController(IRatesCalculationSerivce ratesCalculationSerivce)
        {
            _ratesCalculationSerivce = ratesCalculationSerivce;
        }

        [HttpGet]
        [Route("api/GetEvaluatedImpactInfo")]
        #region Swagger attributes
        [SwaggerResponse(HttpStatusCode.OK, "Indicates that the request succeeded and that the requested information is in the response.",
            typeof(ChangedRateInfo))]
        //[SwaggerResponse(HttpStatusCode.BadRequest, "Bad Request - the request could not be understood or was missing required parameters.",
        //    typeof(ErrorResponse))]
        [SwaggerResponse(HttpStatusCode.NotFound, @"Indicates that the requested resource does not exist on the server.
            <br/>Error codes:
            <br/>502 - User not found;"/*, typeof(ErrorResponse)*/)]
        #endregion
        public ChangedRateInfo GetEvaluatedImpactInfo([FromUri] Int64 agreementId, [FromUri] EBaseRateCode newBaseRateCode)
        {
            ChangedRateInfo changedRateInfo = new ChangedRateInfo();

            changedRateInfo = _ratesCalculationSerivce.GetNewRateCustomerDataAsync(agreementId, newBaseRateCode).Result;

            return changedRateInfo;
        }
    }
}
