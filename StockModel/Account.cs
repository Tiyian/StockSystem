using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModel
{
    public class UserInfo
    {
        [Key]
        [Display(Name = "用户编号")]
        public int UserID { get; set; }


        [Required]
        [Display(Name ="用户名")]
        [MaxLength(16)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "电子邮件")]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        [MaxLength(64)]
        public string UserPassword { get; set; }

        [Required]
        public short UserAge { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }

}
