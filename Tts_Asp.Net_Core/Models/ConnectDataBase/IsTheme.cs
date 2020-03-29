using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class IsTheme
    {
        public IsTheme()
        {
            IsSpecies = new HashSet<IsSpecies>();
        }
        [Key]
        public int ThemeId { get; set; }

        [StringLength(50)]
        public string Isname { get; set; }

        [StringLength(50)]
        public string IsTitle { get; set; }

        [StringLength(300)]
        public string AvatarTheme { get; set; }

        public virtual ICollection<IsSpecies> IsSpecies { get; set; }
    }
}
