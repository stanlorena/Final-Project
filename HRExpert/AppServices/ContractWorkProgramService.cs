using AppData;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppServices
{
    public class ContractWorkProgramService : IContractWorkProgram
    {
        private HrContext _context;

        public ContractWorkProgramService(HrContext context)
        {
            _context = context;
        }

        public void Add(ContractWorkProgram contractWorkProgram)
        {
            _context.Add(contractWorkProgram);
            _context.SaveChanges();
        }

        public void Edit(int contractWorkProgramId, string programLucru, string norma, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractWorkProgram = _context.ContractWorkPrograms.FirstOrDefault(c => c.Id == contractWorkProgramId);

            contractWorkProgram.ProgramLucru = programLucru;
            contractWorkProgram.Norma = norma;
            contractWorkProgram.DataInceput = dataInceput;
            contractWorkProgram.DataSfarsit = dataSfarsit;

            _context.SaveChanges();
        }

        public IEnumerable<ContractWorkProgram> GetAll()
        {
            return _context.ContractWorkPrograms;
        }

        public ContractWorkProgram GetById(int wpId)
        {
            return _context.ContractWorkPrograms.
                FirstOrDefault(c => c.Id == wpId);
        }

        public IEnumerable<ContractWorkProgram> GetContractWorkProgramHistory(int id)
        {
            return _context.ContractWorkPrograms.
                Where(c => c.Contract.Id == id).
                OrderByDescending(c => c.DataInceput);
        }

        public void Remove(ContractWorkProgram contractWorkProgram)
        {
            _context.Remove(contractWorkProgram);
            _context.SaveChanges();
        }
    }
}
