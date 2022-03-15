using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backstage.Controllers
{
    public class BackReportController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
