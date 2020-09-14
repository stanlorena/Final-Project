using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class AddContractInsuranceModel
    {
        public string Asigurare { get; set; }
        public string CompanieAsigurare { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int ContractInsuranceId { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
