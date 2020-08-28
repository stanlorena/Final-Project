using AppData;
using HRExpert.Models.Statistici;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRExpert.Controllers
{
    public class StatisticsController : Controller
    {
        private IStatistics _statistici;

        public StatisticsController(IStatistics statistici)
        {
            _statistici = statistici;
        }

        public ActionResult Index()
        {
            int nrFemei = _statistici.GetNrFemei();
            int nrBarbati = _statistici.GetNrBarbati();
            int nrContracteNedet = _statistici.GetContractePerNedeterminata();
            int nrContracteDet = _statistici.GetContractePerDeterminata();
            int nrPersoane = _statistici.GetNrPersoane();
            int nrContracte = _statistici.GetNrContracte();
            double salariuMediu = _statistici.GetSalariuMediu();

            var model = new StatisticsModel()
            {
                NrFemei = nrFemei,
                NrBarbati = nrBarbati,
                NrPersoane = nrPersoane,
                NrContracte = nrContracte,
                NrContractePerioadaNedeterminata = nrContracteNedet,
                NrContractePerioadaDeterminata = nrContracteDet,
                SalariuMediu = salariuMediu
            };

            return View(model);
        }

    }
}
