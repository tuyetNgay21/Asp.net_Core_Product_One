using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
  public interface IMenuTop2
    {
        IEnumerable<MenuTop2> GetIsThemes();
        MenuTop2 GetIsTheme(string Account);
        void Add(MenuTop2 _Th);
        void Edit(MenuTop2 _Th);
        void Remove(int id);
    }
}
