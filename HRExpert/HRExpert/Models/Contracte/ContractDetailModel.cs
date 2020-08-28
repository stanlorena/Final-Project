using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class ContractDetailModel
    {
        public int Id { get; set; }
        public string TipContract { get; set; }
        public int NumarContract { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public IEnumerable<ContractFiscality> ContractFiscality { get; set; }
        public IEnumerable<ContractInsurance> ContractInsurance { get; set; }
        public IEnumerable<ContractOrganizatoricalAssignment> ContractOrganizatoricalAssignment { get; set; }
        public IEnumerable<ContractPeriod> ContractPeriod { get; set; }
        public IEnumerable<ContractSalary> ContractSalary { get; set; }
        public IEnumerable<ContractWorkProgram> ContractWorkProgram { get; set; }

    }
}
