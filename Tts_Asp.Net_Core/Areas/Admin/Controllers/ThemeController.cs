using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.Repository;

namespace Tts_Asp.Net_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThemeController : Controller
    {
        public static string Meo = "";
        [Route("chu-de")]
        public IActionResult ChuDe()
        {
            return View();
        }

        [Route("Them-chu-de")]
        public IActionResult AddTheme(IsTheme th)
        {
            if (th.Isname == null || th.IsTitle == null || th.AvatarTheme == null)
            {
                ViewBag.ImgUrl = Meo;
                return View();
            }
            else
            {
                RIsTheme r = new RIsTheme();
                r.Add(th);
                return Redirect("chu-de");
            }
        }
        [Route("SuaChuDe")]
        public IActionResult EdiTheme(IsTheme th)
        {
            if(ModelState.IsValid==false)
            {
                RIsTheme t = new RIsTheme();
                t.Edit(th);
            }     
            return Redirect("chu-de");
        }
        [HttpPost]
        [Route("TaiTheme")]
        public IActionResult ImageUpload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                //var imgpa = @"\Image\";
                //var uploadPath = he.WebRootPath + imgpa;
                //if(!Directory.Exists(uploadPath))
                //{
                //    Directory.CreateDirectory(uploadPath);
                //}
                //var uiFileName = Guid.NewGuid().ToString();
                //var fileName = Path.GetFileName(uiFileName + "." + file.FileName.Split(".")[1].ToLower());
                //var full = uploadPath + fileName;
                //imgpa = imgpa + @"\";
                //var filePath = @".." + Path.Combine(imgpa, fileName);
                //using (var fileStream= new FileStream(full, FileMode.Create))
                //{
                //    await file.CopyToAsync(fileStream);
                //}

                var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                var file1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image", fileName);
                file.CopyToAsync(new FileStream(file1, FileMode.Create));
                Meo = "/Image/" + fileName;
                return Redirect("chu-de");
            }
            else
            {
                return View("chu-de");
            }
        }
    }
}