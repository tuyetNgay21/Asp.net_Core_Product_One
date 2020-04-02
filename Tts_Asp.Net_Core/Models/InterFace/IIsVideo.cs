using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
    public interface IIsVideo
    {
        IEnumerable<IsVideo> GetIsThemes();
        IsVideo GetIsTheme(string Account);
        void Add(IsVideo _Th);
        void Edit(IsVideo _Th);
        void Remove(int id);
    }
}
