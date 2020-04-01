using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.InterFace;

namespace Tts_Asp.Net_Core.Models.Repository
{
    public class RIsSpecies : IIsSpecies
    {
        private readonly TTS_ASP_CoreContext dbs = new TTS_ASP_CoreContext();
        public void Add(IsSpecies _Th)
        {
            try
            {                
                dbs.IsSpecies.Add(_Th);
                dbs.SaveChanges();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
           
        }

        public void Edit(IsSpecies _Th)
        {
            try
            {
                IsSpecies thi = dbs.IsSpecies.Where(m => m.ThemeId == _Th.ThemeId).FirstOrDefault();
                thi.IsTitle = _Th.IsTitle;
                thi.Isname = _Th.Isname;
                thi.AvatarSpecies = _Th.AvatarSpecies;
                thi.ThemeId = _Th.ThemeId;
                dbs.SaveChanges();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public IsSpecies GetIsTheme(string Account)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IsSpecies> GetIsThemes()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            try
            {
                var a = dbs.IsSpecies.Where(m => m.ThemeId == id).FirstOrDefault();
                dbs.IsSpecies.Remove(a);
                dbs.SaveChanges();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
