using Autofac;
using Autofac.Integration.WebApi;
using RatesCalculator.DAL.Interfaces;
using RatesCalculator.DAL.Persistence.DBContext;
using RatesCalculator.DAL.Persistence.Repositories;
using RatesCalculator.Services;
using RatesCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace RatesCalculator.App_Start
{
    public static class ContainerConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<RatesCalculatorContext>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<AgreementRepository>().As<IAgreementRepository>();
            builder.RegisterType<RatesCalculationSerivce>().As<IRatesCalculationSerivce>();

            builder.RegisterType<ChangedRateImpactEvaluator>().As<IChangedRateImpactEvaluator>();
            builder.RegisterType<RatesCalculationSerivce>().As<IRatesCalculationSerivce>();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}