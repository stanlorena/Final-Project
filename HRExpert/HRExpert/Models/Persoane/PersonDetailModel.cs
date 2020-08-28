using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Persoane
{
    public class PersonDetailModel
    {
        public int PersonId { get; set; }
        public int Marca { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNastere { get; set; }
        public string Sex { get; set; }
        public string Nationalitate { get; set; }
        public string Email { get; set; }
        public IEnumerable<PersonIdentity> PersonIdentity { get; set; }
        public IEnumerable<PersonAddress> PersonAddress { get; set; }
    }
}
