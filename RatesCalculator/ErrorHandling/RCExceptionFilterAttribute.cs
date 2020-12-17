using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace RatesCalculator.ErrorHandling
{
    public class RCExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            var rcException = context.Exception.InnerException as RCException;
            HttpStatusCode statusCode = HttpStatusCode.BadRequest;

            if (rcException != null)
            {                
                switch (rcException.ErrorCode)
                {
                    case ErrorCode.DataNotFound:
                        statusCode = HttpStatusCode.NotFound;
                        break;
                    default:
                        statusCode = HttpStatusCode.BadRequest;
                        break;
                }                
            }
           
            context.Response = new HttpResponseMessage(statusCode);
        }
    }
}