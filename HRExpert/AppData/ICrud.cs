using AppData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface ICrud
    {
        IEnumerable<Person> GetAll();
        Person GetById(int id);
        void Add(Person newPerson);
        int GetMarca(int id);
        string GetNume(int id);
        PersonIdentity GetPersonIdentity(int id);
        PersonAddress GetPersonAddress(int id);
    }
}
