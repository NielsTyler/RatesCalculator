namespace RatesCalculator.Services.ResultModels
{
    using RatesCalculator.DAL.Models;

    public class AgreementInfo
    {
        public AgreementInfo(Agreement agreement)
        {
            BaseRateCode = agreement.BaseRateCode;
            Amount = agreement.Amount;
            Margin = agreement.Margin;
            Duration = agreement.Duration;
        }

        public EBaseRateCode BaseRateCode { get; set; }

        public decimal Amount { get; set; }

        public decimal Margin { get; set; }

        public int Duration { get; set; }
    }
}
