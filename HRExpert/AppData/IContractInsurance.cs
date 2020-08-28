using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IContractInsurance
    {
        IEnumerable<ContractInsurance> GetAll();
        ContractInsurance GetById(int insuranceId);
        void Add(ContractInsurance contractInsurance);
        IEnumerable<ContractInsurance> GetContractInsuranceHistory(int id);
    }
}
