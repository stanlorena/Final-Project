using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Persoane
{
    public class PersonIndexModel
    {
        public IEnumerable<PersonIndexListingModel> Persons { get; set; }
    }
}
