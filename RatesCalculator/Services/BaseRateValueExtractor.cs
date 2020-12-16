using RatesCalculator.DAL.Models;
using RatesCalculator.Services.Helpers;
using RatesCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace RatesCalculator.Services
{
    public class BaseRateValueExtractor : IBaseRateValueExtractor
    {
        public const string BASIC_RATE_VALUE_PROVIDER_LINK = "http://www.lb.lt/webservices/VilibidVilibor/VilibidVilibor.asmx/getLatestVilibRate?RateType=";
        public BaseRateValueExtractor()
        {
            ApiHelper.InitializeClient();
        }

        public async Task<decimal> RetrieveBasicRateValueAsync(EBaseRateCode basicValueCode)
        {
            decimal result = 0;

            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(BASIC_RATE_VALUE_PROVIDER_LINK + basicValueCode.ToString()).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();

                        XDocument doc = XDocument.Parse(res);
                        if (doc.Root.Name.LocalName == "decimal")
                        {
                            result = Convert.ToDecimal(doc.Root.Value);
                        }
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }
    }
}