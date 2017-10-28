using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneCenter.Models.ViewModels.Admin
{
    /// <summary>
    /// 管理者ViewModel
    /// </summary>
    public class AdminViewModel
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }
    }
}