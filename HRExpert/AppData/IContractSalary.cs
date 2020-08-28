using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IContractSalary
    {
        IEnumerable<ContractSalary> GetAll();
        ContractSalary GetById(int salaryId);
        void Add(ContractSalary contractSalary);
        IEnumerable<ContractSalary> GetContractSalaryHistory(int id);

    }
}
