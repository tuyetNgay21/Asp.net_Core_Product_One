using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models
{
    public partial class IsLogin
    {
        public string Account { get; set; }
        public string Passwork { get; set; }
        public string HaskPassword { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }
        public bool Decentralization { get; set; }
    }
}
