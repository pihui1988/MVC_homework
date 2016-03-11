using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_homwork.Models
{
    public class 客戶資料ViewModel
    {
        [Required(ErrorMessage="客戶名稱為必填欄位")]
        public string 客戶名稱 { get; set; }

        [Required(ErrorMessage="統一編號為必填欄位")]
        [MaxLength(8, ErrorMessage="統一編號最多8碼")]
        public string 統一編號 { get; set; }

        [Required(ErrorMessage="電話為必填欄位")]
        [RegularExpression(@"[0-9]{2}\-[0-9]{7}", ErrorMessage="請輸入正確格式(02-1234567)")]
        public string 電話 { get; set; }

        public string 傳真 { get; set; }

        public string 地址 { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage="請輸入正確的電子信箱")]
        public string Email { get; set; }
    }
}