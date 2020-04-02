using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class IsAdmin
    {
        public int AdminId { get; set; }
        public string Logo { get; set; }
        public int? MenuFooterid1 { get; set; }
        public int? MenuFooterid2 { get; set; }
        public int? MenuFooterid3 { get; set; }
        public int? MenuTopId2 { get; set; }
        public int? MenuTopId1 { get; set; }

        public virtual MenuFooter MenuFooterid1Navigation { get; set; }
        public virtual MenuFooter MenuFooterid2Navigation { get; set; }
        public virtual MenuFooter MenuFooterid3Navigation { get; set; }
        public virtual MenuTop1 MenuTopId1Navigation { get; set; }
        public virtual MenuTop2 MenuTopId2Navigation { get; set; }
    }
}
