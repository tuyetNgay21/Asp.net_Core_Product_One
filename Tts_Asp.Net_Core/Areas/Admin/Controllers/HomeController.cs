using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Tts_Asp.Net_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public  class HomeController : Controller
    {
        
        private readonly IHostingEnvironment he;

        
        public HomeController(IHostingEnvironment e)
        {
            he=e;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPort()
        {
            return View();
        }
        public IActionResult MapPost()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpLoadCKEditor(IFormFile upload)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image",fileName);
            upload.CopyToAsync(new FileStream(file, FileMode.Create));
            // return new JsonResult(new { path = "/wwwroot/Image/" + fileName });
            return new JsonResult(new
            {
                uploaded = 1,
                url = "~/Image/"+fileName
            });
        }
    }
}