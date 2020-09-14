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

        public void Edit(int contractOrgAssignmentId, string departament, string functie, DateTime dataInceput, DateTime dataSfarsit)
        {
            var coa = _context.ContractOrganizatoricalAssignments.FirstOrDefault(c => c.Id == contractOrgAssignmentId);

            coa.Departament = departament;
            coa.Functie = functie;
            coa.DataInceput = dataInceput;
            coa.DataSfarsit = dataSfarsit;

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

        public void Remove(ContractOrganizatoricalAssignment coa)
        {
            _context.Remove(coa);
            _context.SaveChanges();
        }
    }
}
