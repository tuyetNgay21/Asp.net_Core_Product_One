using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
  public  interface IMenuTop1
    {
        IEnumerable<MenuTop1> GetIsThemes();
        MenuTop1 GetIsTheme(string Account);
        void Add(MenuTop1 _Th);
        void Edit(MenuTop1 _Th);
        void Remove(int id);
    }
}
