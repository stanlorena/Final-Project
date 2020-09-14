using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Persoane
{
    public class AddPersonModel
    {
        public int Id { get; set; }
        public int Marca { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNastere { get; set; }
        public string Sex { get; set; }
        public string Nationalitate { get; set; }
        public string Email { get; set; }
    }
}
