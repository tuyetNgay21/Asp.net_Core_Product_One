using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.InterFace;

namespace Tts_Asp.Net_Core.Models.Repository
{
    public class RIsNavbar : IIsNavbar
    {
        private readonly TTS_ASP_CoreContext dbIsNavbar = new TTS_ASP_CoreContext();
        public void Add(IsNavbar _Th)
        {            
            try
            {
                var kk = dbIsNavbar.IsNavbar.Where(m => m.Deleted == true).ToList();
                if(kk.Count!=0)
                { 
                    foreach (var k in kk)
                    {
                        k.Deleted = false;
                    }
                }
                
                dbIsNavbar.SaveChanges();

                IsNavbar nav = _Th;
                nav.Deleted = true;
                dbIsNavbar.Add(nav);
                dbIsNavbar.SaveChanges();                
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void Edit(IsNavbar _Th)
        {
            throw new NotImplementedException();
        }

        public IsNavbar GetIsTheme()
        {
            try
            {
                return dbIsNavbar.IsNavbar.Where(m => m.Deleted==true).FirstOrDefault();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IsNavbar> GetIsThemes()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
