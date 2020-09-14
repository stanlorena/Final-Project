using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class ContractInsuranceService : IContractInsurance
    {
        public HrContext _context;

        public ContractInsuranceService(HrContext context)
        {
            _context = context;
        }

        public void Add(ContractInsurance contractInsurance)
        {
            _context.Add(contractInsurance);
            _context.SaveChanges();
        }

        public void Edit(int contractInsuranceId, string asigurare, string companieAsigurare, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractInsurance = _context.ContractInsurances.FirstOrDefault(c => c.Id == contractInsuranceId);

            contractInsurance.Asigurare = asigurare;
            contractInsurance.CompanieAsigurare = companieAsigurare;
            contractInsurance.DataInceput = dataInceput;
            contractInsurance.DataSfarsit = dataSfarsit;

            _context.SaveChanges();
        }

        public IEnumerable<ContractInsurance> GetAll()
        {
            return _context.ContractInsurances;
        }

        public ContractInsurance GetById(int insuranceId)
        {
            return _context.ContractInsurances.
                FirstOrDefault(i => i.Id == insuranceId);
        }

        public IEnumerable<ContractInsurance> GetContractInsuranceHistory(int id)
        {
            return _context.ContractInsurances.
                Where(i => i.Contract.Id == id).
                OrderByDescending(i => i.DataInceput);
        }

        public void Remove(ContractInsurance contractInsurance)
        {
            _context.Remove(contractInsurance);
            _context.SaveChanges();
        }
    }
}
