using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class DangnhapModel
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập Username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Chức Danh")]
        [Display(Name = "Chức Danh")]
        public string Chucdanh{ get; set; }

    }
}
