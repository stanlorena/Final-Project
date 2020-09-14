using AppData;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppServices
{
    public class PersonService : ICrud
    {
        private HrContext _context;

        public PersonService(HrContext context)
        {
            _context = context;
        }

        public void Add(Person newPerson)
        {
            _context.Add(newPerson);
            _context.SaveChanges();
        }

        public void Edit(int id, int marca, string nume, string prenume, DateTime dataNasterii, string sex, string nationalitate, string email)
        {
            var person = _context.Persons.FirstOrDefault(p => p.Id == id);
            //_context.Update(person);

            person.Marca = marca;
            person.Nume = nume;
            person.Prenume = prenume;
            person.DataNastere = dataNasterii;
            person.Sex = sex;
            person.Nationalitate = nationalitate;
            person.Email = email;

            //_context.Update(person);
            _context.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.Persons;
                /*.Include(person => person.Marca)
                .Include(person => person.Nume)
                .Include(person => person.Prenume)
                .Include(person => person.DataNastere)
                .Include(person => person.Sex)
                .Include(person => person.Nationalitate);*/
        }

        public Person GetById(int id)
        {
            return _context.Persons
                .FirstOrDefault(person => person.Id == id);
        }

        public int GetIdByMarca(int marca)
        {
            return _context.Persons.
                FirstOrDefault(person => person.Marca == marca)
                .Id;
        }

        public int GetMarca(int id)
        {
            return _context.Persons.
                FirstOrDefault(person => person.Id == id)
                .Marca;
        }

        public string GetNume(int id)
        {
            return _context.Persons.
                FirstOrDefault(person => person.Id == id)
                .Nume;
        }

        public PersonAddress GetPersonAddress(int id)
        {
            //return _context.Persons.FirstOrDefault(person => person.Id == id).Address;
            throw new NotImplementedException();
        }

        public PersonIdentity GetPersonIdentity(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Person person)
        {
            _context.Remove(person);
            _context.SaveChanges();
        }
    }
}
