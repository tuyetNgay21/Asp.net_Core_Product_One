using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
   public interface IIsAdmin
    {
        IEnumerable<IsAdmin> GetIsThemes();
        IsAdmin GetIsTheme(string Account);
        void Add(IsAdmin _Th);
        void Edit(IsAdmin _Th);
        void Remove(int id);
    }
}
