using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Marca { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public string Prenume { get; set; }
        [Required]
        public DateTime DataNastere { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Nationalitate { get; set; }
        public string Email { get; set; }
        //public PersonIdentity PersonIdentity { get; set; }
        //public PersonAddress PersonAddress { get; set; }
    }
}
