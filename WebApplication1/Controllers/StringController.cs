using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Andrew()
        {
            return "Hello Andrew";
        }

        public String Task()
        {
            return "Hello ASP.NET CORE";
        }

    }
}