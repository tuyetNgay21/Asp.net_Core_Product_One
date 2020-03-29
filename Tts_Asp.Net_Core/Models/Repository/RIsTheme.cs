using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.InterFace;

namespace Tts_Asp.Net_Core.Models.Repository
{
    public class RIsTheme : IIsTheme
    {
        private readonly TTS_ASP_CoreContext db;
        public RIsTheme()
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
        public void Add(IsTheme _Th)
        {
            try
            {
                db.IsTheme.Add(_Th);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public IsTheme GetIsTheme(string Account)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IsTheme> GetIsThemes()
        {
            try
            {
                IEnumerable<IsTheme> lg = db.IsTheme;
                return lg;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
