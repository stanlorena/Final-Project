using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class PersonIdentity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public long CNP { get; set; }
        [Required]
        public string Serie { get; set; }
        [Required]
        public int Numar { get; set; }
        [Required]
        public string Emitent { get; set; }
        [Required]
        public DateTime DataEmitere { get; set; }
        [Required]
        public DateTime DataExpirare { get; set; }
        [Required]
        public Person Persoana { get; set; }
    }
}
