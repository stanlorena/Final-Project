using System;
using System.Collections.Generic;
using AppData.Models;
using System.Text;

namespace AppData
{
    public interface IContract
    {
        IEnumerable<Contract> GetAll();
        Contract GetById(int id);
        void Add(Contract newContract);
        void Remove(Contract contract);
        void Edit(int id, string tipContract, int numarContract, DateTime dataInceput, DateTime dataSfarsit);
        Person GetPerson(int contractId);
        ContractFiscality GetContractFiscality();
        ContractInsurance GetContractInsurance();
        ContractOrganizatoricalAssignment GetContractOrg();
        ContractPeriod GetContractPeriod();
        ContractSalary GetContractSalary();
        ContractWorkProgram GetContractWorkProgram();
    }
}
