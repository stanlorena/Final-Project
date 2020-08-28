using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class ContractOrganizatoricalAssignmentService : IContractOrgAssignment
    {
        private HrContext _context;

        public ContractOrganizatoricalAssignmentService(HrContext context)
        {
            _context = context;
        }

        public void Add(ContractOrganizatoricalAssignment coa)
        {
            _context.Add(coa);
            _context.SaveChanges();
        }

        public IEnumerable<ContractOrganizatoricalAssignment> GetAll()
        {
            return _context.ContractOrganizatoricalAssignments;
        }

        public ContractOrganizatoricalAssignment GetById(int coaId)
        {
            return _context.ContractOrganizatoricalAssignments.
                FirstOrDefault(c => c.Id == coaId);
        }

        public IEnumerable<ContractOrganizatoricalAssignment> GetContractOrganizatoricalAssignmentHistory(int id)
        {
            return _context.ContractOrganizatoricalAssignments.
                Where(c => c.Contract.Id == id).
                OrderByDescending(c => c.DataInceput);
        }
    }
}
