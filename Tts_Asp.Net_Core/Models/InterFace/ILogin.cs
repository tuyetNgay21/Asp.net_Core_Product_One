using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
    public interface ILogin
    {
        IEnumerable<IsLogin> GetIsLogins();
        IsLogin GetIsLogin(string Account);
        void Add(IsLogin _LG);
        void Remove(string Account);
    }
}
