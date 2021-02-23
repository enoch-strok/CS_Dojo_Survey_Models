using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CS_Dojo_Survey_Models.Models;
using Hogwarts.Models;

namespace CS_Dojo_Survey_Models.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
//_____________________________________/Index\___________________________________________________//
        [HttpGet("/")]
        public IActionResult WizardRegForm()
        {
            return View();
        }
//-------------------------------------------------------------------------------------------------// 
//_____________________________________/Register\___________________________________________________//
        [HttpPost("register")]
        public IActionResult RegisterWizard(string name, string dojo, string fav_language, string comment)
        {
            // process the form...

            HogwartsStudent someUser1 = new HogwartsStudent()
            {
                Name = name,
                Dojo = dojo,
                FavoriteLanguage = fav_language,
                Comment = comment
            };

            Console.WriteLine(name);
            Console.WriteLine(dojo);
            Console.WriteLine(fav_language);
            Console.WriteLine(comment);

            // List<User> viewModel = new List<User>()
            // {
            //     someUser1
            // };

            return View(someUser1);
        }
//-------------------------------------------------------------------------------------------------// 
    }
}
