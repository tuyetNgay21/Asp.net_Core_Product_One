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
        void Add(IsLogin _Th);
        void Edit(IsLogin _Th);
        void EditDelete(string _Th);
        void EditQuyen(string _Th);
        void Remove(int id);
    }
}
