using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModel
{
    public class UserLoginView
    {
        [Display(Name = "用户编号")]
        public int UserID { get; set; }
        

        [Required]
        [Display(Name = "密码")]
        [MaxLength(64)]
        public string UserPassword { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }
}
