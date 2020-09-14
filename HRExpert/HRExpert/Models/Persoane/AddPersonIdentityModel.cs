using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Persoane
{
    public class AddPersonIdentityModel
    {
        public long CNP { get; set; }
        public string Serie { get; set; }
        public int Numar { get; set; }
        public string Emitent { get; set; }
        public DateTime DataEmitere { get; set; }
        public DateTime DataExpirare { get; set; }
        public int PersonIdentityId { get; set; }
        public int IdPersoana { get; set; }
        public Person Persoana { get; set; }
    }
}
