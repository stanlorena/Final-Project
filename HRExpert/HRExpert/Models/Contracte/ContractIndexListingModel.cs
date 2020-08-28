using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class ContractIndexListingModel
    {
        public int Id { get; set; }
        public string TipContract { get; set; }
        public int NumarContract { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
    }
}
