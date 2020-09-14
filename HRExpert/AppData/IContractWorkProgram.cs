using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IContractWorkProgram
    {
        IEnumerable<ContractWorkProgram> GetAll();
        ContractWorkProgram GetById(int wpId);
        void Add(ContractWorkProgram contractWorkProgram);
        void Edit(int contractWorkProgramId, string programLucru, string norma, DateTime dataInceput, DateTime dataSfarsit);
        void Remove(ContractWorkProgram contractWorkProgram);
        IEnumerable<ContractWorkProgram> GetContractWorkProgramHistory(int id);
    }
}
