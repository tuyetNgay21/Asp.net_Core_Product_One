using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.Repository;

namespace Tts_Asp.Net_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        [Route("OverviewAccount")]
        public IActionResult OverviewAccount(string lo)
        {
            TTS_ASP_CoreContext db = new TTS_ASP_CoreContext();
            Infomation be = db.Infomation.Where(m => m.InfomationId == lo).FirstOrDefault();
            if (be==null)
            {
                return View();
            }
            else
            {
                return View(lo);
            }            
        }
        [Route("UpDateAdminLogin")]
        public IActionResult UpDateAdminLogin(string lo)
        {
            RLogin r = new RLogin();
            r.EditQuyen(lo);
            return Redirect("OverviewAccount?lo=" + lo + "");
        }
        [Route("UpdateDeleteAccount")]
        public IActionResult UpdateDeleteAccount(string lo)
        {
            RLogin r = new RLogin();
            r.EditDelete(lo);
            return Redirect("OverviewAccount?lo=" + lo + "");
        }
        [Route("EditInfomation")]
        public IActionResult EditInfomation(Infomation lo)
        {
            RInfomation h = new RInfomation();
            h.Edit(lo);
            return Redirect("OverviewAccount?lo="+ lo.InfomationId + "");
        }
        public IActionResult ChangeAccount()
        {
            return View();
        }        
    }
}