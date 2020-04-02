using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class MenuTop2
    {
        public MenuTop2()
        {
            IsAdmin = new HashSet<IsAdmin>();
        }

        public int MenuTopId2 { get; set; }
        public string Section1 { get; set; }
        public string LinkMenu1 { get; set; }
        public string Section2 { get; set; }
        public string LinkMenu2 { get; set; }
        public string Section3 { get; set; }
        public string LinkMenu3 { get; set; }
        public string Section4 { get; set; }
        public string LinkMenu4 { get; set; }
        public string Section5 { get; set; }
        public string LinkMenu5 { get; set; }
        public string Section6 { get; set; }
        public string LinkMenu6 { get; set; }
        public string Section7 { get; set; }
        public string LinkMenu7 { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateUpdate { get; set; }

        public virtual ICollection<IsAdmin> IsAdmin { get; set; }
    }
}
