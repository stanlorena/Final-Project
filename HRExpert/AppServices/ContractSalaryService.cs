using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class ContractSalaryService : IContractSalary
    {
        private HrContext _context;

        public ContractSalaryService(HrContext context)
        {
            _context = context;
        }

        public void Add(ContractSalary contractSalary)
        {
            _context.Add(contractSalary);
            _context.SaveChanges();
        }

        public IEnumerable<ContractSalary> GetAll()
        {
            return _context.ContractSalaries;
        }

        public ContractSalary GetById(int salaryId)
        {
            return _context.ContractSalaries.
                FirstOrDefault(c => c.Id == salaryId);
        }

        public IEnumerable<ContractSalary> GetContractSalaryHistory(int id)
        {
            return _context.ContractSalaries.
                Where(c => c.Contract.Id == id).
                OrderByDescending(c => c.DataInceput);
        }
    }
}
