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
        void Remove(Person person);
        void Edit(int personId, int marca, string nume, string prenume, DateTime dataNasterii, string sex, string nationalitate, string email);
        int GetMarca(int id);
        string GetNume(int id);
        int GetIdByMarca(int marca);
        PersonIdentity GetPersonIdentity(int id);
        PersonAddress GetPersonAddress(int id);
    }
}
