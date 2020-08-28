using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class ContractSalary
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double Salariu { get; set; }
        [Required]
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        [Required]
        public Contract Contract { get; set; }
    }
}
