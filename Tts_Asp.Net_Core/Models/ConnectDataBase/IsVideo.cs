using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class IsVideo
    {
        public int VideoId { get; set; }
        public string Title { get; set; }
        public DateTime DayInPost { get; set; }
        public string VideoIndex { get; set; }
        public string Content { get; set; }
        public int? ViewPost { get; set; }
        public bool Deleted { get; set; }
        public int? SpeciesId { get; set; }

        public virtual IsSpecies Species { get; set; }
    }
}
