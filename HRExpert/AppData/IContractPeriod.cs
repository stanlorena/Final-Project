using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IContractPeriod
    {
        IEnumerable<ContractPeriod> GetAll();
        ContractPeriod GetById(int periodId);
        void Add(ContractPeriod contractPeriod);
        void Edit(int contractPeriodId, string perioada, DateTime dataInceput, DateTime dataSfarsit);
        void Remove(ContractPeriod contractPeriod);
        IEnumerable<ContractPeriod> GetContractPeriodHistory(int id);
    }
}
