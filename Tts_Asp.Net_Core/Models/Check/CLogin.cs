using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.Repository;
using Tts_Asp.Net_Core.Models.Security;

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
                try
                {
                    string hask = HaskPass.create_Hask();
                    string securityPass = MD5.MD5Hash(Ba.Passwork.ToString() + hask).Trim();
                    //create one class account 
                    var LoginNew = new IsLogin();
                    LoginNew.Account = Ba.Account.Trim();
                    LoginNew.Passwork = securityPass;
                    LoginNew.Email = Ba.Email.Trim();
                    LoginNew.HaskPassword = hask.Trim();
                    LoginNew.Decentralization = false;
                    LoginNew.Deleted = false;
                    //  now create acc and add database
                    RLogin lo = new RLogin();
                    lo.Add(LoginNew);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }               
            }
        }

        public int checkLoginAcc(IsLogin lo)
        {
           var log= new RLogin().GetIsLogin(lo.Account);
            
            if (log==null)//tai khoan khong chinh xac
            {
                return 0;
            }
            else 
            {
                string securityPass = MD5.MD5Hash(lo.Passwork.ToString() + log.HaskPassword).Trim();
                if (log.Passwork.Trim()==securityPass.Trim())
                {
                    if (log.Deleted == false)
                    {
                        if (log.Decentralization == false)
                        {
                            return 3;// nguoi dung binh thuong
                        }
                        else
                        {
                            return 4;//la admin
                        }
                    }
                    else
                    {
                        return 2;//tai khoan da xoa
                    }
                    
                }
                else
                {
                    return 1;//mat khau khong chinh xac
                }

            }
        }
    }
}
