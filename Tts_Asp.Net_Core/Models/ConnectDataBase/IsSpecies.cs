using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class IsSpecies
    {
        public IsSpecies()
        {
            IsPost = new HashSet<IsPost>();
        }

        public int SpeciesId { get; set; }
        public string Isname { get; set; }
        public string IsTitle { get; set; }
        public string AvatarSpecies { get; set; }
        public int? ThemeId { get; set; }

        public virtual IsTheme Theme { get; set; }
        public virtual ICollection<IsPost> IsPost { get; set; }
    }
}
