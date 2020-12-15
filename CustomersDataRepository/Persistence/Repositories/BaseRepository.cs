using RatesCalculator.DAL.Persistence.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatesCalculator.DAL.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly RatesCalculatorContext _context;

        public BaseRepository(RatesCalculatorContext context)
        {
            _context = context;
        }
    }
}
