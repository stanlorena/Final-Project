using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class AddContractWorkProgramModel
    {
        public string ProgramLucru { get; set; }
        public string Norma { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int ContractWorkProgramId { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
