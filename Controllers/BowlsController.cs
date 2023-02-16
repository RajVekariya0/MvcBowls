using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBowls.Controllers
{
    public class BowlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
