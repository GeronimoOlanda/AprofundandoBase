using GethaWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace GethaWebSite.Controllers
{
    public class PaginaInicialController : Controller
    {
        private readonly ILogger<PaginaInicialController> _logger;

        public PaginaInicialController(ILogger<PaginaInicialController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var urlApiGetha = ConfigurationManager.AppSettings["urlApiGetha"];

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}