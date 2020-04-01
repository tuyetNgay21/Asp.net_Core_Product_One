using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
   public interface IIsSpecies
    {
        IEnumerable<IsSpecies> GetIsThemes();
        IsSpecies GetIsTheme(string Account);
        void Add(IsSpecies _Th);
        void Edit(IsSpecies _Th);
        void Remove(int id);
    }
}
