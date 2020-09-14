using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class ContractInsurance
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Asigurare { get; set; }
        [Required]
        public string CompanieAsigurare { get; set; }
        [Required]
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int ContractId { get; set; }
        [Required]
        public Contract Contract { get; set; }
    }
}
