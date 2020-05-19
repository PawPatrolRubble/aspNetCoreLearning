using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Asp.MVC.Learning.Models;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using NetCoreFastenalLib;
using NetCoreFastenalLib.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Asp.MVC.Learning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _env = environment;
        }

        public IActionResult Index()
        {

            //return "hello world, this is the first app.";
            ViewBag.HelloTime = $"current time is {DateTime.Now}";
            //this the main page when the website is accessed
            ViewBag.SystemPath = _env.ContentRootPath;
            ViewBag.UserIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
            ViewBag.UserPort = Request.HttpContext.Connection.RemotePort;

            return View("myPage");
        }


        public ViewResult ViewReport()
        {
            using (var db = new FastenalCodeDatabase())
            {
                ViewBag.Approvals= db.Approvals.Include(x=>x.dohItems).ToList();
            }
            return View();
        }




        [HttpGet]
        public IActionResult MyTest()
        {
            return View();
        }

        [HttpPost]
        public ViewResult MyTest(Test testModel) 
        {
            if (ModelState.IsValid)
            {
                var currentAllinDatabase = new List<Test>();
                using(var db = new testDatabase()){
                    db.tests.Add(testModel);
                    db.SaveChanges();
                    currentAllinDatabase = db.tests.ToList();
                }


                return View("Thanks", currentAllinDatabase);
            }
            else
            {
                return View();
            }
        }



        [HttpPost]
        public string AddBranch(FastenalBranch fastenalBranch)
        {
            string totalAdded = "";
            if (ModelState.IsValid)
            {
                using (var db = new FastenalCodeDatabase())
                {
                    db.FastenalBranches.Add(fastenalBranch);
                    db.SaveChanges();
                    totalAdded = db.FastenalBranches.Count().ToString();
                }
            }
            return totalAdded;
        }

        protected List<string> GetIPAddress()
        {
            var context = HttpContext.Request.Headers;
            var result = new List<string>();
            
            foreach (var item in context)
            {
                result.Add( $"**** {item.Key}: {item.Value} **** \n ");
            }

            return result;
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
