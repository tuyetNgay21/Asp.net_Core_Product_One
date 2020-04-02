using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class MenuTop1
    {
        public MenuTop1()
        {
            IsAdmin = new HashSet<IsAdmin>();
        }

        public int MenuTopId1 { get; set; }
        public string Menu1 { get; set; }
        public string LinkMenu1 { get; set; }
        public string Menu2 { get; set; }
        public string LinkMenu2 { get; set; }
        public string Menu3 { get; set; }
        public string LinkMenu3 { get; set; }
        public string Menu4 { get; set; }
        public string LinkMenu4 { get; set; }
        public string Menu5 { get; set; }
        public string LinkMenu5 { get; set; }
        public string Menu6 { get; set; }
        public string LinkMenu6 { get; set; }
        public string Menu7 { get; set; }
        public string LinkMenu7 { get; set; }
        public string Menu8 { get; set; }
        public string LinkMenu8 { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateUpdate { get; set; }

        public virtual ICollection<IsAdmin> IsAdmin { get; set; }
    }
}
