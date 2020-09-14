using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class AddContractOrgAssignmentModel
    {
        public string Departament { get; set; }
        public string Functie { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int ContractOrganizatoricalAssignmentId { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
