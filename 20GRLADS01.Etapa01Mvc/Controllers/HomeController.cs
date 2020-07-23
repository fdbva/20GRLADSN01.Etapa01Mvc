using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _20GRLADS01.Etapa01Mvc.Models;

namespace _20GRLADS01.Etapa01Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new HomeModel();

            model.TituloPagina = "Novo Título";
            model.Cabecalho = "Bem vindos!";

            return View(model);
        }

        [HttpGet]
        public string IndexGet()
        {
            return "IndexGet Sucesso";
        }

        [HttpPost]
        public string IndexPost()
        {
            return "IndexPost Sucesso";
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
