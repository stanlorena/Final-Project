using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IPersonAddress
    {
        IEnumerable<PersonAddress> GetAll();
        PersonAddress GetById(int id);
        void Add(PersonAddress newPersonAddress);
        IEnumerable<PersonAddress> GetPersonAddressHistory(int id);
    }
}
