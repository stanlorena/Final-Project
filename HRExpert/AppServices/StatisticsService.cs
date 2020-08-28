using AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class StatisticsService : IStatistics
    {
        private HrContext _context;

        public StatisticsService(HrContext context)
        {
            _context = context;
        }
        public int GetContractePerDeterminata()
        {
            return _context.ContractPeriods
                .Where(p => p.Perioada == "Determinata")
                .Count();
        }

        public int GetContractePerNedeterminata()
        {
            return _context.ContractPeriods
                .Where(p => p.Perioada == "Nedeterminata")
                .Count();
        }

        public int GetNrBarbati()
        {
            return _context.Persons
                .Where(p => p.Sex == "M")
                .Count();
        }

        public int GetNrContracte()
        {
            return _context.Contracts.Count();
        }

        public int GetNrFemei()
        {
            return _context.Persons
                .Where(p => p.Sex == "F")
                .Count();
        }

        public int GetNrPersoane()
        {
            return _context.Persons.Count();
        }

        public double GetSalariuMediu()
        {
            return _context.ContractSalaries.
                Select(s => s.Salariu).
                Average();
        }
    }
}
