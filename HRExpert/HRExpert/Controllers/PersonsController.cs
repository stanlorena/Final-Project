using AppData;
using AppData.Models;
using HRExpert.Models.Persoane;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
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

        public void ExportToExcel()
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

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Raport persoane");

            ws.Cells["A1"].Value = "Marca";
            ws.Cells["B1"].Value = "Nume";
            ws.Cells["C1"].Value = "Prenume";
            ws.Cells["D1"].Value = "Data nasterii";
            ws.Cells["E1"].Value = "Sex";
            ws.Cells["F1"].Value = "Nationalitate";
            ws.Cells["G1"].Value = "Email";

            int rowStart = 2;
            foreach(var person in model.Persons)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = person.Marca;
                ws.Cells[string.Format("B{0}", rowStart)].Value = person.Nume;
                ws.Cells[string.Format("C{0}", rowStart)].Value = person.Prenume;
                ws.Cells[string.Format("D{0}", rowStart)].Value = string.Format("{0:dd MMMM yyyy}", person.DataNastere);
                ws.Cells[string.Format("E{0}", rowStart)].Value = person.Sex;
                ws.Cells[string.Format("F{0}", rowStart)].Value = person.Nationalitate;
                ws.Cells[string.Format("G{0}", rowStart)].Value = person.Email;
                rowStart++;
            }

            ws.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.Headers.Add("content-disposition", "attachment: filename=" + "ExcelReport.xlsx");
            Response.Body.Write(pck.GetAsByteArray());

        }

        public IActionResult AddPerson()
        {
            var model = new AddPersonModel
            {
                Nume = "",
                Prenume = "",
                DataNastere = DateTime.Now,
                Sex = "",
                Nationalitate = "",
                Email = ""
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddPersonAction(int marca, string nume, string prenume, DateTime dataNastere, string sex, string nationalitate, string email)
        {
            var person = new Person
            {
                Marca = marca,
                Nume = nume,
                Prenume = prenume,
                DataNastere = dataNastere,
                Sex = sex,
                Nationalitate = nationalitate,
                Email = email
            };
            _persons.Add(person);
            return RedirectToAction("Index");
        }

        public IActionResult EditPerson(int id)
        {
            var person = _persons.GetById(id);
            var model = new AddPersonModel
            {
                Id = person.Id,
                Marca = person.Marca,
                Nume = person.Nume,
                Prenume = person.Prenume,
                DataNastere = person.DataNastere,
                Sex = person.Sex,
                Nationalitate = person.Nationalitate,
                Email = person.Email
            };
            return View("EditPerson", model);
        }

        [HttpPost]
        public IActionResult EditPersonAction(int id, int marca, string nume, string prenume, DateTime dataNastere, string sex, string nationalitate, string email)
        {
            var person = _persons.GetById(id);
            _persons.Edit(id, marca, nume, prenume, dataNastere, sex, nationalitate, email);
            return RedirectToAction("Detail", new { id });
        }

        public IActionResult DeletePerson(int id)
        {
            var person = _persons.GetById(id);
            _persons.Remove(person);
            return RedirectToAction("Index");
        }

        public IActionResult AddPersonIdentity(int id)
        {
            var person = _persons.GetById(id);
            var model = new AddPersonIdentityModel
            {
                IdPersoana = id,
                Serie = "",
                Emitent = "",
                DataEmitere = DateTime.Now,
                DataExpirare = DateTime.Now.AddYears(5),
                Persoana = person
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddPersonIdentityAction(int idPersoana, long cnp, string serie, int numar, string emitent, DateTime dataEmitere, DateTime dataExpirare)
        {
            var person = _persons.GetById(idPersoana);

            var personIdentity = new PersonIdentity
            {
                CNP = cnp,
                Serie = serie,
                Numar = numar,
                Emitent = emitent,
                DataEmitere = dataEmitere,
                DataExpirare = dataExpirare,
                Persoana = person
            };
            _personIdentity.Add(personIdentity);
            return RedirectToAction("Detail", new { id = idPersoana });
        }

        public IActionResult EditPersonIdentity(int id)
        {
            var personIdentity = _personIdentity.GetById(id);
            System.Diagnostics.Debug.WriteLine(id);
            var model = new AddPersonIdentityModel
            {
                PersonIdentityId = personIdentity.Id,
                CNP = personIdentity.CNP,
                Serie = personIdentity.Serie,
                Numar = personIdentity.Numar,
                Emitent = personIdentity.Emitent,
                DataEmitere = personIdentity.DataEmitere,
                DataExpirare = personIdentity.DataEmitere,
                Persoana = personIdentity.Persoana
            };
            System.Diagnostics.Debug.WriteLine(personIdentity.CNP);
            return View("EditPersonIdentity", model);
        }

        [HttpPost]
        public IActionResult EditPersonIdentityAction(int personIdentityId, long cnp, string serie, int numar, string emitent, DateTime dataEmitere, DateTime dataExpirare)
        {
            var personIdentity = _personIdentity.GetById(personIdentityId);
            _personIdentity.Edit(personIdentityId, cnp, serie, numar, emitent, dataEmitere, dataExpirare);
            return RedirectToAction("Detail", new { id = personIdentity.PersoanaId });
        }

        public IActionResult DeleteIdentity(int id)
        {
            var personIdentity = _personIdentity.GetById(id);
            var idPersoana = personIdentity.PersoanaId;
            _personIdentity.Remove(personIdentity);
            return RedirectToAction("Detail", new { id = idPersoana });
        }


        public IActionResult AddPersonAddress(int id)
        {
            var person = _persons.GetById(id);
            var model = new AddPersonAddressModel
            {
                IdPersoana = id,
                Strada = "",
                Bloc = "",
                Localitate = "",
                Judet = "",
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1),
                Persoana = person
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddPersonAddressAction(int idPersoana, string strada, int numar, string bloc, int etaj, int apartament, string localitate, string judet, DateTime dataInceput, DateTime dataSfarsit)
        {
            var person = _persons.GetById(idPersoana);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var personAddress = new PersonAddress
            {
                Strada = strada,
                Numar = numar,
                Bloc = bloc,
                Etaj = etaj,
                Apartament = apartament,
                Localitate = localitate,
                Judet = judet,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Persoana = person
            };
            _personAddress.Add(personAddress);
            return RedirectToAction("Detail", new { id = idPersoana });
        }

        public IActionResult EditPersonAddress(int id)
        {
            var personAddress = _personAddress.GetById(id);
            var model = new AddPersonAddressModel
            {
                PersonAddressId = personAddress.Id,
                Strada = personAddress.Strada,
                Numar = personAddress.Numar,
                Bloc = personAddress.Bloc,
                Etaj = personAddress.Etaj,
                Apartament = personAddress.Apartament,
                Localitate = personAddress.Localitate,
                Judet = personAddress.Judet,
                DataInceput = personAddress.DataInceput,
                DataSfarsit = personAddress.DataSfarsit,
                Persoana = personAddress.Persoana
            };
            return View("EditPersonAddress", model);
        }

        [HttpPost]
        public IActionResult EditPersonAddressAction(int personAddressId, string strada, int numar, string bloc, int etaj, int apartament, string localitate, string judet, DateTime dataInceput, DateTime dataSfarsit)
        {
            var personAddress = _personAddress.GetById(personAddressId);
            _personAddress.Edit(personAddressId, strada, numar, bloc, etaj, apartament, localitate, judet, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id = personAddress.PersoanaId });
        }

        public IActionResult DeleteAddress(int id)
        {
            var personAddress = _personAddress.GetById(id);
            var idPersoana = personAddress.PersoanaId;
            _personAddress.Remove(personAddress);
            return RedirectToAction("Detail", new { id = idPersoana });
        }
    }
}
