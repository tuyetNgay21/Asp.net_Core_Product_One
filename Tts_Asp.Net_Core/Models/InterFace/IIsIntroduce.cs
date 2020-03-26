using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
    public interface IIsIntroduce
    {
        IEnumerable<IsIntroduce> GetIsThemes();
        IsIntroduce GetIsTheme(string Account);
        void Add(IsIntroduce _Th);
        void Remove(int id);
    }
}
