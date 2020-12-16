using RatesCalculator.DAL.Interfaces;
using RatesCalculator.DAL.Models;
using RatesCalculator.DAL.Persistence.DBContext;
using RatesCalculator.DAL.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.DAL.Persistence.Repositories
{
    public class AgreementRepository : BaseRepository, IAgreementRepository
    {
        public AgreementRepository(RatesCalculatorContext context) : base(context)
        {
        }

        public Agreement GetAgreementById(Int64 id)
        {
            return _context.Agreements.Include("Customer").FirstOrDefault(a => a.ID == id);
        }
    }
}
