using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        private Lucky7 lucky7;
        public SpinnerController(Lucky7 l7) 
        {
            lucky7 = l7;
        }

        public IActionResult Index(int luck)
        {
            return new ContentResult { Content = lucky7.Output(luck), ContentType = "text/html" };
        }
    }
}