using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IContractOrgAssignment
    {
        IEnumerable<ContractOrganizatoricalAssignment> GetAll();
        ContractOrganizatoricalAssignment GetById(int coaId);
        void Add(ContractOrganizatoricalAssignment coa);
        IEnumerable<ContractOrganizatoricalAssignment> GetContractOrganizatoricalAssignmentHistory(int id);
    }
}
