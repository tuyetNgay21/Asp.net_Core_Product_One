﻿using System;
using System.Collections.Generic;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class IsIntroduce
    {
        public int IntroduceId { get; set; }
        public string Title { get; set; }
        public DateTime DayInPost { get; set; }
        public string AvataIndex { get; set; }
        public string Content { get; set; }
        public int? ViewPost { get; set; }
        public bool Deleted { get; set; }
    }
}
