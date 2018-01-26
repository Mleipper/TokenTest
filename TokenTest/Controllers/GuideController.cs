using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TokenTest.Controllers
{
    public class GuideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HowToBuyEther()
        {
            return View();
        }

        public IActionResult EtherWallet()
        {
            return View();
        }
    }
}