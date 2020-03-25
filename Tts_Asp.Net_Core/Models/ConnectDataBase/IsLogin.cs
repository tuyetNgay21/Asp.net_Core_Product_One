using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class IsLogin
    {
        public string Account { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Passwork { get; set; }
        public string HaskPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool Deleted { get; set; }
        public bool Decentralization { get; set; }
    }
}
