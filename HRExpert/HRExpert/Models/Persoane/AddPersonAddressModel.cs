using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Persoane
{
    public class AddPersonAddressModel
    {
        public string Strada { get; set; }
        public int Numar { get; set; }
        public string Bloc { get; set; }
        public int Etaj { get; set; }
        public int Apartament { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int PersonAddressId { get; set; }
        public int IdPersoana { get; set; }
        public Person Persoana { get; set; }
    }
}
