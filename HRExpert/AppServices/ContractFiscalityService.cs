﻿using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class ContractFiscalityService : IContractFiscality
    {

        private HrContext _context;

        public ContractFiscalityService(HrContext context)
        {
            _context = context;
        }
        public void Add(ContractFiscality contractFiscality)
        {
            _context.Add(contractFiscality);
            _context.SaveChanges();
        }

        public void Edit(int contractFiscalityId, string fiscalitate, bool seAcordaDeduceri, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractFiscality = _context.ContractFiscalities.FirstOrDefault(c => c.Id == contractFiscalityId);

            contractFiscality.Fiscalitate = fiscalitate;
            contractFiscality.SeAcordaDeduceri = seAcordaDeduceri;
            contractFiscality.DataInceput = dataInceput;
            contractFiscality.DataSfarsit = dataSfarsit;

            _context.SaveChanges();
        }

        public IEnumerable<ContractFiscality> GetAll()
        {
            return _context.ContractFiscalities;
        }

        public ContractFiscality GetById(int fiscalityId)
        {
            return _context.ContractFiscalities.
                FirstOrDefault(f => f.Id == fiscalityId);
        }

        public IEnumerable<ContractFiscality> GetContractFiscalityHistory(int id)
        {
            return _context.ContractFiscalities.
                Where(c => c.Contract.Id == id).
                OrderByDescending(c => c.DataInceput);
        }

        public void Remove(ContractFiscality contractFiscality)
        {
            _context.Remove(contractFiscality);
            _context.SaveChanges();
        }
    }
}
