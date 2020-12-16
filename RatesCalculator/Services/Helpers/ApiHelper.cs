using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace RatesCalculator.Services.Helpers
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient() {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
        }
    }
}