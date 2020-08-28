using AppData;
using AppData.Models;
using HRExpert.Models.Contracte;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Controllers
{
    public class ContractsController : Controller
    {
        private IContract _contract;
        private IContractFiscality _fiscality;
        private IContractInsurance _insurance;
        private IContractOrgAssignment _contractOrgAssignment;
        private IContractPeriod _period;
        private IContractSalary _salary;
        private IContractWorkProgram _workProgram;

        public ContractsController(IContract contract, IContractFiscality fiscality, IContractInsurance insurance,
            IContractOrgAssignment contractOrgAssignment, IContractPeriod period, IContractSalary salary, IContractWorkProgram workProgram)
        {
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
    }
}
