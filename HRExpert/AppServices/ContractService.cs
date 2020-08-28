using AppData;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class ContractService : IContract
    {
        private HrContext _context;

        public ContractService(HrContext context)
        {
            _context = context;
        }
        public void Add(Contract newContract)
        {
            _context.Add(newContract);
            _context.SaveChanges();
        }

        public IEnumerable<Contract> GetAll()
        {
            return _context.Contracts.Include(c => c.Person);
        }

        public Contract GetById(int id)
        {
            return _context.Contracts
                .Include(c => c.Person)
                .FirstOrDefault(c => c.Id == id);
        }

        public ContractFiscality GetContractFiscality()
        {
            throw new NotImplementedException();
        }

        public ContractInsurance GetContractInsurance()
        {
            throw new NotImplementedException();
        }

        public ContractOrganizatoricalAssignment GetContractOrg()
        {
            throw new NotImplementedException();
        }

        public ContractPeriod GetContractPeriod()
        {
            throw new NotImplementedException();
        }

        public ContractSalary GetContractSalary()
        {
            throw new NotImplementedException();
        }

        public ContractWorkProgram GetContractWorkProgram()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int contractId)
        {
            var personId = _context.Contracts
                .FirstOrDefault(c => c.Id == contractId)
                .Person.Id;

            return _context.Persons
                .FirstOrDefault(p => p.Id == personId);
        }
    }
}
