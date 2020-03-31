using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
    public interface IIsTheme
    {
        IEnumerable<IsTheme> GetIsThemes();
        IsTheme GetIsTheme(string Account);
        void Add(IsTheme _Th);
        void Edit(IsTheme _Th);
        void Remove(int id);
    }
}
