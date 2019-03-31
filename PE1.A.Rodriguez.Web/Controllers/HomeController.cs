using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE1.A.Rodriguez.Lib;
using PE1.A.Rodriguez.Web.Models;

namespace PE1.A.Rodriguez.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult IndexGrijs()
        //{
        //    var cssColours = new ColourService();
        //    IEnumerable<string> model = ColourService.GenerateGreyScales(10);
        //    return View(model);
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
