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
    public class SpeciesController : Controller
    {
        public static string Meo = "";
        [Route("Loai-chu-de")]
        public IActionResult LoaiChuDe()
        {
            ViewBag.ImgUrlMeo = Meo;
            return View();
        }

        [Route("Them-Loai-chu-de")]
        public IActionResult AddSpecies(IsSpecies th)
        {
            if (th.Isname == null || th.IsTitle == null || th.AvatarSpecies == null || th.ThemeId==null)
            {
                ViewBag.ImgUrlMeo = Meo;
                return Redirect("Loai-chu-de");
            }
            else
            {
                RIsSpecies r = new RIsSpecies();
                r.Add(th);
                return Redirect("Loai-chu-de");
            }
        }
        [Route("Loai-SuaChuDe")]
        public IActionResult EditSpecies(IsSpecies th2)
        {
            if (ModelState.IsValid == true)
            {
                RIsSpecies t = new RIsSpecies();
                t.Edit(th2);
            }
            return Redirect("Loai-chu-de");
        }
        [Route("Loai-XoaChuDe")]
        public IActionResult DeleteSpecies(string id)
        {
            if (!id.Equals(null))
            {
                RIsSpecies t = new RIsSpecies();
                t.Remove(Int32.Parse(id.Trim()));
            }
            return Redirect("Loai-chu-de");
        }
        [HttpPost]
        [Route("TaiLoaiChuDe")]
        public IActionResult ImageUpload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                var file1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image", fileName);
                file.CopyToAsync(new FileStream(file1, FileMode.Create));
                Meo = "/Image/" + fileName;
                return Redirect("Them-Loai-chu-de");
            }
            else
            {
                return Redirect("Them-Loai-chu-de");
            }
        }
    }
}