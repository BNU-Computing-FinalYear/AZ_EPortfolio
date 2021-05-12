using AZ_EPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();

        }

        public IActionResult TermsConditions()
        {
            return View();
        }

        public IActionResult SupportedBrowsersDevices()
        {
            return View();
        }

        public IActionResult AcceptedFileFormats()
        {
            return View();
        }

        public IActionResult FormattingImages()
        {
            return View();
        }

        public IActionResult VideoRenditions()
        {
            return View();
        }

        public IActionResult WriteBetterBio()
        {
            return View();
        }
        public IActionResult EssentialSteps()
        {
            return View();
        }
        public IActionResult PromoteYourself()
        {
            return View();
        }
        public IActionResult AttractEmployers()
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
