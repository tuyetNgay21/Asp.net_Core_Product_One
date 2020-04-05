using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tts_Asp.Net_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MapController : Controller
    {
        [Route("MapAdmin")]
        public IActionResult MapAdmin()
        {
            return View();
        }
    }
}