using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tts_Asp.Net_Core.Models.Check;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.Repository;

namespace Tts_Asp.Net_Core.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {          
            return View();
        }
        public IActionResult AddAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAccount(IsLogin Ba)//  create account new  method post , user click will send data to server
        {
            CLogin lo = new CLogin();

            if(lo.checkAddAccount(Ba)==true)
            {
                return RedirectToAction("Index");
                
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản đã tồn tại hoặc có lỗi sảy ra!!!");
                return View();
            }
        }

        public IActionResult Index(IsLogin Ba)
        {
            var ck = new CLogin().checkLoginAcc(Ba);
            if(ck==0)//tai khoan khong xacs dinh
            {
                ModelState.AddModelError("", "Tài khoản đã tồn tại!!!");
                return View();
            }
            else if(ck==1)// mat khau khong chinh xacs
            {
                ModelState.AddModelError("", "Mật khuẩu không chính xác!!!");
                return View();
            }
            else if (ck==2)//tai khoan da xoa
            {
                ModelState.AddModelError("", "Tài khoản đã xóa!!!");
                return View();
            }
            else if (ck==3)// nguoi dung
            {
                return RedirectToAction("Index", "Home");
            }
            else if (ck==4)// admin
            {
                return RedirectToAction("Index", "Home");
            }
            else //loi ky thuat
            {
                ModelState.AddModelError("", "Có biến rồi đại vương!!!");
                return View();
            }
            return View();
        }

    }
}