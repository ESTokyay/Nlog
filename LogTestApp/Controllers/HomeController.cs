using MyNlog;
using LogTestApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace LogTestApp.Controllers
{
    public class HomeController : Controller
    {
            
             

        public IActionResult Index()
        {
          
            MyLogger.LogInfo(this.GetType(),"Anasayfa açıldı.");            
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
