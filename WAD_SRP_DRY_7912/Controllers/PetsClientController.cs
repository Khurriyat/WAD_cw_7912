using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_PetCare_7912.Controllers
{
    public class PetsClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
