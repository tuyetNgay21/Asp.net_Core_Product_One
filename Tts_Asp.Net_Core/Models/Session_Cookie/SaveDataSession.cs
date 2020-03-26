using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tts_Asp.Net_Core.Models.Session_Cookie
{
    public class SaveDataSession
    {
        public string account { get; set; }
        public DateTime last = DateTime.Now;
        public bool Quyen { get; set; }
    }
}
