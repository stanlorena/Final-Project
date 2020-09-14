using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class AddContractFiscalityModel
    {
        public string Fiscalitate { get; set; }
        public bool SeAcordaDeduceri { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int ContractFiscalityId { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
