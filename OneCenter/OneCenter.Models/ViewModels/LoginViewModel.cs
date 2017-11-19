using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.Models.ViewModels.Auth
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "請輸入帳號")]
        public string Account { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "請輸入密碼")]
        public string Password { get; set; }
    }
}