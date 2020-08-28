using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Models.Contracte
{
    public class ContractIndexModel
    {
        public IEnumerable<ContractIndexListingModel> Contracts { get; set; }
    }
}
