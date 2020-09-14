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
        void Remove(ContractInsurance contractInsurance);
        void Edit(int contractInsuranceId, string asigurare, string companieAsigurare, DateTime dataInceput, DateTime dataSfarsit);
        IEnumerable<ContractInsurance> GetContractInsuranceHistory(int id);
    }
}
