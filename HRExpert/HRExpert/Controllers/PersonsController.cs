using AppData;
using HRExpert.Models.Persoane;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Controllers
{
    public class PersonsController : Controller
    {
        private ICrud _persons;
        private IPersonIdentity _personIdentity;
        private IPersonAddress _personAddress;
        public PersonsController(ICrud persons, IPersonIdentity personIdentity, IPersonAddress personAddress)
        {
            _persons = persons;
            _personIdentity = personIdentity;
            _personAddress = personAddress;
        }

        public IActionResult Index()
        {
            var personModels = _persons.GetAll();
            var listingResult = personModels.Select(result => new PersonIndexListingModel
            {
                Id = result.Id,
                Marca = result.Marca,
                Nume = result.Nume,
                Prenume = result.Prenume,
                DataNastere = result.DataNastere,
                Sex = result.Sex,
                Nationalitate = result.Nationalitate,
                Email = result.Email
            });

            var model = new PersonIndexModel()
            {
                Persons = listingResult
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var person = _persons.GetById(id);
            var model = new PersonDetailModel
            {
                PersonId = id,
                Marca = person.Marca,
                Nume = person.Nume,
                Prenume = person.Prenume,
                DataNastere = person.DataNastere,
                Sex = person.Sex,
                Nationalitate = person.Nationalitate,
                Email = person.Email,
                PersonIdentity = _personIdentity.GetPersonIdentityHistory(id),
                PersonAddress = _personAddress.GetPersonAddressHistory(id)
            };
            return View(model);
        }
    }
}
