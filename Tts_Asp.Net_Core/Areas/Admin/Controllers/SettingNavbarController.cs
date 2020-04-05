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
    public class SettingNavbarController : Controller
    {
        public static IsNavbar navbarCreate = new IsNavbar();
        [Route("CreateNav")]
        public IActionResult CreateNav(IsNavbar ik)
        {
            if(ik.NavbarId==0)
            {
                ik = navbarCreate;
            }            
            return View(ik);
        }

        [Route("ViewNav")]
        public IActionResult ViewNav()
        {
            //láy dữ liệu rồi trả ra 
            var mo = new RIsNavbar();           
            return View(mo.GetIsTheme());
        }
        [Route("CreateNavPro")]
        public IActionResult CreateNavPro(IsNavbar ik)
        {
            var mo = new RIsNavbar();
            mo.Add(ik);
            return Redirect("ViewNav");
        }

        [Route("TaiNav")]
        public IActionResult ImageUpload(IFormFile file,int id)
        {
            if (file != null && file.Length > 0)
            {

                var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                var file1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NavImg", fileName);
                file.CopyToAsync(new FileStream(file1, FileMode.Create));
                switch(id)
                {
                    case 1:
                        navbarCreate.Image1 = "/NavImg/" + fileName;
                    break;
                    case 2:
                        navbarCreate.Image2 = "/NavImg/" + fileName;
                        break;
                    case 3:
                        navbarCreate.Image3 = "/NavImg/" + fileName;
                        break;
                    case 4:
                        navbarCreate.Image4 = "/NavImg/" + fileName;
                        break;
                    case 5:
                        navbarCreate.Image5 = "/NavImg/" + fileName;
                        break;
                    case 6:
                        navbarCreate.Image6 = "/NavImg/" + fileName;
                        break;
                    case 7:
                        navbarCreate.Image7 = "/NavImg/" + fileName;
                        break;
                    case 8:
                        navbarCreate.Image8 = "/NavImg/" + fileName;
                        break;
                    case 9:
                        navbarCreate.Image9 = "/NavImg/" + fileName;
                        break;
                    case 10:
                        navbarCreate.Image10 = "/NavImg/" + fileName;
                        break;
                    default:
                        navbarCreate.Image1 = "/NavImg/" + fileName;
                        break;
                }
                return Redirect("CreateNav");
            }
            else
            {
                return View("CreateNav");
            }
        }
    }
}