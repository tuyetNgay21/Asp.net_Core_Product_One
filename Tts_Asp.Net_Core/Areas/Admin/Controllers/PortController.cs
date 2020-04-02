using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tts_Asp.Net_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortController : Controller
    {
        [Route("AddPost")]
        public IActionResult AddPort()
        {
            return View();
        }
        [Route("ViewPost")]
        public IActionResult ViewPort()
        {
            return View();
        }
        [Route("ChangePost")]
        public IActionResult ChangePost()
        {
            return View();
        }
        [Route("ClosePost")]
        public IActionResult ClosePost()
        {
            return View();
        }
    }
}