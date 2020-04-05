using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tts_Asp.Net_Core.Areas.User.Controllers
{
    public class InformationUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}