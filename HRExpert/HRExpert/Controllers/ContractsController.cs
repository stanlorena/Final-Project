using AppData;
using AppData.Models;
using HRExpert.Models.Contracte;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Controllers
{
    public class ContractsController : Controller
    {
        private ICrud _persons;
        private IContract _contract;
        private IContractFiscality _fiscality;
        private IContractInsurance _insurance;
        private IContractOrgAssignment _contractOrgAssignment;
        private IContractPeriod _period;
        private IContractSalary _salary;
        private IContractWorkProgram _workProgram;

        public ContractsController(ICrud persons, IContract contract, IContractFiscality fiscality, IContractInsurance insurance,
            IContractOrgAssignment contractOrgAssignment, IContractPeriod period, IContractSalary salary, IContractWorkProgram workProgram)
        {
            _persons = persons;
            _contract = contract;
            _fiscality = fiscality;
            _insurance = insurance;
            _contractOrgAssignment = contractOrgAssignment;
            _period = period;
            _salary = salary;
            _workProgram = workProgram;
        }

        public IActionResult Index()
        {
            var allContracts = _contract.GetAll();
            var contractModel = allContracts.Select(c => new ContractIndexListingModel
            {
                Id = c.Id,
                TipContract = c.TipContract,
                NumarContract = c.NumarContract,
                DataInceput = c.DataInceput,
                DataSfarsit = c.DataSfarsit,
                PersonId = c.Person.Id,
                PersonName = c.Person.Nume,
                PersonSurname = c.Person.Prenume
            });

            var model = new ContractIndexModel()
            {
                Contracts = contractModel
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var contract = _contract.GetById(id);
            var model = new ContractDetailModel
            {
                Id = id,
                TipContract = contract.TipContract,
                NumarContract = contract.NumarContract,
                PersonName = contract.Person.Nume,
                PersonSurname = contract.Person.Prenume,
                DataInceput = contract.DataInceput,
                DataSfarsit = contract.DataSfarsit,
                ContractFiscality = _fiscality.GetContractFiscalityHistory(id),
                ContractInsurance = _insurance.GetContractInsuranceHistory(id),
                ContractPeriod = _period.GetContractPeriodHistory(id),
                ContractOrganizatoricalAssignment = _contractOrgAssignment.GetContractOrganizatoricalAssignmentHistory(id),
                ContractSalary = _salary.GetContractSalaryHistory(id),
                ContractWorkProgram = _workProgram.GetContractWorkProgramHistory(id)
            };
            return View(model);
        }

        public void ExportToExcel()
        {
            var allContracts = _contract.GetAll();
            var contractModel = allContracts.Select(c => new ContractIndexListingModel
            {
                Id = c.Id,
                TipContract = c.TipContract,
                NumarContract = c.NumarContract,
                DataInceput = c.DataInceput,
                DataSfarsit = c.DataSfarsit,
                PersonId = c.Person.Id,
                PersonName = c.Person.Nume,
                PersonSurname = c.Person.Prenume
            });

            var model = new ContractIndexModel()
            {
                Contracts = contractModel
            };

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Raport contracte");

            ws.Cells["A1"].Value = "Tip contract";
            ws.Cells["B1"].Value = "Numar contract";
            ws.Cells["C1"].Value = "Persoana";
            ws.Cells["D1"].Value = "Data de inceput";
            ws.Cells["E1"].Value = "Data de sfarsit";

            int rowStart = 2;
            foreach (var contract in model.Contracts)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = contract.TipContract;
                ws.Cells[string.Format("B{0}", rowStart)].Value = contract.NumarContract;
                ws.Cells[string.Format("C{0}", rowStart)].Value = contract.PersonName + " " + contract.PersonSurname;
                ws.Cells[string.Format("D{0}", rowStart)].Value = string.Format("{0:dd MMMM yyyy}", contract.DataInceput);
                ws.Cells[string.Format("E{0}", rowStart)].Value = string.Format("{0:dd MMMM yyyy}", contract.DataSfarsit);
                rowStart++;
            }

            ws.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.Headers.Add("content-disposition", "attachment: filename=" + "ExcelReport.xlsx");
            Response.Body.Write(pck.GetAsByteArray());

        }

        public IActionResult AddContract()
        {
            var model = new AddContractModel
            {
                TipContract = "",
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddContractAction(int marca, string tipContract, int numarContract, DateTime dataInceput, DateTime dataSfarsit)
        {
            var personId = _persons.GetIdByMarca(marca);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var person = _persons.GetById(personId);

            var contract = new Contract
            {
                TipContract = tipContract,
                NumarContract = numarContract,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Person = person
            };
            _contract.Add(contract);
            return RedirectToAction("Index");
        }

        public IActionResult EditContract(int id)
        {
            var contract = _contract.GetById(id);
            var person = contract.Person;
            var model = new AddContractModel
            {
                Id = contract.Id,
                Marca = person.Marca,
                TipContract = contract.TipContract,
                NumarContract = contract.NumarContract,
                DataInceput = contract.DataInceput,
                DataSfarsit = contract.DataSfarsit,
                Person = person
            };
            return View("EditContract", model);
        }

        [HttpPost]
        public IActionResult EditContractAction(int id, string tipContract, int numarContract, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contract = _contract.GetById(id);
            _contract.Edit(id, tipContract, numarContract, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id });
        }

        public IActionResult DeleteContract(int id)
        {
            var contract = _contract.GetById(id);
            _contract.Remove(contract);
            return RedirectToAction("Index");
        }

        public IActionResult AddContractFiscality(int id)
        {
            var contract = _contract.GetById(id);
            var model = new AddContractFiscalityModel
            {
                ContractId = id,
                Fiscalitate = "",
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1),
                Contract = contract
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddContractFiscalityAction(int contractId, string fiscalitate, bool seAcordaDeduceri, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contract = _contract.GetById(contractId);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var contractFiscality = new ContractFiscality
            {
                Fiscalitate = fiscalitate,
                SeAcordaDeduceri = seAcordaDeduceri,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Contract = contract
            };
            _fiscality.Add(contractFiscality);
            return RedirectToAction("Detail", new { id = contractId });
        }

        public IActionResult EditContractFiscality(int id)
        {
            var contractFiscality = _fiscality.GetById(id);
            System.Diagnostics.Debug.WriteLine(id);
            var model = new AddContractFiscalityModel
            {
                ContractFiscalityId = contractFiscality.Id,
                Fiscalitate = contractFiscality.Fiscalitate,
                SeAcordaDeduceri = contractFiscality.SeAcordaDeduceri,
                DataInceput = contractFiscality.DataInceput,
                DataSfarsit = contractFiscality.DataSfarsit,
                Contract = contractFiscality.Contract
            };
            return View("EditContractFiscality", model);
        }

        [HttpPost]
        public IActionResult EditContractFiscalityAction(int contractFiscalityId, string fiscalitate, bool seAcordaDeduceri, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractFiscality = _fiscality.GetById(contractFiscalityId);
            _fiscality.Edit(contractFiscalityId, fiscalitate, seAcordaDeduceri, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id = contractFiscality.ContractId });
        }

        public IActionResult DeleteFiscality(int id)
        {
            var contractFiscality = _fiscality.GetById(id);
            var idContract = contractFiscality.ContractId;
            _fiscality.Remove(contractFiscality);
            return RedirectToAction("Detail", new { id = idContract });
        }

        public IActionResult AddContractInsurance(int id)
        {
            var contract = _contract.GetById(id);
            var model = new AddContractInsuranceModel
            {
                ContractId = id,
                Asigurare = "",
                CompanieAsigurare = "",
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1),
                Contract = contract
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddContractInsuranceAction(int contractId, string asigurare, string companieAsigurare, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contract = _contract.GetById(contractId);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var contractInsurance = new ContractInsurance
            {
                Asigurare = asigurare,
                CompanieAsigurare = companieAsigurare,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Contract = contract
            };
            _insurance.Add(contractInsurance);
            return RedirectToAction("Detail", new { id = contractId });
        }

        public IActionResult EditContractInsurance(int id)
        {
            var contractInsurance = _insurance.GetById(id);
            var model = new AddContractInsuranceModel
            {
                ContractInsuranceId = contractInsurance.Id,
                Asigurare = contractInsurance.Asigurare,
                CompanieAsigurare = contractInsurance.CompanieAsigurare,
                DataInceput = contractInsurance.DataInceput,
                DataSfarsit = contractInsurance.DataSfarsit,
                Contract = contractInsurance.Contract
            };
            return View("EditContractInsurance", model);
        }

        [HttpPost]
        public IActionResult EditContractInsuranceAction(int contractInsuranceId, string asigurare, string companieAsigurare, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractInsurance = _insurance.GetById(contractInsuranceId);
            _insurance.Edit(contractInsuranceId, asigurare, companieAsigurare, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id = contractInsurance.ContractId });
        }

        public IActionResult DeleteInsurance(int id)
        {
            var contractInsurance = _insurance.GetById(id);
            var idContract = contractInsurance.ContractId;
            _insurance.Remove(contractInsurance);
            return RedirectToAction("Detail", new { id = idContract });
        }
        public IActionResult AddContractOrgAssignment(int id)
        {
            var contract = _contract.GetById(id);
            var model = new AddContractOrgAssignmentModel
            {
                ContractId = id,
                Departament = "",
                Functie = "",
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1),
                Contract = contract
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddContractOrgAssignmentAction(int contractId, string departament, string functie, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contract = _contract.GetById(contractId);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var contractOrgAssignment = new ContractOrganizatoricalAssignment
            {
                Departament = departament,
                Functie = functie,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Contract = contract
            };
            _contractOrgAssignment.Add(contractOrgAssignment);
            return RedirectToAction("Detail", new { id = contractId });
        }

        public IActionResult EditContractOrgAssignment(int id)
        {
            var contractOrgAssignment = _contractOrgAssignment.GetById(id);
            var model = new AddContractOrgAssignmentModel
            {
                ContractOrganizatoricalAssignmentId = contractOrgAssignment.Id,
                Departament = contractOrgAssignment.Departament,
                Functie = contractOrgAssignment.Functie,
                DataInceput = contractOrgAssignment.DataInceput,
                DataSfarsit = contractOrgAssignment.DataSfarsit,
                Contract = contractOrgAssignment.Contract
            };
            return View("EditContractOrgAssignment", model);
        }

        [HttpPost]
        public IActionResult EditContractOrgAssignmentAction(int contractOrganizatoricalAssignmentId, string departament, string functie, DateTime dataInceput, DateTime dataSfarsit)
        {
            var coa = _contractOrgAssignment.GetById(contractOrganizatoricalAssignmentId);
            _contractOrgAssignment.Edit(contractOrganizatoricalAssignmentId, departament, functie, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id = coa.ContractId });
        }

        public IActionResult DeleteCoa(int id)
        {
            var contractOrgAssignment = _contractOrgAssignment.GetById(id);
            var idContract = contractOrgAssignment.ContractId;
            _contractOrgAssignment.Remove(contractOrgAssignment);
            return RedirectToAction("Detail", new { id = idContract });
        }

        public IActionResult AddContractPeriod(int id)
        {
            var contract = _contract.GetById(id);
            var model = new AddContractPeriodModel
            {
                ContractId = id,
                Perioada = "",
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1),
                Contract = contract
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddContractPeriodAction(int contractId, string perioada, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contract = _contract.GetById(contractId);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var contractPeriod = new ContractPeriod
            {
                Perioada = perioada,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Contract = contract
            };
            _period.Add(contractPeriod);
            return RedirectToAction("Detail", new { id = contractId });
        }

        public IActionResult EditContractPeriod(int id)
        {
            var contractPeriod = _period.GetById(id);
            var model = new AddContractPeriodModel
            {
                ContractPeriodId = contractPeriod.Id,
                Perioada = contractPeriod.Perioada,
                DataInceput = contractPeriod.DataInceput,
                DataSfarsit = contractPeriod.DataSfarsit,
                Contract = contractPeriod.Contract
            };
            return View("EditContractPeriod", model);
        }

        [HttpPost]
        public IActionResult EditContractPeriodAction(int contractPeriodId, string perioada, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractPeriod = _period.GetById(contractPeriodId);
            _period.Edit(contractPeriodId, perioada, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id = contractPeriod.ContractId });
        }

        public IActionResult DeletePeriod(int id)
        {
            var contractPeriod = _period.GetById(id);
            var idContract = contractPeriod.ContractId;
            _period.Remove(contractPeriod);
            return RedirectToAction("Detail", new { id = idContract });
        }

        public IActionResult AddContractSalary(int id)
        {
            var contract = _contract.GetById(id);
            var model = new AddContractSalaryModel
            {
                ContractId = id,
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1),
                Contract = contract
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddContractSalaryAction(int contractId, double salariu, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contract = _contract.GetById(contractId);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var contractSalary = new ContractSalary
            {
                Salariu = salariu,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Contract = contract
            };
            _salary.Add(contractSalary);
            return RedirectToAction("Detail", new { id = contractId });
        }

        public IActionResult EditContractSalary(int id)
        {
            var contractSalary = _salary.GetById(id);
            var model = new AddContractSalaryModel
            {
                ContractSalaryId = contractSalary.Id,
                Salariu = contractSalary.Salariu,
                DataInceput = contractSalary.DataInceput,
                DataSfarsit = contractSalary.DataSfarsit,
                Contract = contractSalary.Contract
            };
            return View("EditContractSalary", model);
        }

        [HttpPost]
        public IActionResult EditContractSalaryAction(int contractSalaryId, double salariu, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractSalary = _salary.GetById(contractSalaryId);
            _salary.Edit(contractSalaryId, salariu, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id = contractSalary.ContractId });
        }

        public IActionResult DeleteSalary(int id)
        {
            var contractSalary = _salary.GetById(id);
            var idContract = contractSalary.ContractId;
            _salary.Remove(contractSalary);
            return RedirectToAction("Detail", new { id = idContract });
        }

        public IActionResult AddContractWorkProgram(int id)
        {
            var contract = _contract.GetById(id);
            var model = new AddContractWorkProgramModel
            {
                ContractId = id,
                ProgramLucru = "",
                Norma = "",
                DataInceput = DateTime.Now,
                DataSfarsit = DateTime.Now.AddYears(1),
                Contract = contract
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddContractWorkProgramAction(int contractId, string programLucru, string norma, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contract = _contract.GetById(contractId);
            if (dataSfarsit == DateTime.MinValue)
            {
                dataSfarsit = DateTime.MaxValue;
            }
            var contractWorkProgram = new ContractWorkProgram
            {
                ProgramLucru = programLucru,
                Norma = norma,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit,
                Contract = contract
            };
            _workProgram.Add(contractWorkProgram);
            return RedirectToAction("Detail", new { id = contractId });
        }

        public IActionResult EditContractWorkProgram(int id)
        {
            var contractWorkProgram = _workProgram.GetById(id);
            var model = new AddContractWorkProgramModel
            {
                ContractWorkProgramId = contractWorkProgram.Id,
                ProgramLucru = contractWorkProgram.ProgramLucru,
                Norma = contractWorkProgram.Norma,
                DataInceput = contractWorkProgram.DataInceput,
                DataSfarsit = contractWorkProgram.DataSfarsit,
                Contract = contractWorkProgram.Contract
            };
            return View("EditContractWorkProgram", model);
        }

        [HttpPost]
        public IActionResult EditContractWorkProgramAction(int contractWorkProgramId, string programLucru, string norma, DateTime dataInceput, DateTime dataSfarsit)
        {
            var contractWorkProgram = _workProgram.GetById(contractWorkProgramId);
            _workProgram.Edit(contractWorkProgramId, programLucru, norma, dataInceput, dataSfarsit);
            return RedirectToAction("Detail", new { id = contractWorkProgram.ContractId });
        }

        public IActionResult DeleteWorkProgram(int id)
        {
            var contractWorkProgram = _workProgram.GetById(id);
            var idContract = contractWorkProgram.ContractId;
            _workProgram.Remove(contractWorkProgram);
            return RedirectToAction("Detail", new { id = idContract });
        }
    }
}
