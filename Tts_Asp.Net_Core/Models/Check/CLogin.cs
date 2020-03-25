using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.Check
{
    public class CLogin
    {
        public bool checkAddAccount(IsLogin Ba)
        {
            //not using ModelState.IsValid because it is have haskpass , user not create

            if (Ba.Account==null || Ba.Passwork==null || Ba.Email==null )
            {
                return false;
            }
            else
            {

            }
            return true;
        }
    }
}
