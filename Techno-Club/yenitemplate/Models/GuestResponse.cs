using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yenitemplate.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Lütfen bilgi girişi yapınız!")]
        public string name { get; set; }

        [Required(ErrorMessage = "Lütfen bilgi girişi yapınız!")]
        [EmailAddress, Key]
        public string email { get; set; }

        [Required(ErrorMessage = "Lütfen bilgi girişi yapınız!")]
        public string Message { get; set; }

    } 
    
}
