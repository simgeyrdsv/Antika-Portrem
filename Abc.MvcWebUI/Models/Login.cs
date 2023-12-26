using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı adınız")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}