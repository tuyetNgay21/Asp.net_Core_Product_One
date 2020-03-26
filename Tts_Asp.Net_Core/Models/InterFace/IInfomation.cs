using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
   public  interface IInfomation
    {
        IEnumerable<Infomation> GetIsThemes();
        Infomation GetIsTheme(string Account);
        void Add(Infomation _Th);
        void Remove(int id);
    }
}
