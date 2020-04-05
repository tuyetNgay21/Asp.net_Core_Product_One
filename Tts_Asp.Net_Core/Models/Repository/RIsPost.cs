using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;
using Tts_Asp.Net_Core.Models.InterFace;

namespace Tts_Asp.Net_Core.Models.Repository
{
    public class RIsPost : IIsPost
    {
        private readonly TTS_ASP_CoreContext dbPost = new TTS_ASP_CoreContext();        
        public void Add(IsPost _Th)
        {
            try
            {
                dbPost.IsPost.Add(_Th);
                dbPost.SaveChanges();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public void Edit(IsPost _Th)
        {
            try
            {
                var It = dbPost.IsPost.Where(m => m.PostId == _Th.PostId).FirstOrDefault();
                It.Content = _Th.Content;
                It.DayInPost = DateTime.Now;
                It.AvataIndex = _Th.AvataIndex;
                It.Title = _Th.Title;
                It.Deleted = _Th.Deleted;
                It.SpeciesId = _Th.SpeciesId;
                It.ViewPost = _Th.ViewPost;
                dbPost.SaveChanges();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public IsPost GetIsTheme(string Account)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IsPost> GetIsThemes()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
