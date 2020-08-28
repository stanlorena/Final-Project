using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class ContractOrganizatoricalAssignment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Departament { get; set; }
        [Required]
        public string Functie { get; set; }
        [Required]
        public DateTime DataInceput { get; set; }
        [Required]
        public DateTime DataSfarsit { get; set; }
        [Required]
        public Contract Contract { get; set; }
    }
}
