﻿using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class IsTheme
    {
        public IsTheme()
        {
            IsSpecies = new HashSet<IsSpecies>();
        }

        public int ThemeId { get; set; }
        public string Isname { get; set; }
        public string IsTitle { get; set; }
        public bool Deleted { get; set; }
        public string AvatarTheme { get; set; }

        public virtual ICollection<IsSpecies> IsSpecies { get; set; }
    }
}
