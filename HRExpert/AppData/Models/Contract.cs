using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppData.Models
{
    public class Contract
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TipContract { get; set; }
        [Required]
        public int NumarContract { get; set; }
        [Required]
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        [Required]
        public Person Person { get; set; }
    }
}
