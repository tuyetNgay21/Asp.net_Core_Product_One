using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class Infomation
    {
        public string InfomationId { get; set; }
        public string IsName { get; set; }
        public int IsAge { get; set; }
        public string IsAddress { get; set; }
        public decimal IsPhone { get; set; }
        public bool Deleted { get; set; }

        public virtual IsLogin InfomationNavigation { get; set; }
    }
}
