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
        private readonly TTS_ASP_CoreContext db;
        public RLogin()
        {
            try
            {
                db = new TTS_ASP_CoreContext();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public IEnumerable<IsLogin> GetIsLogins()
        {
            try
            {
                IEnumerable<IsLogin> lg = db.IsLogin;
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
                db.IsLogin.Add(_LG);
                db.SaveChanges();
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
                IsLogin lo = db.IsLogin.Find(Account);
                return lo;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public void Remove(string Account)
        {
            throw new NotImplementedException();
        }
    }
}
