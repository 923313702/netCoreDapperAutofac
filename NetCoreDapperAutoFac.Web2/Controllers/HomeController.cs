using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreDapperAutoFac.Services.IServices;
using NetCoreDapperAutoFac.Web2.Models;

namespace NetCoreDapperAutoFac.Web2.Controllers
{
    public class HomeController : Controller
    {


        private IPersonService ips;

        public HomeController(IPersonService _ips)
        {
            ips = _ips;
        }
        public IActionResult Index()
        {
            var ss =ips.Add(" insert into person (name) values (@Name)",new Entitys.Person() { Name="测测"},false);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
