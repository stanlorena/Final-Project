using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class ContractFiscality
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Fiscalitate { get; set; }
        [Required]
        public bool SeAcordaDeduceri { get; set; }
        [Required]
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public int ContractId { get; set; }
        [Required]
        public Contract Contract { get; set; }
    }
}
