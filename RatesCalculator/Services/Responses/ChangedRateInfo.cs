namespace RatesCalculator.Services.ResultModels
{
    using System;

    public class ChangedRateInfo
    {
        public PersonInfo Person { get; set; }

        public AgreementInfo Agreement { get; set; }

        public decimal OriginalInterestRate { get; set; }

        public decimal NewInterestRate { get; set; }

        public decimal InterestRateDelta
        {
            get
            {
                return Math.Abs(NewInterestRate - OriginalInterestRate);
            }
        }
    }
}
