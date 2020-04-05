using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.InterFace;

namespace Tts_Asp.Net_Core.Models.Repository
{
    public class RLogin : ILogin
    {
        private readonly TTS_ASP_CoreContext dbLogin = new TTS_ASP_CoreContext();
        public IEnumerable<IsLogin> GetIsLogins()
        {
            try
            {
                IEnumerable<IsLogin> lg = dbLogin.IsLogin;
                return lg;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public void Add(IsLogin _LG)
        {
            try
            {
                dbLogin.IsLogin.Add(_LG);
                dbLogin.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public IsLogin GetIsLogin(string Account)
        {
            try
            {
                IsLogin lo = dbLogin.IsLogin.Find(Account);
                return lo;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void Edit(IsLogin _Th)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void EditDelete(string _Th)
        {
            try
            {
                var lo = dbLogin.IsLogin.Where(m => m.Account == _Th).FirstOrDefault();
                if(lo.Deleted==true)
                {
                    lo.Deleted = false;
                }
                else
                {
                    lo.Deleted = true;
                }
                dbLogin.SaveChanges();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void EditQuyen(string _Th)
        {
            var lo = dbLogin.IsLogin.Where(m => m.Account == _Th).FirstOrDefault();
            if (lo.Decentralization == true)
            {
                lo.Decentralization = false;
            }
            else
            {
                lo.Decentralization = true;
            }
            dbLogin.SaveChanges();
        }
    }
}
