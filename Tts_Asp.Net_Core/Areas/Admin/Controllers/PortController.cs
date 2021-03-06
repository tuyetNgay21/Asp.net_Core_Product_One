﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tts_Asp.Net_Core.Models.Check;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.Repository;

namespace Tts_Asp.Net_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortController : Controller
    {
        public static string postImg = "";
        [Route("AddPost")]
        public IActionResult AddPort(IsPost th)
        {
            if (th.SpeciesId != null || th.Title != null || th.Content != null || th.AvataIndex != null)
            {
                RIsPost r = new RIsPost();
                r.Add(th);
            }
            else
            {
                ViewBag.postImg = postImg;
            }

            return View();
        }
        
        [Route("ViewPost")]
        public IActionResult ViewPort(int idSearch, int numberSearch, string contentSearch, int trangso)
        {
            var listTheme = ViewPosrt.DepTrai(idSearch, numberSearch, contentSearch);
            ViewBag.tongTrang = (listTheme.Count() / 10)+1;
            ViewBag.tranghientai = trangso;
            if(listTheme.Count< (trangso+1)*10)
            {
                listTheme = listTheme.GetRange(trangso * 10,listTheme.Count()-(trangso * 10));
            }
            else
            {
                listTheme = listTheme.GetRange(trangso * 10, 10);
            }
           
            return View(listTheme);
        }
        public static int MabaiViet;
        [Route("ChangePost")]
        public IActionResult ChangePost(int maBaiViet)
        {
            if(MabaiViet==0)
            {
                MabaiViet = maBaiViet;
            }
            else
            {
                maBaiViet = MabaiViet;
            }                        
            using (TTS_ASP_CoreContext db = new TTS_ASP_CoreContext())
            {
                var model = db.IsPost.Where(m => m.PostId == maBaiViet).FirstOrDefault();
                if (postImg == "")
                {
                    ViewBag.postImg = model.AvataIndex;
                 }
                else
                {
                    ViewBag.postImg = postImg;
                }
                return View(model);
            }                
        }

        [Route("ChangeDatePost")]
        public IActionResult ChangeDatePost(IsPost Rip)
        {
            RIsPost rip = new RIsPost();
            rip.Edit(Rip);
            return Redirect("ChangePost");            
        }
        [Route("TaiPortImage")]
        public IActionResult ImageUpload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                var file1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImagePost", fileName);
                file.CopyToAsync(new FileStream(file1, FileMode.Create));
                postImg = "/ImagePost/" + fileName;
                return Redirect("AddPost");
            }
            else
            {
                return View("AddPost");
            }
        }

        [Route("ChangePortImage")]
        public IActionResult ImageUpload2(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                var file1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImagePost", fileName);
                file.CopyToAsync(new FileStream(file1, FileMode.Create));
                postImg = "/ImagePost/" + fileName;
                return Redirect("ChangePost");
            }
            else
            {
                return View("ChangePost");
            }
        }
    }
}