using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tts_Asp.Net_Core.Models.Security
{
    public class HaskPass
    {
        public static string create_Hask()
        {
            string hask = new Random().Next(100000, 999999).ToString();
            return hask;
        }
        
    }
}
