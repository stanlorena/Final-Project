using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class PersonAddress
    {
        public int Id { get; set; }
        [Required]
        public string Strada { get; set; }
        [Required]
        public int Numar { get; set; }
        public string Bloc { get; set; }
        public int Etaj { get; set; }
        public int Apartament { get; set; }
        [Required]
        public string Localitate { get; set; }
        [Required]
        public string Judet { get; set; }
        [Required]
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        [Required]
        public Person Persoana { get; set; }
    }
}
