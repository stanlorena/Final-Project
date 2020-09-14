using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HRExpert.Models;
using AppData;
using HRExpert.Models.Statistici;

namespace HRExpert.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        private IStatistics _statistici;

        public HomeController(IStatistics statistici)
        {
            _statistici = statistici;
        }

        public IActionResult Index()
        {
            int nrFemei = _statistici.GetNrFemei();
            int nrBarbati = _statistici.GetNrBarbati();
            int nrContracteNedet = _statistici.GetContractePerNedeterminata();
            int nrContracteDet = _statistici.GetContractePerDeterminata();
            int nrPersoane = _statistici.GetNrPersoane();
            int nrContracte = _statistici.GetNrContracte();
            double salariuMediu = Math.Round(_statistici.GetSalariuMediu(), 2);

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
