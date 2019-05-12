using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Http;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        public static List<string> surveys = new List<string>(){};
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ListOfSurveys = surveys;
            return View();
            
        }
        
        [Route("create")]
        [HttpPost]
        public IActionResult Create(Survey c)
        {
            c.Display();
            if(ModelState.IsValid)
            {
            
                return View("Result", c);
            }
            else
            {
                Console.WriteLine("Does this work?");
                return View("Index");
            }
        }

        [Route("result")]
        [HttpGet]
        public IActionResult Result()
        {
            
            return View("Result");
        }
        
    

    }
}
