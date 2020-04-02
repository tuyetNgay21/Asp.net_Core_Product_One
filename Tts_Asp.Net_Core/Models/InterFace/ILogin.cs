using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
    public interface ILogin
    {
        IEnumerable<IsLogin> GetIsThemes();
        IsLogin GetIsTheme(string Account);
        void Add(IsLogin _Th);
        void Edit(IsLogin _Th);
        void Remove(int id);
    }
}
