using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RatesCalculator.DAL.Domain.Enums;
using RatesCalculator.DAL.Domain.Models;
using RatesCalculator.DAL.Interfaces;
using RatesCalculator.Services;
using RatesCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.Tests.Service
{
    [TestClass]
    public class RateCalculationServiceTest
    {
        [TestMethod]
        public void InterestRateCalculationTest()
        {
            Mock<IBaseRateValueExtractor> baseRateValExtractor = new Mock<IBaseRateValueExtractor>();

            Decimal newBaseRateVal = 3.22M;
            Decimal originalBaseRateVal = 7.41M;

            baseRateValExtractor.SetupSequence(x => x.RetrieveBasicRateValueAsync(It.IsAny<DAL.Domain.Enums.EBaseRateCode>()))
                .Returns(Task.FromResult(newBaseRateVal))
                .Returns(Task.FromResult(originalBaseRateVal));

            IChangedRateImpactEvaluator ChangedRateImpactEvaluator = new ChangedRateImpactEvaluator();
            Mock<IAgreementRepository> agreementRep = new Mock<IAgreementRepository>();

            Agreement agr = new Agreement();
            agr.Customer = new Customer();
            agr.Margin = 1.6M;
            agreementRep.Setup(x => x.GetAgreementById(It.IsAny<long>())).Returns(agr);

            RatesCalculationSerivce service = new RatesCalculationSerivce(ChangedRateImpactEvaluator, agreementRep.Object, baseRateValExtractor.Object);

            var res = service.GetNewRateCustomerData(1, EBaseRateCode.VILIBOR1m);

            Assert.IsNotNull(res);

            Assert.IsTrue(res.NewInterestRate == 4.82M);
            Assert.IsTrue(res.OriginalInterestRate == 9.01M);
        }
    }
}
