using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class AddContractModel
    {
        public int Id { get; set; }
        public int Marca { get; set; }
        public string TipContract { get; set; }
        public int NumarContract { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public Person Person { get; set; }
    }
}
