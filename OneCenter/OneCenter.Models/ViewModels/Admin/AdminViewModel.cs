using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// 序號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 帳號
        /// </summary>
        [Required(ErrorMessage = "必要欄位")] // 驗證必填欄位屬性
        [StringLength(5, ErrorMessage = "最大5個字")] //驗證字串長度屬性
                                                  // [Range(1,5,ErrorMessage = "範圍必須介於1~5之間")] // 驗證數字範圍屬性
                                                  // [CustomValidation] 客製化驗證屬性
                                                  // [CompareAttribute("要比較的屬性名稱",ErrorMessage = "不相同")] 驗證兩個屬性

        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        [Required(ErrorMessage = "必要欄位")]
        public string Password { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        [Required(ErrorMessage = "必要欄位")]
        public string Name { get; set; }
    }
}