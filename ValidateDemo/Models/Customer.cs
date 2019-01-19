using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Models
{
    [Serializable]
    public class Customer
    {
        [DisplayName("账号")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string LoginId { get; set; }

        [DisplayName("密码")]
        [Required(ErrorMessage = "{0}不得为空")]
        [StringLength(18, MinimumLength = 6, ErrorMessage = "{0}长度必须在{2}和{1}之间")]
        public string LoginPwd { get; set; }

        [DisplayName("重复密码")]
        [Required(ErrorMessage = "{0}不得为空")]
        [Compare("LoginPwd", ErrorMessage = "两次输入密码不一致")]
        public string PasswordConfirm { get; set; }

        [DisplayName("姓名")]
        [Required(ErrorMessage = "{0}不能为空")]
        public string Name { get; set; }

        [DisplayName("年龄")]
        [Required(ErrorMessage = "{0}不得为空")]
        [Range(18, 60, ErrorMessage = "{0}必须在{1}和{2}之间")]
        public int? Age { get; set; }

        [DisplayName("地址")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Address { get; set; }

        [DisplayName("手机号")]
        [Required(ErrorMessage = "{0}不得为空")]
        public string Phone { get; set; }

        public string Email { get; set; }

    }
}
