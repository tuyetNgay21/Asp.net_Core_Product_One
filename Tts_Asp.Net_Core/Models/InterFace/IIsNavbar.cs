using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tts_Asp.Net_Core.Models.ConnectDataBase;

namespace Tts_Asp.Net_Core.Models.InterFace
{
   public interface IIsNavbar
    {
        IEnumerable<IsNavbar> GetIsThemes();
        IsNavbar GetIsTheme();
        void Add(IsNavbar _Th);
        void Edit(IsNavbar _Th);
        void Remove(int id);
    }
}
