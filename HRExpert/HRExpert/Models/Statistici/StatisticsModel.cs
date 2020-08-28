using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Statistici
{
    public class StatisticsModel
    {
        public int NrFemei { get; set; }
        public int NrBarbati { get; set; }
        public int NrPersoane { get; set; }
        public int NrContracte { get; set; }
        public int NrContractePerioadaNedeterminata { get; set; }
        public int NrContractePerioadaDeterminata { get; set; }
        public double SalariuMediu { get; set; }
    }
}
