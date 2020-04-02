using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
   public  interface IIsPost
    {
        IEnumerable<IsPost> GetIsThemes();
        IsPost GetIsTheme(string Account);
        void Add(IsPost _Th);
        void Edit(IsPost _Th);
        void Remove(int id);
    }
}
