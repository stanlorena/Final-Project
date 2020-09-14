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
        void Remove(PersonAddress personAddress);
        void Edit(int personAddressId, string strada, int numar, string bloc, int etaj, int apartament, string localitate, string judet, DateTime dataInceput, DateTime dataSfarsit);
        IEnumerable<PersonAddress> GetPersonAddressHistory(int id);
    }
}
