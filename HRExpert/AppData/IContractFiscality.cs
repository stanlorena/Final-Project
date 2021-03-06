﻿using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IContractFiscality
    {
        IEnumerable<ContractFiscality> GetAll();
        ContractFiscality GetById(int fiscalityId);
        void Add(ContractFiscality contractFiscality);
        void Remove(ContractFiscality contractFiscality);
        void Edit(int contractFiscalityId, string fiscalitate, bool seAcordaDeduceri, DateTime dataInceput, DateTime dataSfarsit);
        IEnumerable<ContractFiscality> GetContractFiscalityHistory(int id);

    }
}
