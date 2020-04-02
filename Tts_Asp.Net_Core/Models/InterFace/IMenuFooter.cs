using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
   public interface IMenuFooter
    {
        IEnumerable<MenuFooter> GetIsThemes();
        MenuFooter GetIsTheme(string Account);
        void Add(MenuFooter _Th);
        void Edit(MenuFooter _Th);
        void Remove(int id);
    }
}
