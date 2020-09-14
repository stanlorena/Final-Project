using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class ContractPeriodService : IContractPeriod
    {
        private HrContext _context;

        public ContractPeriodService(HrContext context)
        {
            _context = context;
        }

        public void Add(ContractPeriod contractPeriod)
        {
            _context.Add(contractPeriod);
            _context.SaveChanges();
        }

        public void Edit(int contractPeriodId, string perioada, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractPeriod = _context.ContractPeriods.FirstOrDefault(c => c.Id == contractPeriodId);

            contractPeriod.Perioada = perioada;
            contractPeriod.DataInceput = dataInceput;
            contractPeriod.DataSfarsit = dataSfarsit;

            _context.SaveChanges();
        }

        public IEnumerable<ContractPeriod> GetAll()
        {
            return _context.ContractPeriods;
        }

        public ContractPeriod GetById(int periodId)
        {
            return _context.ContractPeriods.
                FirstOrDefault(c => c.Id == periodId);
        }

        public IEnumerable<ContractPeriod> GetContractPeriodHistory(int id)
        {
            return _context.ContractPeriods.
                Where(c => c.Contract.Id == id).
                OrderByDescending(c => c.DataInceput);
        }

        public void Remove(ContractPeriod contractPeriod)
        {
            _context.Remove(contractPeriod);
            _context.SaveChanges();
        }
    }
}
