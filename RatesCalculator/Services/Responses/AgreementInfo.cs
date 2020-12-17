namespace RatesCalculator.Services.ResultModels
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using RatesCalculator.DAL.Domain.Enums;
    using RatesCalculator.DAL.Domain.Models;

    public class AgreementInfo
    {
        public AgreementInfo(Agreement agreement)
        {
            BaseRateCode = agreement.BaseRateCode;
            Amount = agreement.Amount;
            Margin = agreement.Margin;
            Duration = agreement.Duration;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public EBaseRateCode BaseRateCode { get; set; }

        public decimal Amount { get; set; }

        public decimal Margin { get; set; }

        public int Duration { get; set; }
    }
}
