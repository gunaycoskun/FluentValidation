using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Net7MVC.Models;
using Net7MVC.Validations;
using System.Diagnostics;

namespace Net7MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Person p)
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person p)
        {
          
            if (ModelState.IsValid)
            {
                return View(p);
               
            }

            return RedirectToAction("Privacy");
        }
        public IActionResult AddPerson()
        {
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