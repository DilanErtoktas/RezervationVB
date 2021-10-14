using Microsoft.AspNetCore.Mvc;
using RezervationVB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezervationVB.Controllers
{
    public class Masa : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.TableMasa.ToList();
            return View(deger);
        }
    }
}
